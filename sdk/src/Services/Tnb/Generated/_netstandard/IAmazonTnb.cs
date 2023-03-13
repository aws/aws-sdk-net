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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Tnb.Model;

namespace Amazon.Tnb
{
    /// <summary>
    /// Interface for accessing Tnb
    ///
    /// Amazon Web Services Telco Network Builder (TNB) is a network automation service that
    /// helps you deploy and manage telecom networks. AWS TNB helps you with the lifecycle
    /// management of your telecommunication network functions throughout planning, deployment,
    /// and post-deployment activities.
    /// </summary>
    public partial interface IAmazonTnb : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITnbPaginatorFactory Paginators { get; }
#endif
                
        #region  CancelSolNetworkOperation



        /// <summary>
        /// Cancels a network operation.
        /// 
        ///  
        /// <para>
        /// A network operation is any operation that is done to your network, such as network
        /// instance instantiation or termination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSolNetworkOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSolNetworkOperation service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CancelSolNetworkOperation">REST API Reference for CancelSolNetworkOperation Operation</seealso>
        Task<CancelSolNetworkOperationResponse> CancelSolNetworkOperationAsync(CancelSolNetworkOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSolFunctionPackage



        /// <summary>
        /// Creates a function package.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network. For more information, see <a href="https://docs.aws.amazon.com/tnb/latest/ug/function-packages.html">Function
        /// packages</a> in the <i>Amazon Web Services Telco Network Builder User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// Creating a function package is the first step for creating a network in AWS TNB. This
        /// request creates an empty container with an ID. The next step is to upload the actual
        /// CSAR zip file into that empty container. To upload function package content, see <a
        /// href="https://docs.aws.amazon.com/tnb/latest/APIReference/API_PutSolFunctionPackageContent.html">PutSolFunctionPackageContent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSolFunctionPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSolFunctionPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ServiceQuotaExceededException">
        /// Service quotas have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CreateSolFunctionPackage">REST API Reference for CreateSolFunctionPackage Operation</seealso>
        Task<CreateSolFunctionPackageResponse> CreateSolFunctionPackageAsync(CreateSolFunctionPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSolNetworkInstance



        /// <summary>
        /// Creates a network instance.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed. Creating a network instance is the third step after creating a network
        /// package. For more information about network instances, <a href="https://docs.aws.amazon.com/tnb/latest/ug/network-instances.html">Network
        /// instances</a> in the <i>Amazon Web Services Telco Network Builder User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Once you create a network instance, you can instantiate it. To instantiate a network,
        /// see <a href="https://docs.aws.amazon.com/tnb/latest/APIReference/API_InstantiateSolNetworkInstance.html">InstantiateSolNetworkInstance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSolNetworkInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSolNetworkInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ServiceQuotaExceededException">
        /// Service quotas have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CreateSolNetworkInstance">REST API Reference for CreateSolNetworkInstance Operation</seealso>
        Task<CreateSolNetworkInstanceResponse> CreateSolNetworkInstanceAsync(CreateSolNetworkInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSolNetworkPackage



        /// <summary>
        /// Creates a network package.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on. For more information, see <a href="https://docs.aws.amazon.com/tnb/latest/ug/network-instances.html">Network
        /// instances</a> in the <i>Amazon Web Services Telco Network Builder User Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// A network package consists of a network service descriptor (NSD) file (required) and
        /// any additional files (optional), such as scripts specific to your needs. For example,
        /// if you have multiple function packages in your network package, you can use the NSD
        /// to define which network functions should run in certain VPCs, subnets, or EKS clusters.
        /// </para>
        ///  
        /// <para>
        /// This request creates an empty network package container with an ID. Once you create
        /// a network package, you can upload the network package content using <a href="https://docs.aws.amazon.com/tnb/latest/APIReference/API_PutSolNetworkPackageContent.html">PutSolNetworkPackageContent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSolNetworkPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSolNetworkPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ServiceQuotaExceededException">
        /// Service quotas have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CreateSolNetworkPackage">REST API Reference for CreateSolNetworkPackage Operation</seealso>
        Task<CreateSolNetworkPackageResponse> CreateSolNetworkPackageAsync(CreateSolNetworkPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSolFunctionPackage



        /// <summary>
        /// Deletes a function package.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        ///  
        /// <para>
        /// To delete a function package, the package must be in a disabled state. To disable
        /// a function package, see <a href="https://docs.aws.amazon.com/tnb/latest/APIReference/API_UpdateSolFunctionPackage.html">UpdateSolFunctionPackage</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSolFunctionPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSolFunctionPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/DeleteSolFunctionPackage">REST API Reference for DeleteSolFunctionPackage Operation</seealso>
        Task<DeleteSolFunctionPackageResponse> DeleteSolFunctionPackageAsync(DeleteSolFunctionPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSolNetworkInstance



        /// <summary>
        /// Deletes a network instance.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed.
        /// </para>
        ///  
        /// <para>
        /// To delete a network instance, the instance must be in a stopped or terminated state.
        /// To terminate a network instance, see <a href="https://docs.aws.amazon.com/tnb/latest/APIReference/API_TerminateSolNetworkInstance.html">TerminateSolNetworkInstance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSolNetworkInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSolNetworkInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/DeleteSolNetworkInstance">REST API Reference for DeleteSolNetworkInstance Operation</seealso>
        Task<DeleteSolNetworkInstanceResponse> DeleteSolNetworkInstanceAsync(DeleteSolNetworkInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSolNetworkPackage



        /// <summary>
        /// Deletes network package.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        ///  
        /// <para>
        /// To delete a network package, the package must be in a disable state. To disable a
        /// network package, see <a href="https://docs.aws.amazon.com/tnb/latest/APIReference/API_UpdateSolNetworkPackage.html">UpdateSolNetworkPackage</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSolNetworkPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSolNetworkPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/DeleteSolNetworkPackage">REST API Reference for DeleteSolNetworkPackage Operation</seealso>
        Task<DeleteSolNetworkPackageResponse> DeleteSolNetworkPackageAsync(DeleteSolNetworkPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSolFunctionInstance



        /// <summary>
        /// Gets the details of a network function instance, including the instantation state
        /// and metadata from the function package descriptor in the network function package.
        /// 
        ///  
        /// <para>
        /// A network function instance is a function in a function package .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolFunctionInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolFunctionInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionInstance">REST API Reference for GetSolFunctionInstance Operation</seealso>
        Task<GetSolFunctionInstanceResponse> GetSolFunctionInstanceAsync(GetSolFunctionInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSolFunctionPackage



        /// <summary>
        /// Gets the details of an individual function package, such as the operational state
        /// and whether the package is in use.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolFunctionPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolFunctionPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionPackage">REST API Reference for GetSolFunctionPackage Operation</seealso>
        Task<GetSolFunctionPackageResponse> GetSolFunctionPackageAsync(GetSolFunctionPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSolFunctionPackageContent



        /// <summary>
        /// Gets the contents of a function package.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolFunctionPackageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolFunctionPackageContent service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionPackageContent">REST API Reference for GetSolFunctionPackageContent Operation</seealso>
        Task<GetSolFunctionPackageContentResponse> GetSolFunctionPackageContentAsync(GetSolFunctionPackageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSolFunctionPackageDescriptor



        /// <summary>
        /// Gets a function package descriptor in a function package.
        /// 
        ///  
        /// <para>
        /// A function package descriptor is a .yaml file in a function package that uses the
        /// TOSCA standard to describe how the network function in the function package should
        /// run on your network.
        /// </para>
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolFunctionPackageDescriptor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolFunctionPackageDescriptor service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionPackageDescriptor">REST API Reference for GetSolFunctionPackageDescriptor Operation</seealso>
        Task<GetSolFunctionPackageDescriptorResponse> GetSolFunctionPackageDescriptorAsync(GetSolFunctionPackageDescriptorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSolNetworkInstance



        /// <summary>
        /// Gets the details of the network instance.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolNetworkInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkInstance">REST API Reference for GetSolNetworkInstance Operation</seealso>
        Task<GetSolNetworkInstanceResponse> GetSolNetworkInstanceAsync(GetSolNetworkInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSolNetworkOperation



        /// <summary>
        /// Gets the details of a network operation, including the tasks involved in the network
        /// operation and the status of the tasks.
        /// 
        ///  
        /// <para>
        /// A network operation is any operation that is done to your network, such as network
        /// instance instantiation or termination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolNetworkOperation service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkOperation">REST API Reference for GetSolNetworkOperation Operation</seealso>
        Task<GetSolNetworkOperationResponse> GetSolNetworkOperationAsync(GetSolNetworkOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSolNetworkPackage



        /// <summary>
        /// Gets the details of a network package.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolNetworkPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkPackage">REST API Reference for GetSolNetworkPackage Operation</seealso>
        Task<GetSolNetworkPackageResponse> GetSolNetworkPackageAsync(GetSolNetworkPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSolNetworkPackageContent



        /// <summary>
        /// Gets the contents of a network package.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkPackageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolNetworkPackageContent service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkPackageContent">REST API Reference for GetSolNetworkPackageContent Operation</seealso>
        Task<GetSolNetworkPackageContentResponse> GetSolNetworkPackageContentAsync(GetSolNetworkPackageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSolNetworkPackageDescriptor



        /// <summary>
        /// Gets the content of the network service descriptor.
        /// 
        ///  
        /// <para>
        /// A network service descriptor is a .yaml file in a network package that uses the TOSCA
        /// standard to describe the network functions you want to deploy and the Amazon Web Services
        /// infrastructure you want to deploy the network functions on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkPackageDescriptor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolNetworkPackageDescriptor service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkPackageDescriptor">REST API Reference for GetSolNetworkPackageDescriptor Operation</seealso>
        Task<GetSolNetworkPackageDescriptorResponse> GetSolNetworkPackageDescriptorAsync(GetSolNetworkPackageDescriptorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InstantiateSolNetworkInstance



        /// <summary>
        /// Instantiates a network instance.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed.
        /// </para>
        ///  
        /// <para>
        /// Before you can instantiate a network instance, you have to create a network instance.
        /// For more information, see <a href="https://docs.aws.amazon.com/tnb/latest/APIReference/API_CreateSolNetworkInstance.html">CreateSolNetworkInstance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InstantiateSolNetworkInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InstantiateSolNetworkInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ServiceQuotaExceededException">
        /// Service quotas have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/InstantiateSolNetworkInstance">REST API Reference for InstantiateSolNetworkInstance Operation</seealso>
        Task<InstantiateSolNetworkInstanceResponse> InstantiateSolNetworkInstanceAsync(InstantiateSolNetworkInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSolFunctionInstances



        /// <summary>
        /// Lists network function instances.
        /// 
        ///  
        /// <para>
        /// A network function instance is a function in a function package .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolFunctionInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSolFunctionInstances service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolFunctionInstances">REST API Reference for ListSolFunctionInstances Operation</seealso>
        Task<ListSolFunctionInstancesResponse> ListSolFunctionInstancesAsync(ListSolFunctionInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSolFunctionPackages



        /// <summary>
        /// Lists information about function packages.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolFunctionPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSolFunctionPackages service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolFunctionPackages">REST API Reference for ListSolFunctionPackages Operation</seealso>
        Task<ListSolFunctionPackagesResponse> ListSolFunctionPackagesAsync(ListSolFunctionPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSolNetworkInstances



        /// <summary>
        /// Lists your network instances.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolNetworkInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSolNetworkInstances service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolNetworkInstances">REST API Reference for ListSolNetworkInstances Operation</seealso>
        Task<ListSolNetworkInstancesResponse> ListSolNetworkInstancesAsync(ListSolNetworkInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSolNetworkOperations



        /// <summary>
        /// Lists details for a network operation, including when the operation started and the
        /// status of the operation.
        /// 
        ///  
        /// <para>
        /// A network operation is any operation that is done to your network, such as network
        /// instance instantiation or termination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolNetworkOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSolNetworkOperations service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolNetworkOperations">REST API Reference for ListSolNetworkOperations Operation</seealso>
        Task<ListSolNetworkOperationsResponse> ListSolNetworkOperationsAsync(ListSolNetworkOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSolNetworkPackages



        /// <summary>
        /// Lists network packages.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolNetworkPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSolNetworkPackages service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolNetworkPackages">REST API Reference for ListSolNetworkPackages Operation</seealso>
        Task<ListSolNetworkPackagesResponse> ListSolNetworkPackagesAsync(ListSolNetworkPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists tags for AWS TNB resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutSolFunctionPackageContent



        /// <summary>
        /// Uploads the contents of a function package.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSolFunctionPackageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSolFunctionPackageContent service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/PutSolFunctionPackageContent">REST API Reference for PutSolFunctionPackageContent Operation</seealso>
        Task<PutSolFunctionPackageContentResponse> PutSolFunctionPackageContentAsync(PutSolFunctionPackageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutSolNetworkPackageContent



        /// <summary>
        /// Uploads the contents of a network package.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSolNetworkPackageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSolNetworkPackageContent service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/PutSolNetworkPackageContent">REST API Reference for PutSolNetworkPackageContent Operation</seealso>
        Task<PutSolNetworkPackageContentResponse> PutSolNetworkPackageContentAsync(PutSolNetworkPackageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Tags an AWS TNB resource.
        /// 
        ///  
        /// <para>
        /// A tag is a label that you assign to an Amazon Web Services resource. Each tag consists
        /// of a key and an optional value. You can use tags to search and filter your resources
        /// or track your Amazon Web Services costs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TerminateSolNetworkInstance



        /// <summary>
        /// Terminates a network instance.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed.
        /// </para>
        ///  
        /// <para>
        /// You must terminate a network instance before you can delete it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateSolNetworkInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateSolNetworkInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ServiceQuotaExceededException">
        /// Service quotas have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/TerminateSolNetworkInstance">REST API Reference for TerminateSolNetworkInstance Operation</seealso>
        Task<TerminateSolNetworkInstanceResponse> TerminateSolNetworkInstanceAsync(TerminateSolNetworkInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Untags an AWS TNB resource.
        /// 
        ///  
        /// <para>
        /// A tag is a label that you assign to an Amazon Web Services resource. Each tag consists
        /// of a key and an optional value. You can use tags to search and filter your resources
        /// or track your Amazon Web Services costs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSolFunctionPackage



        /// <summary>
        /// Updates the operational state of function package.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSolFunctionPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSolFunctionPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UpdateSolFunctionPackage">REST API Reference for UpdateSolFunctionPackage Operation</seealso>
        Task<UpdateSolFunctionPackageResponse> UpdateSolFunctionPackageAsync(UpdateSolFunctionPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSolNetworkInstance



        /// <summary>
        /// Update a network instance.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSolNetworkInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSolNetworkInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ServiceQuotaExceededException">
        /// Service quotas have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UpdateSolNetworkInstance">REST API Reference for UpdateSolNetworkInstance Operation</seealso>
        Task<UpdateSolNetworkInstanceResponse> UpdateSolNetworkInstanceAsync(UpdateSolNetworkInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSolNetworkPackage



        /// <summary>
        /// Updates the operational state of a network package.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        ///  
        /// <para>
        /// A network service descriptor is a .yaml file in a network package that uses the TOSCA
        /// standard to describe the network functions you want to deploy and the Amazon Web Services
        /// infrastructure you want to deploy the network functions on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSolNetworkPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSolNetworkPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UpdateSolNetworkPackage">REST API Reference for UpdateSolNetworkPackage Operation</seealso>
        Task<UpdateSolNetworkPackageResponse> UpdateSolNetworkPackageAsync(UpdateSolNetworkPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ValidateSolFunctionPackageContent



        /// <summary>
        /// Validates function package content. This can be used as a dry run before uploading
        /// function package content with <a href="https://docs.aws.amazon.com/tnb/latest/APIReference/API_PutSolFunctionPackageContent.html">PutSolFunctionPackageContent</a>.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateSolFunctionPackageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateSolFunctionPackageContent service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ValidateSolFunctionPackageContent">REST API Reference for ValidateSolFunctionPackageContent Operation</seealso>
        Task<ValidateSolFunctionPackageContentResponse> ValidateSolFunctionPackageContentAsync(ValidateSolFunctionPackageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ValidateSolNetworkPackageContent



        /// <summary>
        /// Validates network package content. This can be used as a dry run before uploading
        /// network package content with <a href="https://docs.aws.amazon.com/tnb/latest/APIReference/API_PutSolNetworkPackageContent.html">PutSolNetworkPackageContent</a>.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateSolNetworkPackageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateSolNetworkPackageContent service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ValidateSolNetworkPackageContent">REST API Reference for ValidateSolNetworkPackageContent Operation</seealso>
        Task<ValidateSolNetworkPackageContentResponse> ValidateSolNetworkPackageContentAsync(ValidateSolNetworkPackageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}