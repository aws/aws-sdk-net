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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.BackupSearch.Model;
using Amazon.BackupSearch.Model.Internal.MarshallTransformations;
using Amazon.BackupSearch.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.BackupSearch
{
    /// <summary>
    /// <para>Implementation for accessing BackupSearch</para>
    ///
    /// Backup Search 
    /// <para>
    /// Backup Search is the recovery point and item level search for Backup.
    /// 
    ///  
    /// <para>
    /// For additional information, see:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/api-reference.html">Backup
    /// API Reference</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/whatisbackup.html">Backup
    /// Developer Guide</a> 
    /// </para>
    ///  </li> </ul>
    /// </para>
    /// </summary>
    public partial class AmazonBackupSearchClient : AmazonServiceClient, IAmazonBackupSearch
    {
        private static IServiceMetadata serviceMetadata = new AmazonBackupSearchMetadata();
        private IBackupSearchPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBackupSearchPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BackupSearchPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonBackupSearchClient with the credentials loaded from the application's
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
        public AmazonBackupSearchClient()
            : base(new AmazonBackupSearchConfig()) { }

        /// <summary>
        /// Constructs AmazonBackupSearchClient with the credentials loaded from the application's
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
        public AmazonBackupSearchClient(RegionEndpoint region)
            : base(new AmazonBackupSearchConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBackupSearchClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBackupSearchClient Configuration Object</param>
        public AmazonBackupSearchClient(AmazonBackupSearchConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonBackupSearchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBackupSearchClient(AWSCredentials credentials)
            : this(credentials, new AmazonBackupSearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupSearchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupSearchClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBackupSearchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupSearchClient with AWS Credentials and an
        /// AmazonBackupSearchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBackupSearchClient Configuration Object</param>
        public AmazonBackupSearchClient(AWSCredentials credentials, AmazonBackupSearchConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBackupSearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBackupSearchClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBackupSearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupSearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupSearchClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBackupSearchConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupSearchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBackupSearchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBackupSearchClient Configuration Object</param>
        public AmazonBackupSearchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBackupSearchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBackupSearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBackupSearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBackupSearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupSearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupSearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBackupSearchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupSearchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBackupSearchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBackupSearchClient Configuration Object</param>
        public AmazonBackupSearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBackupSearchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBackupSearchEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBackupSearchAuthSchemeHandler());
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


        #region  GetSearchJob


        /// <summary>
        /// This operation retrieves metadata of a search job, including its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSearchJob service method.</param>
        /// 
        /// <returns>The response from the GetSearchJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/GetSearchJob">REST API Reference for GetSearchJob Operation</seealso>
        public virtual GetSearchJobResponse GetSearchJob(GetSearchJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSearchJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSearchJobResponseUnmarshaller.Instance;

            return Invoke<GetSearchJobResponse>(request, options);
        }


        /// <summary>
        /// This operation retrieves metadata of a search job, including its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSearchJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSearchJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/GetSearchJob">REST API Reference for GetSearchJob Operation</seealso>
        public virtual Task<GetSearchJobResponse> GetSearchJobAsync(GetSearchJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSearchJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSearchJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSearchJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSearchResultExportJob


        /// <summary>
        /// This operation retrieves the metadata of an export job.
        /// 
        ///  
        /// <para>
        /// An export job is an operation that transmits the results of a search job to a specified
        /// S3 bucket in a .csv file.
        /// </para>
        ///  
        /// <para>
        /// An export job allows you to retain results of a search beyond the search job's scheduled
        /// retention of 7 days.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSearchResultExportJob service method.</param>
        /// 
        /// <returns>The response from the GetSearchResultExportJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/GetSearchResultExportJob">REST API Reference for GetSearchResultExportJob Operation</seealso>
        public virtual GetSearchResultExportJobResponse GetSearchResultExportJob(GetSearchResultExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSearchResultExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSearchResultExportJobResponseUnmarshaller.Instance;

            return Invoke<GetSearchResultExportJobResponse>(request, options);
        }


        /// <summary>
        /// This operation retrieves the metadata of an export job.
        /// 
        ///  
        /// <para>
        /// An export job is an operation that transmits the results of a search job to a specified
        /// S3 bucket in a .csv file.
        /// </para>
        ///  
        /// <para>
        /// An export job allows you to retain results of a search beyond the search job's scheduled
        /// retention of 7 days.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSearchResultExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSearchResultExportJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/GetSearchResultExportJob">REST API Reference for GetSearchResultExportJob Operation</seealso>
        public virtual Task<GetSearchResultExportJobResponse> GetSearchResultExportJobAsync(GetSearchResultExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSearchResultExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSearchResultExportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSearchResultExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSearchJobBackups


        /// <summary>
        /// This operation returns a list of all backups (recovery points) in a paginated format
        /// that were included in the search job.
        /// 
        ///  
        /// <para>
        /// If a search does not display an expected backup in the results, you can call this
        /// operation to display each backup included in the search. Any backups that were not
        /// included because they have a <c>FAILED</c> status from a permissions issue will be
        /// displayed, along with a status message.
        /// </para>
        ///  
        /// <para>
        /// Only recovery points with a backup index that has a status of <c>ACTIVE</c> will be
        /// included in search results. If the index has any other status, its status will be
        /// displayed along with a status message.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSearchJobBackups service method.</param>
        /// 
        /// <returns>The response from the ListSearchJobBackups service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobBackups">REST API Reference for ListSearchJobBackups Operation</seealso>
        public virtual ListSearchJobBackupsResponse ListSearchJobBackups(ListSearchJobBackupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSearchJobBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSearchJobBackupsResponseUnmarshaller.Instance;

            return Invoke<ListSearchJobBackupsResponse>(request, options);
        }


        /// <summary>
        /// This operation returns a list of all backups (recovery points) in a paginated format
        /// that were included in the search job.
        /// 
        ///  
        /// <para>
        /// If a search does not display an expected backup in the results, you can call this
        /// operation to display each backup included in the search. Any backups that were not
        /// included because they have a <c>FAILED</c> status from a permissions issue will be
        /// displayed, along with a status message.
        /// </para>
        ///  
        /// <para>
        /// Only recovery points with a backup index that has a status of <c>ACTIVE</c> will be
        /// included in search results. If the index has any other status, its status will be
        /// displayed along with a status message.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSearchJobBackups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSearchJobBackups service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobBackups">REST API Reference for ListSearchJobBackups Operation</seealso>
        public virtual Task<ListSearchJobBackupsResponse> ListSearchJobBackupsAsync(ListSearchJobBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSearchJobBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSearchJobBackupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSearchJobBackupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSearchJobResults


        /// <summary>
        /// This operation returns a list of a specified search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSearchJobResults service method.</param>
        /// 
        /// <returns>The response from the ListSearchJobResults service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobResults">REST API Reference for ListSearchJobResults Operation</seealso>
        public virtual ListSearchJobResultsResponse ListSearchJobResults(ListSearchJobResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSearchJobResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSearchJobResultsResponseUnmarshaller.Instance;

            return Invoke<ListSearchJobResultsResponse>(request, options);
        }


        /// <summary>
        /// This operation returns a list of a specified search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSearchJobResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSearchJobResults service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobResults">REST API Reference for ListSearchJobResults Operation</seealso>
        public virtual Task<ListSearchJobResultsResponse> ListSearchJobResultsAsync(ListSearchJobResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSearchJobResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSearchJobResultsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSearchJobResultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSearchJobs


        /// <summary>
        /// This operation returns a list of search jobs belonging to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSearchJobs service method.</param>
        /// 
        /// <returns>The response from the ListSearchJobs service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobs">REST API Reference for ListSearchJobs Operation</seealso>
        public virtual ListSearchJobsResponse ListSearchJobs(ListSearchJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSearchJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSearchJobsResponseUnmarshaller.Instance;

            return Invoke<ListSearchJobsResponse>(request, options);
        }


        /// <summary>
        /// This operation returns a list of search jobs belonging to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSearchJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSearchJobs service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchJobs">REST API Reference for ListSearchJobs Operation</seealso>
        public virtual Task<ListSearchJobsResponse> ListSearchJobsAsync(ListSearchJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSearchJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSearchJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSearchJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSearchResultExportJobs


        /// <summary>
        /// This operation exports search results of a search job to a specified destination S3
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSearchResultExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListSearchResultExportJobs service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ServiceQuotaExceededException">
        /// The request denied due to exceeding the quota limits permitted.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchResultExportJobs">REST API Reference for ListSearchResultExportJobs Operation</seealso>
        public virtual ListSearchResultExportJobsResponse ListSearchResultExportJobs(ListSearchResultExportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSearchResultExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSearchResultExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListSearchResultExportJobsResponse>(request, options);
        }


        /// <summary>
        /// This operation exports search results of a search job to a specified destination S3
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSearchResultExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSearchResultExportJobs service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ServiceQuotaExceededException">
        /// The request denied due to exceeding the quota limits permitted.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListSearchResultExportJobs">REST API Reference for ListSearchResultExportJobs Operation</seealso>
        public virtual Task<ListSearchResultExportJobsResponse> ListSearchResultExportJobsAsync(ListSearchResultExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSearchResultExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSearchResultExportJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSearchResultExportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// This operation returns the tags for a resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// This operation returns the tags for a resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSearchJob


        /// <summary>
        /// This operation creates a search job which returns recovery points filtered by SearchScope
        /// and items filtered by ItemFilters.
        /// 
        ///  
        /// <para>
        /// You can optionally include ClientToken, EncryptionKeyArn, Name, and/or Tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSearchJob service method.</param>
        /// 
        /// <returns>The response from the StartSearchJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful operation is detected.
        /// This generally occurs when the previous operation did not have time to propagate to
        /// the host serving the current request.
        /// 
        ///  
        /// <para>
        /// A retry (with appropriate backoff logic) is the recommended response to this exception.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ServiceQuotaExceededException">
        /// The request denied due to exceeding the quota limits permitted.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StartSearchJob">REST API Reference for StartSearchJob Operation</seealso>
        public virtual StartSearchJobResponse StartSearchJob(StartSearchJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSearchJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSearchJobResponseUnmarshaller.Instance;

            return Invoke<StartSearchJobResponse>(request, options);
        }


        /// <summary>
        /// This operation creates a search job which returns recovery points filtered by SearchScope
        /// and items filtered by ItemFilters.
        /// 
        ///  
        /// <para>
        /// You can optionally include ClientToken, EncryptionKeyArn, Name, and/or Tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSearchJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSearchJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful operation is detected.
        /// This generally occurs when the previous operation did not have time to propagate to
        /// the host serving the current request.
        /// 
        ///  
        /// <para>
        /// A retry (with appropriate backoff logic) is the recommended response to this exception.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ServiceQuotaExceededException">
        /// The request denied due to exceeding the quota limits permitted.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StartSearchJob">REST API Reference for StartSearchJob Operation</seealso>
        public virtual Task<StartSearchJobResponse> StartSearchJobAsync(StartSearchJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSearchJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSearchJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartSearchJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSearchResultExportJob


        /// <summary>
        /// This operations starts a job to export the results of search job to a designated S3
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSearchResultExportJob service method.</param>
        /// 
        /// <returns>The response from the StartSearchResultExportJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful operation is detected.
        /// This generally occurs when the previous operation did not have time to propagate to
        /// the host serving the current request.
        /// 
        ///  
        /// <para>
        /// A retry (with appropriate backoff logic) is the recommended response to this exception.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ServiceQuotaExceededException">
        /// The request denied due to exceeding the quota limits permitted.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StartSearchResultExportJob">REST API Reference for StartSearchResultExportJob Operation</seealso>
        public virtual StartSearchResultExportJobResponse StartSearchResultExportJob(StartSearchResultExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSearchResultExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSearchResultExportJobResponseUnmarshaller.Instance;

            return Invoke<StartSearchResultExportJobResponse>(request, options);
        }


        /// <summary>
        /// This operations starts a job to export the results of search job to a designated S3
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSearchResultExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSearchResultExportJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful operation is detected.
        /// This generally occurs when the previous operation did not have time to propagate to
        /// the host serving the current request.
        /// 
        ///  
        /// <para>
        /// A retry (with appropriate backoff logic) is the recommended response to this exception.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ServiceQuotaExceededException">
        /// The request denied due to exceeding the quota limits permitted.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StartSearchResultExportJob">REST API Reference for StartSearchResultExportJob Operation</seealso>
        public virtual Task<StartSearchResultExportJobResponse> StartSearchResultExportJobAsync(StartSearchResultExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSearchResultExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSearchResultExportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartSearchResultExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopSearchJob


        /// <summary>
        /// This operations ends a search job.
        /// 
        ///  
        /// <para>
        /// Only a search job with a status of <c>RUNNING</c> can be stopped.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSearchJob service method.</param>
        /// 
        /// <returns>The response from the StopSearchJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful operation is detected.
        /// This generally occurs when the previous operation did not have time to propagate to
        /// the host serving the current request.
        /// 
        ///  
        /// <para>
        /// A retry (with appropriate backoff logic) is the recommended response to this exception.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StopSearchJob">REST API Reference for StopSearchJob Operation</seealso>
        public virtual StopSearchJobResponse StopSearchJob(StopSearchJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopSearchJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSearchJobResponseUnmarshaller.Instance;

            return Invoke<StopSearchJobResponse>(request, options);
        }


        /// <summary>
        /// This operations ends a search job.
        /// 
        ///  
        /// <para>
        /// Only a search job with a status of <c>RUNNING</c> can be stopped.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSearchJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopSearchJob service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ConflictException">
        /// This exception occurs when a conflict with a previous successful operation is detected.
        /// This generally occurs when the previous operation did not have time to propagate to
        /// the host serving the current request.
        /// 
        ///  
        /// <para>
        /// A retry (with appropriate backoff logic) is the recommended response to this exception.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/StopSearchJob">REST API Reference for StopSearchJob Operation</seealso>
        public virtual Task<StopSearchJobResponse> StopSearchJobAsync(StopSearchJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopSearchJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSearchJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopSearchJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// This operation puts tags on the resource you indicate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// This operation puts tags on the resource you indicate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// This operation removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// This operation removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BackupSearch.</returns>
        /// <exception cref="Amazon.BackupSearch.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ResourceNotFoundException">
        /// The resource was not found for this request.
        /// 
        ///  
        /// <para>
        /// Confirm the resource information, such as the ARN or type is correct and exists, then
        /// retry the request.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BackupSearch.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by a service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupsearch-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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