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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BackupGateway.Model;

namespace Amazon.BackupGateway
{
    /// <summary>
    /// Interface for accessing BackupGateway
    ///
    /// Backup gateway 
    /// <para>
    /// Backup gateway connects Backup to your hypervisor, so you can create, store, and restore
    /// backups of your virtual machines (VMs) anywhere, whether on-premises or in the VMware
    /// Cloud (VMC) on Amazon Web Services.
    /// 
    ///  
    /// <para>
    /// Add on-premises resources by connecting to a hypervisor through a gateway. Backup
    /// will automatically discover the resources in your hypervisor.
    /// </para>
    ///  
    /// <para>
    /// Use Backup to assign virtual or on-premises resources to a backup plan, or run on-demand
    /// backups. Once you have backed up your resources, you can view them and restore them
    /// like any resource supported by Backup.
    /// </para>
    ///  
    /// <para>
    /// To download the Amazon Web Services software to get started, navigate to the Backup
    /// console, choose <b>Gateways</b>, then choose <b>Create gateway</b>.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonBackupGateway : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBackupGatewayPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateGatewayToServer


        /// <summary>
        /// Associates a backup gateway with your server. After you complete the association process,
        /// you can back up and restore your VMs through the gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateGatewayToServer service method.</param>
        /// 
        /// <returns>The response from the AssociateGatewayToServer service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/AssociateGatewayToServer">REST API Reference for AssociateGatewayToServer Operation</seealso>
        AssociateGatewayToServerResponse AssociateGatewayToServer(AssociateGatewayToServerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateGatewayToServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateGatewayToServer operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateGatewayToServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/AssociateGatewayToServer">REST API Reference for AssociateGatewayToServer Operation</seealso>
        IAsyncResult BeginAssociateGatewayToServer(AssociateGatewayToServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateGatewayToServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateGatewayToServer.</param>
        /// 
        /// <returns>Returns a  AssociateGatewayToServerResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/AssociateGatewayToServer">REST API Reference for AssociateGatewayToServer Operation</seealso>
        AssociateGatewayToServerResponse EndAssociateGatewayToServer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGateway


        /// <summary>
        /// Creates a backup gateway. After you create a gateway, you can associate it with a
        /// server using the <code>AssociateGatewayToServer</code> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway service method.</param>
        /// 
        /// <returns>The response from the CreateGateway service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        CreateGatewayResponse CreateGateway(CreateGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        IAsyncResult BeginCreateGateway(CreateGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGateway.</param>
        /// 
        /// <returns>Returns a  CreateGatewayResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        CreateGatewayResponse EndCreateGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGateway


        /// <summary>
        /// Deletes a backup gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        IAsyncResult BeginDeleteGateway(DeleteGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGateway.</param>
        /// 
        /// <returns>Returns a  DeleteGatewayResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        DeleteGatewayResponse EndDeleteGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteHypervisor


        /// <summary>
        /// Deletes a hypervisor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHypervisor service method.</param>
        /// 
        /// <returns>The response from the DeleteHypervisor service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DeleteHypervisor">REST API Reference for DeleteHypervisor Operation</seealso>
        DeleteHypervisorResponse DeleteHypervisor(DeleteHypervisorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHypervisor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHypervisor operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHypervisor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DeleteHypervisor">REST API Reference for DeleteHypervisor Operation</seealso>
        IAsyncResult BeginDeleteHypervisor(DeleteHypervisorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHypervisor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHypervisor.</param>
        /// 
        /// <returns>Returns a  DeleteHypervisorResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DeleteHypervisor">REST API Reference for DeleteHypervisor Operation</seealso>
        DeleteHypervisorResponse EndDeleteHypervisor(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateGatewayFromServer


        /// <summary>
        /// Disassociates a backup gateway from the specified server. After the disassociation
        /// process finishes, the gateway can no longer access the virtual machines on the server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateGatewayFromServer service method.</param>
        /// 
        /// <returns>The response from the DisassociateGatewayFromServer service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DisassociateGatewayFromServer">REST API Reference for DisassociateGatewayFromServer Operation</seealso>
        DisassociateGatewayFromServerResponse DisassociateGatewayFromServer(DisassociateGatewayFromServerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateGatewayFromServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateGatewayFromServer operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateGatewayFromServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DisassociateGatewayFromServer">REST API Reference for DisassociateGatewayFromServer Operation</seealso>
        IAsyncResult BeginDisassociateGatewayFromServer(DisassociateGatewayFromServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateGatewayFromServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateGatewayFromServer.</param>
        /// 
        /// <returns>Returns a  DisassociateGatewayFromServerResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DisassociateGatewayFromServer">REST API Reference for DisassociateGatewayFromServer Operation</seealso>
        DisassociateGatewayFromServerResponse EndDisassociateGatewayFromServer(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBandwidthRateLimitSchedule


        /// <summary>
        /// Retrieves the bandwidth rate limit schedule for a specified gateway. By default, gateways
        /// do not have bandwidth rate limit schedules, which means no bandwidth rate limiting
        /// is in effect. Use this to get a gateway's bandwidth rate limit schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBandwidthRateLimitSchedule service method.</param>
        /// 
        /// <returns>The response from the GetBandwidthRateLimitSchedule service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetBandwidthRateLimitSchedule">REST API Reference for GetBandwidthRateLimitSchedule Operation</seealso>
        GetBandwidthRateLimitScheduleResponse GetBandwidthRateLimitSchedule(GetBandwidthRateLimitScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBandwidthRateLimitSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBandwidthRateLimitSchedule operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBandwidthRateLimitSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetBandwidthRateLimitSchedule">REST API Reference for GetBandwidthRateLimitSchedule Operation</seealso>
        IAsyncResult BeginGetBandwidthRateLimitSchedule(GetBandwidthRateLimitScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBandwidthRateLimitSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBandwidthRateLimitSchedule.</param>
        /// 
        /// <returns>Returns a  GetBandwidthRateLimitScheduleResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetBandwidthRateLimitSchedule">REST API Reference for GetBandwidthRateLimitSchedule Operation</seealso>
        GetBandwidthRateLimitScheduleResponse EndGetBandwidthRateLimitSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGateway


        /// <summary>
        /// By providing the ARN (Amazon Resource Name), this API returns the gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGateway service method.</param>
        /// 
        /// <returns>The response from the GetGateway service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetGateway">REST API Reference for GetGateway Operation</seealso>
        GetGatewayResponse GetGateway(GetGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGateway operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetGateway">REST API Reference for GetGateway Operation</seealso>
        IAsyncResult BeginGetGateway(GetGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGateway.</param>
        /// 
        /// <returns>Returns a  GetGatewayResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetGateway">REST API Reference for GetGateway Operation</seealso>
        GetGatewayResponse EndGetGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHypervisor


        /// <summary>
        /// This action requests information about the specified hypervisor to which the gateway
        /// will connect. A hypervisor is hardware, software, or firmware that creates and manages
        /// virtual machines, and allocates resources to them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHypervisor service method.</param>
        /// 
        /// <returns>The response from the GetHypervisor service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetHypervisor">REST API Reference for GetHypervisor Operation</seealso>
        GetHypervisorResponse GetHypervisor(GetHypervisorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHypervisor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHypervisor operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHypervisor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetHypervisor">REST API Reference for GetHypervisor Operation</seealso>
        IAsyncResult BeginGetHypervisor(GetHypervisorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHypervisor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHypervisor.</param>
        /// 
        /// <returns>Returns a  GetHypervisorResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetHypervisor">REST API Reference for GetHypervisor Operation</seealso>
        GetHypervisorResponse EndGetHypervisor(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHypervisorPropertyMappings


        /// <summary>
        /// This action retrieves the property mappings for the specified hypervisor. A hypervisor
        /// property mapping displays the relationship of entity properties available from the
        /// on-premises hypervisor to the properties available in Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHypervisorPropertyMappings service method.</param>
        /// 
        /// <returns>The response from the GetHypervisorPropertyMappings service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetHypervisorPropertyMappings">REST API Reference for GetHypervisorPropertyMappings Operation</seealso>
        GetHypervisorPropertyMappingsResponse GetHypervisorPropertyMappings(GetHypervisorPropertyMappingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHypervisorPropertyMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHypervisorPropertyMappings operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHypervisorPropertyMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetHypervisorPropertyMappings">REST API Reference for GetHypervisorPropertyMappings Operation</seealso>
        IAsyncResult BeginGetHypervisorPropertyMappings(GetHypervisorPropertyMappingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHypervisorPropertyMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHypervisorPropertyMappings.</param>
        /// 
        /// <returns>Returns a  GetHypervisorPropertyMappingsResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetHypervisorPropertyMappings">REST API Reference for GetHypervisorPropertyMappings Operation</seealso>
        GetHypervisorPropertyMappingsResponse EndGetHypervisorPropertyMappings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVirtualMachine


        /// <summary>
        /// By providing the ARN (Amazon Resource Name), this API returns the virtual machine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVirtualMachine service method.</param>
        /// 
        /// <returns>The response from the GetVirtualMachine service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetVirtualMachine">REST API Reference for GetVirtualMachine Operation</seealso>
        GetVirtualMachineResponse GetVirtualMachine(GetVirtualMachineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVirtualMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVirtualMachine operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVirtualMachine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetVirtualMachine">REST API Reference for GetVirtualMachine Operation</seealso>
        IAsyncResult BeginGetVirtualMachine(GetVirtualMachineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVirtualMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVirtualMachine.</param>
        /// 
        /// <returns>Returns a  GetVirtualMachineResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetVirtualMachine">REST API Reference for GetVirtualMachine Operation</seealso>
        GetVirtualMachineResponse EndGetVirtualMachine(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportHypervisorConfiguration


        /// <summary>
        /// Connect to a hypervisor by importing its configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportHypervisorConfiguration service method.</param>
        /// 
        /// <returns>The response from the ImportHypervisorConfiguration service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ImportHypervisorConfiguration">REST API Reference for ImportHypervisorConfiguration Operation</seealso>
        ImportHypervisorConfigurationResponse ImportHypervisorConfiguration(ImportHypervisorConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportHypervisorConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportHypervisorConfiguration operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportHypervisorConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ImportHypervisorConfiguration">REST API Reference for ImportHypervisorConfiguration Operation</seealso>
        IAsyncResult BeginImportHypervisorConfiguration(ImportHypervisorConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportHypervisorConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportHypervisorConfiguration.</param>
        /// 
        /// <returns>Returns a  ImportHypervisorConfigurationResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ImportHypervisorConfiguration">REST API Reference for ImportHypervisorConfiguration Operation</seealso>
        ImportHypervisorConfigurationResponse EndImportHypervisorConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGateways


        /// <summary>
        /// Lists backup gateways owned by an Amazon Web Services account in an Amazon Web Services
        /// Region. The returned list is ordered by gateway Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListGateways">REST API Reference for ListGateways Operation</seealso>
        ListGatewaysResponse ListGateways(ListGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGateways operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListGateways">REST API Reference for ListGateways Operation</seealso>
        IAsyncResult BeginListGateways(ListGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGateways.</param>
        /// 
        /// <returns>Returns a  ListGatewaysResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListGateways">REST API Reference for ListGateways Operation</seealso>
        ListGatewaysResponse EndListGateways(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHypervisors


        /// <summary>
        /// Lists your hypervisors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHypervisors service method.</param>
        /// 
        /// <returns>The response from the ListHypervisors service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListHypervisors">REST API Reference for ListHypervisors Operation</seealso>
        ListHypervisorsResponse ListHypervisors(ListHypervisorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHypervisors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHypervisors operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHypervisors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListHypervisors">REST API Reference for ListHypervisors Operation</seealso>
        IAsyncResult BeginListHypervisors(ListHypervisorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHypervisors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHypervisors.</param>
        /// 
        /// <returns>Returns a  ListHypervisorsResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListHypervisors">REST API Reference for ListHypervisors Operation</seealso>
        ListHypervisorsResponse EndListHypervisors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags applied to the resource identified by its Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVirtualMachines


        /// <summary>
        /// Lists your virtual machines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMachines service method.</param>
        /// 
        /// <returns>The response from the ListVirtualMachines service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListVirtualMachines">REST API Reference for ListVirtualMachines Operation</seealso>
        ListVirtualMachinesResponse ListVirtualMachines(ListVirtualMachinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualMachines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMachines operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVirtualMachines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListVirtualMachines">REST API Reference for ListVirtualMachines Operation</seealso>
        IAsyncResult BeginListVirtualMachines(ListVirtualMachinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVirtualMachines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualMachines.</param>
        /// 
        /// <returns>Returns a  ListVirtualMachinesResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListVirtualMachines">REST API Reference for ListVirtualMachines Operation</seealso>
        ListVirtualMachinesResponse EndListVirtualMachines(IAsyncResult asyncResult);

        #endregion
        
        #region  PutBandwidthRateLimitSchedule


        /// <summary>
        /// This action sets the bandwidth rate limit schedule for a specified gateway. By default,
        /// gateways do not have a bandwidth rate limit schedule, which means no bandwidth rate
        /// limiting is in effect. Use this to initiate a gateway's bandwidth rate limit schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBandwidthRateLimitSchedule service method.</param>
        /// 
        /// <returns>The response from the PutBandwidthRateLimitSchedule service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutBandwidthRateLimitSchedule">REST API Reference for PutBandwidthRateLimitSchedule Operation</seealso>
        PutBandwidthRateLimitScheduleResponse PutBandwidthRateLimitSchedule(PutBandwidthRateLimitScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBandwidthRateLimitSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBandwidthRateLimitSchedule operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBandwidthRateLimitSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutBandwidthRateLimitSchedule">REST API Reference for PutBandwidthRateLimitSchedule Operation</seealso>
        IAsyncResult BeginPutBandwidthRateLimitSchedule(PutBandwidthRateLimitScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutBandwidthRateLimitSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBandwidthRateLimitSchedule.</param>
        /// 
        /// <returns>Returns a  PutBandwidthRateLimitScheduleResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutBandwidthRateLimitSchedule">REST API Reference for PutBandwidthRateLimitSchedule Operation</seealso>
        PutBandwidthRateLimitScheduleResponse EndPutBandwidthRateLimitSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  PutHypervisorPropertyMappings


        /// <summary>
        /// This action sets the property mappings for the specified hypervisor. A hypervisor
        /// property mapping displays the relationship of entity properties available from the
        /// on-premises hypervisor to the properties available in Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutHypervisorPropertyMappings service method.</param>
        /// 
        /// <returns>The response from the PutHypervisorPropertyMappings service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutHypervisorPropertyMappings">REST API Reference for PutHypervisorPropertyMappings Operation</seealso>
        PutHypervisorPropertyMappingsResponse PutHypervisorPropertyMappings(PutHypervisorPropertyMappingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutHypervisorPropertyMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutHypervisorPropertyMappings operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutHypervisorPropertyMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutHypervisorPropertyMappings">REST API Reference for PutHypervisorPropertyMappings Operation</seealso>
        IAsyncResult BeginPutHypervisorPropertyMappings(PutHypervisorPropertyMappingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutHypervisorPropertyMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutHypervisorPropertyMappings.</param>
        /// 
        /// <returns>Returns a  PutHypervisorPropertyMappingsResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutHypervisorPropertyMappings">REST API Reference for PutHypervisorPropertyMappings Operation</seealso>
        PutHypervisorPropertyMappingsResponse EndPutHypervisorPropertyMappings(IAsyncResult asyncResult);

        #endregion
        
        #region  PutMaintenanceStartTime


        /// <summary>
        /// Set the maintenance start time for a gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMaintenanceStartTime service method.</param>
        /// 
        /// <returns>The response from the PutMaintenanceStartTime service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutMaintenanceStartTime">REST API Reference for PutMaintenanceStartTime Operation</seealso>
        PutMaintenanceStartTimeResponse PutMaintenanceStartTime(PutMaintenanceStartTimeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMaintenanceStartTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMaintenanceStartTime operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMaintenanceStartTime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutMaintenanceStartTime">REST API Reference for PutMaintenanceStartTime Operation</seealso>
        IAsyncResult BeginPutMaintenanceStartTime(PutMaintenanceStartTimeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMaintenanceStartTime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMaintenanceStartTime.</param>
        /// 
        /// <returns>Returns a  PutMaintenanceStartTimeResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutMaintenanceStartTime">REST API Reference for PutMaintenanceStartTime Operation</seealso>
        PutMaintenanceStartTimeResponse EndPutMaintenanceStartTime(IAsyncResult asyncResult);

        #endregion
        
        #region  StartVirtualMachinesMetadataSync


        /// <summary>
        /// This action sends a request to sync metadata across the specified virtual machines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVirtualMachinesMetadataSync service method.</param>
        /// 
        /// <returns>The response from the StartVirtualMachinesMetadataSync service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/StartVirtualMachinesMetadataSync">REST API Reference for StartVirtualMachinesMetadataSync Operation</seealso>
        StartVirtualMachinesMetadataSyncResponse StartVirtualMachinesMetadataSync(StartVirtualMachinesMetadataSyncRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartVirtualMachinesMetadataSync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartVirtualMachinesMetadataSync operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartVirtualMachinesMetadataSync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/StartVirtualMachinesMetadataSync">REST API Reference for StartVirtualMachinesMetadataSync Operation</seealso>
        IAsyncResult BeginStartVirtualMachinesMetadataSync(StartVirtualMachinesMetadataSyncRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartVirtualMachinesMetadataSync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartVirtualMachinesMetadataSync.</param>
        /// 
        /// <returns>Returns a  StartVirtualMachinesMetadataSyncResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/StartVirtualMachinesMetadataSync">REST API Reference for StartVirtualMachinesMetadataSync Operation</seealso>
        StartVirtualMachinesMetadataSyncResponse EndStartVirtualMachinesMetadataSync(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tag the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TestHypervisorConfiguration


        /// <summary>
        /// Tests your hypervisor configuration to validate that backup gateway can connect with
        /// the hypervisor and its resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestHypervisorConfiguration service method.</param>
        /// 
        /// <returns>The response from the TestHypervisorConfiguration service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/TestHypervisorConfiguration">REST API Reference for TestHypervisorConfiguration Operation</seealso>
        TestHypervisorConfigurationResponse TestHypervisorConfiguration(TestHypervisorConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestHypervisorConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestHypervisorConfiguration operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestHypervisorConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/TestHypervisorConfiguration">REST API Reference for TestHypervisorConfiguration Operation</seealso>
        IAsyncResult BeginTestHypervisorConfiguration(TestHypervisorConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestHypervisorConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestHypervisorConfiguration.</param>
        /// 
        /// <returns>Returns a  TestHypervisorConfigurationResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/TestHypervisorConfiguration">REST API Reference for TestHypervisorConfiguration Operation</seealso>
        TestHypervisorConfigurationResponse EndTestHypervisorConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGatewayInformation


        /// <summary>
        /// Updates a gateway's name. Specify which gateway to update using the Amazon Resource
        /// Name (ARN) of the gateway in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewayInformation service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateGatewayInformation">REST API Reference for UpdateGatewayInformation Operation</seealso>
        UpdateGatewayInformationResponse UpdateGatewayInformation(UpdateGatewayInformationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGatewayInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateGatewayInformation">REST API Reference for UpdateGatewayInformation Operation</seealso>
        IAsyncResult BeginUpdateGatewayInformation(UpdateGatewayInformationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewayInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewayInformation.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayInformationResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateGatewayInformation">REST API Reference for UpdateGatewayInformation Operation</seealso>
        UpdateGatewayInformationResponse EndUpdateGatewayInformation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGatewaySoftwareNow


        /// <summary>
        /// Updates the gateway virtual machine (VM) software. The request immediately triggers
        /// the software update.
        /// 
        ///  <note> 
        /// <para>
        /// When you make this request, you get a <code>200 OK</code> success response immediately.
        /// However, it might take some time for the update to complete.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewaySoftwareNow service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateGatewaySoftwareNow">REST API Reference for UpdateGatewaySoftwareNow Operation</seealso>
        UpdateGatewaySoftwareNowResponse UpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewaySoftwareNow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGatewaySoftwareNow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateGatewaySoftwareNow">REST API Reference for UpdateGatewaySoftwareNow Operation</seealso>
        IAsyncResult BeginUpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewaySoftwareNow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewaySoftwareNow.</param>
        /// 
        /// <returns>Returns a  UpdateGatewaySoftwareNowResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateGatewaySoftwareNow">REST API Reference for UpdateGatewaySoftwareNow Operation</seealso>
        UpdateGatewaySoftwareNowResponse EndUpdateGatewaySoftwareNow(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateHypervisor


        /// <summary>
        /// Updates a hypervisor metadata, including its host, username, and password. Specify
        /// which hypervisor to update using the Amazon Resource Name (ARN) of the hypervisor
        /// in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHypervisor service method.</param>
        /// 
        /// <returns>The response from the UpdateHypervisor service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateHypervisor">REST API Reference for UpdateHypervisor Operation</seealso>
        UpdateHypervisorResponse UpdateHypervisor(UpdateHypervisorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHypervisor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHypervisor operation on AmazonBackupGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHypervisor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateHypervisor">REST API Reference for UpdateHypervisor Operation</seealso>
        IAsyncResult BeginUpdateHypervisor(UpdateHypervisorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHypervisor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHypervisor.</param>
        /// 
        /// <returns>Returns a  UpdateHypervisorResult from BackupGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateHypervisor">REST API Reference for UpdateHypervisor Operation</seealso>
        UpdateHypervisorResponse EndUpdateHypervisor(IAsyncResult asyncResult);

        #endregion
        
    }
}