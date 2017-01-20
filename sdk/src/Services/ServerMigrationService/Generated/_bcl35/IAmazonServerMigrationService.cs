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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ServerMigrationService.Model;

namespace Amazon.ServerMigrationService
{
    /// <summary>
    /// Interface for accessing ServerMigrationService
    ///
    /// Amazon Server Migration Service automates the process of migrating servers to EC2.
    /// </summary>
    public partial interface IAmazonServerMigrationService : IAmazonService, IDisposable
    {

        
        #region  CreateReplicationJob


        /// <summary>
        /// The CreateReplicationJob API is used to create a ReplicationJob to replicate a server
        /// on AWS. Call this API to first create a ReplicationJob, which will then schedule periodic
        /// ReplicationRuns to replicate your server to AWS. Each ReplicationRun will result in
        /// the creation of an AWS AMI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationJob service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error has occured.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.NoConnectorsAvailableException">
        /// No connectors are available to handle this request. Please associate connector(s)
        /// and verify any existing connectors are healthy and can respond to requests.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobAlreadyExistsException">
        /// An active Replication Job already exists for the specified server.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ServerCannotBeReplicatedException">
        /// The provided server cannot be replicated.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        CreateReplicationJobResponse CreateReplicationJob(CreateReplicationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationJob operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationJob
        ///         operation.</returns>
        IAsyncResult BeginCreateReplicationJob(CreateReplicationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationJob.</param>
        /// 
        /// <returns>Returns a  CreateReplicationJobResult from ServerMigrationService.</returns>
        CreateReplicationJobResponse EndCreateReplicationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReplicationJob


        /// <summary>
        /// The DeleteReplicationJob API is used to delete a ReplicationJob, resulting in no further
        /// ReplicationRuns. This will delete the contents of the S3 bucket used to store SMS
        /// artifacts, but will not delete any AMIs created by the SMS service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationJob service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobNotFoundException">
        /// The specified Replication Job cannot be found.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        DeleteReplicationJobResponse DeleteReplicationJob(DeleteReplicationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationJob operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationJob
        ///         operation.</returns>
        IAsyncResult BeginDeleteReplicationJob(DeleteReplicationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationJob.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationJobResult from ServerMigrationService.</returns>
        DeleteReplicationJobResponse EndDeleteReplicationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteServerCatalog


        /// <summary>
        /// The DeleteServerCatalog API clears all servers from your server catalog. This means
        /// that these servers will no longer be accessible to the Server Migration Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCatalog service method.</param>
        /// 
        /// <returns>The response from the DeleteServerCatalog service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        DeleteServerCatalogResponse DeleteServerCatalog(DeleteServerCatalogRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCatalog operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServerCatalog
        ///         operation.</returns>
        IAsyncResult BeginDeleteServerCatalog(DeleteServerCatalogRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServerCatalog.</param>
        /// 
        /// <returns>Returns a  DeleteServerCatalogResult from ServerMigrationService.</returns>
        DeleteServerCatalogResponse EndDeleteServerCatalog(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateConnector


        /// <summary>
        /// The DisassociateConnector API will disassociate a connector from the Server Migration
        /// Service, rendering it unavailable to support replication jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnector service method.</param>
        /// 
        /// <returns>The response from the DisassociateConnector service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        DisassociateConnectorResponse DisassociateConnector(DisassociateConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnector operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateConnector
        ///         operation.</returns>
        IAsyncResult BeginDisassociateConnector(DisassociateConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateConnector.</param>
        /// 
        /// <returns>Returns a  DisassociateConnectorResult from ServerMigrationService.</returns>
        DisassociateConnectorResponse EndDisassociateConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnectors


        /// <summary>
        /// The GetConnectors API returns a list of connectors that are registered with the Server
        /// Migration Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectors service method.</param>
        /// 
        /// <returns>The response from the GetConnectors service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        GetConnectorsResponse GetConnectors(GetConnectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectors operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectors
        ///         operation.</returns>
        IAsyncResult BeginGetConnectors(GetConnectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectors.</param>
        /// 
        /// <returns>Returns a  GetConnectorsResult from ServerMigrationService.</returns>
        GetConnectorsResponse EndGetConnectors(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReplicationJobs


        /// <summary>
        /// The GetReplicationJobs API will return all of your ReplicationJobs and their details.
        /// This API returns a paginated list, that may be consecutively called with nextToken
        /// to retrieve all ReplicationJobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationJobs service method.</param>
        /// 
        /// <returns>The response from the GetReplicationJobs service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        GetReplicationJobsResponse GetReplicationJobs(GetReplicationJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReplicationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationJobs operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReplicationJobs
        ///         operation.</returns>
        IAsyncResult BeginGetReplicationJobs(GetReplicationJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReplicationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReplicationJobs.</param>
        /// 
        /// <returns>Returns a  GetReplicationJobsResult from ServerMigrationService.</returns>
        GetReplicationJobsResponse EndGetReplicationJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReplicationRuns


        /// <summary>
        /// The GetReplicationRuns API will return all ReplicationRuns for a given ReplicationJob.
        /// This API returns a paginated list, that may be consecutively called with nextToken
        /// to retrieve all ReplicationRuns for a ReplicationJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationRuns service method.</param>
        /// 
        /// <returns>The response from the GetReplicationRuns service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        GetReplicationRunsResponse GetReplicationRuns(GetReplicationRunsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReplicationRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationRuns operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReplicationRuns
        ///         operation.</returns>
        IAsyncResult BeginGetReplicationRuns(GetReplicationRunsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReplicationRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReplicationRuns.</param>
        /// 
        /// <returns>Returns a  GetReplicationRunsResult from ServerMigrationService.</returns>
        GetReplicationRunsResponse EndGetReplicationRuns(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServers


        /// <summary>
        /// The GetServers API returns a list of all servers in your server catalog. For this
        /// call to succeed, you must previously have called ImportServerCatalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServers service method.</param>
        /// 
        /// <returns>The response from the GetServers service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        GetServersResponse GetServers(GetServersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServers operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServers
        ///         operation.</returns>
        IAsyncResult BeginGetServers(GetServersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServers.</param>
        /// 
        /// <returns>Returns a  GetServersResult from ServerMigrationService.</returns>
        GetServersResponse EndGetServers(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportServerCatalog


        /// <summary>
        /// The ImportServerCatalog API is used to gather the complete list of on-premises servers
        /// on your premises. This API call requires connectors to be installed and monitoring
        /// all servers you would like imported. This API call returns immediately, but may take
        /// some time to retrieve all of the servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportServerCatalog service method.</param>
        /// 
        /// <returns>The response from the ImportServerCatalog service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.NoConnectorsAvailableException">
        /// No connectors are available to handle this request. Please associate connector(s)
        /// and verify any existing connectors are healthy and can respond to requests.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        ImportServerCatalogResponse ImportServerCatalog(ImportServerCatalogRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportServerCatalog operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportServerCatalog
        ///         operation.</returns>
        IAsyncResult BeginImportServerCatalog(ImportServerCatalogRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportServerCatalog.</param>
        /// 
        /// <returns>Returns a  ImportServerCatalogResult from ServerMigrationService.</returns>
        ImportServerCatalogResponse EndImportServerCatalog(IAsyncResult asyncResult);

        #endregion
        
        #region  StartOnDemandReplicationRun


        /// <summary>
        /// The StartOnDemandReplicationRun API is used to start a ReplicationRun on demand (in
        /// addition to those that are scheduled based on your frequency). This ReplicationRun
        /// will start immediately. StartOnDemandReplicationRun is subject to limits on how many
        /// on demand ReplicationRuns you may call per 24-hour period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandReplicationRun service method.</param>
        /// 
        /// <returns>The response from the StartOnDemandReplicationRun service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationRunLimitExceededException">
        /// This user has exceeded the maximum allowed Replication Run limit.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        StartOnDemandReplicationRunResponse StartOnDemandReplicationRun(StartOnDemandReplicationRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartOnDemandReplicationRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandReplicationRun operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartOnDemandReplicationRun
        ///         operation.</returns>
        IAsyncResult BeginStartOnDemandReplicationRun(StartOnDemandReplicationRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartOnDemandReplicationRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartOnDemandReplicationRun.</param>
        /// 
        /// <returns>Returns a  StartOnDemandReplicationRunResult from ServerMigrationService.</returns>
        StartOnDemandReplicationRunResponse EndStartOnDemandReplicationRun(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateReplicationJob


        /// <summary>
        /// The UpdateReplicationJob API is used to change the settings of your existing ReplicationJob
        /// created using CreateReplicationJob. Calling this API will affect the next scheduled
        /// ReplicationRun.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationJob service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationJob service method, as returned by ServerMigrationService.</returns>
        /// <exception cref="Amazon.ServerMigrationService.Model.InternalErrorException">
        /// An internal error has occured.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.InvalidParameterException">
        /// A parameter specified in the request is not valid, is unsupported, or cannot be used.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.MissingRequiredParameterException">
        /// The request is missing a required parameter. Ensure that you have supplied all the
        /// required parameters for the request.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.OperationNotPermittedException">
        /// The specified operation is not allowed. This error can occur for a number of reasons;
        /// for example, you might be trying to start a Replication Run before seed Replication
        /// Run.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ReplicationJobNotFoundException">
        /// The specified Replication Job cannot be found.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.ServerCannotBeReplicatedException">
        /// The provided server cannot be replicated.
        /// </exception>
        /// <exception cref="Amazon.ServerMigrationService.Model.UnauthorizedOperationException">
        /// This user does not have permissions to perform this operation.
        /// </exception>
        UpdateReplicationJobResponse UpdateReplicationJob(UpdateReplicationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationJob operation on AmazonServerMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReplicationJob
        ///         operation.</returns>
        IAsyncResult BeginUpdateReplicationJob(UpdateReplicationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReplicationJob.</param>
        /// 
        /// <returns>Returns a  UpdateReplicationJobResult from ServerMigrationService.</returns>
        UpdateReplicationJobResponse EndUpdateReplicationJob(IAsyncResult asyncResult);

        #endregion
        
    }
}