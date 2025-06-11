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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Invoicing.Model;

#pragma warning disable CS1570
namespace Amazon.Invoicing
{
    /// <summary>
    /// <para>Interface for accessing Invoicing</para>
    ///
    /// <b>Amazon Web Services Invoice Configuration</b> 
    /// 
    ///  
    /// <para>
    /// You can use Amazon Web Services Invoice Configuration APIs to programmatically create,
    /// update, delete, get, and list invoice units. You can also programmatically fetch the
    /// information of the invoice receiver. For example, business legal name, address, and
    /// invoicing contacts. 
    /// </para>
    ///  
    /// <para>
    /// You can use Amazon Web Services Invoice Configuration to receive separate Amazon Web
    /// Services invoices based your organizational needs. By using Amazon Web Services Invoice
    /// Configuration, you can configure invoice units that are groups of Amazon Web Services
    /// accounts that represent your business entities, and receive separate invoices for
    /// each business entity. You can also assign a unique member or payer account as the
    /// invoice receiver for each invoice unit. As you create new accounts within your Organizations
    /// using Amazon Web Services Invoice Configuration APIs, you can automate the creation
    /// of new invoice units and subsequently automate the addition of new accounts to your
    /// invoice units.
    /// </para>
    ///  
    /// <para>
    /// Service endpoint
    /// </para>
    ///  
    /// <para>
    /// You can use the following endpoints for Amazon Web Services Invoice Configuration:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>https://invoicing.us-east-1.api.aws</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonInvoicing : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IInvoicingPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchGetInvoiceProfile



        /// <summary>
        /// This gets the invoice profile associated with a set of accounts. The accounts must
        /// be linked accounts under the requester management account organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetInvoiceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetInvoiceProfile service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/BatchGetInvoiceProfile">REST API Reference for BatchGetInvoiceProfile Operation</seealso>
        Task<BatchGetInvoiceProfileResponse> BatchGetInvoiceProfileAsync(BatchGetInvoiceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInvoiceUnit



        /// <summary>
        /// This creates a new invoice unit with the provided definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvoiceUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInvoiceUnit service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/CreateInvoiceUnit">REST API Reference for CreateInvoiceUnit Operation</seealso>
        Task<CreateInvoiceUnitResponse> CreateInvoiceUnitAsync(CreateInvoiceUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInvoiceUnit



        /// <summary>
        /// This deletes an invoice unit with the provided invoice unit ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvoiceUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInvoiceUnit service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/DeleteInvoiceUnit">REST API Reference for DeleteInvoiceUnit Operation</seealso>
        Task<DeleteInvoiceUnitResponse> DeleteInvoiceUnitAsync(DeleteInvoiceUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetInvoiceUnit



        /// <summary>
        /// This retrieves the invoice unit definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvoiceUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInvoiceUnit service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/GetInvoiceUnit">REST API Reference for GetInvoiceUnit Operation</seealso>
        Task<GetInvoiceUnitResponse> GetInvoiceUnitAsync(GetInvoiceUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInvoiceSummaries



        /// <summary>
        /// Retrieves your invoice details programmatically, without line item details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvoiceSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvoiceSummaries service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListInvoiceSummaries">REST API Reference for ListInvoiceSummaries Operation</seealso>
        Task<ListInvoiceSummariesResponse> ListInvoiceSummariesAsync(ListInvoiceSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInvoiceUnits



        /// <summary>
        /// This fetches a list of all invoice unit definitions for a given account, as of the
        /// provided <c>AsOf</c> date.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvoiceUnits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvoiceUnits service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListInvoiceUnits">REST API Reference for ListInvoiceUnits Operation</seealso>
        Task<ListInvoiceUnitsResponse> ListInvoiceUnitsAsync(ListInvoiceUnitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ServiceQuotaExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateInvoiceUnit



        /// <summary>
        /// You can update the invoice unit configuration at any time, and Amazon Web Services
        /// will use the latest configuration at the end of the month.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInvoiceUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInvoiceUnit service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UpdateInvoiceUnit">REST API Reference for UpdateInvoiceUnit Operation</seealso>
        Task<UpdateInvoiceUnitResponse> UpdateInvoiceUnitAsync(UpdateInvoiceUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonInvoicingConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonInvoicingConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonInvoicingConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonInvoicingConfig to create AmazonInvoicingClient");
            }

            return awsCredentials == null ? 
                    new AmazonInvoicingClient(serviceClientConfig) :
                    new AmazonInvoicingClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}