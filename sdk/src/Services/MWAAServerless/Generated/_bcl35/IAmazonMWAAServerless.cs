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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        IAsyncResult BeginCreateWorkflow(CreateWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkflow.</param>
        /// 
        /// <returns>Returns a  CreateWorkflowResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        CreateWorkflowResponse EndCreateWorkflow(IAsyncResult asyncResult);

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
        DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        IAsyncResult BeginDeleteWorkflow(DeleteWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkflow.</param>
        /// 
        /// <returns>Returns a  DeleteWorkflowResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        DeleteWorkflowResponse EndDeleteWorkflow(IAsyncResult asyncResult);

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
        GetTaskInstanceResponse GetTaskInstance(GetTaskInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTaskInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTaskInstance operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTaskInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/GetTaskInstance">REST API Reference for GetTaskInstance Operation</seealso>
        IAsyncResult BeginGetTaskInstance(GetTaskInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTaskInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTaskInstance.</param>
        /// 
        /// <returns>Returns a  GetTaskInstanceResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/GetTaskInstance">REST API Reference for GetTaskInstance Operation</seealso>
        GetTaskInstanceResponse EndGetTaskInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkflow


        /// <summary>
        /// Retrieves detailed information about a workflow, including its configuration, status,
        /// and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
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
        GetWorkflowResponse GetWorkflow(GetWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        IAsyncResult BeginGetWorkflow(GetWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflow.</param>
        /// 
        /// <returns>Returns a  GetWorkflowResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        GetWorkflowResponse EndGetWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkflowRun


        /// <summary>
        /// Retrieves detailed information about a specific workflow run, including its status,
        /// execution details, and task instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun service method.</param>
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
        GetWorkflowRunResponse GetWorkflowRun(GetWorkflowRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        IAsyncResult BeginGetWorkflowRun(GetWorkflowRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowRun.</param>
        /// 
        /// <returns>Returns a  GetWorkflowRunResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        GetWorkflowRunResponse EndGetWorkflowRun(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags that are associated with a specified Amazon Managed Workflows for Apache
        /// Airflow Serverless resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTaskInstances


        /// <summary>
        /// Lists all task instances for a specific workflow run, with optional pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskInstances service method.</param>
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
        ListTaskInstancesResponse ListTaskInstances(ListTaskInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTaskInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTaskInstances operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTaskInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListTaskInstances">REST API Reference for ListTaskInstances Operation</seealso>
        IAsyncResult BeginListTaskInstances(ListTaskInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTaskInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTaskInstances.</param>
        /// 
        /// <returns>Returns a  ListTaskInstancesResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListTaskInstances">REST API Reference for ListTaskInstances Operation</seealso>
        ListTaskInstancesResponse EndListTaskInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkflowRuns


        /// <summary>
        /// Lists all runs for a specified workflow, with optional pagination and filtering support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowRuns service method.</param>
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
        ListWorkflowRunsResponse ListWorkflowRuns(ListWorkflowRunsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflowRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowRuns operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflowRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListWorkflowRuns">REST API Reference for ListWorkflowRuns Operation</seealso>
        IAsyncResult BeginListWorkflowRuns(ListWorkflowRunsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflowRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflowRuns.</param>
        /// 
        /// <returns>Returns a  ListWorkflowRunsResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListWorkflowRuns">REST API Reference for ListWorkflowRuns Operation</seealso>
        ListWorkflowRunsResponse EndListWorkflowRuns(IAsyncResult asyncResult);

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
        ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        IAsyncResult BeginListWorkflows(ListWorkflowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflows.</param>
        /// 
        /// <returns>Returns a  ListWorkflowsResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        ListWorkflowsResponse EndListWorkflows(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkflowVersions


        /// <summary>
        /// Lists all versions of a specified workflow, with optional pagination support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowVersions service method.</param>
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
        ListWorkflowVersionsResponse ListWorkflowVersions(ListWorkflowVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflowVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowVersions operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflowVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListWorkflowVersions">REST API Reference for ListWorkflowVersions Operation</seealso>
        IAsyncResult BeginListWorkflowVersions(ListWorkflowVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflowVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflowVersions.</param>
        /// 
        /// <returns>Returns a  ListWorkflowVersionsResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/ListWorkflowVersions">REST API Reference for ListWorkflowVersions Operation</seealso>
        ListWorkflowVersionsResponse EndListWorkflowVersions(IAsyncResult asyncResult);

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
        StartWorkflowRunResponse StartWorkflowRun(StartWorkflowRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowRun operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/StartWorkflowRun">REST API Reference for StartWorkflowRun Operation</seealso>
        IAsyncResult BeginStartWorkflowRun(StartWorkflowRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWorkflowRun.</param>
        /// 
        /// <returns>Returns a  StartWorkflowRunResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/StartWorkflowRun">REST API Reference for StartWorkflowRun Operation</seealso>
        StartWorkflowRunResponse EndStartWorkflowRun(IAsyncResult asyncResult);

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
        StopWorkflowRunResponse StopWorkflowRun(StopWorkflowRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopWorkflowRun operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/StopWorkflowRun">REST API Reference for StopWorkflowRun Operation</seealso>
        IAsyncResult BeginStopWorkflowRun(StopWorkflowRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopWorkflowRun.</param>
        /// 
        /// <returns>Returns a  StopWorkflowRunResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/StopWorkflowRun">REST API Reference for StopWorkflowRun Operation</seealso>
        StopWorkflowRunResponse EndStopWorkflowRun(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to an Amazon Managed Workflows for Apache Airflow Serverless resource. Tags
        /// are key-value pairs that help you organize and categorize your resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from an Amazon Managed Workflows for Apache Airflow Serverless resource.
        /// This operation removes the specified tags from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        UpdateWorkflowResponse UpdateWorkflow(UpdateWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow operation on AmazonMWAAServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        IAsyncResult BeginUpdateWorkflow(UpdateWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkflow.</param>
        /// 
        /// <returns>Returns a  UpdateWorkflowResult from MWAAServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mwaa-serverless-2024-07-26/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        UpdateWorkflowResponse EndUpdateWorkflow(IAsyncResult asyncResult);

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