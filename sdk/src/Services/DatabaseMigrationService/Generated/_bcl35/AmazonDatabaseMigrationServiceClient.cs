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

#pragma warning disable CS1570
namespace Amazon.DatabaseMigrationService
{
    /// <summary>
    /// <para>Implementation for accessing DatabaseMigrationService</para>
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// <c>Tag</c> </a> data type description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
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
        /// code of <c>200</c>.
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
        
        #region  CreateDataMigration

        /// <summary>
        /// Creates a data migration using the provided settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataMigration service method.</param>
        /// 
        /// <returns>The response from the CreateDataMigration service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidOperationException">
        /// The action or operation requested isn't valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateDataMigration">REST API Reference for CreateDataMigration Operation</seealso>
        public virtual CreateDataMigrationResponse CreateDataMigration(CreateDataMigrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataMigrationResponseUnmarshaller.Instance;

            return Invoke<CreateDataMigrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataMigration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataMigration operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataMigration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateDataMigration">REST API Reference for CreateDataMigration Operation</seealso>
        public virtual IAsyncResult BeginCreateDataMigration(CreateDataMigrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataMigrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataMigration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataMigration.</param>
        /// 
        /// <returns>Returns a  CreateDataMigrationResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateDataMigration">REST API Reference for CreateDataMigration Operation</seealso>
        public virtual CreateDataMigrationResponse EndCreateDataMigration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataMigrationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataProvider

        /// <summary>
        /// Creates a data provider using the provided settings. A data provider stores a data
        /// store type and location information about your database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProvider service method.</param>
        /// 
        /// <returns>The response from the CreateDataProvider service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateDataProvider">REST API Reference for CreateDataProvider Operation</seealso>
        public virtual CreateDataProviderResponse CreateDataProvider(CreateDataProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProviderResponseUnmarshaller.Instance;

            return Invoke<CreateDataProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProvider operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateDataProvider">REST API Reference for CreateDataProvider Operation</seealso>
        public virtual IAsyncResult BeginCreateDataProvider(CreateDataProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataProvider.</param>
        /// 
        /// <returns>Returns a  CreateDataProviderResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateDataProvider">REST API Reference for CreateDataProvider Operation</seealso>
        public virtual CreateDataProviderResponse EndCreateDataProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEndpoint

        /// <summary>
        /// Creates an endpoint using the provided settings.
        /// 
        ///  <note> 
        /// <para>
        /// For a MySQL source or target endpoint, don't explicitly specify the database using
        /// the <c>DatabaseName</c> request parameter on the <c>CreateEndpoint</c> API call. Specifying
        /// <c>DatabaseName</c> when you create a MySQL endpoint replicates all the task tables
        /// to this single database. For MySQL endpoints, you specify the database only when you
        /// specify the schema in the table-mapping rules of the DMS task.
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
        /// You can specify the type of source (<c>SourceType</c>) you want to be notified of,
        /// provide a list of DMS source IDs (<c>SourceIds</c>) that triggers the events, and
        /// provide a list of event categories (<c>EventCategories</c>) for events you want to
        /// be notified of. If you specify both the <c>SourceType</c> and <c>SourceIds</c>, such
        /// as <c>SourceType = replication-instance</c> and <c>SourceIdentifier = my-replinstance</c>,
        /// you will be notified of all the replication instance events for the specified source.
        /// If you specify a <c>SourceType</c> but don't specify a <c>SourceIdentifier</c>, you
        /// receive notice of the events for that source type for all your DMS sources. If you
        /// don't specify either <c>SourceType</c> nor <c>SourceIdentifier</c>, you will be notified
        /// of events generated from all DMS sources belonging to your customer account.
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
        
        #region  CreateInstanceProfile

        /// <summary>
        /// Creates the instance profile using the specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceProfile service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3ResourceNotFoundException">
        /// A specified Amazon S3 bucket, bucket folder, or other object can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        public virtual CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateInstanceProfile(CreateInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceProfile.</param>
        /// 
        /// <returns>Returns a  CreateInstanceProfileResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        public virtual CreateInstanceProfileResponse EndCreateInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInstanceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMigrationProject

        /// <summary>
        /// Creates the migration project using the specified parameters.
        /// 
        ///  
        /// <para>
        /// You can run this action only after you create an instance profile and data providers
        /// using <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_CreateInstanceProfile.html">CreateInstanceProfile</a>
        /// and <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_CreateDataProvider.html">CreateDataProvider</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMigrationProject service method.</param>
        /// 
        /// <returns>The response from the CreateMigrationProject service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3ResourceNotFoundException">
        /// A specified Amazon S3 bucket, bucket folder, or other object can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateMigrationProject">REST API Reference for CreateMigrationProject Operation</seealso>
        public virtual CreateMigrationProjectResponse CreateMigrationProject(CreateMigrationProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMigrationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMigrationProjectResponseUnmarshaller.Instance;

            return Invoke<CreateMigrationProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMigrationProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMigrationProject operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMigrationProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateMigrationProject">REST API Reference for CreateMigrationProject Operation</seealso>
        public virtual IAsyncResult BeginCreateMigrationProject(CreateMigrationProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMigrationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMigrationProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMigrationProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMigrationProject.</param>
        /// 
        /// <returns>Returns a  CreateMigrationProjectResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateMigrationProject">REST API Reference for CreateMigrationProject Operation</seealso>
        public virtual CreateMigrationProjectResponse EndCreateMigrationProject(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMigrationProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReplicationConfig

        /// <summary>
        /// Creates a configuration that you can later provide to configure and start an DMS Serverless
        /// replication. You can also provide options to validate the configuration inputs before
        /// you start the replication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfig service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationConfig service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// The subnet provided isn't valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationConfig">REST API Reference for CreateReplicationConfig Operation</seealso>
        public virtual CreateReplicationConfigResponse CreateReplicationConfig(CreateReplicationConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationConfigResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfig operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationConfig">REST API Reference for CreateReplicationConfig Operation</seealso>
        public virtual IAsyncResult BeginCreateReplicationConfig(CreateReplicationConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationConfig.</param>
        /// 
        /// <returns>Returns a  CreateReplicationConfigResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationConfig">REST API Reference for CreateReplicationConfig Operation</seealso>
        public virtual CreateReplicationConfigResponse EndCreateReplicationConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReplicationConfigResponse>(asyncResult);
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
        ///  <note> 
        /// <para>
        /// If you don't specify a version when creating a replication instance, DMS will create
        /// the instance using the default engine version. For information about the default engine
        /// version, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_ReleaseNotes.html">Release
        /// Notes</a>.
        /// </para>
        ///  </note>
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
        /// The subnet provided isn't valid.
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
        /// Amazon Web Services Region, otherwise the service will throw a <c>ReplicationSubnetGroupDoesNotCoverEnoughAZs</c>
        /// exception.
        /// </para>
        ///  
        /// <para>
        /// If a replication subnet group exists in your Amazon Web Services account, the CreateReplicationSubnetGroup
        /// action returns the following error message: The Replication Subnet Group already exists.
        /// In this case, delete the existing replication subnet group. To do so, use the <a href="https://docs.aws.amazon.com/en_us/dms/latest/APIReference/API_DeleteReplicationSubnetGroup.html">DeleteReplicationSubnetGroup</a>
        /// action. Optionally, choose Subnet groups in the DMS console, then choose your subnet
        /// group. Next, choose Delete from Actions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationSubnetGroup service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// The subnet provided isn't valid.
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
        
        #region  DeleteDataMigration

        /// <summary>
        /// Deletes the specified data migration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataMigration service method.</param>
        /// 
        /// <returns>The response from the DeleteDataMigration service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteDataMigration">REST API Reference for DeleteDataMigration Operation</seealso>
        public virtual DeleteDataMigrationResponse DeleteDataMigration(DeleteDataMigrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataMigrationResponseUnmarshaller.Instance;

            return Invoke<DeleteDataMigrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataMigration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataMigration operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataMigration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteDataMigration">REST API Reference for DeleteDataMigration Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataMigration(DeleteDataMigrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataMigrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataMigration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataMigration.</param>
        /// 
        /// <returns>Returns a  DeleteDataMigrationResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteDataMigration">REST API Reference for DeleteDataMigration Operation</seealso>
        public virtual DeleteDataMigrationResponse EndDeleteDataMigration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataMigrationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataProvider

        /// <summary>
        /// Deletes the specified data provider.
        /// 
        ///  <note> 
        /// <para>
        /// All migration projects associated with the data provider must be deleted or modified
        /// before you can delete the data provider.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteDataProvider service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteDataProvider">REST API Reference for DeleteDataProvider Operation</seealso>
        public virtual DeleteDataProviderResponse DeleteDataProvider(DeleteDataProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteDataProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataProvider operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteDataProvider">REST API Reference for DeleteDataProvider Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataProvider(DeleteDataProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataProvider.</param>
        /// 
        /// <returns>Returns a  DeleteDataProviderResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteDataProvider">REST API Reference for DeleteDataProvider Operation</seealso>
        public virtual DeleteDataProviderResponse EndDeleteDataProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataProviderResponse>(asyncResult);
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
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
        
        #region  DeleteInstanceProfile

        /// <summary>
        /// Deletes the specified instance profile.
        /// 
        ///  <note> 
        /// <para>
        /// All migration projects associated with the instance profile must be deleted or modified
        /// before you can delete the instance profile.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceProfile service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        public virtual DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteInstanceProfile(DeleteInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceProfileResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        public virtual DeleteInstanceProfileResponse EndDeleteInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInstanceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMigrationProject

        /// <summary>
        /// Deletes the specified migration project.
        /// 
        ///  <note> 
        /// <para>
        /// The migration project must be closed before you can delete it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMigrationProject service method.</param>
        /// 
        /// <returns>The response from the DeleteMigrationProject service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteMigrationProject">REST API Reference for DeleteMigrationProject Operation</seealso>
        public virtual DeleteMigrationProjectResponse DeleteMigrationProject(DeleteMigrationProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMigrationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMigrationProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteMigrationProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMigrationProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMigrationProject operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMigrationProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteMigrationProject">REST API Reference for DeleteMigrationProject Operation</seealso>
        public virtual IAsyncResult BeginDeleteMigrationProject(DeleteMigrationProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMigrationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMigrationProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMigrationProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMigrationProject.</param>
        /// 
        /// <returns>Returns a  DeleteMigrationProjectResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteMigrationProject">REST API Reference for DeleteMigrationProject Operation</seealso>
        public virtual DeleteMigrationProjectResponse EndDeleteMigrationProject(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMigrationProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReplicationConfig

        /// <summary>
        /// Deletes an DMS Serverless replication configuration. This effectively deprovisions
        /// any and all replications that use this configuration. You can't delete the configuration
        /// for an DMS Serverless replication that is ongoing. You can delete the configuration
        /// when the replication is in a non-RUNNING and non-STARTING state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationConfig service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationConfig">REST API Reference for DeleteReplicationConfig Operation</seealso>
        public virtual DeleteReplicationConfigResponse DeleteReplicationConfig(DeleteReplicationConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfig operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationConfig">REST API Reference for DeleteReplicationConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteReplicationConfig(DeleteReplicationConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationConfig.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationConfigResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationConfig">REST API Reference for DeleteReplicationConfig Operation</seealso>
        public virtual DeleteReplicationConfigResponse EndDeleteReplicationConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReplicationConfigResponse>(asyncResult);
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
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
        
        #region  DescribeConversionConfiguration

        /// <summary>
        /// Returns configuration parameters for a schema conversion project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeConversionConfiguration service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeConversionConfiguration">REST API Reference for DescribeConversionConfiguration Operation</seealso>
        public virtual DescribeConversionConfigurationResponse DescribeConversionConfiguration(DescribeConversionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConversionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConversionConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeConversionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConversionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionConfiguration operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConversionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeConversionConfiguration">REST API Reference for DescribeConversionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeConversionConfiguration(DescribeConversionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConversionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConversionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConversionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConversionConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeConversionConfigurationResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeConversionConfiguration">REST API Reference for DescribeConversionConfiguration Operation</seealso>
        public virtual DescribeConversionConfigurationResponse EndDescribeConversionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConversionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataMigrations

        /// <summary>
        /// Returns information about data migrations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataMigrations service method.</param>
        /// 
        /// <returns>The response from the DescribeDataMigrations service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeDataMigrations">REST API Reference for DescribeDataMigrations Operation</seealso>
        public virtual DescribeDataMigrationsResponse DescribeDataMigrations(DescribeDataMigrationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataMigrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataMigrationsResponseUnmarshaller.Instance;

            return Invoke<DescribeDataMigrationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataMigrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataMigrations operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataMigrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeDataMigrations">REST API Reference for DescribeDataMigrations Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataMigrations(DescribeDataMigrationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataMigrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataMigrationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataMigrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataMigrations.</param>
        /// 
        /// <returns>Returns a  DescribeDataMigrationsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeDataMigrations">REST API Reference for DescribeDataMigrations Operation</seealso>
        public virtual DescribeDataMigrationsResponse EndDescribeDataMigrations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDataMigrationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataProviders

        /// <summary>
        /// Returns a paginated list of data providers for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataProviders service method.</param>
        /// 
        /// <returns>The response from the DescribeDataProviders service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeDataProviders">REST API Reference for DescribeDataProviders Operation</seealso>
        public virtual DescribeDataProvidersResponse DescribeDataProviders(DescribeDataProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataProvidersResponseUnmarshaller.Instance;

            return Invoke<DescribeDataProvidersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataProviders operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeDataProviders">REST API Reference for DescribeDataProviders Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataProviders(DescribeDataProvidersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataProvidersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataProviders.</param>
        /// 
        /// <returns>Returns a  DescribeDataProvidersResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeDataProviders">REST API Reference for DescribeDataProviders Operation</seealso>
        public virtual DescribeDataProvidersResponse EndDescribeDataProviders(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDataProvidersResponse>(asyncResult);
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
        
        #region  DescribeEngineVersions

        /// <summary>
        /// Returns information about the replication instance versions used in the project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineVersions service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEngineVersions">REST API Reference for DescribeEngineVersions Operation</seealso>
        public virtual DescribeEngineVersionsResponse DescribeEngineVersions(DescribeEngineVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineVersions operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEngineVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEngineVersions">REST API Reference for DescribeEngineVersions Operation</seealso>
        public virtual IAsyncResult BeginDescribeEngineVersions(DescribeEngineVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngineVersions.</param>
        /// 
        /// <returns>Returns a  DescribeEngineVersionsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEngineVersions">REST API Reference for DescribeEngineVersions Operation</seealso>
        public virtual DescribeEngineVersionsResponse EndDescribeEngineVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEngineVersionsResponse>(asyncResult);
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
        /// includes <c>SubscriptionName</c>, <c>SNSTopicARN</c>, <c>CustomerID</c>, <c>SourceType</c>,
        /// <c>SourceID</c>, <c>CreationTime</c>, and <c>Status</c>. 
        /// 
        ///  
        /// <para>
        /// If you specify <c>SubscriptionName</c>, this action lists the description for that
        /// subscription.
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
        
        #region  DescribeExtensionPackAssociations

        /// <summary>
        /// Returns a paginated list of extension pack associations for the specified migration
        /// project. An extension pack is an add-on module that emulates functions present in
        /// a source database that are required when converting objects to the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExtensionPackAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeExtensionPackAssociations service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeExtensionPackAssociations">REST API Reference for DescribeExtensionPackAssociations Operation</seealso>
        public virtual DescribeExtensionPackAssociationsResponse DescribeExtensionPackAssociations(DescribeExtensionPackAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExtensionPackAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExtensionPackAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeExtensionPackAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExtensionPackAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExtensionPackAssociations operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExtensionPackAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeExtensionPackAssociations">REST API Reference for DescribeExtensionPackAssociations Operation</seealso>
        public virtual IAsyncResult BeginDescribeExtensionPackAssociations(DescribeExtensionPackAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExtensionPackAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExtensionPackAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExtensionPackAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExtensionPackAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeExtensionPackAssociationsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeExtensionPackAssociations">REST API Reference for DescribeExtensionPackAssociations Operation</seealso>
        public virtual DescribeExtensionPackAssociationsResponse EndDescribeExtensionPackAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeExtensionPackAssociationsResponse>(asyncResult);
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
        
        #region  DescribeInstanceProfiles

        /// <summary>
        /// Returns a paginated list of instance profiles for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceProfiles service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceProfiles service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeInstanceProfiles">REST API Reference for DescribeInstanceProfiles Operation</seealso>
        public virtual DescribeInstanceProfilesResponse DescribeInstanceProfiles(DescribeInstanceProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceProfilesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceProfiles operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeInstanceProfiles">REST API Reference for DescribeInstanceProfiles Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstanceProfiles(DescribeInstanceProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceProfiles.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceProfilesResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeInstanceProfiles">REST API Reference for DescribeInstanceProfiles Operation</seealso>
        public virtual DescribeInstanceProfilesResponse EndDescribeInstanceProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMetadataModelAssessments

        /// <summary>
        /// Returns a paginated list of metadata model assessments for your account in the current
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelAssessments service method.</param>
        /// 
        /// <returns>The response from the DescribeMetadataModelAssessments service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelAssessments">REST API Reference for DescribeMetadataModelAssessments Operation</seealso>
        public virtual DescribeMetadataModelAssessmentsResponse DescribeMetadataModelAssessments(DescribeMetadataModelAssessmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelAssessmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeMetadataModelAssessmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetadataModelAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelAssessments operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMetadataModelAssessments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelAssessments">REST API Reference for DescribeMetadataModelAssessments Operation</seealso>
        public virtual IAsyncResult BeginDescribeMetadataModelAssessments(DescribeMetadataModelAssessmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelAssessmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMetadataModelAssessments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetadataModelAssessments.</param>
        /// 
        /// <returns>Returns a  DescribeMetadataModelAssessmentsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelAssessments">REST API Reference for DescribeMetadataModelAssessments Operation</seealso>
        public virtual DescribeMetadataModelAssessmentsResponse EndDescribeMetadataModelAssessments(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMetadataModelAssessmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMetadataModelConversions

        /// <summary>
        /// Returns a paginated list of metadata model conversions for a migration project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelConversions service method.</param>
        /// 
        /// <returns>The response from the DescribeMetadataModelConversions service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelConversions">REST API Reference for DescribeMetadataModelConversions Operation</seealso>
        public virtual DescribeMetadataModelConversionsResponse DescribeMetadataModelConversions(DescribeMetadataModelConversionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelConversionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelConversionsResponseUnmarshaller.Instance;

            return Invoke<DescribeMetadataModelConversionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetadataModelConversions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelConversions operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMetadataModelConversions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelConversions">REST API Reference for DescribeMetadataModelConversions Operation</seealso>
        public virtual IAsyncResult BeginDescribeMetadataModelConversions(DescribeMetadataModelConversionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelConversionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelConversionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMetadataModelConversions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetadataModelConversions.</param>
        /// 
        /// <returns>Returns a  DescribeMetadataModelConversionsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelConversions">REST API Reference for DescribeMetadataModelConversions Operation</seealso>
        public virtual DescribeMetadataModelConversionsResponse EndDescribeMetadataModelConversions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMetadataModelConversionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMetadataModelExportsAsScript

        /// <summary>
        /// Returns a paginated list of metadata model exports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelExportsAsScript service method.</param>
        /// 
        /// <returns>The response from the DescribeMetadataModelExportsAsScript service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelExportsAsScript">REST API Reference for DescribeMetadataModelExportsAsScript Operation</seealso>
        public virtual DescribeMetadataModelExportsAsScriptResponse DescribeMetadataModelExportsAsScript(DescribeMetadataModelExportsAsScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelExportsAsScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelExportsAsScriptResponseUnmarshaller.Instance;

            return Invoke<DescribeMetadataModelExportsAsScriptResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetadataModelExportsAsScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelExportsAsScript operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMetadataModelExportsAsScript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelExportsAsScript">REST API Reference for DescribeMetadataModelExportsAsScript Operation</seealso>
        public virtual IAsyncResult BeginDescribeMetadataModelExportsAsScript(DescribeMetadataModelExportsAsScriptRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelExportsAsScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelExportsAsScriptResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMetadataModelExportsAsScript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetadataModelExportsAsScript.</param>
        /// 
        /// <returns>Returns a  DescribeMetadataModelExportsAsScriptResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelExportsAsScript">REST API Reference for DescribeMetadataModelExportsAsScript Operation</seealso>
        public virtual DescribeMetadataModelExportsAsScriptResponse EndDescribeMetadataModelExportsAsScript(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMetadataModelExportsAsScriptResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMetadataModelExportsToTarget

        /// <summary>
        /// Returns a paginated list of metadata model exports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelExportsToTarget service method.</param>
        /// 
        /// <returns>The response from the DescribeMetadataModelExportsToTarget service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelExportsToTarget">REST API Reference for DescribeMetadataModelExportsToTarget Operation</seealso>
        public virtual DescribeMetadataModelExportsToTargetResponse DescribeMetadataModelExportsToTarget(DescribeMetadataModelExportsToTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelExportsToTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelExportsToTargetResponseUnmarshaller.Instance;

            return Invoke<DescribeMetadataModelExportsToTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetadataModelExportsToTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelExportsToTarget operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMetadataModelExportsToTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelExportsToTarget">REST API Reference for DescribeMetadataModelExportsToTarget Operation</seealso>
        public virtual IAsyncResult BeginDescribeMetadataModelExportsToTarget(DescribeMetadataModelExportsToTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelExportsToTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelExportsToTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMetadataModelExportsToTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetadataModelExportsToTarget.</param>
        /// 
        /// <returns>Returns a  DescribeMetadataModelExportsToTargetResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelExportsToTarget">REST API Reference for DescribeMetadataModelExportsToTarget Operation</seealso>
        public virtual DescribeMetadataModelExportsToTargetResponse EndDescribeMetadataModelExportsToTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMetadataModelExportsToTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMetadataModelImports

        /// <summary>
        /// Returns a paginated list of metadata model imports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelImports service method.</param>
        /// 
        /// <returns>The response from the DescribeMetadataModelImports service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelImports">REST API Reference for DescribeMetadataModelImports Operation</seealso>
        public virtual DescribeMetadataModelImportsResponse DescribeMetadataModelImports(DescribeMetadataModelImportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelImportsResponseUnmarshaller.Instance;

            return Invoke<DescribeMetadataModelImportsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetadataModelImports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelImports operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMetadataModelImports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelImports">REST API Reference for DescribeMetadataModelImports Operation</seealso>
        public virtual IAsyncResult BeginDescribeMetadataModelImports(DescribeMetadataModelImportsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelImportsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMetadataModelImports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetadataModelImports.</param>
        /// 
        /// <returns>Returns a  DescribeMetadataModelImportsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelImports">REST API Reference for DescribeMetadataModelImports Operation</seealso>
        public virtual DescribeMetadataModelImportsResponse EndDescribeMetadataModelImports(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMetadataModelImportsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMigrationProjects

        /// <summary>
        /// Returns a paginated list of migration projects for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMigrationProjects service method.</param>
        /// 
        /// <returns>The response from the DescribeMigrationProjects service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMigrationProjects">REST API Reference for DescribeMigrationProjects Operation</seealso>
        public virtual DescribeMigrationProjectsResponse DescribeMigrationProjects(DescribeMigrationProjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMigrationProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMigrationProjectsResponseUnmarshaller.Instance;

            return Invoke<DescribeMigrationProjectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMigrationProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMigrationProjects operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMigrationProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMigrationProjects">REST API Reference for DescribeMigrationProjects Operation</seealso>
        public virtual IAsyncResult BeginDescribeMigrationProjects(DescribeMigrationProjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMigrationProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMigrationProjectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMigrationProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMigrationProjects.</param>
        /// 
        /// <returns>Returns a  DescribeMigrationProjectsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMigrationProjects">REST API Reference for DescribeMigrationProjects Operation</seealso>
        public virtual DescribeMigrationProjectsResponse EndDescribeMigrationProjects(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMigrationProjectsResponse>(asyncResult);
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
        /// Returns a list of upcoming maintenance events for replication instances in your account
        /// in the current Region.
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
        
        #region  DescribeReplicationConfigs

        /// <summary>
        /// Returns one or more existing DMS Serverless replication configurations as a list of
        /// structures.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigs service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationConfigs service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationConfigs">REST API Reference for DescribeReplicationConfigs Operation</seealso>
        public virtual DescribeReplicationConfigsResponse DescribeReplicationConfigs(DescribeReplicationConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationConfigsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationConfigsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigs operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationConfigs">REST API Reference for DescribeReplicationConfigs Operation</seealso>
        public virtual IAsyncResult BeginDescribeReplicationConfigs(DescribeReplicationConfigsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationConfigsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationConfigs.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationConfigsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationConfigs">REST API Reference for DescribeReplicationConfigs Operation</seealso>
        public virtual DescribeReplicationConfigsResponse EndDescribeReplicationConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplicationConfigsResponse>(asyncResult);
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
        
        #region  DescribeReplications

        /// <summary>
        /// Provides details on replication progress by returning status information for one or
        /// more provisioned DMS Serverless replications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplications service method.</param>
        /// 
        /// <returns>The response from the DescribeReplications service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplications">REST API Reference for DescribeReplications Operation</seealso>
        public virtual DescribeReplicationsResponse DescribeReplications(DescribeReplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplications operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplications">REST API Reference for DescribeReplications Operation</seealso>
        public virtual IAsyncResult BeginDescribeReplications(DescribeReplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplications.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplications">REST API Reference for DescribeReplications Operation</seealso>
        public virtual DescribeReplicationsResponse EndDescribeReplications(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplicationsResponse>(asyncResult);
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
        
        #region  DescribeReplicationTableStatistics

        /// <summary>
        /// Returns table and schema statistics for one or more provisioned replications that
        /// use a given DMS Serverless replication configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTableStatistics service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationTableStatistics service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTableStatistics">REST API Reference for DescribeReplicationTableStatistics Operation</seealso>
        public virtual DescribeReplicationTableStatisticsResponse DescribeReplicationTableStatistics(DescribeReplicationTableStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTableStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTableStatisticsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTableStatisticsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationTableStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTableStatistics operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationTableStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTableStatistics">REST API Reference for DescribeReplicationTableStatistics Operation</seealso>
        public virtual IAsyncResult BeginDescribeReplicationTableStatistics(DescribeReplicationTableStatisticsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTableStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTableStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationTableStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationTableStatistics.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationTableStatisticsResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTableStatistics">REST API Reference for DescribeReplicationTableStatistics Operation</seealso>
        public virtual DescribeReplicationTableStatisticsResponse EndDescribeReplicationTableStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReplicationTableStatisticsResponse>(asyncResult);
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
        /// see the <c>DescribeReplicationTaskIndividualAssessments</c> operation. 
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
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
        
        #region  ExportMetadataModelAssessment

        /// <summary>
        /// Saves a copy of a database migration assessment report to your Amazon S3 bucket. DMS
        /// can save your assessment report as a comma-separated value (CSV) or a PDF file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportMetadataModelAssessment service method.</param>
        /// 
        /// <returns>The response from the ExportMetadataModelAssessment service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ExportMetadataModelAssessment">REST API Reference for ExportMetadataModelAssessment Operation</seealso>
        public virtual ExportMetadataModelAssessmentResponse ExportMetadataModelAssessment(ExportMetadataModelAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportMetadataModelAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportMetadataModelAssessmentResponseUnmarshaller.Instance;

            return Invoke<ExportMetadataModelAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportMetadataModelAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportMetadataModelAssessment operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportMetadataModelAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ExportMetadataModelAssessment">REST API Reference for ExportMetadataModelAssessment Operation</seealso>
        public virtual IAsyncResult BeginExportMetadataModelAssessment(ExportMetadataModelAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportMetadataModelAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportMetadataModelAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportMetadataModelAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportMetadataModelAssessment.</param>
        /// 
        /// <returns>Returns a  ExportMetadataModelAssessmentResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ExportMetadataModelAssessment">REST API Reference for ExportMetadataModelAssessment Operation</seealso>
        public virtual ExportMetadataModelAssessmentResponse EndExportMetadataModelAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportMetadataModelAssessmentResponse>(asyncResult);
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
        /// <c>Tag</c> </a> data type description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
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
        
        #region  ModifyConversionConfiguration

        /// <summary>
        /// Modifies the specified schema conversion configuration using the provided parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyConversionConfiguration service method.</param>
        /// 
        /// <returns>The response from the ModifyConversionConfiguration service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyConversionConfiguration">REST API Reference for ModifyConversionConfiguration Operation</seealso>
        public virtual ModifyConversionConfigurationResponse ModifyConversionConfiguration(ModifyConversionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyConversionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyConversionConfigurationResponseUnmarshaller.Instance;

            return Invoke<ModifyConversionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyConversionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyConversionConfiguration operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyConversionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyConversionConfiguration">REST API Reference for ModifyConversionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginModifyConversionConfiguration(ModifyConversionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyConversionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyConversionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyConversionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyConversionConfiguration.</param>
        /// 
        /// <returns>Returns a  ModifyConversionConfigurationResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyConversionConfiguration">REST API Reference for ModifyConversionConfiguration Operation</seealso>
        public virtual ModifyConversionConfigurationResponse EndModifyConversionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyConversionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDataMigration

        /// <summary>
        /// Modifies an existing DMS data migration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDataMigration service method.</param>
        /// 
        /// <returns>The response from the ModifyDataMigration service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyDataMigration">REST API Reference for ModifyDataMigration Operation</seealso>
        public virtual ModifyDataMigrationResponse ModifyDataMigration(ModifyDataMigrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDataMigrationResponseUnmarshaller.Instance;

            return Invoke<ModifyDataMigrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDataMigration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDataMigration operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDataMigration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyDataMigration">REST API Reference for ModifyDataMigration Operation</seealso>
        public virtual IAsyncResult BeginModifyDataMigration(ModifyDataMigrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDataMigrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDataMigration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDataMigration.</param>
        /// 
        /// <returns>Returns a  ModifyDataMigrationResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyDataMigration">REST API Reference for ModifyDataMigration Operation</seealso>
        public virtual ModifyDataMigrationResponse EndModifyDataMigration(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDataMigrationResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDataProvider

        /// <summary>
        /// Modifies the specified data provider using the provided settings.
        /// 
        ///  <note> 
        /// <para>
        /// You must remove the data provider from all migration projects before you can modify
        /// it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDataProvider service method.</param>
        /// 
        /// <returns>The response from the ModifyDataProvider service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyDataProvider">REST API Reference for ModifyDataProvider Operation</seealso>
        public virtual ModifyDataProviderResponse ModifyDataProvider(ModifyDataProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDataProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDataProviderResponseUnmarshaller.Instance;

            return Invoke<ModifyDataProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDataProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDataProvider operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDataProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyDataProvider">REST API Reference for ModifyDataProvider Operation</seealso>
        public virtual IAsyncResult BeginModifyDataProvider(ModifyDataProviderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDataProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDataProviderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDataProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDataProvider.</param>
        /// 
        /// <returns>Returns a  ModifyDataProviderResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyDataProvider">REST API Reference for ModifyDataProvider Operation</seealso>
        public virtual ModifyDataProviderResponse EndModifyDataProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDataProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyEndpoint

        /// <summary>
        /// Modifies the specified endpoint.
        /// 
        ///  <note> 
        /// <para>
        /// For a MySQL source or target endpoint, don't explicitly specify the database using
        /// the <c>DatabaseName</c> request parameter on the <c>ModifyEndpoint</c> API call. Specifying
        /// <c>DatabaseName</c> when you modify a MySQL endpoint replicates all the task tables
        /// to this single database. For MySQL endpoints, you specify the database only when you
        /// specify the schema in the table-mapping rules of the DMS task.
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
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
        
        #region  ModifyInstanceProfile

        /// <summary>
        /// Modifies the specified instance profile using the provided parameters.
        /// 
        ///  <note> 
        /// <para>
        /// All migration projects associated with the instance profile must be deleted or modified
        /// before you can modify the instance profile.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the ModifyInstanceProfile service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3AccessDeniedException">
        /// Insufficient privileges are preventing access to an Amazon S3 object.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3ResourceNotFoundException">
        /// A specified Amazon S3 bucket, bucket folder, or other object can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyInstanceProfile">REST API Reference for ModifyInstanceProfile Operation</seealso>
        public virtual ModifyInstanceProfileResponse ModifyInstanceProfile(ModifyInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceProfile operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyInstanceProfile">REST API Reference for ModifyInstanceProfile Operation</seealso>
        public virtual IAsyncResult BeginModifyInstanceProfile(ModifyInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstanceProfile.</param>
        /// 
        /// <returns>Returns a  ModifyInstanceProfileResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyInstanceProfile">REST API Reference for ModifyInstanceProfile Operation</seealso>
        public virtual ModifyInstanceProfileResponse EndModifyInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyInstanceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyMigrationProject

        /// <summary>
        /// Modifies the specified migration project using the provided parameters.
        /// 
        ///  <note> 
        /// <para>
        /// The migration project must be closed before you can modify it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyMigrationProject service method.</param>
        /// 
        /// <returns>The response from the ModifyMigrationProject service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyMigrationProject">REST API Reference for ModifyMigrationProject Operation</seealso>
        public virtual ModifyMigrationProjectResponse ModifyMigrationProject(ModifyMigrationProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyMigrationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyMigrationProjectResponseUnmarshaller.Instance;

            return Invoke<ModifyMigrationProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyMigrationProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyMigrationProject operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyMigrationProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyMigrationProject">REST API Reference for ModifyMigrationProject Operation</seealso>
        public virtual IAsyncResult BeginModifyMigrationProject(ModifyMigrationProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyMigrationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyMigrationProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyMigrationProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyMigrationProject.</param>
        /// 
        /// <returns>Returns a  ModifyMigrationProjectResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyMigrationProject">REST API Reference for ModifyMigrationProject Operation</seealso>
        public virtual ModifyMigrationProjectResponse EndModifyMigrationProject(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyMigrationProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyReplicationConfig

        /// <summary>
        /// Modifies an existing DMS Serverless replication configuration that you can use to
        /// start a replication. This command includes input validation and logic to check the
        /// state of any replication that uses this configuration. You can only modify a replication
        /// configuration before any replication that uses it has started. As soon as you have
        /// initially started a replication with a given configuiration, you can't modify that
        /// configuration, even if you stop it.
        /// 
        ///  
        /// <para>
        /// Other run statuses that allow you to run this command include FAILED and CREATED.
        /// A provisioning state that allows you to run this command is FAILED_PROVISION.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationConfig service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationConfig service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// The subnet provided isn't valid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ReplicationSubnetGroupDoesNotCoverEnoughAZsException">
        /// The replication subnet group does not cover enough Availability Zones (AZs). Edit
        /// the replication subnet group and add more AZs.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationConfig">REST API Reference for ModifyReplicationConfig Operation</seealso>
        public virtual ModifyReplicationConfigResponse ModifyReplicationConfig(ModifyReplicationConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationConfigResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationConfig operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyReplicationConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationConfig">REST API Reference for ModifyReplicationConfig Operation</seealso>
        public virtual IAsyncResult BeginModifyReplicationConfig(ModifyReplicationConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyReplicationConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReplicationConfig.</param>
        /// 
        /// <returns>Returns a  ModifyReplicationConfigResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationConfig">REST API Reference for ModifyReplicationConfig Operation</seealso>
        public virtual ModifyReplicationConfigResponse EndModifyReplicationConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyReplicationConfigResponse>(asyncResult);
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
        /// The subnet provided isn't valid.
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
        
        #region  ReloadReplicationTables

        /// <summary>
        /// Reloads the target database table with the source data for a given DMS Serverless
        /// replication configuration.
        /// 
        ///  
        /// <para>
        /// You can only use this operation with a task in the RUNNING state, otherwise the service
        /// will throw an <c>InvalidResourceStateFault</c> exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReloadReplicationTables service method.</param>
        /// 
        /// <returns>The response from the ReloadReplicationTables service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ReloadReplicationTables">REST API Reference for ReloadReplicationTables Operation</seealso>
        public virtual ReloadReplicationTablesResponse ReloadReplicationTables(ReloadReplicationTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReloadReplicationTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReloadReplicationTablesResponseUnmarshaller.Instance;

            return Invoke<ReloadReplicationTablesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReloadReplicationTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReloadReplicationTables operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReloadReplicationTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ReloadReplicationTables">REST API Reference for ReloadReplicationTables Operation</seealso>
        public virtual IAsyncResult BeginReloadReplicationTables(ReloadReplicationTablesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReloadReplicationTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReloadReplicationTablesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReloadReplicationTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReloadReplicationTables.</param>
        /// 
        /// <returns>Returns a  ReloadReplicationTablesResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ReloadReplicationTables">REST API Reference for ReloadReplicationTables Operation</seealso>
        public virtual ReloadReplicationTablesResponse EndReloadReplicationTables(IAsyncResult asyncResult)
        {
            return EndInvoke<ReloadReplicationTablesResponse>(asyncResult);
        }

        #endregion
        
        #region  ReloadTables

        /// <summary>
        /// Reloads the target database table with the source data. 
        /// 
        ///  
        /// <para>
        /// You can only use this operation with a task in the <c>RUNNING</c> state, otherwise
        /// the service will throw an <c>InvalidResourceStateFault</c> exception.
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
        /// <c>Tag</c> </a> data type description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
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
        
        #region  StartDataMigration

        /// <summary>
        /// Starts the specified data migration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataMigration service method.</param>
        /// 
        /// <returns>The response from the StartDataMigration service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidOperationException">
        /// The action or operation requested isn't valid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartDataMigration">REST API Reference for StartDataMigration Operation</seealso>
        public virtual StartDataMigrationResponse StartDataMigration(StartDataMigrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataMigrationResponseUnmarshaller.Instance;

            return Invoke<StartDataMigrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataMigration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataMigration operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataMigration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartDataMigration">REST API Reference for StartDataMigration Operation</seealso>
        public virtual IAsyncResult BeginStartDataMigration(StartDataMigrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataMigrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataMigration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataMigration.</param>
        /// 
        /// <returns>Returns a  StartDataMigrationResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartDataMigration">REST API Reference for StartDataMigration Operation</seealso>
        public virtual StartDataMigrationResponse EndStartDataMigration(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDataMigrationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartExtensionPackAssociation

        /// <summary>
        /// Applies the extension pack to your target database. An extension pack is an add-on
        /// module that emulates functions present in a source database that are required when
        /// converting objects to the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExtensionPackAssociation service method.</param>
        /// 
        /// <returns>The response from the StartExtensionPackAssociation service method, as returned by DatabaseMigrationService.</returns>
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3ResourceNotFoundException">
        /// A specified Amazon S3 bucket, bucket folder, or other object can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartExtensionPackAssociation">REST API Reference for StartExtensionPackAssociation Operation</seealso>
        public virtual StartExtensionPackAssociationResponse StartExtensionPackAssociation(StartExtensionPackAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExtensionPackAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExtensionPackAssociationResponseUnmarshaller.Instance;

            return Invoke<StartExtensionPackAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartExtensionPackAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExtensionPackAssociation operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartExtensionPackAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartExtensionPackAssociation">REST API Reference for StartExtensionPackAssociation Operation</seealso>
        public virtual IAsyncResult BeginStartExtensionPackAssociation(StartExtensionPackAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExtensionPackAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExtensionPackAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartExtensionPackAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartExtensionPackAssociation.</param>
        /// 
        /// <returns>Returns a  StartExtensionPackAssociationResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartExtensionPackAssociation">REST API Reference for StartExtensionPackAssociation Operation</seealso>
        public virtual StartExtensionPackAssociationResponse EndStartExtensionPackAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<StartExtensionPackAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMetadataModelAssessment

        /// <summary>
        /// Creates a database migration assessment report by assessing the migration complexity
        /// for your source database. A database migration assessment report summarizes all of
        /// the schema conversion tasks. It also details the action items for database objects
        /// that can't be converted to the database engine of your target database instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelAssessment service method.</param>
        /// 
        /// <returns>The response from the StartMetadataModelAssessment service method, as returned by DatabaseMigrationService.</returns>
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3ResourceNotFoundException">
        /// A specified Amazon S3 bucket, bucket folder, or other object can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelAssessment">REST API Reference for StartMetadataModelAssessment Operation</seealso>
        public virtual StartMetadataModelAssessmentResponse StartMetadataModelAssessment(StartMetadataModelAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMetadataModelAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelAssessmentResponseUnmarshaller.Instance;

            return Invoke<StartMetadataModelAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMetadataModelAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelAssessment operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMetadataModelAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelAssessment">REST API Reference for StartMetadataModelAssessment Operation</seealso>
        public virtual IAsyncResult BeginStartMetadataModelAssessment(StartMetadataModelAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMetadataModelAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMetadataModelAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMetadataModelAssessment.</param>
        /// 
        /// <returns>Returns a  StartMetadataModelAssessmentResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelAssessment">REST API Reference for StartMetadataModelAssessment Operation</seealso>
        public virtual StartMetadataModelAssessmentResponse EndStartMetadataModelAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMetadataModelAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMetadataModelConversion

        /// <summary>
        /// Converts your source database objects to a format compatible with the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelConversion service method.</param>
        /// 
        /// <returns>The response from the StartMetadataModelConversion service method, as returned by DatabaseMigrationService.</returns>
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3ResourceNotFoundException">
        /// A specified Amazon S3 bucket, bucket folder, or other object can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelConversion">REST API Reference for StartMetadataModelConversion Operation</seealso>
        public virtual StartMetadataModelConversionResponse StartMetadataModelConversion(StartMetadataModelConversionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMetadataModelConversionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelConversionResponseUnmarshaller.Instance;

            return Invoke<StartMetadataModelConversionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMetadataModelConversion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelConversion operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMetadataModelConversion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelConversion">REST API Reference for StartMetadataModelConversion Operation</seealso>
        public virtual IAsyncResult BeginStartMetadataModelConversion(StartMetadataModelConversionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMetadataModelConversionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelConversionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMetadataModelConversion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMetadataModelConversion.</param>
        /// 
        /// <returns>Returns a  StartMetadataModelConversionResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelConversion">REST API Reference for StartMetadataModelConversion Operation</seealso>
        public virtual StartMetadataModelConversionResponse EndStartMetadataModelConversion(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMetadataModelConversionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMetadataModelExportAsScript

        /// <summary>
        /// Saves your converted code to a file as a SQL script, and stores this file on your
        /// Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelExportAsScript service method.</param>
        /// 
        /// <returns>The response from the StartMetadataModelExportAsScript service method, as returned by DatabaseMigrationService.</returns>
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3ResourceNotFoundException">
        /// A specified Amazon S3 bucket, bucket folder, or other object can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelExportAsScript">REST API Reference for StartMetadataModelExportAsScript Operation</seealso>
        public virtual StartMetadataModelExportAsScriptResponse StartMetadataModelExportAsScript(StartMetadataModelExportAsScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMetadataModelExportAsScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelExportAsScriptResponseUnmarshaller.Instance;

            return Invoke<StartMetadataModelExportAsScriptResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMetadataModelExportAsScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelExportAsScript operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMetadataModelExportAsScript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelExportAsScript">REST API Reference for StartMetadataModelExportAsScript Operation</seealso>
        public virtual IAsyncResult BeginStartMetadataModelExportAsScript(StartMetadataModelExportAsScriptRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMetadataModelExportAsScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelExportAsScriptResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMetadataModelExportAsScript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMetadataModelExportAsScript.</param>
        /// 
        /// <returns>Returns a  StartMetadataModelExportAsScriptResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelExportAsScript">REST API Reference for StartMetadataModelExportAsScript Operation</seealso>
        public virtual StartMetadataModelExportAsScriptResponse EndStartMetadataModelExportAsScript(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMetadataModelExportAsScriptResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMetadataModelExportToTarget

        /// <summary>
        /// Applies converted database objects to your target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelExportToTarget service method.</param>
        /// 
        /// <returns>The response from the StartMetadataModelExportToTarget service method, as returned by DatabaseMigrationService.</returns>
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3ResourceNotFoundException">
        /// A specified Amazon S3 bucket, bucket folder, or other object can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelExportToTarget">REST API Reference for StartMetadataModelExportToTarget Operation</seealso>
        public virtual StartMetadataModelExportToTargetResponse StartMetadataModelExportToTarget(StartMetadataModelExportToTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMetadataModelExportToTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelExportToTargetResponseUnmarshaller.Instance;

            return Invoke<StartMetadataModelExportToTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMetadataModelExportToTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelExportToTarget operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMetadataModelExportToTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelExportToTarget">REST API Reference for StartMetadataModelExportToTarget Operation</seealso>
        public virtual IAsyncResult BeginStartMetadataModelExportToTarget(StartMetadataModelExportToTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMetadataModelExportToTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelExportToTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMetadataModelExportToTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMetadataModelExportToTarget.</param>
        /// 
        /// <returns>Returns a  StartMetadataModelExportToTargetResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelExportToTarget">REST API Reference for StartMetadataModelExportToTarget Operation</seealso>
        public virtual StartMetadataModelExportToTargetResponse EndStartMetadataModelExportToTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMetadataModelExportToTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMetadataModelImport

        /// <summary>
        /// Loads the metadata for all the dependent database objects of the parent object.
        /// 
        ///  
        /// <para>
        /// This operation uses your project's Amazon S3 bucket as a metadata cache to improve
        /// performance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelImport service method.</param>
        /// 
        /// <returns>The response from the StartMetadataModelImport service method, as returned by DatabaseMigrationService.</returns>
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
        /// <exception cref="Amazon.DatabaseMigrationService.Model.S3ResourceNotFoundException">
        /// A specified Amazon S3 bucket, bucket folder, or other object can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelImport">REST API Reference for StartMetadataModelImport Operation</seealso>
        public virtual StartMetadataModelImportResponse StartMetadataModelImport(StartMetadataModelImportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMetadataModelImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelImportResponseUnmarshaller.Instance;

            return Invoke<StartMetadataModelImportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMetadataModelImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelImport operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMetadataModelImport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelImport">REST API Reference for StartMetadataModelImport Operation</seealso>
        public virtual IAsyncResult BeginStartMetadataModelImport(StartMetadataModelImportRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMetadataModelImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelImportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMetadataModelImport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMetadataModelImport.</param>
        /// 
        /// <returns>Returns a  StartMetadataModelImportResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartMetadataModelImport">REST API Reference for StartMetadataModelImport Operation</seealso>
        public virtual StartMetadataModelImportResponse EndStartMetadataModelImport(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMetadataModelImportResponse>(asyncResult);
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
        
        #region  StartReplication

        /// <summary>
        /// For a given DMS Serverless replication configuration, DMS connects to the source endpoint
        /// and collects the metadata to analyze the replication workload. Using this metadata,
        /// DMS then computes and provisions the required capacity and starts replicating to the
        /// target endpoint using the server resources that DMS has provisioned for the DMS Serverless
        /// replication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplication service method.</param>
        /// 
        /// <returns>The response from the StartReplication service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplication">REST API Reference for StartReplication Operation</seealso>
        public virtual StartReplicationResponse StartReplication(StartReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationResponseUnmarshaller.Instance;

            return Invoke<StartReplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplication operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplication">REST API Reference for StartReplication Operation</seealso>
        public virtual IAsyncResult BeginStartReplication(StartReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReplication.</param>
        /// 
        /// <returns>Returns a  StartReplicationResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplication">REST API Reference for StartReplication Operation</seealso>
        public virtual StartReplicationResponse EndStartReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<StartReplicationResponse>(asyncResult);
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
        /// The task must be in the <c>stopped</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The task must have successful connections to the source and target.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If either of these conditions are not met, an <c>InvalidResourceStateFault</c> error
        /// will result. 
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
        
        #region  StopDataMigration

        /// <summary>
        /// Stops the specified data migration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataMigration service method.</param>
        /// 
        /// <returns>The response from the StopDataMigration service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.FailedDependencyException">
        /// A dependency threw an exception.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopDataMigration">REST API Reference for StopDataMigration Operation</seealso>
        public virtual StopDataMigrationResponse StopDataMigration(StopDataMigrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDataMigrationResponseUnmarshaller.Instance;

            return Invoke<StopDataMigrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDataMigration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataMigration operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDataMigration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopDataMigration">REST API Reference for StopDataMigration Operation</seealso>
        public virtual IAsyncResult BeginStopDataMigration(StopDataMigrationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDataMigrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopDataMigration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDataMigration.</param>
        /// 
        /// <returns>Returns a  StopDataMigrationResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopDataMigration">REST API Reference for StopDataMigration Operation</seealso>
        public virtual StopDataMigrationResponse EndStopDataMigration(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDataMigrationResponse>(asyncResult);
        }

        #endregion
        
        #region  StopReplication

        /// <summary>
        /// For a given DMS Serverless replication configuration, DMS stops any and all ongoing
        /// DMS Serverless replications. This command doesn't deprovision the stopped replications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplication service method.</param>
        /// 
        /// <returns>The response from the StopReplication service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopReplication">REST API Reference for StopReplication Operation</seealso>
        public virtual StopReplicationResponse StopReplication(StopReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationResponseUnmarshaller.Instance;

            return Invoke<StopReplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopReplication operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopReplication">REST API Reference for StopReplication Operation</seealso>
        public virtual IAsyncResult BeginStopReplication(StopReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopReplication.</param>
        /// 
        /// <returns>Returns a  StopReplicationResult from DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopReplication">REST API Reference for StopReplication Operation</seealso>
        public virtual StopReplicationResponse EndStopReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<StopReplicationResponse>(asyncResult);
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
        /// only when all your replication instance versions are 3.4.5 or higher. If any replication
        /// instances are from versions earlier than 3.4.5, the operation raises an error and
        /// tells you to upgrade these instances to version 3.4.5 or higher. To enable migration
        /// regardless of version, set the <c>Force</c> option to true. However, if you don't
        /// upgrade instances earlier than version 3.4.5, some types of events might not be available
        /// when you use Amazon EventBridge.
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
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonDatabaseMigrationServiceEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}