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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IEMRContainersPaginatorFactory Paginators { get; }

        
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
        /// Cancels a job run. A job run is a unit of work, such as a Spark jar, PySpark script,
        /// or SparkSQL query, that you submit to Amazon EMR on EKS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJobRun service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/CancelJobRun">REST API Reference for CancelJobRun Operation</seealso>
        Task<CancelJobRunResponse> CancelJobRunAsync(CancelJobRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a job template. Job template stores values of StartJobRun API request in a
        /// template and can be used to start a job run. Job template allows two use cases: avoid
        /// repeating recurring StartJobRun API request values, enforcing certain values in StartJobRun
        /// API request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateJobTemplateResponse> CreateJobTemplateAsync(CreateJobTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a managed endpoint. A managed endpoint is a gateway that connects Amazon EMR
        /// Studio to Amazon EMR on EKS so that Amazon EMR Studio can communicate with your virtual
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateManagedEndpointResponse> CreateManagedEndpointAsync(CreateManagedEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a virtual cluster. Virtual cluster is a managed entity on Amazon EMR on EKS.
        /// You can create, describe, list and delete virtual clusters. They do not consume any
        /// additional resource in your system. A single virtual cluster maps to a single Kubernetes
        /// namespace. Given this relationship, you can model virtual clusters the same way you
        /// model Kubernetes namespaces to meet your requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateVirtualClusterResponse> CreateVirtualClusterAsync(CreateVirtualClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a job template. Job template stores values of StartJobRun API request in a
        /// template and can be used to start a job run. Job template allows two use cases: avoid
        /// repeating recurring StartJobRun API request values, enforcing certain values in StartJobRun
        /// API request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteJobTemplate service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteJobTemplate">REST API Reference for DeleteJobTemplate Operation</seealso>
        Task<DeleteJobTemplateResponse> DeleteJobTemplateAsync(DeleteJobTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a managed endpoint. A managed endpoint is a gateway that connects Amazon EMR
        /// Studio to Amazon EMR on EKS so that Amazon EMR Studio can communicate with your virtual
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteManagedEndpoint service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteManagedEndpoint">REST API Reference for DeleteManagedEndpoint Operation</seealso>
        Task<DeleteManagedEndpointResponse> DeleteManagedEndpointAsync(DeleteManagedEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a virtual cluster. Virtual cluster is a managed entity on Amazon EMR on EKS.
        /// You can create, describe, list and delete virtual clusters. They do not consume any
        /// additional resource in your system. A single virtual cluster maps to a single Kubernetes
        /// namespace. Given this relationship, you can model virtual clusters the same way you
        /// model Kubernetes namespaces to meet your requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVirtualCluster service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/DeleteVirtualCluster">REST API Reference for DeleteVirtualCluster Operation</seealso>
        Task<DeleteVirtualClusterResponse> DeleteVirtualClusterAsync(DeleteVirtualClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Displays detailed information about a job run. A job run is a unit of work, such as
        /// a Spark jar, PySpark script, or SparkSQL query, that you submit to Amazon EMR on EKS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeJobRunResponse> DescribeJobRunAsync(DescribeJobRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Displays detailed information about a specified job template. Job template stores
        /// values of StartJobRun API request in a template and can be used to start a job run.
        /// Job template allows two use cases: avoid repeating recurring StartJobRun API request
        /// values, enforcing certain values in StartJobRun API request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeJobTemplateResponse> DescribeJobTemplateAsync(DescribeJobTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Displays detailed information about a managed endpoint. A managed endpoint is a gateway
        /// that connects Amazon EMR Studio to Amazon EMR on EKS so that Amazon EMR Studio can
        /// communicate with your virtual cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeManagedEndpointResponse> DescribeManagedEndpointAsync(DescribeManagedEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Displays detailed information about a specified virtual cluster. Virtual cluster is
        /// a managed entity on Amazon EMR on EKS. You can create, describe, list and delete virtual
        /// clusters. They do not consume any additional resource in your system. A single virtual
        /// cluster maps to a single Kubernetes namespace. Given this relationship, you can model
        /// virtual clusters the same way you model Kubernetes namespaces to meet your requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeVirtualClusterResponse> DescribeVirtualClusterAsync(DescribeVirtualClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists job runs based on a set of parameters. A job run is a unit of work, such as
        /// a Spark jar, PySpark script, or SparkSQL query, that you submit to Amazon EMR on EKS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobRuns service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        Task<ListJobRunsResponse> ListJobRunsAsync(ListJobRunsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists job templates based on a set of parameters. Job template stores values of StartJobRun
        /// API request in a template and can be used to start a job run. Job template allows
        /// two use cases: avoid repeating recurring StartJobRun API request values, enforcing
        /// certain values in StartJobRun API request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobTemplates service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListJobTemplates">REST API Reference for ListJobTemplates Operation</seealso>
        Task<ListJobTemplatesResponse> ListJobTemplatesAsync(ListJobTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists managed endpoints based on a set of parameters. A managed endpoint is a gateway
        /// that connects Amazon EMR Studio to Amazon EMR on EKS so that Amazon EMR Studio can
        /// communicate with your virtual cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListManagedEndpoints service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListManagedEndpoints">REST API Reference for ListManagedEndpoints Operation</seealso>
        Task<ListManagedEndpointsResponse> ListManagedEndpointsAsync(ListManagedEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the tags assigned to the resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists information about the specified virtual cluster. Virtual cluster is a managed
        /// entity on Amazon EMR on EKS. You can create, describe, list and delete virtual clusters.
        /// They do not consume any additional resource in your system. A single virtual cluster
        /// maps to a single Kubernetes namespace. Given this relationship, you can model virtual
        /// clusters the same way you model Kubernetes namespaces to meet your requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVirtualClusters service method, as returned by EMRContainers.</returns>
        /// <exception cref="Amazon.EMRContainers.Model.InternalServerException">
        /// This is an internal server exception.
        /// </exception>
        /// <exception cref="Amazon.EMRContainers.Model.ValidationException">
        /// There are invalid parameters in the client request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-containers-2020-10-01/ListVirtualClusters">REST API Reference for ListVirtualClusters Operation</seealso>
        Task<ListVirtualClustersResponse> ListVirtualClustersAsync(ListVirtualClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts a job run. A job run is a unit of work, such as a Spark jar, PySpark script,
        /// or SparkSQL query, that you submit to Amazon EMR on EKS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartJobRunResponse> StartJobRunAsync(StartJobRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes tags from resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}