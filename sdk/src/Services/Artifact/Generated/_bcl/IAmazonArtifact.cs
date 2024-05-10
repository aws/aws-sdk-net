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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Artifact.Model;

#pragma warning disable CS1570
namespace Amazon.Artifact
{
    /// <summary>
    /// <para>Interface for accessing Artifact</para>
    ///
    /// This reference provides descriptions of the low-level AWS Artifact Service API.
    /// </summary>
    public partial interface IAmazonArtifact : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IArtifactPaginatorFactory Paginators { get; }

        
        #region  GetAccountSettings


        /// <summary>
        /// Get the account settings for Artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request);



        /// <summary>
        /// Get the account settings for Artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetReport


        /// <summary>
        /// Get the content for a single report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReport service method.</param>
        /// 
        /// <returns>The response from the GetReport service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/GetReport">REST API Reference for GetReport Operation</seealso>
        GetReportResponse GetReport(GetReportRequest request);



        /// <summary>
        /// Get the content for a single report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReport service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/GetReport">REST API Reference for GetReport Operation</seealso>
        Task<GetReportResponse> GetReportAsync(GetReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetReportMetadata


        /// <summary>
        /// Get the metadata for a single report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReportMetadata service method.</param>
        /// 
        /// <returns>The response from the GetReportMetadata service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/GetReportMetadata">REST API Reference for GetReportMetadata Operation</seealso>
        GetReportMetadataResponse GetReportMetadata(GetReportMetadataRequest request);



        /// <summary>
        /// Get the metadata for a single report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReportMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReportMetadata service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/GetReportMetadata">REST API Reference for GetReportMetadata Operation</seealso>
        Task<GetReportMetadataResponse> GetReportMetadataAsync(GetReportMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTermForReport


        /// <summary>
        /// Get the Term content associated with a single report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTermForReport service method.</param>
        /// 
        /// <returns>The response from the GetTermForReport service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/GetTermForReport">REST API Reference for GetTermForReport Operation</seealso>
        GetTermForReportResponse GetTermForReport(GetTermForReportRequest request);



        /// <summary>
        /// Get the Term content associated with a single report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTermForReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTermForReport service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/GetTermForReport">REST API Reference for GetTermForReport Operation</seealso>
        Task<GetTermForReportResponse> GetTermForReportAsync(GetTermForReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReports


        /// <summary>
        /// List available reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReports service method.</param>
        /// 
        /// <returns>The response from the ListReports service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/ListReports">REST API Reference for ListReports Operation</seealso>
        ListReportsResponse ListReports(ListReportsRequest request);



        /// <summary>
        /// List available reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReports service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/ListReports">REST API Reference for ListReports Operation</seealso>
        Task<ListReportsResponse> ListReportsAsync(ListReportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAccountSettings


        /// <summary>
        /// Put the account settings for Artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSettings service method.</param>
        /// 
        /// <returns>The response from the PutAccountSettings service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/PutAccountSettings">REST API Reference for PutAccountSettings Operation</seealso>
        PutAccountSettingsResponse PutAccountSettings(PutAccountSettingsRequest request);



        /// <summary>
        /// Put the account settings for Artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountSettings service method, as returned by Artifact.</returns>
        /// <exception cref="Amazon.Artifact.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ConflictException">
        /// Request to create/modify content would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.InternalServerException">
        /// An unknown server exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Artifact.Model.ValidationException">
        /// Request fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/artifact-2018-05-10/PutAccountSettings">REST API Reference for PutAccountSettings Operation</seealso>
        Task<PutAccountSettingsResponse> PutAccountSettingsAsync(PutAccountSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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