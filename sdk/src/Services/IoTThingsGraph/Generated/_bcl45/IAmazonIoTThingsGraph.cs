/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTThingsGraph.Model;

namespace Amazon.IoTThingsGraph
{
    /// <summary>
    /// Interface for accessing IoTThingsGraph
    ///
    /// AWS IoT Things Graph 
    /// <para>
    /// AWS IoT Things Graph provides an integrated set of tools that enable developers to
    /// connect devices and services that use different standards, such as units of measure
    /// and communication protocols. AWS IoT Things Graph makes it possible to build IoT applications
    /// with little to no code by connecting devices and services and defining how they interact
    /// at an abstract level.
    /// </para>
    ///  
    /// <para>
    /// For more information about how AWS IoT Things Graph works, see the <a href="https://docs.aws.amazon.com/thingsgraph/latest/ug/iot-tg-whatis.html">User
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonIoTThingsGraph : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTThingsGraphPaginatorFactory Paginators { get; }

        
        #region  AssociateEntityToThing


        /// <summary>
        /// Associates a device with a concrete thing that is in the user's registry.
        /// 
        ///  
        /// <para>
        /// A thing can be associated with only one device at a time. If you associate a thing
        /// with a new device id, its previous association will be removed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEntityToThing service method.</param>
        /// 
        /// <returns>The response from the AssociateEntityToThing service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/AssociateEntityToThing">REST API Reference for AssociateEntityToThing Operation</seealso>
        AssociateEntityToThingResponse AssociateEntityToThing(AssociateEntityToThingRequest request);



        /// <summary>
        /// Associates a device with a concrete thing that is in the user's registry.
        /// 
        ///  
        /// <para>
        /// A thing can be associated with only one device at a time. If you associate a thing
        /// with a new device id, its previous association will be removed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEntityToThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateEntityToThing service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/AssociateEntityToThing">REST API Reference for AssociateEntityToThing Operation</seealso>
        Task<AssociateEntityToThingResponse> AssociateEntityToThingAsync(AssociateEntityToThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFlowTemplate


        /// <summary>
        /// Creates a workflow template. Workflows can be created only in the user's namespace.
        /// (The public namespace contains only entities.) The workflow can contain only entities
        /// in the specified namespace. The workflow is validated against the entities in the
        /// latest version of the user's namespace unless another namespace version is specified
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateFlowTemplate">REST API Reference for CreateFlowTemplate Operation</seealso>
        CreateFlowTemplateResponse CreateFlowTemplate(CreateFlowTemplateRequest request);



        /// <summary>
        /// Creates a workflow template. Workflows can be created only in the user's namespace.
        /// (The public namespace contains only entities.) The workflow can contain only entities
        /// in the specified namespace. The workflow is validated against the entities in the
        /// latest version of the user's namespace unless another namespace version is specified
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateFlowTemplate">REST API Reference for CreateFlowTemplate Operation</seealso>
        Task<CreateFlowTemplateResponse> CreateFlowTemplateAsync(CreateFlowTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSystemInstance


        /// <summary>
        /// Creates a system instance. 
        /// 
        ///  
        /// <para>
        /// This action validates the system instance, prepares the deployment-related resources.
        /// For Greengrass deployments, it updates the Greengrass group that is specified by the
        /// <code>greengrassGroupName</code> parameter. It also adds a file to the S3 bucket specified
        /// by the <code>s3BucketName</code> parameter. You need to call <code>DeploySystemInstance</code>
        /// after running this action.
        /// </para>
        ///  
        /// <para>
        /// For Greengrass deployments, since this action modifies and adds resources to a Greengrass
        /// group and an S3 bucket on the caller's behalf, the calling identity must have write
        /// permissions to both the specified Greengrass group and S3 bucket. Otherwise, the call
        /// will fail with an authorization error.
        /// </para>
        ///  
        /// <para>
        /// For cloud deployments, this action requires a <code>flowActionsRoleArn</code> value.
        /// This is an IAM role that has permissions to access AWS services, such as AWS Lambda
        /// and AWS IoT, that the flow uses when it executes.
        /// </para>
        ///  
        /// <para>
        /// If the definition document doesn't specify a version of the user's namespace, the
        /// latest version will be used by default.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSystemInstance service method.</param>
        /// 
        /// <returns>The response from the CreateSystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemInstance">REST API Reference for CreateSystemInstance Operation</seealso>
        CreateSystemInstanceResponse CreateSystemInstance(CreateSystemInstanceRequest request);



        /// <summary>
        /// Creates a system instance. 
        /// 
        ///  
        /// <para>
        /// This action validates the system instance, prepares the deployment-related resources.
        /// For Greengrass deployments, it updates the Greengrass group that is specified by the
        /// <code>greengrassGroupName</code> parameter. It also adds a file to the S3 bucket specified
        /// by the <code>s3BucketName</code> parameter. You need to call <code>DeploySystemInstance</code>
        /// after running this action.
        /// </para>
        ///  
        /// <para>
        /// For Greengrass deployments, since this action modifies and adds resources to a Greengrass
        /// group and an S3 bucket on the caller's behalf, the calling identity must have write
        /// permissions to both the specified Greengrass group and S3 bucket. Otherwise, the call
        /// will fail with an authorization error.
        /// </para>
        ///  
        /// <para>
        /// For cloud deployments, this action requires a <code>flowActionsRoleArn</code> value.
        /// This is an IAM role that has permissions to access AWS services, such as AWS Lambda
        /// and AWS IoT, that the flow uses when it executes.
        /// </para>
        ///  
        /// <para>
        /// If the definition document doesn't specify a version of the user's namespace, the
        /// latest version will be used by default.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSystemInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemInstance">REST API Reference for CreateSystemInstance Operation</seealso>
        Task<CreateSystemInstanceResponse> CreateSystemInstanceAsync(CreateSystemInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSystemTemplate


        /// <summary>
        /// Creates a system. The system is validated against the entities in the latest version
        /// of the user's namespace unless another namespace version is specified in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSystemTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemTemplate">REST API Reference for CreateSystemTemplate Operation</seealso>
        CreateSystemTemplateResponse CreateSystemTemplate(CreateSystemTemplateRequest request);



        /// <summary>
        /// Creates a system. The system is validated against the entities in the latest version
        /// of the user's namespace unless another namespace version is specified in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSystemTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemTemplate">REST API Reference for CreateSystemTemplate Operation</seealso>
        Task<CreateSystemTemplateResponse> CreateSystemTemplateAsync(CreateSystemTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFlowTemplate


        /// <summary>
        /// Deletes a workflow. Any new system or deployment that contains this workflow will
        /// fail to update or deploy. Existing deployments that contain the workflow will continue
        /// to run (since they use a snapshot of the workflow taken at the time of deployment).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteFlowTemplate">REST API Reference for DeleteFlowTemplate Operation</seealso>
        DeleteFlowTemplateResponse DeleteFlowTemplate(DeleteFlowTemplateRequest request);



        /// <summary>
        /// Deletes a workflow. Any new system or deployment that contains this workflow will
        /// fail to update or deploy. Existing deployments that contain the workflow will continue
        /// to run (since they use a snapshot of the workflow taken at the time of deployment).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteFlowTemplate">REST API Reference for DeleteFlowTemplate Operation</seealso>
        Task<DeleteFlowTemplateResponse> DeleteFlowTemplateAsync(DeleteFlowTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteNamespace


        /// <summary>
        /// Deletes the specified namespace. This action deletes all of the entities in the namespace.
        /// Delete the systems and flows that use entities in the namespace before performing
        /// this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request);



        /// <summary>
        /// Deletes the specified namespace. This action deletes all of the entities in the namespace.
        /// Delete the systems and flows that use entities in the namespace before performing
        /// this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSystemInstance


        /// <summary>
        /// Deletes a system instance. Only system instances that have never been deployed, or
        /// that have been undeployed can be deleted.
        /// 
        ///  
        /// <para>
        /// Users can create a new system instance that has the same ID as a deleted system instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystemInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteSystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemInstance">REST API Reference for DeleteSystemInstance Operation</seealso>
        DeleteSystemInstanceResponse DeleteSystemInstance(DeleteSystemInstanceRequest request);



        /// <summary>
        /// Deletes a system instance. Only system instances that have never been deployed, or
        /// that have been undeployed can be deleted.
        /// 
        ///  
        /// <para>
        /// Users can create a new system instance that has the same ID as a deleted system instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystemInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemInstance">REST API Reference for DeleteSystemInstance Operation</seealso>
        Task<DeleteSystemInstanceResponse> DeleteSystemInstanceAsync(DeleteSystemInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSystemTemplate


        /// <summary>
        /// Deletes a system. New deployments can't contain the system after its deletion. Existing
        /// deployments that contain the system will continue to work because they use a snapshot
        /// of the system that is taken when it is deployed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystemTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemTemplate">REST API Reference for DeleteSystemTemplate Operation</seealso>
        DeleteSystemTemplateResponse DeleteSystemTemplate(DeleteSystemTemplateRequest request);



        /// <summary>
        /// Deletes a system. New deployments can't contain the system after its deletion. Existing
        /// deployments that contain the system will continue to work because they use a snapshot
        /// of the system that is taken when it is deployed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystemTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemTemplate">REST API Reference for DeleteSystemTemplate Operation</seealso>
        Task<DeleteSystemTemplateResponse> DeleteSystemTemplateAsync(DeleteSystemTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeploySystemInstance


        /// <summary>
        /// <b>Greengrass and Cloud Deployments</b> 
        /// 
        ///  
        /// <para>
        /// Deploys the system instance to the target specified in <code>CreateSystemInstance</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Greengrass Deployments</b> 
        /// </para>
        ///  
        /// <para>
        /// If the system or any workflows and entities have been updated before this action is
        /// called, then the deployment will create a new Amazon Simple Storage Service resource
        /// file and then deploy it.
        /// </para>
        ///  
        /// <para>
        /// Since this action creates a Greengrass deployment on the caller's behalf, the calling
        /// identity must have write permissions to the specified Greengrass group. Otherwise,
        /// the call will fail with an authorization error.
        /// </para>
        ///  
        /// <para>
        /// For information about the artifacts that get added to your Greengrass core device
        /// when you use this API, see <a href="https://docs.aws.amazon.com/thingsgraph/latest/ug/iot-tg-greengrass.html">AWS
        /// IoT Things Graph and AWS IoT Greengrass</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeploySystemInstance service method.</param>
        /// 
        /// <returns>The response from the DeploySystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeploySystemInstance">REST API Reference for DeploySystemInstance Operation</seealso>
        DeploySystemInstanceResponse DeploySystemInstance(DeploySystemInstanceRequest request);



        /// <summary>
        /// <b>Greengrass and Cloud Deployments</b> 
        /// 
        ///  
        /// <para>
        /// Deploys the system instance to the target specified in <code>CreateSystemInstance</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Greengrass Deployments</b> 
        /// </para>
        ///  
        /// <para>
        /// If the system or any workflows and entities have been updated before this action is
        /// called, then the deployment will create a new Amazon Simple Storage Service resource
        /// file and then deploy it.
        /// </para>
        ///  
        /// <para>
        /// Since this action creates a Greengrass deployment on the caller's behalf, the calling
        /// identity must have write permissions to the specified Greengrass group. Otherwise,
        /// the call will fail with an authorization error.
        /// </para>
        ///  
        /// <para>
        /// For information about the artifacts that get added to your Greengrass core device
        /// when you use this API, see <a href="https://docs.aws.amazon.com/thingsgraph/latest/ug/iot-tg-greengrass.html">AWS
        /// IoT Things Graph and AWS IoT Greengrass</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeploySystemInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeploySystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeploySystemInstance">REST API Reference for DeploySystemInstance Operation</seealso>
        Task<DeploySystemInstanceResponse> DeploySystemInstanceAsync(DeploySystemInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeprecateFlowTemplate


        /// <summary>
        /// Deprecates the specified workflow. This action marks the workflow for deletion. Deprecated
        /// flows can't be deployed, but existing deployments will continue to run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateFlowTemplate service method.</param>
        /// 
        /// <returns>The response from the DeprecateFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateFlowTemplate">REST API Reference for DeprecateFlowTemplate Operation</seealso>
        DeprecateFlowTemplateResponse DeprecateFlowTemplate(DeprecateFlowTemplateRequest request);



        /// <summary>
        /// Deprecates the specified workflow. This action marks the workflow for deletion. Deprecated
        /// flows can't be deployed, but existing deployments will continue to run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateFlowTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeprecateFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateFlowTemplate">REST API Reference for DeprecateFlowTemplate Operation</seealso>
        Task<DeprecateFlowTemplateResponse> DeprecateFlowTemplateAsync(DeprecateFlowTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeprecateSystemTemplate


        /// <summary>
        /// Deprecates the specified system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateSystemTemplate service method.</param>
        /// 
        /// <returns>The response from the DeprecateSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateSystemTemplate">REST API Reference for DeprecateSystemTemplate Operation</seealso>
        DeprecateSystemTemplateResponse DeprecateSystemTemplate(DeprecateSystemTemplateRequest request);



        /// <summary>
        /// Deprecates the specified system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateSystemTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeprecateSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateSystemTemplate">REST API Reference for DeprecateSystemTemplate Operation</seealso>
        Task<DeprecateSystemTemplateResponse> DeprecateSystemTemplateAsync(DeprecateSystemTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeNamespace


        /// <summary>
        /// Gets the latest version of the user's namespace and the public version that it is
        /// tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNamespace service method.</param>
        /// 
        /// <returns>The response from the DescribeNamespace service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DescribeNamespace">REST API Reference for DescribeNamespace Operation</seealso>
        DescribeNamespaceResponse DescribeNamespace(DescribeNamespaceRequest request);



        /// <summary>
        /// Gets the latest version of the user's namespace and the public version that it is
        /// tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNamespace service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DescribeNamespace">REST API Reference for DescribeNamespace Operation</seealso>
        Task<DescribeNamespaceResponse> DescribeNamespaceAsync(DescribeNamespaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DissociateEntityFromThing


        /// <summary>
        /// Dissociates a device entity from a concrete thing. The action takes only the type
        /// of the entity that you need to dissociate because only one entity of a particular
        /// type can be associated with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DissociateEntityFromThing service method.</param>
        /// 
        /// <returns>The response from the DissociateEntityFromThing service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DissociateEntityFromThing">REST API Reference for DissociateEntityFromThing Operation</seealso>
        DissociateEntityFromThingResponse DissociateEntityFromThing(DissociateEntityFromThingRequest request);



        /// <summary>
        /// Dissociates a device entity from a concrete thing. The action takes only the type
        /// of the entity that you need to dissociate because only one entity of a particular
        /// type can be associated with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DissociateEntityFromThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DissociateEntityFromThing service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DissociateEntityFromThing">REST API Reference for DissociateEntityFromThing Operation</seealso>
        Task<DissociateEntityFromThingResponse> DissociateEntityFromThingAsync(DissociateEntityFromThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEntities


        /// <summary>
        /// Gets definitions of the specified entities. Uses the latest version of the user's
        /// namespace by default. This API returns the following TDM entities.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Properties
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// States
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Events
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Actions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Capabilities
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Mappings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Devices
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Device Models
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Services
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This action doesn't return definitions for systems, flows, and deployments.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntities service method.</param>
        /// 
        /// <returns>The response from the GetEntities service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetEntities">REST API Reference for GetEntities Operation</seealso>
        GetEntitiesResponse GetEntities(GetEntitiesRequest request);



        /// <summary>
        /// Gets definitions of the specified entities. Uses the latest version of the user's
        /// namespace by default. This API returns the following TDM entities.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Properties
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// States
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Events
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Actions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Capabilities
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Mappings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Devices
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Device Models
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Services
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This action doesn't return definitions for systems, flows, and deployments.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEntities service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetEntities">REST API Reference for GetEntities Operation</seealso>
        Task<GetEntitiesResponse> GetEntitiesAsync(GetEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFlowTemplate


        /// <summary>
        /// Gets the latest version of the <code>DefinitionDocument</code> and <code>FlowTemplateSummary</code>
        /// for the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplate service method.</param>
        /// 
        /// <returns>The response from the GetFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplate">REST API Reference for GetFlowTemplate Operation</seealso>
        GetFlowTemplateResponse GetFlowTemplate(GetFlowTemplateRequest request);



        /// <summary>
        /// Gets the latest version of the <code>DefinitionDocument</code> and <code>FlowTemplateSummary</code>
        /// for the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplate">REST API Reference for GetFlowTemplate Operation</seealso>
        Task<GetFlowTemplateResponse> GetFlowTemplateAsync(GetFlowTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFlowTemplateRevisions


        /// <summary>
        /// Gets revisions of the specified workflow. Only the last 100 revisions are stored.
        /// If the workflow has been deprecated, this action will return revisions that occurred
        /// before the deprecation. This action won't work for workflows that have been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplateRevisions service method.</param>
        /// 
        /// <returns>The response from the GetFlowTemplateRevisions service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplateRevisions">REST API Reference for GetFlowTemplateRevisions Operation</seealso>
        GetFlowTemplateRevisionsResponse GetFlowTemplateRevisions(GetFlowTemplateRevisionsRequest request);



        /// <summary>
        /// Gets revisions of the specified workflow. Only the last 100 revisions are stored.
        /// If the workflow has been deprecated, this action will return revisions that occurred
        /// before the deprecation. This action won't work for workflows that have been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplateRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFlowTemplateRevisions service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplateRevisions">REST API Reference for GetFlowTemplateRevisions Operation</seealso>
        Task<GetFlowTemplateRevisionsResponse> GetFlowTemplateRevisionsAsync(GetFlowTemplateRevisionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetNamespaceDeletionStatus


        /// <summary>
        /// Gets the status of a namespace deletion task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespaceDeletionStatus service method.</param>
        /// 
        /// <returns>The response from the GetNamespaceDeletionStatus service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetNamespaceDeletionStatus">REST API Reference for GetNamespaceDeletionStatus Operation</seealso>
        GetNamespaceDeletionStatusResponse GetNamespaceDeletionStatus(GetNamespaceDeletionStatusRequest request);



        /// <summary>
        /// Gets the status of a namespace deletion task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespaceDeletionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNamespaceDeletionStatus service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetNamespaceDeletionStatus">REST API Reference for GetNamespaceDeletionStatus Operation</seealso>
        Task<GetNamespaceDeletionStatusResponse> GetNamespaceDeletionStatusAsync(GetNamespaceDeletionStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSystemInstance


        /// <summary>
        /// Gets a system instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystemInstance service method.</param>
        /// 
        /// <returns>The response from the GetSystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemInstance">REST API Reference for GetSystemInstance Operation</seealso>
        GetSystemInstanceResponse GetSystemInstance(GetSystemInstanceRequest request);



        /// <summary>
        /// Gets a system instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystemInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemInstance">REST API Reference for GetSystemInstance Operation</seealso>
        Task<GetSystemInstanceResponse> GetSystemInstanceAsync(GetSystemInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSystemTemplate


        /// <summary>
        /// Gets a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplate service method.</param>
        /// 
        /// <returns>The response from the GetSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplate">REST API Reference for GetSystemTemplate Operation</seealso>
        GetSystemTemplateResponse GetSystemTemplate(GetSystemTemplateRequest request);



        /// <summary>
        /// Gets a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplate">REST API Reference for GetSystemTemplate Operation</seealso>
        Task<GetSystemTemplateResponse> GetSystemTemplateAsync(GetSystemTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSystemTemplateRevisions


        /// <summary>
        /// Gets revisions made to the specified system template. Only the previous 100 revisions
        /// are stored. If the system has been deprecated, this action will return the revisions
        /// that occurred before its deprecation. This action won't work with systems that have
        /// been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplateRevisions service method.</param>
        /// 
        /// <returns>The response from the GetSystemTemplateRevisions service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplateRevisions">REST API Reference for GetSystemTemplateRevisions Operation</seealso>
        GetSystemTemplateRevisionsResponse GetSystemTemplateRevisions(GetSystemTemplateRevisionsRequest request);



        /// <summary>
        /// Gets revisions made to the specified system template. Only the previous 100 revisions
        /// are stored. If the system has been deprecated, this action will return the revisions
        /// that occurred before its deprecation. This action won't work with systems that have
        /// been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplateRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSystemTemplateRevisions service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplateRevisions">REST API Reference for GetSystemTemplateRevisions Operation</seealso>
        Task<GetSystemTemplateRevisionsResponse> GetSystemTemplateRevisionsAsync(GetSystemTemplateRevisionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUploadStatus


        /// <summary>
        /// Gets the status of the specified upload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadStatus service method.</param>
        /// 
        /// <returns>The response from the GetUploadStatus service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetUploadStatus">REST API Reference for GetUploadStatus Operation</seealso>
        GetUploadStatusResponse GetUploadStatus(GetUploadStatusRequest request);



        /// <summary>
        /// Gets the status of the specified upload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUploadStatus service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetUploadStatus">REST API Reference for GetUploadStatus Operation</seealso>
        Task<GetUploadStatusResponse> GetUploadStatusAsync(GetUploadStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFlowExecutionMessages


        /// <summary>
        /// Returns a list of objects that contain information about events in a flow execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlowExecutionMessages service method.</param>
        /// 
        /// <returns>The response from the ListFlowExecutionMessages service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListFlowExecutionMessages">REST API Reference for ListFlowExecutionMessages Operation</seealso>
        ListFlowExecutionMessagesResponse ListFlowExecutionMessages(ListFlowExecutionMessagesRequest request);



        /// <summary>
        /// Returns a list of objects that contain information about events in a flow execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlowExecutionMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFlowExecutionMessages service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListFlowExecutionMessages">REST API Reference for ListFlowExecutionMessages Operation</seealso>
        Task<ListFlowExecutionMessagesResponse> ListFlowExecutionMessagesAsync(ListFlowExecutionMessagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags on an AWS IoT Things Graph resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists all tags on an AWS IoT Things Graph resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchEntities


        /// <summary>
        /// Searches for entities of the specified type. You can search for entities in your namespace
        /// and the public namespace that you're tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchEntities service method.</param>
        /// 
        /// <returns>The response from the SearchEntities service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchEntities">REST API Reference for SearchEntities Operation</seealso>
        SearchEntitiesResponse SearchEntities(SearchEntitiesRequest request);



        /// <summary>
        /// Searches for entities of the specified type. You can search for entities in your namespace
        /// and the public namespace that you're tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchEntities service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchEntities">REST API Reference for SearchEntities Operation</seealso>
        Task<SearchEntitiesResponse> SearchEntitiesAsync(SearchEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchFlowExecutions


        /// <summary>
        /// Searches for AWS IoT Things Graph workflow execution instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowExecutions service method.</param>
        /// 
        /// <returns>The response from the SearchFlowExecutions service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowExecutions">REST API Reference for SearchFlowExecutions Operation</seealso>
        SearchFlowExecutionsResponse SearchFlowExecutions(SearchFlowExecutionsRequest request);



        /// <summary>
        /// Searches for AWS IoT Things Graph workflow execution instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchFlowExecutions service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowExecutions">REST API Reference for SearchFlowExecutions Operation</seealso>
        Task<SearchFlowExecutionsResponse> SearchFlowExecutionsAsync(SearchFlowExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchFlowTemplates


        /// <summary>
        /// Searches for summary information about workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowTemplates service method.</param>
        /// 
        /// <returns>The response from the SearchFlowTemplates service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowTemplates">REST API Reference for SearchFlowTemplates Operation</seealso>
        SearchFlowTemplatesResponse SearchFlowTemplates(SearchFlowTemplatesRequest request);



        /// <summary>
        /// Searches for summary information about workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchFlowTemplates service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowTemplates">REST API Reference for SearchFlowTemplates Operation</seealso>
        Task<SearchFlowTemplatesResponse> SearchFlowTemplatesAsync(SearchFlowTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchSystemInstances


        /// <summary>
        /// Searches for system instances in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemInstances service method.</param>
        /// 
        /// <returns>The response from the SearchSystemInstances service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemInstances">REST API Reference for SearchSystemInstances Operation</seealso>
        SearchSystemInstancesResponse SearchSystemInstances(SearchSystemInstancesRequest request);



        /// <summary>
        /// Searches for system instances in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchSystemInstances service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemInstances">REST API Reference for SearchSystemInstances Operation</seealso>
        Task<SearchSystemInstancesResponse> SearchSystemInstancesAsync(SearchSystemInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchSystemTemplates


        /// <summary>
        /// Searches for summary information about systems in the user's account. You can filter
        /// by the ID of a workflow to return only systems that use the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemTemplates service method.</param>
        /// 
        /// <returns>The response from the SearchSystemTemplates service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemTemplates">REST API Reference for SearchSystemTemplates Operation</seealso>
        SearchSystemTemplatesResponse SearchSystemTemplates(SearchSystemTemplatesRequest request);



        /// <summary>
        /// Searches for summary information about systems in the user's account. You can filter
        /// by the ID of a workflow to return only systems that use the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchSystemTemplates service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemTemplates">REST API Reference for SearchSystemTemplates Operation</seealso>
        Task<SearchSystemTemplatesResponse> SearchSystemTemplatesAsync(SearchSystemTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchThings


        /// <summary>
        /// Searches for things associated with the specified entity. You can search by both device
        /// and device model.
        /// 
        ///  
        /// <para>
        /// For example, if two different devices, camera1 and camera2, implement the camera device
        /// model, the user can associate thing1 to camera1 and thing2 to camera2. <code>SearchThings(camera2)</code>
        /// will return only thing2, but <code>SearchThings(camera)</code> will return both thing1
        /// and thing2.
        /// </para>
        ///  
        /// <para>
        /// This action searches for exact matches and doesn't perform partial text matching.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchThings service method.</param>
        /// 
        /// <returns>The response from the SearchThings service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchThings">REST API Reference for SearchThings Operation</seealso>
        SearchThingsResponse SearchThings(SearchThingsRequest request);



        /// <summary>
        /// Searches for things associated with the specified entity. You can search by both device
        /// and device model.
        /// 
        ///  
        /// <para>
        /// For example, if two different devices, camera1 and camera2, implement the camera device
        /// model, the user can associate thing1 to camera1 and thing2 to camera2. <code>SearchThings(camera2)</code>
        /// will return only thing2, but <code>SearchThings(camera)</code> will return both thing1
        /// and thing2.
        /// </para>
        ///  
        /// <para>
        /// This action searches for exact matches and doesn't perform partial text matching.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchThings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchThings service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchThings">REST API Reference for SearchThings Operation</seealso>
        Task<SearchThingsResponse> SearchThingsAsync(SearchThingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Creates a tag for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Creates a tag for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UndeploySystemInstance


        /// <summary>
        /// Removes a system instance from its target (Cloud or Greengrass).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UndeploySystemInstance service method.</param>
        /// 
        /// <returns>The response from the UndeploySystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UndeploySystemInstance">REST API Reference for UndeploySystemInstance Operation</seealso>
        UndeploySystemInstanceResponse UndeploySystemInstance(UndeploySystemInstanceRequest request);



        /// <summary>
        /// Removes a system instance from its target (Cloud or Greengrass).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UndeploySystemInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UndeploySystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UndeploySystemInstance">REST API Reference for UndeploySystemInstance Operation</seealso>
        Task<UndeploySystemInstanceResponse> UndeploySystemInstanceAsync(UndeploySystemInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes a tag from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFlowTemplate


        /// <summary>
        /// Updates the specified workflow. All deployed systems and system instances that use
        /// the workflow will see the changes in the flow when it is redeployed. If you don't
        /// want this behavior, copy the workflow (creating a new workflow with a different ID),
        /// and update the copy. The workflow can contain only entities in the specified namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateFlowTemplate">REST API Reference for UpdateFlowTemplate Operation</seealso>
        UpdateFlowTemplateResponse UpdateFlowTemplate(UpdateFlowTemplateRequest request);



        /// <summary>
        /// Updates the specified workflow. All deployed systems and system instances that use
        /// the workflow will see the changes in the flow when it is redeployed. If you don't
        /// want this behavior, copy the workflow (creating a new workflow with a different ID),
        /// and update the copy. The workflow can contain only entities in the specified namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateFlowTemplate">REST API Reference for UpdateFlowTemplate Operation</seealso>
        Task<UpdateFlowTemplateResponse> UpdateFlowTemplateAsync(UpdateFlowTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSystemTemplate


        /// <summary>
        /// Updates the specified system. You don't need to run this action after updating a workflow.
        /// Any deployment that uses the system will see the changes in the system when it is
        /// redeployed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSystemTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateSystemTemplate">REST API Reference for UpdateSystemTemplate Operation</seealso>
        UpdateSystemTemplateResponse UpdateSystemTemplate(UpdateSystemTemplateRequest request);



        /// <summary>
        /// Updates the specified system. You don't need to run this action after updating a workflow.
        /// Any deployment that uses the system will see the changes in the system when it is
        /// redeployed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSystemTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateSystemTemplate">REST API Reference for UpdateSystemTemplate Operation</seealso>
        Task<UpdateSystemTemplateResponse> UpdateSystemTemplateAsync(UpdateSystemTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UploadEntityDefinitions


        /// <summary>
        /// Asynchronously uploads one or more entity definitions to the user's namespace. The
        /// <code>document</code> parameter is required if <code>syncWithPublicNamespace</code>
        /// and <code>deleteExistingEntites</code> are false. If the <code>syncWithPublicNamespace</code>
        /// parameter is set to <code>true</code>, the user's namespace will synchronize with
        /// the latest version of the public namespace. If <code>deprecateExistingEntities</code>
        /// is set to true, all entities in the latest version will be deleted before the new
        /// <code>DefinitionDocument</code> is uploaded.
        /// 
        ///  
        /// <para>
        /// When a user uploads entity definitions for the first time, the service creates a new
        /// namespace for the user. The new namespace tracks the public namespace. Currently users
        /// can have only one namespace. The namespace version increments whenever a user uploads
        /// entity definitions that are backwards-incompatible and whenever a user sets the <code>syncWithPublicNamespace</code>
        /// parameter or the <code>deprecateExistingEntities</code> parameter to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// The IDs for all of the entities should be in URN format. Each entity must be in the
        /// user's namespace. Users can't create entities in the public namespace, but entity
        /// definitions can refer to entities in the public namespace.
        /// </para>
        ///  
        /// <para>
        /// Valid entities are <code>Device</code>, <code>DeviceModel</code>, <code>Service</code>,
        /// <code>Capability</code>, <code>State</code>, <code>Action</code>, <code>Event</code>,
        /// <code>Property</code>, <code>Mapping</code>, <code>Enum</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadEntityDefinitions service method.</param>
        /// 
        /// <returns>The response from the UploadEntityDefinitions service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UploadEntityDefinitions">REST API Reference for UploadEntityDefinitions Operation</seealso>
        UploadEntityDefinitionsResponse UploadEntityDefinitions(UploadEntityDefinitionsRequest request);



        /// <summary>
        /// Asynchronously uploads one or more entity definitions to the user's namespace. The
        /// <code>document</code> parameter is required if <code>syncWithPublicNamespace</code>
        /// and <code>deleteExistingEntites</code> are false. If the <code>syncWithPublicNamespace</code>
        /// parameter is set to <code>true</code>, the user's namespace will synchronize with
        /// the latest version of the public namespace. If <code>deprecateExistingEntities</code>
        /// is set to true, all entities in the latest version will be deleted before the new
        /// <code>DefinitionDocument</code> is uploaded.
        /// 
        ///  
        /// <para>
        /// When a user uploads entity definitions for the first time, the service creates a new
        /// namespace for the user. The new namespace tracks the public namespace. Currently users
        /// can have only one namespace. The namespace version increments whenever a user uploads
        /// entity definitions that are backwards-incompatible and whenever a user sets the <code>syncWithPublicNamespace</code>
        /// parameter or the <code>deprecateExistingEntities</code> parameter to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// The IDs for all of the entities should be in URN format. Each entity must be in the
        /// user's namespace. Users can't create entities in the public namespace, but entity
        /// definitions can refer to entities in the public namespace.
        /// </para>
        ///  
        /// <para>
        /// Valid entities are <code>Device</code>, <code>DeviceModel</code>, <code>Service</code>,
        /// <code>Capability</code>, <code>State</code>, <code>Action</code>, <code>Event</code>,
        /// <code>Property</code>, <code>Mapping</code>, <code>Enum</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadEntityDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UploadEntityDefinitions service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UploadEntityDefinitions">REST API Reference for UploadEntityDefinitions Operation</seealso>
        Task<UploadEntityDefinitionsResponse> UploadEntityDefinitionsAsync(UploadEntityDefinitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}