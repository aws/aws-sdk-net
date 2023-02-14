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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.EMRContainers.Model;

namespace Amazon.EMRContainers
{
    /// <summary>
    /// Interface for accessing EMRContainers
    ///
    /// Amazon EMR on EKS provides a deployment option for Amazon EMR that allows you to run
    /// open-source big data frameworks on Amazon Elastic Kubernetes Service (Amazon EKS).
    /// With this deployment option, you can focus on running analytics workloads while Amazon
    /// EMR on EKS builds, configures, and manages containers for open-source applications.
    /// For more information about Amazon EMR on EKS concepts and tasks, see <a href="https://docs.aws.amazon.com/emr/latest/EMR-on-EKS-DevelopmentGuide/emr-eks.html">What
    /// is shared id="EMR-EKS"/&gt;</a>.
    /// 
    ///  
    /// <para>
    ///  <i>Amazon EMR containers</i> is the API name for Amazon EMR on EKS. The <code>emr-containers</code>
    /// prefix is used in the following scenarios: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// It is the prefix in the CLI commands for Amazon EMR on EKS. For example, <code>aws
    /// emr-containers start-job-run</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It is the prefix before IAM policy actions for Amazon EMR on EKS. For example, <code>"Action":
    /// [ "emr-containers:StartJobRun"]</code>. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/EMR-on-EKS-DevelopmentGuide/security_iam_service-with-iam.html#security_iam_service-with-iam-id-based-policies-actions">Policy
    /// actions for Amazon EMR on EKS</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It is the prefix used in Amazon EMR on EKS service endpoints. For example, <code>emr-containers.us-east-2.amazonaws.com</code>.
    /// For more information, see <a href="https://docs.aws.amazon.com/emr/latest/EMR-on-EKS-DevelopmentGuide/service-quotas.html#service-endpoints">Amazon
    /// EMR on EKSService Endpoints</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonEMRContainers : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IEMRContainersPaginatorFactory Paginators { get; }
#endif


        
        #region  CancelJobRun


        /// <summary>
        /// Cancels a job run. A job run is a unit of work, such as a Spark jar, PySpark script,
        /// or SparkSQL query, that you submit to Amazon EMR on EKS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJobRun service method.</param>
        /// 
        /// <returns>The response from the CancelJobRun service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CancelJobRun">REST API Reference for CancelJobRun Operation</seealso>
        CancelJobRunResponse CancelJobRun(CancelJobRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJobRun operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJobRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CancelJobRun">REST API Reference for CancelJobRun Operation</seealso>
        IAsyncResult BeginCancelJobRun(CancelJobRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelJobRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJobRun.</param>
        /// 
        /// <returns>Returns a  CancelJobRunResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CancelJobRun">REST API Reference for CancelJobRun Operation</seealso>
        CancelJobRunResponse EndCancelJobRun(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateJobTemplate


        /// <summary>
        /// Creates a job template. Job template stores values of StartJobRun API request in a
        /// template and can be used to start a job run. Job template allows two use cases: avoid
        /// repeating recurring StartJobRun API request values, enforcing certain values in StartJobRun
        /// API request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateJobTemplate service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CreateJobTemplate">REST API Reference for CreateJobTemplate Operation</seealso>
        CreateJobTemplateResponse CreateJobTemplate(CreateJobTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJobTemplate operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJobTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CreateJobTemplate">REST API Reference for CreateJobTemplate Operation</seealso>
        IAsyncResult BeginCreateJobTemplate(CreateJobTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJobTemplate.</param>
        /// 
        /// <returns>Returns a  CreateJobTemplateResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CreateJobTemplate">REST API Reference for CreateJobTemplate Operation</seealso>
        CreateJobTemplateResponse EndCreateJobTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateManagedEndpoint


        /// <summary>
        /// Creates a managed endpoint. A managed endpoint is a gateway that connects Amazon EMR
        /// Studio to Amazon EMR on EKS so that Amazon EMR Studio can communicate with your virtual
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateManagedEndpoint service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CreateManagedEndpoint">REST API Reference for CreateManagedEndpoint Operation</seealso>
        CreateManagedEndpointResponse CreateManagedEndpoint(CreateManagedEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateManagedEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedEndpoint operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateManagedEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CreateManagedEndpoint">REST API Reference for CreateManagedEndpoint Operation</seealso>
        IAsyncResult BeginCreateManagedEndpoint(CreateManagedEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateManagedEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateManagedEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateManagedEndpointResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CreateManagedEndpoint">REST API Reference for CreateManagedEndpoint Operation</seealso>
        CreateManagedEndpointResponse EndCreateManagedEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVirtualCluster


        /// <summary>
        /// Creates a virtual cluster. Virtual cluster is a managed entity on Amazon EMR on EKS.
        /// You can create, describe, list and delete virtual clusters. They do not consume any
        /// additional resource in your system. A single virtual cluster maps to a single Kubernetes
        /// namespace. Given this relationship, you can model virtual clusters the same way you
        /// model Kubernetes namespaces to meet your requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualCluster service method.</param>
        /// 
        /// <returns>The response from the CreateVirtualCluster service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CreateVirtualCluster">REST API Reference for CreateVirtualCluster Operation</seealso>
        CreateVirtualClusterResponse CreateVirtualCluster(CreateVirtualClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualCluster operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVirtualCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CreateVirtualCluster">REST API Reference for CreateVirtualCluster Operation</seealso>
        IAsyncResult BeginCreateVirtualCluster(CreateVirtualClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVirtualCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVirtualCluster.</param>
        /// 
        /// <returns>Returns a  CreateVirtualClusterResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CreateVirtualCluster">REST API Reference for CreateVirtualCluster Operation</seealso>
        CreateVirtualClusterResponse EndCreateVirtualCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteJobTemplate


        /// <summary>
        /// Deletes a job template. Job template stores values of StartJobRun API request in a
        /// template and can be used to start a job run. Job template allows two use cases: avoid
        /// repeating recurring StartJobRun API request values, enforcing certain values in StartJobRun
        /// API request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteJobTemplate service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteJobTemplate">REST API Reference for DeleteJobTemplate Operation</seealso>
        DeleteJobTemplateResponse DeleteJobTemplate(DeleteJobTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTemplate operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJobTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteJobTemplate">REST API Reference for DeleteJobTemplate Operation</seealso>
        IAsyncResult BeginDeleteJobTemplate(DeleteJobTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJobTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteJobTemplateResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteJobTemplate">REST API Reference for DeleteJobTemplate Operation</seealso>
        DeleteJobTemplateResponse EndDeleteJobTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteManagedEndpoint


        /// <summary>
        /// Deletes a managed endpoint. A managed endpoint is a gateway that connects Amazon EMR
        /// Studio to Amazon EMR on EKS so that Amazon EMR Studio can communicate with your virtual
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteManagedEndpoint service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteManagedEndpoint">REST API Reference for DeleteManagedEndpoint Operation</seealso>
        DeleteManagedEndpointResponse DeleteManagedEndpoint(DeleteManagedEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteManagedEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedEndpoint operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteManagedEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteManagedEndpoint">REST API Reference for DeleteManagedEndpoint Operation</seealso>
        IAsyncResult BeginDeleteManagedEndpoint(DeleteManagedEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteManagedEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteManagedEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteManagedEndpointResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteManagedEndpoint">REST API Reference for DeleteManagedEndpoint Operation</seealso>
        DeleteManagedEndpointResponse EndDeleteManagedEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVirtualCluster


        /// <summary>
        /// Deletes a virtual cluster. Virtual cluster is a managed entity on Amazon EMR on EKS.
        /// You can create, describe, list and delete virtual clusters. They do not consume any
        /// additional resource in your system. A single virtual cluster maps to a single Kubernetes
        /// namespace. Given this relationship, you can model virtual clusters the same way you
        /// model Kubernetes namespaces to meet your requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualCluster service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteVirtualCluster">REST API Reference for DeleteVirtualCluster Operation</seealso>
        DeleteVirtualClusterResponse DeleteVirtualCluster(DeleteVirtualClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualCluster operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVirtualCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteVirtualCluster">REST API Reference for DeleteVirtualCluster Operation</seealso>
        IAsyncResult BeginDeleteVirtualCluster(DeleteVirtualClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVirtualCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualCluster.</param>
        /// 
        /// <returns>Returns a  DeleteVirtualClusterResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteVirtualCluster">REST API Reference for DeleteVirtualCluster Operation</seealso>
        DeleteVirtualClusterResponse EndDeleteVirtualCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeJobRun


        /// <summary>
        /// Displays detailed information about a job run. A job run is a unit of work, such as
        /// a Spark jar, PySpark script, or SparkSQL query, that you submit to Amazon EMR on EKS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobRun service method.</param>
        /// 
        /// <returns>The response from the DescribeJobRun service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeJobRun">REST API Reference for DescribeJobRun Operation</seealso>
        DescribeJobRunResponse DescribeJobRun(DescribeJobRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobRun operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeJobRun">REST API Reference for DescribeJobRun Operation</seealso>
        IAsyncResult BeginDescribeJobRun(DescribeJobRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobRun.</param>
        /// 
        /// <returns>Returns a  DescribeJobRunResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeJobRun">REST API Reference for DescribeJobRun Operation</seealso>
        DescribeJobRunResponse EndDescribeJobRun(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeJobTemplate


        /// <summary>
        /// Displays detailed information about a specified job template. Job template stores
        /// values of StartJobRun API request in a template and can be used to start a job run.
        /// Job template allows two use cases: avoid repeating recurring StartJobRun API request
        /// values, enforcing certain values in StartJobRun API request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobTemplate service method.</param>
        /// 
        /// <returns>The response from the DescribeJobTemplate service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeJobTemplate">REST API Reference for DescribeJobTemplate Operation</seealso>
        DescribeJobTemplateResponse DescribeJobTemplate(DescribeJobTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobTemplate operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeJobTemplate">REST API Reference for DescribeJobTemplate Operation</seealso>
        IAsyncResult BeginDescribeJobTemplate(DescribeJobTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobTemplate.</param>
        /// 
        /// <returns>Returns a  DescribeJobTemplateResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeJobTemplate">REST API Reference for DescribeJobTemplate Operation</seealso>
        DescribeJobTemplateResponse EndDescribeJobTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeManagedEndpoint


        /// <summary>
        /// Displays detailed information about a managed endpoint. A managed endpoint is a gateway
        /// that connects Amazon EMR Studio to Amazon EMR on EKS so that Amazon EMR Studio can
        /// communicate with your virtual cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedEndpoint service method.</param>
        /// 
        /// <returns>The response from the DescribeManagedEndpoint service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeManagedEndpoint">REST API Reference for DescribeManagedEndpoint Operation</seealso>
        DescribeManagedEndpointResponse DescribeManagedEndpoint(DescribeManagedEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeManagedEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedEndpoint operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeManagedEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeManagedEndpoint">REST API Reference for DescribeManagedEndpoint Operation</seealso>
        IAsyncResult BeginDescribeManagedEndpoint(DescribeManagedEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeManagedEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeManagedEndpoint.</param>
        /// 
        /// <returns>Returns a  DescribeManagedEndpointResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeManagedEndpoint">REST API Reference for DescribeManagedEndpoint Operation</seealso>
        DescribeManagedEndpointResponse EndDescribeManagedEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVirtualCluster


        /// <summary>
        /// Displays detailed information about a specified virtual cluster. Virtual cluster is
        /// a managed entity on Amazon EMR on EKS. You can create, describe, list and delete virtual
        /// clusters. They do not consume any additional resource in your system. A single virtual
        /// cluster maps to a single Kubernetes namespace. Given this relationship, you can model
        /// virtual clusters the same way you model Kubernetes namespaces to meet your requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualCluster service method.</param>
        /// 
        /// <returns>The response from the DescribeVirtualCluster service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeVirtualCluster">REST API Reference for DescribeVirtualCluster Operation</seealso>
        DescribeVirtualClusterResponse DescribeVirtualCluster(DescribeVirtualClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualCluster operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVirtualCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeVirtualCluster">REST API Reference for DescribeVirtualCluster Operation</seealso>
        IAsyncResult BeginDescribeVirtualCluster(DescribeVirtualClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVirtualCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualCluster.</param>
        /// 
        /// <returns>Returns a  DescribeVirtualClusterResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DescribeVirtualCluster">REST API Reference for DescribeVirtualCluster Operation</seealso>
        DescribeVirtualClusterResponse EndDescribeVirtualCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobRuns


        /// <summary>
        /// Lists job runs based on a set of parameters. A job run is a unit of work, such as
        /// a Spark jar, PySpark script, or SparkSQL query, that you submit to Amazon EMR on EKS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobRuns service method.</param>
        /// 
        /// <returns>The response from the ListJobRuns service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        ListJobRunsResponse ListJobRuns(ListJobRunsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobRuns operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        IAsyncResult BeginListJobRuns(ListJobRunsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobRuns.</param>
        /// 
        /// <returns>Returns a  ListJobRunsResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        ListJobRunsResponse EndListJobRuns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobTemplates


        /// <summary>
        /// Lists job templates based on a set of parameters. Job template stores values of StartJobRun
        /// API request in a template and can be used to start a job run. Job template allows
        /// two use cases: avoid repeating recurring StartJobRun API request values, enforcing
        /// certain values in StartJobRun API request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobTemplates service method.</param>
        /// 
        /// <returns>The response from the ListJobTemplates service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListJobTemplates">REST API Reference for ListJobTemplates Operation</seealso>
        ListJobTemplatesResponse ListJobTemplates(ListJobTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobTemplates operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListJobTemplates">REST API Reference for ListJobTemplates Operation</seealso>
        IAsyncResult BeginListJobTemplates(ListJobTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobTemplates.</param>
        /// 
        /// <returns>Returns a  ListJobTemplatesResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListJobTemplates">REST API Reference for ListJobTemplates Operation</seealso>
        ListJobTemplatesResponse EndListJobTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListManagedEndpoints


        /// <summary>
        /// Lists managed endpoints based on a set of parameters. A managed endpoint is a gateway
        /// that connects Amazon EMR Studio to Amazon EMR on EKS so that Amazon EMR Studio can
        /// communicate with your virtual cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListManagedEndpoints service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListManagedEndpoints">REST API Reference for ListManagedEndpoints Operation</seealso>
        ListManagedEndpointsResponse ListManagedEndpoints(ListManagedEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedEndpoints operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListManagedEndpoints">REST API Reference for ListManagedEndpoints Operation</seealso>
        IAsyncResult BeginListManagedEndpoints(ListManagedEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedEndpoints.</param>
        /// 
        /// <returns>Returns a  ListManagedEndpointsResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListManagedEndpoints">REST API Reference for ListManagedEndpoints Operation</seealso>
        ListManagedEndpointsResponse EndListManagedEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags assigned to the resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVirtualClusters


        /// <summary>
        /// Lists information about the specified virtual cluster. Virtual cluster is a managed
        /// entity on Amazon EMR on EKS. You can create, describe, list and delete virtual clusters.
        /// They do not consume any additional resource in your system. A single virtual cluster
        /// maps to a single Kubernetes namespace. Given this relationship, you can model virtual
        /// clusters the same way you model Kubernetes namespaces to meet your requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualClusters service method.</param>
        /// 
        /// <returns>The response from the ListVirtualClusters service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListVirtualClusters">REST API Reference for ListVirtualClusters Operation</seealso>
        ListVirtualClustersResponse ListVirtualClusters(ListVirtualClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualClusters operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVirtualClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListVirtualClusters">REST API Reference for ListVirtualClusters Operation</seealso>
        IAsyncResult BeginListVirtualClusters(ListVirtualClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVirtualClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualClusters.</param>
        /// 
        /// <returns>Returns a  ListVirtualClustersResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListVirtualClusters">REST API Reference for ListVirtualClusters Operation</seealso>
        ListVirtualClustersResponse EndListVirtualClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  StartJobRun


        /// <summary>
        /// Starts a job run. A job run is a unit of work, such as a Spark jar, PySpark script,
        /// or SparkSQL query, that you submit to Amazon EMR on EKS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun service method.</param>
        /// 
        /// <returns>The response from the StartJobRun service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        StartJobRunResponse StartJobRun(StartJobRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartJobRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        IAsyncResult BeginStartJobRun(StartJobRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartJobRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartJobRun.</param>
        /// 
        /// <returns>Returns a  StartJobRunResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        StartJobRunResponse EndStartJobRun(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns tags to resources. A tag is a label that you assign to an Amazon Web Services
        /// resource. Each tag consists of a key and an optional value, both of which you define.
        /// Tags enable you to categorize your Amazon Web Services resources by attributes such
        /// as purpose, owner, or environment. When you have many resources of the same type,
        /// you can quickly identify a specific resource based on the tags you've assigned to
        /// it. For example, you can define a set of tags for your Amazon EMR on EKS clusters
        /// to help you track each cluster's owner and stack level. We recommend that you devise
        /// a consistent set of tag keys for each resource type. You can then search and filter
        /// the resources based on the tags that you add.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonEMRContainersClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from EMRContainers.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
    }
}