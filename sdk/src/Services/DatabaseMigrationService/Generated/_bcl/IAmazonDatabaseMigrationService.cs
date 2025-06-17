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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DatabaseMigrationService.Model;

#pragma warning disable CS1570
namespace Amazon.DatabaseMigrationService
{
    /// <summary>
    /// <para>Interface for accessing DatabaseMigrationService</para>
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
    public partial interface IAmazonDatabaseMigrationService : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDatabaseMigrationServicePaginatorFactory Paginators { get; }

        
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
        AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request);



        /// <summary>
        /// Adds metadata tags to an DMS resource, including replication instance, endpoint, subnet
        /// group, and migration task. These tags can also be used with cost allocation reporting
        /// to track cost associated with DMS resources, or used in a Condition statement in an
        /// IAM policy for DMS. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_Tag.html">
        /// <c>Tag</c> </a> data type description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ApplyPendingMaintenanceActionResponse ApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request);



        /// <summary>
        /// Applies a pending maintenance action to a resource (for example, to a replication
        /// instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApplyPendingMaintenanceAction service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        Task<ApplyPendingMaintenanceActionResponse> ApplyPendingMaintenanceActionAsync(ApplyPendingMaintenanceActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchStartRecommendations


        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Starts the analysis of up to 20 source databases to recommend target engines for each
        /// source database. This is a batch version of <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartRecommendations.html">StartRecommendations</a>.
        /// </para>
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
        BatchStartRecommendationsResponse BatchStartRecommendations(BatchStartRecommendationsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Starts the analysis of up to 20 source databases to recommend target engines for each
        /// source database. This is a batch version of <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_StartRecommendations.html">StartRecommendations</a>.
        /// </para>
        ///  
        /// <para>
        /// The result of analysis of each source database is reported individually in the response.
        /// Because the batch request can result in a combination of successful and unsuccessful
        /// actions, you should check for batch errors even when the call returns an HTTP status
        /// code of <c>200</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchStartRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchStartRecommendationsResponse> BatchStartRecommendationsAsync(BatchStartRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CancelReplicationTaskAssessmentRunResponse CancelReplicationTaskAssessmentRun(CancelReplicationTaskAssessmentRunRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CancelReplicationTaskAssessmentRunResponse> CancelReplicationTaskAssessmentRunAsync(CancelReplicationTaskAssessmentRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateDataMigrationResponse CreateDataMigration(CreateDataMigrationRequest request);



        /// <summary>
        /// Creates a data migration using the provided settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataMigration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDataMigrationResponse> CreateDataMigrationAsync(CreateDataMigrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateDataProviderResponse CreateDataProvider(CreateDataProviderRequest request);



        /// <summary>
        /// Creates a data provider using the provided settings. A data provider stores a data
        /// store type and location information about your database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDataProviderResponse> CreateDataProviderAsync(CreateDataProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFleetAdvisorCollector


        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a Fleet Advisor collector using the specified parameters.
        /// </para>
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
        CreateFleetAdvisorCollectorResponse CreateFleetAdvisorCollector(CreateFleetAdvisorCollectorRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a Fleet Advisor collector using the specified parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleetAdvisorCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateFleetAdvisorCollectorResponse> CreateFleetAdvisorCollectorAsync(CreateFleetAdvisorCollectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest request);



        /// <summary>
        /// Creates the instance profile using the specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateInstanceProfileResponse> CreateInstanceProfileAsync(CreateInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateMigrationProjectResponse CreateMigrationProject(CreateMigrationProjectRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateMigrationProjectResponse> CreateMigrationProjectAsync(CreateMigrationProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateReplicationConfigResponse CreateReplicationConfig(CreateReplicationConfigRequest request);



        /// <summary>
        /// Creates a configuration that you can later provide to configure and start an DMS Serverless
        /// replication. You can also provide options to validate the configuration inputs before
        /// you start the replication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateReplicationConfigResponse> CreateReplicationConfigAsync(CreateReplicationConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateReplicationInstanceResponse CreateReplicationInstance(CreateReplicationInstanceRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateReplicationInstanceResponse> CreateReplicationInstanceAsync(CreateReplicationInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateReplicationSubnetGroupResponse CreateReplicationSubnetGroup(CreateReplicationSubnetGroupRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateReplicationSubnetGroupResponse> CreateReplicationSubnetGroupAsync(CreateReplicationSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateReplicationTaskResponse CreateReplicationTask(CreateReplicationTaskRequest request);



        /// <summary>
        /// Creates a replication task using the specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateReplicationTaskResponse> CreateReplicationTaskAsync(CreateReplicationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request);



        /// <summary>
        /// Deletes the specified certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request);



        /// <summary>
        /// Deletes the connection between a replication instance and an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteDataMigrationResponse DeleteDataMigration(DeleteDataMigrationRequest request);



        /// <summary>
        /// Deletes the specified data migration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataMigration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDataMigrationResponse> DeleteDataMigrationAsync(DeleteDataMigrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteDataProviderResponse DeleteDataProvider(DeleteDataProviderRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDataProviderResponse> DeleteDataProviderAsync(DeleteDataProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request);



        /// <summary>
        /// Deletes an DMS event subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFleetAdvisorCollector


        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes the specified Fleet Advisor collector.
        /// </para>
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
        DeleteFleetAdvisorCollectorResponse DeleteFleetAdvisorCollector(DeleteFleetAdvisorCollectorRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes the specified Fleet Advisor collector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleetAdvisorCollector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteFleetAdvisorCollectorResponse> DeleteFleetAdvisorCollectorAsync(DeleteFleetAdvisorCollectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFleetAdvisorDatabases


        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes the specified Fleet Advisor collector databases.
        /// </para>
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
        DeleteFleetAdvisorDatabasesResponse DeleteFleetAdvisorDatabases(DeleteFleetAdvisorDatabasesRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes the specified Fleet Advisor collector databases.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleetAdvisorDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteFleetAdvisorDatabasesResponse> DeleteFleetAdvisorDatabasesAsync(DeleteFleetAdvisorDatabasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteInstanceProfileResponse> DeleteInstanceProfileAsync(DeleteInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteMigrationProjectResponse DeleteMigrationProject(DeleteMigrationProjectRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteMigrationProjectResponse> DeleteMigrationProjectAsync(DeleteMigrationProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteReplicationConfigResponse DeleteReplicationConfig(DeleteReplicationConfigRequest request);



        /// <summary>
        /// Deletes an DMS Serverless replication configuration. This effectively deprovisions
        /// any and all replications that use this configuration. You can't delete the configuration
        /// for an DMS Serverless replication that is ongoing. You can delete the configuration
        /// when the replication is in a non-RUNNING and non-STARTING state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteReplicationConfigResponse> DeleteReplicationConfigAsync(DeleteReplicationConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteReplicationInstanceResponse DeleteReplicationInstance(DeleteReplicationInstanceRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationInstance">REST API Reference for DeleteReplicationInstance Operation</seealso>
        Task<DeleteReplicationInstanceResponse> DeleteReplicationInstanceAsync(DeleteReplicationInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteReplicationSubnetGroupResponse DeleteReplicationSubnetGroup(DeleteReplicationSubnetGroupRequest request);



        /// <summary>
        /// Deletes a subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteReplicationSubnetGroupResponse> DeleteReplicationSubnetGroupAsync(DeleteReplicationSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteReplicationTaskResponse DeleteReplicationTask(DeleteReplicationTaskRequest request);



        /// <summary>
        /// Deletes the specified replication task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationTask">REST API Reference for DeleteReplicationTask Operation</seealso>
        Task<DeleteReplicationTaskResponse> DeleteReplicationTaskAsync(DeleteReplicationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteReplicationTaskAssessmentRunResponse DeleteReplicationTaskAssessmentRun(DeleteReplicationTaskAssessmentRunRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteReplicationTaskAssessmentRunResponse> DeleteReplicationTaskAssessmentRunAsync(DeleteReplicationTaskAssessmentRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeApplicableIndividualAssessmentsResponse DescribeApplicableIndividualAssessments(DescribeApplicableIndividualAssessmentsRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeApplicableIndividualAssessmentsResponse> DescribeApplicableIndividualAssessmentsAsync(DescribeApplicableIndividualAssessmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeCertificatesResponse DescribeCertificates(DescribeCertificatesRequest request);



        /// <summary>
        /// Provides a description of the certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificates service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        Task<DescribeCertificatesResponse> DescribeCertificatesAsync(DescribeCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest request);



        /// <summary>
        /// Describes the status of the connections that have been made between the replication
        /// instance and an endpoint. Connections are created when you test an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        Task<DescribeConnectionsResponse> DescribeConnectionsAsync(DescribeConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeConversionConfigurationResponse DescribeConversionConfiguration(DescribeConversionConfigurationRequest request);



        /// <summary>
        /// Returns configuration parameters for a schema conversion project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConversionConfiguration service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeConversionConfiguration">REST API Reference for DescribeConversionConfiguration Operation</seealso>
        Task<DescribeConversionConfigurationResponse> DescribeConversionConfigurationAsync(DescribeConversionConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeDataMigrationsResponse DescribeDataMigrations(DescribeDataMigrationsRequest request);



        /// <summary>
        /// Returns information about data migrations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataMigrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeDataMigrationsResponse> DescribeDataMigrationsAsync(DescribeDataMigrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeDataProvidersResponse DescribeDataProviders(DescribeDataProvidersRequest request);



        /// <summary>
        /// Returns a paginated list of data providers for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeDataProvidersResponse> DescribeDataProvidersAsync(DescribeDataProvidersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request);



        /// <summary>
        /// Returns information about the endpoints for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeEndpointSettingsResponse DescribeEndpointSettings(DescribeEndpointSettingsRequest request);



        /// <summary>
        /// Returns information about the possible endpoint settings available when you create
        /// an endpoint for a specific database engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpointSettings service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpointSettings">REST API Reference for DescribeEndpointSettings Operation</seealso>
        Task<DescribeEndpointSettingsResponse> DescribeEndpointSettingsAsync(DescribeEndpointSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEndpointTypes


        /// <summary>
        /// Returns information about the type of endpoints available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpointTypes service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpointTypes">REST API Reference for DescribeEndpointTypes Operation</seealso>
        DescribeEndpointTypesResponse DescribeEndpointTypes(DescribeEndpointTypesRequest request);



        /// <summary>
        /// Returns information about the type of endpoints available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpointTypes service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpointTypes">REST API Reference for DescribeEndpointTypes Operation</seealso>
        Task<DescribeEndpointTypesResponse> DescribeEndpointTypesAsync(DescribeEndpointTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEngineVersions


        /// <summary>
        /// Returns information about the replication instance versions used in the project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineVersions service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEngineVersions">REST API Reference for DescribeEngineVersions Operation</seealso>
        DescribeEngineVersionsResponse DescribeEngineVersions(DescribeEngineVersionsRequest request);



        /// <summary>
        /// Returns information about the replication instance versions used in the project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEngineVersions service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEngineVersions">REST API Reference for DescribeEngineVersions Operation</seealso>
        Task<DescribeEngineVersionsResponse> DescribeEngineVersionsAsync(DescribeEngineVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request);



        /// <summary>
        /// Lists categories for all event source types, or, if specified, for a specified source
        /// type. You can see a list of the event categories and source types in <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html">Working
        /// with Events and Notifications</a> in the <i>Database Migration Service User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);



        /// <summary>
        /// Lists events for a given source identifier and source type. You can also specify
        /// a start and end time. For more information on DMS events, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html">Working
        /// with Events and Notifications</a> in the <i>Database Migration Service User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeExtensionPackAssociationsResponse DescribeExtensionPackAssociations(DescribeExtensionPackAssociationsRequest request);



        /// <summary>
        /// Returns a paginated list of extension pack associations for the specified migration
        /// project. An extension pack is an add-on module that emulates functions present in
        /// a source database that are required when converting objects to the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExtensionPackAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExtensionPackAssociations service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeExtensionPackAssociations">REST API Reference for DescribeExtensionPackAssociations Operation</seealso>
        Task<DescribeExtensionPackAssociationsResponse> DescribeExtensionPackAssociationsAsync(DescribeExtensionPackAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetAdvisorCollectors


        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of the Fleet Advisor collectors in your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorCollectors service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorCollectors service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorCollectors">REST API Reference for DescribeFleetAdvisorCollectors Operation</seealso>
        DescribeFleetAdvisorCollectorsResponse DescribeFleetAdvisorCollectors(DescribeFleetAdvisorCollectorsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of the Fleet Advisor collectors in your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorCollectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorCollectors service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorCollectors">REST API Reference for DescribeFleetAdvisorCollectors Operation</seealso>
        Task<DescribeFleetAdvisorCollectorsResponse> DescribeFleetAdvisorCollectorsAsync(DescribeFleetAdvisorCollectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetAdvisorDatabases


        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of Fleet Advisor databases in your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorDatabases service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorDatabases service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorDatabases">REST API Reference for DescribeFleetAdvisorDatabases Operation</seealso>
        DescribeFleetAdvisorDatabasesResponse DescribeFleetAdvisorDatabases(DescribeFleetAdvisorDatabasesRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of Fleet Advisor databases in your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorDatabases service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorDatabases">REST API Reference for DescribeFleetAdvisorDatabases Operation</seealso>
        Task<DescribeFleetAdvisorDatabasesResponse> DescribeFleetAdvisorDatabasesAsync(DescribeFleetAdvisorDatabasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetAdvisorLsaAnalysis


        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Provides descriptions of large-scale assessment (LSA) analyses produced by your Fleet
        /// Advisor collectors. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorLsaAnalysis service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorLsaAnalysis service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorLsaAnalysis">REST API Reference for DescribeFleetAdvisorLsaAnalysis Operation</seealso>
        DescribeFleetAdvisorLsaAnalysisResponse DescribeFleetAdvisorLsaAnalysis(DescribeFleetAdvisorLsaAnalysisRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Provides descriptions of large-scale assessment (LSA) analyses produced by your Fleet
        /// Advisor collectors. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorLsaAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorLsaAnalysis service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorLsaAnalysis">REST API Reference for DescribeFleetAdvisorLsaAnalysis Operation</seealso>
        Task<DescribeFleetAdvisorLsaAnalysisResponse> DescribeFleetAdvisorLsaAnalysisAsync(DescribeFleetAdvisorLsaAnalysisRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetAdvisorSchemaObjectSummary


        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Provides descriptions of the schemas discovered by your Fleet Advisor collectors.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorSchemaObjectSummary service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorSchemaObjectSummary service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorSchemaObjectSummary">REST API Reference for DescribeFleetAdvisorSchemaObjectSummary Operation</seealso>
        DescribeFleetAdvisorSchemaObjectSummaryResponse DescribeFleetAdvisorSchemaObjectSummary(DescribeFleetAdvisorSchemaObjectSummaryRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Provides descriptions of the schemas discovered by your Fleet Advisor collectors.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorSchemaObjectSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorSchemaObjectSummary service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorSchemaObjectSummary">REST API Reference for DescribeFleetAdvisorSchemaObjectSummary Operation</seealso>
        Task<DescribeFleetAdvisorSchemaObjectSummaryResponse> DescribeFleetAdvisorSchemaObjectSummaryAsync(DescribeFleetAdvisorSchemaObjectSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleetAdvisorSchemas


        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of schemas detected by Fleet Advisor Collectors in your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorSchemas service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorSchemas service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorSchemas">REST API Reference for DescribeFleetAdvisorSchemas Operation</seealso>
        DescribeFleetAdvisorSchemasResponse DescribeFleetAdvisorSchemas(DescribeFleetAdvisorSchemasRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of schemas detected by Fleet Advisor Collectors in your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAdvisorSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetAdvisorSchemas service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeFleetAdvisorSchemas">REST API Reference for DescribeFleetAdvisorSchemas Operation</seealso>
        Task<DescribeFleetAdvisorSchemasResponse> DescribeFleetAdvisorSchemasAsync(DescribeFleetAdvisorSchemasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeInstanceProfilesResponse DescribeInstanceProfiles(DescribeInstanceProfilesRequest request);



        /// <summary>
        /// Returns a paginated list of instance profiles for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeInstanceProfilesResponse> DescribeInstanceProfilesAsync(DescribeInstanceProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeMetadataModelAssessmentsResponse DescribeMetadataModelAssessments(DescribeMetadataModelAssessmentsRequest request);



        /// <summary>
        /// Returns a paginated list of metadata model assessments for your account in the current
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelAssessments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetadataModelAssessments service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelAssessments">REST API Reference for DescribeMetadataModelAssessments Operation</seealso>
        Task<DescribeMetadataModelAssessmentsResponse> DescribeMetadataModelAssessmentsAsync(DescribeMetadataModelAssessmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeMetadataModelConversionsResponse DescribeMetadataModelConversions(DescribeMetadataModelConversionsRequest request);



        /// <summary>
        /// Returns a paginated list of metadata model conversions for a migration project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelConversions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetadataModelConversions service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelConversions">REST API Reference for DescribeMetadataModelConversions Operation</seealso>
        Task<DescribeMetadataModelConversionsResponse> DescribeMetadataModelConversionsAsync(DescribeMetadataModelConversionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeMetadataModelExportsAsScriptResponse DescribeMetadataModelExportsAsScript(DescribeMetadataModelExportsAsScriptRequest request);



        /// <summary>
        /// Returns a paginated list of metadata model exports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelExportsAsScript service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetadataModelExportsAsScript service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelExportsAsScript">REST API Reference for DescribeMetadataModelExportsAsScript Operation</seealso>
        Task<DescribeMetadataModelExportsAsScriptResponse> DescribeMetadataModelExportsAsScriptAsync(DescribeMetadataModelExportsAsScriptRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeMetadataModelExportsToTargetResponse DescribeMetadataModelExportsToTarget(DescribeMetadataModelExportsToTargetRequest request);



        /// <summary>
        /// Returns a paginated list of metadata model exports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelExportsToTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetadataModelExportsToTarget service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelExportsToTarget">REST API Reference for DescribeMetadataModelExportsToTarget Operation</seealso>
        Task<DescribeMetadataModelExportsToTargetResponse> DescribeMetadataModelExportsToTargetAsync(DescribeMetadataModelExportsToTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeMetadataModelImportsResponse DescribeMetadataModelImports(DescribeMetadataModelImportsRequest request);



        /// <summary>
        /// Returns a paginated list of metadata model imports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetadataModelImports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetadataModelImports service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeMetadataModelImports">REST API Reference for DescribeMetadataModelImports Operation</seealso>
        Task<DescribeMetadataModelImportsResponse> DescribeMetadataModelImportsAsync(DescribeMetadataModelImportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeMigrationProjectsResponse DescribeMigrationProjects(DescribeMigrationProjectsRequest request);



        /// <summary>
        /// Returns a paginated list of migration projects for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMigrationProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeMigrationProjectsResponse> DescribeMigrationProjectsAsync(DescribeMigrationProjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeOrderableReplicationInstancesResponse DescribeOrderableReplicationInstances(DescribeOrderableReplicationInstancesRequest request);



        /// <summary>
        /// Returns information about the replication instance types that can be created in the
        /// specified region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableReplicationInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrderableReplicationInstances service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeOrderableReplicationInstances">REST API Reference for DescribeOrderableReplicationInstances Operation</seealso>
        Task<DescribeOrderableReplicationInstancesResponse> DescribeOrderableReplicationInstancesAsync(DescribeOrderableReplicationInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribePendingMaintenanceActionsResponse DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request);



        /// <summary>
        /// Returns a list of upcoming maintenance events for replication instances in your account
        /// in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePendingMaintenanceActions service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        Task<DescribePendingMaintenanceActionsResponse> DescribePendingMaintenanceActionsAsync(DescribePendingMaintenanceActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRecommendationLimitations


        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a paginated list of limitations for recommendations of target Amazon Web Services
        /// engines.
        /// </para>
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
        DescribeRecommendationLimitationsResponse DescribeRecommendationLimitations(DescribeRecommendationLimitationsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a paginated list of limitations for recommendations of target Amazon Web Services
        /// engines.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationLimitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRecommendationLimitations service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRecommendationLimitations">REST API Reference for DescribeRecommendationLimitations Operation</seealso>
        Task<DescribeRecommendationLimitationsResponse> DescribeRecommendationLimitationsAsync(DescribeRecommendationLimitationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRecommendations


        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a paginated list of target engine recommendations for your source databases.
        /// </para>
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
        DescribeRecommendationsResponse DescribeRecommendations(DescribeRecommendationsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a paginated list of target engine recommendations for your source databases.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRecommendations service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRecommendations">REST API Reference for DescribeRecommendations Operation</seealso>
        Task<DescribeRecommendationsResponse> DescribeRecommendationsAsync(DescribeRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeRefreshSchemasStatusResponse DescribeRefreshSchemasStatus(DescribeRefreshSchemasStatusRequest request);



        /// <summary>
        /// Returns the status of the RefreshSchemas operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchemasStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRefreshSchemasStatus service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRefreshSchemasStatus">REST API Reference for DescribeRefreshSchemasStatus Operation</seealso>
        Task<DescribeRefreshSchemasStatusResponse> DescribeRefreshSchemasStatusAsync(DescribeRefreshSchemasStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeReplicationConfigsResponse DescribeReplicationConfigs(DescribeReplicationConfigsRequest request);



        /// <summary>
        /// Returns one or more existing DMS Serverless replication configurations as a list of
        /// structures.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplicationConfigs service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationConfigs">REST API Reference for DescribeReplicationConfigs Operation</seealso>
        Task<DescribeReplicationConfigsResponse> DescribeReplicationConfigsAsync(DescribeReplicationConfigsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeReplicationInstancesResponse DescribeReplicationInstances(DescribeReplicationInstancesRequest request);



        /// <summary>
        /// Returns information about replication instances for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplicationInstances service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstances">REST API Reference for DescribeReplicationInstances Operation</seealso>
        Task<DescribeReplicationInstancesResponse> DescribeReplicationInstancesAsync(DescribeReplicationInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeReplicationInstanceTaskLogsResponse DescribeReplicationInstanceTaskLogs(DescribeReplicationInstanceTaskLogsRequest request);



        /// <summary>
        /// Returns information about the task logs for the specified task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstanceTaskLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplicationInstanceTaskLogs service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstanceTaskLogs">REST API Reference for DescribeReplicationInstanceTaskLogs Operation</seealso>
        Task<DescribeReplicationInstanceTaskLogsResponse> DescribeReplicationInstanceTaskLogsAsync(DescribeReplicationInstanceTaskLogsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeReplicationsResponse DescribeReplications(DescribeReplicationsRequest request);



        /// <summary>
        /// Provides details on replication progress by returning status information for one or
        /// more provisioned DMS Serverless replications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplications service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplications">REST API Reference for DescribeReplications Operation</seealso>
        Task<DescribeReplicationsResponse> DescribeReplicationsAsync(DescribeReplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeReplicationSubnetGroupsResponse DescribeReplicationSubnetGroups(DescribeReplicationSubnetGroupsRequest request);



        /// <summary>
        /// Returns information about the replication subnet groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationSubnetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplicationSubnetGroups service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationSubnetGroups">REST API Reference for DescribeReplicationSubnetGroups Operation</seealso>
        Task<DescribeReplicationSubnetGroupsResponse> DescribeReplicationSubnetGroupsAsync(DescribeReplicationSubnetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeReplicationTableStatisticsResponse DescribeReplicationTableStatistics(DescribeReplicationTableStatisticsRequest request);



        /// <summary>
        /// Returns table and schema statistics for one or more provisioned replications that
        /// use a given DMS Serverless replication configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTableStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplicationTableStatistics service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTableStatistics">REST API Reference for DescribeReplicationTableStatistics Operation</seealso>
        Task<DescribeReplicationTableStatisticsResponse> DescribeReplicationTableStatisticsAsync(DescribeReplicationTableStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeReplicationTaskAssessmentResultsResponse DescribeReplicationTaskAssessmentResults(DescribeReplicationTaskAssessmentResultsRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplicationTaskAssessmentResults service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskAssessmentResults">REST API Reference for DescribeReplicationTaskAssessmentResults Operation</seealso>
        Task<DescribeReplicationTaskAssessmentResultsResponse> DescribeReplicationTaskAssessmentResultsAsync(DescribeReplicationTaskAssessmentResultsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeReplicationTaskAssessmentRunsResponse DescribeReplicationTaskAssessmentRuns(DescribeReplicationTaskAssessmentRunsRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplicationTaskAssessmentRuns service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskAssessmentRuns">REST API Reference for DescribeReplicationTaskAssessmentRuns Operation</seealso>
        Task<DescribeReplicationTaskAssessmentRunsResponse> DescribeReplicationTaskAssessmentRunsAsync(DescribeReplicationTaskAssessmentRunsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeReplicationTaskIndividualAssessmentsResponse DescribeReplicationTaskIndividualAssessments(DescribeReplicationTaskIndividualAssessmentsRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplicationTaskIndividualAssessments service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskIndividualAssessments">REST API Reference for DescribeReplicationTaskIndividualAssessments Operation</seealso>
        Task<DescribeReplicationTaskIndividualAssessmentsResponse> DescribeReplicationTaskIndividualAssessmentsAsync(DescribeReplicationTaskIndividualAssessmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeReplicationTasksResponse DescribeReplicationTasks(DescribeReplicationTasksRequest request);



        /// <summary>
        /// Returns information about replication tasks for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplicationTasks service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTasks">REST API Reference for DescribeReplicationTasks Operation</seealso>
        Task<DescribeReplicationTasksResponse> DescribeReplicationTasksAsync(DescribeReplicationTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeSchemasResponse DescribeSchemas(DescribeSchemasRequest request);



        /// <summary>
        /// Returns information about the schema for the specified endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSchemas service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeSchemas">REST API Reference for DescribeSchemas Operation</seealso>
        Task<DescribeSchemasResponse> DescribeSchemasAsync(DescribeSchemasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeTableStatisticsResponse DescribeTableStatistics(DescribeTableStatisticsRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeTableStatisticsResponse> DescribeTableStatisticsAsync(DescribeTableStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ExportMetadataModelAssessmentResponse ExportMetadataModelAssessment(ExportMetadataModelAssessmentRequest request);



        /// <summary>
        /// Saves a copy of a database migration assessment report to your Amazon S3 bucket. DMS
        /// can save your assessment report as a comma-separated value (CSV) or a PDF file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportMetadataModelAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportMetadataModelAssessment service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ExportMetadataModelAssessment">REST API Reference for ExportMetadataModelAssessment Operation</seealso>
        Task<ExportMetadataModelAssessmentResponse> ExportMetadataModelAssessmentAsync(ExportMetadataModelAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ImportCertificateResponse ImportCertificate(ImportCertificateRequest request);



        /// <summary>
        /// Uploads the specified certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ImportCertificateResponse> ImportCertificateAsync(ImportCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists all metadata tags attached to an DMS resource, including replication instance,
        /// endpoint, subnet group, and migration task. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_Tag.html">
        /// <c>Tag</c> </a> data type description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyConversionConfigurationResponse ModifyConversionConfiguration(ModifyConversionConfigurationRequest request);



        /// <summary>
        /// Modifies the specified schema conversion configuration using the provided parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyConversionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyConversionConfiguration service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyConversionConfiguration">REST API Reference for ModifyConversionConfiguration Operation</seealso>
        Task<ModifyConversionConfigurationResponse> ModifyConversionConfigurationAsync(ModifyConversionConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyDataMigrationResponse ModifyDataMigration(ModifyDataMigrationRequest request);



        /// <summary>
        /// Modifies an existing DMS data migration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDataMigration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifyDataMigrationResponse> ModifyDataMigrationAsync(ModifyDataMigrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyDataProviderResponse ModifyDataProvider(ModifyDataProviderRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifyDataProviderResponse> ModifyDataProviderAsync(ModifyDataProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyEndpointResponse ModifyEndpoint(ModifyEndpointRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifyEndpointResponse> ModifyEndpointAsync(ModifyEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request);



        /// <summary>
        /// Modifies an existing DMS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyInstanceProfileResponse ModifyInstanceProfile(ModifyInstanceProfileRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifyInstanceProfileResponse> ModifyInstanceProfileAsync(ModifyInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyMigrationProjectResponse ModifyMigrationProject(ModifyMigrationProjectRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifyMigrationProjectResponse> ModifyMigrationProjectAsync(ModifyMigrationProjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyReplicationConfigResponse ModifyReplicationConfig(ModifyReplicationConfigRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifyReplicationConfigResponse> ModifyReplicationConfigAsync(ModifyReplicationConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyReplicationInstanceResponse ModifyReplicationInstance(ModifyReplicationInstanceRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifyReplicationInstanceResponse> ModifyReplicationInstanceAsync(ModifyReplicationInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyReplicationSubnetGroupResponse ModifyReplicationSubnetGroup(ModifyReplicationSubnetGroupRequest request);



        /// <summary>
        /// Modifies the settings for the specified replication subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifyReplicationSubnetGroupResponse> ModifyReplicationSubnetGroupAsync(ModifyReplicationSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyReplicationTaskResponse ModifyReplicationTask(ModifyReplicationTaskRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ModifyReplicationTaskResponse> ModifyReplicationTaskAsync(ModifyReplicationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        MoveReplicationTaskResponse MoveReplicationTask(MoveReplicationTaskRequest request);



        /// <summary>
        /// Moves a replication task from its current replication instance to a different target
        /// replication instance using the specified parameters. The target replication instance
        /// must be created with the same or later DMS version as the current replication instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MoveReplicationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<MoveReplicationTaskResponse> MoveReplicationTaskAsync(MoveReplicationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        RebootReplicationInstanceResponse RebootReplicationInstance(RebootReplicationInstanceRequest request);



        /// <summary>
        /// Reboots a replication instance. Rebooting results in a momentary outage, until the
        /// replication instance becomes available again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootReplicationInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RebootReplicationInstance">REST API Reference for RebootReplicationInstance Operation</seealso>
        Task<RebootReplicationInstanceResponse> RebootReplicationInstanceAsync(RebootReplicationInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        RefreshSchemasResponse RefreshSchemas(RefreshSchemasRequest request);



        /// <summary>
        /// Populates the schema for the specified endpoint. This is an asynchronous operation
        /// and can take several minutes. You can check the status of this operation by calling
        /// the DescribeRefreshSchemasStatus operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RefreshSchemasResponse> RefreshSchemasAsync(RefreshSchemasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ReloadReplicationTablesResponse ReloadReplicationTables(ReloadReplicationTablesRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReloadReplicationTables service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ReloadReplicationTables">REST API Reference for ReloadReplicationTables Operation</seealso>
        Task<ReloadReplicationTablesResponse> ReloadReplicationTablesAsync(ReloadReplicationTablesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ReloadTablesResponse ReloadTables(ReloadTablesRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReloadTables service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ReloadTables">REST API Reference for ReloadTables Operation</seealso>
        Task<ReloadTablesResponse> ReloadTablesAsync(ReloadTablesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request);



        /// <summary>
        /// Removes metadata tags from an DMS resource, including replication instance, endpoint,
        /// subnet group, and migration task. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_Tag.html">
        /// <c>Tag</c> </a> data type description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RunFleetAdvisorLsaAnalysis


        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Runs large-scale assessment (LSA) analysis on every Fleet Advisor collector in your
        /// account.
        /// </para>
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
        RunFleetAdvisorLsaAnalysisResponse RunFleetAdvisorLsaAnalysis(RunFleetAdvisorLsaAnalysisRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Runs large-scale assessment (LSA) analysis on every Fleet Advisor collector in your
        /// account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunFleetAdvisorLsaAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunFleetAdvisorLsaAnalysis service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RunFleetAdvisorLsaAnalysis">REST API Reference for RunFleetAdvisorLsaAnalysis Operation</seealso>
        Task<RunFleetAdvisorLsaAnalysisResponse> RunFleetAdvisorLsaAnalysisAsync(RunFleetAdvisorLsaAnalysisRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartDataMigrationResponse StartDataMigration(StartDataMigrationRequest request);



        /// <summary>
        /// Starts the specified data migration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataMigration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartDataMigrationResponse> StartDataMigrationAsync(StartDataMigrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartExtensionPackAssociationResponse StartExtensionPackAssociation(StartExtensionPackAssociationRequest request);



        /// <summary>
        /// Applies the extension pack to your target database. An extension pack is an add-on
        /// module that emulates functions present in a source database that are required when
        /// converting objects to the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExtensionPackAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartExtensionPackAssociationResponse> StartExtensionPackAssociationAsync(StartExtensionPackAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartMetadataModelAssessmentResponse StartMetadataModelAssessment(StartMetadataModelAssessmentRequest request);



        /// <summary>
        /// Creates a database migration assessment report by assessing the migration complexity
        /// for your source database. A database migration assessment report summarizes all of
        /// the schema conversion tasks. It also details the action items for database objects
        /// that can't be converted to the database engine of your target database instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartMetadataModelAssessmentResponse> StartMetadataModelAssessmentAsync(StartMetadataModelAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartMetadataModelConversionResponse StartMetadataModelConversion(StartMetadataModelConversionRequest request);



        /// <summary>
        /// Converts your source database objects to a format compatible with the target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelConversion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartMetadataModelConversionResponse> StartMetadataModelConversionAsync(StartMetadataModelConversionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartMetadataModelExportAsScriptResponse StartMetadataModelExportAsScript(StartMetadataModelExportAsScriptRequest request);



        /// <summary>
        /// Saves your converted code to a file as a SQL script, and stores this file on your
        /// Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelExportAsScript service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartMetadataModelExportAsScriptResponse> StartMetadataModelExportAsScriptAsync(StartMetadataModelExportAsScriptRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartMetadataModelExportToTargetResponse StartMetadataModelExportToTarget(StartMetadataModelExportToTargetRequest request);



        /// <summary>
        /// Applies converted database objects to your target database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataModelExportToTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartMetadataModelExportToTargetResponse> StartMetadataModelExportToTargetAsync(StartMetadataModelExportToTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartMetadataModelImportResponse StartMetadataModelImport(StartMetadataModelImportRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartMetadataModelImportResponse> StartMetadataModelImportAsync(StartMetadataModelImportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartRecommendations


        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Starts the analysis of your source database to provide recommendations of target engines.
        /// </para>
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
        StartRecommendationsResponse StartRecommendations(StartRecommendationsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
        /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
        /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
        /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
        /// Web Services DMS Fleet Advisor end of support</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Starts the analysis of your source database to provide recommendations of target engines.
        /// </para>
        ///  
        /// <para>
        /// You can create recommendations for multiple source databases using <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_BatchStartRecommendations.html">BatchStartRecommendations</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartRecommendationsResponse> StartRecommendationsAsync(StartRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartReplicationResponse StartReplication(StartReplicationRequest request);



        /// <summary>
        /// For a given DMS Serverless replication configuration, DMS connects to the source endpoint
        /// and collects the metadata to analyze the replication workload. Using this metadata,
        /// DMS then computes and provisions the required capacity and starts replicating to the
        /// target endpoint using the server resources that DMS has provisioned for the DMS Serverless
        /// replication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartReplicationResponse> StartReplicationAsync(StartReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartReplicationTaskResponse StartReplicationTask(StartReplicationTaskRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartReplicationTaskResponse> StartReplicationTaskAsync(StartReplicationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartReplicationTaskAssessmentResponse StartReplicationTaskAssessment(StartReplicationTaskAssessmentRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartReplicationTaskAssessment service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTaskAssessment">REST API Reference for StartReplicationTaskAssessment Operation</seealso>
        Task<StartReplicationTaskAssessmentResponse> StartReplicationTaskAssessmentAsync(StartReplicationTaskAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StartReplicationTaskAssessmentRunResponse StartReplicationTaskAssessmentRun(StartReplicationTaskAssessmentRunRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartReplicationTaskAssessmentRunResponse> StartReplicationTaskAssessmentRunAsync(StartReplicationTaskAssessmentRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StopDataMigrationResponse StopDataMigration(StopDataMigrationRequest request);



        /// <summary>
        /// Stops the specified data migration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataMigration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopDataMigrationResponse> StopDataMigrationAsync(StopDataMigrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StopReplicationResponse StopReplication(StopReplicationRequest request);



        /// <summary>
        /// For a given DMS Serverless replication configuration, DMS stops any and all ongoing
        /// DMS Serverless replications. This command doesn't deprovision the stopped replications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopReplicationResponse> StopReplicationAsync(StopReplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StopReplicationTaskResponse StopReplicationTask(StopReplicationTaskRequest request);



        /// <summary>
        /// Stops the replication task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopReplicationTask">REST API Reference for StopReplicationTask Operation</seealso>
        Task<StopReplicationTaskResponse> StopReplicationTaskAsync(StopReplicationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        TestConnectionResponse TestConnection(TestConnectionRequest request);



        /// <summary>
        /// Tests the connection between the replication instance and the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TestConnectionResponse> TestConnectionAsync(TestConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateSubscriptionsToEventBridgeResponse UpdateSubscriptionsToEventBridge(UpdateSubscriptionsToEventBridgeRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriptionsToEventBridge service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// DMS was denied access to the endpoint. Check that the role is correctly configured.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/UpdateSubscriptionsToEventBridge">REST API Reference for UpdateSubscriptionsToEventBridge Operation</seealso>
        Task<UpdateSubscriptionsToEventBridgeResponse> UpdateSubscriptionsToEventBridgeAsync(UpdateSubscriptionsToEventBridgeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}