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
 * Do not modify this file. This file is generated from the importexport-2010-06-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.ImportExport.Model;
using Amazon.ImportExport.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ImportExport
{
    /// <summary>
    /// Implementation for accessing ImportExport
    ///
    /// AWS Import/Export Service AWS Import/Export accelerates transferring large amounts
    /// of data between the AWS cloud and portable storage devices that you mail to us. AWS
    /// Import/Export transfers data directly onto and off of your storage devices using Amazon's
    /// high-speed internal network and bypassing the Internet. For large data sets, AWS Import/Export
    /// is often faster than Internet transfer and more cost effective than upgrading your
    /// connectivity.
    /// </summary>
    public partial class AmazonImportExportClient : AmazonServiceClient, IAmazonImportExport
    {
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
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonImportExportClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonImportExportConfig()) { }

        /// <summary>
        /// Constructs AmazonImportExportClient with the credentials loaded from the application's
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
        public AmazonImportExportClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonImportExportConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonImportExportClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonImportExportClient Configuration Object</param>
        public AmazonImportExportClient(AmazonImportExportConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            : base(credentials, clientConfig)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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
            return new QueryStringSigner();
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
        /// This operation cancels a specified job. Only the job owner can cancel it. The operation
        /// fails if the job has already started or is complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by ImportExport.</returns>
        /// <exception cref="Amazon.ImportExport.Model.CanceledJobIdException">
        /// The specified job ID has been canceled and is no longer valid.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.ExpiredJobIdException">
        /// Indicates that the specified job has expired out of the system.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidAccessKeyIdException">
        /// The AWS Access Key ID specified in the request did not match the manifest's accessKeyId
        /// value. The manifest and the request authentication must use the same AWS Access Key
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidJobIdException">
        /// The JOBID was missing, not found, or not associated with the AWS account.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidVersionException">
        /// The client tool version is invalid.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.UnableToCancelJobIdException">
        /// AWS Import/Export cannot cancel the job
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
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation on AmazonImportExportClient.</param>
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
        /// <returns>Returns a  CancelJobResult from ImportExport.</returns>
        public virtual CancelJobResponse EndCancelJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateJob

        /// <summary>
        /// This operation initiates the process of scheduling an upload or download of your data.
        /// You include in the request a manifest that describes the data transfer specifics.
        /// The response to the request includes a job ID, which you can use in other operations,
        /// a signature that you use to identify your storage device, and the address where you
        /// should ship your storage device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by ImportExport.</returns>
        /// <exception cref="Amazon.ImportExport.Model.BucketPermissionException">
        /// The account specified does not have the appropriate bucket permissions.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.CreateJobQuotaExceededException">
        /// Each account can create only a certain number of jobs per day. If you need to create
        /// more than this, please contact awsimportexport@amazon.com to explain your particular
        /// use case.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidAccessKeyIdException">
        /// The AWS Access Key ID specified in the request did not match the manifest's accessKeyId
        /// value. The manifest and the request authentication must use the same AWS Access Key
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidAddressException">
        /// The address specified in the manifest is invalid.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidCustomsException">
        /// One or more customs parameters was invalid. Please correct and resubmit.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidFileSystemException">
        /// File system specified in export manifest is invalid.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidJobIdException">
        /// The JOBID was missing, not found, or not associated with the AWS account.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidManifestFieldException">
        /// One or more manifest fields was invalid. Please correct and resubmit.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidVersionException">
        /// The client tool version is invalid.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.MalformedManifestException">
        /// Your manifest is not well-formed.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.MissingCustomsException">
        /// One or more required customs parameters was missing from the manifest.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.MissingManifestFieldException">
        /// One or more required fields were missing from the manifest file. Please correct and
        /// resubmit.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.MissingParameterException">
        /// One or more required parameters was missing from the request.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.MultipleRegionsException">
        /// Your manifest file contained buckets from multiple regions. A job is restricted to
        /// buckets from one region. Please correct and resubmit.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.NoSuchBucketException">
        /// The specified bucket does not exist. Create the specified bucket or change the manifest's
        /// bucket, exportBucket, or logBucket field to a bucket that the account, as specified
        /// by the manifest's Access Key ID, has write permissions to.
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
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonImportExportClient.</param>
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
        /// <returns>Returns a  CreateJobResult from ImportExport.</returns>
        public virtual CreateJobResponse EndCreateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetShippingLabel

        /// <summary>
        /// This operation generates a pre-paid UPS shipping label that you will use to ship your
        /// device to AWS for processing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetShippingLabel service method.</param>
        /// 
        /// <returns>The response from the GetShippingLabel service method, as returned by ImportExport.</returns>
        /// <exception cref="Amazon.ImportExport.Model.CanceledJobIdException">
        /// The specified job ID has been canceled and is no longer valid.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.ExpiredJobIdException">
        /// Indicates that the specified job has expired out of the system.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidAccessKeyIdException">
        /// The AWS Access Key ID specified in the request did not match the manifest's accessKeyId
        /// value. The manifest and the request authentication must use the same AWS Access Key
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidAddressException">
        /// The address specified in the manifest is invalid.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidJobIdException">
        /// The JOBID was missing, not found, or not associated with the AWS account.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidVersionException">
        /// The client tool version is invalid.
        /// </exception>
        public virtual GetShippingLabelResponse GetShippingLabel(GetShippingLabelRequest request)
        {
            var marshaller = GetShippingLabelRequestMarshaller.Instance;
            var unmarshaller = GetShippingLabelResponseUnmarshaller.Instance;

            return Invoke<GetShippingLabelRequest,GetShippingLabelResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetShippingLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetShippingLabel operation on AmazonImportExportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetShippingLabel
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetShippingLabel(GetShippingLabelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetShippingLabelRequestMarshaller.Instance;
            var unmarshaller = GetShippingLabelResponseUnmarshaller.Instance;

            return BeginInvoke<GetShippingLabelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetShippingLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetShippingLabel.</param>
        /// 
        /// <returns>Returns a  GetShippingLabelResult from ImportExport.</returns>
        public virtual GetShippingLabelResponse EndGetShippingLabel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetShippingLabelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStatus

        /// <summary>
        /// This operation returns information about a job, including where the job is in the
        /// processing pipeline, the status of the results, and the signature value associated
        /// with the job. You can only return information about jobs you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStatus service method.</param>
        /// 
        /// <returns>The response from the GetStatus service method, as returned by ImportExport.</returns>
        /// <exception cref="Amazon.ImportExport.Model.CanceledJobIdException">
        /// The specified job ID has been canceled and is no longer valid.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.ExpiredJobIdException">
        /// Indicates that the specified job has expired out of the system.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidAccessKeyIdException">
        /// The AWS Access Key ID specified in the request did not match the manifest's accessKeyId
        /// value. The manifest and the request authentication must use the same AWS Access Key
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidJobIdException">
        /// The JOBID was missing, not found, or not associated with the AWS account.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidVersionException">
        /// The client tool version is invalid.
        /// </exception>
        public virtual GetStatusResponse GetStatus(GetStatusRequest request)
        {
            var marshaller = GetStatusRequestMarshaller.Instance;
            var unmarshaller = GetStatusResponseUnmarshaller.Instance;

            return Invoke<GetStatusRequest,GetStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStatus operation on AmazonImportExportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStatus
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetStatus(GetStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetStatusRequestMarshaller.Instance;
            var unmarshaller = GetStatusResponseUnmarshaller.Instance;

            return BeginInvoke<GetStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStatus.</param>
        /// 
        /// <returns>Returns a  GetStatusResult from ImportExport.</returns>
        public virtual GetStatusResponse EndGetStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJobs

        /// <summary>
        /// This operation returns the jobs associated with the requester. AWS Import/Export lists
        /// the jobs in reverse chronological order based on the date of creation. For example
        /// if Job Test1 was created 2009Dec30 and Test2 was created 2010Feb05, the ListJobs operation
        /// would return Test2 followed by Test1.
        /// </summary>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by ImportExport.</returns>
        /// <exception cref="Amazon.ImportExport.Model.InvalidAccessKeyIdException">
        /// The AWS Access Key ID specified in the request did not match the manifest's accessKeyId
        /// value. The manifest and the request authentication must use the same AWS Access Key
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidVersionException">
        /// The client tool version is invalid.
        /// </exception>
        public virtual ListJobsResponse ListJobs()
        {
            return ListJobs(new ListJobsRequest());
        }

        /// <summary>
        /// This operation returns the jobs associated with the requester. AWS Import/Export lists
        /// the jobs in reverse chronological order based on the date of creation. For example
        /// if Job Test1 was created 2009Dec30 and Test2 was created 2010Feb05, the ListJobs operation
        /// would return Test2 followed by Test1.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by ImportExport.</returns>
        /// <exception cref="Amazon.ImportExport.Model.InvalidAccessKeyIdException">
        /// The AWS Access Key ID specified in the request did not match the manifest's accessKeyId
        /// value. The manifest and the request authentication must use the same AWS Access Key
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidVersionException">
        /// The client tool version is invalid.
        /// </exception>
        public virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var marshaller = ListJobsRequestMarshaller.Instance;
            var unmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsRequest,ListJobsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonImportExportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        public virtual IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListJobsRequestMarshaller.Instance;
            var unmarshaller = ListJobsResponseUnmarshaller.Instance;

            return BeginInvoke<ListJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from ImportExport.</returns>
        public virtual ListJobsResponse EndListJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateJob

        /// <summary>
        /// You use this operation to change the parameters specified in the original manifest
        /// file by supplying a new manifest file. The manifest file attached to this request
        /// replaces the original manifest file. You can only use the operation after a CreateJob
        /// request but before the data transfer starts and you can only use it on jobs you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by ImportExport.</returns>
        /// <exception cref="Amazon.ImportExport.Model.BucketPermissionException">
        /// The account specified does not have the appropriate bucket permissions.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.CanceledJobIdException">
        /// The specified job ID has been canceled and is no longer valid.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.ExpiredJobIdException">
        /// Indicates that the specified job has expired out of the system.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidAccessKeyIdException">
        /// The AWS Access Key ID specified in the request did not match the manifest's accessKeyId
        /// value. The manifest and the request authentication must use the same AWS Access Key
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidAddressException">
        /// The address specified in the manifest is invalid.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidCustomsException">
        /// One or more customs parameters was invalid. Please correct and resubmit.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidFileSystemException">
        /// File system specified in export manifest is invalid.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidJobIdException">
        /// The JOBID was missing, not found, or not associated with the AWS account.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidManifestFieldException">
        /// One or more manifest fields was invalid. Please correct and resubmit.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.InvalidVersionException">
        /// The client tool version is invalid.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.MalformedManifestException">
        /// Your manifest is not well-formed.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.MissingCustomsException">
        /// One or more required customs parameters was missing from the manifest.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.MissingManifestFieldException">
        /// One or more required fields were missing from the manifest file. Please correct and
        /// resubmit.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.MissingParameterException">
        /// One or more required parameters was missing from the request.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.MultipleRegionsException">
        /// Your manifest file contained buckets from multiple regions. A job is restricted to
        /// buckets from one region. Please correct and resubmit.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.NoSuchBucketException">
        /// The specified bucket does not exist. Create the specified bucket or change the manifest's
        /// bucket, exportBucket, or logBucket field to a bucket that the account, as specified
        /// by the manifest's Access Key ID, has write permissions to.
        /// </exception>
        /// <exception cref="Amazon.ImportExport.Model.UnableToUpdateJobIdException">
        /// AWS Import/Export cannot update the job
        /// </exception>
        public virtual UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            var marshaller = UpdateJobRequestMarshaller.Instance;
            var unmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return Invoke<UpdateJobRequest,UpdateJobResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation on AmazonImportExportClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJob
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateJob(UpdateJobRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateJobRequestMarshaller.Instance;
            var unmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateJobRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJob.</param>
        /// 
        /// <returns>Returns a  UpdateJobResult from ImportExport.</returns>
        public virtual UpdateJobResponse EndUpdateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateJobResponse>(asyncResult);
        }

        #endregion
        
    }
}