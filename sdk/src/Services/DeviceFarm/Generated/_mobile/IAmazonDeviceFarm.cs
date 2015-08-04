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
using System.Threading;
using System.Threading.Tasks;
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
        /// Initiates the asynchronous execution of the CreateDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevicePool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDevicePoolResponse> CreateDevicePoolAsync(CreateDevicePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProject


        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="name">The project's name.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateProjectResponse> CreateProjectAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUpload


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateUploadResponse> CreateUploadAsync(CreateUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccountSettings


        /// <summary>
        /// Returns the number of unmetered iOS and/or unmetered Android devices that have been
        /// purchased by the account.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAccountSettingsResponse> GetAccountSettingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDevice


        /// <summary>
        /// Gets information about a unique device type.
        /// </summary>
        /// <param name="arn">The device type's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDeviceResponse> GetDeviceAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDevicePool


        /// <summary>
        /// Gets information about a device pool.
        /// </summary>
        /// <param name="arn">The device pool's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDevicePoolResponse> GetDevicePoolAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDevicePoolResponse> GetDevicePoolAsync(GetDevicePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDevicePoolCompatibility


        /// <summary>
        /// Initiates the asynchronous execution of the GetDevicePoolCompatibility operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevicePoolCompatibility operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDevicePoolCompatibilityResponse> GetDevicePoolCompatibilityAsync(GetDevicePoolCompatibilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJob


        /// <summary>
        /// Gets information about a job.
        /// </summary>
        /// <param name="arn">The job's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetJobResponse> GetJobAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProject


        /// <summary>
        /// Gets information about a project.
        /// </summary>
        /// <param name="arn">The project's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetProjectResponse> GetProjectAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRun


        /// <summary>
        /// Gets information about a run.
        /// </summary>
        /// <param name="arn">The run's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRunResponse> GetRunAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetRunResponse> GetRunAsync(GetRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSuite


        /// <summary>
        /// Gets information about a suite.
        /// </summary>
        /// <param name="arn">The suite's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSuiteResponse> GetSuiteAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetSuite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSuite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetSuiteResponse> GetSuiteAsync(GetSuiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTest


        /// <summary>
        /// Gets information about a test.
        /// </summary>
        /// <param name="arn">The test's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetTestResponse> GetTestAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetTest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetTestResponse> GetTestAsync(GetTestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUpload


        /// <summary>
        /// Gets information about an upload.
        /// </summary>
        /// <param name="arn">The upload's ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetUploadResponse> GetUploadAsync(string arn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetUploadResponse> GetUploadAsync(GetUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListArtifacts


        /// <summary>
        /// Initiates the asynchronous execution of the ListArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListArtifactsResponse> ListArtifactsAsync(ListArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDevicePools


        /// <summary>
        /// Initiates the asynchronous execution of the ListDevicePools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevicePools operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDevicePoolsResponse> ListDevicePoolsAsync(ListDevicePoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDevices


        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListJobs


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProjects


        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRuns


        /// <summary>
        /// Initiates the asynchronous execution of the ListRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListRunsResponse> ListRunsAsync(ListRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSamples


        /// <summary>
        /// Initiates the asynchronous execution of the ListSamples operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSamples operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListSamplesResponse> ListSamplesAsync(ListSamplesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSuites


        /// <summary>
        /// Initiates the asynchronous execution of the ListSuites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSuites operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListSuitesResponse> ListSuitesAsync(ListSuitesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTests


        /// <summary>
        /// Initiates the asynchronous execution of the ListTests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTestsResponse> ListTestsAsync(ListTestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUniqueProblems


        /// <summary>
        /// Initiates the asynchronous execution of the ListUniqueProblems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUniqueProblems operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListUniqueProblemsResponse> ListUniqueProblemsAsync(ListUniqueProblemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUploads


        /// <summary>
        /// Initiates the asynchronous execution of the ListUploads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUploads operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListUploadsResponse> ListUploadsAsync(ListUploadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ScheduleRun


        /// <summary>
        /// Initiates the asynchronous execution of the ScheduleRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScheduleRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ScheduleRunResponse> ScheduleRunAsync(ScheduleRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}