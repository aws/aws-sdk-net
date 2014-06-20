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
    public partial class AmazonElasticTranscoderClient : AmazonWebServiceClient, AmazonElasticTranscoder
    {
        AbstractAWSSigner signer = new AWS4Signer();
        
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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonElasticTranscoderClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticTranscoderConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with the credentials loaded from the application's
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
        public AmazonElasticTranscoderClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticTranscoderConfig{RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticTranscoderClient Configuration Object</param>
        public AmazonElasticTranscoderClient(AmazonElasticTranscoderConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

        
        #region  CancelJob


        /// <summary>
        /// The CancelJob operation cancels an unfinished job.
        /// 
        ///         <note>You can only cancel a job that has a status of <code>Submitted</code>.
        /// To prevent a            pipeline from starting to process a job while you're getting
        /// the job identifier, use                <a>UpdatePipelineStatus</a> to temporarily
        /// pause the pipeline.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public CancelJobResponse CancelJob(CancelJobRequest request)
        {
            IAsyncResult asyncResult = invokeCancelJob(request, null, null, true);
            return EndCancelJob(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJob
        ///         operation.</returns>
        public IAsyncResult BeginCancelJob(CancelJobRequest request, AsyncCallback callback, object state)
        {
            return invokeCancelJob(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a  CancelJobResult from ElasticTranscoder.</returns>
        public  CancelJobResponse EndCancelJob(IAsyncResult asyncResult)
        {
            return endOperation< CancelJobResponse>(asyncResult);
        }

        IAsyncResult invokeCancelJob(CancelJobRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CancelJobRequestMarshaller().Marshall(request);
            var unmarshaller = CancelJobResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// When you create a job, Elastic Transcoder returns JSON data that includes the values
        ///            that you specified plus information about the job that is created. 
        /// 
        ///         
        /// <para>
        /// If you have specified more than one output for your jobs (for example, one output
        /// for the            Kindle Fire and another output for the Apple iPhone 4s), you currently
        /// must use the            Elastic Transcoder API to list the jobs (as opposed to the
        /// AWS Console).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds            the maximum allowed.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            IAsyncResult asyncResult = invokeCreateJob(request, null, null, true);
            return EndCreateJob(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        public IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateJob(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from ElasticTranscoder.</returns>
        public  CreateJobResponse EndCreateJob(IAsyncResult asyncResult)
        {
            return endOperation< CreateJobResponse>(asyncResult);
        }

        IAsyncResult invokeCreateJob(CreateJobRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateJobRequestMarshaller().Marshall(request);
            var unmarshaller = CreateJobResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreatePipeline


        /// <summary>
        /// The CreatePipeline operation creates a pipeline with settings that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds            the maximum allowed.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            IAsyncResult asyncResult = invokeCreatePipeline(request, null, null, true);
            return EndCreatePipeline(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipeline
        ///         operation.</returns>
        public IAsyncResult BeginCreatePipeline(CreatePipelineRequest request, AsyncCallback callback, object state)
        {
            return invokeCreatePipeline(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipeline.</param>
        /// 
        /// <returns>Returns a  CreatePipelineResult from ElasticTranscoder.</returns>
        public  CreatePipelineResponse EndCreatePipeline(IAsyncResult asyncResult)
        {
            return endOperation< CreatePipelineResponse>(asyncResult);
        }

        IAsyncResult invokeCreatePipeline(CreatePipelineRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreatePipelineRequestMarshaller().Marshall(request);
            var unmarshaller = CreatePipelineResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  CreatePreset


        /// <summary>
        /// The CreatePreset operation creates a preset with settings that you specify.
        /// 
        ///         <important>Elastic Transcoder checks the CreatePreset settings to ensure that
        /// they meet Elastic Transcoder requirements            and to determine whether they
        /// comply with H.264 standards. If your settings are not            valid for Elastic
        /// Transcoder, Elastic Transcoder returns an HTTP 400 response (<code>ValidationException</code>)
        /// and            does not create the preset. If the settings are valid for Elastic Transcoder
        /// but aren't strictly            compliant with the H.264 standard, Elastic Transcoder
        /// creates the preset and returns a warning message            in the response. This
        /// helps you determine whether your settings comply with the H.264            standard
        /// while giving you greater flexibility with respect to the video that Elastic Transcoder
        ///            produces.</important>        
        /// <para>
        /// Elastic Transcoder uses the H.264 video-compression format. For more information,
        /// see the International            Telecommunication Union publication <i>Recommendation
        /// ITU-T H.264: Advanced video coding                for generic audiovisual services</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset service method.</param>
        /// 
        /// <returns>The response from the CreatePreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// Too many operations for a given AWS account. For example, the number of pipelines
        /// exceeds            the maximum allowed.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public CreatePresetResponse CreatePreset(CreatePresetRequest request)
        {
            IAsyncResult asyncResult = invokeCreatePreset(request, null, null, true);
            return EndCreatePreset(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePreset operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePreset
        ///         operation.</returns>
        public IAsyncResult BeginCreatePreset(CreatePresetRequest request, AsyncCallback callback, object state)
        {
            return invokeCreatePreset(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePreset.</param>
        /// 
        /// <returns>Returns a  CreatePresetResult from ElasticTranscoder.</returns>
        public  CreatePresetResponse EndCreatePreset(IAsyncResult asyncResult)
        {
            return endOperation< CreatePresetResponse>(asyncResult);
        }

        IAsyncResult invokeCreatePreset(CreatePresetRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreatePresetRequestMarshaller().Marshall(request);
            var unmarshaller = CreatePresetResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeletePipeline


        /// <summary>
        /// The DeletePipeline operation removes a pipeline.
        /// 
        ///         
        /// <para>
        ///  You can only delete a pipeline that has never been used or that is not currently
        /// in use            (doesn't contain any active jobs). If the pipeline is currently
        /// in use,                <code>DeletePipeline</code> returns an error. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            IAsyncResult asyncResult = invokeDeletePipeline(request, null, null, true);
            return EndDeletePipeline(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePipeline
        ///         operation.</returns>
        public IAsyncResult BeginDeletePipeline(DeletePipelineRequest request, AsyncCallback callback, object state)
        {
            return invokeDeletePipeline(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipeline.</param>
        /// 
        /// <returns>Returns a  DeletePipelineResult from ElasticTranscoder.</returns>
        public  DeletePipelineResponse EndDeletePipeline(IAsyncResult asyncResult)
        {
            return endOperation< DeletePipelineResponse>(asyncResult);
        }

        IAsyncResult invokeDeletePipeline(DeletePipelineRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeletePipelineRequestMarshaller().Marshall(request);
            var unmarshaller = DeletePipelineResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  DeletePreset


        /// <summary>
        /// The DeletePreset operation removes a preset that you've added in an AWS region.
        /// 
        ///         <note>            
        /// <para>
        /// You can't delete the default presets that are included with Elastic Transcoder.
        /// </para>
        ///         </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset service method.</param>
        /// 
        /// <returns>The response from the DeletePreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public DeletePresetResponse DeletePreset(DeletePresetRequest request)
        {
            IAsyncResult asyncResult = invokeDeletePreset(request, null, null, true);
            return EndDeletePreset(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePreset operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePreset
        ///         operation.</returns>
        public IAsyncResult BeginDeletePreset(DeletePresetRequest request, AsyncCallback callback, object state)
        {
            return invokeDeletePreset(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePreset.</param>
        /// 
        /// <returns>Returns a  DeletePresetResult from ElasticTranscoder.</returns>
        public  DeletePresetResponse EndDeletePreset(IAsyncResult asyncResult)
        {
            return endOperation< DeletePresetResponse>(asyncResult);
        }

        IAsyncResult invokeDeletePreset(DeletePresetRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeletePresetRequestMarshaller().Marshall(request);
            var unmarshaller = DeletePresetResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ListJobsByPipeline


        /// <summary>
        /// The ListJobsByPipeline operation gets a list of the jobs currently in a pipeline.
        /// 
        ///         
        /// <para>
        /// Elastic Transcoder returns all of the jobs currently in the specified pipeline. The
        ///            response body contains one element for each job that satisfies the search
        /// criteria.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline service method.</param>
        /// 
        /// <returns>The response from the ListJobsByPipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ListJobsByPipelineResponse ListJobsByPipeline(ListJobsByPipelineRequest request)
        {
            IAsyncResult asyncResult = invokeListJobsByPipeline(request, null, null, true);
            return EndListJobsByPipeline(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByPipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobsByPipeline
        ///         operation.</returns>
        public IAsyncResult BeginListJobsByPipeline(ListJobsByPipelineRequest request, AsyncCallback callback, object state)
        {
            return invokeListJobsByPipeline(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobsByPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobsByPipeline.</param>
        /// 
        /// <returns>Returns a  ListJobsByPipelineResult from ElasticTranscoder.</returns>
        public  ListJobsByPipelineResponse EndListJobsByPipeline(IAsyncResult asyncResult)
        {
            return endOperation< ListJobsByPipelineResponse>(asyncResult);
        }

        IAsyncResult invokeListJobsByPipeline(ListJobsByPipelineRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListJobsByPipelineRequestMarshaller().Marshall(request);
            var unmarshaller = ListJobsByPipelineResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ListJobsByStatus


        /// <summary>
        /// The ListJobsByStatus operation gets a list of jobs that have a specified status. The
        ///            response body contains one element for each job that satisfies the search
        /// criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus service method.</param>
        /// 
        /// <returns>The response from the ListJobsByStatus service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ListJobsByStatusResponse ListJobsByStatus(ListJobsByStatusRequest request)
        {
            IAsyncResult asyncResult = invokeListJobsByStatus(request, null, null, true);
            return EndListJobsByStatus(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByStatus operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobsByStatus
        ///         operation.</returns>
        public IAsyncResult BeginListJobsByStatus(ListJobsByStatusRequest request, AsyncCallback callback, object state)
        {
            return invokeListJobsByStatus(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobsByStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobsByStatus.</param>
        /// 
        /// <returns>Returns a  ListJobsByStatusResult from ElasticTranscoder.</returns>
        public  ListJobsByStatusResponse EndListJobsByStatus(IAsyncResult asyncResult)
        {
            return endOperation< ListJobsByStatusResponse>(asyncResult);
        }

        IAsyncResult invokeListJobsByStatus(ListJobsByStatusRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListJobsByStatusRequestMarshaller().Marshall(request);
            var unmarshaller = ListJobsByStatusResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ListPipelines

        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS            account.
        /// </summary>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ListPipelinesResponse ListPipelines()
        {
            return ListPipelines(new ListPipelinesRequest());
        }

        /// <summary>
        /// The ListPipelines operation gets a list of the pipelines associated with the current
        /// AWS            account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            IAsyncResult asyncResult = invokeListPipelines(request, null, null, true);
            return EndListPipelines(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelines
        ///         operation.</returns>
        public IAsyncResult BeginListPipelines(ListPipelinesRequest request, AsyncCallback callback, object state)
        {
            return invokeListPipelines(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelines operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelines.</param>
        /// 
        /// <returns>Returns a  ListPipelinesResult from ElasticTranscoder.</returns>
        public  ListPipelinesResponse EndListPipelines(IAsyncResult asyncResult)
        {
            return endOperation< ListPipelinesResponse>(asyncResult);
        }

        IAsyncResult invokeListPipelines(ListPipelinesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListPipelinesRequestMarshaller().Marshall(request);
            var unmarshaller = ListPipelinesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ListPresets

        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the            presets that you've added in an AWS region.
        /// </summary>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ListPresetsResponse ListPresets()
        {
            return ListPresets(new ListPresetsRequest());
        }

        /// <summary>
        /// The ListPresets operation gets a list of the default presets included with Elastic
        /// Transcoder and the            presets that you've added in an AWS region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPresets service method.</param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ListPresetsResponse ListPresets(ListPresetsRequest request)
        {
            IAsyncResult asyncResult = invokeListPresets(request, null, null, true);
            return EndListPresets(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPresets operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPresets operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPresets
        ///         operation.</returns>
        public IAsyncResult BeginListPresets(ListPresetsRequest request, AsyncCallback callback, object state)
        {
            return invokeListPresets(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPresets operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPresets.</param>
        /// 
        /// <returns>Returns a  ListPresetsResult from ElasticTranscoder.</returns>
        public  ListPresetsResponse EndListPresets(IAsyncResult asyncResult)
        {
            return endOperation< ListPresetsResponse>(asyncResult);
        }

        IAsyncResult invokeListPresets(ListPresetsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListPresetsRequestMarshaller().Marshall(request);
            var unmarshaller = ListPresetsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ReadJob


        /// <summary>
        /// The ReadJob operation returns detailed information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadJob service method.</param>
        /// 
        /// <returns>The response from the ReadJob service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ReadJobResponse ReadJob(ReadJobRequest request)
        {
            IAsyncResult asyncResult = invokeReadJob(request, null, null, true);
            return EndReadJob(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReadJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadJob operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadJob
        ///         operation.</returns>
        public IAsyncResult BeginReadJob(ReadJobRequest request, AsyncCallback callback, object state)
        {
            return invokeReadJob(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ReadJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadJob.</param>
        /// 
        /// <returns>Returns a  ReadJobResult from ElasticTranscoder.</returns>
        public  ReadJobResponse EndReadJob(IAsyncResult asyncResult)
        {
            return endOperation< ReadJobResponse>(asyncResult);
        }

        IAsyncResult invokeReadJob(ReadJobRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReadJobRequestMarshaller().Marshall(request);
            var unmarshaller = ReadJobResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ReadPipeline


        /// <summary>
        /// The ReadPipeline operation gets detailed information about a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline service method.</param>
        /// 
        /// <returns>The response from the ReadPipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ReadPipelineResponse ReadPipeline(ReadPipelineRequest request)
        {
            IAsyncResult asyncResult = invokeReadPipeline(request, null, null, true);
            return EndReadPipeline(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadPipeline
        ///         operation.</returns>
        public IAsyncResult BeginReadPipeline(ReadPipelineRequest request, AsyncCallback callback, object state)
        {
            return invokeReadPipeline(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ReadPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadPipeline.</param>
        /// 
        /// <returns>Returns a  ReadPipelineResult from ElasticTranscoder.</returns>
        public  ReadPipelineResponse EndReadPipeline(IAsyncResult asyncResult)
        {
            return endOperation< ReadPipelineResponse>(asyncResult);
        }

        IAsyncResult invokeReadPipeline(ReadPipelineRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReadPipelineRequestMarshaller().Marshall(request);
            var unmarshaller = ReadPipelineResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  ReadPreset


        /// <summary>
        /// The ReadPreset operation gets detailed information about a preset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset service method.</param>
        /// 
        /// <returns>The response from the ReadPreset service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public ReadPresetResponse ReadPreset(ReadPresetRequest request)
        {
            IAsyncResult asyncResult = invokeReadPreset(request, null, null, true);
            return EndReadPreset(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReadPreset operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadPreset
        ///         operation.</returns>
        public IAsyncResult BeginReadPreset(ReadPresetRequest request, AsyncCallback callback, object state)
        {
            return invokeReadPreset(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ReadPreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadPreset.</param>
        /// 
        /// <returns>Returns a  ReadPresetResult from ElasticTranscoder.</returns>
        public  ReadPresetResponse EndReadPreset(IAsyncResult asyncResult)
        {
            return endOperation< ReadPresetResponse>(asyncResult);
        }

        IAsyncResult invokeReadPreset(ReadPresetRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReadPresetRequestMarshaller().Marshall(request);
            var unmarshaller = ReadPresetResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  TestRole


        /// <summary>
        /// The TestRole operation tests the IAM role used to create the pipeline.
        /// 
        ///         
        /// <para>
        /// The <code>TestRole</code> action lets you determine whether the IAM role you are using
        ///            has sufficient permissions to let Elastic Transcoder perform tasks associated
        /// with the transcoding            process. The action attempts to assume the specified
        /// IAM role, checks read access to the            input and output buckets, and tries
        /// to send a test notification to Amazon SNS topics            that you specify.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRole service method.</param>
        /// 
        /// <returns>The response from the TestRole service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public TestRoleResponse TestRole(TestRoleRequest request)
        {
            IAsyncResult asyncResult = invokeTestRole(request, null, null, true);
            return EndTestRole(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestRole operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRole operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestRole
        ///         operation.</returns>
        public IAsyncResult BeginTestRole(TestRoleRequest request, AsyncCallback callback, object state)
        {
            return invokeTestRole(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  TestRole operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestRole.</param>
        /// 
        /// <returns>Returns a  TestRoleResult from ElasticTranscoder.</returns>
        public  TestRoleResponse EndTestRole(IAsyncResult asyncResult)
        {
            return endOperation< TestRoleResponse>(asyncResult);
        }

        IAsyncResult invokeTestRole(TestRoleRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new TestRoleRequestMarshaller().Marshall(request);
            var unmarshaller = TestRoleResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  UpdatePipeline


        /// <summary>
        /// Use the <code>UpdatePipeline</code> operation to update settings for a pipeline.
        ///                <important>When you change pipeline settings, your changes take effect
        /// immediately.                Jobs that you have already submitted and that Elastic
        /// Transcoder has not started to process are                affected in addition to jobs
        /// that you submit after you change settings. </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            IAsyncResult asyncResult = invokeUpdatePipeline(request, null, null, true);
            return EndUpdatePipeline(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipeline
        ///         operation.</returns>
        public IAsyncResult BeginUpdatePipeline(UpdatePipelineRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdatePipeline(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipeline.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineResult from ElasticTranscoder.</returns>
        public  UpdatePipelineResponse EndUpdatePipeline(IAsyncResult asyncResult)
        {
            return endOperation< UpdatePipelineResponse>(asyncResult);
        }

        IAsyncResult invokeUpdatePipeline(UpdatePipelineRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdatePipelineRequestMarshaller().Marshall(request);
            var unmarshaller = UpdatePipelineResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  UpdatePipelineNotifications


        /// <summary>
        /// With the UpdatePipelineNotifications operation, you can update Amazon Simple Notification
        /// Service (Amazon SNS)            notifications for a pipeline.
        /// 
        ///         
        /// <para>
        /// When you update notifications for a pipeline, Elastic Transcoder returns the values
        /// that you specified            in the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications service method.</param>
        /// 
        /// <returns>The response from the UpdatePipelineNotifications service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public UpdatePipelineNotificationsResponse UpdatePipelineNotifications(UpdatePipelineNotificationsRequest request)
        {
            IAsyncResult asyncResult = invokeUpdatePipelineNotifications(request, null, null, true);
            return EndUpdatePipelineNotifications(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineNotifications operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineNotifications operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipelineNotifications
        ///         operation.</returns>
        public IAsyncResult BeginUpdatePipelineNotifications(UpdatePipelineNotificationsRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdatePipelineNotifications(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipelineNotifications operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipelineNotifications.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineNotificationsResult from ElasticTranscoder.</returns>
        public  UpdatePipelineNotificationsResponse EndUpdatePipelineNotifications(IAsyncResult asyncResult)
        {
            return endOperation< UpdatePipelineNotificationsResponse>(asyncResult);
        }

        IAsyncResult invokeUpdatePipelineNotifications(UpdatePipelineNotificationsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdatePipelineNotificationsRequestMarshaller().Marshall(request);
            var unmarshaller = UpdatePipelineNotificationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
        #region  UpdatePipelineStatus


        /// <summary>
        /// The UpdatePipelineStatus operation pauses or reactivates a pipeline, so that the pipeline
        ///            stops or restarts the processing of jobs.
        /// 
        ///         
        /// <para>
        /// Changing the pipeline status is useful if you want to cancel one or more jobs. You
        /// can't            cancel jobs after Elastic Transcoder has started processing them;
        /// if you pause the pipeline to which            you submitted the jobs, you have more
        /// time to get the job IDs for the jobs that you want            to cancel, and to send
        /// a <a>CancelJob</a> request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus service method.</param>
        /// 
        /// <returns>The response from the UpdatePipelineStatus service method, as returned by ElasticTranscoder.</returns>
        /// <exception cref="AccessDeniedException">
        /// General authentication failure. The request was not signed correctly.
        /// </exception>
        /// <exception cref="IncompatibleVersionException">
        /// 
        /// </exception>
        /// <exception cref="InternalServiceException">
        /// Elastic Transcoder encountered an unexpected exception while trying to fulfill the
        /// request.
        /// </exception>
        /// <exception cref="ResourceInUseException">
        /// The resource you are attempting to change is in use. For example, you are attempting
        /// to            delete a pipeline that is currently in use.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The requested resource does not exist or is not available. For example, the pipeline
        /// to            which you're trying to add a job doesn't exist or is still being created.
        /// </exception>
        /// <exception cref="ValidationException">
        /// One or more required parameter values were not provided in the request.
        /// </exception>
        public UpdatePipelineStatusResponse UpdatePipelineStatus(UpdatePipelineStatusRequest request)
        {
            IAsyncResult asyncResult = invokeUpdatePipelineStatus(request, null, null, true);
            return EndUpdatePipelineStatus(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipelineStatus operation on AmazonElasticTranscoderClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipelineStatus
        ///         operation.</returns>
        public IAsyncResult BeginUpdatePipelineStatus(UpdatePipelineStatusRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdatePipelineStatus(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipelineStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipelineStatus.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineStatusResult from ElasticTranscoder.</returns>
        public  UpdatePipelineStatusResponse EndUpdatePipelineStatus(IAsyncResult asyncResult)
        {
            return endOperation< UpdatePipelineStatusResponse>(asyncResult);
        }

        IAsyncResult invokeUpdatePipelineStatus(UpdatePipelineStatusRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdatePipelineStatusRequestMarshaller().Marshall(request);
            var unmarshaller = UpdatePipelineStatusResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
    }
}