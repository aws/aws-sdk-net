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
 * Do not modify this file. This file is generated from the mwaa-serverless-2024-07-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MWAAServerless.Model;

#pragma warning disable CS1570
namespace Amazon.MWAAServerless
{
    /// <summary>
    /// <para>Interface for accessing MWAAServerless</para>
    ///
    /// Amazon Managed Workflows for Apache Airflow Serverless provides a managed workflow
    /// orchestration platform for running Apache Airflow workflows in a serverless environment.
    /// You can use Amazon Managed Workflows for Apache Airflow Serverless to create, manage,
    /// and run data processing workflows without managing the underlying infrastructure,
    /// Airflow clusters, metadata databases, or scheduling overhead. The service provides
    /// secure multi-tenant run environments with automatic scaling, comprehensive logging,
    /// and integration with multiple Amazon Web Services services for orchestrating complex
    /// analytics workloads.
    /// </summary>
    public partial interface IAmazonMWAAServerless : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMWAAServerlessPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateWorkflow



        /// <summary>
        /// Creates a new workflow in Amazon Managed Workflows for Apache Airflow Serverless.
        /// This operation initializes a workflow with the specified configuration including the
        /// workflow definition, execution role, and optional settings for encryption, logging,
        /// and networking. You must provide the workflow definition as a YAML file stored in
        /// Amazon S3 that defines the DAG structure using supported Amazon Web Services operators.
        /// Amazon Managed Workflows for Apache Airflow Serverless automatically creates the first
        /// version of the workflow and sets up the necessary execution environment with multi-tenant
        /// isolation and security controls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkflow service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ConflictException">
        /// You cannot create a resource that already exists, or the resource is in a state that
        /// prevents the requested operation.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota for Amazon Managed Workflows for Apache Airflow
        /// Serverless resources. This can occur when you attempt to create more workflows than
        /// allowed, exceed concurrent workflow run limits, or surpass task execution limits.
        /// Amazon Managed Workflows for Apache Airflow Serverless implements admission control
        /// using DynamoDB-based counters to manage resource utilization across the multi-tenant
        /// environment. Contact Amazon Web Services Support to request quota increases if you
        /// need higher limits for your use case.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        Task<CreateWorkflowResponse> CreateWorkflowAsync(CreateWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkflow



        /// <summary>
        /// Deletes a workflow and all its versions. This operation permanently removes the workflow
        /// and cannot be undone. Amazon Managed Workflows for Apache Airflow Serverless ensures
        /// that all associated resources are properly cleaned up, including stopping any running
        /// executions, removing scheduled triggers, and cleaning up execution history. The deletion
        /// process respects the multi-tenant isolation boundaries and ensures that no residual
        /// data or configurations remain that could affect other customers or workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkflow service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ResourceNotFoundException">
        /// The specified resource was not found. You can only access or modify a resource that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTaskInstance



        /// <summary>
        /// Retrieves detailed information about a specific task instance within a workflow run.
        /// Task instances represent individual tasks that are executed as part of a workflow
        /// in the Amazon Managed Workflows for Apache Airflow Serverless environment. Each task
        /// instance runs in an isolated ECS container with dedicated resources and security boundaries.
        /// The service tracks task execution state, retry attempts, and provides detailed timing
        /// and error information for troubleshooting and monitoring purposes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTaskInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTaskInstance service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ResourceNotFoundException">
        /// The specified resource was not found. You can only access or modify a resource that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/GetTaskInstance">REST API Reference for GetTaskInstance Operation</seealso>
        Task<GetTaskInstanceResponse> GetTaskInstanceAsync(GetTaskInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetWorkflow



        /// <summary>
        /// Retrieves detailed information about a workflow, including its configuration, status,
        /// and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflow service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ResourceNotFoundException">
        /// The specified resource was not found. You can only access or modify a resource that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        Task<GetWorkflowResponse> GetWorkflowAsync(GetWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetWorkflowRun



        /// <summary>
        /// Retrieves detailed information about a specific workflow run, including its status,
        /// execution details, and task instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowRun service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ResourceNotFoundException">
        /// The specified resource was not found. You can only access or modify a resource that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        Task<GetWorkflowRunResponse> GetWorkflowRunAsync(GetWorkflowRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all tags that are associated with a specified Amazon Managed Workflows for Apache
        /// Airflow Serverless resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ResourceNotFoundException">
        /// The specified resource was not found. You can only access or modify a resource that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTaskInstances



        /// <summary>
        /// Lists all task instances for a specific workflow run, with optional pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTaskInstances service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListTaskInstances">REST API Reference for ListTaskInstances Operation</seealso>
        Task<ListTaskInstancesResponse> ListTaskInstancesAsync(ListTaskInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkflowRuns



        /// <summary>
        /// Lists all runs for a specified workflow, with optional pagination and filtering support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflowRuns service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListWorkflowRuns">REST API Reference for ListWorkflowRuns Operation</seealso>
        Task<ListWorkflowRunsResponse> ListWorkflowRunsAsync(ListWorkflowRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkflows



        /// <summary>
        /// Lists all workflows in your account, with optional pagination support. This operation
        /// returns summary information for workflows, showing only the most recently created
        /// version of each workflow. Amazon Managed Workflows for Apache Airflow Serverless maintains
        /// workflow metadata in a highly available, distributed storage system that enables efficient
        /// querying and filtering. The service implements proper access controls to ensure you
        /// can only view workflows that you have permissions to access, supporting both individual
        /// and team-based workflow management scenarios.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        Task<ListWorkflowsResponse> ListWorkflowsAsync(ListWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkflowVersions



        /// <summary>
        /// Lists all versions of a specified workflow, with optional pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflowVersions service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListWorkflowVersions">REST API Reference for ListWorkflowVersions Operation</seealso>
        Task<ListWorkflowVersionsResponse> ListWorkflowVersionsAsync(ListWorkflowVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartWorkflowRun



        /// <summary>
        /// Starts a new execution of a workflow. This operation creates a workflow run that executes
        /// the tasks that are defined in the workflow. Amazon Managed Workflows for Apache Airflow
        /// Serverless schedules the workflow execution across its managed Airflow environment,
        /// automatically scaling ECS worker tasks based on the workload. The service handles
        /// task isolation, dependency resolution, and provides comprehensive monitoring and logging
        /// throughout the execution lifecycle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartWorkflowRun service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ConflictException">
        /// You cannot create a resource that already exists, or the resource is in a state that
        /// prevents the requested operation.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ResourceNotFoundException">
        /// The specified resource was not found. You can only access or modify a resource that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota for Amazon Managed Workflows for Apache Airflow
        /// Serverless resources. This can occur when you attempt to create more workflows than
        /// allowed, exceed concurrent workflow run limits, or surpass task execution limits.
        /// Amazon Managed Workflows for Apache Airflow Serverless implements admission control
        /// using DynamoDB-based counters to manage resource utilization across the multi-tenant
        /// environment. Contact Amazon Web Services Support to request quota increases if you
        /// need higher limits for your use case.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/StartWorkflowRun">REST API Reference for StartWorkflowRun Operation</seealso>
        Task<StartWorkflowRunResponse> StartWorkflowRunAsync(StartWorkflowRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopWorkflowRun



        /// <summary>
        /// Stops a running workflow execution. This operation terminates all running tasks and
        /// prevents new tasks from starting. Amazon Managed Workflows for Apache Airflow Serverless
        /// gracefully shuts down the workflow execution by stopping task scheduling and terminating
        /// active ECS worker containers. The operation transitions the workflow run to a <c>STOPPING</c>
        /// state and then to <c>STOPPED</c> once all cleanup is complete. In-flight tasks may
        /// complete or be terminated depending on their current execution state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopWorkflowRun service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ResourceNotFoundException">
        /// The specified resource was not found. You can only access or modify a resource that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/StopWorkflowRun">REST API Reference for StopWorkflowRun Operation</seealso>
        Task<StopWorkflowRunResponse> StopWorkflowRunAsync(StopWorkflowRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds tags to an Amazon Managed Workflows for Apache Airflow Serverless resource. Tags
        /// are key-value pairs that help you organize and categorize your resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ResourceNotFoundException">
        /// The specified resource was not found. You can only access or modify a resource that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from an Amazon Managed Workflows for Apache Airflow Serverless resource.
        /// This operation removes the specified tags from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ResourceNotFoundException">
        /// The specified resource was not found. You can only access or modify a resource that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWorkflow



        /// <summary>
        /// Updates an existing workflow with new configuration settings. This operation allows
        /// you to modify the workflow definition, role, and other settings. When you update a
        /// workflow, Amazon Managed Workflows for Apache Airflow Serverless automatically creates
        /// a new version with the updated configuration and disables scheduling on all previous
        /// versions to ensure only one version is actively scheduled at a time. The update operation
        /// maintains workflow history while providing a clean transition to the new configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkflow service method, as returned by MWAAServerless.</returns>
        /// <exception cref="Amazon.MWAAServerless.Model.AccessDeniedException">
        /// You do not have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ConflictException">
        /// You cannot create a resource that already exists, or the resource is in a state that
        /// prevents the requested operation.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.InternalServerException">
        /// An unexpected server-side error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ResourceNotFoundException">
        /// The specified resource was not found. You can only access or modify a resource that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota for Amazon Managed Workflows for Apache Airflow
        /// Serverless resources. This can occur when you attempt to create more workflows than
        /// allowed, exceed concurrent workflow run limits, or surpass task execution limits.
        /// Amazon Managed Workflows for Apache Airflow Serverless implements admission control
        /// using DynamoDB-based counters to manage resource utilization across the multi-tenant
        /// environment. Contact Amazon Web Services Support to request quota increases if you
        /// need higher limits for your use case.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ThrottlingException">
        /// The request was denied because too many requests were made in a short period, exceeding
        /// the service rate limits. Amazon Managed Workflows for Apache Airflow Serverless implements
        /// throttling controls to ensure fair resource allocation across all customers in the
        /// multi-tenant environment. This helps maintain service stability and performance. If
        /// you encounter throttling, implement exponential backoff and retry logic in your applications,
        /// or consider distributing your API calls over a longer time period.
        /// </exception>
        /// <exception cref="Amazon.MWAAServerless.Model.ValidationException">
        /// The specified request parameters are invalid, missing, or inconsistent with Amazon
        /// Managed Workflows for Apache Airflow Serverless service requirements. This can occur
        /// when workflow definitions contain unsupported operators, when required IAM permissions
        /// are missing, when S3 locations are inaccessible, or when network configurations are
        /// invalid. The service validates workflow definitions, execution roles, and resource
        /// configurations to ensure compatibility with the managed Airflow environment and security
        /// requirements.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        Task<UpdateWorkflowResponse> UpdateWorkflowAsync(UpdateWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonMWAAServerlessConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonMWAAServerlessConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonMWAAServerlessConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonMWAAServerlessConfig to create AmazonMWAAServerlessClient");
            }

            return awsCredentials == null ? 
                    new AmazonMWAAServerlessClient(serviceClientConfig) :
                    new AmazonMWAAServerlessClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}