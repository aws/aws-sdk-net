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
 * Do not modify this file. This file is generated from the route53profiles-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Route53Profiles.Model;

#pragma warning disable CS1570
namespace Amazon.Route53Profiles
{
    /// <summary>
    /// <para>Interface for accessing Route53Profiles</para>
    ///
    /// With Amazon Route 53 Profiles you can share Route 53 configurations with VPCs and
    /// AWS accounts
    /// </summary>
    public partial interface IAmazonRoute53Profiles : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRoute53ProfilesPaginatorFactory Paginators { get; }
#endif
                
        #region  AssociateProfile



        /// <summary>
        /// Associates a Route 53 Profiles profile with a VPC. A VPC can have only one Profile
        /// associated with it, but a Profile can be associated with 1000 of VPCs (and you can
        /// request a higher quota). For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html#limits-api-entities">https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html#limits-api-entities</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceExistsException">
        /// The resource you are trying to associate, has already been associated.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/AssociateProfile">REST API Reference for AssociateProfile Operation</seealso>
        Task<AssociateProfileResponse> AssociateProfileAsync(AssociateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateResourceToProfile



        /// <summary>
        /// Associates a DNS reource configuration to a Route 53 Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceToProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateResourceToProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InternalServiceErrorException">
        /// An internal server error occured. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/AssociateResourceToProfile">REST API Reference for AssociateResourceToProfile Operation</seealso>
        Task<AssociateResourceToProfileResponse> AssociateResourceToProfileAsync(AssociateResourceToProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProfile



        /// <summary>
        /// Creates an empty Route 53 Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProfile



        /// <summary>
        /// Deletes the specified Route 53 Profile. Before you can delete a profile, you must
        /// first disassociate it from all VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateProfile



        /// <summary>
        /// Dissociates a specified Route 53 Profile from the specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DisassociateProfile">REST API Reference for DisassociateProfile Operation</seealso>
        Task<DisassociateProfileResponse> DisassociateProfileAsync(DisassociateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateResourceFromProfile



        /// <summary>
        /// Dissoaciated a specified resource, from the Route 53 Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceFromProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateResourceFromProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InternalServiceErrorException">
        /// An internal server error occured. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DisassociateResourceFromProfile">REST API Reference for DisassociateResourceFromProfile Operation</seealso>
        Task<DisassociateResourceFromProfileResponse> DisassociateResourceFromProfileAsync(DisassociateResourceFromProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProfile



        /// <summary>
        /// Returns information about a specified Route 53 Profile, such as whether whether the
        /// Profile is shared, and the current status of the Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfile">REST API Reference for GetProfile Operation</seealso>
        Task<GetProfileResponse> GetProfileAsync(GetProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProfileAssociation



        /// <summary>
        /// Retrieves a Route 53 Profile association for a VPC. A VPC can have only one Profile
        /// association, but a Profile can be associated with up to 5000 VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfileAssociation service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfileAssociation">REST API Reference for GetProfileAssociation Operation</seealso>
        Task<GetProfileAssociationResponse> GetProfileAssociationAsync(GetProfileAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProfileResourceAssociation



        /// <summary>
        /// Returns information about a specified Route 53 Profile resource association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileResourceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfileResourceAssociation service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfileResourceAssociation">REST API Reference for GetProfileResourceAssociation Operation</seealso>
        Task<GetProfileResourceAssociationResponse> GetProfileResourceAssociationAsync(GetProfileResourceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProfileAssociations



        /// <summary>
        /// Lists all the VPCs that the specified Route 53 Profile is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfileAssociations service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> you provided isn;t valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfileAssociations">REST API Reference for ListProfileAssociations Operation</seealso>
        Task<ListProfileAssociationsResponse> ListProfileAssociationsAsync(ListProfileAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProfileResourceAssociations



        /// <summary>
        /// Lists all the resource associations for the specified Route 53 Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileResourceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfileResourceAssociations service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InternalServiceErrorException">
        /// An internal server error occured. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> you provided isn;t valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfileResourceAssociations">REST API Reference for ListProfileResourceAssociations Operation</seealso>
        Task<ListProfileResourceAssociationsResponse> ListProfileResourceAssociationsAsync(ListProfileResourceAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProfiles



        /// <summary>
        /// Lists all the Route 53 Profiles associated with your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfiles service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> you provided isn;t valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        Task<ListProfilesResponse> ListProfilesAsync(ListProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags that you associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds one or more tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProfileResourceAssociation



        /// <summary>
        /// Updates the specified Route 53 Profile resourse association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfileResourceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProfileResourceAssociation service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InternalServiceErrorException">
        /// An internal server error occured. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/UpdateProfileResourceAssociation">REST API Reference for UpdateProfileResourceAssociation Operation</seealso>
        Task<UpdateProfileResourceAssociationResponse> UpdateProfileResourceAssociationAsync(UpdateProfileResourceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonRoute53ProfilesConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonRoute53ProfilesConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonRoute53ProfilesConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonRoute53ProfilesConfig to create AmazonRoute53ProfilesClient");
            }

            return awsCredentials == null ? 
                    new AmazonRoute53ProfilesClient(serviceClientConfig) :
                    new AmazonRoute53ProfilesClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}