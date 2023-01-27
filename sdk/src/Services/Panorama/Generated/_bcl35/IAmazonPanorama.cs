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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        CreateApplicationInstanceResponse CreateApplicationInstance(CreateApplicationInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationInstance operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplicationInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateApplicationInstance">REST API Reference for CreateApplicationInstance Operation</seealso>
        IAsyncResult BeginCreateApplicationInstance(CreateApplicationInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplicationInstance.</param>
        /// 
        /// <returns>Returns a  CreateApplicationInstanceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateApplicationInstance">REST API Reference for CreateApplicationInstance Operation</seealso>
        CreateApplicationInstanceResponse EndCreateApplicationInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateJobForDevices


        /// <summary>
        /// Creates a job to run on a device. A job can update a device's software or reboot it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobForDevices service method.</param>
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
        CreateJobForDevicesResponse CreateJobForDevices(CreateJobForDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJobForDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJobForDevices operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJobForDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateJobForDevices">REST API Reference for CreateJobForDevices Operation</seealso>
        IAsyncResult BeginCreateJobForDevices(CreateJobForDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJobForDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJobForDevices.</param>
        /// 
        /// <returns>Returns a  CreateJobForDevicesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateJobForDevices">REST API Reference for CreateJobForDevices Operation</seealso>
        CreateJobForDevicesResponse EndCreateJobForDevices(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNodeFromTemplateJob


        /// <summary>
        /// Creates a camera stream node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNodeFromTemplateJob service method.</param>
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
        CreateNodeFromTemplateJobResponse CreateNodeFromTemplateJob(CreateNodeFromTemplateJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNodeFromTemplateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNodeFromTemplateJob operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNodeFromTemplateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateNodeFromTemplateJob">REST API Reference for CreateNodeFromTemplateJob Operation</seealso>
        IAsyncResult BeginCreateNodeFromTemplateJob(CreateNodeFromTemplateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNodeFromTemplateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNodeFromTemplateJob.</param>
        /// 
        /// <returns>Returns a  CreateNodeFromTemplateJobResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreateNodeFromTemplateJob">REST API Reference for CreateNodeFromTemplateJob Operation</seealso>
        CreateNodeFromTemplateJobResponse EndCreateNodeFromTemplateJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePackage


        /// <summary>
        /// Creates a package and storage location in an Amazon S3 access point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage service method.</param>
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
        CreatePackageResponse CreatePackage(CreatePackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        IAsyncResult BeginCreatePackage(CreatePackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePackage.</param>
        /// 
        /// <returns>Returns a  CreatePackageResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        CreatePackageResponse EndCreatePackage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePackageImportJob


        /// <summary>
        /// Imports a node package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackageImportJob service method.</param>
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
        CreatePackageImportJobResponse CreatePackageImportJob(CreatePackageImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePackageImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePackageImportJob operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePackageImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreatePackageImportJob">REST API Reference for CreatePackageImportJob Operation</seealso>
        IAsyncResult BeginCreatePackageImportJob(CreatePackageImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePackageImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePackageImportJob.</param>
        /// 
        /// <returns>Returns a  CreatePackageImportJobResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/CreatePackageImportJob">REST API Reference for CreatePackageImportJob Operation</seealso>
        CreatePackageImportJobResponse EndCreatePackageImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDevice


        /// <summary>
        /// Deletes a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice service method.</param>
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
        DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        IAsyncResult BeginDeleteDevice(DeleteDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDevice.</param>
        /// 
        /// <returns>Returns a  DeleteDeviceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        DeleteDeviceResponse EndDeleteDevice(IAsyncResult asyncResult);

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
        DeletePackageResponse DeletePackage(DeletePackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        IAsyncResult BeginDeletePackage(DeletePackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePackage.</param>
        /// 
        /// <returns>Returns a  DeletePackageResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        DeletePackageResponse EndDeletePackage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterPackageVersion


        /// <summary>
        /// Deregisters a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPackageVersion service method.</param>
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
        DeregisterPackageVersionResponse DeregisterPackageVersion(DeregisterPackageVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterPackageVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPackageVersion operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterPackageVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeregisterPackageVersion">REST API Reference for DeregisterPackageVersion Operation</seealso>
        IAsyncResult BeginDeregisterPackageVersion(DeregisterPackageVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterPackageVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterPackageVersion.</param>
        /// 
        /// <returns>Returns a  DeregisterPackageVersionResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DeregisterPackageVersion">REST API Reference for DeregisterPackageVersion Operation</seealso>
        DeregisterPackageVersionResponse EndDeregisterPackageVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApplicationInstance


        /// <summary>
        /// Returns information about an application instance on a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationInstance service method.</param>
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
        DescribeApplicationInstanceResponse DescribeApplicationInstance(DescribeApplicationInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationInstance operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeApplicationInstance">REST API Reference for DescribeApplicationInstance Operation</seealso>
        IAsyncResult BeginDescribeApplicationInstance(DescribeApplicationInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationInstance.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationInstanceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeApplicationInstance">REST API Reference for DescribeApplicationInstance Operation</seealso>
        DescribeApplicationInstanceResponse EndDescribeApplicationInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApplicationInstanceDetails


        /// <summary>
        /// Returns information about an application instance's configuration manifest.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationInstanceDetails service method.</param>
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
        DescribeApplicationInstanceDetailsResponse DescribeApplicationInstanceDetails(DescribeApplicationInstanceDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationInstanceDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationInstanceDetails operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationInstanceDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeApplicationInstanceDetails">REST API Reference for DescribeApplicationInstanceDetails Operation</seealso>
        IAsyncResult BeginDescribeApplicationInstanceDetails(DescribeApplicationInstanceDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationInstanceDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationInstanceDetails.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationInstanceDetailsResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeApplicationInstanceDetails">REST API Reference for DescribeApplicationInstanceDetails Operation</seealso>
        DescribeApplicationInstanceDetailsResponse EndDescribeApplicationInstanceDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDevice


        /// <summary>
        /// Returns information about a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
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
        DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        IAsyncResult BeginDescribeDevice(DescribeDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDevice.</param>
        /// 
        /// <returns>Returns a  DescribeDeviceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        DescribeDeviceResponse EndDescribeDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDeviceJob


        /// <summary>
        /// Returns information about a device job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeviceJob service method.</param>
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
        DescribeDeviceJobResponse DescribeDeviceJob(DescribeDeviceJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeviceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeviceJob operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeviceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeDeviceJob">REST API Reference for DescribeDeviceJob Operation</seealso>
        IAsyncResult BeginDescribeDeviceJob(DescribeDeviceJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeviceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeviceJob.</param>
        /// 
        /// <returns>Returns a  DescribeDeviceJobResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeDeviceJob">REST API Reference for DescribeDeviceJob Operation</seealso>
        DescribeDeviceJobResponse EndDescribeDeviceJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNode


        /// <summary>
        /// Returns information about a node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNode service method.</param>
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
        DescribeNodeResponse DescribeNode(DescribeNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNode operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeNode">REST API Reference for DescribeNode Operation</seealso>
        IAsyncResult BeginDescribeNode(DescribeNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNode.</param>
        /// 
        /// <returns>Returns a  DescribeNodeResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeNode">REST API Reference for DescribeNode Operation</seealso>
        DescribeNodeResponse EndDescribeNode(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNodeFromTemplateJob


        /// <summary>
        /// Returns information about a job to create a camera stream node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeFromTemplateJob service method.</param>
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
        DescribeNodeFromTemplateJobResponse DescribeNodeFromTemplateJob(DescribeNodeFromTemplateJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNodeFromTemplateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeFromTemplateJob operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNodeFromTemplateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeNodeFromTemplateJob">REST API Reference for DescribeNodeFromTemplateJob Operation</seealso>
        IAsyncResult BeginDescribeNodeFromTemplateJob(DescribeNodeFromTemplateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNodeFromTemplateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNodeFromTemplateJob.</param>
        /// 
        /// <returns>Returns a  DescribeNodeFromTemplateJobResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribeNodeFromTemplateJob">REST API Reference for DescribeNodeFromTemplateJob Operation</seealso>
        DescribeNodeFromTemplateJobResponse EndDescribeNodeFromTemplateJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePackage


        /// <summary>
        /// Returns information about a package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackage service method.</param>
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
        DescribePackageResponse DescribePackage(DescribePackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackage operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackage">REST API Reference for DescribePackage Operation</seealso>
        IAsyncResult BeginDescribePackage(DescribePackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePackage.</param>
        /// 
        /// <returns>Returns a  DescribePackageResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackage">REST API Reference for DescribePackage Operation</seealso>
        DescribePackageResponse EndDescribePackage(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePackageImportJob


        /// <summary>
        /// Returns information about a package import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageImportJob service method.</param>
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
        DescribePackageImportJobResponse DescribePackageImportJob(DescribePackageImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackageImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageImportJob operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePackageImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackageImportJob">REST API Reference for DescribePackageImportJob Operation</seealso>
        IAsyncResult BeginDescribePackageImportJob(DescribePackageImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePackageImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePackageImportJob.</param>
        /// 
        /// <returns>Returns a  DescribePackageImportJobResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackageImportJob">REST API Reference for DescribePackageImportJob Operation</seealso>
        DescribePackageImportJobResponse EndDescribePackageImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePackageVersion


        /// <summary>
        /// Returns information about a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageVersion service method.</param>
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
        DescribePackageVersionResponse DescribePackageVersion(DescribePackageVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackageVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackageVersion operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePackageVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackageVersion">REST API Reference for DescribePackageVersion Operation</seealso>
        IAsyncResult BeginDescribePackageVersion(DescribePackageVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePackageVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePackageVersion.</param>
        /// 
        /// <returns>Returns a  DescribePackageVersionResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/DescribePackageVersion">REST API Reference for DescribePackageVersion Operation</seealso>
        DescribePackageVersionResponse EndDescribePackageVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplicationInstanceDependencies


        /// <summary>
        /// Returns a list of application instance dependencies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstanceDependencies service method.</param>
        /// 
        /// <returns>The response from the ListApplicationInstanceDependencies service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceDependencies">REST API Reference for ListApplicationInstanceDependencies Operation</seealso>
        ListApplicationInstanceDependenciesResponse ListApplicationInstanceDependencies(ListApplicationInstanceDependenciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationInstanceDependencies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstanceDependencies operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationInstanceDependencies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceDependencies">REST API Reference for ListApplicationInstanceDependencies Operation</seealso>
        IAsyncResult BeginListApplicationInstanceDependencies(ListApplicationInstanceDependenciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationInstanceDependencies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationInstanceDependencies.</param>
        /// 
        /// <returns>Returns a  ListApplicationInstanceDependenciesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceDependencies">REST API Reference for ListApplicationInstanceDependencies Operation</seealso>
        ListApplicationInstanceDependenciesResponse EndListApplicationInstanceDependencies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplicationInstanceNodeInstances


        /// <summary>
        /// Returns a list of application node instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstanceNodeInstances service method.</param>
        /// 
        /// <returns>The response from the ListApplicationInstanceNodeInstances service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceNodeInstances">REST API Reference for ListApplicationInstanceNodeInstances Operation</seealso>
        ListApplicationInstanceNodeInstancesResponse ListApplicationInstanceNodeInstances(ListApplicationInstanceNodeInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationInstanceNodeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstanceNodeInstances operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationInstanceNodeInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceNodeInstances">REST API Reference for ListApplicationInstanceNodeInstances Operation</seealso>
        IAsyncResult BeginListApplicationInstanceNodeInstances(ListApplicationInstanceNodeInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationInstanceNodeInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationInstanceNodeInstances.</param>
        /// 
        /// <returns>Returns a  ListApplicationInstanceNodeInstancesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstanceNodeInstances">REST API Reference for ListApplicationInstanceNodeInstances Operation</seealso>
        ListApplicationInstanceNodeInstancesResponse EndListApplicationInstanceNodeInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplicationInstances


        /// <summary>
        /// Returns a list of application instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstances service method.</param>
        /// 
        /// <returns>The response from the ListApplicationInstances service method, as returned by Panorama.</returns>
        /// <exception cref="Amazon.Panorama.Model.AccessDeniedException">
        /// The requestor does not have permission to access the target action or resource.
        /// </exception>
        /// <exception cref="Amazon.Panorama.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstances">REST API Reference for ListApplicationInstances Operation</seealso>
        ListApplicationInstancesResponse ListApplicationInstances(ListApplicationInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationInstances operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstances">REST API Reference for ListApplicationInstances Operation</seealso>
        IAsyncResult BeginListApplicationInstances(ListApplicationInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationInstances.</param>
        /// 
        /// <returns>Returns a  ListApplicationInstancesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListApplicationInstances">REST API Reference for ListApplicationInstances Operation</seealso>
        ListApplicationInstancesResponse EndListApplicationInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDevices


        /// <summary>
        /// Returns a list of devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
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
        ListDevicesResponse ListDevices(ListDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListDevices">REST API Reference for ListDevices Operation</seealso>
        IAsyncResult BeginListDevices(ListDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevices.</param>
        /// 
        /// <returns>Returns a  ListDevicesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListDevices">REST API Reference for ListDevices Operation</seealso>
        ListDevicesResponse EndListDevices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDevicesJobs


        /// <summary>
        /// Returns a list of jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesJobs service method.</param>
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
        ListDevicesJobsResponse ListDevicesJobs(ListDevicesJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevicesJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesJobs operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevicesJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListDevicesJobs">REST API Reference for ListDevicesJobs Operation</seealso>
        IAsyncResult BeginListDevicesJobs(ListDevicesJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevicesJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevicesJobs.</param>
        /// 
        /// <returns>Returns a  ListDevicesJobsResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListDevicesJobs">REST API Reference for ListDevicesJobs Operation</seealso>
        ListDevicesJobsResponse EndListDevicesJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNodeFromTemplateJobs


        /// <summary>
        /// Returns a list of camera stream node jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodeFromTemplateJobs service method.</param>
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
        ListNodeFromTemplateJobsResponse ListNodeFromTemplateJobs(ListNodeFromTemplateJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNodeFromTemplateJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNodeFromTemplateJobs operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNodeFromTemplateJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListNodeFromTemplateJobs">REST API Reference for ListNodeFromTemplateJobs Operation</seealso>
        IAsyncResult BeginListNodeFromTemplateJobs(ListNodeFromTemplateJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNodeFromTemplateJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNodeFromTemplateJobs.</param>
        /// 
        /// <returns>Returns a  ListNodeFromTemplateJobsResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListNodeFromTemplateJobs">REST API Reference for ListNodeFromTemplateJobs Operation</seealso>
        ListNodeFromTemplateJobsResponse EndListNodeFromTemplateJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNodes


        /// <summary>
        /// Returns a list of nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodes service method.</param>
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
        ListNodesResponse ListNodes(ListNodesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNodes operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListNodes">REST API Reference for ListNodes Operation</seealso>
        IAsyncResult BeginListNodes(ListNodesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNodes.</param>
        /// 
        /// <returns>Returns a  ListNodesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListNodes">REST API Reference for ListNodes Operation</seealso>
        ListNodesResponse EndListNodes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPackageImportJobs


        /// <summary>
        /// Returns a list of package import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackageImportJobs service method.</param>
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
        ListPackageImportJobsResponse ListPackageImportJobs(ListPackageImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPackageImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackageImportJobs operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPackageImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListPackageImportJobs">REST API Reference for ListPackageImportJobs Operation</seealso>
        IAsyncResult BeginListPackageImportJobs(ListPackageImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPackageImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPackageImportJobs.</param>
        /// 
        /// <returns>Returns a  ListPackageImportJobsResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListPackageImportJobs">REST API Reference for ListPackageImportJobs Operation</seealso>
        ListPackageImportJobsResponse EndListPackageImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPackages


        /// <summary>
        /// Returns a list of packages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackages service method.</param>
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
        ListPackagesResponse ListPackages(ListPackagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackages operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListPackages">REST API Reference for ListPackages Operation</seealso>
        IAsyncResult BeginListPackages(ListPackagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPackages.</param>
        /// 
        /// <returns>Returns a  ListPackagesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListPackages">REST API Reference for ListPackages Operation</seealso>
        ListPackagesResponse EndListPackages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        ProvisionDeviceResponse ProvisionDevice(ProvisionDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ProvisionDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ProvisionDevice operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndProvisionDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ProvisionDevice">REST API Reference for ProvisionDevice Operation</seealso>
        IAsyncResult BeginProvisionDevice(ProvisionDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ProvisionDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginProvisionDevice.</param>
        /// 
        /// <returns>Returns a  ProvisionDeviceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/ProvisionDevice">REST API Reference for ProvisionDevice Operation</seealso>
        ProvisionDeviceResponse EndProvisionDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterPackageVersion


        /// <summary>
        /// Registers a package version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterPackageVersion service method.</param>
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
        RegisterPackageVersionResponse RegisterPackageVersion(RegisterPackageVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterPackageVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterPackageVersion operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterPackageVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/RegisterPackageVersion">REST API Reference for RegisterPackageVersion Operation</seealso>
        IAsyncResult BeginRegisterPackageVersion(RegisterPackageVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterPackageVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterPackageVersion.</param>
        /// 
        /// <returns>Returns a  RegisterPackageVersionResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/RegisterPackageVersion">REST API Reference for RegisterPackageVersion Operation</seealso>
        RegisterPackageVersionResponse EndRegisterPackageVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveApplicationInstance


        /// <summary>
        /// Removes an application instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveApplicationInstance service method.</param>
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
        RemoveApplicationInstanceResponse RemoveApplicationInstance(RemoveApplicationInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveApplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveApplicationInstance operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveApplicationInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/RemoveApplicationInstance">REST API Reference for RemoveApplicationInstance Operation</seealso>
        IAsyncResult BeginRemoveApplicationInstance(RemoveApplicationInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveApplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveApplicationInstance.</param>
        /// 
        /// <returns>Returns a  RemoveApplicationInstanceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/RemoveApplicationInstance">REST API Reference for RemoveApplicationInstance Operation</seealso>
        RemoveApplicationInstanceResponse EndRemoveApplicationInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  SignalApplicationInstanceNodeInstances


        /// <summary>
        /// Signal camera nodes to stop or resume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalApplicationInstanceNodeInstances service method.</param>
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
        SignalApplicationInstanceNodeInstancesResponse SignalApplicationInstanceNodeInstances(SignalApplicationInstanceNodeInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SignalApplicationInstanceNodeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignalApplicationInstanceNodeInstances operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSignalApplicationInstanceNodeInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/SignalApplicationInstanceNodeInstances">REST API Reference for SignalApplicationInstanceNodeInstances Operation</seealso>
        IAsyncResult BeginSignalApplicationInstanceNodeInstances(SignalApplicationInstanceNodeInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SignalApplicationInstanceNodeInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSignalApplicationInstanceNodeInstances.</param>
        /// 
        /// <returns>Returns a  SignalApplicationInstanceNodeInstancesResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/SignalApplicationInstanceNodeInstances">REST API Reference for SignalApplicationInstanceNodeInstances Operation</seealso>
        SignalApplicationInstanceNodeInstancesResponse EndSignalApplicationInstanceNodeInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDeviceMetadata


        /// <summary>
        /// Updates a device's metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceMetadata service method.</param>
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
        UpdateDeviceMetadataResponse UpdateDeviceMetadata(UpdateDeviceMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceMetadata operation on AmazonPanoramaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeviceMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/UpdateDeviceMetadata">REST API Reference for UpdateDeviceMetadata Operation</seealso>
        IAsyncResult BeginUpdateDeviceMetadata(UpdateDeviceMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeviceMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeviceMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateDeviceMetadataResult from Panorama.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/panorama-2019-07-24/UpdateDeviceMetadata">REST API Reference for UpdateDeviceMetadata Operation</seealso>
        UpdateDeviceMetadataResponse EndUpdateDeviceMetadata(IAsyncResult asyncResult);

        #endregion
        
    }
}