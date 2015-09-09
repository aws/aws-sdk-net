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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.DeviceFarm.Model;

namespace Amazon.DeviceFarm
{
    /// <summary>
    /// Interface for accessing DeviceFarm
    ///
    /// AWS Device Farm is a service that enables mobile app developers to test Android, iOS,
    /// and Fire OS apps on physical phones, tablets, and other devices in the cloud.
    /// </summary>
    public partial interface IAmazonDeviceFarm : IDisposable
    {

        
        #region  CreateDevicePool

        /// <summary>
        /// Creates a device pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevicePool service method.</param>
        /// 
        /// <returns>The response from the CreateDevicePool service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        CreateDevicePoolResponse CreateDevicePool(CreateDevicePoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevicePool operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDevicePool
        ///         operation.</returns>
        IAsyncResult BeginCreateDevicePool(CreateDevicePoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDevicePool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDevicePool.</param>
        /// 
        /// <returns>Returns a  CreateDevicePoolResult from DeviceFarm.</returns>
        CreateDevicePoolResponse EndCreateDevicePool(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProject

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="name">The project's name.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        CreateProjectResponse CreateProject(string name);

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        CreateProjectResponse CreateProject(CreateProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from DeviceFarm.</returns>
        CreateProjectResponse EndCreateProject(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUpload

        /// <summary>
        /// Uploads an app or test scripts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUpload service method.</param>
        /// 
        /// <returns>The response from the CreateUpload service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        CreateUploadResponse CreateUpload(CreateUploadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUpload operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUpload
        ///         operation.</returns>
        IAsyncResult BeginCreateUpload(CreateUploadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUpload.</param>
        /// 
        /// <returns>Returns a  CreateUploadResult from DeviceFarm.</returns>
        CreateUploadResponse EndCreateUpload(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccountSettings

        /// <summary>
        /// Returns the number of unmetered iOS and/or unmetered Android devices that have been
        /// purchased by the account.
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetAccountSettingsResponse GetAccountSettings();

        /// <summary>
        /// Returns the number of unmetered iOS and/or unmetered Android devices that have been
        /// purchased by the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSettings
        ///         operation.</returns>
        IAsyncResult BeginGetAccountSettings(GetAccountSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSettings.</param>
        /// 
        /// <returns>Returns a  GetAccountSettingsResult from DeviceFarm.</returns>
        GetAccountSettingsResponse EndGetAccountSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDevice

        /// <summary>
        /// Gets information about a unique device type.
        /// </summary>
        /// <param name="arn">The device type's ARN.</param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetDeviceResponse GetDevice(string arn);

        /// <summary>
        /// Gets information about a unique device type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetDeviceResponse GetDevice(GetDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevice operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevice
        ///         operation.</returns>
        IAsyncResult BeginGetDevice(GetDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevice.</param>
        /// 
        /// <returns>Returns a  GetDeviceResult from DeviceFarm.</returns>
        GetDeviceResponse EndGetDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDevicePool

        /// <summary>
        /// Gets information about a device pool.
        /// </summary>
        /// <param name="arn">The device pool's ARN.</param>
        /// 
        /// <returns>The response from the GetDevicePool service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetDevicePoolResponse GetDevicePool(string arn);

        /// <summary>
        /// Gets information about a device pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePool service method.</param>
        /// 
        /// <returns>The response from the GetDevicePool service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetDevicePoolResponse GetDevicePool(GetDevicePoolRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePool operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevicePool
        ///         operation.</returns>
        IAsyncResult BeginGetDevicePool(GetDevicePoolRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevicePool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevicePool.</param>
        /// 
        /// <returns>Returns a  GetDevicePoolResult from DeviceFarm.</returns>
        GetDevicePoolResponse EndGetDevicePool(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDevicePoolCompatibility

        /// <summary>
        /// Gets information about compatibility with a device pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePoolCompatibility service method.</param>
        /// 
        /// <returns>The response from the GetDevicePoolCompatibility service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetDevicePoolCompatibilityResponse GetDevicePoolCompatibility(GetDevicePoolCompatibilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePoolCompatibility operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePoolCompatibility operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevicePoolCompatibility
        ///         operation.</returns>
        IAsyncResult BeginGetDevicePoolCompatibility(GetDevicePoolCompatibilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevicePoolCompatibility operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevicePoolCompatibility.</param>
        /// 
        /// <returns>Returns a  GetDevicePoolCompatibilityResult from DeviceFarm.</returns>
        GetDevicePoolCompatibilityResponse EndGetDevicePoolCompatibility(IAsyncResult asyncResult);

        #endregion
        
        #region  GetJob

        /// <summary>
        /// Gets information about a job.
        /// </summary>
        /// <param name="arn">The job's ARN.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetJobResponse GetJob(string arn);

        /// <summary>
        /// Gets information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetJobResponse GetJob(GetJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJob
        ///         operation.</returns>
        IAsyncResult BeginGetJob(GetJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJob.</param>
        /// 
        /// <returns>Returns a  GetJobResult from DeviceFarm.</returns>
        GetJobResponse EndGetJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProject

        /// <summary>
        /// Gets information about a project.
        /// </summary>
        /// <param name="arn">The project's ARN.</param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetProjectResponse GetProject(string arn);

        /// <summary>
        /// Gets information about a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetProjectResponse GetProject(GetProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProject operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProject
        ///         operation.</returns>
        IAsyncResult BeginGetProject(GetProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProject.</param>
        /// 
        /// <returns>Returns a  GetProjectResult from DeviceFarm.</returns>
        GetProjectResponse EndGetProject(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRun

        /// <summary>
        /// Gets information about a run.
        /// </summary>
        /// <param name="arn">The run's ARN.</param>
        /// 
        /// <returns>The response from the GetRun service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetRunResponse GetRun(string arn);

        /// <summary>
        /// Gets information about a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRun service method.</param>
        /// 
        /// <returns>The response from the GetRun service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetRunResponse GetRun(GetRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRun operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRun
        ///         operation.</returns>
        IAsyncResult BeginGetRun(GetRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRun.</param>
        /// 
        /// <returns>Returns a  GetRunResult from DeviceFarm.</returns>
        GetRunResponse EndGetRun(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSuite

        /// <summary>
        /// Gets information about a suite.
        /// </summary>
        /// <param name="arn">The suite's ARN.</param>
        /// 
        /// <returns>The response from the GetSuite service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetSuiteResponse GetSuite(string arn);

        /// <summary>
        /// Gets information about a suite.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuite service method.</param>
        /// 
        /// <returns>The response from the GetSuite service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetSuiteResponse GetSuite(GetSuiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSuite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSuite operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSuite
        ///         operation.</returns>
        IAsyncResult BeginGetSuite(GetSuiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSuite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSuite.</param>
        /// 
        /// <returns>Returns a  GetSuiteResult from DeviceFarm.</returns>
        GetSuiteResponse EndGetSuite(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTest

        /// <summary>
        /// Gets information about a test.
        /// </summary>
        /// <param name="arn">The test's ARN.</param>
        /// 
        /// <returns>The response from the GetTest service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetTestResponse GetTest(string arn);

        /// <summary>
        /// Gets information about a test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTest service method.</param>
        /// 
        /// <returns>The response from the GetTest service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetTestResponse GetTest(GetTestRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTest operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTest
        ///         operation.</returns>
        IAsyncResult BeginGetTest(GetTestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTest.</param>
        /// 
        /// <returns>Returns a  GetTestResult from DeviceFarm.</returns>
        GetTestResponse EndGetTest(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUpload

        /// <summary>
        /// Gets information about an upload.
        /// </summary>
        /// <param name="arn">The upload's ARN.</param>
        /// 
        /// <returns>The response from the GetUpload service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetUploadResponse GetUpload(string arn);

        /// <summary>
        /// Gets information about an upload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpload service method.</param>
        /// 
        /// <returns>The response from the GetUpload service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        GetUploadResponse GetUpload(GetUploadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpload operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUpload
        ///         operation.</returns>
        IAsyncResult BeginGetUpload(GetUploadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUpload.</param>
        /// 
        /// <returns>Returns a  GetUploadResult from DeviceFarm.</returns>
        GetUploadResponse EndGetUpload(IAsyncResult asyncResult);

        #endregion
        
        #region  ListArtifacts

        /// <summary>
        /// Gets information about artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        ListArtifactsResponse ListArtifacts(ListArtifactsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListArtifacts
        ///         operation.</returns>
        IAsyncResult BeginListArtifacts(ListArtifactsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListArtifacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListArtifacts.</param>
        /// 
        /// <returns>Returns a  ListArtifactsResult from DeviceFarm.</returns>
        ListArtifactsResponse EndListArtifacts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDevicePools

        /// <summary>
        /// Gets information about device pools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicePools service method.</param>
        /// 
        /// <returns>The response from the ListDevicePools service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        ListDevicePoolsResponse ListDevicePools(ListDevicePoolsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevicePools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevicePools operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevicePools
        ///         operation.</returns>
        IAsyncResult BeginListDevicePools(ListDevicePoolsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevicePools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevicePools.</param>
        /// 
        /// <returns>Returns a  ListDevicePoolsResult from DeviceFarm.</returns>
        ListDevicePoolsResponse EndListDevicePools(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDevices

        /// <summary>
        /// Gets information about unique device types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        ListDevicesResponse ListDevices(ListDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevices
        ///         operation.</returns>
        IAsyncResult BeginListDevices(ListDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevices.</param>
        /// 
        /// <returns>Returns a  ListDevicesResult from DeviceFarm.</returns>
        ListDevicesResponse EndListDevices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobs

        /// <summary>
        /// Gets information about jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        ListJobsResponse ListJobs(ListJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from DeviceFarm.</returns>
        ListJobsResponse EndListJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProjects

        /// <summary>
        /// Gets information about projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        ListProjectsResponse ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from DeviceFarm.</returns>
        ListProjectsResponse EndListProjects(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRuns

        /// <summary>
        /// Gets information about runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuns service method.</param>
        /// 
        /// <returns>The response from the ListRuns service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        ListRunsResponse ListRuns(ListRunsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuns operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuns
        ///         operation.</returns>
        IAsyncResult BeginListRuns(ListRunsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuns.</param>
        /// 
        /// <returns>Returns a  ListRunsResult from DeviceFarm.</returns>
        ListRunsResponse EndListRuns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSamples

        /// <summary>
        /// Gets information about samples.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSamples service method.</param>
        /// 
        /// <returns>The response from the ListSamples service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        ListSamplesResponse ListSamples(ListSamplesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSamples operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSamples operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSamples
        ///         operation.</returns>
        IAsyncResult BeginListSamples(ListSamplesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSamples operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSamples.</param>
        /// 
        /// <returns>Returns a  ListSamplesResult from DeviceFarm.</returns>
        ListSamplesResponse EndListSamples(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSuites

        /// <summary>
        /// Gets information about suites.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuites service method.</param>
        /// 
        /// <returns>The response from the ListSuites service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        ListSuitesResponse ListSuites(ListSuitesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSuites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSuites operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSuites
        ///         operation.</returns>
        IAsyncResult BeginListSuites(ListSuitesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSuites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSuites.</param>
        /// 
        /// <returns>Returns a  ListSuitesResult from DeviceFarm.</returns>
        ListSuitesResponse EndListSuites(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTests

        /// <summary>
        /// Gets information about tests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTests service method.</param>
        /// 
        /// <returns>The response from the ListTests service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        ListTestsResponse ListTests(ListTestsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTests operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTests
        ///         operation.</returns>
        IAsyncResult BeginListTests(ListTestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTests.</param>
        /// 
        /// <returns>Returns a  ListTestsResult from DeviceFarm.</returns>
        ListTestsResponse EndListTests(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUniqueProblems

        /// <summary>
        /// Gets information about unique problems.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUniqueProblems service method.</param>
        /// 
        /// <returns>The response from the ListUniqueProblems service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        ListUniqueProblemsResponse ListUniqueProblems(ListUniqueProblemsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUniqueProblems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUniqueProblems operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUniqueProblems
        ///         operation.</returns>
        IAsyncResult BeginListUniqueProblems(ListUniqueProblemsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUniqueProblems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUniqueProblems.</param>
        /// 
        /// <returns>Returns a  ListUniqueProblemsResult from DeviceFarm.</returns>
        ListUniqueProblemsResponse EndListUniqueProblems(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUploads

        /// <summary>
        /// Gets information about uploads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUploads service method.</param>
        /// 
        /// <returns>The response from the ListUploads service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        ListUploadsResponse ListUploads(ListUploadsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUploads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUploads operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUploads
        ///         operation.</returns>
        IAsyncResult BeginListUploads(ListUploadsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUploads operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUploads.</param>
        /// 
        /// <returns>Returns a  ListUploadsResult from DeviceFarm.</returns>
        ListUploadsResponse EndListUploads(IAsyncResult asyncResult);

        #endregion
        
        #region  ScheduleRun

        /// <summary>
        /// Schedules a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScheduleRun service method.</param>
        /// 
        /// <returns>The response from the ScheduleRun service method, as returned by DeviceFarm.</returns>
        /// <exception cref="Amazon.DeviceFarm.Model.ArgumentException">
        /// An invalid argument was specified.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.IdempotencyException">
        /// An entity with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.NotFoundException">
        /// The specified entity was not found.
        /// </exception>
        /// <exception cref="Amazon.DeviceFarm.Model.ServiceAccountException">
        /// There was a problem with the service account.
        /// </exception>
        ScheduleRunResponse ScheduleRun(ScheduleRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ScheduleRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScheduleRun operation on AmazonDeviceFarmClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndScheduleRun
        ///         operation.</returns>
        IAsyncResult BeginScheduleRun(ScheduleRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ScheduleRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginScheduleRun.</param>
        /// 
        /// <returns>Returns a  ScheduleRunResult from DeviceFarm.</returns>
        ScheduleRunResponse EndScheduleRun(IAsyncResult asyncResult);

        #endregion
        
    }
}