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
using System.Threading;
using System.Threading.Tasks;
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
#if AWS_ASYNC_ENUMERABLES_API
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociateGatewayToServerResponse> AssociateGatewayToServerAsync(AssociateGatewayToServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGateway



        /// <summary>
        /// Creates a backup gateway. After you create a gateway, you can associate it with a
        /// server using the <code>AssociateGatewayToServer</code> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateGatewayResponse> CreateGatewayAsync(CreateGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGateway



        /// <summary>
        /// Deletes a backup gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHypervisor



        /// <summary>
        /// Deletes a hypervisor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHypervisor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteHypervisorResponse> DeleteHypervisorAsync(DeleteHypervisorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateGatewayFromServer



        /// <summary>
        /// Disassociates a backup gateway from the specified server. After the disassociation
        /// process finishes, the gateway can no longer access the virtual machines on the server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateGatewayFromServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateGatewayFromServerResponse> DisassociateGatewayFromServerAsync(DisassociateGatewayFromServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBandwidthRateLimitSchedule



        /// <summary>
        /// Retrieves the bandwidth rate limit schedule for a specified gateway. By default, gateways
        /// do not have bandwidth rate limit schedules, which means no bandwidth rate limiting
        /// is in effect. Use this to get a gateway's bandwidth rate limit schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBandwidthRateLimitSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetBandwidthRateLimitScheduleResponse> GetBandwidthRateLimitScheduleAsync(GetBandwidthRateLimitScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGateway



        /// <summary>
        /// By providing the ARN (Amazon Resource Name), this API returns the gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetGatewayResponse> GetGatewayAsync(GetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHypervisor



        /// <summary>
        /// This action requests information about the specified hypervisor to which the gateway
        /// will connect. A hypervisor is hardware, software, or firmware that creates and manages
        /// virtual machines, and allocates resources to them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHypervisor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetHypervisorResponse> GetHypervisorAsync(GetHypervisorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHypervisorPropertyMappings



        /// <summary>
        /// This action retrieves the property mappings for the specified hypervisor. A hypervisor
        /// property mapping displays the relationship of entity properties available from the
        /// on-premises hypervisor to the properties available in Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHypervisorPropertyMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetHypervisorPropertyMappingsResponse> GetHypervisorPropertyMappingsAsync(GetHypervisorPropertyMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVirtualMachine



        /// <summary>
        /// By providing the ARN (Amazon Resource Name), this API returns the virtual machine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVirtualMachine service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetVirtualMachineResponse> GetVirtualMachineAsync(GetVirtualMachineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportHypervisorConfiguration



        /// <summary>
        /// Connect to a hypervisor by importing its configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportHypervisorConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ImportHypervisorConfigurationResponse> ImportHypervisorConfigurationAsync(ImportHypervisorConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGateways



        /// <summary>
        /// Lists backup gateways owned by an Amazon Web Services account in an Amazon Web Services
        /// Region. The returned list is ordered by gateway Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHypervisors



        /// <summary>
        /// Lists your hypervisors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHypervisors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListHypervisorsResponse> ListHypervisorsAsync(ListHypervisorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags applied to the resource identified by its Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVirtualMachines



        /// <summary>
        /// Lists your virtual machines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMachines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListVirtualMachinesResponse> ListVirtualMachinesAsync(ListVirtualMachinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutBandwidthRateLimitSchedule



        /// <summary>
        /// This action sets the bandwidth rate limit schedule for a specified gateway. By default,
        /// gateways do not have a bandwidth rate limit schedule, which means no bandwidth rate
        /// limiting is in effect. Use this to initiate a gateway's bandwidth rate limit schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBandwidthRateLimitSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutBandwidthRateLimitScheduleResponse> PutBandwidthRateLimitScheduleAsync(PutBandwidthRateLimitScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutHypervisorPropertyMappings



        /// <summary>
        /// This action sets the property mappings for the specified hypervisor. A hypervisor
        /// property mapping displays the relationship of entity properties available from the
        /// on-premises hypervisor to the properties available in Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutHypervisorPropertyMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutHypervisorPropertyMappingsResponse> PutHypervisorPropertyMappingsAsync(PutHypervisorPropertyMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutMaintenanceStartTime



        /// <summary>
        /// Set the maintenance start time for a gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMaintenanceStartTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutMaintenanceStartTimeResponse> PutMaintenanceStartTimeAsync(PutMaintenanceStartTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartVirtualMachinesMetadataSync



        /// <summary>
        /// This action sends a request to sync metadata across the specified virtual machines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVirtualMachinesMetadataSync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartVirtualMachinesMetadataSyncResponse> StartVirtualMachinesMetadataSyncAsync(StartVirtualMachinesMetadataSyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Tag the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestHypervisorConfiguration



        /// <summary>
        /// Tests your hypervisor configuration to validate that backup gateway can connect with
        /// the hypervisor and its resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestHypervisorConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TestHypervisorConfigurationResponse> TestHypervisorConfigurationAsync(TestHypervisorConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGatewayInformation



        /// <summary>
        /// Updates a gateway's name. Specify which gateway to update using the Amazon Resource
        /// Name (ARN) of the gateway in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateGatewayInformationResponse> UpdateGatewayInformationAsync(UpdateGatewayInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateGatewaySoftwareNowResponse> UpdateGatewaySoftwareNowAsync(UpdateGatewaySoftwareNowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHypervisor



        /// <summary>
        /// Updates a hypervisor metadata, including its host, username, and password. Specify
        /// which hypervisor to update using the Amazon Resource Name (ARN) of the hypervisor
        /// in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHypervisor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateHypervisorResponse> UpdateHypervisorAsync(UpdateHypervisorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}