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

using Amazon.ImportExport.Model;
using Amazon.ImportExport.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.ImportExport
{
    /// <summary>
    /// Implementation for accessing AmazonImportExport.
    ///  
    /// AWS Import/Export Service <para> AWS Import/Export accelerates transferring large amounts of data between the AWS cloud and portable storage
    /// devices that you mail to us. AWS Import/Export transfers data directly onto and off of your storage devices using Amazon's high-speed
    /// internal network and bypassing the Internet. For large data sets, AWS Import/Export is often faster than Internet transfer and more cost
    /// effective than upgrading your connectivity. </para>
    /// </summary>
    public partial class AmazonImportExportClient : AmazonWebServiceClient, IAmazonImportExport
    {
    QueryStringSigner signer = new QueryStringSigner();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonImportExportClient with the credentials loaded from the application's
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
        public AmazonImportExportClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonImportExportConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonImportExportClient with the credentials loaded from the application's
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
        public AmazonImportExportClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonImportExportConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonImportExportClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonImportExport Configuration Object</param>
        public AmazonImportExportClient(AmazonImportExportConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonImportExportClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonImportExportClient(AWSCredentials credentials)
            : this(credentials, new AmazonImportExportConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonImportExportClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonImportExportClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonImportExportConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonImportExportClient with AWS Credentials and an
        /// AmazonImportExportClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonImportExportClient Configuration Object</param>
        public AmazonImportExportClient(AWSCredentials credentials, AmazonImportExportConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonImportExportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonImportExportClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonImportExportConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonImportExportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonImportExportClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonImportExportConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonImportExportClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonImportExportClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonImportExportClient Configuration Object</param>
        public AmazonImportExportClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonImportExportConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonImportExportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonImportExportClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonImportExportConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonImportExportClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonImportExportClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonImportExportConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonImportExportClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonImportExportClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonImportExportClient Configuration Object</param>
        public AmazonImportExportClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonImportExportConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion


        #region CancelJob

        /// <summary>
        /// <para> This operation cancels a specified job. Only the job owner can cancel it. The operation fails if the job has already started or is
        /// complete. </para>
        /// </summary>
        /// 
        /// <param name="cancelJobRequest">Container for the necessary parameters to execute the CancelJob service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="CanceledJobIdException"/>
        /// <exception cref="ExpiredJobIdException"/>
        /// <exception cref="InvalidAccessKeyIdException"/>
        /// <exception cref="InvalidJobIdException"/>
        /// <exception cref="UnableToCancelJobIdException"/>
        public CancelJobResponse CancelJob(CancelJobRequest cancelJobRequest)
        {
            IAsyncResult asyncResult = invokeCancelJob(cancelJobRequest, null, null, true);
            return EndCancelJob(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.CancelJob"/>
        /// </summary>
        /// 
        /// <param name="cancelJobRequest">Container for the necessary parameters to execute the CancelJob operation on AmazonImportExport.</param>
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
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.CancelJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a CancelJobResult from AmazonImportExport.</returns>
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
    
        #region CreateJob

        /// <summary>
        /// <para> This operation initiates the process of scheduling an upload or download of your data. You include in the request a manifest that
        /// describes the data transfer specifics. The response to the request includes a job ID, which you can use in other operations, a signature
        /// that you use to identify your storage device, and the address where you should ship your storage device. </para>
        /// </summary>
        /// 
        /// <param name="createJobRequest">Container for the necessary parameters to execute the CreateJob service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="MalformedManifestException"/>
        /// <exception cref="InvalidAddressException"/>
        /// <exception cref="BucketPermissionException"/>
        /// <exception cref="InvalidParameterException"/>
        /// <exception cref="MultipleRegionsException"/>
        /// <exception cref="MissingParameterException"/>
        /// <exception cref="InvalidFileSystemException"/>
        /// <exception cref="MissingCustomsException"/>
        /// <exception cref="NoSuchBucketException"/>
        /// <exception cref="InvalidAccessKeyIdException"/>
        /// <exception cref="InvalidManifestFieldException"/>
        /// <exception cref="InvalidCustomsException"/>
        /// <exception cref="MissingManifestFieldException"/>
        public CreateJobResponse CreateJob(CreateJobRequest createJobRequest)
        {
            IAsyncResult asyncResult = invokeCreateJob(createJobRequest, null, null, true);
            return EndCreateJob(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.CreateJob"/>
        /// </summary>
        /// 
        /// <param name="createJobRequest">Container for the necessary parameters to execute the CreateJob operation on AmazonImportExport.</param>
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
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.CreateJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a CreateJobResult from AmazonImportExport.</returns>
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
    
        #region GetStatus

        /// <summary>
        /// <para> This operation returns information about a job, including where the job is in the processing pipeline, the status of the results, and
        /// the signature value associated with the job. You can only return information about jobs you own. </para>
        /// </summary>
        /// 
        /// <param name="getStatusRequest">Container for the necessary parameters to execute the GetStatus service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the GetStatus service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="CanceledJobIdException"/>
        /// <exception cref="ExpiredJobIdException"/>
        /// <exception cref="InvalidAccessKeyIdException"/>
        /// <exception cref="InvalidJobIdException"/>
        public GetStatusResponse GetStatus(GetStatusRequest getStatusRequest)
        {
            IAsyncResult asyncResult = invokeGetStatus(getStatusRequest, null, null, true);
            return EndGetStatus(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetStatus operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.GetStatus"/>
        /// </summary>
        /// 
        /// <param name="getStatusRequest">Container for the necessary parameters to execute the GetStatus operation on AmazonImportExport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStatus
        ///         operation.</returns>
        public IAsyncResult BeginGetStatus(GetStatusRequest getStatusRequest, AsyncCallback callback, object state)
        {
            return invokeGetStatus(getStatusRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetStatus operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.GetStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStatus.</param>
        /// 
        /// <returns>Returns a GetStatusResult from AmazonImportExport.</returns>
        public GetStatusResponse EndGetStatus(IAsyncResult asyncResult)
        {
            return endOperation<GetStatusResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetStatus(GetStatusRequest getStatusRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetStatusRequestMarshaller().Marshall(getStatusRequest);
            var unmarshaller = GetStatusResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListJobs

        /// <summary>
        /// <para> This operation returns the jobs associated with the requester. AWS Import/Export lists the jobs in reverse chronological order based
        /// on the date of creation. For example if Job Test1 was created 2009Dec30 and Test2 was created 2010Feb05, the ListJobs operation would return
        /// Test2 followed by Test1. </para>
        /// </summary>
        /// 
        /// <param name="listJobsRequest">Container for the necessary parameters to execute the ListJobs service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="InvalidParameterException"/>
        /// <exception cref="InvalidAccessKeyIdException"/>
        public ListJobsResponse ListJobs(ListJobsRequest listJobsRequest)
        {
            IAsyncResult asyncResult = invokeListJobs(listJobsRequest, null, null, true);
            return EndListJobs(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.ListJobs"/>
        /// </summary>
        /// 
        /// <param name="listJobsRequest">Container for the necessary parameters to execute the ListJobs operation on AmazonImportExport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        public IAsyncResult BeginListJobs(ListJobsRequest listJobsRequest, AsyncCallback callback, object state)
        {
            return invokeListJobs(listJobsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListJobs operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.ListJobs"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a ListJobsResult from AmazonImportExport.</returns>
        public ListJobsResponse EndListJobs(IAsyncResult asyncResult)
        {
            return endOperation<ListJobsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListJobs(ListJobsRequest listJobsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListJobsRequestMarshaller().Marshall(listJobsRequest);
            var unmarshaller = ListJobsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> This operation returns the jobs associated with the requester. AWS Import/Export lists the jobs in reverse chronological order based
        /// on the date of creation. For example if Job Test1 was created 2009Dec30 and Test2 was created 2010Feb05, the ListJobs operation would return
        /// Test2 followed by Test1. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="InvalidParameterException"/>
        /// <exception cref="InvalidAccessKeyIdException"/>
        public ListJobsResponse ListJobs()
        {
            return ListJobs(new ListJobsRequest());
        }
        

        #endregion
    
        #region UpdateJob

        /// <summary>
        /// <para> You use this operation to change the parameters specified in the original manifest file by supplying a new manifest file. The
        /// manifest file attached to this request replaces the original manifest file. You can only use the operation after a CreateJob request but
        /// before the data transfer starts and you can only use it on jobs you own. </para>
        /// </summary>
        /// 
        /// <param name="updateJobRequest">Container for the necessary parameters to execute the UpdateJob service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="MalformedManifestException"/>
        /// <exception cref="BucketPermissionException"/>
        /// <exception cref="InvalidAddressException"/>
        /// <exception cref="InvalidParameterException"/>
        /// <exception cref="MultipleRegionsException"/>
        /// <exception cref="MissingParameterException"/>
        /// <exception cref="InvalidFileSystemException"/>
        /// <exception cref="CanceledJobIdException"/>
        /// <exception cref="MissingCustomsException"/>
        /// <exception cref="NoSuchBucketException"/>
        /// <exception cref="ExpiredJobIdException"/>
        /// <exception cref="InvalidAccessKeyIdException"/>
        /// <exception cref="InvalidCustomsException"/>
        /// <exception cref="InvalidManifestFieldException"/>
        /// <exception cref="MissingManifestFieldException"/>
        /// <exception cref="InvalidJobIdException"/>
        public UpdateJobResponse UpdateJob(UpdateJobRequest updateJobRequest)
        {
            IAsyncResult asyncResult = invokeUpdateJob(updateJobRequest, null, null, true);
            return EndUpdateJob(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.UpdateJob"/>
        /// </summary>
        /// 
        /// <param name="updateJobRequest">Container for the necessary parameters to execute the UpdateJob operation on AmazonImportExport.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJob
        ///         operation.</returns>
        public IAsyncResult BeginUpdateJob(UpdateJobRequest updateJobRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateJob(updateJobRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateJob operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.UpdateJob"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJob.</param>
        /// 
        /// <returns>Returns a UpdateJobResult from AmazonImportExport.</returns>
        public UpdateJobResponse EndUpdateJob(IAsyncResult asyncResult)
        {
            return endOperation<UpdateJobResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateJob(UpdateJobRequest updateJobRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateJobRequestMarshaller().Marshall(updateJobRequest);
            var unmarshaller = UpdateJobResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
