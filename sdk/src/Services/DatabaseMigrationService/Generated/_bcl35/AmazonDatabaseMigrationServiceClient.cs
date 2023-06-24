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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.DatabaseMigrationService.Model;
using Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations;
using Amazon.DatabaseMigrationService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DatabaseMigrationService
{
    /// <summary>
    /// Implementation for accessing DatabaseMigrationService
    ///
    /// Database Migration Service 
    /// <para>
    /// Database Migration Service (DMS) can migrate your data to and from the most widely
    /// used commercial and open-source databases such as Oracle, PostgreSQL, Microsoft SQL
    /// Server, Amazon Redshift, MariaDB, Amazon Aurora, MySQL, and SAP Adaptive Server Enterprise
    /// (ASE). The service supports homogeneous migrations such as Oracle to Oracle, as well
    /// as heterogeneous migrations between different database platforms, such as Oracle to
    /// MySQL or SQL Server to PostgreSQL.
    /// </para>
    ///  
    /// <para>
    /// For more information about DMS, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/Welcome.html">What
    /// Is Database Migration Service?</a> in the <i>Database Migration Service User Guide.</i>
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonDatabaseMigrationServiceClient : AmazonServiceClient, IAmazonDatabaseMigrationService
    {
        private static IServiceMetadata serviceMetadata = new AmazonDatabaseMigrationServiceMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IDatabaseMigrationServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDatabaseMigrationServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DatabaseMigrationServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with the credentials loaded from the application's
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
        public AmazonDatabaseMigrationServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDatabaseMigrationServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with the credentials loaded from the application's
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
        public AmazonDatabaseMigrationServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDatabaseMigrationServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDatabaseMigrationServiceClient Configuration Object</param>
        public AmazonDatabaseMigrationServiceClient(AmazonDatabaseMigrationServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDatabaseMigrationServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonDatabaseMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDatabaseMigrationServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDatabaseMigrationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Credentials and an
        /// AmazonDatabaseMigrationServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDatabaseMigrationServiceClient Configuration Object</param>
        public AmazonDatabaseMigrationServiceClient(AWSCredentials credentials, AmazonDatabaseMigrationServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDatabaseMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDatabaseMigrationServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDatabaseMigrationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDatabaseMigrationServiceClient Configuration Object</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDatabaseMigrationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDatabaseMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDatabaseMigrationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDatabaseMigrationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDatabaseMigrationServiceClient Configuration Object</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDatabaseMigrationServiceConfig clientConfig)
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
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDatabaseMigrationServiceEndpointResolver());
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


        #region  AddTagsToResource

        /// <summary>
        /// Adds metadata tags to an DMS resource, including replication instance, endpoint, subnet
        /// group, and migration task. These tags can also be used with cost allocation reporting
        /// to track cost associated with DMS resources, or used in a Condition statement in an
        /// IAM policy for DMS. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_Tag.html">
        /// <code>Tag</code> </a> data type description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual IAsyncResult BeginAddTagsToResource(AddTagsToResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToResource.</param>
        /// 
        /// <returns>Returns a  AddTagsToResourceResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse EndAddTagsToResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsToResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ApplyPendingMaintenanceAction

        /// <summary>
        /// Applies a pending maintenance action to a resource (for example, to a replication
        /// instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction service method.</param>
        /// 
        /// <returns>The response from the ApplyPendingMaintenanceAction service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual ApplyPendingMaintenanceActionResponse ApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return Invoke<ApplyPendingMaintenanceActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ApplyPendingMaintenanceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApplyPendingMaintenanceAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual IAsyncResult BeginApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ApplyPendingMaintenanceAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplyPendingMaintenanceAction.</param>
        /// 
        /// <returns>Returns a  ApplyPendingMaintenanceActionResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual ApplyPendingMaintenanceActionResponse EndApplyPendingMaintenanceAction(IAsyncResult asyncResult)
        {
            return EndInvoke<ApplyPendingMaintenanceActionResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchStartRecommendations

        /// <summary>
        /// Starts the analysis of up to 20 source databases to recommend target engines for each
        /// source database. This is a batch version of <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartRecommendations.html">StartRecommendations</a>.
        /// 
        ///  
        /// <para>
        /// The result of analysis of each source database is reported individually in the response.
        /// Because the batch request can result in a combination of successful and unsuccessful
        /// actions, you should check for batch errors even when the call returns an HTTP status
        /// code of <code>200</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchStartRecommendations service method.</param>
        /// 
        /// <returns>The response from the BatchStartRecommendations service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/BatchStartRecommendations">REST API Reference for BatchStartRecommendations Operation</seealso>
        public virtual BatchStartRecommendationsResponse BatchStartRecommendations(BatchStartRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchStartRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchStartRecommendationsResponseUnmarshaller.Instance;

            return Invoke<BatchStartRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchStartRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchStartRecommendations operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchStartRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/BatchStartRecommendations">REST API Reference for BatchStartRecommendations Operation</seealso>
        public virtual IAsyncResult BeginBatchStartRecommendations(BatchStartRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchStartRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchStartRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchStartRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchStartRecommendations.</param>
        /// 
        /// <returns>Returns a  BatchStartRecommendationsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/BatchStartRecommendations">REST API Reference for BatchStartRecommendations Operation</seealso>
        public virtual BatchStartRecommendationsResponse EndBatchStartRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchStartRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelReplicationTaskAssessmentRun

        /// <summary>
        /// Cancels a single premigration assessment run.
        /// 
        ///  
        /// <para>
        /// This operation prevents any individual assessments from running if they haven't started
        /// running. It also attempts to cancel any individual assessments that are currently
        /// running.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelReplicationTaskAssessmentRun service method.</param>
        /// 
        /// <returns>The response from the CancelReplicationTaskAssessmentRun service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CancelReplicationTaskAssessmentRun">REST API Reference for CancelReplicationTaskAssessmentRun Operation</seealso>
        public virtual CancelReplicationTaskAssessmentRunResponse CancelReplicationTaskAssessmentRun(CancelReplicationTaskAssessmentRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelReplicationTaskAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelReplicationTaskAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<CancelReplicationTaskAssessmentRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelReplicationTaskAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelReplicationTaskAssessmentRun operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelReplicationTaskAssessmentRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CancelReplicationTaskAssessmentRun">REST API Reference for CancelReplicationTaskAssessmentRun Operation</seealso>
        public virtual IAsyncResult BeginCancelReplicationTaskAssessmentRun(CancelReplicationTaskAssessmentRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelReplicationTaskAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelReplicationTaskAssessmentRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelReplicationTaskAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelReplicationTaskAssessmentRun.</param>
        /// 
        /// <returns>Returns a  CancelReplicationTaskAssessmentRunResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CancelReplicationTaskAssessmentRun">REST API Reference for CancelReplicationTaskAssessmentRun Operation</seealso>
        public virtual CancelReplicationTaskAssessmentRunResponse EndCancelReplicationTaskAssessmentRun(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelReplicationTaskAssessmentRunResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEndpoint

        /// <summary>
        /// Creates an endpoint using the provided settings.
        /// 
        ///  <note> 
        /// <para>
        /// For a MySQL source or target endpoint, don't explicitly specify the database using
        /// the <code>DatabaseName</code> request parameter on the <code>CreateEndpoint</code>
        /// API call. Specifying <code>DatabaseName</code> when you create a MySQL endpoint replicates
        /// all the task tables to this single database. For MySQL endpoints, you specify the
        /// database only when you specify the schema in the table-mapping rules of the DMS task.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3AccessDeniedException">
        /// Insufficient privileges are preventing access to an Amazon S3 object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreateEndpoint(CreateEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateEndpointResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual CreateEndpointResponse EndCreateEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEventSubscription

        /// <summary>
        /// Creates an DMS event notification subscription. 
        /// 
        ///  
        /// <para>
        /// You can specify the type of source (<code>SourceType</code>) you want to be notified
        /// of, provide a list of DMS source IDs (<code>SourceIds</code>) that triggers the events,
        /// and provide a list of event categories (<code>EventCategories</code>) for events you
        /// want to be notified of. If you specify both the <code>SourceType</code> and <code>SourceIds</code>,
        /// such as <code>SourceType = replication-instance</code> and <code>SourceIdentifier
        /// = my-replinstance</code>, you will be notified of all the replication instance events
        /// for the specified source. If you specify a <code>SourceType</code> but don't specify
        /// a <code>SourceIdentifier</code>, you receive notice of the events for that source
        /// type for all your DMS sources. If you don't specify either <code>SourceType</code>
        /// nor <code>SourceIdentifier</code>, you will be notified of events generated from all
        /// DMS sources belonging to your customer account.
        /// </para>
        ///  
        /// <para>
        /// For more information about DMS events, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html">Working
        /// with Events and Notifications</a> in the <i>Database Migration Service User Guide.</i>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that the DMS account doesn't
        /// have access to.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSDisabledException">
        /// The specified KMS key isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSInvalidStateException">
        /// The state of the specified KMS resource isn't valid for this request.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSNotFoundException">
        /// The specified KMS entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSThrottlingException">
        /// This request triggered KMS request throttling.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.SNSInvalidTopicException">
        /// The SNS topic is invalid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.SNSNoAuthorizationException">
        /// You are not authorized for the SNS subscription.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginCreateEventSubscription(CreateEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventSubscription.</param>
        /// 
        /// <returns>Returns a  CreateEventSubscriptionResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual CreateEventSubscriptionResponse EndCreateEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFleetAdvisorCollector

        /// <summary>
        /// Creates a Fleet Advisor collector using the specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleetAdvisorCollector service method.</param>
        /// 
        /// <returns>The response from the CreateFleetAdvisorCollector service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3AccessDeniedException">
        /// Insufficient privileges are preventing access to an Amazon S3 object.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3ResourceNotFoundException">
        /// A specified Amazon S3 bucket, bucket folder, or other object can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateFleetAdvisorCollector">REST API Reference for CreateFleetAdvisorCollector Operation</seealso>
        public virtual CreateFleetAdvisorCollectorResponse CreateFleetAdvisorCollector(CreateFleetAdvisorCollectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetAdvisorCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetAdvisorCollectorResponseUnmarshaller.Instance;

            return Invoke<CreateFleetAdvisorCollectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleetAdvisorCollector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleetAdvisorCollector operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleetAdvisorCollector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateFleetAdvisorCollector">REST API Reference for CreateFleetAdvisorCollector Operation</seealso>
        public virtual IAsyncResult BeginCreateFleetAdvisorCollector(CreateFleetAdvisorCollectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetAdvisorCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetAdvisorCollectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleetAdvisorCollector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleetAdvisorCollector.</param>
        /// 
        /// <returns>Returns a  CreateFleetAdvisorCollectorResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateFleetAdvisorCollector">REST API Reference for CreateFleetAdvisorCollector Operation</seealso>
        public virtual CreateFleetAdvisorCollectorResponse EndCreateFleetAdvisorCollector(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFleetAdvisorCollectorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReplicationInstance

        /// <summary>
        /// Creates the replication instance using the specified parameters.
        /// 
        ///  
        /// <para>
        /// DMS requires that your account have certain roles with appropriate permissions before
        /// you can create a replication instance. For information on the required roles, see
        /// <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#CHAP_Security.APIRole">Creating
        /// the IAM Roles to Use With the CLI and DMS API</a>. For information on the required
        /// permissions, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#CHAP_Security.IAMPermissions">IAM
        /// Permissions Needed to Use DMS</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InsufficientResourceCapacityException">
        /// There are not enough resources allocated to the database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// The subnet provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ReplicationSubnetGroupDoesNotCoverEnoughAZsException">
        /// The replication subnet group does not cover enough Availability Zones (AZs). Edit
        /// the replication subnet group and add more AZs.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.StorageQuotaExceededException">
        /// The storage quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationInstance">REST API Reference for CreateReplicationInstance Operation</seealso>
        public virtual CreateReplicationInstanceResponse CreateReplicationInstance(CreateReplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationInstance operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationInstance">REST API Reference for CreateReplicationInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateReplicationInstance(CreateReplicationInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationInstance.</param>
        /// 
        /// <returns>Returns a  CreateReplicationInstanceResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationInstance">REST API Reference for CreateReplicationInstance Operation</seealso>
        public virtual CreateReplicationInstanceResponse EndCreateReplicationInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReplicationInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReplicationSubnetGroup

        /// <summary>
        /// Creates a replication subnet group given a list of the subnet IDs in a VPC.
        /// 
        ///  
        /// <para>
        /// The VPC needs to have at least one subnet in at least two availability zones in the
        /// Amazon Web Services Region, otherwise the service will throw a <code>ReplicationSubnetGroupDoesNotCoverEnoughAZs</code>
        /// exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationSubnetGroup service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// The subnet provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ReplicationSubnetGroupDoesNotCoverEnoughAZsException">
        /// The replication subnet group does not cover enough Availability Zones (AZs). Edit
        /// the replication subnet group and add more AZs.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationSubnetGroup">REST API Reference for CreateReplicationSubnetGroup Operation</seealso>
        public virtual CreateReplicationSubnetGroupResponse CreateReplicationSubnetGroup(CreateReplicationSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSubnetGroup operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationSubnetGroup">REST API Reference for CreateReplicationSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateReplicationSubnetGroup(CreateReplicationSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationSubnetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationSubnetGroup.</param>
        /// 
        /// <returns>Returns a  CreateReplicationSubnetGroupResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationSubnetGroup">REST API Reference for CreateReplicationSubnetGroup Operation</seealso>
        public virtual CreateReplicationSubnetGroupResponse EndCreateReplicationSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReplicationSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReplicationTask

        /// <summary>
        /// Creates a replication task using the specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationTask service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationTask">REST API Reference for CreateReplicationTask Operation</seealso>
        public virtual CreateReplicationTaskResponse CreateReplicationTask(CreateReplicationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationTask operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationTask">REST API Reference for CreateReplicationTask Operation</seealso>
        public virtual IAsyncResult BeginCreateReplicationTask(CreateReplicationTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationTask.</param>
        /// 
        /// <returns>Returns a  CreateReplicationTaskResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationTask">REST API Reference for CreateReplicationTask Operation</seealso>
        public virtual CreateReplicationTaskResponse EndCreateReplicationTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReplicationTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCertificate

        /// <summary>
        /// Deletes the specified certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual IAsyncResult BeginDeleteCertificate(DeleteCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteCertificateResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual DeleteCertificateResponse EndDeleteCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnection

        /// <summary>
        /// Deletes the connection between a replication instance and an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnection(DeleteConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEndpoint

        /// <summary>
        /// Deletes the specified endpoint.
        /// 
        ///  <note> 
        /// <para>
        /// All tasks associated with the endpoint must be deleted before you can delete the endpoint.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventSubscription

        /// <summary>
        /// Deletes an DMS event subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventSubscription(DeleteEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteEventSubscriptionResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual DeleteEventSubscriptionResponse EndDeleteEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFleetAdvisorCollector

        /// <summary>
        /// Deletes the specified Fleet Advisor collector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleetAdvisorCollector service method.</param>
        /// 
        /// <returns>The response from the DeleteFleetAdvisorCollector service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.CollectorNotFoundException">
        /// The specified collector doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteFleetAdvisorCollector">REST API Reference for DeleteFleetAdvisorCollector Operation</seealso>
        public virtual DeleteFleetAdvisorCollectorResponse DeleteFleetAdvisorCollector(DeleteFleetAdvisorCollectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetAdvisorCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetAdvisorCollectorResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetAdvisorCollectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleetAdvisorCollector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleetAdvisorCollector operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleetAdvisorCollector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteFleetAdvisorCollector">REST API Reference for DeleteFleetAdvisorCollector Operation</seealso>
        public virtual IAsyncResult BeginDeleteFleetAdvisorCollector(DeleteFleetAdvisorCollectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetAdvisorCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetAdvisorCollectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleetAdvisorCollector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleetAdvisorCollector.</param>
        /// 
        /// <returns>Returns a  DeleteFleetAdvisorCollectorResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteFleetAdvisorCollector">REST API Reference for DeleteFleetAdvisorCollector Operation</seealso>
        public virtual DeleteFleetAdvisorCollectorResponse EndDeleteFleetAdvisorCollector(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFleetAdvisorCollectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFleetAdvisorDatabases

        /// <summary>
        /// Deletes the specified Fleet Advisor collector databases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleetAdvisorDatabases service method.</param>
        /// 
        /// <returns>The response from the DeleteFleetAdvisorDatabases service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidOperationException">
        /// The action or operation requested isn't valid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteFleetAdvisorDatabases">REST API Reference for DeleteFleetAdvisorDatabases Operation</seealso>
        public virtual DeleteFleetAdvisorDatabasesResponse DeleteFleetAdvisorDatabases(DeleteFleetAdvisorDatabasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetAdvisorDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetAdvisorDatabasesResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetAdvisorDatabasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleetAdvisorDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleetAdvisorDatabases operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleetAdvisorDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteFleetAdvisorDatabases">REST API Reference for DeleteFleetAdvisorDatabases Operation</seealso>
        public virtual IAsyncResult BeginDeleteFleetAdvisorDatabases(DeleteFleetAdvisorDatabasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetAdvisorDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetAdvisorDatabasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleetAdvisorDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleetAdvisorDatabases.</param>
        /// 
        /// <returns>Returns a  DeleteFleetAdvisorDatabasesResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteFleetAdvisorDatabases">REST API Reference for DeleteFleetAdvisorDatabases Operation</seealso>
        public virtual DeleteFleetAdvisorDatabasesResponse EndDeleteFleetAdvisorDatabases(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFleetAdvisorDatabasesResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReplicationInstance

        /// <summary>
        /// Deletes the specified replication instance.
        /// 
        ///  <note> 
        /// <para>
        /// You must delete any migration tasks that are associated with the replication instance
        /// before you can delete it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationInstance">REST API Reference for DeleteReplicationInstance Operation</seealso>
        public virtual DeleteReplicationInstanceResponse DeleteReplicationInstance(DeleteReplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationInstance operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationInstance">REST API Reference for DeleteReplicationInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteReplicationInstance(DeleteReplicationInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationInstance.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationInstanceResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationInstance">REST API Reference for DeleteReplicationInstance Operation</seealso>
        public virtual DeleteReplicationInstanceResponse EndDeleteReplicationInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReplicationInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReplicationSubnetGroup

        /// <summary>
        /// Deletes a subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationSubnetGroup service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationSubnetGroup">REST API Reference for DeleteReplicationSubnetGroup Operation</seealso>
        public virtual DeleteReplicationSubnetGroupResponse DeleteReplicationSubnetGroup(DeleteReplicationSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSubnetGroup operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationSubnetGroup">REST API Reference for DeleteReplicationSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteReplicationSubnetGroup(DeleteReplicationSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationSubnetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationSubnetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationSubnetGroupResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationSubnetGroup">REST API Reference for DeleteReplicationSubnetGroup Operation</seealso>
        public virtual DeleteReplicationSubnetGroupResponse EndDeleteReplicationSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReplicationSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReplicationTask

        /// <summary>
        /// Deletes the specified replication task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationTask service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationTask">REST API Reference for DeleteReplicationTask Operation</seealso>
        public virtual DeleteReplicationTaskResponse DeleteReplicationTask(DeleteReplicationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationTask operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationTask">REST API Reference for DeleteReplicationTask Operation</seealso>
        public virtual IAsyncResult BeginDeleteReplicationTask(DeleteReplicationTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationTask.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationTaskResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationTask">REST API Reference for DeleteReplicationTask Operation</seealso>
        public virtual DeleteReplicationTaskResponse EndDeleteReplicationTask(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReplicationTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReplicationTaskAssessmentRun

        /// <summary>
        /// Deletes the record of a single premigration assessment run.
        /// 
        ///  
        /// <para>
        /// This operation removes all metadata that DMS maintains about this assessment run.
        /// However, the operation leaves untouched all information about this assessment run
        /// that is stored in your Amazon S3 bucket.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationTaskAssessmentRun service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationTaskAssessmentRun service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationTaskAssessmentRun">REST API Reference for DeleteReplicationTaskAssessmentRun Operation</seealso>
        public virtual DeleteReplicationTaskAssessmentRunResponse DeleteReplicationTaskAssessmentRun(DeleteReplicationTaskAssessmentRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationTaskAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationTaskAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationTaskAssessmentRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationTaskAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationTaskAssessmentRun operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationTaskAssessmentRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationTaskAssessmentRun">REST API Reference for DeleteReplicationTaskAssessmentRun Operation</seealso>
        public virtual IAsyncResult BeginDeleteReplicationTaskAssessmentRun(DeleteReplicationTaskAssessmentRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationTaskAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationTaskAssessmentRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationTaskAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationTaskAssessmentRun.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationTaskAssessmentRunResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationTaskAssessmentRun">REST API Reference for DeleteReplicationTaskAssessmentRun Operation</seealso>
        public virtual DeleteReplicationTaskAssessmentRunResponse EndDeleteReplicationTaskAssessmentRun(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReplicationTaskAssessmentRunResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        /// <summary>
        /// Lists all of the DMS attributes for a customer account. These attributes include DMS
        /// quotas for the account and a unique account identifier in a particular DMS region.
        /// DMS quotas include a list of resource quotas supported by the account, such as the
        /// number of replication instances allowed. The description for each resource quota,
        /// includes the quota name, current usage toward that quota, and the quota's maximum
        /// value. DMS uses the unique account identifier to name each artifact used by DMS in
        /// the given region.
        /// 
        ///  
        /// <para>
        /// This command does not take any parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccountAttributes(DescribeAccountAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAttributesResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse EndDescribeAccountAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeApplicableIndividualAssessments

        /// <summary>
        /// Provides a list of individual assessments that you can specify for a new premigration
        /// assessment run, given one or more parameters.
        /// 
        ///  
        /// <para>
        /// If you specify an existing migration task, this operation provides the default individual
        /// assessments you can specify for that task. Otherwise, the specified parameters model
        /// elements of a possible migration task on which to base a premigration assessment run.
        /// </para>
        ///  
        /// <para>
        /// To use these migration task modeling parameters, you must specify an existing replication
        /// instance, a source database engine, a target database engine, and a migration type.
        /// This combination of parameters potentially limits the default individual assessments
        /// available for an assessment run created for a corresponding migration task.
        /// </para>
        ///  
        /// <para>
        /// If you specify no parameters, this operation provides a list of all possible individual
        /// assessments that you can specify for an assessment run. If you specify any one of
        /// the task modeling parameters, you must specify all of them or the operation cannot
        /// provide a list of individual assessments. The only parameter that you can specify
        /// alone is for an existing migration task. The specified task definition then determines
        /// the default list of individual assessments that you can specify in an assessment run
        /// for the task.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicableIndividualAssessments service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicableIndividualAssessments service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeApplicableIndividualAssessments">REST API Reference for DescribeApplicableIndividualAssessments Operation</seealso>
        public virtual DescribeApplicableIndividualAssessmentsResponse DescribeApplicableIndividualAssessments(DescribeApplicableIndividualAssessmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicableIndividualAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicableIndividualAssessmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicableIndividualAssessmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicableIndividualAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicableIndividualAssessments operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicableIndividualAssessments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeApplicableIndividualAssessments">REST API Reference for DescribeApplicableIndividualAssessments Operation</seealso>
        public virtual IAsyncResult BeginDescribeApplicableIndividualAssessments(DescribeApplicableIndividualAssessmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicableIndividualAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicableIndividualAssessmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicableIndividualAssessments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicableIndividualAssessments.</param>
        /// 
        /// <returns>Returns a  DescribeApplicableIndividualAssessmentsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeApplicableIndividualAssessments">REST API Reference for DescribeApplicableIndividualAssessments Operation</seealso>
        public virtual DescribeApplicableIndividualAssessmentsResponse EndDescribeApplicableIndividualAssessments(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeApplicableIndividualAssessmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCertificates

        /// <summary>
        /// Provides a description of the certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificates service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual DescribeCertificatesResponse DescribeCertificates(DescribeCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual IAsyncResult BeginDescribeCertificates(DescribeCertificatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCertificates.</param>
        /// 
        /// <returns>Returns a  DescribeCertificatesResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual DescribeCertificatesResponse EndDescribeCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCertificatesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConnections

        /// <summary>
        /// Describes the status of the connections that have been made between the replication
        /// instance and an endpoint. Connections are created when you test an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual IAsyncResult BeginDescribeConnections(DescribeConnectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnections.</param>
        /// 
        /// <returns>Returns a  DescribeConnectionsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual DescribeConnectionsResponse EndDescribeConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEndpoints

        /// <summary>
        /// Returns information about the endpoints for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        public virtual DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        public virtual IAsyncResult BeginDescribeEndpoints(DescribeEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpoints.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        public virtual DescribeEndpointsResponse EndDescribeEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEndpointSettings

        /// <summary>
        /// Returns information about the possible endpoint settings available when you create
        /// an endpoint for a specific database engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpointSettings service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpointSettings">REST API Reference for DescribeEndpointSettings Operation</seealso>
        public virtual DescribeEndpointSettingsResponse DescribeEndpointSettings(DescribeEndpointSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointSettings operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpointSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpointSettings">REST API Reference for DescribeEndpointSettings Operation</seealso>
        public virtual IAsyncResult BeginDescribeEndpointSettings(DescribeEndpointSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpointSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpointSettings.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointSettingsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpointSettings">REST API Reference for DescribeEndpointSettings Operation</seealso>
        public virtual DescribeEndpointSettingsResponse EndDescribeEndpointSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEndpointSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEndpointTypes

        /// <summary>
        /// Returns information about the type of endpoints available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpointTypes service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpointTypes">REST API Reference for DescribeEndpointTypes Operation</seealso>
        public virtual DescribeEndpointTypesResponse DescribeEndpointTypes(DescribeEndpointTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointTypes operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpointTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpointTypes">REST API Reference for DescribeEndpointTypes Operation</seealso>
        public virtual IAsyncResult BeginDescribeEndpointTypes(DescribeEndpointTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpointTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpointTypes.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointTypesResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpointTypes">REST API Reference for DescribeEndpointTypes Operation</seealso>
        public virtual DescribeEndpointTypesResponse EndDescribeEndpointTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEndpointTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventCategories

        /// <summary>
        /// Lists categories for all event source types, or, if specified, for a specified source
        /// type. You can see a list of the event categories and source types in <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html">Working
        /// with Events and Notifications</a> in the <i>Database Migration Service User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventCategories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventCategories(DescribeEventCategoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventCategories.</param>
        /// 
        /// <returns>Returns a  DescribeEventCategoriesResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse EndDescribeEventCategories(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventCategoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEvents

        /// <summary>
        /// Lists events for a given source identifier and source type. You can also specify
        /// a start and end time. For more information on DMS events, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html">Working
        /// with Events and Notifications</a> in the <i>Database Migration Service User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        /// <summary>
        /// Lists all the event subscriptions for a customer account. The description of a subscription
        /// includes <code>SubscriptionName</code>, <code>SNSTopicARN</code>, <code>CustomerID</code>,
        /// <code>SourceType</code>, <code>SourceID</code>, <code>CreationTime</code>, and <code>Status</code>.
        /// 
        /// 
        ///  
        /// <para>
        /// If you specify <code>SubscriptionName</code>, this action lists the description for
        /// that subscription.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventSubscriptions(DescribeEventSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventSubscriptions.</param>
        /// 
        /// <returns>Returns a  DescribeEventSubscriptionsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse EndDescribeEventSubscriptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventSubscriptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetAdvisorCollectors

        /// <summary>
        /// Returns a list of the Fleet Advisor collectors in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorCollectors service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorCollectors service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorCollectors">REST API Reference for DescribeFleetAdvisorCollectors Operation</seealso>
        public virtual DescribeFleetAdvisorCollectorsResponse DescribeFleetAdvisorCollectors(DescribeFleetAdvisorCollectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorCollectorsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAdvisorCollectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetAdvisorCollectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorCollectors operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetAdvisorCollectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorCollectors">REST API Reference for DescribeFleetAdvisorCollectors Operation</seealso>
        public virtual IAsyncResult BeginDescribeFleetAdvisorCollectors(DescribeFleetAdvisorCollectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorCollectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetAdvisorCollectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetAdvisorCollectors.</param>
        /// 
        /// <returns>Returns a  DescribeFleetAdvisorCollectorsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorCollectors">REST API Reference for DescribeFleetAdvisorCollectors Operation</seealso>
        public virtual DescribeFleetAdvisorCollectorsResponse EndDescribeFleetAdvisorCollectors(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetAdvisorCollectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetAdvisorDatabases

        /// <summary>
        /// Returns a list of Fleet Advisor databases in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorDatabases service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorDatabases service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorDatabases">REST API Reference for DescribeFleetAdvisorDatabases Operation</seealso>
        public virtual DescribeFleetAdvisorDatabasesResponse DescribeFleetAdvisorDatabases(DescribeFleetAdvisorDatabasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorDatabasesResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAdvisorDatabasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetAdvisorDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorDatabases operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetAdvisorDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorDatabases">REST API Reference for DescribeFleetAdvisorDatabases Operation</seealso>
        public virtual IAsyncResult BeginDescribeFleetAdvisorDatabases(DescribeFleetAdvisorDatabasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorDatabasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetAdvisorDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetAdvisorDatabases.</param>
        /// 
        /// <returns>Returns a  DescribeFleetAdvisorDatabasesResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorDatabases">REST API Reference for DescribeFleetAdvisorDatabases Operation</seealso>
        public virtual DescribeFleetAdvisorDatabasesResponse EndDescribeFleetAdvisorDatabases(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetAdvisorDatabasesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetAdvisorLsaAnalysis

        /// <summary>
        /// Provides descriptions of large-scale assessment (LSA) analyses produced by your Fleet
        /// Advisor collectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorLsaAnalysis service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorLsaAnalysis service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorLsaAnalysis">REST API Reference for DescribeFleetAdvisorLsaAnalysis Operation</seealso>
        public virtual DescribeFleetAdvisorLsaAnalysisResponse DescribeFleetAdvisorLsaAnalysis(DescribeFleetAdvisorLsaAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorLsaAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorLsaAnalysisResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAdvisorLsaAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetAdvisorLsaAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorLsaAnalysis operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetAdvisorLsaAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorLsaAnalysis">REST API Reference for DescribeFleetAdvisorLsaAnalysis Operation</seealso>
        public virtual IAsyncResult BeginDescribeFleetAdvisorLsaAnalysis(DescribeFleetAdvisorLsaAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorLsaAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorLsaAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetAdvisorLsaAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetAdvisorLsaAnalysis.</param>
        /// 
        /// <returns>Returns a  DescribeFleetAdvisorLsaAnalysisResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorLsaAnalysis">REST API Reference for DescribeFleetAdvisorLsaAnalysis Operation</seealso>
        public virtual DescribeFleetAdvisorLsaAnalysisResponse EndDescribeFleetAdvisorLsaAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetAdvisorLsaAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetAdvisorSchemaObjectSummary

        /// <summary>
        /// Provides descriptions of the schemas discovered by your Fleet Advisor collectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorSchemaObjectSummary service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorSchemaObjectSummary service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorSchemaObjectSummary">REST API Reference for DescribeFleetAdvisorSchemaObjectSummary Operation</seealso>
        public virtual DescribeFleetAdvisorSchemaObjectSummaryResponse DescribeFleetAdvisorSchemaObjectSummary(DescribeFleetAdvisorSchemaObjectSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorSchemaObjectSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorSchemaObjectSummaryResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAdvisorSchemaObjectSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetAdvisorSchemaObjectSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorSchemaObjectSummary operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetAdvisorSchemaObjectSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorSchemaObjectSummary">REST API Reference for DescribeFleetAdvisorSchemaObjectSummary Operation</seealso>
        public virtual IAsyncResult BeginDescribeFleetAdvisorSchemaObjectSummary(DescribeFleetAdvisorSchemaObjectSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorSchemaObjectSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorSchemaObjectSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetAdvisorSchemaObjectSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetAdvisorSchemaObjectSummary.</param>
        /// 
        /// <returns>Returns a  DescribeFleetAdvisorSchemaObjectSummaryResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorSchemaObjectSummary">REST API Reference for DescribeFleetAdvisorSchemaObjectSummary Operation</seealso>
        public virtual DescribeFleetAdvisorSchemaObjectSummaryResponse EndDescribeFleetAdvisorSchemaObjectSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetAdvisorSchemaObjectSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFleetAdvisorSchemas

        /// <summary>
        /// Returns a list of schemas detected by Fleet Advisor Collectors in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorSchemas service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorSchemas service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorSchemas">REST API Reference for DescribeFleetAdvisorSchemas Operation</seealso>
        public virtual DescribeFleetAdvisorSchemasResponse DescribeFleetAdvisorSchemas(DescribeFleetAdvisorSchemasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorSchemasResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAdvisorSchemasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetAdvisorSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorSchemas operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetAdvisorSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorSchemas">REST API Reference for DescribeFleetAdvisorSchemas Operation</seealso>
        public virtual IAsyncResult BeginDescribeFleetAdvisorSchemas(DescribeFleetAdvisorSchemasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorSchemasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetAdvisorSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetAdvisorSchemas.</param>
        /// 
        /// <returns>Returns a  DescribeFleetAdvisorSchemasResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorSchemas">REST API Reference for DescribeFleetAdvisorSchemas Operation</seealso>
        public virtual DescribeFleetAdvisorSchemasResponse EndDescribeFleetAdvisorSchemas(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFleetAdvisorSchemasResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOrderableReplicationInstances

        /// <summary>
        /// Returns information about the replication instance types that can be created in the
        /// specified region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableReplicationInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableReplicationInstances service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeOrderableReplicationInstances">REST API Reference for DescribeOrderableReplicationInstances Operation</seealso>
        public virtual DescribeOrderableReplicationInstancesResponse DescribeOrderableReplicationInstances(DescribeOrderableReplicationInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrderableReplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableReplicationInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableReplicationInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableReplicationInstances operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrderableReplicationInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeOrderableReplicationInstances">REST API Reference for DescribeOrderableReplicationInstances Operation</seealso>
        public virtual IAsyncResult BeginDescribeOrderableReplicationInstances(DescribeOrderableReplicationInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrderableReplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableReplicationInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrderableReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrderableReplicationInstances.</param>
        /// 
        /// <returns>Returns a  DescribeOrderableReplicationInstancesResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeOrderableReplicationInstances">REST API Reference for DescribeOrderableReplicationInstances Operation</seealso>
        public virtual DescribeOrderableReplicationInstancesResponse EndDescribeOrderableReplicationInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOrderableReplicationInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePendingMaintenanceActions

        /// <summary>
        /// For internal use only
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions service method.</param>
        /// 
        /// <returns>The response from the DescribePendingMaintenanceActions service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual DescribePendingMaintenanceActionsResponse DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return Invoke<DescribePendingMaintenanceActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePendingMaintenanceActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePendingMaintenanceActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual IAsyncResult BeginDescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePendingMaintenanceActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePendingMaintenanceActions.</param>
        /// 
        /// <returns>Returns a  DescribePendingMaintenanceActionsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual DescribePendingMaintenanceActionsResponse EndDescribePendingMaintenanceActions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePendingMaintenanceActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRecommendationLimitations

        /// <summary>
        /// Returns a paginated list of limitations for recommendations of target Amazon Web Services
        /// engines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationLimitations service method.</param>
        /// 
        /// <returns>The response from the DescribeRecommendationLimitations service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRecommendationLimitations">REST API Reference for DescribeRecommendationLimitations Operation</seealso>
        public virtual DescribeRecommendationLimitationsResponse DescribeRecommendationLimitations(DescribeRecommendationLimitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationLimitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationLimitationsResponseUnmarshaller.Instance;

            return Invoke<DescribeRecommendationLimitationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecommendationLimitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationLimitations operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecommendationLimitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRecommendationLimitations">REST API Reference for DescribeRecommendationLimitations Operation</seealso>
        public virtual IAsyncResult BeginDescribeRecommendationLimitations(DescribeRecommendationLimitationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationLimitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationLimitationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecommendationLimitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecommendationLimitations.</param>
        /// 
        /// <returns>Returns a  DescribeRecommendationLimitationsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRecommendationLimitations">REST API Reference for DescribeRecommendationLimitations Operation</seealso>
        public virtual DescribeRecommendationLimitationsResponse EndDescribeRecommendationLimitations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRecommendationLimitationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRecommendations

        /// <summary>
        /// Returns a paginated list of target engine recommendations for your source databases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendations service method.</param>
        /// 
        /// <returns>The response from the DescribeRecommendations service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRecommendations">REST API Reference for DescribeRecommendations Operation</seealso>
        public virtual DescribeRecommendationsResponse DescribeRecommendations(DescribeRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationsResponseUnmarshaller.Instance;

            return Invoke<DescribeRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendations operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRecommendations">REST API Reference for DescribeRecommendations Operation</seealso>
        public virtual IAsyncResult BeginDescribeRecommendations(DescribeRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecommendations.</param>
        /// 
        /// <returns>Returns a  DescribeRecommendationsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRecommendations">REST API Reference for DescribeRecommendations Operation</seealso>
        public virtual DescribeRecommendationsResponse EndDescribeRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRefreshSchemasStatus

        /// <summary>
        /// Returns the status of the RefreshSchemas operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchemasStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeRefreshSchemasStatus service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRefreshSchemasStatus">REST API Reference for DescribeRefreshSchemasStatus Operation</seealso>
        public virtual DescribeRefreshSchemasStatusResponse DescribeRefreshSchemasStatus(DescribeRefreshSchemasStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRefreshSchemasStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRefreshSchemasStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeRefreshSchemasStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRefreshSchemasStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchemasStatus operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRefreshSchemasStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRefreshSchemasStatus">REST API Reference for DescribeRefreshSchemasStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeRefreshSchemasStatus(DescribeRefreshSchemasStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRefreshSchemasStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRefreshSchemasStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRefreshSchemasStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRefreshSchemasStatus.</param>
        /// 
        /// <returns>Returns a  DescribeRefreshSchemasStatusResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRefreshSchemasStatus">REST API Reference for DescribeRefreshSchemasStatus Operation</seealso>
        public virtual DescribeRefreshSchemasStatusResponse EndDescribeRefreshSchemasStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRefreshSchemasStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReplicationInstances

        /// <summary>
        /// Returns information about replication instances for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationInstances service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstances">REST API Reference for DescribeReplicationInstances Operation</seealso>
        public virtual DescribeReplicationInstancesResponse DescribeReplicationInstances(DescribeReplicationInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstances operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstances">REST API Reference for DescribeReplicationInstances Operation</seealso>
        public virtual IAsyncResult BeginDescribeReplicationInstances(DescribeReplicationInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationInstances.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationInstancesResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstances">REST API Reference for DescribeReplicationInstances Operation</seealso>
        public virtual DescribeReplicationInstancesResponse EndDescribeReplicationInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplicationInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReplicationInstanceTaskLogs

        /// <summary>
        /// Returns information about the task logs for the specified task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstanceTaskLogs service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationInstanceTaskLogs service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstanceTaskLogs">REST API Reference for DescribeReplicationInstanceTaskLogs Operation</seealso>
        public virtual DescribeReplicationInstanceTaskLogsResponse DescribeReplicationInstanceTaskLogs(DescribeReplicationInstanceTaskLogsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationInstanceTaskLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationInstanceTaskLogsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationInstanceTaskLogsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationInstanceTaskLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstanceTaskLogs operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationInstanceTaskLogs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstanceTaskLogs">REST API Reference for DescribeReplicationInstanceTaskLogs Operation</seealso>
        public virtual IAsyncResult BeginDescribeReplicationInstanceTaskLogs(DescribeReplicationInstanceTaskLogsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationInstanceTaskLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationInstanceTaskLogsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationInstanceTaskLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationInstanceTaskLogs.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationInstanceTaskLogsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstanceTaskLogs">REST API Reference for DescribeReplicationInstanceTaskLogs Operation</seealso>
        public virtual DescribeReplicationInstanceTaskLogsResponse EndDescribeReplicationInstanceTaskLogs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplicationInstanceTaskLogsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReplicationSubnetGroups

        /// <summary>
        /// Returns information about the replication subnet groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationSubnetGroups service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationSubnetGroups">REST API Reference for DescribeReplicationSubnetGroups Operation</seealso>
        public virtual DescribeReplicationSubnetGroupsResponse DescribeReplicationSubnetGroups(DescribeReplicationSubnetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationSubnetGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationSubnetGroups operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationSubnetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationSubnetGroups">REST API Reference for DescribeReplicationSubnetGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeReplicationSubnetGroups(DescribeReplicationSubnetGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationSubnetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationSubnetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationSubnetGroupsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationSubnetGroups">REST API Reference for DescribeReplicationSubnetGroups Operation</seealso>
        public virtual DescribeReplicationSubnetGroupsResponse EndDescribeReplicationSubnetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplicationSubnetGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReplicationTaskAssessmentResults

        /// <summary>
        /// Returns the task assessment results from the Amazon S3 bucket that DMS creates in
        /// your Amazon Web Services account. This action always returns the latest results.
        /// 
        ///  
        /// <para>
        /// For more information about DMS task assessments, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.AssessmentReport.html">Creating
        /// a task assessment report</a> in the <i>Database Migration Service User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTaskAssessmentResults service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationTaskAssessmentResults service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskAssessmentResults">REST API Reference for DescribeReplicationTaskAssessmentResults Operation</seealso>
        public virtual DescribeReplicationTaskAssessmentResultsResponse DescribeReplicationTaskAssessmentResults(DescribeReplicationTaskAssessmentResultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskAssessmentResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskAssessmentResultsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTaskAssessmentResultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationTaskAssessmentResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTaskAssessmentResults operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationTaskAssessmentResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskAssessmentResults">REST API Reference for DescribeReplicationTaskAssessmentResults Operation</seealso>
        public virtual IAsyncResult BeginDescribeReplicationTaskAssessmentResults(DescribeReplicationTaskAssessmentResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskAssessmentResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskAssessmentResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationTaskAssessmentResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationTaskAssessmentResults.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationTaskAssessmentResultsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskAssessmentResults">REST API Reference for DescribeReplicationTaskAssessmentResults Operation</seealso>
        public virtual DescribeReplicationTaskAssessmentResultsResponse EndDescribeReplicationTaskAssessmentResults(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplicationTaskAssessmentResultsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReplicationTaskAssessmentRuns

        /// <summary>
        /// Returns a paginated list of premigration assessment runs based on filter settings.
        /// 
        ///  
        /// <para>
        /// These filter settings can specify a combination of premigration assessment runs, migration
        /// tasks, replication instances, and assessment run status values.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation doesn't return information about individual assessments. For this information,
        /// see the <code>DescribeReplicationTaskIndividualAssessments</code> operation. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTaskAssessmentRuns service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationTaskAssessmentRuns service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskAssessmentRuns">REST API Reference for DescribeReplicationTaskAssessmentRuns Operation</seealso>
        public virtual DescribeReplicationTaskAssessmentRunsResponse DescribeReplicationTaskAssessmentRuns(DescribeReplicationTaskAssessmentRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTaskAssessmentRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationTaskAssessmentRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTaskAssessmentRuns operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationTaskAssessmentRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskAssessmentRuns">REST API Reference for DescribeReplicationTaskAssessmentRuns Operation</seealso>
        public virtual IAsyncResult BeginDescribeReplicationTaskAssessmentRuns(DescribeReplicationTaskAssessmentRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskAssessmentRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationTaskAssessmentRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationTaskAssessmentRuns.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationTaskAssessmentRunsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskAssessmentRuns">REST API Reference for DescribeReplicationTaskAssessmentRuns Operation</seealso>
        public virtual DescribeReplicationTaskAssessmentRunsResponse EndDescribeReplicationTaskAssessmentRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplicationTaskAssessmentRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReplicationTaskIndividualAssessments

        /// <summary>
        /// Returns a paginated list of individual assessments based on filter settings.
        /// 
        ///  
        /// <para>
        /// These filter settings can specify a combination of premigration assessment runs, migration
        /// tasks, and assessment status values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTaskIndividualAssessments service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationTaskIndividualAssessments service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskIndividualAssessments">REST API Reference for DescribeReplicationTaskIndividualAssessments Operation</seealso>
        public virtual DescribeReplicationTaskIndividualAssessmentsResponse DescribeReplicationTaskIndividualAssessments(DescribeReplicationTaskIndividualAssessmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskIndividualAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskIndividualAssessmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTaskIndividualAssessmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationTaskIndividualAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTaskIndividualAssessments operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationTaskIndividualAssessments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskIndividualAssessments">REST API Reference for DescribeReplicationTaskIndividualAssessments Operation</seealso>
        public virtual IAsyncResult BeginDescribeReplicationTaskIndividualAssessments(DescribeReplicationTaskIndividualAssessmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskIndividualAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskIndividualAssessmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationTaskIndividualAssessments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationTaskIndividualAssessments.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationTaskIndividualAssessmentsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskIndividualAssessments">REST API Reference for DescribeReplicationTaskIndividualAssessments Operation</seealso>
        public virtual DescribeReplicationTaskIndividualAssessmentsResponse EndDescribeReplicationTaskIndividualAssessments(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplicationTaskIndividualAssessmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReplicationTasks

        /// <summary>
        /// Returns information about replication tasks for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationTasks service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTasks">REST API Reference for DescribeReplicationTasks Operation</seealso>
        public virtual DescribeReplicationTasksResponse DescribeReplicationTasks(DescribeReplicationTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTasks operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTasks">REST API Reference for DescribeReplicationTasks Operation</seealso>
        public virtual IAsyncResult BeginDescribeReplicationTasks(DescribeReplicationTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationTasks.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationTasksResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTasks">REST API Reference for DescribeReplicationTasks Operation</seealso>
        public virtual DescribeReplicationTasksResponse EndDescribeReplicationTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplicationTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSchemas

        /// <summary>
        /// Returns information about the schema for the specified endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchemas service method.</param>
        /// 
        /// <returns>The response from the DescribeSchemas service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeSchemas">REST API Reference for DescribeSchemas Operation</seealso>
        public virtual DescribeSchemasResponse DescribeSchemas(DescribeSchemasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemasResponseUnmarshaller.Instance;

            return Invoke<DescribeSchemasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchemas operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeSchemas">REST API Reference for DescribeSchemas Operation</seealso>
        public virtual IAsyncResult BeginDescribeSchemas(DescribeSchemasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSchemas.</param>
        /// 
        /// <returns>Returns a  DescribeSchemasResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeSchemas">REST API Reference for DescribeSchemas Operation</seealso>
        public virtual DescribeSchemasResponse EndDescribeSchemas(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSchemasResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTableStatistics

        /// <summary>
        /// Returns table statistics on the database migration task, including table name, rows
        /// inserted, rows updated, and rows deleted.
        /// 
        ///  
        /// <para>
        /// Note that the "last updated" column the DMS console only indicates the time that DMS
        /// last updated the table statistics record for a table. It does not indicate the time
        /// of the last update to the table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableStatistics service method.</param>
        /// 
        /// <returns>The response from the DescribeTableStatistics service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeTableStatistics">REST API Reference for DescribeTableStatistics Operation</seealso>
        public virtual DescribeTableStatisticsResponse DescribeTableStatistics(DescribeTableStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableStatisticsResponseUnmarshaller.Instance;

            return Invoke<DescribeTableStatisticsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTableStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableStatistics operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTableStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeTableStatistics">REST API Reference for DescribeTableStatistics Operation</seealso>
        public virtual IAsyncResult BeginDescribeTableStatistics(DescribeTableStatisticsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTableStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTableStatistics.</param>
        /// 
        /// <returns>Returns a  DescribeTableStatisticsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeTableStatistics">REST API Reference for DescribeTableStatistics Operation</seealso>
        public virtual DescribeTableStatisticsResponse EndDescribeTableStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTableStatisticsResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportCertificate

        /// <summary>
        /// Uploads the specified certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidCertificateException">
        /// The certificate was not valid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        public virtual ImportCertificateResponse ImportCertificate(ImportCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return Invoke<ImportCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        public virtual IAsyncResult BeginImportCertificate(ImportCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportCertificate.</param>
        /// 
        /// <returns>Returns a  ImportCertificateResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        public virtual ImportCertificateResponse EndImportCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all metadata tags attached to an DMS resource, including replication instance,
        /// endpoint, subnet group, and migration task. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_Tag.html">
        /// <code>Tag</code> </a> data type description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyEndpoint

        /// <summary>
        /// Modifies the specified endpoint.
        /// 
        ///  <note> 
        /// <para>
        /// For a MySQL source or target endpoint, don't explicitly specify the database using
        /// the <code>DatabaseName</code> request parameter on the <code>ModifyEndpoint</code>
        /// API call. Specifying <code>DatabaseName</code> when you modify a MySQL endpoint replicates
        /// all the task tables to this single database. For MySQL endpoints, you specify the
        /// database only when you specify the schema in the table-mapping rules of the DMS task.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpoint service method.</param>
        /// 
        /// <returns>The response from the ModifyEndpoint service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEndpoint">REST API Reference for ModifyEndpoint Operation</seealso>
        public virtual ModifyEndpointResponse ModifyEndpoint(ModifyEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpoint operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEndpoint">REST API Reference for ModifyEndpoint Operation</seealso>
        public virtual IAsyncResult BeginModifyEndpoint(ModifyEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyEndpoint.</param>
        /// 
        /// <returns>Returns a  ModifyEndpointResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEndpoint">REST API Reference for ModifyEndpoint Operation</seealso>
        public virtual ModifyEndpointResponse EndModifyEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyEventSubscription

        /// <summary>
        /// Modifies an existing DMS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that the DMS account doesn't
        /// have access to.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSDisabledException">
        /// The specified KMS key isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSInvalidStateException">
        /// The state of the specified KMS resource isn't valid for this request.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSNotFoundException">
        /// The specified KMS entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSThrottlingException">
        /// This request triggered KMS request throttling.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.SNSInvalidTopicException">
        /// The SNS topic is invalid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.SNSNoAuthorizationException">
        /// You are not authorized for the SNS subscription.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginModifyEventSubscription(ModifyEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyEventSubscription.</param>
        /// 
        /// <returns>Returns a  ModifyEventSubscriptionResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual ModifyEventSubscriptionResponse EndModifyEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyReplicationInstance

        /// <summary>
        /// Modifies the replication instance to apply new settings. You can change one or more
        /// parameters by specifying these parameters and the new values in the request.
        /// 
        ///  
        /// <para>
        /// Some settings are applied during the maintenance window.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InsufficientResourceCapacityException">
        /// There are not enough resources allocated to the database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.StorageQuotaExceededException">
        /// The storage quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.UpgradeDependencyFailureException">
        /// An upgrade dependency is preventing the database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationInstance">REST API Reference for ModifyReplicationInstance Operation</seealso>
        public virtual ModifyReplicationInstanceResponse ModifyReplicationInstance(ModifyReplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationInstance operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyReplicationInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationInstance">REST API Reference for ModifyReplicationInstance Operation</seealso>
        public virtual IAsyncResult BeginModifyReplicationInstance(ModifyReplicationInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReplicationInstance.</param>
        /// 
        /// <returns>Returns a  ModifyReplicationInstanceResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationInstance">REST API Reference for ModifyReplicationInstance Operation</seealso>
        public virtual ModifyReplicationInstanceResponse EndModifyReplicationInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyReplicationInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyReplicationSubnetGroup

        /// <summary>
        /// Modifies the settings for the specified replication subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationSubnetGroup service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// The subnet provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ReplicationSubnetGroupDoesNotCoverEnoughAZsException">
        /// The replication subnet group does not cover enough Availability Zones (AZs). Edit
        /// the replication subnet group and add more AZs.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.SubnetAlreadyInUseException">
        /// The specified subnet is already in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationSubnetGroup">REST API Reference for ModifyReplicationSubnetGroup Operation</seealso>
        public virtual ModifyReplicationSubnetGroupResponse ModifyReplicationSubnetGroup(ModifyReplicationSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationSubnetGroup operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyReplicationSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationSubnetGroup">REST API Reference for ModifyReplicationSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginModifyReplicationSubnetGroup(ModifyReplicationSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationSubnetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReplicationSubnetGroup.</param>
        /// 
        /// <returns>Returns a  ModifyReplicationSubnetGroupResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationSubnetGroup">REST API Reference for ModifyReplicationSubnetGroup Operation</seealso>
        public virtual ModifyReplicationSubnetGroupResponse EndModifyReplicationSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyReplicationSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyReplicationTask

        /// <summary>
        /// Modifies the specified replication task.
        /// 
        ///  
        /// <para>
        /// You can't modify the task endpoints. The task must be stopped before you can modify
        /// it. 
        /// </para>
        ///  
        /// <para>
        /// For more information about DMS tasks, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.html">Working
        /// with Migration Tasks</a> in the <i>Database Migration Service User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationTask service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationTask">REST API Reference for ModifyReplicationTask Operation</seealso>
        public virtual ModifyReplicationTaskResponse ModifyReplicationTask(ModifyReplicationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationTask operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyReplicationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationTask">REST API Reference for ModifyReplicationTask Operation</seealso>
        public virtual IAsyncResult BeginModifyReplicationTask(ModifyReplicationTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReplicationTask.</param>
        /// 
        /// <returns>Returns a  ModifyReplicationTaskResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationTask">REST API Reference for ModifyReplicationTask Operation</seealso>
        public virtual ModifyReplicationTaskResponse EndModifyReplicationTask(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyReplicationTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  MoveReplicationTask

        /// <summary>
        /// Moves a replication task from its current replication instance to a different target
        /// replication instance using the specified parameters. The target replication instance
        /// must be created with the same or later DMS version as the current replication instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MoveReplicationTask service method.</param>
        /// 
        /// <returns>The response from the MoveReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/MoveReplicationTask">REST API Reference for MoveReplicationTask Operation</seealso>
        public virtual MoveReplicationTaskResponse MoveReplicationTask(MoveReplicationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MoveReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MoveReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<MoveReplicationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MoveReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MoveReplicationTask operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMoveReplicationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/MoveReplicationTask">REST API Reference for MoveReplicationTask Operation</seealso>
        public virtual IAsyncResult BeginMoveReplicationTask(MoveReplicationTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MoveReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MoveReplicationTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MoveReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMoveReplicationTask.</param>
        /// 
        /// <returns>Returns a  MoveReplicationTaskResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/MoveReplicationTask">REST API Reference for MoveReplicationTask Operation</seealso>
        public virtual MoveReplicationTaskResponse EndMoveReplicationTask(IAsyncResult asyncResult)
        {
            return EndInvoke<MoveReplicationTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  RebootReplicationInstance

        /// <summary>
        /// Reboots a replication instance. Rebooting results in a momentary outage, until the
        /// replication instance becomes available again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the RebootReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RebootReplicationInstance">REST API Reference for RebootReplicationInstance Operation</seealso>
        public virtual RebootReplicationInstanceResponse RebootReplicationInstance(RebootReplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootReplicationInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootReplicationInstance operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootReplicationInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RebootReplicationInstance">REST API Reference for RebootReplicationInstance Operation</seealso>
        public virtual IAsyncResult BeginRebootReplicationInstance(RebootReplicationInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootReplicationInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RebootReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootReplicationInstance.</param>
        /// 
        /// <returns>Returns a  RebootReplicationInstanceResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RebootReplicationInstance">REST API Reference for RebootReplicationInstance Operation</seealso>
        public virtual RebootReplicationInstanceResponse EndRebootReplicationInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<RebootReplicationInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  RefreshSchemas

        /// <summary>
        /// Populates the schema for the specified endpoint. This is an asynchronous operation
        /// and can take several minutes. You can check the status of this operation by calling
        /// the DescribeRefreshSchemasStatus operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshSchemas service method.</param>
        /// 
        /// <returns>The response from the RefreshSchemas service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RefreshSchemas">REST API Reference for RefreshSchemas Operation</seealso>
        public virtual RefreshSchemasResponse RefreshSchemas(RefreshSchemasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RefreshSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshSchemasResponseUnmarshaller.Instance;

            return Invoke<RefreshSchemasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RefreshSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshSchemas operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRefreshSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RefreshSchemas">REST API Reference for RefreshSchemas Operation</seealso>
        public virtual IAsyncResult BeginRefreshSchemas(RefreshSchemasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RefreshSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshSchemasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RefreshSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRefreshSchemas.</param>
        /// 
        /// <returns>Returns a  RefreshSchemasResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RefreshSchemas">REST API Reference for RefreshSchemas Operation</seealso>
        public virtual RefreshSchemasResponse EndRefreshSchemas(IAsyncResult asyncResult)
        {
            return EndInvoke<RefreshSchemasResponse>(asyncResult);
        }

        #endregion
        
        #region  ReloadTables

        /// <summary>
        /// Reloads the target database table with the source data. 
        /// 
        ///  
        /// <para>
        /// You can only use this operation with a task in the <code>RUNNING</code> state, otherwise
        /// the service will throw an <code>InvalidResourceStateFault</code> exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReloadTables service method.</param>
        /// 
        /// <returns>The response from the ReloadTables service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ReloadTables">REST API Reference for ReloadTables Operation</seealso>
        public virtual ReloadTablesResponse ReloadTables(ReloadTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReloadTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReloadTablesResponseUnmarshaller.Instance;

            return Invoke<ReloadTablesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReloadTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReloadTables operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReloadTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ReloadTables">REST API Reference for ReloadTables Operation</seealso>
        public virtual IAsyncResult BeginReloadTables(ReloadTablesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReloadTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReloadTablesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReloadTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReloadTables.</param>
        /// 
        /// <returns>Returns a  ReloadTablesResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ReloadTables">REST API Reference for ReloadTables Operation</seealso>
        public virtual ReloadTablesResponse EndReloadTables(IAsyncResult asyncResult)
        {
            return EndInvoke<ReloadTablesResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        /// <summary>
        /// Removes metadata tags from an DMS resource, including replication instance, endpoint,
        /// subnet group, and migration task. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_Tag.html">
        /// <code>Tag</code> </a> data type description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual IAsyncResult BeginRemoveTagsFromResource(RemoveTagsFromResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromResource.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromResourceResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse EndRemoveTagsFromResource(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsFromResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RunFleetAdvisorLsaAnalysis

        /// <summary>
        /// Runs large-scale assessment (LSA) analysis on every Fleet Advisor collector in your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunFleetAdvisorLsaAnalysis service method.</param>
        /// 
        /// <returns>The response from the RunFleetAdvisorLsaAnalysis service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RunFleetAdvisorLsaAnalysis">REST API Reference for RunFleetAdvisorLsaAnalysis Operation</seealso>
        public virtual RunFleetAdvisorLsaAnalysisResponse RunFleetAdvisorLsaAnalysis(RunFleetAdvisorLsaAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunFleetAdvisorLsaAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunFleetAdvisorLsaAnalysisResponseUnmarshaller.Instance;

            return Invoke<RunFleetAdvisorLsaAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RunFleetAdvisorLsaAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunFleetAdvisorLsaAnalysis operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunFleetAdvisorLsaAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RunFleetAdvisorLsaAnalysis">REST API Reference for RunFleetAdvisorLsaAnalysis Operation</seealso>
        public virtual IAsyncResult BeginRunFleetAdvisorLsaAnalysis(RunFleetAdvisorLsaAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunFleetAdvisorLsaAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunFleetAdvisorLsaAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RunFleetAdvisorLsaAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunFleetAdvisorLsaAnalysis.</param>
        /// 
        /// <returns>Returns a  RunFleetAdvisorLsaAnalysisResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RunFleetAdvisorLsaAnalysis">REST API Reference for RunFleetAdvisorLsaAnalysis Operation</seealso>
        public virtual RunFleetAdvisorLsaAnalysisResponse EndRunFleetAdvisorLsaAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<RunFleetAdvisorLsaAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  StartRecommendations

        /// <summary>
        /// Starts the analysis of your source database to provide recommendations of target engines.
        /// 
        ///  
        /// <para>
        /// You can create recommendations for multiple source databases using <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_BatchStartRecommendations.html">BatchStartRecommendations</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecommendations service method.</param>
        /// 
        /// <returns>The response from the StartRecommendations service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartRecommendations">REST API Reference for StartRecommendations Operation</seealso>
        public virtual StartRecommendationsResponse StartRecommendations(StartRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRecommendationsResponseUnmarshaller.Instance;

            return Invoke<StartRecommendationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRecommendations operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartRecommendations">REST API Reference for StartRecommendations Operation</seealso>
        public virtual IAsyncResult BeginStartRecommendations(StartRecommendationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRecommendationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRecommendations.</param>
        /// 
        /// <returns>Returns a  StartRecommendationsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartRecommendations">REST API Reference for StartRecommendations Operation</seealso>
        public virtual StartRecommendationsResponse EndStartRecommendations(IAsyncResult asyncResult)
        {
            return EndInvoke<StartRecommendationsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartReplicationTask

        /// <summary>
        /// Starts the replication task.
        /// 
        ///  
        /// <para>
        /// For more information about DMS tasks, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.html">Working
        /// with Migration Tasks </a> in the <i>Database Migration Service User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTask service method.</param>
        /// 
        /// <returns>The response from the StartReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTask">REST API Reference for StartReplicationTask Operation</seealso>
        public virtual StartReplicationTaskResponse StartReplicationTask(StartReplicationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<StartReplicationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTask operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReplicationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTask">REST API Reference for StartReplicationTask Operation</seealso>
        public virtual IAsyncResult BeginStartReplicationTask(StartReplicationTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReplicationTask.</param>
        /// 
        /// <returns>Returns a  StartReplicationTaskResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTask">REST API Reference for StartReplicationTask Operation</seealso>
        public virtual StartReplicationTaskResponse EndStartReplicationTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartReplicationTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  StartReplicationTaskAssessment

        /// <summary>
        /// Starts the replication task assessment for unsupported data types in the source database.
        /// 
        /// 
        ///  
        /// <para>
        /// You can only use this operation for a task if the following conditions are true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The task must be in the <code>stopped</code> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The task must have successful connections to the source and target.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If either of these conditions are not met, an <code>InvalidResourceStateFault</code>
        /// error will result. 
        /// </para>
        ///  
        /// <para>
        /// For information about DMS task assessments, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.AssessmentReport.html">Creating
        /// a task assessment report</a> in the <i>Database Migration Service User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTaskAssessment service method.</param>
        /// 
        /// <returns>The response from the StartReplicationTaskAssessment service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTaskAssessment">REST API Reference for StartReplicationTaskAssessment Operation</seealso>
        public virtual StartReplicationTaskAssessmentResponse StartReplicationTaskAssessment(StartReplicationTaskAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskAssessmentResponseUnmarshaller.Instance;

            return Invoke<StartReplicationTaskAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartReplicationTaskAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTaskAssessment operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReplicationTaskAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTaskAssessment">REST API Reference for StartReplicationTaskAssessment Operation</seealso>
        public virtual IAsyncResult BeginStartReplicationTaskAssessment(StartReplicationTaskAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartReplicationTaskAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReplicationTaskAssessment.</param>
        /// 
        /// <returns>Returns a  StartReplicationTaskAssessmentResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTaskAssessment">REST API Reference for StartReplicationTaskAssessment Operation</seealso>
        public virtual StartReplicationTaskAssessmentResponse EndStartReplicationTaskAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<StartReplicationTaskAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  StartReplicationTaskAssessmentRun

        /// <summary>
        /// Starts a new premigration assessment run for one or more individual assessments of
        /// a migration task.
        /// 
        ///  
        /// <para>
        /// The assessments that you can specify depend on the source and target database engine
        /// and the migration type defined for the given task. To run this operation, your migration
        /// task must already be created. After you run this operation, you can review the status
        /// of each individual assessment. You can also run the migration task manually after
        /// the assessment run and its individual assessments complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTaskAssessmentRun service method.</param>
        /// 
        /// <returns>The response from the StartReplicationTaskAssessmentRun service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that the DMS account doesn't
        /// have access to.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSDisabledException">
        /// The specified KMS key isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSException">
        /// An Key Management Service (KMS) error is preventing access to KMS.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSInvalidStateException">
        /// The state of the specified KMS resource isn't valid for this request.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSNotFoundException">
        /// The specified KMS entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3AccessDeniedException">
        /// Insufficient privileges are preventing access to an Amazon S3 object.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3ResourceNotFoundException">
        /// A specified Amazon S3 bucket, bucket folder, or other object can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTaskAssessmentRun">REST API Reference for StartReplicationTaskAssessmentRun Operation</seealso>
        public virtual StartReplicationTaskAssessmentRunResponse StartReplicationTaskAssessmentRun(StartReplicationTaskAssessmentRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StartReplicationTaskAssessmentRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartReplicationTaskAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTaskAssessmentRun operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReplicationTaskAssessmentRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTaskAssessmentRun">REST API Reference for StartReplicationTaskAssessmentRun Operation</seealso>
        public virtual IAsyncResult BeginStartReplicationTaskAssessmentRun(StartReplicationTaskAssessmentRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskAssessmentRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartReplicationTaskAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReplicationTaskAssessmentRun.</param>
        /// 
        /// <returns>Returns a  StartReplicationTaskAssessmentRunResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTaskAssessmentRun">REST API Reference for StartReplicationTaskAssessmentRun Operation</seealso>
        public virtual StartReplicationTaskAssessmentRunResponse EndStartReplicationTaskAssessmentRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartReplicationTaskAssessmentRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StopReplicationTask

        /// <summary>
        /// Stops the replication task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationTask service method.</param>
        /// 
        /// <returns>The response from the StopReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopReplicationTask">REST API Reference for StopReplicationTask Operation</seealso>
        public virtual StopReplicationTaskResponse StopReplicationTask(StopReplicationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<StopReplicationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationTask operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopReplicationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopReplicationTask">REST API Reference for StopReplicationTask Operation</seealso>
        public virtual IAsyncResult BeginStopReplicationTask(StopReplicationTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopReplicationTask.</param>
        /// 
        /// <returns>Returns a  StopReplicationTaskResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopReplicationTask">REST API Reference for StopReplicationTask Operation</seealso>
        public virtual StopReplicationTaskResponse EndStopReplicationTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StopReplicationTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  TestConnection

        /// <summary>
        /// Tests the connection between the replication instance and the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestConnection service method.</param>
        /// 
        /// <returns>The response from the TestConnection service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/TestConnection">REST API Reference for TestConnection Operation</seealso>
        public virtual TestConnectionResponse TestConnection(TestConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestConnectionResponseUnmarshaller.Instance;

            return Invoke<TestConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestConnection operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/TestConnection">REST API Reference for TestConnection Operation</seealso>
        public virtual IAsyncResult BeginTestConnection(TestConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestConnection.</param>
        /// 
        /// <returns>Returns a  TestConnectionResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/TestConnection">REST API Reference for TestConnection Operation</seealso>
        public virtual TestConnectionResponse EndTestConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<TestConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSubscriptionsToEventBridge

        /// <summary>
        /// Migrates 10 active and enabled Amazon SNS subscriptions at a time and converts them
        /// to corresponding Amazon EventBridge rules. By default, this operation migrates subscriptions
        /// only when all your replication instance versions are 3.4.6 or higher. If any replication
        /// instances are from versions earlier than 3.4.6, the operation raises an error and
        /// tells you to upgrade these instances to version 3.4.6 or higher. To enable migration
        /// regardless of version, set the <code>Force</code> option to true. However, if you
        /// don't upgrade instances earlier than version 3.4.6, some types of events might not
        /// be available when you use Amazon EventBridge.
        /// 
        ///  
        /// <para>
        /// To call this operation, make sure that you have certain permissions added to your
        /// user account. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html#CHAP_Events-migrate-to-eventbridge">Migrating
        /// event subscriptions to Amazon EventBridge</a> in the <i>Amazon Web Services Database
        /// Migration Service User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionsToEventBridge service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriptionsToEventBridge service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/UpdateSubscriptionsToEventBridge">REST API Reference for UpdateSubscriptionsToEventBridge Operation</seealso>
        public virtual UpdateSubscriptionsToEventBridgeResponse UpdateSubscriptionsToEventBridge(UpdateSubscriptionsToEventBridgeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionsToEventBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionsToEventBridgeResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionsToEventBridgeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscriptionsToEventBridge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionsToEventBridge operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscriptionsToEventBridge
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/UpdateSubscriptionsToEventBridge">REST API Reference for UpdateSubscriptionsToEventBridge Operation</seealso>
        public virtual IAsyncResult BeginUpdateSubscriptionsToEventBridge(UpdateSubscriptionsToEventBridgeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionsToEventBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionsToEventBridgeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriptionsToEventBridge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriptionsToEventBridge.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriptionsToEventBridgeResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/UpdateSubscriptionsToEventBridge">REST API Reference for UpdateSubscriptionsToEventBridge Operation</seealso>
        public virtual UpdateSubscriptionsToEventBridgeResponse EndUpdateSubscriptionsToEventBridge(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSubscriptionsToEventBridgeResponse>(asyncResult);
        }

        #endregion
        
    }
}