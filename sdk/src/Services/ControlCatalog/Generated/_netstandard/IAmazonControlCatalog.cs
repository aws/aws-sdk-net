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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ControlCatalog.Model;

#pragma warning disable CS1570
namespace Amazon.ControlCatalog
{
    /// <summary>
    /// <para>Interface for accessing ControlCatalog</para>
    ///
    /// Welcome to the Control Catalog API reference. This guide is for developers who need
    /// detailed information about how to programmatically identify and filter the common
    /// controls and related metadata that are available to Amazon Web Services customers.
    /// This API reference provides descriptions, syntax, and usage examples for each of the
    /// actions and data types that are supported by Control Catalog. 
    /// 
    ///  
    /// <para>
    /// Use the following links to get started with the Control Catalog API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/API_Operations.html">Actions</a>:
    /// An alphabetical list of all Control Catalog API operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/API_Types.html">Data
    /// types</a>: An alphabetical list of all Control Catalog data types.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/CommonParameters.html">Common
    /// parameters</a>: Parameters that all operations can use.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/CommonErrors.html">Common
    /// errors</a>: Client and server errors that all operations can return.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonControlCatalog : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IControlCatalogPaginatorFactory Paginators { get; }
#endif
                
        #region  GetControl



        /// <summary>
        /// Returns details about a specific control, most notably a list of Amazon Web Services
        /// Regions where this control is supported. Input a value for the <i>ControlArn</i> parameter,
        /// in ARN form. <c>GetControl</c> accepts <i>controltower</i> or <i>controlcatalog</i>
        /// control ARNs as input. Returns a <i>controlcatalog</i> ARN format.
        /// 
        ///  
        /// <para>
        /// In the API response, controls that have the value <c>GLOBAL</c> in the <c>Scope</c>
        /// field do not show the <c>DeployableRegions</c> field, because it does not apply. Controls
        /// that have the value <c>REGIONAL</c> in the <c>Scope</c> field return a value for the
        /// <c>DeployableRegions</c> field, as shown in the example.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetControl service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/GetControl">REST API Reference for GetControl Operation</seealso>
        Task<GetControlResponse> GetControlAsync(GetControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCommonControls



        /// <summary>
        /// Returns a paginated list of common controls from the Amazon Web Services Control Catalog.
        /// 
        ///  
        /// <para>
        /// You can apply an optional filter to see common controls that have a specific objective.
        /// If you don’t provide a filter, the operation returns all common controls. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommonControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommonControls service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListCommonControls">REST API Reference for ListCommonControls Operation</seealso>
        Task<ListCommonControlsResponse> ListCommonControlsAsync(ListCommonControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListControlMappings



        /// <summary>
        /// Returns a paginated list of control mappings from the Control Catalog. Control mappings
        /// show relationships between controls and other entities, such as common controls or
        /// compliance frameworks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListControlMappings service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListControlMappings">REST API Reference for ListControlMappings Operation</seealso>
        Task<ListControlMappingsResponse> ListControlMappingsAsync(ListControlMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListControls



        /// <summary>
        /// Returns a paginated list of all available controls in the Control Catalog library.
        /// Allows you to discover available controls. The list of controls is given as structures
        /// of type <i>controlSummary</i>. The ARN is returned in the global <i>controlcatalog</i>
        /// format, as shown in the examples.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListControls service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListControls">REST API Reference for ListControls Operation</seealso>
        Task<ListControlsResponse> ListControlsAsync(ListControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomains



        /// <summary>
        /// Returns a paginated list of domains from the Control Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListObjectives



        /// <summary>
        /// Returns a paginated list of objectives from the Control Catalog.
        /// 
        ///  
        /// <para>
        /// You can apply an optional filter to see the objectives that belong to a specific domain.
        /// If you don’t provide a filter, the operation returns all objectives. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectives service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjectives service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListObjectives">REST API Reference for ListObjectives Operation</seealso>
        Task<ListObjectivesResponse> ListObjectivesAsync(ListObjectivesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonControlCatalogConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonControlCatalogConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonControlCatalogConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonControlCatalogConfig to create AmazonControlCatalogClient");
            }

            return awsCredentials == null ? 
                    new AmazonControlCatalogClient(serviceClientConfig) :
                    new AmazonControlCatalogClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}