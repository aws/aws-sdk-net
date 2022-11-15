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
 * Do not modify this file. This file is generated from the ssmsap-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SsmSap.Model;

namespace Amazon.SsmSap
{
    /// <summary>
    /// Interface for accessing SsmSap
    ///
    /// 
    /// </summary>
    public partial interface IAmazonSsmSap : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISsmSapPaginatorFactory Paginators { get; }

        
        #region  DeleteResourcePermission


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePermission service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePermission service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/DeleteResourcePermission">REST API Reference for DeleteResourcePermission Operation</seealso>
        DeleteResourcePermissionResponse DeleteResourcePermission(DeleteResourcePermissionRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePermission service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/DeleteResourcePermission">REST API Reference for DeleteResourcePermission Operation</seealso>
        Task<DeleteResourcePermissionResponse> DeleteResourcePermissionAsync(DeleteResourcePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterApplication


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterApplication service method.</param>
        /// 
        /// <returns>The response from the DeregisterApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/DeregisterApplication">REST API Reference for DeregisterApplication Operation</seealso>
        DeregisterApplicationResponse DeregisterApplication(DeregisterApplicationRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/DeregisterApplication">REST API Reference for DeregisterApplication Operation</seealso>
        Task<DeregisterApplicationResponse> DeregisterApplicationAsync(DeregisterApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetApplication


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/GetApplication">REST API Reference for GetApplication Operation</seealso>
        GetApplicationResponse GetApplication(GetApplicationRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/GetApplication">REST API Reference for GetApplication Operation</seealso>
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetComponent


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
        /// 
        /// <returns>The response from the GetComponent service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/GetComponent">REST API Reference for GetComponent Operation</seealso>
        GetComponentResponse GetComponent(GetComponentRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComponent service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/GetComponent">REST API Reference for GetComponent Operation</seealso>
        Task<GetComponentResponse> GetComponentAsync(GetComponentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDatabase


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase service method.</param>
        /// 
        /// <returns>The response from the GetDatabase service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        GetDatabaseResponse GetDatabase(GetDatabaseRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatabase service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        Task<GetDatabaseResponse> GetDatabaseAsync(GetDatabaseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperation service method.</param>
        /// 
        /// <returns>The response from the GetOperation service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/GetOperation">REST API Reference for GetOperation Operation</seealso>
        GetOperationResponse GetOperation(GetOperationRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOperation service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/GetOperation">REST API Reference for GetOperation Operation</seealso>
        Task<GetOperationResponse> GetOperationAsync(GetOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourcePermission


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePermission service method.</param>
        /// 
        /// <returns>The response from the GetResourcePermission service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/GetResourcePermission">REST API Reference for GetResourcePermission Operation</seealso>
        GetResourcePermissionResponse GetResourcePermission(GetResourcePermissionRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePermission service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/GetResourcePermission">REST API Reference for GetResourcePermission Operation</seealso>
        Task<GetResourcePermissionResponse> GetResourcePermissionAsync(GetResourcePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListComponents


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/ListComponents">REST API Reference for ListComponents Operation</seealso>
        ListComponentsResponse ListComponents(ListComponentsRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/ListComponents">REST API Reference for ListComponents Operation</seealso>
        Task<ListComponentsResponse> ListComponentsAsync(ListComponentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDatabases


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
        /// 
        /// <returns>The response from the ListDatabases service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        ListDatabasesResponse ListDatabases(ListDatabasesRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatabases service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResourcePermission


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePermission service method.</param>
        /// 
        /// <returns>The response from the PutResourcePermission service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/PutResourcePermission">REST API Reference for PutResourcePermission Operation</seealso>
        PutResourcePermissionResponse PutResourcePermission(PutResourcePermissionRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePermission service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/PutResourcePermission">REST API Reference for PutResourcePermission Operation</seealso>
        Task<PutResourcePermissionResponse> PutResourcePermissionAsync(PutResourcePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterApplication


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterApplication service method.</param>
        /// 
        /// <returns>The response from the RegisterApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/RegisterApplication">REST API Reference for RegisterApplication Operation</seealso>
        RegisterApplicationResponse RegisterApplication(RegisterApplicationRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterApplication service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/RegisterApplication">REST API Reference for RegisterApplication Operation</seealso>
        Task<RegisterApplicationResponse> RegisterApplicationAsync(RegisterApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApplicationSettings


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationSettings service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
        UpdateApplicationSettingsResponse UpdateApplicationSettings(UpdateApplicationSettingsRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplicationSettings service method, as returned by SsmSap.</returns>
        /// <exception cref="Amazon.SsmSap.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SsmSap.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssmsap-2018-05-10/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
        Task<UpdateApplicationSettingsResponse> UpdateApplicationSettingsAsync(UpdateApplicationSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}