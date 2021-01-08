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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Synthetics.Model;

namespace Amazon.Synthetics
{
    /// <summary>
    /// Interface for accessing Synthetics
    ///
    /// Amazon CloudWatch Synthetics 
    /// <para>
    /// You can use Amazon CloudWatch Synthetics to continually monitor your services. You
    /// can create and manage <i>canaries</i>, which are modular, lightweight scripts that
    /// monitor your endpoints and APIs from the outside-in. You can set up your canaries
    /// to run 24 hours a day, once per minute. The canaries help you check the availability
    /// and latency of your web services and troubleshoot anomalies by investigating load
    /// time data, screenshots of the UI, logs, and metrics. The canaries seamlessly integrate
    /// with CloudWatch ServiceLens to help you trace the causes of impacted nodes in your
    /// applications. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/ServiceLens.html">Using
    /// ServiceLens to Monitor the Health of Your Applications</a> in the <i>Amazon CloudWatch
    /// User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Before you create and manage canaries, be aware of the security considerations. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/servicelens_canaries_security.html">Security
    /// Considerations for Synthetics Canaries</a>.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonSynthetics : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISyntheticsPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateCanary



        /// <summary>
        /// Creates a canary. Canaries are scripts that monitor your endpoints and APIs from the
        /// outside-in. Canaries help you check the availability and latency of your web services
        /// and troubleshoot anomalies by investigating load time data, screenshots of the UI,
        /// logs, and metrics. You can set up a canary to run continuously or just once. 
        /// 
        ///  
        /// <para>
        /// Do not use <code>CreateCanary</code> to modify an existing canary. Use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_UpdateCanary.html">UpdateCanary</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// To create canaries, you must have the <code>CloudWatchSyntheticsFullAccess</code>
        /// policy. If you are creating a new IAM role for the canary, you also need the the <code>iam:CreateRole</code>,
        /// <code>iam:CreatePolicy</code> and <code>iam:AttachRolePolicy</code> permissions. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Roles">Necessary
        /// Roles and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// Do not include secrets or proprietary information in your canary names. The canary
        /// name makes up part of the Amazon Resource Name (ARN) for the canary, and the ARN is
        /// included in outbound calls over the internet. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/servicelens_canaries_security.html">Security
        /// Considerations for Synthetics Canaries</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCanary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/CreateCanary">REST API Reference for CreateCanary Operation</seealso>
        Task<CreateCanaryResponse> CreateCanaryAsync(CreateCanaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCanary



        /// <summary>
        /// Permanently deletes the specified canary.
        /// 
        ///  
        /// <para>
        /// When you delete a canary, resources used and created by the canary are not automatically
        /// deleted. After you delete a canary that you do not intend to use again, you should
        /// also delete the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The Lambda functions and layers used by this canary. These have the prefix <code>cwsyn-<i>MyCanaryName</i>
        /// </code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The CloudWatch alarms created for this canary. These alarms have a name of <code>Synthetics-SharpDrop-Alarm-<i>MyCanaryName</i>
        /// </code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon S3 objects and buckets, such as the canary's artifact location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IAM roles created for the canary. If they were created in the console, these roles
        /// have the name <code> role/service-role/CloudWatchSyntheticsRole-<i>MyCanaryName</i>
        /// </code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CloudWatch Logs log groups created for the canary. These logs groups have the name
        /// <code>/aws/lambda/cwsyn-<i>MyCanaryName</i> </code>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Before you delete a canary, you might want to use <code>GetCanary</code> to display
        /// the information about this canary. Make note of the information returned by this operation
        /// so that you can delete these resources after you delete the canary.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCanary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DeleteCanary">REST API Reference for DeleteCanary Operation</seealso>
        Task<DeleteCanaryResponse> DeleteCanaryAsync(DeleteCanaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCanaries



        /// <summary>
        /// This operation returns a list of the canaries in your account, along with full details
        /// about each canary.
        /// 
        ///  
        /// <para>
        /// This operation does not have resource-level authorization, so if a user is able to
        /// use <code>DescribeCanaries</code>, the user can see all of the canaries in the account.
        /// A deny policy can only be used to restrict access to all canaries. It cannot be used
        /// on specific resources. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCanaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCanaries service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeCanaries">REST API Reference for DescribeCanaries Operation</seealso>
        Task<DescribeCanariesResponse> DescribeCanariesAsync(DescribeCanariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCanariesLastRun



        /// <summary>
        /// Use this operation to see information from the most recent run of each canary that
        /// you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCanariesLastRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCanariesLastRun service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeCanariesLastRun">REST API Reference for DescribeCanariesLastRun Operation</seealso>
        Task<DescribeCanariesLastRunResponse> DescribeCanariesLastRunAsync(DescribeCanariesLastRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRuntimeVersions



        /// <summary>
        /// Returns a list of Synthetics canary runtime versions. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Library.html">
        /// Canary Runtime Versions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuntimeVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRuntimeVersions service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeRuntimeVersions">REST API Reference for DescribeRuntimeVersions Operation</seealso>
        Task<DescribeRuntimeVersionsResponse> DescribeRuntimeVersionsAsync(DescribeRuntimeVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCanary



        /// <summary>
        /// Retrieves complete information about one canary. You must specify the name of the
        /// canary that you want. To get a list of canaries and their names, use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_DescribeCanaries.html">DescribeCanaries</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCanary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetCanary">REST API Reference for GetCanary Operation</seealso>
        Task<GetCanaryResponse> GetCanaryAsync(GetCanaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCanaryRuns



        /// <summary>
        /// Retrieves a list of runs for a specified canary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCanaryRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCanaryRuns service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetCanaryRuns">REST API Reference for GetCanaryRuns Operation</seealso>
        Task<GetCanaryRunsResponse> GetCanaryRunsAsync(GetCanaryRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Displays the tags associated with a canary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartCanary



        /// <summary>
        /// Use this operation to run a canary that has already been created. The frequency of
        /// the canary runs is determined by the value of the canary's <code>Schedule</code>.
        /// To see a canary's schedule, use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_GetCanary.html">GetCanary</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCanary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/StartCanary">REST API Reference for StartCanary Operation</seealso>
        Task<StartCanaryResponse> StartCanaryAsync(StartCanaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopCanary



        /// <summary>
        /// Stops the canary to prevent all future runs. If the canary is currently running, Synthetics
        /// stops waiting for the current run of the specified canary to complete. The run that
        /// is in progress completes on its own, publishes metrics, and uploads artifacts, but
        /// it is not recorded in Synthetics as a completed run.
        /// 
        ///  
        /// <para>
        /// You can use <code>StartCanary</code> to start it running again with the canary’s current
        /// schedule at any point in the future. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCanary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/StopCanary">REST API Reference for StopCanary Operation</seealso>
        Task<StopCanaryResponse> StopCanaryAsync(StopCanaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified canary. 
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to AWS and are interpreted strictly as strings
        /// of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with a canary that already has tags.
        /// If you specify a new tag key for the alarm, this tag is appended to the list of tags
        /// associated with the alarm. If you specify a tag key that is already associated with
        /// the alarm, the new tag value that you specify replaces the previous value for that
        /// tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a canary.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags from the specified canary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCanary



        /// <summary>
        /// Use this operation to change the settings of a canary that has already been created.
        /// 
        ///  
        /// <para>
        /// You can't use this operation to update the tags of an existing canary. To change the
        /// tags of an existing canary, use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCanary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/UpdateCanary">REST API Reference for UpdateCanary Operation</seealso>
        Task<UpdateCanaryResponse> UpdateCanaryAsync(UpdateCanaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}