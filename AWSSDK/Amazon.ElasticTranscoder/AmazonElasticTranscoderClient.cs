/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Implementation for accessing AmazonElasticTranscoder.
    ///  
    /// AWS Elastic Transcoder Service <para>The AWS Elastic Transcoder Service.</para>
    /// </summary>
    public class AmazonElasticTranscoderClient : AmazonWebServiceClient, AmazonElasticTranscoder
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticTranscoderConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
        /// <param name="config">The AmazonElasticTranscoder Configuration Object</param>
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
            : this(credentials, new AmazonElasticTranscoderConfig(){RegionEndpoint=region})
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
        /// AmazonElasticTranscoderClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticTranscoderConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticTranscoderClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
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
   
        #region UpdatePipelineStatus

        /// <summary>
        /// <para>The UpdatePipelineStatus operation pauses or reactivates a pipeline, so that the pipeline stops or restarts the processing of
        /// jobs.</para> <para>Changing the pipeline status is useful if you want to cancel one or more jobs. You can't cancel jobs after Elastic
        /// Transcoder has started processing them; if you pause the pipeline to which you submitted the jobs, you have more time to get the job IDs for
        /// the jobs that you want to cancel, and to send a CancelJob request. </para>
        /// </summary>
        /// 
        /// <param name="updatePipelineStatusRequest">Container for the necessary parameters to execute the UpdatePipelineStatus service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the UpdatePipelineStatus service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public UpdatePipelineStatusResponse UpdatePipelineStatus(UpdatePipelineStatusRequest updatePipelineStatusRequest)
        {
            IAsyncResult asyncResult = invokeUpdatePipelineStatus(updatePipelineStatusRequest, null, null, true);
            return EndUpdatePipelineStatus(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.UpdatePipelineStatus"/>
        /// </summary>
        /// 
        /// <param name="updatePipelineStatusRequest">Container for the necessary parameters to execute the UpdatePipelineStatus operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdatePipelineStatus operation.</returns>
        public IAsyncResult BeginUpdatePipelineStatus(UpdatePipelineStatusRequest updatePipelineStatusRequest, AsyncCallback callback, object state)
        {
            return invokeUpdatePipelineStatus(updatePipelineStatusRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdatePipelineStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.UpdatePipelineStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipelineStatus.</param>
        /// 
        /// <returns>Returns a UpdatePipelineStatusResult from AmazonElasticTranscoder.</returns>
        public UpdatePipelineStatusResponse EndUpdatePipelineStatus(IAsyncResult asyncResult)
        {
            return endOperation<UpdatePipelineStatusResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdatePipelineStatus(UpdatePipelineStatusRequest updatePipelineStatusRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdatePipelineStatusRequestMarshaller().Marshall(updatePipelineStatusRequest);
            var unmarshaller = UpdatePipelineStatusResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdatePipelineNotifications

        /// <summary>
        /// <para>With the UpdatePipelineNotifications operation, you can update Amazon Simple Notification Service (Amazon SNS) notifications for a
        /// pipeline.</para> <para>When you update notifications for a pipeline, Elastic Transcoder returns the values that you specified in the
        /// request.</para>
        /// </summary>
        /// 
        /// <param name="updatePipelineNotificationsRequest">Container for the necessary parameters to execute the UpdatePipelineNotifications service
        ///          method on AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the UpdatePipelineNotifications service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public UpdatePipelineNotificationsResponse UpdatePipelineNotifications(UpdatePipelineNotificationsRequest updatePipelineNotificationsRequest)
        {
            IAsyncResult asyncResult = invokeUpdatePipelineNotifications(updatePipelineNotificationsRequest, null, null, true);
            return EndUpdatePipelineNotifications(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipelineNotifications operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.UpdatePipelineNotifications"/>
        /// </summary>
        /// 
        /// <param name="updatePipelineNotificationsRequest">Container for the necessary parameters to execute the UpdatePipelineNotifications operation
        ///          on AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdatePipelineNotifications operation.</returns>
        public IAsyncResult BeginUpdatePipelineNotifications(UpdatePipelineNotificationsRequest updatePipelineNotificationsRequest, AsyncCallback callback, object state)
        {
            return invokeUpdatePipelineNotifications(updatePipelineNotificationsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdatePipelineNotifications operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.UpdatePipelineNotifications"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipelineNotifications.</param>
        /// 
        /// <returns>Returns a UpdatePipelineNotificationsResult from AmazonElasticTranscoder.</returns>
        public UpdatePipelineNotificationsResponse EndUpdatePipelineNotifications(IAsyncResult asyncResult)
        {
            return endOperation<UpdatePipelineNotificationsResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdatePipelineNotifications(UpdatePipelineNotificationsRequest updatePipelineNotificationsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdatePipelineNotificationsRequestMarshaller().Marshall(updatePipelineNotificationsRequest);
            var unmarshaller = UpdatePipelineNotificationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ReadJob

        /// <summary>
        /// <para>The ReadJob operation returns detailed information about a job.</para>
        /// </summary>
        /// 
        /// <param name="readJobRequest">Container for the necessary parameters to execute the ReadJob service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ReadJob service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public ReadJobResponse ReadJob(ReadJobRequest readJobRequest)
        {
            IAsyncResult asyncResult = invokeReadJob(readJobRequest, null, null, true);
            return EndReadJob(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ReadJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ReadJob"/>
        /// </summary>
        /// 
        /// <param name="readJobRequest">Container for the necessary parameters to execute the ReadJob operation on AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadJob
        ///         operation.</returns>
        public IAsyncResult BeginReadJob(ReadJobRequest readJobRequest, AsyncCallback callback, object state)
        {
            return invokeReadJob(readJobRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ReadJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ReadJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadJob.</param>
        /// 
        /// <returns>Returns a ReadJobResult from AmazonElasticTranscoder.</returns>
        public ReadJobResponse EndReadJob(IAsyncResult asyncResult)
        {
            return endOperation<ReadJobResponse>(asyncResult);
        }
        
        IAsyncResult invokeReadJob(ReadJobRequest readJobRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReadJobRequestMarshaller().Marshall(readJobRequest);
            var unmarshaller = ReadJobResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListJobsByStatus

        /// <summary>
        /// <para>The ListJobsByStatus operation gets a list of jobs that have a specified status. The response body contains one element for each job
        /// that satisfies the search criteria.</para>
        /// </summary>
        /// 
        /// <param name="listJobsByStatusRequest">Container for the necessary parameters to execute the ListJobsByStatus service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListJobsByStatus service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public ListJobsByStatusResponse ListJobsByStatus(ListJobsByStatusRequest listJobsByStatusRequest)
        {
            IAsyncResult asyncResult = invokeListJobsByStatus(listJobsByStatusRequest, null, null, true);
            return EndListJobsByStatus(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListJobsByStatus"/>
        /// </summary>
        /// 
        /// <param name="listJobsByStatusRequest">Container for the necessary parameters to execute the ListJobsByStatus operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobsByStatus
        ///         operation.</returns>
        public IAsyncResult BeginListJobsByStatus(ListJobsByStatusRequest listJobsByStatusRequest, AsyncCallback callback, object state)
        {
            return invokeListJobsByStatus(listJobsByStatusRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListJobsByStatus operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListJobsByStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobsByStatus.</param>
        /// 
        /// <returns>Returns a ListJobsByStatusResult from AmazonElasticTranscoder.</returns>
        public ListJobsByStatusResponse EndListJobsByStatus(IAsyncResult asyncResult)
        {
            return endOperation<ListJobsByStatusResponse>(asyncResult);
        }
        
        IAsyncResult invokeListJobsByStatus(ListJobsByStatusRequest listJobsByStatusRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListJobsByStatusRequestMarshaller().Marshall(listJobsByStatusRequest);
            var unmarshaller = ListJobsByStatusResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ReadPreset

        /// <summary>
        /// <para>The ReadPreset operation gets detailed information about a preset.</para>
        /// </summary>
        /// 
        /// <param name="readPresetRequest">Container for the necessary parameters to execute the ReadPreset service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ReadPreset service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public ReadPresetResponse ReadPreset(ReadPresetRequest readPresetRequest)
        {
            IAsyncResult asyncResult = invokeReadPreset(readPresetRequest, null, null, true);
            return EndReadPreset(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ReadPreset"/>
        /// </summary>
        /// 
        /// <param name="readPresetRequest">Container for the necessary parameters to execute the ReadPreset operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadPreset
        ///         operation.</returns>
        public IAsyncResult BeginReadPreset(ReadPresetRequest readPresetRequest, AsyncCallback callback, object state)
        {
            return invokeReadPreset(readPresetRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ReadPreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ReadPreset"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadPreset.</param>
        /// 
        /// <returns>Returns a ReadPresetResult from AmazonElasticTranscoder.</returns>
        public ReadPresetResponse EndReadPreset(IAsyncResult asyncResult)
        {
            return endOperation<ReadPresetResponse>(asyncResult);
        }
        
        IAsyncResult invokeReadPreset(ReadPresetRequest readPresetRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReadPresetRequestMarshaller().Marshall(readPresetRequest);
            var unmarshaller = ReadPresetResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreatePipeline

        /// <summary>
        /// <para>The CreatePipeline operation creates a pipeline with settings that you specify.</para>
        /// </summary>
        /// 
        /// <param name="createPipelineRequest">Container for the necessary parameters to execute the CreatePipeline service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public CreatePipelineResponse CreatePipeline(CreatePipelineRequest createPipelineRequest)
        {
            IAsyncResult asyncResult = invokeCreatePipeline(createPipelineRequest, null, null, true);
            return EndCreatePipeline(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreatePipeline"/>
        /// </summary>
        /// 
        /// <param name="createPipelineRequest">Container for the necessary parameters to execute the CreatePipeline operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipeline
        ///         operation.</returns>
        public IAsyncResult BeginCreatePipeline(CreatePipelineRequest createPipelineRequest, AsyncCallback callback, object state)
        {
            return invokeCreatePipeline(createPipelineRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreatePipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipeline.</param>
        /// 
        /// <returns>Returns a CreatePipelineResult from AmazonElasticTranscoder.</returns>
        public CreatePipelineResponse EndCreatePipeline(IAsyncResult asyncResult)
        {
            return endOperation<CreatePipelineResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreatePipeline(CreatePipelineRequest createPipelineRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreatePipelineRequestMarshaller().Marshall(createPipelineRequest);
            var unmarshaller = CreatePipelineResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CancelJob

        /// <summary>
        /// <para>The CancelJob operation cancels an unfinished job.</para> <para><b>NOTE:</b>You can only cancel a job that has a status of Submitted.
        /// To prevent a pipeline from starting to process a job while you're getting the job identifier, use UpdatePipelineStatus to temporarily pause
        /// the pipeline.</para>
        /// </summary>
        /// 
        /// <param name="cancelJobRequest">Container for the necessary parameters to execute the CancelJob service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public CancelJobResponse CancelJob(CancelJobRequest cancelJobRequest)
        {
            IAsyncResult asyncResult = invokeCancelJob(cancelJobRequest, null, null, true);
            return EndCancelJob(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CancelJob"/>
        /// </summary>
        /// 
        /// <param name="cancelJobRequest">Container for the necessary parameters to execute the CancelJob operation on AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJob
        ///         operation.</returns>
        public IAsyncResult BeginCancelJob(CancelJobRequest cancelJobRequest, AsyncCallback callback, object state)
        {
            return invokeCancelJob(cancelJobRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CancelJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CancelJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a CancelJobResult from AmazonElasticTranscoder.</returns>
        public CancelJobResponse EndCancelJob(IAsyncResult asyncResult)
        {
            return endOperation<CancelJobResponse>(asyncResult);
        }
        
        IAsyncResult invokeCancelJob(CancelJobRequest cancelJobRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CancelJobRequestMarshaller().Marshall(cancelJobRequest);
            var unmarshaller = CancelJobResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdatePipeline

        /// <summary>
        /// <para> Use the <c>UpdatePipeline</c> operation to update settings for a pipeline. <para><b>IMPORTANT:</b>When you change pipeline settings,
        /// your changes take effect immediately. Jobs that you have already submitted and that Elastic Transcoder has not started to process are
        /// affected in addition to jobs that you submit after you change settings. </para> </para>
        /// </summary>
        /// 
        /// <param name="updatePipelineRequest">Container for the necessary parameters to execute the UpdatePipeline service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest updatePipelineRequest)
        {
            IAsyncResult asyncResult = invokeUpdatePipeline(updatePipelineRequest, null, null, true);
            return EndUpdatePipeline(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.UpdatePipeline"/>
        /// </summary>
        /// 
        /// <param name="updatePipelineRequest">Container for the necessary parameters to execute the UpdatePipeline operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipeline
        ///         operation.</returns>
        public IAsyncResult BeginUpdatePipeline(UpdatePipelineRequest updatePipelineRequest, AsyncCallback callback, object state)
        {
            return invokeUpdatePipeline(updatePipelineRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdatePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.UpdatePipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipeline.</param>
        /// 
        /// <returns>Returns a UpdatePipelineResult from AmazonElasticTranscoder.</returns>
        public UpdatePipelineResponse EndUpdatePipeline(IAsyncResult asyncResult)
        {
            return endOperation<UpdatePipelineResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdatePipeline(UpdatePipelineRequest updatePipelineRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdatePipelineRequestMarshaller().Marshall(updatePipelineRequest);
            var unmarshaller = UpdatePipelineResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListPresets

        /// <summary>
        /// <para>The ListPresets operation gets a list of the default presets included with Elastic Transcoder and the presets that you've added in an
        /// AWS region.</para>
        /// </summary>
        /// 
        /// <param name="listPresetsRequest">Container for the necessary parameters to execute the ListPresets service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public ListPresetsResponse ListPresets(ListPresetsRequest listPresetsRequest)
        {
            IAsyncResult asyncResult = invokeListPresets(listPresetsRequest, null, null, true);
            return EndListPresets(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListPresets operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListPresets"/>
        /// </summary>
        /// 
        /// <param name="listPresetsRequest">Container for the necessary parameters to execute the ListPresets operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPresets
        ///         operation.</returns>
        public IAsyncResult BeginListPresets(ListPresetsRequest listPresetsRequest, AsyncCallback callback, object state)
        {
            return invokeListPresets(listPresetsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListPresets operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListPresets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPresets.</param>
        /// 
        /// <returns>Returns a ListPresetsResult from AmazonElasticTranscoder.</returns>
        public ListPresetsResponse EndListPresets(IAsyncResult asyncResult)
        {
            return endOperation<ListPresetsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListPresets(ListPresetsRequest listPresetsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListPresetsRequestMarshaller().Marshall(listPresetsRequest);
            var unmarshaller = ListPresetsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>The ListPresets operation gets a list of the default presets included with Elastic Transcoder and the presets that you've added in an
        /// AWS region.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public ListPresetsResponse ListPresets()
        {
            return ListPresets(new ListPresetsRequest());
        }
        

        #endregion
    
        #region DeletePipeline

        /// <summary>
        /// <para>The DeletePipeline operation removes a pipeline.</para> <para> You can only delete a pipeline that has never been used or that is not
        /// currently in use (doesn't contain any active jobs). If the pipeline is currently in use, <c>DeletePipeline</c> returns an error. </para>
        /// </summary>
        /// 
        /// <param name="deletePipelineRequest">Container for the necessary parameters to execute the DeletePipeline service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public DeletePipelineResponse DeletePipeline(DeletePipelineRequest deletePipelineRequest)
        {
            IAsyncResult asyncResult = invokeDeletePipeline(deletePipelineRequest, null, null, true);
            return EndDeletePipeline(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.DeletePipeline"/>
        /// </summary>
        /// 
        /// <param name="deletePipelineRequest">Container for the necessary parameters to execute the DeletePipeline operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePipeline
        ///         operation.</returns>
        public IAsyncResult BeginDeletePipeline(DeletePipelineRequest deletePipelineRequest, AsyncCallback callback, object state)
        {
            return invokeDeletePipeline(deletePipelineRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeletePipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.DeletePipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipeline.</param>
        /// 
        /// <returns>Returns a DeletePipelineResult from AmazonElasticTranscoder.</returns>
        public DeletePipelineResponse EndDeletePipeline(IAsyncResult asyncResult)
        {
            return endOperation<DeletePipelineResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeletePipeline(DeletePipelineRequest deletePipelineRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeletePipelineRequestMarshaller().Marshall(deletePipelineRequest);
            var unmarshaller = DeletePipelineResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region TestRole

        /// <summary>
        /// <para>The TestRole operation tests the IAM role used to create the pipeline.</para> <para>The <c>TestRole</c> action lets you determine
        /// whether the IAM role you are using has sufficient permissions to let Elastic Transcoder perform tasks associated with the transcoding
        /// process. The action attempts to assume the specified IAM role, checks read access to the input and output buckets, and tries to send a test
        /// notification to Amazon SNS topics that you specify.</para>
        /// </summary>
        /// 
        /// <param name="testRoleRequest">Container for the necessary parameters to execute the TestRole service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the TestRole service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public TestRoleResponse TestRole(TestRoleRequest testRoleRequest)
        {
            IAsyncResult asyncResult = invokeTestRole(testRoleRequest, null, null, true);
            return EndTestRole(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the TestRole operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.TestRole"/>
        /// </summary>
        /// 
        /// <param name="testRoleRequest">Container for the necessary parameters to execute the TestRole operation on AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestRole
        ///         operation.</returns>
        public IAsyncResult BeginTestRole(TestRoleRequest testRoleRequest, AsyncCallback callback, object state)
        {
            return invokeTestRole(testRoleRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the TestRole operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.TestRole"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestRole.</param>
        /// 
        /// <returns>Returns a TestRoleResult from AmazonElasticTranscoder.</returns>
        public TestRoleResponse EndTestRole(IAsyncResult asyncResult)
        {
            return endOperation<TestRoleResponse>(asyncResult);
        }
        
        IAsyncResult invokeTestRole(TestRoleRequest testRoleRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new TestRoleRequestMarshaller().Marshall(testRoleRequest);
            var unmarshaller = TestRoleResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        


        #endregion
    
        #region ListPipelines

        /// <summary>
        /// <para>The ListPipelines operation gets a list of the pipelines associated with the current AWS account.</para>
        /// </summary>
        /// 
        /// <param name="listPipelinesRequest">Container for the necessary parameters to execute the ListPipelines service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public ListPipelinesResponse ListPipelines(ListPipelinesRequest listPipelinesRequest)
        {
            IAsyncResult asyncResult = invokeListPipelines(listPipelinesRequest, null, null, true);
            return EndListPipelines(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListPipelines"/>
        /// </summary>
        /// 
        /// <param name="listPipelinesRequest">Container for the necessary parameters to execute the ListPipelines operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelines
        ///         operation.</returns>
        public IAsyncResult BeginListPipelines(ListPipelinesRequest listPipelinesRequest, AsyncCallback callback, object state)
        {
            return invokeListPipelines(listPipelinesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListPipelines operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListPipelines"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelines.</param>
        /// 
        /// <returns>Returns a ListPipelinesResult from AmazonElasticTranscoder.</returns>
        public ListPipelinesResponse EndListPipelines(IAsyncResult asyncResult)
        {
            return endOperation<ListPipelinesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListPipelines(ListPipelinesRequest listPipelinesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListPipelinesRequestMarshaller().Marshall(listPipelinesRequest);
            var unmarshaller = ListPipelinesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>The ListPipelines operation gets a list of the pipelines associated with the current AWS account.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public ListPipelinesResponse ListPipelines()
        {
            return ListPipelines(new ListPipelinesRequest());
        }
        

        #endregion
    
        #region ReadPipeline

        /// <summary>
        /// <para>The ReadPipeline operation gets detailed information about a pipeline.</para>
        /// </summary>
        /// 
        /// <param name="readPipelineRequest">Container for the necessary parameters to execute the ReadPipeline service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ReadPipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public ReadPipelineResponse ReadPipeline(ReadPipelineRequest readPipelineRequest)
        {
            IAsyncResult asyncResult = invokeReadPipeline(readPipelineRequest, null, null, true);
            return EndReadPipeline(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ReadPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ReadPipeline"/>
        /// </summary>
        /// 
        /// <param name="readPipelineRequest">Container for the necessary parameters to execute the ReadPipeline operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReadPipeline
        ///         operation.</returns>
        public IAsyncResult BeginReadPipeline(ReadPipelineRequest readPipelineRequest, AsyncCallback callback, object state)
        {
            return invokeReadPipeline(readPipelineRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ReadPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ReadPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReadPipeline.</param>
        /// 
        /// <returns>Returns a ReadPipelineResult from AmazonElasticTranscoder.</returns>
        public ReadPipelineResponse EndReadPipeline(IAsyncResult asyncResult)
        {
            return endOperation<ReadPipelineResponse>(asyncResult);
        }
        
        IAsyncResult invokeReadPipeline(ReadPipelineRequest readPipelineRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReadPipelineRequestMarshaller().Marshall(readPipelineRequest);
            var unmarshaller = ReadPipelineResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreatePreset

        /// <summary>
        /// <para>The CreatePreset operation creates a preset with settings that you specify.</para> <para><b>IMPORTANT:</b>Elastic Transcoder checks
        /// the CreatePreset settings to ensure that they meet Elastic Transcoder requirements and to determine whether they comply with H.264
        /// standards. If your settings are not valid for Elastic Transcoder, Elastic Transcoder returns an HTTP 400 response (ValidationException) and
        /// does not create the preset. If the settings are valid for Elastic Transcoder but aren't strictly compliant with the H.264 standard, Elastic
        /// Transcoder creates the preset and returns a warning message in the response. This helps you determine whether your settings comply with the
        /// H.264 standard while giving you greater flexibility with respect to the video that Elastic Transcoder produces.</para> <para>Elastic
        /// Transcoder uses the H.264 video-compression format. For more information, see the International Telecommunication Union publication
        /// <i>Recommendation ITU-T H.264: Advanced video coding for generic audiovisual services</i> .</para>
        /// </summary>
        /// 
        /// <param name="createPresetRequest">Container for the necessary parameters to execute the CreatePreset service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CreatePreset service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public CreatePresetResponse CreatePreset(CreatePresetRequest createPresetRequest)
        {
            IAsyncResult asyncResult = invokeCreatePreset(createPresetRequest, null, null, true);
            return EndCreatePreset(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreatePreset"/>
        /// </summary>
        /// 
        /// <param name="createPresetRequest">Container for the necessary parameters to execute the CreatePreset operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePreset
        ///         operation.</returns>
        public IAsyncResult BeginCreatePreset(CreatePresetRequest createPresetRequest, AsyncCallback callback, object state)
        {
            return invokeCreatePreset(createPresetRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreatePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreatePreset"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePreset.</param>
        /// 
        /// <returns>Returns a CreatePresetResult from AmazonElasticTranscoder.</returns>
        public CreatePresetResponse EndCreatePreset(IAsyncResult asyncResult)
        {
            return endOperation<CreatePresetResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreatePreset(CreatePresetRequest createPresetRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreatePresetRequestMarshaller().Marshall(createPresetRequest);
            var unmarshaller = CreatePresetResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeletePreset

        /// <summary>
        /// <para>The DeletePreset operation removes a preset that you've added in an AWS region.</para> <para><b>NOTE:</b> You can't delete the default
        /// presets that are included with Elastic Transcoder. </para>
        /// </summary>
        /// 
        /// <param name="deletePresetRequest">Container for the necessary parameters to execute the DeletePreset service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the DeletePreset service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public DeletePresetResponse DeletePreset(DeletePresetRequest deletePresetRequest)
        {
            IAsyncResult asyncResult = invokeDeletePreset(deletePresetRequest, null, null, true);
            return EndDeletePreset(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.DeletePreset"/>
        /// </summary>
        /// 
        /// <param name="deletePresetRequest">Container for the necessary parameters to execute the DeletePreset operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePreset
        ///         operation.</returns>
        public IAsyncResult BeginDeletePreset(DeletePresetRequest deletePresetRequest, AsyncCallback callback, object state)
        {
            return invokeDeletePreset(deletePresetRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeletePreset operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.DeletePreset"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePreset.</param>
        /// 
        /// <returns>Returns a DeletePresetResult from AmazonElasticTranscoder.</returns>
        public DeletePresetResponse EndDeletePreset(IAsyncResult asyncResult)
        {
            return endOperation<DeletePresetResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeletePreset(DeletePresetRequest deletePresetRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeletePresetRequestMarshaller().Marshall(deletePresetRequest);
            var unmarshaller = DeletePresetResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateJob

        /// <summary>
        /// <para> When you create a job, Elastic Transcoder returns JSON data that includes the values that you specified plus information about the
        /// job that is created. </para> <para>If you have specified more than one output for your jobs (for example, one output for the Kindle Fire and
        /// another output for the Apple iPhone 4s), you currently must use the Elastic Transcoder API to list the jobs (as opposed to the AWS
        /// Console).</para>
        /// </summary>
        /// 
        /// <param name="createJobRequest">Container for the necessary parameters to execute the CreateJob service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public CreateJobResponse CreateJob(CreateJobRequest createJobRequest)
        {
            IAsyncResult asyncResult = invokeCreateJob(createJobRequest, null, null, true);
            return EndCreateJob(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreateJob"/>
        /// </summary>
        /// 
        /// <param name="createJobRequest">Container for the necessary parameters to execute the CreateJob operation on AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        public IAsyncResult BeginCreateJob(CreateJobRequest createJobRequest, AsyncCallback callback, object state)
        {
            return invokeCreateJob(createJobRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateJob operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreateJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a CreateJobResult from AmazonElasticTranscoder.</returns>
        public CreateJobResponse EndCreateJob(IAsyncResult asyncResult)
        {
            return endOperation<CreateJobResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateJob(CreateJobRequest createJobRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateJobRequestMarshaller().Marshall(createJobRequest);
            var unmarshaller = CreateJobResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListJobsByPipeline

        /// <summary>
        /// <para>The ListJobsByPipeline operation gets a list of the jobs currently in a pipeline.</para> <para>Elastic Transcoder returns all of the
        /// jobs currently in the specified pipeline. The response body contains one element for each job that satisfies the search criteria.</para>
        /// </summary>
        /// 
        /// <param name="listJobsByPipelineRequest">Container for the necessary parameters to execute the ListJobsByPipeline service method on
        ///          AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListJobsByPipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="AccessDeniedException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="ValidationException"/>
        /// <exception cref="IncompatibleVersionException"/>
        public ListJobsByPipelineResponse ListJobsByPipeline(ListJobsByPipelineRequest listJobsByPipelineRequest)
        {
            IAsyncResult asyncResult = invokeListJobsByPipeline(listJobsByPipelineRequest, null, null, true);
            return EndListJobsByPipeline(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListJobsByPipeline"/>
        /// </summary>
        /// 
        /// <param name="listJobsByPipelineRequest">Container for the necessary parameters to execute the ListJobsByPipeline operation on
        ///          AmazonElasticTranscoder.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListJobsByPipeline operation.</returns>
        public IAsyncResult BeginListJobsByPipeline(ListJobsByPipelineRequest listJobsByPipelineRequest, AsyncCallback callback, object state)
        {
            return invokeListJobsByPipeline(listJobsByPipelineRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListJobsByPipeline operation.
        /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.ListJobsByPipeline"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobsByPipeline.</param>
        /// 
        /// <returns>Returns a ListJobsByPipelineResult from AmazonElasticTranscoder.</returns>
        public ListJobsByPipelineResponse EndListJobsByPipeline(IAsyncResult asyncResult)
        {
            return endOperation<ListJobsByPipelineResponse>(asyncResult);
        }
        
        IAsyncResult invokeListJobsByPipeline(ListJobsByPipelineRequest listJobsByPipelineRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListJobsByPipelineRequestMarshaller().Marshall(listJobsByPipelineRequest);
            var unmarshaller = ListJobsByPipelineResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
