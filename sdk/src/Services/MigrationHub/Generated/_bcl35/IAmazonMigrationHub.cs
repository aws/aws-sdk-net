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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MigrationHub.Model;

#pragma warning disable CS1570
namespace Amazon.MigrationHub
{
    /// <summary>
    /// <para>Interface for accessing MigrationHub</para>
    ///
    /// The AWS Migration Hub API methods help to obtain server and application migration
    /// status and integrate your resource-specific migration tool by providing a programmatic
    /// interface to Migration Hub.
    /// 
    ///  
    /// <para>
    /// Remember that you must set your AWS Migration Hub home region before you call any
    /// of these APIs, or a <c>HomeRegionNotSetException</c> error will be returned. Also,
    /// you must make the API calls while in your home region.
    /// </para>
    /// </summary>
    public partial interface IAmazonMigrationHub : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMigrationHubPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateCreatedArtifact


        /// <summary>
        /// Associates a created artifact of an AWS cloud resource, the target receiving the migration,
        /// with the migration task performed by a migration tool. This API has the following
        /// traits:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Migration tools can call the <c>AssociateCreatedArtifact</c> operation to indicate
        /// which AWS artifact is associated with a migration task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The created artifact name must be provided in ARN (Amazon Resource Name) format which
        /// will contain information about type and region; for example: <c>arn:aws:ec2:us-east-1:488216288981:image/ami-6d0ba87b</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Examples of the AWS resource behind the created artifact are, AMI's, EC2 instance,
        /// or DMS endpoint, etc.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCreatedArtifact service method.</param>
        /// 
        /// <returns>The response from the AssociateCreatedArtifact service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <c>DryRun</c>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <c>DryRun</c> flag
        /// is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateCreatedArtifact">REST API Reference for AssociateCreatedArtifact Operation</seealso>
        AssociateCreatedArtifactResponse AssociateCreatedArtifact(AssociateCreatedArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateCreatedArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateCreatedArtifact operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateCreatedArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateCreatedArtifact">REST API Reference for AssociateCreatedArtifact Operation</seealso>
        IAsyncResult BeginAssociateCreatedArtifact(AssociateCreatedArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateCreatedArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateCreatedArtifact.</param>
        /// 
        /// <returns>Returns a  AssociateCreatedArtifactResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateCreatedArtifact">REST API Reference for AssociateCreatedArtifact Operation</seealso>
        AssociateCreatedArtifactResponse EndAssociateCreatedArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateDiscoveredResource


        /// <summary>
        /// Associates a discovered resource ID from Application Discovery Service with a migration
        /// task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDiscoveredResource service method.</param>
        /// 
        /// <returns>The response from the AssociateDiscoveredResource service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <c>DryRun</c>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.PolicyErrorException">
        /// Exception raised when there are problems accessing Application Discovery Service (Application
        /// Discovery Service); most likely due to a misconfigured policy or the <c>migrationhub-discovery</c>
        /// role is missing or not configured correctly.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <c>DryRun</c> flag
        /// is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateDiscoveredResource">REST API Reference for AssociateDiscoveredResource Operation</seealso>
        AssociateDiscoveredResourceResponse AssociateDiscoveredResource(AssociateDiscoveredResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDiscoveredResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDiscoveredResource operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDiscoveredResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateDiscoveredResource">REST API Reference for AssociateDiscoveredResource Operation</seealso>
        IAsyncResult BeginAssociateDiscoveredResource(AssociateDiscoveredResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDiscoveredResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDiscoveredResource.</param>
        /// 
        /// <returns>Returns a  AssociateDiscoveredResourceResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateDiscoveredResource">REST API Reference for AssociateDiscoveredResource Operation</seealso>
        AssociateDiscoveredResourceResponse EndAssociateDiscoveredResource(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateSourceResource


        /// <summary>
        /// Associates a source resource with a migration task. For example, the source resource
        /// can be a source server, an application, or a migration wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceResource service method.</param>
        /// 
        /// <returns>The response from the AssociateSourceResource service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <c>DryRun</c>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <c>DryRun</c> flag
        /// is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateSourceResource">REST API Reference for AssociateSourceResource Operation</seealso>
        AssociateSourceResourceResponse AssociateSourceResource(AssociateSourceResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSourceResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceResource operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSourceResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateSourceResource">REST API Reference for AssociateSourceResource Operation</seealso>
        IAsyncResult BeginAssociateSourceResource(AssociateSourceResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSourceResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSourceResource.</param>
        /// 
        /// <returns>Returns a  AssociateSourceResourceResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateSourceResource">REST API Reference for AssociateSourceResource Operation</seealso>
        AssociateSourceResourceResponse EndAssociateSourceResource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProgressUpdateStream


        /// <summary>
        /// Creates a progress update stream which is an AWS resource used for access control
        /// as well as a namespace for migration task names that is implicitly linked to your
        /// AWS account. It must uniquely identify the migration tool as it is used for all updates
        /// made by the tool; however, it does not need to be unique for each AWS account because
        /// it is scoped to the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProgressUpdateStream service method.</param>
        /// 
        /// <returns>The response from the CreateProgressUpdateStream service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <c>DryRun</c>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <c>DryRun</c> flag
        /// is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/CreateProgressUpdateStream">REST API Reference for CreateProgressUpdateStream Operation</seealso>
        CreateProgressUpdateStreamResponse CreateProgressUpdateStream(CreateProgressUpdateStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProgressUpdateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProgressUpdateStream operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProgressUpdateStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/CreateProgressUpdateStream">REST API Reference for CreateProgressUpdateStream Operation</seealso>
        IAsyncResult BeginCreateProgressUpdateStream(CreateProgressUpdateStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProgressUpdateStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProgressUpdateStream.</param>
        /// 
        /// <returns>Returns a  CreateProgressUpdateStreamResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/CreateProgressUpdateStream">REST API Reference for CreateProgressUpdateStream Operation</seealso>
        CreateProgressUpdateStreamResponse EndCreateProgressUpdateStream(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProgressUpdateStream


        /// <summary>
        /// Deletes a progress update stream, including all of its tasks, which was previously
        /// created as an AWS resource used for access control. This API has the following traits:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The only parameter needed for <c>DeleteProgressUpdateStream</c> is the stream name
        /// (same as a <c>CreateProgressUpdateStream</c> call).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The call will return, and a background process will asynchronously delete the stream
        /// and all of its resources (tasks, associated resources, resource attributes, created
        /// artifacts).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the stream takes time to be deleted, it might still show up on a <c>ListProgressUpdateStreams</c>
        /// call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CreateProgressUpdateStream</c>, <c>ImportMigrationTask</c>, <c>NotifyMigrationTaskState</c>,
        /// and all Associate[*] APIs related to the tasks belonging to the stream will throw
        /// "InvalidInputException" if the stream of the same name is in the process of being
        /// deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Once the stream and all of its resources are deleted, <c>CreateProgressUpdateStream</c>
        /// for a stream of the same name will succeed, and that stream will be an entirely new
        /// logical resource (without any resources associated with the old stream).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgressUpdateStream service method.</param>
        /// 
        /// <returns>The response from the DeleteProgressUpdateStream service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <c>DryRun</c>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <c>DryRun</c> flag
        /// is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DeleteProgressUpdateStream">REST API Reference for DeleteProgressUpdateStream Operation</seealso>
        DeleteProgressUpdateStreamResponse DeleteProgressUpdateStream(DeleteProgressUpdateStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProgressUpdateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgressUpdateStream operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProgressUpdateStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DeleteProgressUpdateStream">REST API Reference for DeleteProgressUpdateStream Operation</seealso>
        IAsyncResult BeginDeleteProgressUpdateStream(DeleteProgressUpdateStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProgressUpdateStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProgressUpdateStream.</param>
        /// 
        /// <returns>Returns a  DeleteProgressUpdateStreamResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DeleteProgressUpdateStream">REST API Reference for DeleteProgressUpdateStream Operation</seealso>
        DeleteProgressUpdateStreamResponse EndDeleteProgressUpdateStream(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApplicationState


        /// <summary>
        /// Gets the migration status of an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationState service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicationState service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.PolicyErrorException">
        /// Exception raised when there are problems accessing Application Discovery Service (Application
        /// Discovery Service); most likely due to a misconfigured policy or the <c>migrationhub-discovery</c>
        /// role is missing or not configured correctly.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeApplicationState">REST API Reference for DescribeApplicationState Operation</seealso>
        DescribeApplicationStateResponse DescribeApplicationState(DescribeApplicationStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationState operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeApplicationState">REST API Reference for DescribeApplicationState Operation</seealso>
        IAsyncResult BeginDescribeApplicationState(DescribeApplicationStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationState.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationStateResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeApplicationState">REST API Reference for DescribeApplicationState Operation</seealso>
        DescribeApplicationStateResponse EndDescribeApplicationState(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMigrationTask


        /// <summary>
        /// Retrieves a list of all attributes associated with a specific migration task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMigrationTask service method.</param>
        /// 
        /// <returns>The response from the DescribeMigrationTask service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeMigrationTask">REST API Reference for DescribeMigrationTask Operation</seealso>
        DescribeMigrationTaskResponse DescribeMigrationTask(DescribeMigrationTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMigrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMigrationTask operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMigrationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeMigrationTask">REST API Reference for DescribeMigrationTask Operation</seealso>
        IAsyncResult BeginDescribeMigrationTask(DescribeMigrationTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMigrationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMigrationTask.</param>
        /// 
        /// <returns>Returns a  DescribeMigrationTaskResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeMigrationTask">REST API Reference for DescribeMigrationTask Operation</seealso>
        DescribeMigrationTaskResponse EndDescribeMigrationTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateCreatedArtifact


        /// <summary>
        /// Disassociates a created artifact of an AWS resource with a migration task performed
        /// by a migration tool that was previously associated. This API has the following traits:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A migration user can call the <c>DisassociateCreatedArtifacts</c> operation to disassociate
        /// a created AWS Artifact from a migration task.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The created artifact name must be provided in ARN (Amazon Resource Name) format which
        /// will contain information about type and region; for example: <c>arn:aws:ec2:us-east-1:488216288981:image/ami-6d0ba87b</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Examples of the AWS resource behind the created artifact are, AMI's, EC2 instance,
        /// or RDS instance, etc.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCreatedArtifact service method.</param>
        /// 
        /// <returns>The response from the DisassociateCreatedArtifact service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <c>DryRun</c>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <c>DryRun</c> flag
        /// is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateCreatedArtifact">REST API Reference for DisassociateCreatedArtifact Operation</seealso>
        DisassociateCreatedArtifactResponse DisassociateCreatedArtifact(DisassociateCreatedArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateCreatedArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCreatedArtifact operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateCreatedArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateCreatedArtifact">REST API Reference for DisassociateCreatedArtifact Operation</seealso>
        IAsyncResult BeginDisassociateCreatedArtifact(DisassociateCreatedArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateCreatedArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateCreatedArtifact.</param>
        /// 
        /// <returns>Returns a  DisassociateCreatedArtifactResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateCreatedArtifact">REST API Reference for DisassociateCreatedArtifact Operation</seealso>
        DisassociateCreatedArtifactResponse EndDisassociateCreatedArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateDiscoveredResource


        /// <summary>
        /// Disassociate an Application Discovery Service discovered resource from a migration
        /// task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDiscoveredResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateDiscoveredResource service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <c>DryRun</c>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <c>DryRun</c> flag
        /// is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateDiscoveredResource">REST API Reference for DisassociateDiscoveredResource Operation</seealso>
        DisassociateDiscoveredResourceResponse DisassociateDiscoveredResource(DisassociateDiscoveredResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDiscoveredResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDiscoveredResource operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDiscoveredResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateDiscoveredResource">REST API Reference for DisassociateDiscoveredResource Operation</seealso>
        IAsyncResult BeginDisassociateDiscoveredResource(DisassociateDiscoveredResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDiscoveredResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDiscoveredResource.</param>
        /// 
        /// <returns>Returns a  DisassociateDiscoveredResourceResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateDiscoveredResource">REST API Reference for DisassociateDiscoveredResource Operation</seealso>
        DisassociateDiscoveredResourceResponse EndDisassociateDiscoveredResource(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateSourceResource


        /// <summary>
        /// Removes the association between a source resource and a migration task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateSourceResource service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <c>DryRun</c>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <c>DryRun</c> flag
        /// is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateSourceResource">REST API Reference for DisassociateSourceResource Operation</seealso>
        DisassociateSourceResourceResponse DisassociateSourceResource(DisassociateSourceResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSourceResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceResource operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSourceResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateSourceResource">REST API Reference for DisassociateSourceResource Operation</seealso>
        IAsyncResult BeginDisassociateSourceResource(DisassociateSourceResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSourceResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSourceResource.</param>
        /// 
        /// <returns>Returns a  DisassociateSourceResourceResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateSourceResource">REST API Reference for DisassociateSourceResource Operation</seealso>
        DisassociateSourceResourceResponse EndDisassociateSourceResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportMigrationTask


        /// <summary>
        /// Registers a new migration task which represents a server, database, etc., being migrated
        /// to AWS by a migration tool.
        /// 
        ///  
        /// <para>
        /// This API is a prerequisite to calling the <c>NotifyMigrationTaskState</c> API as the
        /// migration tool must first register the migration task with Migration Hub.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportMigrationTask service method.</param>
        /// 
        /// <returns>The response from the ImportMigrationTask service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <c>DryRun</c>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <c>DryRun</c> flag
        /// is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ImportMigrationTask">REST API Reference for ImportMigrationTask Operation</seealso>
        ImportMigrationTaskResponse ImportMigrationTask(ImportMigrationTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportMigrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportMigrationTask operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportMigrationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ImportMigrationTask">REST API Reference for ImportMigrationTask Operation</seealso>
        IAsyncResult BeginImportMigrationTask(ImportMigrationTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportMigrationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportMigrationTask.</param>
        /// 
        /// <returns>Returns a  ImportMigrationTaskResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ImportMigrationTask">REST API Reference for ImportMigrationTask Operation</seealso>
        ImportMigrationTaskResponse EndImportMigrationTask(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplicationStates


        /// <summary>
        /// Lists all the migration statuses for your applications. If you use the optional <c>ApplicationIds</c>
        /// parameter, only the migration statuses for those applications will be returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationStates service method.</param>
        /// 
        /// <returns>The response from the ListApplicationStates service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListApplicationStates">REST API Reference for ListApplicationStates Operation</seealso>
        ListApplicationStatesResponse ListApplicationStates(ListApplicationStatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationStates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationStates operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationStates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListApplicationStates">REST API Reference for ListApplicationStates Operation</seealso>
        IAsyncResult BeginListApplicationStates(ListApplicationStatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationStates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationStates.</param>
        /// 
        /// <returns>Returns a  ListApplicationStatesResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListApplicationStates">REST API Reference for ListApplicationStates Operation</seealso>
        ListApplicationStatesResponse EndListApplicationStates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCreatedArtifacts


        /// <summary>
        /// Lists the created artifacts attached to a given migration task in an update stream.
        /// This API has the following traits:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Gets the list of the created artifacts while migration is taking place.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Shows the artifacts created by the migration tool that was associated by the <c>AssociateCreatedArtifact</c>
        /// API. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lists created artifacts in a paginated interface. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCreatedArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListCreatedArtifacts service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListCreatedArtifacts">REST API Reference for ListCreatedArtifacts Operation</seealso>
        ListCreatedArtifactsResponse ListCreatedArtifacts(ListCreatedArtifactsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCreatedArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCreatedArtifacts operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCreatedArtifacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListCreatedArtifacts">REST API Reference for ListCreatedArtifacts Operation</seealso>
        IAsyncResult BeginListCreatedArtifacts(ListCreatedArtifactsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCreatedArtifacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCreatedArtifacts.</param>
        /// 
        /// <returns>Returns a  ListCreatedArtifactsResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListCreatedArtifacts">REST API Reference for ListCreatedArtifacts Operation</seealso>
        ListCreatedArtifactsResponse EndListCreatedArtifacts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDiscoveredResources


        /// <summary>
        /// Lists discovered resources associated with the given <c>MigrationTask</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources service method.</param>
        /// 
        /// <returns>The response from the ListDiscoveredResources service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        ListDiscoveredResourcesResponse ListDiscoveredResources(ListDiscoveredResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDiscoveredResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        IAsyncResult BeginListDiscoveredResources(ListDiscoveredResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDiscoveredResources.</param>
        /// 
        /// <returns>Returns a  ListDiscoveredResourcesResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        ListDiscoveredResourcesResponse EndListDiscoveredResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMigrationTasks


        /// <summary>
        /// Lists all, or filtered by resource name, migration tasks associated with the user
        /// account making this call. This API has the following traits:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Can show a summary list of the most recent migration tasks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can show a summary list of migration tasks associated with a given discovered resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lists migration tasks in a paginated interface.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMigrationTasks service method.</param>
        /// 
        /// <returns>The response from the ListMigrationTasks service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.PolicyErrorException">
        /// Exception raised when there are problems accessing Application Discovery Service (Application
        /// Discovery Service); most likely due to a misconfigured policy or the <c>migrationhub-discovery</c>
        /// role is missing or not configured correctly.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListMigrationTasks">REST API Reference for ListMigrationTasks Operation</seealso>
        ListMigrationTasksResponse ListMigrationTasks(ListMigrationTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMigrationTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMigrationTasks operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMigrationTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListMigrationTasks">REST API Reference for ListMigrationTasks Operation</seealso>
        IAsyncResult BeginListMigrationTasks(ListMigrationTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMigrationTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMigrationTasks.</param>
        /// 
        /// <returns>Returns a  ListMigrationTasksResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListMigrationTasks">REST API Reference for ListMigrationTasks Operation</seealso>
        ListMigrationTasksResponse EndListMigrationTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMigrationTaskUpdates


        /// <summary>
        /// This is a paginated API that returns all the migration-task states for the specified
        /// <c>MigrationTaskName</c> and <c>ProgressUpdateStream</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMigrationTaskUpdates service method.</param>
        /// 
        /// <returns>The response from the ListMigrationTaskUpdates service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListMigrationTaskUpdates">REST API Reference for ListMigrationTaskUpdates Operation</seealso>
        ListMigrationTaskUpdatesResponse ListMigrationTaskUpdates(ListMigrationTaskUpdatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMigrationTaskUpdates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMigrationTaskUpdates operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMigrationTaskUpdates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListMigrationTaskUpdates">REST API Reference for ListMigrationTaskUpdates Operation</seealso>
        IAsyncResult BeginListMigrationTaskUpdates(ListMigrationTaskUpdatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMigrationTaskUpdates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMigrationTaskUpdates.</param>
        /// 
        /// <returns>Returns a  ListMigrationTaskUpdatesResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListMigrationTaskUpdates">REST API Reference for ListMigrationTaskUpdates Operation</seealso>
        ListMigrationTaskUpdatesResponse EndListMigrationTaskUpdates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProgressUpdateStreams


        /// <summary>
        /// Lists progress update streams associated with the user account making this call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProgressUpdateStreams service method.</param>
        /// 
        /// <returns>The response from the ListProgressUpdateStreams service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListProgressUpdateStreams">REST API Reference for ListProgressUpdateStreams Operation</seealso>
        ListProgressUpdateStreamsResponse ListProgressUpdateStreams(ListProgressUpdateStreamsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProgressUpdateStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProgressUpdateStreams operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProgressUpdateStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListProgressUpdateStreams">REST API Reference for ListProgressUpdateStreams Operation</seealso>
        IAsyncResult BeginListProgressUpdateStreams(ListProgressUpdateStreamsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProgressUpdateStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProgressUpdateStreams.</param>
        /// 
        /// <returns>Returns a  ListProgressUpdateStreamsResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListProgressUpdateStreams">REST API Reference for ListProgressUpdateStreams Operation</seealso>
        ListProgressUpdateStreamsResponse EndListProgressUpdateStreams(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSourceResources


        /// <summary>
        /// Lists all the source resource that are associated with the specified <c>MigrationTaskName</c>
        /// and <c>ProgressUpdateStream</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceResources service method.</param>
        /// 
        /// <returns>The response from the ListSourceResources service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListSourceResources">REST API Reference for ListSourceResources Operation</seealso>
        ListSourceResourcesResponse ListSourceResources(ListSourceResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSourceResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSourceResources operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSourceResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListSourceResources">REST API Reference for ListSourceResources Operation</seealso>
        IAsyncResult BeginListSourceResources(ListSourceResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSourceResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSourceResources.</param>
        /// 
        /// <returns>Returns a  ListSourceResourcesResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListSourceResources">REST API Reference for ListSourceResources Operation</seealso>
        ListSourceResourcesResponse EndListSourceResources(IAsyncResult asyncResult);

        #endregion
        
        #region  NotifyApplicationState


        /// <summary>
        /// Sets the migration state of an application. For a given application identified by
        /// the value passed to <c>ApplicationId</c>, its status is set or updated by passing
        /// one of three values to <c>Status</c>: <c>NOT_STARTED | IN_PROGRESS | COMPLETED</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyApplicationState service method.</param>
        /// 
        /// <returns>The response from the NotifyApplicationState service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <c>DryRun</c>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.PolicyErrorException">
        /// Exception raised when there are problems accessing Application Discovery Service (Application
        /// Discovery Service); most likely due to a misconfigured policy or the <c>migrationhub-discovery</c>
        /// role is missing or not configured correctly.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <c>DryRun</c> flag
        /// is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyApplicationState">REST API Reference for NotifyApplicationState Operation</seealso>
        NotifyApplicationStateResponse NotifyApplicationState(NotifyApplicationStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NotifyApplicationState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyApplicationState operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNotifyApplicationState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyApplicationState">REST API Reference for NotifyApplicationState Operation</seealso>
        IAsyncResult BeginNotifyApplicationState(NotifyApplicationStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NotifyApplicationState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNotifyApplicationState.</param>
        /// 
        /// <returns>Returns a  NotifyApplicationStateResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyApplicationState">REST API Reference for NotifyApplicationState Operation</seealso>
        NotifyApplicationStateResponse EndNotifyApplicationState(IAsyncResult asyncResult);

        #endregion
        
        #region  NotifyMigrationTaskState


        /// <summary>
        /// Notifies Migration Hub of the current status, progress, or other detail regarding
        /// a migration task. This API has the following traits:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Migration tools will call the <c>NotifyMigrationTaskState</c> API to share the latest
        /// progress and status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MigrationTaskName</c> is used for addressing updates to the correct target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ProgressUpdateStream</c> is used for access control and to provide a namespace
        /// for each migration tool.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyMigrationTaskState service method.</param>
        /// 
        /// <returns>The response from the NotifyMigrationTaskState service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <c>DryRun</c>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <c>DryRun</c> flag
        /// is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyMigrationTaskState">REST API Reference for NotifyMigrationTaskState Operation</seealso>
        NotifyMigrationTaskStateResponse NotifyMigrationTaskState(NotifyMigrationTaskStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NotifyMigrationTaskState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyMigrationTaskState operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNotifyMigrationTaskState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyMigrationTaskState">REST API Reference for NotifyMigrationTaskState Operation</seealso>
        IAsyncResult BeginNotifyMigrationTaskState(NotifyMigrationTaskStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NotifyMigrationTaskState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNotifyMigrationTaskState.</param>
        /// 
        /// <returns>Returns a  NotifyMigrationTaskStateResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyMigrationTaskState">REST API Reference for NotifyMigrationTaskState Operation</seealso>
        NotifyMigrationTaskStateResponse EndNotifyMigrationTaskState(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourceAttributes


        /// <summary>
        /// Provides identifying details of the resource being migrated so that it can be associated
        /// in the Application Discovery Service repository. This association occurs asynchronously
        /// after <c>PutResourceAttributes</c> returns.
        /// 
        ///  <important> <ul> <li> 
        /// <para>
        /// Keep in mind that subsequent calls to PutResourceAttributes will override previously
        /// stored attributes. For example, if it is first called with a MAC address, but later,
        /// it is desired to <i>add</i> an IP address, it will then be required to call it with
        /// <i>both</i> the IP and MAC addresses to prevent overriding the MAC address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Note the instructions regarding the special use case of the <a href="https://docs.aws.amazon.com/migrationhub/latest/ug/API_PutResourceAttributes.html#migrationhub-PutResourceAttributes-request-ResourceAttributeList">
        /// <c>ResourceAttributeList</c> </a> parameter when specifying any "VM" related value.
        /// </para>
        ///  </li> </ul> </important> <note> 
        /// <para>
        /// Because this is an asynchronous call, it will always return 200, whether an association
        /// occurs or not. To confirm if an association was found based on the provided details,
        /// call <c>ListDiscoveredResources</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourceAttributes service method.</param>
        /// 
        /// <returns>The response from the PutResourceAttributes service method, as returned by MigrationHub.</returns>
        /// <exception cref="Amazon.MigrationHub.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.DryRunOperationException">
        /// Exception raised to indicate a successfully authorized action when the <c>DryRun</c>
        /// flag is set to "true".
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.HomeRegionNotSetException">
        /// The home region is not set. Set the home region to continue.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InternalServerErrorException">
        /// Exception raised when an internal, configuration, or dependency error is encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.InvalidInputException">
        /// Exception raised when the provided input violates a policy constraint or is entered
        /// in the wrong format or data type.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ResourceNotFoundException">
        /// Exception raised when the request references a resource (Application Discovery Service
        /// configuration, update stream, migration task, etc.) that does not exist in Application
        /// Discovery Service (Application Discovery Service) or in Migration Hub's repository.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ServiceUnavailableException">
        /// Exception raised when there is an internal, configuration, or dependency error encountered.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHub.Model.UnauthorizedOperationException">
        /// Exception raised to indicate a request was not authorized when the <c>DryRun</c> flag
        /// is set to "true".
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/PutResourceAttributes">REST API Reference for PutResourceAttributes Operation</seealso>
        PutResourceAttributesResponse PutResourceAttributes(PutResourceAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourceAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourceAttributes operation on AmazonMigrationHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourceAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/PutResourceAttributes">REST API Reference for PutResourceAttributes Operation</seealso>
        IAsyncResult BeginPutResourceAttributes(PutResourceAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourceAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourceAttributes.</param>
        /// 
        /// <returns>Returns a  PutResourceAttributesResult from MigrationHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/PutResourceAttributes">REST API Reference for PutResourceAttributes Operation</seealso>
        PutResourceAttributesResponse EndPutResourceAttributes(IAsyncResult asyncResult);

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