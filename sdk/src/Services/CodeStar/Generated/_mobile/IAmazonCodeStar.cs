/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeStar.Model;

namespace Amazon.CodeStar
{
    /// <summary>
    /// Interface for accessing CodeStar
    ///
    /// AWS CodeStar 
    /// <para>
    /// This is the API reference for AWS CodeStar. This reference provides descriptions of
    /// the operations and data types for the AWS CodeStar API along with usage examples.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodeStar API to work with:
    /// </para>
    ///  
    /// <para>
    /// Projects and their resources, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateProject</a>, which creates an empty project in AWS CodeStar with no resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteProject</a>, which deletes a project in AWS CodeStar.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeProject</a>, which lists the attributes of a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListProjects</a>, which lists all AWS CodeStar projects associated with your AWS
    /// account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListResources</a>, which lists the resources associated with an AWS CodeStar project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateProject</a>, which updates the attributes of an AWS CodeStar project.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Teams and team members, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>AssociateTeamMember</a>, which adds an IAM user to the team for an AWS CodeStar
    /// project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisassociateTeamMember</a>, which removes an IAM user from the team for an AWS
    /// CodeStar project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListTeamMembers</a>, which lists all the IAM users in the team for an AWS CodeStar
    /// project, including their roles and attributes.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Users, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateUserProfile</a>, which creates a user profile that contains data associated
    /// with the user across all AWS CodeStar projects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteUserProfile</a>, which deletes all user profile information across all AWS
    /// CodeStar projects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeUserProfile</a>, which describes the profile of a user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListUserProfiles</a>, which lists all AWS CodeStar user profiles.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateUserProfile</a>, which updates the profile for an AWS CodeStar user. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonCodeStar : IAmazonService, IDisposable
    {
                
        #region  AssociateTeamMember


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTeamMember operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/AssociateTeamMember">REST API Reference for AssociateTeamMember Operation</seealso>
        Task<AssociateTeamMemberResponse> AssociateTeamMemberAsync(AssociateTeamMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProject


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateProject">REST API Reference for CreateProject Operation</seealso>
        Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUserProfile


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProject


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUserProfile


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        Task<DeleteUserProfileResponse> DeleteUserProfileAsync(DeleteUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeProject


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUserProfile


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        Task<DescribeUserProfileResponse> DescribeUserProfileAsync(DescribeUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateTeamMember


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTeamMember operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DisassociateTeamMember">REST API Reference for DisassociateTeamMember Operation</seealso>
        Task<DisassociateTeamMemberResponse> DisassociateTeamMemberAsync(DisassociateTeamMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProjects


        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListProjects">REST API Reference for ListProjects Operation</seealso>
        Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResources


        /// <summary>
        /// Initiates the asynchronous execution of the ListResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListResources">REST API Reference for ListResources Operation</seealso>
        Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTeamMembers


        /// <summary>
        /// Initiates the asynchronous execution of the ListTeamMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTeamMembers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListTeamMembers">REST API Reference for ListTeamMembers Operation</seealso>
        Task<ListTeamMembersResponse> ListTeamMembersAsync(ListTeamMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUserProfiles


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        Task<ListUserProfilesResponse> ListUserProfilesAsync(ListUserProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProject


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTeamMember


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTeamMember operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateTeamMember">REST API Reference for UpdateTeamMember Operation</seealso>
        Task<UpdateTeamMemberResponse> UpdateTeamMemberAsync(UpdateTeamMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserProfile


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}