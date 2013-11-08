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
using System.Threading.Tasks;

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
	public partial class AmazonImportExportClient : AmazonWebServiceClient, Amazon.ImportExport.IAmazonImportExport
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonImportExportConfig(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : this(credentials, new AmazonImportExportConfig(){RegionEndpoint=region})
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
        /// AmazonImportExportClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonImportExportConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonImportExportClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonImportExportClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
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

 
        /// <summary>
        /// <para> This operation cancels a specified job. Only the job owner can cancel it. The operation fails if the job has already started or is
        /// complete. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="T:Amazon.ImportExport.Model.CanceledJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.ExpiredJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAccessKeyIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.UnableToCancelJobIdException" />
		public CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var task = CancelJobAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.CancelJob"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelJobRequestMarshaller();
            var unmarshaller = CancelJobResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CancelJobRequest, CancelJobResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> This operation initiates the process of scheduling an upload or download of your data. You include in the request a manifest that
        /// describes the data transfer specifics. The response to the request includes a job ID, which you can use in other operations, a signature
        /// that you use to identify your storage device, and the address where you should ship your storage device. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="T:Amazon.ImportExport.Model.MalformedManifestException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAddressException" />
        /// <exception cref="T:Amazon.ImportExport.Model.BucketPermissionException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidParameterException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MultipleRegionsException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MissingParameterException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidFileSystemException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MissingCustomsException" />
        /// <exception cref="T:Amazon.ImportExport.Model.NoSuchBucketException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAccessKeyIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidManifestFieldException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidCustomsException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MissingManifestFieldException" />
		public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var task = CreateJobAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.CreateJob"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateJobRequestMarshaller();
            var unmarshaller = CreateJobResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateJobRequest, CreateJobResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> This operation returns information about a job, including where the job is in the processing pipeline, the status of the results, and
        /// the signature value associated with the job. You can only return information about jobs you own. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStatus service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the GetStatus service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="T:Amazon.ImportExport.Model.CanceledJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.ExpiredJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAccessKeyIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidJobIdException" />
		public GetStatusResponse GetStatus(GetStatusRequest request)
        {
            var task = GetStatusAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetStatus operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.GetStatus"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetStatusResponse> GetStatusAsync(GetStatusRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStatusRequestMarshaller();
            var unmarshaller = GetStatusResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetStatusRequest, GetStatusResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> This operation returns the jobs associated with the requester. AWS Import/Export lists the jobs in reverse chronological order based
        /// on the date of creation. For example if Job Test1 was created 2009Dec30 and Test2 was created 2010Feb05, the ListJobs operation would return
        /// Test2 followed by Test1. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidParameterException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAccessKeyIdException" />
		public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var task = ListJobsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.ListJobs"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListJobsRequestMarshaller();
            var unmarshaller = ListJobsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListJobsRequest, ListJobsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> This operation returns the jobs associated with the requester. AWS Import/Export lists the jobs in reverse chronological order based
        /// on the date of creation. For example if Job Test1 was created 2009Dec30 and Test2 was created 2010Feb05, the ListJobs operation would return
        /// Test2 followed by Test1. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListJobs service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidParameterException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAccessKeyIdException" />
		public ListJobsResponse ListJobs()
        {
            return this.ListJobs(new ListJobsRequest());
        }
 
        /// <summary>
        /// <para> You use this operation to change the parameters specified in the original manifest file by supplying a new manifest file. The
        /// manifest file attached to this request replaces the original manifest file. You can only use the operation after a CreateJob request but
        /// before the data transfer starts and you can only use it on jobs you own. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method on AmazonImportExport.</param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by AmazonImportExport.</returns>
        /// 
        /// <exception cref="T:Amazon.ImportExport.Model.MalformedManifestException" />
        /// <exception cref="T:Amazon.ImportExport.Model.BucketPermissionException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAddressException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidParameterException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MultipleRegionsException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MissingParameterException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidFileSystemException" />
        /// <exception cref="T:Amazon.ImportExport.Model.CanceledJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MissingCustomsException" />
        /// <exception cref="T:Amazon.ImportExport.Model.NoSuchBucketException" />
        /// <exception cref="T:Amazon.ImportExport.Model.ExpiredJobIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidAccessKeyIdException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidCustomsException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidManifestFieldException" />
        /// <exception cref="T:Amazon.ImportExport.Model.MissingManifestFieldException" />
        /// <exception cref="T:Amazon.ImportExport.Model.InvalidJobIdException" />
		public UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            var task = UpdateJobAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// <seealso cref="Amazon.ImportExport.IAmazonImportExport.UpdateJob"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateJobRequestMarshaller();
            var unmarshaller = UpdateJobResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdateJobRequest, UpdateJobResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
