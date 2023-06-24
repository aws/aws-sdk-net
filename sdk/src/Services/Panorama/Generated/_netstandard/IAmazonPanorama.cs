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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Panorama.Model;

namespace Amazon.Panorama
{
    /// <summary>
    /// Interface for accessing Panorama
    ///
    /// AWS Panorama 
    /// <para>
    ///  <b>Overview</b> 
    /// 
    ///  
    /// <para>
    /// This is the <i>AWS Panorama API Reference</i>. For an introduction to the service,
    /// see <a href="https://docs.aws.amazon.com/panorama/latest/dev/panorama-welcome.html">What
    /// is AWS Panorama?</a> in the <i>AWS Panorama Developer Guide</i>.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonPanorama : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPanoramaPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateApplicationInstance



        /// <summary>
        /// Creates an application instance and deploys it to a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplicationInstance service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ServiceQuotaExceededException">
        /// The request would cause a limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateApplicationInstance">REST API Reference for CreateApplicationInstance Operation</seealso>
        Task<CreateApplicationInstanceResponse> CreateApplicationInstanceAsync(CreateApplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateJobForDevices



        /// <summary>
        /// Creates a job to run on a device. A job can update a device's software or reboot it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobForDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJobForDevices service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateJobForDevices">REST API Reference for CreateJobForDevices Operation</seealso>
        Task<CreateJobForDevicesResponse> CreateJobForDevicesAsync(CreateJobForDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNodeFromTemplateJob



        /// <summary>
        /// Creates a camera stream node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNodeFromTemplateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNodeFromTemplateJob service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateNodeFromTemplateJob">REST API Reference for CreateNodeFromTemplateJob Operation</seealso>
        Task<CreateNodeFromTemplateJobResponse> CreateNodeFromTemplateJobAsync(CreateNodeFromTemplateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePackage



        /// <summary>
        /// Creates a package and storage location in an Amazon S3 access point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePackage service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        Task<CreatePackageResponse> CreatePackageAsync(CreatePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePackageImportJob



        /// <summary>
        /// Imports a node package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackageImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePackageImportJob service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreatePackageImportJob">REST API Reference for CreatePackageImportJob Operation</seealso>
        Task<CreatePackageImportJobResponse> CreatePackageImportJobAsync(CreatePackageImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDevice



        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDevice service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePackage



        /// <summary>
        /// Deletes a package.
        /// 
        ///  <note> 
        /// <para>
        /// To delete a package, you need permission to call <code>s3:DeleteObject</code> in addition
        /// to permissions for the AWS Panorama API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePackage service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        Task<DeletePackageResponse> DeletePackageAsync(DeletePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterPackageVersion



        /// <summary>
        /// Deregisters a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPackageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterPackageVersion service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeregisterPackageVersion">REST API Reference for DeregisterPackageVersion Operation</seealso>
        Task<DeregisterPackageVersionResponse> DeregisterPackageVersionAsync(DeregisterPackageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeApplicationInstance



        /// <summary>
        /// Returns information about an application instance on a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationInstance service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeApplicationInstance">REST API Reference for DescribeApplicationInstance Operation</seealso>
        Task<DescribeApplicationInstanceResponse> DescribeApplicationInstanceAsync(DescribeApplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeApplicationInstanceDetails



        /// <summary>
        /// Returns information about an application instance's configuration manifest.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationInstanceDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationInstanceDetails service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeApplicationInstanceDetails">REST API Reference for DescribeApplicationInstanceDetails Operation</seealso>
        Task<DescribeApplicationInstanceDetailsResponse> DescribeApplicationInstanceDetailsAsync(DescribeApplicationInstanceDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDevice



        /// <summary>
        /// Returns information about a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDevice service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        Task<DescribeDeviceResponse> DescribeDeviceAsync(DescribeDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDeviceJob



        /// <summary>
        /// Returns information about a device job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeviceJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeviceJob service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeDeviceJob">REST API Reference for DescribeDeviceJob Operation</seealso>
        Task<DescribeDeviceJobResponse> DescribeDeviceJobAsync(DescribeDeviceJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNode



        /// <summary>
        /// Returns information about a node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNode service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeNode">REST API Reference for DescribeNode Operation</seealso>
        Task<DescribeNodeResponse> DescribeNodeAsync(DescribeNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNodeFromTemplateJob



        /// <summary>
        /// Returns information about a job to create a camera stream node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeFromTemplateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNodeFromTemplateJob service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeNodeFromTemplateJob">REST API Reference for DescribeNodeFromTemplateJob Operation</seealso>
        Task<DescribeNodeFromTemplateJobResponse> DescribeNodeFromTemplateJobAsync(DescribeNodeFromTemplateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePackage



        /// <summary>
        /// Returns information about a package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePackage service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackage">REST API Reference for DescribePackage Operation</seealso>
        Task<DescribePackageResponse> DescribePackageAsync(DescribePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePackageImportJob



        /// <summary>
        /// Returns information about a package import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePackageImportJob service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackageImportJob">REST API Reference for DescribePackageImportJob Operation</seealso>
        Task<DescribePackageImportJobResponse> DescribePackageImportJobAsync(DescribePackageImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePackageVersion



        /// <summary>
        /// Returns information about a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePackageVersion service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackageVersion">REST API Reference for DescribePackageVersion Operation</seealso>
        Task<DescribePackageVersionResponse> DescribePackageVersionAsync(DescribePackageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplicationInstanceDependencies



        /// <summary>
        /// Returns a list of application instance dependencies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstanceDependencies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationInstanceDependencies service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceDependencies">REST API Reference for ListApplicationInstanceDependencies Operation</seealso>
        Task<ListApplicationInstanceDependenciesResponse> ListApplicationInstanceDependenciesAsync(ListApplicationInstanceDependenciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplicationInstanceNodeInstances



        /// <summary>
        /// Returns a list of application node instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstanceNodeInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationInstanceNodeInstances service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceNodeInstances">REST API Reference for ListApplicationInstanceNodeInstances Operation</seealso>
        Task<ListApplicationInstanceNodeInstancesResponse> ListApplicationInstanceNodeInstancesAsync(ListApplicationInstanceNodeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplicationInstances



        /// <summary>
        /// Returns a list of application instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationInstances service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstances">REST API Reference for ListApplicationInstances Operation</seealso>
        Task<ListApplicationInstancesResponse> ListApplicationInstancesAsync(ListApplicationInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDevices



        /// <summary>
        /// Returns a list of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListDevices">REST API Reference for ListDevices Operation</seealso>
        Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDevicesJobs



        /// <summary>
        /// Returns a list of jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevicesJobs service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListDevicesJobs">REST API Reference for ListDevicesJobs Operation</seealso>
        Task<ListDevicesJobsResponse> ListDevicesJobsAsync(ListDevicesJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNodeFromTemplateJobs



        /// <summary>
        /// Returns a list of camera stream node jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodeFromTemplateJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNodeFromTemplateJobs service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListNodeFromTemplateJobs">REST API Reference for ListNodeFromTemplateJobs Operation</seealso>
        Task<ListNodeFromTemplateJobsResponse> ListNodeFromTemplateJobsAsync(ListNodeFromTemplateJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNodes



        /// <summary>
        /// Returns a list of nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNodes service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListNodes">REST API Reference for ListNodes Operation</seealso>
        Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPackageImportJobs



        /// <summary>
        /// Returns a list of package import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackageImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPackageImportJobs service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListPackageImportJobs">REST API Reference for ListPackageImportJobs Operation</seealso>
        Task<ListPackageImportJobsResponse> ListPackageImportJobsAsync(ListPackageImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPackages



        /// <summary>
        /// Returns a list of packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPackages service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListPackages">REST API Reference for ListPackages Operation</seealso>
        Task<ListPackagesResponse> ListPackagesAsync(ListPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ProvisionDevice



        /// <summary>
        /// Creates a device and returns a configuration archive. The configuration archive is
        /// a ZIP file that contains a provisioning certificate that is valid for 5 minutes. Name
        /// the configuration archive <code>certificates-omni_<i>device-name</i>.zip</code> and
        /// transfer it to the device within 5 minutes. Use the included USB storage device and
        /// connect it to the USB 3.0 port next to the HDMI output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ProvisionDevice service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ServiceQuotaExceededException">
        /// The request would cause a limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ProvisionDevice">REST API Reference for ProvisionDevice Operation</seealso>
        Task<ProvisionDeviceResponse> ProvisionDeviceAsync(ProvisionDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterPackageVersion



        /// <summary>
        /// Registers a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterPackageVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterPackageVersion service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/RegisterPackageVersion">REST API Reference for RegisterPackageVersion Operation</seealso>
        Task<RegisterPackageVersionResponse> RegisterPackageVersionAsync(RegisterPackageVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveApplicationInstance



        /// <summary>
        /// Removes an application instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveApplicationInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveApplicationInstance service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/RemoveApplicationInstance">REST API Reference for RemoveApplicationInstance Operation</seealso>
        Task<RemoveApplicationInstanceResponse> RemoveApplicationInstanceAsync(RemoveApplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SignalApplicationInstanceNodeInstances



        /// <summary>
        /// Signal camera nodes to stop or resume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalApplicationInstanceNodeInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SignalApplicationInstanceNodeInstances service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ServiceQuotaExceededException">
        /// The request would cause a limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/SignalApplicationInstanceNodeInstances">REST API Reference for SignalApplicationInstanceNodeInstances Operation</seealso>
        Task<SignalApplicationInstanceNodeInstancesResponse> SignalApplicationInstanceNodeInstancesAsync(SignalApplicationInstanceNodeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDeviceMetadata



        /// <summary>
        /// Updates a device's metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeviceMetadata service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ConflictException">
        /// The target resource is in use.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ResourceNotFoundException">
        /// The target resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/UpdateDeviceMetadata">REST API Reference for UpdateDeviceMetadata Operation</seealso>
        Task<UpdateDeviceMetadataResponse> UpdateDeviceMetadataAsync(UpdateDeviceMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}