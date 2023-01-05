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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ElasticMapReduce.Model;

namespace Amazon.ElasticMapReduce
{
    /// <summary>
    /// Interface for accessing ElasticMapReduce
    ///
    /// Amazon EMR is a web service that makes it easier to process large amounts of data
    /// efficiently. Amazon EMR uses Hadoop processing combined with several Amazon Web Services
    /// services to do tasks such as web indexing, data mining, log file analysis, machine
    /// learning, scientific simulation, and data warehouse management.
    /// </summary>
    public partial interface IAmazonElasticMapReduce : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IElasticMapReducePaginatorFactory Paginators { get; }

        
        #region  AddInstanceFleet


        /// <summary>
        /// Adds an instance fleet to a running cluster.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceFleet service method.</param>
        /// 
        /// <returns>The response from the AddInstanceFleet service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceFleet">REST API Reference for AddInstanceFleet Operation</seealso>
        AddInstanceFleetResponse AddInstanceFleet(AddInstanceFleetRequest request);



        /// <summary>
        /// Adds an instance fleet to a running cluster.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddInstanceFleet service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceFleet">REST API Reference for AddInstanceFleet Operation</seealso>
        Task<AddInstanceFleetResponse> AddInstanceFleetAsync(AddInstanceFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddInstanceGroups


        /// <summary>
        /// Adds one or more instance groups to a running cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceGroups service method.</param>
        /// 
        /// <returns>The response from the AddInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceGroups">REST API Reference for AddInstanceGroups Operation</seealso>
        AddInstanceGroupsResponse AddInstanceGroups(AddInstanceGroupsRequest request);



        /// <summary>
        /// Adds one or more instance groups to a running cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceGroups">REST API Reference for AddInstanceGroups Operation</seealso>
        Task<AddInstanceGroupsResponse> AddInstanceGroupsAsync(AddInstanceGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddJobFlowSteps


        /// <summary>
        /// AddJobFlowSteps adds new steps to a running cluster. A maximum of 256 steps are allowed
        /// in each job flow.
        /// 
        ///  
        /// <para>
        /// If your cluster is long-running (such as a Hive data warehouse) or complex, you may
        /// require more than 256 steps to process your data. You can bypass the 256-step limitation
        /// in various ways, including using SSH to connect to the master node and submitting
        /// queries directly to the software running on the master node, such as Hive and Hadoop.
        /// </para>
        ///  
        /// <para>
        /// A step specifies the location of a JAR file stored either on the master node of the
        /// cluster or in Amazon S3. Each step is performed by the main function of the main class
        /// of the JAR file. The main class can be specified either in the manifest of the JAR
        /// or by using the MainFunction parameter of the step.
        /// </para>
        ///  
        /// <para>
        /// Amazon EMR executes each step in the order listed. For a step to be considered complete,
        /// the main function must exit with a zero exit code and all Hadoop jobs started while
        /// the step was running must have completed and run successfully.
        /// </para>
        ///  
        /// <para>
        /// You can only add steps to a cluster that is in one of the following states: STARTING,
        /// BOOTSTRAPPING, RUNNING, or WAITING.
        /// </para>
        ///  <note> 
        /// <para>
        /// The string values passed into <code>HadoopJarStep</code> object cannot exceed a total
        /// of 10240 characters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddJobFlowSteps service method.</param>
        /// 
        /// <returns>The response from the AddJobFlowSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddJobFlowSteps">REST API Reference for AddJobFlowSteps Operation</seealso>
        AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest request);



        /// <summary>
        /// AddJobFlowSteps adds new steps to a running cluster. A maximum of 256 steps are allowed
        /// in each job flow.
        /// 
        ///  
        /// <para>
        /// If your cluster is long-running (such as a Hive data warehouse) or complex, you may
        /// require more than 256 steps to process your data. You can bypass the 256-step limitation
        /// in various ways, including using SSH to connect to the master node and submitting
        /// queries directly to the software running on the master node, such as Hive and Hadoop.
        /// </para>
        ///  
        /// <para>
        /// A step specifies the location of a JAR file stored either on the master node of the
        /// cluster or in Amazon S3. Each step is performed by the main function of the main class
        /// of the JAR file. The main class can be specified either in the manifest of the JAR
        /// or by using the MainFunction parameter of the step.
        /// </para>
        ///  
        /// <para>
        /// Amazon EMR executes each step in the order listed. For a step to be considered complete,
        /// the main function must exit with a zero exit code and all Hadoop jobs started while
        /// the step was running must have completed and run successfully.
        /// </para>
        ///  
        /// <para>
        /// You can only add steps to a cluster that is in one of the following states: STARTING,
        /// BOOTSTRAPPING, RUNNING, or WAITING.
        /// </para>
        ///  <note> 
        /// <para>
        /// The string values passed into <code>HadoopJarStep</code> object cannot exceed a total
        /// of 10240 characters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddJobFlowSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddJobFlowSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddJobFlowSteps">REST API Reference for AddJobFlowSteps Operation</seealso>
        Task<AddJobFlowStepsResponse> AddJobFlowStepsAsync(AddJobFlowStepsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddTags


        /// <summary>
        /// Adds tags to an Amazon EMR resource, such as a cluster or an Amazon EMR Studio. Tags
        /// make it easier to associate resources in various ways, such as grouping clusters to
        /// track your Amazon EMR resource allocation costs. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-tags.html">Tag
        /// Clusters</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse AddTags(AddTagsRequest request);



        /// <summary>
        /// Adds tags to an Amazon EMR resource, such as a cluster or an Amazon EMR Studio. Tags
        /// make it easier to associate resources in various ways, such as grouping clusters to
        /// track your Amazon EMR resource allocation costs. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-tags.html">Tag
        /// Clusters</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddTags">REST API Reference for AddTags Operation</seealso>
        Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelSteps


        /// <summary>
        /// Cancels a pending step or steps in a running cluster. Available only in Amazon EMR
        /// versions 4.8.0 and later, excluding version 5.0.0. A maximum of 256 steps are allowed
        /// in each CancelSteps request. CancelSteps is idempotent but asynchronous; it does not
        /// guarantee that a step will be canceled, even if the request is successfully submitted.
        /// When you use Amazon EMR versions 5.28.0 and later, you can cancel steps that are in
        /// a <code>PENDING</code> or <code>RUNNING</code> state. In earlier versions of Amazon
        /// EMR, you can only cancel steps that are in a <code>PENDING</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSteps service method.</param>
        /// 
        /// <returns>The response from the CancelSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CancelSteps">REST API Reference for CancelSteps Operation</seealso>
        CancelStepsResponse CancelSteps(CancelStepsRequest request);



        /// <summary>
        /// Cancels a pending step or steps in a running cluster. Available only in Amazon EMR
        /// versions 4.8.0 and later, excluding version 5.0.0. A maximum of 256 steps are allowed
        /// in each CancelSteps request. CancelSteps is idempotent but asynchronous; it does not
        /// guarantee that a step will be canceled, even if the request is successfully submitted.
        /// When you use Amazon EMR versions 5.28.0 and later, you can cancel steps that are in
        /// a <code>PENDING</code> or <code>RUNNING</code> state. In earlier versions of Amazon
        /// EMR, you can only cancel steps that are in a <code>PENDING</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CancelSteps">REST API Reference for CancelSteps Operation</seealso>
        Task<CancelStepsResponse> CancelStepsAsync(CancelStepsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSecurityConfiguration


        /// <summary>
        /// Creates a security configuration, which is stored in the service and can be specified
        /// when a cluster is created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateSecurityConfiguration">REST API Reference for CreateSecurityConfiguration Operation</seealso>
        CreateSecurityConfigurationResponse CreateSecurityConfiguration(CreateSecurityConfigurationRequest request);



        /// <summary>
        /// Creates a security configuration, which is stored in the service and can be specified
        /// when a cluster is created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateSecurityConfiguration">REST API Reference for CreateSecurityConfiguration Operation</seealso>
        Task<CreateSecurityConfigurationResponse> CreateSecurityConfigurationAsync(CreateSecurityConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStudio


        /// <summary>
        /// Creates a new Amazon EMR Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudio service method.</param>
        /// 
        /// <returns>The response from the CreateStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateStudio">REST API Reference for CreateStudio Operation</seealso>
        CreateStudioResponse CreateStudio(CreateStudioRequest request);



        /// <summary>
        /// Creates a new Amazon EMR Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateStudio">REST API Reference for CreateStudio Operation</seealso>
        Task<CreateStudioResponse> CreateStudioAsync(CreateStudioRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStudioSessionMapping


        /// <summary>
        /// Maps a user or group to the Amazon EMR Studio specified by <code>StudioId</code>,
        /// and applies a session policy to refine Studio permissions for that user or group.
        /// Use <code>CreateStudioSessionMapping</code> to assign users to a Studio when you use
        /// IAM Identity Center authentication. For instructions on how to assign users to a Studio
        /// when you use IAM authentication, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-studio-manage-users.html#emr-studio-assign-users-groups">Assign
        /// a user or group to your EMR Studio</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudioSessionMapping service method.</param>
        /// 
        /// <returns>The response from the CreateStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateStudioSessionMapping">REST API Reference for CreateStudioSessionMapping Operation</seealso>
        CreateStudioSessionMappingResponse CreateStudioSessionMapping(CreateStudioSessionMappingRequest request);



        /// <summary>
        /// Maps a user or group to the Amazon EMR Studio specified by <code>StudioId</code>,
        /// and applies a session policy to refine Studio permissions for that user or group.
        /// Use <code>CreateStudioSessionMapping</code> to assign users to a Studio when you use
        /// IAM Identity Center authentication. For instructions on how to assign users to a Studio
        /// when you use IAM authentication, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-studio-manage-users.html#emr-studio-assign-users-groups">Assign
        /// a user or group to your EMR Studio</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudioSessionMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateStudioSessionMapping">REST API Reference for CreateStudioSessionMapping Operation</seealso>
        Task<CreateStudioSessionMappingResponse> CreateStudioSessionMappingAsync(CreateStudioSessionMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSecurityConfiguration


        /// <summary>
        /// Deletes a security configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteSecurityConfiguration">REST API Reference for DeleteSecurityConfiguration Operation</seealso>
        DeleteSecurityConfigurationResponse DeleteSecurityConfiguration(DeleteSecurityConfigurationRequest request);



        /// <summary>
        /// Deletes a security configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteSecurityConfiguration">REST API Reference for DeleteSecurityConfiguration Operation</seealso>
        Task<DeleteSecurityConfigurationResponse> DeleteSecurityConfigurationAsync(DeleteSecurityConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStudio


        /// <summary>
        /// Removes an Amazon EMR Studio from the Studio metadata store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudio service method.</param>
        /// 
        /// <returns>The response from the DeleteStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteStudio">REST API Reference for DeleteStudio Operation</seealso>
        DeleteStudioResponse DeleteStudio(DeleteStudioRequest request);



        /// <summary>
        /// Removes an Amazon EMR Studio from the Studio metadata store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteStudio">REST API Reference for DeleteStudio Operation</seealso>
        Task<DeleteStudioResponse> DeleteStudioAsync(DeleteStudioRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStudioSessionMapping


        /// <summary>
        /// Removes a user or group from an Amazon EMR Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioSessionMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteStudioSessionMapping">REST API Reference for DeleteStudioSessionMapping Operation</seealso>
        DeleteStudioSessionMappingResponse DeleteStudioSessionMapping(DeleteStudioSessionMappingRequest request);



        /// <summary>
        /// Removes a user or group from an Amazon EMR Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioSessionMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteStudioSessionMapping">REST API Reference for DeleteStudioSessionMapping Operation</seealso>
        Task<DeleteStudioSessionMappingResponse> DeleteStudioSessionMappingAsync(DeleteStudioSessionMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCluster


        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        DescribeClusterResponse DescribeCluster();


        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        DescribeClusterResponse DescribeCluster(DescribeClusterRequest request);


        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        Task<DescribeClusterResponse> DescribeClusterAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeJobFlows


        /// <summary>
        /// This API is no longer supported and will eventually be removed. We recommend you use
        /// <a>ListClusters</a>, <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a>
        /// and <a>ListBootstrapActions</a> instead.
        /// 
        ///  
        /// <para>
        /// DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        /// The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job flow creation date and time.
        /// </para>
        ///  
        /// <para>
        /// Regardless of supplied parameters, only job flows created within the last two months
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If no parameters are supplied, then job flows matching either of the following criteria
        /// are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Job flows created and completed in the last two weeks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Job flows created within the last two months that are in one of the following states:
        /// <code>RUNNING</code>, <code>WAITING</code>, <code>SHUTTING_DOWN</code>, <code>STARTING</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon EMR can return a maximum of 512 job flow descriptions.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        DescribeJobFlowsResponse DescribeJobFlows();


        /// <summary>
        /// This API is no longer supported and will eventually be removed. We recommend you use
        /// <a>ListClusters</a>, <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a>
        /// and <a>ListBootstrapActions</a> instead.
        /// 
        ///  
        /// <para>
        /// DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        /// The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job flow creation date and time.
        /// </para>
        ///  
        /// <para>
        /// Regardless of supplied parameters, only job flows created within the last two months
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If no parameters are supplied, then job flows matching either of the following criteria
        /// are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Job flows created and completed in the last two weeks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Job flows created within the last two months that are in one of the following states:
        /// <code>RUNNING</code>, <code>WAITING</code>, <code>SHUTTING_DOWN</code>, <code>STARTING</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon EMR can return a maximum of 512 job flow descriptions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobFlows service method.</param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest request);


        /// <summary>
        /// This API is no longer supported and will eventually be removed. We recommend you use
        /// <a>ListClusters</a>, <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a>
        /// and <a>ListBootstrapActions</a> instead.
        /// 
        ///  
        /// <para>
        /// DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        /// The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job flow creation date and time.
        /// </para>
        ///  
        /// <para>
        /// Regardless of supplied parameters, only job flows created within the last two months
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If no parameters are supplied, then job flows matching either of the following criteria
        /// are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Job flows created and completed in the last two weeks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Job flows created within the last two months that are in one of the following states:
        /// <code>RUNNING</code>, <code>WAITING</code>, <code>SHUTTING_DOWN</code>, <code>STARTING</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon EMR can return a maximum of 512 job flow descriptions.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        Task<DescribeJobFlowsResponse> DescribeJobFlowsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// This API is no longer supported and will eventually be removed. We recommend you use
        /// <a>ListClusters</a>, <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a>
        /// and <a>ListBootstrapActions</a> instead.
        /// 
        ///  
        /// <para>
        /// DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        /// The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job flow creation date and time.
        /// </para>
        ///  
        /// <para>
        /// Regardless of supplied parameters, only job flows created within the last two months
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If no parameters are supplied, then job flows matching either of the following criteria
        /// are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Job flows created and completed in the last two weeks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Job flows created within the last two months that are in one of the following states:
        /// <code>RUNNING</code>, <code>WAITING</code>, <code>SHUTTING_DOWN</code>, <code>STARTING</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon EMR can return a maximum of 512 job flow descriptions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        Task<DescribeJobFlowsResponse> DescribeJobFlowsAsync(DescribeJobFlowsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeNotebookExecution


        /// <summary>
        /// Provides details of a notebook execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeNotebookExecution service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeNotebookExecution">REST API Reference for DescribeNotebookExecution Operation</seealso>
        DescribeNotebookExecutionResponse DescribeNotebookExecution(DescribeNotebookExecutionRequest request);



        /// <summary>
        /// Provides details of a notebook execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotebookExecution service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeNotebookExecution">REST API Reference for DescribeNotebookExecution Operation</seealso>
        Task<DescribeNotebookExecutionResponse> DescribeNotebookExecutionAsync(DescribeNotebookExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReleaseLabel


        /// <summary>
        /// Provides EMR release label details, such as releases available the region where the
        /// API request is run, and the available applications for a specific EMR release label.
        /// Can also list EMR release versions that support a specified version of Spark.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReleaseLabel service method.</param>
        /// 
        /// <returns>The response from the DescribeReleaseLabel service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeReleaseLabel">REST API Reference for DescribeReleaseLabel Operation</seealso>
        DescribeReleaseLabelResponse DescribeReleaseLabel(DescribeReleaseLabelRequest request);



        /// <summary>
        /// Provides EMR release label details, such as releases available the region where the
        /// API request is run, and the available applications for a specific EMR release label.
        /// Can also list EMR release versions that support a specified version of Spark.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReleaseLabel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReleaseLabel service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeReleaseLabel">REST API Reference for DescribeReleaseLabel Operation</seealso>
        Task<DescribeReleaseLabelResponse> DescribeReleaseLabelAsync(DescribeReleaseLabelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSecurityConfiguration


        /// <summary>
        /// Provides the details of a security configuration by returning the configuration JSON.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeSecurityConfiguration">REST API Reference for DescribeSecurityConfiguration Operation</seealso>
        DescribeSecurityConfigurationResponse DescribeSecurityConfiguration(DescribeSecurityConfigurationRequest request);



        /// <summary>
        /// Provides the details of a security configuration by returning the configuration JSON.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeSecurityConfiguration">REST API Reference for DescribeSecurityConfiguration Operation</seealso>
        Task<DescribeSecurityConfigurationResponse> DescribeSecurityConfigurationAsync(DescribeSecurityConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStep


        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        DescribeStepResponse DescribeStep();


        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStep service method.</param>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        DescribeStepResponse DescribeStep(DescribeStepRequest request);


        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        Task<DescribeStepResponse> DescribeStepAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        Task<DescribeStepResponse> DescribeStepAsync(DescribeStepRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStudio


        /// <summary>
        /// Returns details for the specified Amazon EMR Studio including ID, Name, VPC, Studio
        /// access URL, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStudio service method.</param>
        /// 
        /// <returns>The response from the DescribeStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStudio">REST API Reference for DescribeStudio Operation</seealso>
        DescribeStudioResponse DescribeStudio(DescribeStudioRequest request);



        /// <summary>
        /// Returns details for the specified Amazon EMR Studio including ID, Name, VPC, Studio
        /// access URL, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStudio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStudio">REST API Reference for DescribeStudio Operation</seealso>
        Task<DescribeStudioResponse> DescribeStudioAsync(DescribeStudioRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAutoTerminationPolicy


        /// <summary>
        /// Returns the auto-termination policy for an Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoTerminationPolicy service method.</param>
        /// 
        /// <returns>The response from the GetAutoTerminationPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetAutoTerminationPolicy">REST API Reference for GetAutoTerminationPolicy Operation</seealso>
        GetAutoTerminationPolicyResponse GetAutoTerminationPolicy(GetAutoTerminationPolicyRequest request);



        /// <summary>
        /// Returns the auto-termination policy for an Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoTerminationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutoTerminationPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetAutoTerminationPolicy">REST API Reference for GetAutoTerminationPolicy Operation</seealso>
        Task<GetAutoTerminationPolicyResponse> GetAutoTerminationPolicyAsync(GetAutoTerminationPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBlockPublicAccessConfiguration


        /// <summary>
        /// Returns the Amazon EMR block public access configuration for your Amazon Web Services
        /// account in the current Region. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/configure-block-public-access.html">Configure
        /// Block Public Access for Amazon EMR</a> in the <i>Amazon EMR Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlockPublicAccessConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetBlockPublicAccessConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetBlockPublicAccessConfiguration">REST API Reference for GetBlockPublicAccessConfiguration Operation</seealso>
        GetBlockPublicAccessConfigurationResponse GetBlockPublicAccessConfiguration(GetBlockPublicAccessConfigurationRequest request);



        /// <summary>
        /// Returns the Amazon EMR block public access configuration for your Amazon Web Services
        /// account in the current Region. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/configure-block-public-access.html">Configure
        /// Block Public Access for Amazon EMR</a> in the <i>Amazon EMR Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlockPublicAccessConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBlockPublicAccessConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetBlockPublicAccessConfiguration">REST API Reference for GetBlockPublicAccessConfiguration Operation</seealso>
        Task<GetBlockPublicAccessConfigurationResponse> GetBlockPublicAccessConfigurationAsync(GetBlockPublicAccessConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetClusterSessionCredentials


        /// <summary>
        /// Provides Temporary, basic HTTP credentials that are associated with a given runtime
        /// IAM role and used by a cluster with fine-grained access control activated. You can
        /// use these credentials to connect to cluster endpoints that support username-based
        /// and password-based authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterSessionCredentials service method.</param>
        /// 
        /// <returns>The response from the GetClusterSessionCredentials service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetClusterSessionCredentials">REST API Reference for GetClusterSessionCredentials Operation</seealso>
        GetClusterSessionCredentialsResponse GetClusterSessionCredentials(GetClusterSessionCredentialsRequest request);



        /// <summary>
        /// Provides Temporary, basic HTTP credentials that are associated with a given runtime
        /// IAM role and used by a cluster with fine-grained access control activated. You can
        /// use these credentials to connect to cluster endpoints that support username-based
        /// and password-based authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterSessionCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClusterSessionCredentials service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetClusterSessionCredentials">REST API Reference for GetClusterSessionCredentials Operation</seealso>
        Task<GetClusterSessionCredentialsResponse> GetClusterSessionCredentialsAsync(GetClusterSessionCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetManagedScalingPolicy


        /// <summary>
        /// Fetches the attached managed scaling policy for an Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the GetManagedScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetManagedScalingPolicy">REST API Reference for GetManagedScalingPolicy Operation</seealso>
        GetManagedScalingPolicyResponse GetManagedScalingPolicy(GetManagedScalingPolicyRequest request);



        /// <summary>
        /// Fetches the attached managed scaling policy for an Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetManagedScalingPolicy">REST API Reference for GetManagedScalingPolicy Operation</seealso>
        Task<GetManagedScalingPolicyResponse> GetManagedScalingPolicyAsync(GetManagedScalingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStudioSessionMapping


        /// <summary>
        /// Fetches mapping details for the specified Amazon EMR Studio and identity (user or
        /// group).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStudioSessionMapping service method.</param>
        /// 
        /// <returns>The response from the GetStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetStudioSessionMapping">REST API Reference for GetStudioSessionMapping Operation</seealso>
        GetStudioSessionMappingResponse GetStudioSessionMapping(GetStudioSessionMappingRequest request);



        /// <summary>
        /// Fetches mapping details for the specified Amazon EMR Studio and identity (user or
        /// group).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStudioSessionMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetStudioSessionMapping">REST API Reference for GetStudioSessionMapping Operation</seealso>
        Task<GetStudioSessionMappingResponse> GetStudioSessionMappingAsync(GetStudioSessionMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBootstrapActions


        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        ListBootstrapActionsResponse ListBootstrapActions();


        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBootstrapActions service method.</param>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        ListBootstrapActionsResponse ListBootstrapActions(ListBootstrapActionsRequest request);


        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        Task<ListBootstrapActionsResponse> ListBootstrapActionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBootstrapActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        Task<ListBootstrapActionsResponse> ListBootstrapActionsAsync(ListBootstrapActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListClusters


        /// <summary>
        /// Provides the status of all clusters visible to this Amazon Web Services account. Allows
        /// you to filter the list of clusters based on certain criteria; for example, filtering
        /// by cluster creation date and time or by status. This call returns a maximum of 50
        /// clusters in unsorted order per call, but returns a marker to track the paging of the
        /// cluster list across multiple ListClusters calls.
        /// </summary>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        ListClustersResponse ListClusters();


        /// <summary>
        /// Provides the status of all clusters visible to this Amazon Web Services account. Allows
        /// you to filter the list of clusters based on certain criteria; for example, filtering
        /// by cluster creation date and time or by status. This call returns a maximum of 50
        /// clusters in unsorted order per call, but returns a marker to track the paging of the
        /// cluster list across multiple ListClusters calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        ListClustersResponse ListClusters(ListClustersRequest request);


        /// <summary>
        /// Provides the status of all clusters visible to this Amazon Web Services account. Allows
        /// you to filter the list of clusters based on certain criteria; for example, filtering
        /// by cluster creation date and time or by status. This call returns a maximum of 50
        /// clusters in unsorted order per call, but returns a marker to track the paging of the
        /// cluster list across multiple ListClusters calls.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        Task<ListClustersResponse> ListClustersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Provides the status of all clusters visible to this Amazon Web Services account. Allows
        /// you to filter the list of clusters based on certain criteria; for example, filtering
        /// by cluster creation date and time or by status. This call returns a maximum of 50
        /// clusters in unsorted order per call, but returns a marker to track the paging of the
        /// cluster list across multiple ListClusters calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInstanceFleets


        /// <summary>
        /// Lists all available details about the instance fleets in a cluster.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceFleets service method.</param>
        /// 
        /// <returns>The response from the ListInstanceFleets service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceFleets">REST API Reference for ListInstanceFleets Operation</seealso>
        ListInstanceFleetsResponse ListInstanceFleets(ListInstanceFleetsRequest request);



        /// <summary>
        /// Lists all available details about the instance fleets in a cluster.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceFleets service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceFleets">REST API Reference for ListInstanceFleets Operation</seealso>
        Task<ListInstanceFleetsResponse> ListInstanceFleetsAsync(ListInstanceFleetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInstanceGroups


        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        ListInstanceGroupsResponse ListInstanceGroups();


        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceGroups service method.</param>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        ListInstanceGroupsResponse ListInstanceGroups(ListInstanceGroupsRequest request);


        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        Task<ListInstanceGroupsResponse> ListInstanceGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        Task<ListInstanceGroupsResponse> ListInstanceGroupsAsync(ListInstanceGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInstances


        /// <summary>
        /// Provides information for all active EC2 instances and EC2 instances terminated in
        /// the last 30 days, up to a maximum of 2,000. EC2 instances in any of the following
        /// states are considered active: AWAITING_FULFILLMENT, PROVISIONING, BOOTSTRAPPING, RUNNING.
        /// </summary>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        ListInstancesResponse ListInstances();


        /// <summary>
        /// Provides information for all active EC2 instances and EC2 instances terminated in
        /// the last 30 days, up to a maximum of 2,000. EC2 instances in any of the following
        /// states are considered active: AWAITING_FULFILLMENT, PROVISIONING, BOOTSTRAPPING, RUNNING.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        ListInstancesResponse ListInstances(ListInstancesRequest request);


        /// <summary>
        /// Provides information for all active EC2 instances and EC2 instances terminated in
        /// the last 30 days, up to a maximum of 2,000. EC2 instances in any of the following
        /// states are considered active: AWAITING_FULFILLMENT, PROVISIONING, BOOTSTRAPPING, RUNNING.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        Task<ListInstancesResponse> ListInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Provides information for all active EC2 instances and EC2 instances terminated in
        /// the last 30 days, up to a maximum of 2,000. EC2 instances in any of the following
        /// states are considered active: AWAITING_FULFILLMENT, PROVISIONING, BOOTSTRAPPING, RUNNING.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListNotebookExecutions


        /// <summary>
        /// Provides summaries of all notebook executions. You can filter the list based on multiple
        /// criteria such as status, time range, and editor id. Returns a maximum of 50 notebook
        /// executions and a marker to track the paging of a longer notebook execution list across
        /// multiple <code>ListNotebookExecution</code> calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookExecutions service method.</param>
        /// 
        /// <returns>The response from the ListNotebookExecutions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListNotebookExecutions">REST API Reference for ListNotebookExecutions Operation</seealso>
        ListNotebookExecutionsResponse ListNotebookExecutions(ListNotebookExecutionsRequest request);



        /// <summary>
        /// Provides summaries of all notebook executions. You can filter the list based on multiple
        /// criteria such as status, time range, and editor id. Returns a maximum of 50 notebook
        /// executions and a marker to track the paging of a longer notebook execution list across
        /// multiple <code>ListNotebookExecution</code> calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotebookExecutions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListNotebookExecutions">REST API Reference for ListNotebookExecutions Operation</seealso>
        Task<ListNotebookExecutionsResponse> ListNotebookExecutionsAsync(ListNotebookExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReleaseLabels


        /// <summary>
        /// Retrieves release labels of EMR services in the region where the API is called.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReleaseLabels service method.</param>
        /// 
        /// <returns>The response from the ListReleaseLabels service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListReleaseLabels">REST API Reference for ListReleaseLabels Operation</seealso>
        ListReleaseLabelsResponse ListReleaseLabels(ListReleaseLabelsRequest request);



        /// <summary>
        /// Retrieves release labels of EMR services in the region where the API is called.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReleaseLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReleaseLabels service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListReleaseLabels">REST API Reference for ListReleaseLabels Operation</seealso>
        Task<ListReleaseLabelsResponse> ListReleaseLabelsAsync(ListReleaseLabelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSecurityConfigurations


        /// <summary>
        /// Lists all the security configurations visible to this account, providing their creation
        /// dates and times, and their names. This call returns a maximum of 50 clusters per call,
        /// but returns a marker to track the paging of the cluster list across multiple ListSecurityConfigurations
        /// calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListSecurityConfigurations service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSecurityConfigurations">REST API Reference for ListSecurityConfigurations Operation</seealso>
        ListSecurityConfigurationsResponse ListSecurityConfigurations(ListSecurityConfigurationsRequest request);



        /// <summary>
        /// Lists all the security configurations visible to this account, providing their creation
        /// dates and times, and their names. This call returns a maximum of 50 clusters per call,
        /// but returns a marker to track the paging of the cluster list across multiple ListSecurityConfigurations
        /// calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityConfigurations service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSecurityConfigurations">REST API Reference for ListSecurityConfigurations Operation</seealso>
        Task<ListSecurityConfigurationsResponse> ListSecurityConfigurationsAsync(ListSecurityConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSteps


        /// <summary>
        /// Provides a list of steps for the cluster in reverse order unless you specify <code>stepIds</code>
        /// with the request or filter by <code>StepStates</code>. You can specify a maximum of
        /// 10 <code>stepIDs</code>. The CLI automatically paginates results to return a list
        /// greater than 50 steps. To return more than 50 steps using the CLI, specify a <code>Marker</code>,
        /// which is a pagination token that indicates the next set of steps to retrieve.
        /// </summary>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        ListStepsResponse ListSteps();


        /// <summary>
        /// Provides a list of steps for the cluster in reverse order unless you specify <code>stepIds</code>
        /// with the request or filter by <code>StepStates</code>. You can specify a maximum of
        /// 10 <code>stepIDs</code>. The CLI automatically paginates results to return a list
        /// greater than 50 steps. To return more than 50 steps using the CLI, specify a <code>Marker</code>,
        /// which is a pagination token that indicates the next set of steps to retrieve.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSteps service method.</param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        ListStepsResponse ListSteps(ListStepsRequest request);


        /// <summary>
        /// Provides a list of steps for the cluster in reverse order unless you specify <code>stepIds</code>
        /// with the request or filter by <code>StepStates</code>. You can specify a maximum of
        /// 10 <code>stepIDs</code>. The CLI automatically paginates results to return a list
        /// greater than 50 steps. To return more than 50 steps using the CLI, specify a <code>Marker</code>,
        /// which is a pagination token that indicates the next set of steps to retrieve.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        Task<ListStepsResponse> ListStepsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Provides a list of steps for the cluster in reverse order unless you specify <code>stepIds</code>
        /// with the request or filter by <code>StepStates</code>. You can specify a maximum of
        /// 10 <code>stepIDs</code>. The CLI automatically paginates results to return a list
        /// greater than 50 steps. To return more than 50 steps using the CLI, specify a <code>Marker</code>,
        /// which is a pagination token that indicates the next set of steps to retrieve.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        Task<ListStepsResponse> ListStepsAsync(ListStepsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStudios


        /// <summary>
        /// Returns a list of all Amazon EMR Studios associated with the Amazon Web Services account.
        /// The list includes details such as ID, Studio Access URL, and creation time for each
        /// Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudios service method.</param>
        /// 
        /// <returns>The response from the ListStudios service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListStudios">REST API Reference for ListStudios Operation</seealso>
        ListStudiosResponse ListStudios(ListStudiosRequest request);



        /// <summary>
        /// Returns a list of all Amazon EMR Studios associated with the Amazon Web Services account.
        /// The list includes details such as ID, Studio Access URL, and creation time for each
        /// Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudios service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStudios service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListStudios">REST API Reference for ListStudios Operation</seealso>
        Task<ListStudiosResponse> ListStudiosAsync(ListStudiosRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStudioSessionMappings


        /// <summary>
        /// Returns a list of all user or group session mappings for the Amazon EMR Studio specified
        /// by <code>StudioId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudioSessionMappings service method.</param>
        /// 
        /// <returns>The response from the ListStudioSessionMappings service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListStudioSessionMappings">REST API Reference for ListStudioSessionMappings Operation</seealso>
        ListStudioSessionMappingsResponse ListStudioSessionMappings(ListStudioSessionMappingsRequest request);



        /// <summary>
        /// Returns a list of all user or group session mappings for the Amazon EMR Studio specified
        /// by <code>StudioId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudioSessionMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStudioSessionMappings service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListStudioSessionMappings">REST API Reference for ListStudioSessionMappings Operation</seealso>
        Task<ListStudioSessionMappingsResponse> ListStudioSessionMappingsAsync(ListStudioSessionMappingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyCluster


        /// <summary>
        /// Modifies the number of steps that can be executed concurrently for the cluster specified
        /// using ClusterID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        ModifyClusterResponse ModifyCluster(ModifyClusterRequest request);



        /// <summary>
        /// Modifies the number of steps that can be executed concurrently for the cluster specified
        /// using ClusterID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        Task<ModifyClusterResponse> ModifyClusterAsync(ModifyClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyInstanceFleet


        /// <summary>
        /// Modifies the target On-Demand and target Spot capacities for the instance fleet with
        /// the specified InstanceFleetID within the cluster specified using ClusterID. The call
        /// either succeeds or fails atomically.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceFleet service method.</param>
        /// 
        /// <returns>The response from the ModifyInstanceFleet service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceFleet">REST API Reference for ModifyInstanceFleet Operation</seealso>
        ModifyInstanceFleetResponse ModifyInstanceFleet(ModifyInstanceFleetRequest request);



        /// <summary>
        /// Modifies the target On-Demand and target Spot capacities for the instance fleet with
        /// the specified InstanceFleetID within the cluster specified using ClusterID. The call
        /// either succeeds or fails atomically.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceFleet service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceFleet">REST API Reference for ModifyInstanceFleet Operation</seealso>
        Task<ModifyInstanceFleetResponse> ModifyInstanceFleetAsync(ModifyInstanceFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyInstanceGroups


        /// <summary>
        /// ModifyInstanceGroups modifies the number of nodes and configuration settings of an
        /// instance group. The input parameters include the new target instance count for the
        /// group and the instance group ID. The call will either succeed or fail atomically.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceGroups service method.</param>
        /// 
        /// <returns>The response from the ModifyInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceGroups">REST API Reference for ModifyInstanceGroups Operation</seealso>
        ModifyInstanceGroupsResponse ModifyInstanceGroups(ModifyInstanceGroupsRequest request);



        /// <summary>
        /// ModifyInstanceGroups modifies the number of nodes and configuration settings of an
        /// instance group. The input parameters include the new target instance count for the
        /// group and the instance group ID. The call will either succeed or fail atomically.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceGroups">REST API Reference for ModifyInstanceGroups Operation</seealso>
        Task<ModifyInstanceGroupsResponse> ModifyInstanceGroupsAsync(ModifyInstanceGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAutoScalingPolicy


        /// <summary>
        /// Creates or updates an automatic scaling policy for a core instance group or task instance
        /// group in an Amazon EMR cluster. The automatic scaling policy defines how an instance
        /// group dynamically adds and terminates EC2 instances in response to the value of a
        /// CloudWatch metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAutoScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutAutoScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoScalingPolicy">REST API Reference for PutAutoScalingPolicy Operation</seealso>
        PutAutoScalingPolicyResponse PutAutoScalingPolicy(PutAutoScalingPolicyRequest request);



        /// <summary>
        /// Creates or updates an automatic scaling policy for a core instance group or task instance
        /// group in an Amazon EMR cluster. The automatic scaling policy defines how an instance
        /// group dynamically adds and terminates EC2 instances in response to the value of a
        /// CloudWatch metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAutoScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAutoScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoScalingPolicy">REST API Reference for PutAutoScalingPolicy Operation</seealso>
        Task<PutAutoScalingPolicyResponse> PutAutoScalingPolicyAsync(PutAutoScalingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAutoTerminationPolicy


        /// <summary>
        /// <note> 
        /// <para>
        /// Auto-termination is supported in Amazon EMR versions 5.30.0 and 6.1.0 and later. For
        /// more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-auto-termination-policy.html">Using
        /// an auto-termination policy</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates or updates an auto-termination policy for an Amazon EMR cluster. An auto-termination
        /// policy defines the amount of idle time in seconds after which a cluster automatically
        /// terminates. For alternative cluster termination options, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-termination.html">Control
        /// cluster termination</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAutoTerminationPolicy service method.</param>
        /// 
        /// <returns>The response from the PutAutoTerminationPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoTerminationPolicy">REST API Reference for PutAutoTerminationPolicy Operation</seealso>
        PutAutoTerminationPolicyResponse PutAutoTerminationPolicy(PutAutoTerminationPolicyRequest request);



        /// <summary>
        /// <note> 
        /// <para>
        /// Auto-termination is supported in Amazon EMR versions 5.30.0 and 6.1.0 and later. For
        /// more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-auto-termination-policy.html">Using
        /// an auto-termination policy</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates or updates an auto-termination policy for an Amazon EMR cluster. An auto-termination
        /// policy defines the amount of idle time in seconds after which a cluster automatically
        /// terminates. For alternative cluster termination options, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-termination.html">Control
        /// cluster termination</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAutoTerminationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAutoTerminationPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoTerminationPolicy">REST API Reference for PutAutoTerminationPolicy Operation</seealso>
        Task<PutAutoTerminationPolicyResponse> PutAutoTerminationPolicyAsync(PutAutoTerminationPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutBlockPublicAccessConfiguration


        /// <summary>
        /// Creates or updates an Amazon EMR block public access configuration for your Amazon
        /// Web Services account in the current Region. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/configure-block-public-access.html">Configure
        /// Block Public Access for Amazon EMR</a> in the <i>Amazon EMR Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBlockPublicAccessConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutBlockPublicAccessConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutBlockPublicAccessConfiguration">REST API Reference for PutBlockPublicAccessConfiguration Operation</seealso>
        PutBlockPublicAccessConfigurationResponse PutBlockPublicAccessConfiguration(PutBlockPublicAccessConfigurationRequest request);



        /// <summary>
        /// Creates or updates an Amazon EMR block public access configuration for your Amazon
        /// Web Services account in the current Region. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/configure-block-public-access.html">Configure
        /// Block Public Access for Amazon EMR</a> in the <i>Amazon EMR Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBlockPublicAccessConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBlockPublicAccessConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutBlockPublicAccessConfiguration">REST API Reference for PutBlockPublicAccessConfiguration Operation</seealso>
        Task<PutBlockPublicAccessConfigurationResponse> PutBlockPublicAccessConfigurationAsync(PutBlockPublicAccessConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutManagedScalingPolicy


        /// <summary>
        /// Creates or updates a managed scaling policy for an Amazon EMR cluster. The managed
        /// scaling policy defines the limits for resources, such as EC2 instances that can be
        /// added or terminated from a cluster. The policy only applies to the core and task nodes.
        /// The master node cannot be scaled after initial configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutManagedScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutManagedScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutManagedScalingPolicy">REST API Reference for PutManagedScalingPolicy Operation</seealso>
        PutManagedScalingPolicyResponse PutManagedScalingPolicy(PutManagedScalingPolicyRequest request);



        /// <summary>
        /// Creates or updates a managed scaling policy for an Amazon EMR cluster. The managed
        /// scaling policy defines the limits for resources, such as EC2 instances that can be
        /// added or terminated from a cluster. The policy only applies to the core and task nodes.
        /// The master node cannot be scaled after initial configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutManagedScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutManagedScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutManagedScalingPolicy">REST API Reference for PutManagedScalingPolicy Operation</seealso>
        Task<PutManagedScalingPolicyResponse> PutManagedScalingPolicyAsync(PutManagedScalingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveAutoScalingPolicy


        /// <summary>
        /// Removes an automatic scaling policy from a specified instance group within an EMR
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAutoScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the RemoveAutoScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoScalingPolicy">REST API Reference for RemoveAutoScalingPolicy Operation</seealso>
        RemoveAutoScalingPolicyResponse RemoveAutoScalingPolicy(RemoveAutoScalingPolicyRequest request);



        /// <summary>
        /// Removes an automatic scaling policy from a specified instance group within an EMR
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAutoScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveAutoScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoScalingPolicy">REST API Reference for RemoveAutoScalingPolicy Operation</seealso>
        Task<RemoveAutoScalingPolicyResponse> RemoveAutoScalingPolicyAsync(RemoveAutoScalingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveAutoTerminationPolicy


        /// <summary>
        /// Removes an auto-termination policy from an Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAutoTerminationPolicy service method.</param>
        /// 
        /// <returns>The response from the RemoveAutoTerminationPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoTerminationPolicy">REST API Reference for RemoveAutoTerminationPolicy Operation</seealso>
        RemoveAutoTerminationPolicyResponse RemoveAutoTerminationPolicy(RemoveAutoTerminationPolicyRequest request);



        /// <summary>
        /// Removes an auto-termination policy from an Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAutoTerminationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveAutoTerminationPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoTerminationPolicy">REST API Reference for RemoveAutoTerminationPolicy Operation</seealso>
        Task<RemoveAutoTerminationPolicyResponse> RemoveAutoTerminationPolicyAsync(RemoveAutoTerminationPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveManagedScalingPolicy


        /// <summary>
        /// Removes a managed scaling policy from a specified EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveManagedScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the RemoveManagedScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveManagedScalingPolicy">REST API Reference for RemoveManagedScalingPolicy Operation</seealso>
        RemoveManagedScalingPolicyResponse RemoveManagedScalingPolicy(RemoveManagedScalingPolicyRequest request);



        /// <summary>
        /// Removes a managed scaling policy from a specified EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveManagedScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveManagedScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveManagedScalingPolicy">REST API Reference for RemoveManagedScalingPolicy Operation</seealso>
        Task<RemoveManagedScalingPolicyResponse> RemoveManagedScalingPolicyAsync(RemoveManagedScalingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTags


        /// <summary>
        /// Removes tags from an Amazon EMR resource, such as a cluster or Amazon EMR Studio.
        /// Tags make it easier to associate resources in various ways, such as grouping clusters
        /// to track your Amazon EMR resource allocation costs. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-tags.html">Tag
        /// Clusters</a>. 
        /// 
        ///  
        /// <para>
        /// The following example removes the stack tag with value Prod from a cluster:
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        RemoveTagsResponse RemoveTags(RemoveTagsRequest request);



        /// <summary>
        /// Removes tags from an Amazon EMR resource, such as a cluster or Amazon EMR Studio.
        /// Tags make it easier to associate resources in various ways, such as grouping clusters
        /// to track your Amazon EMR resource allocation costs. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-tags.html">Tag
        /// Clusters</a>. 
        /// 
        ///  
        /// <para>
        /// The following example removes the stack tag with value Prod from a cluster:
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RunJobFlow


        /// <summary>
        /// RunJobFlow creates and starts running a new cluster (job flow). The cluster runs the
        /// steps specified. After the steps complete, the cluster stops and the HDFS partition
        /// is lost. To prevent loss of data, configure the last step of the job flow to store
        /// results in Amazon S3. If the <a>JobFlowInstancesConfig</a> <code>KeepJobFlowAliveWhenNoSteps</code>
        /// parameter is set to <code>TRUE</code>, the cluster transitions to the WAITING state
        /// rather than shutting down after the steps have completed. 
        /// 
        ///  
        /// <para>
        /// For additional protection, you can set the <a>JobFlowInstancesConfig</a> <code>TerminationProtected</code>
        /// parameter to <code>TRUE</code> to lock the cluster and prevent it from being terminated
        /// by API call, user intervention, or in the event of a job flow error.
        /// </para>
        ///  
        /// <para>
        /// A maximum of 256 steps are allowed in each job flow.
        /// </para>
        ///  
        /// <para>
        /// If your cluster is long-running (such as a Hive data warehouse) or complex, you may
        /// require more than 256 steps to process your data. You can bypass the 256-step limitation
        /// in various ways, including using the SSH shell to connect to the master node and submitting
        /// queries directly to the software running on the master node, such as Hive and Hadoop.
        /// </para>
        ///  
        /// <para>
        /// For long-running clusters, we recommend that you periodically store your results.
        /// </para>
        ///  <note> 
        /// <para>
        /// The instance fleets configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x versions. The RunJobFlow request can contain InstanceFleets
        /// parameters or InstanceGroups parameters, but not both.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunJobFlow service method.</param>
        /// 
        /// <returns>The response from the RunJobFlow service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RunJobFlow">REST API Reference for RunJobFlow Operation</seealso>
        RunJobFlowResponse RunJobFlow(RunJobFlowRequest request);



        /// <summary>
        /// RunJobFlow creates and starts running a new cluster (job flow). The cluster runs the
        /// steps specified. After the steps complete, the cluster stops and the HDFS partition
        /// is lost. To prevent loss of data, configure the last step of the job flow to store
        /// results in Amazon S3. If the <a>JobFlowInstancesConfig</a> <code>KeepJobFlowAliveWhenNoSteps</code>
        /// parameter is set to <code>TRUE</code>, the cluster transitions to the WAITING state
        /// rather than shutting down after the steps have completed. 
        /// 
        ///  
        /// <para>
        /// For additional protection, you can set the <a>JobFlowInstancesConfig</a> <code>TerminationProtected</code>
        /// parameter to <code>TRUE</code> to lock the cluster and prevent it from being terminated
        /// by API call, user intervention, or in the event of a job flow error.
        /// </para>
        ///  
        /// <para>
        /// A maximum of 256 steps are allowed in each job flow.
        /// </para>
        ///  
        /// <para>
        /// If your cluster is long-running (such as a Hive data warehouse) or complex, you may
        /// require more than 256 steps to process your data. You can bypass the 256-step limitation
        /// in various ways, including using the SSH shell to connect to the master node and submitting
        /// queries directly to the software running on the master node, such as Hive and Hadoop.
        /// </para>
        ///  
        /// <para>
        /// For long-running clusters, we recommend that you periodically store your results.
        /// </para>
        ///  <note> 
        /// <para>
        /// The instance fleets configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x versions. The RunJobFlow request can contain InstanceFleets
        /// parameters or InstanceGroups parameters, but not both.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunJobFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunJobFlow service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RunJobFlow">REST API Reference for RunJobFlow Operation</seealso>
        Task<RunJobFlowResponse> RunJobFlowAsync(RunJobFlowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetTerminationProtection


        /// <summary>
        /// SetTerminationProtection locks a cluster (job flow) so the EC2 instances in the cluster
        /// cannot be terminated by user intervention, an API call, or in the event of a job-flow
        /// error. The cluster still terminates upon successful completion of the job flow. Calling
        /// <code>SetTerminationProtection</code> on a cluster is similar to calling the Amazon
        /// EC2 <code>DisableAPITermination</code> API on all EC2 instances in a cluster.
        /// 
        ///  
        /// <para>
        ///  <code>SetTerminationProtection</code> is used to prevent accidental termination of
        /// a cluster and to ensure that in the event of an error, the instances persist so that
        /// you can recover any data stored in their ephemeral instance storage.
        /// </para>
        ///  
        /// <para>
        ///  To terminate a cluster that has been locked by setting <code>SetTerminationProtection</code>
        /// to <code>true</code>, you must first unlock the job flow by a subsequent call to <code>SetTerminationProtection</code>
        /// in which you set the value to <code>false</code>. 
        /// </para>
        ///  
        /// <para>
        ///  For more information, see<a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/UsingEMR_TerminationProtection.html">Managing
        /// Cluster Termination</a> in the <i>Amazon EMR Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTerminationProtection service method.</param>
        /// 
        /// <returns>The response from the SetTerminationProtection service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetTerminationProtection">REST API Reference for SetTerminationProtection Operation</seealso>
        SetTerminationProtectionResponse SetTerminationProtection(SetTerminationProtectionRequest request);



        /// <summary>
        /// SetTerminationProtection locks a cluster (job flow) so the EC2 instances in the cluster
        /// cannot be terminated by user intervention, an API call, or in the event of a job-flow
        /// error. The cluster still terminates upon successful completion of the job flow. Calling
        /// <code>SetTerminationProtection</code> on a cluster is similar to calling the Amazon
        /// EC2 <code>DisableAPITermination</code> API on all EC2 instances in a cluster.
        /// 
        ///  
        /// <para>
        ///  <code>SetTerminationProtection</code> is used to prevent accidental termination of
        /// a cluster and to ensure that in the event of an error, the instances persist so that
        /// you can recover any data stored in their ephemeral instance storage.
        /// </para>
        ///  
        /// <para>
        ///  To terminate a cluster that has been locked by setting <code>SetTerminationProtection</code>
        /// to <code>true</code>, you must first unlock the job flow by a subsequent call to <code>SetTerminationProtection</code>
        /// in which you set the value to <code>false</code>. 
        /// </para>
        ///  
        /// <para>
        ///  For more information, see<a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/UsingEMR_TerminationProtection.html">Managing
        /// Cluster Termination</a> in the <i>Amazon EMR Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTerminationProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTerminationProtection service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetTerminationProtection">REST API Reference for SetTerminationProtection Operation</seealso>
        Task<SetTerminationProtectionResponse> SetTerminationProtectionAsync(SetTerminationProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetVisibleToAllUsers


        /// <summary>
        /// <important> 
        /// <para>
        /// The SetVisibleToAllUsers parameter is no longer supported. Your cluster may be visible
        /// to all users in your account. To restrict cluster access using an IAM policy, see
        /// <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-access-iam.html">Identity
        /// and Access Management for EMR</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Sets the <a>Cluster$VisibleToAllUsers</a> value for an EMR cluster. When <code>true</code>,
        /// IAM principals in the Amazon Web Services account can perform EMR cluster actions
        /// that their IAM policies allow. When <code>false</code>, only the IAM principal that
        /// created the cluster and the Amazon Web Services account root user can perform EMR
        /// actions on the cluster, regardless of IAM permissions policies attached to other IAM
        /// principals.
        /// </para>
        ///  
        /// <para>
        /// This action works on running clusters. When you create a cluster, use the <a>RunJobFlowInput$VisibleToAllUsers</a>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/security_iam_emr-with-iam.html#security_set_visible_to_all_users">Understanding
        /// the EMR Cluster VisibleToAllUsers Setting</a> in the <i>Amazon EMRManagement Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVisibleToAllUsers service method.</param>
        /// 
        /// <returns>The response from the SetVisibleToAllUsers service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetVisibleToAllUsers">REST API Reference for SetVisibleToAllUsers Operation</seealso>
        SetVisibleToAllUsersResponse SetVisibleToAllUsers(SetVisibleToAllUsersRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// The SetVisibleToAllUsers parameter is no longer supported. Your cluster may be visible
        /// to all users in your account. To restrict cluster access using an IAM policy, see
        /// <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-access-iam.html">Identity
        /// and Access Management for EMR</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Sets the <a>Cluster$VisibleToAllUsers</a> value for an EMR cluster. When <code>true</code>,
        /// IAM principals in the Amazon Web Services account can perform EMR cluster actions
        /// that their IAM policies allow. When <code>false</code>, only the IAM principal that
        /// created the cluster and the Amazon Web Services account root user can perform EMR
        /// actions on the cluster, regardless of IAM permissions policies attached to other IAM
        /// principals.
        /// </para>
        ///  
        /// <para>
        /// This action works on running clusters. When you create a cluster, use the <a>RunJobFlowInput$VisibleToAllUsers</a>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/security_iam_emr-with-iam.html#security_set_visible_to_all_users">Understanding
        /// the EMR Cluster VisibleToAllUsers Setting</a> in the <i>Amazon EMRManagement Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVisibleToAllUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetVisibleToAllUsers service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetVisibleToAllUsers">REST API Reference for SetVisibleToAllUsers Operation</seealso>
        Task<SetVisibleToAllUsersResponse> SetVisibleToAllUsersAsync(SetVisibleToAllUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartNotebookExecution


        /// <summary>
        /// Starts a notebook execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookExecution service method.</param>
        /// 
        /// <returns>The response from the StartNotebookExecution service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/StartNotebookExecution">REST API Reference for StartNotebookExecution Operation</seealso>
        StartNotebookExecutionResponse StartNotebookExecution(StartNotebookExecutionRequest request);



        /// <summary>
        /// Starts a notebook execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartNotebookExecution service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/StartNotebookExecution">REST API Reference for StartNotebookExecution Operation</seealso>
        Task<StartNotebookExecutionResponse> StartNotebookExecutionAsync(StartNotebookExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopNotebookExecution


        /// <summary>
        /// Stops a notebook execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookExecution service method.</param>
        /// 
        /// <returns>The response from the StopNotebookExecution service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/StopNotebookExecution">REST API Reference for StopNotebookExecution Operation</seealso>
        StopNotebookExecutionResponse StopNotebookExecution(StopNotebookExecutionRequest request);



        /// <summary>
        /// Stops a notebook execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopNotebookExecution service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/StopNotebookExecution">REST API Reference for StopNotebookExecution Operation</seealso>
        Task<StopNotebookExecutionResponse> StopNotebookExecutionAsync(StopNotebookExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TerminateJobFlows


        /// <summary>
        /// TerminateJobFlows shuts a list of clusters (job flows) down. When a job flow is shut
        /// down, any step not yet completed is canceled and the EC2 instances on which the cluster
        /// is running are stopped. Any log files not already saved are uploaded to Amazon S3
        /// if a LogUri was specified when the cluster was created.
        /// 
        ///  
        /// <para>
        /// The maximum number of clusters allowed is 10. The call to <code>TerminateJobFlows</code>
        /// is asynchronous. Depending on the configuration of the cluster, it may take up to
        /// 1-5 minutes for the cluster to completely terminate and release allocated resources,
        /// such as Amazon EC2 instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateJobFlows service method.</param>
        /// 
        /// <returns>The response from the TerminateJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/TerminateJobFlows">REST API Reference for TerminateJobFlows Operation</seealso>
        TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest request);



        /// <summary>
        /// TerminateJobFlows shuts a list of clusters (job flows) down. When a job flow is shut
        /// down, any step not yet completed is canceled and the EC2 instances on which the cluster
        /// is running are stopped. Any log files not already saved are uploaded to Amazon S3
        /// if a LogUri was specified when the cluster was created.
        /// 
        ///  
        /// <para>
        /// The maximum number of clusters allowed is 10. The call to <code>TerminateJobFlows</code>
        /// is asynchronous. Depending on the configuration of the cluster, it may take up to
        /// 1-5 minutes for the cluster to completely terminate and release allocated resources,
        /// such as Amazon EC2 instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateJobFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/TerminateJobFlows">REST API Reference for TerminateJobFlows Operation</seealso>
        Task<TerminateJobFlowsResponse> TerminateJobFlowsAsync(TerminateJobFlowsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStudio


        /// <summary>
        /// Updates an Amazon EMR Studio configuration, including attributes such as name, description,
        /// and subnets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudio service method.</param>
        /// 
        /// <returns>The response from the UpdateStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/UpdateStudio">REST API Reference for UpdateStudio Operation</seealso>
        UpdateStudioResponse UpdateStudio(UpdateStudioRequest request);



        /// <summary>
        /// Updates an Amazon EMR Studio configuration, including attributes such as name, description,
        /// and subnets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/UpdateStudio">REST API Reference for UpdateStudio Operation</seealso>
        Task<UpdateStudioResponse> UpdateStudioAsync(UpdateStudioRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStudioSessionMapping


        /// <summary>
        /// Updates the session policy attached to the user or group for the specified Amazon
        /// EMR Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudioSessionMapping service method.</param>
        /// 
        /// <returns>The response from the UpdateStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/UpdateStudioSessionMapping">REST API Reference for UpdateStudioSessionMapping Operation</seealso>
        UpdateStudioSessionMappingResponse UpdateStudioSessionMapping(UpdateStudioSessionMappingRequest request);



        /// <summary>
        /// Updates the session policy attached to the user or group for the specified Amazon
        /// EMR Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudioSessionMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/UpdateStudioSessionMapping">REST API Reference for UpdateStudioSessionMapping Operation</seealso>
        Task<UpdateStudioSessionMappingResponse> UpdateStudioSessionMappingAsync(UpdateStudioSessionMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}