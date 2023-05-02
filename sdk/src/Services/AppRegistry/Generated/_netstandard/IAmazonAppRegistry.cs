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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AppRegistry.Model;

namespace Amazon.AppRegistry
{
    /// <summary>
    /// Interface for accessing AppRegistry
    ///
    /// Amazon Web Services Service Catalog AppRegistry enables organizations to understand
    /// the application context of their Amazon Web Services resources. AppRegistry provides
    /// a repository of your applications, their resources, and the application metadata that
    /// you use within your enterprise.
    /// </summary>
    public partial interface IAmazonAppRegistry : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAppRegistryPaginatorFactory Paginators { get; }
#endif
                
        #region  AssociateAttributeGroup



        /// <summary>
        /// Associates an attribute group with an application to augment the application's metadata
        /// with the group's attributes. This feature enables applications to be described with
        /// user-defined details that are machine-readable, such as third-party integrations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAttributeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/AssociateAttributeGroup">REST API Reference for AssociateAttributeGroup Operation</seealso>
        Task<AssociateAttributeGroupResponse> AssociateAttributeGroupAsync(AssociateAttributeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateResource



        /// <summary>
        /// Associates a resource with an application. The resource can be specified by its ARN
        /// or name. The application can be specified by ARN, ID, or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ThrottlingException">
        /// The maximum number of API requests has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/AssociateResource">REST API Reference for AssociateResource Operation</seealso>
        Task<AssociateResourceResponse> AssociateResourceAsync(AssociateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApplication



        /// <summary>
        /// Creates a new application that is the top-level node in a hierarchy of related cloud
        /// resource abstractions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ThrottlingException">
        /// The maximum number of API requests has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAttributeGroup



        /// <summary>
        /// Creates a new attribute group as a container for user-defined attributes. This feature
        /// enables users to have full control over their cloud application's metadata in a rich
        /// machine-readable format to facilitate integration with automated workflows and third-party
        /// tools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAttributeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/CreateAttributeGroup">REST API Reference for CreateAttributeGroup Operation</seealso>
        Task<CreateAttributeGroupResponse> CreateAttributeGroupAsync(CreateAttributeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApplication



        /// <summary>
        /// Deletes an application that is specified either by its application ID, name, or ARN.
        /// All associated attribute groups and resources must be disassociated from it before
        /// deleting an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAttributeGroup



        /// <summary>
        /// Deletes an attribute group, specified either by its attribute group ID, name, or ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DeleteAttributeGroup">REST API Reference for DeleteAttributeGroup Operation</seealso>
        Task<DeleteAttributeGroupResponse> DeleteAttributeGroupAsync(DeleteAttributeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateAttributeGroup



        /// <summary>
        /// Disassociates an attribute group from an application to remove the extra attributes
        /// contained in the attribute group from the application's metadata. This operation reverts
        /// <code>AssociateAttributeGroup</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAttributeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DisassociateAttributeGroup">REST API Reference for DisassociateAttributeGroup Operation</seealso>
        Task<DisassociateAttributeGroupResponse> DisassociateAttributeGroupAsync(DisassociateAttributeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateResource



        /// <summary>
        /// Disassociates a resource from application. Both the resource and the application can
        /// be specified either by ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ThrottlingException">
        /// The maximum number of API requests has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/DisassociateResource">REST API Reference for DisassociateResource Operation</seealso>
        Task<DisassociateResourceResponse> DisassociateResourceAsync(DisassociateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApplication



        /// <summary>
        /// Retrieves metadata information about one of your applications. The application can
        /// be specified by its ARN, ID, or name (which is unique within one account in one region
        /// at a given point in time). Specify by ARN or ID in automated workflows if you want
        /// to make sure that the exact same application is returned or a <code>ResourceNotFoundException</code>
        /// is thrown, avoiding the ABA addressing problem.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetApplication">REST API Reference for GetApplication Operation</seealso>
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAssociatedResource



        /// <summary>
        /// Gets the resource associated with the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociatedResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssociatedResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetAssociatedResource">REST API Reference for GetAssociatedResource Operation</seealso>
        Task<GetAssociatedResourceResponse> GetAssociatedResourceAsync(GetAssociatedResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAttributeGroup



        /// <summary>
        /// Retrieves an attribute group by its ARN, ID, or name. The attribute group can be
        /// specified by its ARN, ID, or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttributeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetAttributeGroup">REST API Reference for GetAttributeGroup Operation</seealso>
        Task<GetAttributeGroupResponse> GetAttributeGroupAsync(GetAttributeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConfiguration



        /// <summary>
        /// Retrieves a <code>TagKey</code> configuration from an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguration service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/GetConfiguration">REST API Reference for GetConfiguration Operation</seealso>
        Task<GetConfigurationResponse> GetConfigurationAsync(GetConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplications



        /// <summary>
        /// Retrieves a list of all of your applications. Results are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssociatedAttributeGroups



        /// <summary>
        /// Lists all attribute groups that are associated with specified application. Results
        /// are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedAttributeGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociatedAttributeGroups service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAssociatedAttributeGroups">REST API Reference for ListAssociatedAttributeGroups Operation</seealso>
        Task<ListAssociatedAttributeGroupsResponse> ListAssociatedAttributeGroupsAsync(ListAssociatedAttributeGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssociatedResources



        /// <summary>
        /// Lists all of the resources that are associated with the specified application. Results
        /// are paginated. 
        /// 
        ///  <note> 
        /// <para>
        ///  If you share an application, and a consumer account associates a tag query to the
        /// application, all of the users who can access the application can also view the tag
        /// values in all accounts that are associated with it using this API. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociatedResources service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAssociatedResources">REST API Reference for ListAssociatedResources Operation</seealso>
        Task<ListAssociatedResourcesResponse> ListAssociatedResourcesAsync(ListAssociatedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAttributeGroups



        /// <summary>
        /// Lists all attribute groups which you have access to. Results are paginated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttributeGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttributeGroups service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAttributeGroups">REST API Reference for ListAttributeGroups Operation</seealso>
        Task<ListAttributeGroupsResponse> ListAttributeGroupsAsync(ListAttributeGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAttributeGroupsForApplication



        /// <summary>
        /// Lists the details of all attribute groups associated with a specific application.
        /// The results display in pages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttributeGroupsForApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttributeGroupsForApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListAttributeGroupsForApplication">REST API Reference for ListAttributeGroupsForApplication Operation</seealso>
        Task<ListAttributeGroupsForApplicationResponse> ListAttributeGroupsForApplicationAsync(ListAttributeGroupsForApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all of the tags on the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutConfiguration



        /// <summary>
        /// Associates a <code>TagKey</code> configuration to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfiguration service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/PutConfiguration">REST API Reference for PutConfiguration Operation</seealso>
        Task<PutConfigurationResponse> PutConfigurationAsync(PutConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SyncResource



        /// <summary>
        /// Syncs the resource with current AppRegistry records.
        /// 
        ///  
        /// <para>
        /// Specifically, the resource’s AppRegistry system tags sync with its associated application.
        /// We remove the resource's AppRegistry system tags if it does not associate with the
        /// application. The caller must have permissions to read and update the resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SyncResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SyncResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ThrottlingException">
        /// The maximum number of API requests has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/SyncResource">REST API Reference for SyncResource Operation</seealso>
        Task<SyncResourceResponse> SyncResourceAsync(SyncResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a tag with the same key is already
        /// associated with the resource, this action updates its value.
        /// </para>
        ///  
        /// <para>
        /// This operation returns an empty response if the call was successful.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a resource.
        /// 
        ///  
        /// <para>
        /// This operation returns an empty response if the call was successful.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApplication



        /// <summary>
        /// Updates an existing application with new attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ThrottlingException">
        /// The maximum number of API requests has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAttributeGroup



        /// <summary>
        /// Updates an existing attribute group with new details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAttributeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAttributeGroup service method, as returned by AppRegistry.</returns>
        /// <exception cref="Amazon.AppRegistry.Model.ConflictException">
        /// There was a conflict when processing the request (for example, a resource with the
        /// given name already exists within the account).
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.InternalServerException">
        /// The service is experiencing internal problems.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppRegistry.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWS242AppRegistry-2020-06-24/UpdateAttributeGroup">REST API Reference for UpdateAttributeGroup Operation</seealso>
        Task<UpdateAttributeGroupResponse> UpdateAttributeGroupAsync(UpdateAttributeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}