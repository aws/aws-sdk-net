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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LakeFormation.Model;

namespace Amazon.LakeFormation
{
    /// <summary>
    /// Interface for accessing LakeFormation
    ///
    /// AWS Lake Formation 
    /// <para>
    /// Defines the public endpoint for the AWS Lake Formation service.
    /// </para>
    /// </summary>
    public partial interface IAmazonLakeFormation : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILakeFormationPaginatorFactory Paginators { get; }
#endif
                
        #region  AddLFTagsToResource



        /// <summary>
        /// Attaches one or more tags to an existing resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddLFTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddLFTagsToResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/AddLFTagsToResource">REST API Reference for AddLFTagsToResource Operation</seealso>
        Task<AddLFTagsToResourceResponse> AddLFTagsToResourceAsync(AddLFTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGrantPermissions



        /// <summary>
        /// Batch operation to grant permissions to the principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGrantPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGrantPermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchGrantPermissions">REST API Reference for BatchGrantPermissions Operation</seealso>
        Task<BatchGrantPermissionsResponse> BatchGrantPermissionsAsync(BatchGrantPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchRevokePermissions



        /// <summary>
        /// Batch operation to revoke permissions from the principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchRevokePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchRevokePermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/BatchRevokePermissions">REST API Reference for BatchRevokePermissions Operation</seealso>
        Task<BatchRevokePermissionsResponse> BatchRevokePermissionsAsync(BatchRevokePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLFTag



        /// <summary>
        /// Creates a tag with the specified name and values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLFTag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/CreateLFTag">REST API Reference for CreateLFTag Operation</seealso>
        Task<CreateLFTagResponse> CreateLFTagAsync(CreateLFTagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLFTag



        /// <summary>
        /// Deletes the specified tag key name. If the attribute key does not exist or the tag
        /// does not exist, then the operation will not do anything. If the attribute key exists,
        /// then the operation checks if any resources are tagged with this attribute key, if
        /// yes, the API throws a 400 Exception with the message "Delete not allowed" as the tag
        /// key is still attached with resources. You can consider untagging resources with this
        /// tag key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLFTag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeleteLFTag">REST API Reference for DeleteLFTag Operation</seealso>
        Task<DeleteLFTagResponse> DeleteLFTagAsync(DeleteLFTagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterResource



        /// <summary>
        /// Deregisters the resource as managed by the Data Catalog.
        /// 
        ///  
        /// <para>
        /// When you deregister a path, Lake Formation removes the path from the inline policy
        /// attached to your service-linked role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DeregisterResource">REST API Reference for DeregisterResource Operation</seealso>
        Task<DeregisterResourceResponse> DeregisterResourceAsync(DeregisterResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeResource



        /// <summary>
        /// Retrieves the current data access role for the given resource registered in AWS Lake
        /// Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        Task<DescribeResourceResponse> DescribeResourceAsync(DescribeResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataLakeSettings



        /// <summary>
        /// Retrieves the list of the data lake administrators of a Lake Formation-managed data
        /// lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataLakeSettings service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetDataLakeSettings">REST API Reference for GetDataLakeSettings Operation</seealso>
        Task<GetDataLakeSettingsResponse> GetDataLakeSettingsAsync(GetDataLakeSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEffectivePermissionsForPath



        /// <summary>
        /// Returns the Lake Formation permissions for a specified table or database resource
        /// located at a path in Amazon S3. <code>GetEffectivePermissionsForPath</code> will not
        /// return databases and tables if the catalog is encrypted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEffectivePermissionsForPath service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEffectivePermissionsForPath service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetEffectivePermissionsForPath">REST API Reference for GetEffectivePermissionsForPath Operation</seealso>
        Task<GetEffectivePermissionsForPathResponse> GetEffectivePermissionsForPathAsync(GetEffectivePermissionsForPathRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLFTag



        /// <summary>
        /// Returns a tag definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLFTag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetLFTag">REST API Reference for GetLFTag Operation</seealso>
        Task<GetLFTagResponse> GetLFTagAsync(GetLFTagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResourceLFTags



        /// <summary>
        /// Returns the tags applied to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLFTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GetResourceLFTags">REST API Reference for GetResourceLFTags Operation</seealso>
        Task<GetResourceLFTagsResponse> GetResourceLFTagsAsync(GetResourceLFTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GrantPermissions



        /// <summary>
        /// Grants permissions to the principal to access metadata in the Data Catalog and data
        /// organized in underlying data storage such as Amazon S3.
        /// 
        ///  
        /// <para>
        /// For information about permissions, see <a href="https://docs-aws.amazon.com/lake-formation/latest/dg/security-data-access.html">Security
        /// and Access Control to Metadata and Data</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GrantPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GrantPermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/GrantPermissions">REST API Reference for GrantPermissions Operation</seealso>
        Task<GrantPermissionsResponse> GrantPermissionsAsync(GrantPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLFTags



        /// <summary>
        /// Lists tags that the requester has permission to view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLFTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListLFTags">REST API Reference for ListLFTags Operation</seealso>
        Task<ListLFTagsResponse> ListLFTagsAsync(ListLFTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPermissions



        /// <summary>
        /// Returns a list of the principal permissions on the resource, filtered by the permissions
        /// of the caller. For example, if you are granted an ALTER permission, you are able to
        /// see only the principal permissions for ALTER.
        /// 
        ///  
        /// <para>
        /// This operation returns only those permissions that have been explicitly granted.
        /// </para>
        ///  
        /// <para>
        /// For information about permissions, see <a href="https://docs-aws.amazon.com/lake-formation/latest/dg/security-data-access.html">Security
        /// and Access Control to Metadata and Data</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResources



        /// <summary>
        /// Lists the resources registered to be managed by the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/ListResources">REST API Reference for ListResources Operation</seealso>
        Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutDataLakeSettings



        /// <summary>
        /// Sets the list of data lake administrators who have admin privileges on all resources
        /// managed by Lake Formation. For more information on admin privileges, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/lake-formation-permissions.html">Granting
        /// Lake Formation Permissions</a>.
        /// 
        ///  
        /// <para>
        /// This API replaces the current list of data lake admins with the new list being passed.
        /// To add an admin, fetch the current list and add the new admin to that list and pass
        /// that list in this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDataLakeSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDataLakeSettings service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/PutDataLakeSettings">REST API Reference for PutDataLakeSettings Operation</seealso>
        Task<PutDataLakeSettingsResponse> PutDataLakeSettingsAsync(PutDataLakeSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterResource



        /// <summary>
        /// Registers the resource as managed by the Data Catalog.
        /// 
        ///  
        /// <para>
        /// To add or update data, Lake Formation needs read/write access to the chosen Amazon
        /// S3 path. Choose a role that you know has permission to do this, or choose the AWSServiceRoleForLakeFormationDataAccess
        /// service-linked role. When you register the first Amazon S3 path, the service-linked
        /// role and a new inline policy are created on your behalf. Lake Formation adds the first
        /// path to the inline policy and attaches it to the service-linked role. When you register
        /// subsequent paths, Lake Formation adds the path to the existing policy.
        /// </para>
        ///  
        /// <para>
        /// The following request registers a new location and gives AWS Lake Formation permission
        /// to use the service-linked role to access that location.
        /// </para>
        ///  
        /// <para>
        ///  <code>ResourceArn = arn:aws:s3:::my-bucket UseServiceLinkedRole = true</code> 
        /// </para>
        ///  
        /// <para>
        /// If <code>UseServiceLinkedRole</code> is not set to true, you must provide or set the
        /// <code>RoleArn</code>:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:iam::12345:role/my-data-access-role</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RegisterResource">REST API Reference for RegisterResource Operation</seealso>
        Task<RegisterResourceResponse> RegisterResourceAsync(RegisterResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveLFTagsFromResource



        /// <summary>
        /// Removes a tag from the resource. Only database, table, or tableWithColumns resource
        /// are allowed. To tag columns, use the column inclusion list in <code>tableWithColumns</code>
        /// to specify column input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveLFTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveLFTagsFromResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RemoveLFTagsFromResource">REST API Reference for RemoveLFTagsFromResource Operation</seealso>
        Task<RemoveLFTagsFromResourceResponse> RemoveLFTagsFromResourceAsync(RemoveLFTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokePermissions



        /// <summary>
        /// Revokes permissions to the principal to access metadata in the Data Catalog and data
        /// organized in underlying data storage such as Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokePermissions service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/RevokePermissions">REST API Reference for RevokePermissions Operation</seealso>
        Task<RevokePermissionsResponse> RevokePermissionsAsync(RevokePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchDatabasesByLFTags



        /// <summary>
        /// This operation allows a search on <code>DATABASE</code> resources by <code>TagCondition</code>.
        /// This operation is used by admins who want to grant user permissions on certain <code>TagConditions</code>.
        /// Before making a grant, the admin can use <code>SearchDatabasesByTags</code> to find
        /// all resources where the given <code>TagConditions</code> are valid to verify whether
        /// the returned resources can be shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDatabasesByLFTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchDatabasesByLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchDatabasesByLFTags">REST API Reference for SearchDatabasesByLFTags Operation</seealso>
        Task<SearchDatabasesByLFTagsResponse> SearchDatabasesByLFTagsAsync(SearchDatabasesByLFTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchTablesByLFTags



        /// <summary>
        /// This operation allows a search on <code>TABLE</code> resources by <code>LFTag</code>s.
        /// This will be used by admins who want to grant user permissions on certain LFTags.
        /// Before making a grant, the admin can use <code>SearchTablesByLFTags</code> to find
        /// all resources where the given <code>LFTag</code>s are valid to verify whether the
        /// returned resources can be shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTablesByLFTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchTablesByLFTags service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/SearchTablesByLFTags">REST API Reference for SearchTablesByLFTags Operation</seealso>
        Task<SearchTablesByLFTagsResponse> SearchTablesByLFTagsAsync(SearchTablesByLFTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLFTag



        /// <summary>
        /// Updates the list of possible values for the specified tag key. If the tag does not
        /// exist, the operation throws an EntityNotFoundException. The values in the delete key
        /// values will be deleted from list of possible values. If any value in the delete key
        /// values is attached to a resource, then API errors out with a 400 Exception - "Update
        /// not allowed". Untag the attribute before deleting the tag key's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLFTag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLFTag service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateLFTag">REST API Reference for UpdateLFTag Operation</seealso>
        Task<UpdateLFTagResponse> UpdateLFTagAsync(UpdateLFTagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateResource



        /// <summary>
        /// Updates the data access role used for vending access to the given (registered) resource
        /// in AWS Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by LakeFormation.</returns>
        /// <exception cref="Amazon.LakeFormation.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.LakeFormation.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lakeformation-2017-03-31/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}