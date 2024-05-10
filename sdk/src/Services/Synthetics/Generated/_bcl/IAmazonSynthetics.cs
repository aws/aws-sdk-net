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

#pragma warning disable CS1570
namespace Amazon.Synthetics
{
    /// <summary>
    /// <para>Interface for accessing Synthetics</para>
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
    public partial interface IAmazonSynthetics : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISyntheticsPaginatorFactory Paginators { get; }

        
        #region  AssociateResource


        /// <summary>
        /// Associates a canary with a group. Using groups can help you with managing and automating
        /// your canaries, and you can also view aggregated run results and statistics for all
        /// canaries in a group. 
        /// 
        ///  
        /// <para>
        /// You must run this operation in the Region where the canary exists.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResource service method.</param>
        /// 
        /// <returns>The response from the AssociateResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota value.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/AssociateResource">REST API Reference for AssociateResource Operation</seealso>
        AssociateResourceResponse AssociateResource(AssociateResourceRequest request);



        /// <summary>
        /// Associates a canary with a group. Using groups can help you with managing and automating
        /// your canaries, and you can also view aggregated run results and statistics for all
        /// canaries in a group. 
        /// 
        ///  
        /// <para>
        /// You must run this operation in the Region where the canary exists.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota value.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/AssociateResource">REST API Reference for AssociateResource Operation</seealso>
        Task<AssociateResourceResponse> AssociateResourceAsync(AssociateResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCanary


        /// <summary>
        /// Creates a canary. Canaries are scripts that monitor your endpoints and APIs from the
        /// outside-in. Canaries help you check the availability and latency of your web services
        /// and troubleshoot anomalies by investigating load time data, screenshots of the UI,
        /// logs, and metrics. You can set up a canary to run continuously or just once. 
        /// 
        ///  
        /// <para>
        /// Do not use <c>CreateCanary</c> to modify an existing canary. Use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_UpdateCanary.html">UpdateCanary</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// To create canaries, you must have the <c>CloudWatchSyntheticsFullAccess</c> policy.
        /// If you are creating a new IAM role for the canary, you also need the <c>iam:CreateRole</c>,
        /// <c>iam:CreatePolicy</c> and <c>iam:AttachRolePolicy</c> permissions. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Roles">Necessary
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
        /// 
        /// <returns>The response from the CreateCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.RequestEntityTooLargeException">
        /// One of the input resources is larger than is allowed.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/CreateCanary">REST API Reference for CreateCanary Operation</seealso>
        CreateCanaryResponse CreateCanary(CreateCanaryRequest request);



        /// <summary>
        /// Creates a canary. Canaries are scripts that monitor your endpoints and APIs from the
        /// outside-in. Canaries help you check the availability and latency of your web services
        /// and troubleshoot anomalies by investigating load time data, screenshots of the UI,
        /// logs, and metrics. You can set up a canary to run continuously or just once. 
        /// 
        ///  
        /// <para>
        /// Do not use <c>CreateCanary</c> to modify an existing canary. Use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_UpdateCanary.html">UpdateCanary</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// To create canaries, you must have the <c>CloudWatchSyntheticsFullAccess</c> policy.
        /// If you are creating a new IAM role for the canary, you also need the <c>iam:CreateRole</c>,
        /// <c>iam:CreatePolicy</c> and <c>iam:AttachRolePolicy</c> permissions. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Roles">Necessary
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
        /// <exception cref="Amazon.Synthetics.Model.RequestEntityTooLargeException">
        /// One of the input resources is larger than is allowed.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/CreateCanary">REST API Reference for CreateCanary Operation</seealso>
        Task<CreateCanaryResponse> CreateCanaryAsync(CreateCanaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Creates a group which you can use to associate canaries with each other, including
        /// cross-Region canaries. Using groups can help you with managing and automating your
        /// canaries, and you can also view aggregated run results and statistics for all canaries
        /// in a group. 
        /// 
        ///  
        /// <para>
        /// Groups are global resources. When you create a group, it is replicated across Amazon
        /// Web Services Regions, and you can view it and add canaries to it from any Region.
        /// Although the group ARN format reflects the Region name where it was created, a group
        /// is not constrained to any Region. This means that you can put canaries from multiple
        /// Regions into the same group, and then use that group to view and manage all of those
        /// canaries in a single view.
        /// </para>
        ///  
        /// <para>
        /// Groups are supported in all Regions except the Regions that are disabled by default.
        /// For more information about these Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html#rande-manage-enable">Enabling
        /// a Region</a>.
        /// </para>
        ///  
        /// <para>
        /// Each group can contain as many as 10 canaries. You can have as many as 20 groups in
        /// your account. Any single canary can be a member of up to 10 groups.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota value.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);



        /// <summary>
        /// Creates a group which you can use to associate canaries with each other, including
        /// cross-Region canaries. Using groups can help you with managing and automating your
        /// canaries, and you can also view aggregated run results and statistics for all canaries
        /// in a group. 
        /// 
        ///  
        /// <para>
        /// Groups are global resources. When you create a group, it is replicated across Amazon
        /// Web Services Regions, and you can view it and add canaries to it from any Region.
        /// Although the group ARN format reflects the Region name where it was created, a group
        /// is not constrained to any Region. This means that you can put canaries from multiple
        /// Regions into the same group, and then use that group to view and manage all of those
        /// canaries in a single view.
        /// </para>
        ///  
        /// <para>
        /// Groups are supported in all Regions except the Regions that are disabled by default.
        /// For more information about these Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html#rande-manage-enable">Enabling
        /// a Region</a>.
        /// </para>
        ///  
        /// <para>
        /// Each group can contain as many as 10 canaries. You can have as many as 20 groups in
        /// your account. Any single canary can be a member of up to 10 groups.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota value.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCanary


        /// <summary>
        /// Permanently deletes the specified canary.
        /// 
        ///  
        /// <para>
        /// If you specify <c>DeleteLambda</c> to <c>true</c>, CloudWatch Synthetics also deletes
        /// the Lambda functions and layers that are used by the canary.
        /// </para>
        ///  
        /// <para>
        /// Other resources used and created by the canary are not automatically deleted. After
        /// you delete a canary that you do not intend to use again, you should also delete the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The CloudWatch alarms created for this canary. These alarms have a name of <c>Synthetics-SharpDrop-Alarm-<i>MyCanaryName</i>
        /// </c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon S3 objects and buckets, such as the canary's artifact location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IAM roles created for the canary. If they were created in the console, these roles
        /// have the name <c> role/service-role/CloudWatchSyntheticsRole-<i>MyCanaryName</i> </c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CloudWatch Logs log groups created for the canary. These logs groups have the name
        /// <c>/aws/lambda/cwsyn-<i>MyCanaryName</i> </c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Before you delete a canary, you might want to use <c>GetCanary</c> to display the
        /// information about this canary. Make note of the information returned by this operation
        /// so that you can delete these resources after you delete the canary.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCanary service method.</param>
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
        DeleteCanaryResponse DeleteCanary(DeleteCanaryRequest request);



        /// <summary>
        /// Permanently deletes the specified canary.
        /// 
        ///  
        /// <para>
        /// If you specify <c>DeleteLambda</c> to <c>true</c>, CloudWatch Synthetics also deletes
        /// the Lambda functions and layers that are used by the canary.
        /// </para>
        ///  
        /// <para>
        /// Other resources used and created by the canary are not automatically deleted. After
        /// you delete a canary that you do not intend to use again, you should also delete the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The CloudWatch alarms created for this canary. These alarms have a name of <c>Synthetics-SharpDrop-Alarm-<i>MyCanaryName</i>
        /// </c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon S3 objects and buckets, such as the canary's artifact location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IAM roles created for the canary. If they were created in the console, these roles
        /// have the name <c> role/service-role/CloudWatchSyntheticsRole-<i>MyCanaryName</i> </c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CloudWatch Logs log groups created for the canary. These logs groups have the name
        /// <c>/aws/lambda/cwsyn-<i>MyCanaryName</i> </c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Before you delete a canary, you might want to use <c>GetCanary</c> to display the
        /// information about this canary. Make note of the information returned by this operation
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
        Task<DeleteCanaryResponse> DeleteCanaryAsync(DeleteCanaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes a group. The group doesn't need to be empty to be deleted. If there are canaries
        /// in the group, they are not deleted when you delete the group. 
        /// 
        ///  
        /// <para>
        /// Groups are a global resource that appear in all Regions, but the request to delete
        /// a group must be made from its home Region. You can find the home Region of a group
        /// within its ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by Synthetics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);



        /// <summary>
        /// Deletes a group. The group doesn't need to be empty to be deleted. If there are canaries
        /// in the group, they are not deleted when you delete the group. 
        /// 
        ///  
        /// <para>
        /// Groups are a global resource that appear in all Regions, but the request to delete
        /// a group must be made from its home Region. You can find the home Region of a group
        /// within its ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by Synthetics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCanaries


        /// <summary>
        /// This operation returns a list of the canaries in your account, along with full details
        /// about each canary.
        /// 
        ///  
        /// <para>
        /// This operation supports resource-level authorization using an IAM policy and the <c>Names</c>
        /// parameter. If you specify the <c>Names</c> parameter, the operation is successful
        /// only if you have authorization to view all the canaries that you specify in your request.
        /// If you do not have permission to view any of the canaries, the request fails with
        /// a 403 response.
        /// </para>
        ///  
        /// <para>
        /// You are required to use the <c>Names</c> parameter if you are logged on to a user
        /// or role that has an IAM policy that restricts which canaries that you are allowed
        /// to view. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Restricted.html">
        /// Limiting a user to viewing specific canaries</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCanaries service method.</param>
        /// 
        /// <returns>The response from the DescribeCanaries service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeCanaries">REST API Reference for DescribeCanaries Operation</seealso>
        DescribeCanariesResponse DescribeCanaries(DescribeCanariesRequest request);



        /// <summary>
        /// This operation returns a list of the canaries in your account, along with full details
        /// about each canary.
        /// 
        ///  
        /// <para>
        /// This operation supports resource-level authorization using an IAM policy and the <c>Names</c>
        /// parameter. If you specify the <c>Names</c> parameter, the operation is successful
        /// only if you have authorization to view all the canaries that you specify in your request.
        /// If you do not have permission to view any of the canaries, the request fails with
        /// a 403 response.
        /// </para>
        ///  
        /// <para>
        /// You are required to use the <c>Names</c> parameter if you are logged on to a user
        /// or role that has an IAM policy that restricts which canaries that you are allowed
        /// to view. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Restricted.html">
        /// Limiting a user to viewing specific canaries</a>.
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
        Task<DescribeCanariesResponse> DescribeCanariesAsync(DescribeCanariesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCanariesLastRun


        /// <summary>
        /// Use this operation to see information from the most recent run of each canary that
        /// you have created.
        /// 
        ///  
        /// <para>
        /// This operation supports resource-level authorization using an IAM policy and the <c>Names</c>
        /// parameter. If you specify the <c>Names</c> parameter, the operation is successful
        /// only if you have authorization to view all the canaries that you specify in your request.
        /// If you do not have permission to view any of the canaries, the request fails with
        /// a 403 response.
        /// </para>
        ///  
        /// <para>
        /// You are required to use the <c>Names</c> parameter if you are logged on to a user
        /// or role that has an IAM policy that restricts which canaries that you are allowed
        /// to view. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Restricted.html">
        /// Limiting a user to viewing specific canaries</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCanariesLastRun service method.</param>
        /// 
        /// <returns>The response from the DescribeCanariesLastRun service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeCanariesLastRun">REST API Reference for DescribeCanariesLastRun Operation</seealso>
        DescribeCanariesLastRunResponse DescribeCanariesLastRun(DescribeCanariesLastRunRequest request);



        /// <summary>
        /// Use this operation to see information from the most recent run of each canary that
        /// you have created.
        /// 
        ///  
        /// <para>
        /// This operation supports resource-level authorization using an IAM policy and the <c>Names</c>
        /// parameter. If you specify the <c>Names</c> parameter, the operation is successful
        /// only if you have authorization to view all the canaries that you specify in your request.
        /// If you do not have permission to view any of the canaries, the request fails with
        /// a 403 response.
        /// </para>
        ///  
        /// <para>
        /// You are required to use the <c>Names</c> parameter if you are logged on to a user
        /// or role that has an IAM policy that restricts which canaries that you are allowed
        /// to view. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Restricted.html">
        /// Limiting a user to viewing specific canaries</a>.
        /// </para>
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
        Task<DescribeCanariesLastRunResponse> DescribeCanariesLastRunAsync(DescribeCanariesLastRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRuntimeVersions


        /// <summary>
        /// Returns a list of Synthetics canary runtime versions. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Library.html">
        /// Canary Runtime Versions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuntimeVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeRuntimeVersions service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeRuntimeVersions">REST API Reference for DescribeRuntimeVersions Operation</seealso>
        DescribeRuntimeVersionsResponse DescribeRuntimeVersions(DescribeRuntimeVersionsRequest request);



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
        Task<DescribeRuntimeVersionsResponse> DescribeRuntimeVersionsAsync(DescribeRuntimeVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateResource


        /// <summary>
        /// Removes a canary from a group. You must run this operation in the Region where the
        /// canary exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateResource service method, as returned by Synthetics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DisassociateResource">REST API Reference for DisassociateResource Operation</seealso>
        DisassociateResourceResponse DisassociateResource(DisassociateResourceRequest request);



        /// <summary>
        /// Removes a canary from a group. You must run this operation in the Region where the
        /// canary exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateResource service method, as returned by Synthetics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DisassociateResource">REST API Reference for DisassociateResource Operation</seealso>
        Task<DisassociateResourceResponse> DisassociateResourceAsync(DisassociateResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCanary


        /// <summary>
        /// Retrieves complete information about one canary. You must specify the name of the
        /// canary that you want. To get a list of canaries and their names, use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_DescribeCanaries.html">DescribeCanaries</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCanary service method.</param>
        /// 
        /// <returns>The response from the GetCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetCanary">REST API Reference for GetCanary Operation</seealso>
        GetCanaryResponse GetCanary(GetCanaryRequest request);



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
        Task<GetCanaryResponse> GetCanaryAsync(GetCanaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCanaryRuns


        /// <summary>
        /// Retrieves a list of runs for a specified canary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCanaryRuns service method.</param>
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
        GetCanaryRunsResponse GetCanaryRuns(GetCanaryRunsRequest request);



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
        Task<GetCanaryRunsResponse> GetCanaryRunsAsync(GetCanaryRunsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Returns information about one group. Groups are a global resource, so you can use
        /// this operation from any Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by Synthetics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetGroup">REST API Reference for GetGroup Operation</seealso>
        GetGroupResponse GetGroup(GetGroupRequest request);



        /// <summary>
        /// Returns information about one group. Groups are a global resource, so you can use
        /// this operation from any Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by Synthetics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetGroup">REST API Reference for GetGroup Operation</seealso>
        Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssociatedGroups


        /// <summary>
        /// Returns a list of the groups that the specified canary is associated with. The canary
        /// that you specify must be in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedGroups service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedGroups service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListAssociatedGroups">REST API Reference for ListAssociatedGroups Operation</seealso>
        ListAssociatedGroupsResponse ListAssociatedGroups(ListAssociatedGroupsRequest request);



        /// <summary>
        /// Returns a list of the groups that the specified canary is associated with. The canary
        /// that you specify must be in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociatedGroups service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListAssociatedGroups">REST API Reference for ListAssociatedGroups Operation</seealso>
        Task<ListAssociatedGroupsResponse> ListAssociatedGroupsAsync(ListAssociatedGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroupResources


        /// <summary>
        /// This operation returns a list of the ARNs of the canaries that are associated with
        /// the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupResources service method.</param>
        /// 
        /// <returns>The response from the ListGroupResources service method, as returned by Synthetics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListGroupResources">REST API Reference for ListGroupResources Operation</seealso>
        ListGroupResourcesResponse ListGroupResources(ListGroupResourcesRequest request);



        /// <summary>
        /// This operation returns a list of the ARNs of the canaries that are associated with
        /// the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupResources service method, as returned by Synthetics.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListGroupResources">REST API Reference for ListGroupResources Operation</seealso>
        Task<ListGroupResourcesResponse> ListGroupResourcesAsync(ListGroupResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Returns a list of all groups in the account, displaying their names, unique IDs, and
        /// ARNs. The groups from all Regions are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);



        /// <summary>
        /// Returns a list of all groups in the account, displaying their names, unique IDs, and
        /// ARNs. The groups from all Regions are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListGroups">REST API Reference for ListGroups Operation</seealso>
        Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Displays the tags associated with a canary or group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.BadRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalFailureException">
        /// An internal failure occurred. Try the operation again.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.NotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.TooManyRequestsException">
        /// There were too many simultaneous requests. Try the operation again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Displays the tags associated with a canary or group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.BadRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalFailureException">
        /// An internal failure occurred. Try the operation again.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.NotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.TooManyRequestsException">
        /// There were too many simultaneous requests. Try the operation again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartCanary


        /// <summary>
        /// Use this operation to run a canary that has already been created. The frequency of
        /// the canary runs is determined by the value of the canary's <c>Schedule</c>. To see
        /// a canary's schedule, use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_GetCanary.html">GetCanary</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCanary service method.</param>
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
        StartCanaryResponse StartCanary(StartCanaryRequest request);



        /// <summary>
        /// Use this operation to run a canary that has already been created. The frequency of
        /// the canary runs is determined by the value of the canary's <c>Schedule</c>. To see
        /// a canary's schedule, use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_GetCanary.html">GetCanary</a>.
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
        Task<StartCanaryResponse> StartCanaryAsync(StartCanaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopCanary


        /// <summary>
        /// Stops the canary to prevent all future runs. If the canary is currently running,the
        /// run that is in progress completes on its own, publishes metrics, and uploads artifacts,
        /// but it is not recorded in Synthetics as a completed run.
        /// 
        ///  
        /// <para>
        /// You can use <c>StartCanary</c> to start it running again with the canary’s current
        /// schedule at any point in the future. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCanary service method.</param>
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
        StopCanaryResponse StopCanary(StopCanaryRequest request);



        /// <summary>
        /// Stops the canary to prevent all future runs. If the canary is currently running,the
        /// run that is in progress completes on its own, publishes metrics, and uploads artifacts,
        /// but it is not recorded in Synthetics as a completed run.
        /// 
        ///  
        /// <para>
        /// You can use <c>StartCanary</c> to start it running again with the canary’s current
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
        Task<StopCanaryResponse> StopCanaryAsync(StopCanaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified canary or group. 
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>TagResource</c> action with a resource that already has tags. If
        /// you specify a new tag key for the resource, this tag is appended to the list of tags
        /// associated with the resource. If you specify a tag key that is already associated
        /// with the resource, the new tag value that you specify replaces the previous value
        /// for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a canary or group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.BadRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalFailureException">
        /// An internal failure occurred. Try the operation again.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.NotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.TooManyRequestsException">
        /// There were too many simultaneous requests. Try the operation again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified canary or group. 
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>TagResource</c> action with a resource that already has tags. If
        /// you specify a new tag key for the resource, this tag is appended to the list of tags
        /// associated with the resource. If you specify a tag key that is already associated
        /// with the resource, the new tag value that you specify replaces the previous value
        /// for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a canary or group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.BadRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalFailureException">
        /// An internal failure occurred. Try the operation again.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.NotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.TooManyRequestsException">
        /// There were too many simultaneous requests. Try the operation again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.BadRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalFailureException">
        /// An internal failure occurred. Try the operation again.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.NotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.TooManyRequestsException">
        /// There were too many simultaneous requests. Try the operation again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.BadRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalFailureException">
        /// An internal failure occurred. Try the operation again.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.NotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.TooManyRequestsException">
        /// There were too many simultaneous requests. Try the operation again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCanary


        /// <summary>
        /// Updates the configuration of a canary that has already been created.
        /// 
        ///  
        /// <para>
        /// You can't use this operation to update the tags of an existing canary. To change the
        /// tags of an existing canary, use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCanary service method.</param>
        /// 
        /// <returns>The response from the UpdateCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.RequestEntityTooLargeException">
        /// One of the input resources is larger than is allowed.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/UpdateCanary">REST API Reference for UpdateCanary Operation</seealso>
        UpdateCanaryResponse UpdateCanary(UpdateCanaryRequest request);



        /// <summary>
        /// Updates the configuration of a canary that has already been created.
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
        /// <exception cref="Amazon.Synthetics.Model.RequestEntityTooLargeException">
        /// One of the input resources is larger than is allowed.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/UpdateCanary">REST API Reference for UpdateCanary Operation</seealso>
        Task<UpdateCanaryResponse> UpdateCanaryAsync(UpdateCanaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}