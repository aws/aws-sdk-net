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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DatabaseMigrationService.Model;
using Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations;
using Amazon.DatabaseMigrationService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

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
            : base(new AmazonDatabaseMigrationServiceConfig()) { }

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
            : base(new AmazonDatabaseMigrationServiceConfig{RegionEndpoint = region}) { }

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
            : base(config) { }

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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDatabaseMigrationServiceEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDatabaseMigrationServiceAuthSchemeHandler());
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }


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
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddTagsToResourceResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return Invoke<ApplyPendingMaintenanceActionResponse>(request, options);
        }


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
        public virtual Task<ApplyPendingMaintenanceActionResponse> ApplyPendingMaintenanceActionAsync(ApplyPendingMaintenanceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ApplyPendingMaintenanceActionResponse>(request, options, cancellationToken);
        }

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
        public virtual BatchStartRecommendationsResponse BatchStartRecommendations(BatchStartRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchStartRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchStartRecommendationsResponseUnmarshaller.Instance;

            return Invoke<BatchStartRecommendationsResponse>(request, options);
        }


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
        public virtual Task<BatchStartRecommendationsResponse> BatchStartRecommendationsAsync(BatchStartRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchStartRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchStartRecommendationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchStartRecommendationsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelReplicationTaskAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelReplicationTaskAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<CancelReplicationTaskAssessmentRunResponse>(request, options);
        }


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
        public virtual Task<CancelReplicationTaskAssessmentRunResponse> CancelReplicationTaskAssessmentRunAsync(CancelReplicationTaskAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelReplicationTaskAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelReplicationTaskAssessmentRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelReplicationTaskAssessmentRunResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataMigrationResponseUnmarshaller.Instance;

            return Invoke<CreateDataMigrationResponse>(request, options);
        }


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
        public virtual Task<CreateDataMigrationResponse> CreateDataMigrationAsync(CreateDataMigrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataMigrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDataMigrationResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProviderResponseUnmarshaller.Instance;

            return Invoke<CreateDataProviderResponse>(request, options);
        }


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
        public virtual Task<CreateDataProviderResponse> CreateDataProviderAsync(CreateDataProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProviderResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDataProviderResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointResponse>(request, options);
        }


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
        public virtual Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEndpointResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionResponse>(request, options);
        }


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
        public virtual Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEventSubscriptionResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateFleetAdvisorCollectorResponse CreateFleetAdvisorCollector(CreateFleetAdvisorCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFleetAdvisorCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetAdvisorCollectorResponseUnmarshaller.Instance;

            return Invoke<CreateFleetAdvisorCollectorResponse>(request, options);
        }


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
        public virtual Task<CreateFleetAdvisorCollectorResponse> CreateFleetAdvisorCollectorAsync(CreateFleetAdvisorCollectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFleetAdvisorCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetAdvisorCollectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFleetAdvisorCollectorResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceProfileResponse>(request, options);
        }


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
        public virtual Task<CreateInstanceProfileResponse> CreateInstanceProfileAsync(CreateInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateInstanceProfileResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMigrationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMigrationProjectResponseUnmarshaller.Instance;

            return Invoke<CreateMigrationProjectResponse>(request, options);
        }


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
        public virtual Task<CreateMigrationProjectResponse> CreateMigrationProjectAsync(CreateMigrationProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMigrationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMigrationProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMigrationProjectResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReplicationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationConfigResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationConfigResponse>(request, options);
        }


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
        public virtual Task<CreateReplicationConfigResponse> CreateReplicationConfigAsync(CreateReplicationConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReplicationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateReplicationConfigResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationInstanceResponse>(request, options);
        }


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
        public virtual Task<CreateReplicationInstanceResponse> CreateReplicationInstanceAsync(CreateReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateReplicationInstanceResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationSubnetGroupResponse>(request, options);
        }


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
        public virtual Task<CreateReplicationSubnetGroupResponse> CreateReplicationSubnetGroupAsync(CreateReplicationSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationSubnetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateReplicationSubnetGroupResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationTaskResponse>(request, options);
        }


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
        public virtual Task<CreateReplicationTaskResponse> CreateReplicationTaskAsync(CreateReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateReplicationTaskResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateResponse>(request, options);
        }


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
        public virtual Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCertificateResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionResponse>(request, options);
        }


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
        public virtual Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConnectionResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataMigrationResponseUnmarshaller.Instance;

            return Invoke<DeleteDataMigrationResponse>(request, options);
        }


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
        public virtual Task<DeleteDataMigrationResponse> DeleteDataMigrationAsync(DeleteDataMigrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataMigrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDataMigrationResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteDataProviderResponse>(request, options);
        }


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
        public virtual Task<DeleteDataProviderResponse> DeleteDataProviderAsync(DeleteDataProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProviderResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDataProviderResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointResponse>(request, options);
        }


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
        public virtual Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEndpointResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionResponse>(request, options);
        }


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
        public virtual Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEventSubscriptionResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteFleetAdvisorCollectorResponse DeleteFleetAdvisorCollector(DeleteFleetAdvisorCollectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetAdvisorCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetAdvisorCollectorResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetAdvisorCollectorResponse>(request, options);
        }


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
        public virtual Task<DeleteFleetAdvisorCollectorResponse> DeleteFleetAdvisorCollectorAsync(DeleteFleetAdvisorCollectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetAdvisorCollectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetAdvisorCollectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFleetAdvisorCollectorResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteFleetAdvisorDatabasesResponse DeleteFleetAdvisorDatabases(DeleteFleetAdvisorDatabasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetAdvisorDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetAdvisorDatabasesResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetAdvisorDatabasesResponse>(request, options);
        }


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
        public virtual Task<DeleteFleetAdvisorDatabasesResponse> DeleteFleetAdvisorDatabasesAsync(DeleteFleetAdvisorDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetAdvisorDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetAdvisorDatabasesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFleetAdvisorDatabasesResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceProfileResponse>(request, options);
        }


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
        public virtual Task<DeleteInstanceProfileResponse> DeleteInstanceProfileAsync(DeleteInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInstanceProfileResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMigrationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMigrationProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteMigrationProjectResponse>(request, options);
        }


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
        public virtual Task<DeleteMigrationProjectResponse> DeleteMigrationProjectAsync(DeleteMigrationProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMigrationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMigrationProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMigrationProjectResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationConfigResponse>(request, options);
        }


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
        public virtual Task<DeleteReplicationConfigResponse> DeleteReplicationConfigAsync(DeleteReplicationConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteReplicationConfigResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationInstanceResponse>(request, options);
        }


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
        public virtual Task<DeleteReplicationInstanceResponse> DeleteReplicationInstanceAsync(DeleteReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteReplicationInstanceResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationSubnetGroupResponse>(request, options);
        }


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
        public virtual Task<DeleteReplicationSubnetGroupResponse> DeleteReplicationSubnetGroupAsync(DeleteReplicationSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationSubnetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteReplicationSubnetGroupResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationTaskResponse>(request, options);
        }


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
        public virtual Task<DeleteReplicationTaskResponse> DeleteReplicationTaskAsync(DeleteReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteReplicationTaskResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicationTaskAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationTaskAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationTaskAssessmentRunResponse>(request, options);
        }


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
        public virtual Task<DeleteReplicationTaskAssessmentRunResponse> DeleteReplicationTaskAssessmentRunAsync(DeleteReplicationTaskAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicationTaskAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationTaskAssessmentRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteReplicationTaskAssessmentRunResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesResponse>(request, options);
        }


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
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccountAttributesResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicableIndividualAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicableIndividualAssessmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicableIndividualAssessmentsResponse>(request, options);
        }


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
        public virtual Task<DescribeApplicableIndividualAssessmentsResponse> DescribeApplicableIndividualAssessmentsAsync(DescribeApplicableIndividualAssessmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicableIndividualAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicableIndividualAssessmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeApplicableIndividualAssessmentsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificatesResponse>(request, options);
        }


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
        public virtual Task<DescribeCertificatesResponse> DescribeCertificatesAsync(DescribeCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeCertificatesResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionsResponse>(request, options);
        }


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
        public virtual Task<DescribeConnectionsResponse> DescribeConnectionsAsync(DescribeConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConnectionsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConversionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConversionConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeConversionConfigurationResponse>(request, options);
        }


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
        public virtual Task<DescribeConversionConfigurationResponse> DescribeConversionConfigurationAsync(DescribeConversionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConversionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConversionConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConversionConfigurationResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDataMigrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataMigrationsResponseUnmarshaller.Instance;

            return Invoke<DescribeDataMigrationsResponse>(request, options);
        }


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
        public virtual Task<DescribeDataMigrationsResponse> DescribeDataMigrationsAsync(DescribeDataMigrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDataMigrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataMigrationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDataMigrationsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDataProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataProvidersResponseUnmarshaller.Instance;

            return Invoke<DescribeDataProvidersResponse>(request, options);
        }


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
        public virtual Task<DescribeDataProvidersResponse> DescribeDataProvidersAsync(DescribeDataProvidersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDataProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataProvidersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDataProvidersResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointsResponse>(request, options);
        }


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
        public virtual Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEndpointsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEndpointSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointSettingsResponse>(request, options);
        }


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
        public virtual Task<DescribeEndpointSettingsResponse> DescribeEndpointSettingsAsync(DescribeEndpointSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEndpointSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEndpointSettingsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEndpointTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointTypesResponse>(request, options);
        }


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
        public virtual Task<DescribeEndpointTypesResponse> DescribeEndpointTypesAsync(DescribeEndpointTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEndpointTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEndpointTypesResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineVersionsResponse>(request, options);
        }


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
        public virtual Task<DescribeEngineVersionsResponse> DescribeEngineVersionsAsync(DescribeEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEngineVersionsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesResponse>(request, options);
        }


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
        public virtual Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventCategoriesResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }


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
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsResponse>(request, options);
        }


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
        public virtual Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventSubscriptionsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExtensionPackAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExtensionPackAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeExtensionPackAssociationsResponse>(request, options);
        }


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
        public virtual Task<DescribeExtensionPackAssociationsResponse> DescribeExtensionPackAssociationsAsync(DescribeExtensionPackAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExtensionPackAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExtensionPackAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeExtensionPackAssociationsResponse>(request, options, cancellationToken);
        }

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
        public virtual DescribeFleetAdvisorCollectorsResponse DescribeFleetAdvisorCollectors(DescribeFleetAdvisorCollectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorCollectorsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAdvisorCollectorsResponse>(request, options);
        }


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
        public virtual Task<DescribeFleetAdvisorCollectorsResponse> DescribeFleetAdvisorCollectorsAsync(DescribeFleetAdvisorCollectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorCollectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorCollectorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFleetAdvisorCollectorsResponse>(request, options, cancellationToken);
        }

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
        public virtual DescribeFleetAdvisorDatabasesResponse DescribeFleetAdvisorDatabases(DescribeFleetAdvisorDatabasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorDatabasesResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAdvisorDatabasesResponse>(request, options);
        }


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
        public virtual Task<DescribeFleetAdvisorDatabasesResponse> DescribeFleetAdvisorDatabasesAsync(DescribeFleetAdvisorDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorDatabasesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFleetAdvisorDatabasesResponse>(request, options, cancellationToken);
        }

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
        public virtual DescribeFleetAdvisorLsaAnalysisResponse DescribeFleetAdvisorLsaAnalysis(DescribeFleetAdvisorLsaAnalysisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorLsaAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorLsaAnalysisResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAdvisorLsaAnalysisResponse>(request, options);
        }


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
        public virtual Task<DescribeFleetAdvisorLsaAnalysisResponse> DescribeFleetAdvisorLsaAnalysisAsync(DescribeFleetAdvisorLsaAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorLsaAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorLsaAnalysisResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFleetAdvisorLsaAnalysisResponse>(request, options, cancellationToken);
        }

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
        public virtual DescribeFleetAdvisorSchemaObjectSummaryResponse DescribeFleetAdvisorSchemaObjectSummary(DescribeFleetAdvisorSchemaObjectSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorSchemaObjectSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorSchemaObjectSummaryResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAdvisorSchemaObjectSummaryResponse>(request, options);
        }


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
        public virtual Task<DescribeFleetAdvisorSchemaObjectSummaryResponse> DescribeFleetAdvisorSchemaObjectSummaryAsync(DescribeFleetAdvisorSchemaObjectSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorSchemaObjectSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorSchemaObjectSummaryResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFleetAdvisorSchemaObjectSummaryResponse>(request, options, cancellationToken);
        }

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
        public virtual DescribeFleetAdvisorSchemasResponse DescribeFleetAdvisorSchemas(DescribeFleetAdvisorSchemasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorSchemasResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAdvisorSchemasResponse>(request, options);
        }


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
        public virtual Task<DescribeFleetAdvisorSchemasResponse> DescribeFleetAdvisorSchemasAsync(DescribeFleetAdvisorSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetAdvisorSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAdvisorSchemasResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFleetAdvisorSchemasResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInstanceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceProfilesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceProfilesResponse>(request, options);
        }


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
        public virtual Task<DescribeInstanceProfilesResponse> DescribeInstanceProfilesAsync(DescribeInstanceProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInstanceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceProfilesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeInstanceProfilesResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelAssessmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeMetadataModelAssessmentsResponse>(request, options);
        }


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
        public virtual Task<DescribeMetadataModelAssessmentsResponse> DescribeMetadataModelAssessmentsAsync(DescribeMetadataModelAssessmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelAssessmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMetadataModelAssessmentsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelConversionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelConversionsResponseUnmarshaller.Instance;

            return Invoke<DescribeMetadataModelConversionsResponse>(request, options);
        }


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
        public virtual Task<DescribeMetadataModelConversionsResponse> DescribeMetadataModelConversionsAsync(DescribeMetadataModelConversionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelConversionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelConversionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMetadataModelConversionsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelExportsAsScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelExportsAsScriptResponseUnmarshaller.Instance;

            return Invoke<DescribeMetadataModelExportsAsScriptResponse>(request, options);
        }


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
        public virtual Task<DescribeMetadataModelExportsAsScriptResponse> DescribeMetadataModelExportsAsScriptAsync(DescribeMetadataModelExportsAsScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelExportsAsScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelExportsAsScriptResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMetadataModelExportsAsScriptResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelExportsToTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelExportsToTargetResponseUnmarshaller.Instance;

            return Invoke<DescribeMetadataModelExportsToTargetResponse>(request, options);
        }


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
        public virtual Task<DescribeMetadataModelExportsToTargetResponse> DescribeMetadataModelExportsToTargetAsync(DescribeMetadataModelExportsToTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelExportsToTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelExportsToTargetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMetadataModelExportsToTargetResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelImportsResponseUnmarshaller.Instance;

            return Invoke<DescribeMetadataModelImportsResponse>(request, options);
        }


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
        public virtual Task<DescribeMetadataModelImportsResponse> DescribeMetadataModelImportsAsync(DescribeMetadataModelImportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMetadataModelImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetadataModelImportsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMetadataModelImportsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMigrationProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMigrationProjectsResponseUnmarshaller.Instance;

            return Invoke<DescribeMigrationProjectsResponse>(request, options);
        }


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
        public virtual Task<DescribeMigrationProjectsResponse> DescribeMigrationProjectsAsync(DescribeMigrationProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMigrationProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMigrationProjectsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMigrationProjectsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrderableReplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableReplicationInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableReplicationInstancesResponse>(request, options);
        }


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
        public virtual Task<DescribeOrderableReplicationInstancesResponse> DescribeOrderableReplicationInstancesAsync(DescribeOrderableReplicationInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrderableReplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableReplicationInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOrderableReplicationInstancesResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return Invoke<DescribePendingMaintenanceActionsResponse>(request, options);
        }


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
        public virtual Task<DescribePendingMaintenanceActionsResponse> DescribePendingMaintenanceActionsAsync(DescribePendingMaintenanceActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePendingMaintenanceActionsResponse>(request, options, cancellationToken);
        }

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
        public virtual DescribeRecommendationLimitationsResponse DescribeRecommendationLimitations(DescribeRecommendationLimitationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationLimitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationLimitationsResponseUnmarshaller.Instance;

            return Invoke<DescribeRecommendationLimitationsResponse>(request, options);
        }


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
        public virtual Task<DescribeRecommendationLimitationsResponse> DescribeRecommendationLimitationsAsync(DescribeRecommendationLimitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationLimitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationLimitationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRecommendationLimitationsResponse>(request, options, cancellationToken);
        }

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
        public virtual DescribeRecommendationsResponse DescribeRecommendations(DescribeRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationsResponseUnmarshaller.Instance;

            return Invoke<DescribeRecommendationsResponse>(request, options);
        }


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
        public virtual Task<DescribeRecommendationsResponse> DescribeRecommendationsAsync(DescribeRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRecommendationsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRefreshSchemasStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRefreshSchemasStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeRefreshSchemasStatusResponse>(request, options);
        }


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
        public virtual Task<DescribeRefreshSchemasStatusResponse> DescribeRefreshSchemasStatusAsync(DescribeRefreshSchemasStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRefreshSchemasStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRefreshSchemasStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRefreshSchemasStatusResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationConfigsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationConfigsResponse>(request, options);
        }


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
        public virtual Task<DescribeReplicationConfigsResponse> DescribeReplicationConfigsAsync(DescribeReplicationConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationConfigsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationConfigsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationInstancesResponse>(request, options);
        }


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
        public virtual Task<DescribeReplicationInstancesResponse> DescribeReplicationInstancesAsync(DescribeReplicationInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationInstancesResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationInstanceTaskLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationInstanceTaskLogsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationInstanceTaskLogsResponse>(request, options);
        }


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
        public virtual Task<DescribeReplicationInstanceTaskLogsResponse> DescribeReplicationInstanceTaskLogsAsync(DescribeReplicationInstanceTaskLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationInstanceTaskLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationInstanceTaskLogsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationInstanceTaskLogsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationsResponse>(request, options);
        }


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
        public virtual Task<DescribeReplicationsResponse> DescribeReplicationsAsync(DescribeReplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationSubnetGroupsResponse>(request, options);
        }


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
        public virtual Task<DescribeReplicationSubnetGroupsResponse> DescribeReplicationSubnetGroupsAsync(DescribeReplicationSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationSubnetGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationSubnetGroupsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTableStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTableStatisticsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTableStatisticsResponse>(request, options);
        }


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
        public virtual Task<DescribeReplicationTableStatisticsResponse> DescribeReplicationTableStatisticsAsync(DescribeReplicationTableStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTableStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTableStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationTableStatisticsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskAssessmentResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskAssessmentResultsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTaskAssessmentResultsResponse>(request, options);
        }


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
        public virtual Task<DescribeReplicationTaskAssessmentResultsResponse> DescribeReplicationTaskAssessmentResultsAsync(DescribeReplicationTaskAssessmentResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskAssessmentResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskAssessmentResultsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationTaskAssessmentResultsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTaskAssessmentRunsResponse>(request, options);
        }


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
        public virtual Task<DescribeReplicationTaskAssessmentRunsResponse> DescribeReplicationTaskAssessmentRunsAsync(DescribeReplicationTaskAssessmentRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskAssessmentRunsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationTaskAssessmentRunsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskIndividualAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskIndividualAssessmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTaskIndividualAssessmentsResponse>(request, options);
        }


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
        public virtual Task<DescribeReplicationTaskIndividualAssessmentsResponse> DescribeReplicationTaskIndividualAssessmentsAsync(DescribeReplicationTaskIndividualAssessmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskIndividualAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskIndividualAssessmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationTaskIndividualAssessmentsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTasksResponse>(request, options);
        }


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
        public virtual Task<DescribeReplicationTasksResponse> DescribeReplicationTasksAsync(DescribeReplicationTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationTasksResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemasResponseUnmarshaller.Instance;

            return Invoke<DescribeSchemasResponse>(request, options);
        }


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
        public virtual Task<DescribeSchemasResponse> DescribeSchemasAsync(DescribeSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemasResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSchemasResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTableStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableStatisticsResponseUnmarshaller.Instance;

            return Invoke<DescribeTableStatisticsResponse>(request, options);
        }


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
        public virtual Task<DescribeTableStatisticsResponse> DescribeTableStatisticsAsync(DescribeTableStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTableStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTableStatisticsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportMetadataModelAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportMetadataModelAssessmentResponseUnmarshaller.Instance;

            return Invoke<ExportMetadataModelAssessmentResponse>(request, options);
        }


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
        public virtual Task<ExportMetadataModelAssessmentResponse> ExportMetadataModelAssessmentAsync(ExportMetadataModelAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportMetadataModelAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportMetadataModelAssessmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExportMetadataModelAssessmentResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return Invoke<ImportCertificateResponse>(request, options);
        }


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
        public virtual Task<ImportCertificateResponse> ImportCertificateAsync(ImportCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportCertificateResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyConversionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyConversionConfigurationResponseUnmarshaller.Instance;

            return Invoke<ModifyConversionConfigurationResponse>(request, options);
        }


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
        public virtual Task<ModifyConversionConfigurationResponse> ModifyConversionConfigurationAsync(ModifyConversionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyConversionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyConversionConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyConversionConfigurationResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDataMigrationResponseUnmarshaller.Instance;

            return Invoke<ModifyDataMigrationResponse>(request, options);
        }


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
        public virtual Task<ModifyDataMigrationResponse> ModifyDataMigrationAsync(ModifyDataMigrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDataMigrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDataMigrationResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDataProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDataProviderResponseUnmarshaller.Instance;

            return Invoke<ModifyDataProviderResponse>(request, options);
        }


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
        public virtual Task<ModifyDataProviderResponse> ModifyDataProviderAsync(ModifyDataProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDataProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDataProviderResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDataProviderResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyEndpointResponse>(request, options);
        }


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
        public virtual Task<ModifyEndpointResponse> ModifyEndpointAsync(ModifyEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyEndpointResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionResponse>(request, options);
        }


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
        public virtual Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyEventSubscriptionResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceProfileResponse>(request, options);
        }


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
        public virtual Task<ModifyInstanceProfileResponse> ModifyInstanceProfileAsync(ModifyInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyInstanceProfileResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyMigrationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyMigrationProjectResponseUnmarshaller.Instance;

            return Invoke<ModifyMigrationProjectResponse>(request, options);
        }


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
        public virtual Task<ModifyMigrationProjectResponse> ModifyMigrationProjectAsync(ModifyMigrationProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyMigrationProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyMigrationProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyMigrationProjectResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReplicationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationConfigResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationConfigResponse>(request, options);
        }


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
        public virtual Task<ModifyReplicationConfigResponse> ModifyReplicationConfigAsync(ModifyReplicationConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReplicationConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyReplicationConfigResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationInstanceResponse>(request, options);
        }


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
        public virtual Task<ModifyReplicationInstanceResponse> ModifyReplicationInstanceAsync(ModifyReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyReplicationInstanceResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationSubnetGroupResponse>(request, options);
        }


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
        public virtual Task<ModifyReplicationSubnetGroupResponse> ModifyReplicationSubnetGroupAsync(ModifyReplicationSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationSubnetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyReplicationSubnetGroupResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationTaskResponse>(request, options);
        }


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
        public virtual Task<ModifyReplicationTaskResponse> ModifyReplicationTaskAsync(ModifyReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyReplicationTaskResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MoveReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MoveReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<MoveReplicationTaskResponse>(request, options);
        }


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
        public virtual Task<MoveReplicationTaskResponse> MoveReplicationTaskAsync(MoveReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MoveReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MoveReplicationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<MoveReplicationTaskResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootReplicationInstanceResponse>(request, options);
        }


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
        public virtual Task<RebootReplicationInstanceResponse> RebootReplicationInstanceAsync(RebootReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootReplicationInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<RebootReplicationInstanceResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RefreshSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshSchemasResponseUnmarshaller.Instance;

            return Invoke<RefreshSchemasResponse>(request, options);
        }


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
        public virtual Task<RefreshSchemasResponse> RefreshSchemasAsync(RefreshSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RefreshSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshSchemasResponseUnmarshaller.Instance;
            
            return InvokeAsync<RefreshSchemasResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReloadReplicationTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReloadReplicationTablesResponseUnmarshaller.Instance;

            return Invoke<ReloadReplicationTablesResponse>(request, options);
        }


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
        public virtual Task<ReloadReplicationTablesResponse> ReloadReplicationTablesAsync(ReloadReplicationTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReloadReplicationTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReloadReplicationTablesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReloadReplicationTablesResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReloadTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReloadTablesResponseUnmarshaller.Instance;

            return Invoke<ReloadTablesResponse>(request, options);
        }


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
        public virtual Task<ReloadTablesResponse> ReloadTablesAsync(ReloadTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReloadTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReloadTablesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReloadTablesResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }


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
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual RunFleetAdvisorLsaAnalysisResponse RunFleetAdvisorLsaAnalysis(RunFleetAdvisorLsaAnalysisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RunFleetAdvisorLsaAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunFleetAdvisorLsaAnalysisResponseUnmarshaller.Instance;

            return Invoke<RunFleetAdvisorLsaAnalysisResponse>(request, options);
        }


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
        public virtual Task<RunFleetAdvisorLsaAnalysisResponse> RunFleetAdvisorLsaAnalysisAsync(RunFleetAdvisorLsaAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RunFleetAdvisorLsaAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunFleetAdvisorLsaAnalysisResponseUnmarshaller.Instance;
            
            return InvokeAsync<RunFleetAdvisorLsaAnalysisResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataMigrationResponseUnmarshaller.Instance;

            return Invoke<StartDataMigrationResponse>(request, options);
        }


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
        public virtual Task<StartDataMigrationResponse> StartDataMigrationAsync(StartDataMigrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataMigrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartDataMigrationResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExtensionPackAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExtensionPackAssociationResponseUnmarshaller.Instance;

            return Invoke<StartExtensionPackAssociationResponse>(request, options);
        }


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
        public virtual Task<StartExtensionPackAssociationResponse> StartExtensionPackAssociationAsync(StartExtensionPackAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExtensionPackAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExtensionPackAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartExtensionPackAssociationResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataModelAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelAssessmentResponseUnmarshaller.Instance;

            return Invoke<StartMetadataModelAssessmentResponse>(request, options);
        }


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
        public virtual Task<StartMetadataModelAssessmentResponse> StartMetadataModelAssessmentAsync(StartMetadataModelAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataModelAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelAssessmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartMetadataModelAssessmentResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataModelConversionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelConversionResponseUnmarshaller.Instance;

            return Invoke<StartMetadataModelConversionResponse>(request, options);
        }


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
        public virtual Task<StartMetadataModelConversionResponse> StartMetadataModelConversionAsync(StartMetadataModelConversionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataModelConversionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelConversionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartMetadataModelConversionResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataModelExportAsScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelExportAsScriptResponseUnmarshaller.Instance;

            return Invoke<StartMetadataModelExportAsScriptResponse>(request, options);
        }


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
        public virtual Task<StartMetadataModelExportAsScriptResponse> StartMetadataModelExportAsScriptAsync(StartMetadataModelExportAsScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataModelExportAsScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelExportAsScriptResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartMetadataModelExportAsScriptResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataModelExportToTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelExportToTargetResponseUnmarshaller.Instance;

            return Invoke<StartMetadataModelExportToTargetResponse>(request, options);
        }


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
        public virtual Task<StartMetadataModelExportToTargetResponse> StartMetadataModelExportToTargetAsync(StartMetadataModelExportToTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataModelExportToTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelExportToTargetResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartMetadataModelExportToTargetResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataModelImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelImportResponseUnmarshaller.Instance;

            return Invoke<StartMetadataModelImportResponse>(request, options);
        }


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
        public virtual Task<StartMetadataModelImportResponse> StartMetadataModelImportAsync(StartMetadataModelImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataModelImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataModelImportResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartMetadataModelImportResponse>(request, options, cancellationToken);
        }

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
        public virtual StartRecommendationsResponse StartRecommendations(StartRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRecommendationsResponseUnmarshaller.Instance;

            return Invoke<StartRecommendationsResponse>(request, options);
        }


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
        public virtual Task<StartRecommendationsResponse> StartRecommendationsAsync(StartRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRecommendationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartRecommendationsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationResponseUnmarshaller.Instance;

            return Invoke<StartReplicationResponse>(request, options);
        }


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
        public virtual Task<StartReplicationResponse> StartReplicationAsync(StartReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartReplicationResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<StartReplicationTaskResponse>(request, options);
        }


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
        public virtual Task<StartReplicationTaskResponse> StartReplicationTaskAsync(StartReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartReplicationTaskResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskAssessmentResponseUnmarshaller.Instance;

            return Invoke<StartReplicationTaskAssessmentResponse>(request, options);
        }


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
        public virtual Task<StartReplicationTaskAssessmentResponse> StartReplicationTaskAssessmentAsync(StartReplicationTaskAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskAssessmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartReplicationTaskAssessmentResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StartReplicationTaskAssessmentRunResponse>(request, options);
        }


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
        public virtual Task<StartReplicationTaskAssessmentRunResponse> StartReplicationTaskAssessmentRunAsync(StartReplicationTaskAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskAssessmentRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartReplicationTaskAssessmentRunResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDataMigrationResponseUnmarshaller.Instance;

            return Invoke<StopDataMigrationResponse>(request, options);
        }


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
        public virtual Task<StopDataMigrationResponse> StopDataMigrationAsync(StopDataMigrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDataMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDataMigrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopDataMigrationResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationResponseUnmarshaller.Instance;

            return Invoke<StopReplicationResponse>(request, options);
        }


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
        public virtual Task<StopReplicationResponse> StopReplicationAsync(StopReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopReplicationResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<StopReplicationTaskResponse>(request, options);
        }


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
        public virtual Task<StopReplicationTaskResponse> StopReplicationTaskAsync(StopReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopReplicationTaskResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestConnectionResponseUnmarshaller.Instance;

            return Invoke<TestConnectionResponse>(request, options);
        }


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
        public virtual Task<TestConnectionResponse> TestConnectionAsync(TestConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<TestConnectionResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionsToEventBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionsToEventBridgeResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionsToEventBridgeResponse>(request, options);
        }


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
        public virtual Task<UpdateSubscriptionsToEventBridgeResponse> UpdateSubscriptionsToEventBridgeAsync(UpdateSubscriptionsToEventBridgeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionsToEventBridgeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionsToEventBridgeResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSubscriptionsToEventBridgeResponse>(request, options, cancellationToken);
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