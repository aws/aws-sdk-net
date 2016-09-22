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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Snowball.Model;

namespace Amazon.Snowball
{
    /// <summary>
    /// Interface for accessing Snowball
    ///
    /// This is a test of the welcome page front matter.
    /// </summary>
    public partial interface IAmazonSnowball : IAmazonService, IDisposable
    {

        
        #region  CancelJob


        /// <summary>
        /// Cancels the specified job. Note that you can only cancel a job before its <code>JobState</code>
        /// value changes to <code>PreparingAppliance</code>. Requesting the <code>ListJobs</code>
        /// or <code>DescribeJob</code> action will return a job's <code>JobState</code> as part
        /// of the response element data returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided AWS Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        CancelJobResponse CancelJob(CancelJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAddress


        /// <summary>
        /// Creates an address for a Snowball to be shipped to. 
        /// 
        ///  
        /// <para>
        /// Addresses are validated at the time of creation. The address you provide must be located
        /// within the serviceable area of your region. If the address is invalid or unsupported,
        /// then an exception is thrown.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddress service method.</param>
        /// 
        /// <returns>The response from the CreateAddress service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidAddressException">
        /// The address provided was invalid. Check the address with your region's carrier, and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.UnsupportedAddressException">
        /// The address is either outside the serviceable area for your region, or an error occurred.
        /// Check the address with your region's carrier and try again. If the issue persists,
        /// contact AWS Support.
        /// </exception>
        CreateAddressResponse CreateAddress(CreateAddressRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateAddressResponse> CreateAddressAsync(CreateAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// Creates a job to import or export data between Amazon S3 and your on-premises data
        /// center. Note that your AWS account must have the right trust policies and permissions
        /// in place to create a job for Snowball. For more information, see <a>api-reference-policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided AWS Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        CreateJobResponse CreateJob(CreateJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAddress


        /// <summary>
        /// Takes an <code>AddressId</code> and returns specific details about that address in
        /// the form of an <code>Address</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddress service method.</param>
        /// 
        /// <returns>The response from the DescribeAddress service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        DescribeAddressResponse DescribeAddress(DescribeAddressRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAddressResponse> DescribeAddressAsync(DescribeAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAddresses


        /// <summary>
        /// Returns a specified number of <code>ADDRESS</code> objects. Calling this API in one
        /// of the US regions will return addresses from the list of all addresses associated
        /// with this account in all US regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses service method.</param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeJob


        /// <summary>
        /// Returns information about a specific job including shipping information, job status,
        /// and other important metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        DescribeJobResponse DescribeJob(DescribeJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetJobManifest


        /// <summary>
        /// Returns a link to an Amazon S3 presigned URL for the manifest file associated with
        /// the specified <code>JobId</code> value. You can access the manifest file for up to
        /// 60 minutes after this request has been made. To access the manifest file after 60
        /// minutes have passed, you'll have to make another call to the <code>GetJobManifest</code>
        /// action.
        /// 
        ///  
        /// <para>
        /// The manifest is an encrypted file that you can download after your job enters the
        /// <code>WithCustomer</code> status. The manifest is decrypted by using the <code>UnlockCode</code>
        /// code value, when you pass both values to the Snowball through the Snowball client
        /// when the client is started for the first time.
        /// </para>
        ///  
        /// <para>
        /// As a best practice, we recommend that you don't save a copy of an <code>UnlockCode</code>
        /// value in the same location as the manifest file for that job. Saving these separately
        /// helps prevent unauthorized parties from gaining access to the Snowball associated
        /// with that job.
        /// </para>
        ///  
        /// <para>
        /// Note that the credentials of a given job, including its manifest file and unlock code,
        /// expire 90 days after the job is created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobManifest service method.</param>
        /// 
        /// <returns>The response from the GetJobManifest service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        GetJobManifestResponse GetJobManifest(GetJobManifestRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobManifest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetJobManifestResponse> GetJobManifestAsync(GetJobManifestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetJobUnlockCode


        /// <summary>
        /// Returns the <code>UnlockCode</code> code value for the specified job. A particular
        /// <code>UnlockCode</code> value can be accessed for up to 90 days after the associated
        /// job has been created.
        /// 
        ///  
        /// <para>
        /// The <code>UnlockCode</code> value is a 29-character code with 25 alphanumeric characters
        /// and 4 hyphens. This code is used to decrypt the manifest file when it is passed along
        /// with the manifest to the Snowball through the Snowball client when the client is started
        /// for the first time.
        /// </para>
        ///  
        /// <para>
        /// As a best practice, we recommend that you don't save a copy of the <code>UnlockCode</code>
        /// in the same location as the manifest file for that job. Saving these separately helps
        /// prevent unauthorized parties from gaining access to the Snowball associated with that
        /// job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobUnlockCode service method.</param>
        /// 
        /// <returns>The response from the GetJobUnlockCode service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        GetJobUnlockCodeResponse GetJobUnlockCode(GetJobUnlockCodeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobUnlockCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobUnlockCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetJobUnlockCodeResponse> GetJobUnlockCodeAsync(GetJobUnlockCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSnowballUsage


        /// <summary>
        /// Returns information about the Snowball service limit for your account, and also the
        /// number of Snowballs your account has in use.
        /// 
        ///  
        /// <para>
        /// Note that the default service limit for the number of Snowballs that you can have
        /// at one time is 1. If you want to increase your service limit, contact AWS Support.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnowballUsage service method.</param>
        /// 
        /// <returns>The response from the GetSnowballUsage service method, as returned by Snowball.</returns>
        GetSnowballUsageResponse GetSnowballUsage(GetSnowballUsageRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetSnowballUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSnowballUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetSnowballUsageResponse> GetSnowballUsageAsync(GetSnowballUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Returns an array of <code>JobListEntry</code> objects of the specified length. Each
        /// <code>JobListEntry</code> object contains a job's state, a job's ID, and a value that
        /// indicates whether the job is a job part, in the case of export jobs. Calling this
        /// API action in one of the US regions will return jobs from the list of all jobs associated
        /// with this account in all US regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Snowball.</returns>
        ListJobsResponse ListJobs(ListJobsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateJob


        /// <summary>
        /// While a job's <code>JobState</code> value is <code>New</code>, you can update some
        /// of the information associated with a job. Once the job changes to a different job
        /// state, usually within 60 minutes of the job being created, this action is no longer
        /// available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided AWS Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        UpdateJobResponse UpdateJob(UpdateJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}