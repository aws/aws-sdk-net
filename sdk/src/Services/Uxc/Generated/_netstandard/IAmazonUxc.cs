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
 * Do not modify this file. This file is generated from the uxc-2024-07-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Uxc.Model;

#pragma warning disable CS1570
namespace Amazon.Uxc
{
    /// <summary>
    /// <para>Interface for accessing Uxc</para>
    ///
    /// This is the Amazon Web Services User Experience Customization (UXC) API Reference.
    /// Amazon Web Services User Experience Customization (UXC) is a utility that provides
    /// programmatic access to enable account administrators to customize the visual appearance
    /// of the Amazon Web Services Management Console and manage these settings at the account
    /// level.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>visibleServices</c> and <c>visibleRegions</c> settings control only the appearance
    /// of services and Regions in the Amazon Web Services Management Console. They do not
    /// restrict access through the CLI, SDKs, or other APIs.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about UXC features and console procedures, see <a href="https://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/getting-started-uxc.html">Getting
    /// started with Amazon Web Services User Experience Customization</a>. For information
    /// about required permissions, see <a href="https://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/security_iam.html">Identity
    /// and access management for Amazon Web Services Management Console</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonUxc : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IUxcPaginatorFactory Paginators { get; }
#endif
                
        #region  GetAccountCustomizations



        /// <summary>
        /// Returns the current account customization settings, including account color, visible
        /// services, and visible Regions. Settings that you have not configured return their
        /// default values: visible Regions and visible services return `null`, and account color
        /// returns `none`.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>visibleServices</c> and <c>visibleRegions</c> settings control only the appearance
        /// of services and Regions in the Amazon Web Services Management Console. They do not
        /// restrict access through the CLI, SDKs, or other APIs.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountCustomizations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountCustomizations service method, as returned by Uxc.</returns>
        /// <exception cref="Amazon.Uxc.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. Verify that your IAM policy
        /// includes the required <c>uxc:</c> permissions for the operation that you are calling.
        /// For more information on IAM permissions, see <a href="https://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/security-iam-awsmanpol.html">Amazon
        /// Web Services managed policies for Amazon Web Services Management Console</a>.
        /// </exception>
        /// <exception cref="Amazon.Uxc.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.Uxc.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce the frequency of your
        /// requests.
        /// </exception>
        /// <exception cref="Amazon.Uxc.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/uxc-2024-07-01/GetAccountCustomizations">REST API Reference for GetAccountCustomizations Operation</seealso>
        Task<GetAccountCustomizationsResponse> GetAccountCustomizationsAsync(GetAccountCustomizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServices



        /// <summary>
        /// Returns a paginated list of Amazon Web Services service identifiers that you can use
        /// as values for the <c>visibleServices</c> setting in <a href="https://docs.aws.amazon.com/awsconsolehelpdocs/latest/APIReference/API_UpdateAccountCustomizations.html">UpdateAccountCustomizations</a>.
        /// The available services vary by Amazon Web Services partition. Use pagination to retrieve
        /// all results.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>visibleServices</c> setting controls only the appearance of services in the
        /// Amazon Web Services Management Console. It does not restrict access through the CLI,
        /// SDKs, or other APIs.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by Uxc.</returns>
        /// <exception cref="Amazon.Uxc.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. Verify that your IAM policy
        /// includes the required <c>uxc:</c> permissions for the operation that you are calling.
        /// For more information on IAM permissions, see <a href="https://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/security-iam-awsmanpol.html">Amazon
        /// Web Services managed policies for Amazon Web Services Management Console</a>.
        /// </exception>
        /// <exception cref="Amazon.Uxc.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.Uxc.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce the frequency of your
        /// requests.
        /// </exception>
        /// <exception cref="Amazon.Uxc.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/uxc-2024-07-01/ListServices">REST API Reference for ListServices Operation</seealso>
        Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccountCustomizations



        /// <summary>
        /// Updates one or more account customization settings. You can update account color,
        /// visible services, and visible Regions in a single request. Only the settings that
        /// you include in the request body are modified. Omitted settings remain unchanged. To
        /// reset a setting to its default behavior, set the value to <c>null</c> for visible
        /// Regions and visible services, or <c>none</c> for account color. This operation is
        /// idempotent.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>visibleServices</c> and <c>visibleRegions</c> settings control only the appearance
        /// of services and Regions in the Amazon Web Services Management Console. They do not
        /// restrict access through the CLI, SDKs, or other APIs.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountCustomizations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountCustomizations service method, as returned by Uxc.</returns>
        /// <exception cref="Amazon.Uxc.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation. Verify that your IAM policy
        /// includes the required <c>uxc:</c> permissions for the operation that you are calling.
        /// For more information on IAM permissions, see <a href="https://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/security-iam-awsmanpol.html">Amazon
        /// Web Services managed policies for Amazon Web Services Management Console</a>.
        /// </exception>
        /// <exception cref="Amazon.Uxc.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.Uxc.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce the frequency of your
        /// requests.
        /// </exception>
        /// <exception cref="Amazon.Uxc.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/uxc-2024-07-01/UpdateAccountCustomizations">REST API Reference for UpdateAccountCustomizations Operation</seealso>
        Task<UpdateAccountCustomizationsResponse> UpdateAccountCustomizationsAsync(UpdateAccountCustomizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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