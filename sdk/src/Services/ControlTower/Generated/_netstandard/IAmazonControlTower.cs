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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ControlTower.Model;

namespace Amazon.ControlTower
{
    /// <summary>
    /// Interface for accessing ControlTower
    ///
    /// These interfaces allow you to apply the AWS library of pre-defined <i>controls</i>
    /// to your organizational units, programmatically. In this context, controls are the
    /// same as AWS Control Tower guardrails.
    /// 
    ///  
    /// <para>
    /// To call these APIs, you'll need to know:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// the <code>ControlARN</code> for the control--that is, the guardrail--you are targeting,
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// and the ARN associated with the target organizational unit (OU).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>To get the <code>ControlARN</code> for your AWS Control Tower guardrail:</b> 
    /// </para>
    ///  
    /// <para>
    /// The <code>ControlARN</code> contains the control name which is specified in each guardrail.
    /// For a list of control names for <i>Strongly recommended</i> and <i>Elective</i> guardrails,
    /// see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-identifiers.html.html">Resource
    /// identifiers for APIs and guardrails</a> in the <a href="https://docs.aws.amazon.com/controltower/latest/userguide/automating-tasks.html">Automating
    /// tasks section</a> of the AWS Control Tower User Guide. Remember that <i>Mandatory</i>
    /// guardrails cannot be added or removed.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>ARN format:</b> <code>arn:aws:controltower:{REGION}::control/{CONTROL_NAME}</code>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Example:</b> 
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:aws:controltower:us-west-2::control/AWS-GR_AUTOSCALING_LAUNCH_CONFIG_PUBLIC_IP_DISABLED</code>
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>To get the ARN for an OU:</b> 
    /// </para>
    ///  
    /// <para>
    /// In the AWS Organizations console, you can find the ARN for the OU on the <b>Organizational
    /// unit details</b> page associated with that OU.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>OU ARN format:</b> 
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:${Partition}:organizations::${MasterAccountId}:ou/o-${OrganizationId}/ou-${OrganizationalUnitId}</code>
    /// 
    /// </para>
    ///  </note> <p class="title"> <b>Details and examples</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-identifiers.html">List
    /// of resource identifiers for APIs and guardrails</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/guardrail-api-examples-short.html">Guardrail
    /// API examples (CLI)</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/enable-controls.html">Enable
    /// controls with AWS CloudFormation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/creating-resources-with-cloudformation.html">Creating
    /// AWS Control Tower resources with AWS CloudFormation</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To view the open source resource repository on GitHub, see <a href="https://github.com/aws-cloudformation/aws-cloudformation-resource-providers-controltower">aws-cloudformation/aws-cloudformation-resource-providers-controltower</a>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Recording API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS Control Tower supports AWS CloudTrail, a service that records AWS API calls for
    /// your AWS account and delivers log files to an Amazon S3 bucket. By using information
    /// collected by CloudTrail, you can determine which requests the AWS Control Tower service
    /// received, who made the request and when, and so on. For more about AWS Control Tower
    /// and its support for CloudTrail, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/logging-using-cloudtrail.html">Logging
    /// AWS Control Tower Actions with AWS CloudTrail</a> in the AWS Control Tower User Guide.
    /// To learn more about CloudTrail, including how to turn it on and find your log files,
    /// see the AWS CloudTrail User Guide.
    /// </para>
    /// </summary>
    public partial interface IAmazonControlTower : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IControlTowerPaginatorFactory Paginators { get; }
#endif
                
        #region  DisableControl



        /// <summary>
        /// This API call turns off a control. It starts an asynchronous operation that deletes
        /// AWS resources on the specified organizational unit and the accounts it contains. The
        /// resources will vary according to the control that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded. The limit is 10 concurrent operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DisableControl">REST API Reference for DisableControl Operation</seealso>
        Task<DisableControlResponse> DisableControlAsync(DisableControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableControl



        /// <summary>
        /// This API call activates a control. It starts an asynchronous operation that creates
        /// AWS resources on the specified organizational unit and the accounts it contains. The
        /// resources created will vary according to the control that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded. The limit is 10 concurrent operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/EnableControl">REST API Reference for EnableControl Operation</seealso>
        Task<EnableControlResponse> EnableControlAsync(EnableControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetControlOperation



        /// <summary>
        /// Returns the status of a particular <code>EnableControl</code> or <code>DisableControl</code>
        /// operation. Displays a message in case of error. Details for an operation are available
        /// for 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControlOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetControlOperation service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetControlOperation">REST API Reference for GetControlOperation Operation</seealso>
        Task<GetControlOperationResponse> GetControlOperationAsync(GetControlOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEnabledControls



        /// <summary>
        /// Lists the controls enabled by AWS Control Tower on the specified organizational unit
        /// and the accounts it contains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnabledControls service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListEnabledControls">REST API Reference for ListEnabledControls Operation</seealso>
        Task<ListEnabledControlsResponse> ListEnabledControlsAsync(ListEnabledControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}