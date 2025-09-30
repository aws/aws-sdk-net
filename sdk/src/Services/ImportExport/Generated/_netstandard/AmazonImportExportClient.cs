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
 * Do not modify this file. This file is generated from the importexport-2010-06-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ImportExport.Model;
using Amazon.ImportExport.Model.Internal.MarshallTransformations;
using Amazon.ImportExport.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ImportExport
{
    /// <summary>
    /// <para>Implementation for accessing ImportExport</para>
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
        private static IServiceMetadata serviceMetadata = new AmazonImportExportMetadata();
        
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
            : base(new AmazonImportExportConfig()) { }

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
            : base(new AmazonImportExportConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonImportExportEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonImportExportAuthSchemeHandler());
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


        #region  CancelJob

        internal virtual CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobResponse>(request, options);
        }



        /// <summary>
        /// This operation cancels a specified job. Only the job owner can cancel it. The operation
        /// fails if the job has already started or is complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/importexport-2010-06-01/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateJob

        internal virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }



        /// <summary>
        /// This operation initiates the process of scheduling an upload or download of your data.
        /// You include in the request a manifest that describes the data transfer specifics.
        /// The response to the request includes a job ID, which you can use in other operations,
        /// a signature that you use to identify your storage device, and the address where you
        /// should ship your storage device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/importexport-2010-06-01/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetShippingLabel

        internal virtual GetShippingLabelResponse GetShippingLabel(GetShippingLabelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetShippingLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetShippingLabelResponseUnmarshaller.Instance;

            return Invoke<GetShippingLabelResponse>(request, options);
        }



        /// <summary>
        /// This operation generates a pre-paid UPS shipping label that you will use to ship your
        /// device to AWS for processing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetShippingLabel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/importexport-2010-06-01/GetShippingLabel">REST API Reference for GetShippingLabel Operation</seealso>
        public virtual Task<GetShippingLabelResponse> GetShippingLabelAsync(GetShippingLabelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetShippingLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetShippingLabelResponseUnmarshaller.Instance;

            return InvokeAsync<GetShippingLabelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetStatus

        internal virtual GetStatusResponse GetStatus(GetStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStatusResponseUnmarshaller.Instance;

            return Invoke<GetStatusResponse>(request, options);
        }



        /// <summary>
        /// This operation returns information about a job, including where the job is in the
        /// processing pipeline, the status of the results, and the signature value associated
        /// with the job. You can only return information about jobs you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/importexport-2010-06-01/GetStatus">REST API Reference for GetStatus Operation</seealso>
        public virtual Task<GetStatusResponse> GetStatusAsync(GetStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListJobs

        internal virtual ListJobsResponse ListJobs()
        {
            return ListJobs(new ListJobsRequest());
        }
        internal virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }


        /// <summary>
        /// This operation returns the jobs associated with the requester. AWS Import/Export lists
        /// the jobs in reverse chronological order based on the date of creation. For example
        /// if Job Test1 was created 2009Dec30 and Test2 was created 2010Feb05, the ListJobs operation
        /// would return Test2 followed by Test1.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/importexport-2010-06-01/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListJobsAsync(new ListJobsRequest(), cancellationToken);
        }



        /// <summary>
        /// This operation returns the jobs associated with the requester. AWS Import/Export lists
        /// the jobs in reverse chronological order based on the date of creation. For example
        /// if Job Test1 was created 2009Dec30 and Test2 was created 2010Feb05, the ListJobs operation
        /// would return Test2 followed by Test1.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/importexport-2010-06-01/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateJob

        internal virtual UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return Invoke<UpdateJobResponse>(request, options);
        }



        /// <summary>
        /// You use this operation to change the parameters specified in the original manifest
        /// file by supplying a new manifest file. The manifest file attached to this request
        /// replaces the original manifest file. You can only use the operation after a CreateJob
        /// request but before the data transfer starts and you can only use it on jobs you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/importexport-2010-06-01/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}