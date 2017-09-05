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
    ///  <code>DeleteProject</code>, which deletes a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeProject</code>, which lists the attributes of a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListProjects</code>, which lists all projects associated with your AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListResources</code>, which lists the resources associated with a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListTagsForProject</code>, which lists the tags associated with a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>TagProject</code>, which adds tags to a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UntagProject</code>, which removes tags from a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateProject</code>, which updates the attributes of a project.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Teams and team members, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>AssociateTeamMember</code>, which adds an IAM user to the team for a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DisassociateTeamMember</code>, which removes an IAM user from the team for
    /// a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListTeamMembers</code>, which lists all the IAM users in the team for a project,
    /// including their roles and attributes.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateTeamMember</code>, which updates a team member's attributes in a project.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Users, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>CreateUserProfile</code>, which creates a user profile that contains data associated
    /// with the user across all projects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteUserProfile</code>, which deletes all user profile information across
    /// all projects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeUserProfile</code>, which describes the profile of a user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListUserProfiles</code>, which lists all user profiles.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateUserProfile</code>, which updates the profile for a user.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonCodeStar : IAmazonService, IDisposable
    {

        
        #region  AssociateTeamMember


        /// <summary>
        /// Adds an IAM user to the team for an AWS CodeStar project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTeamMember service method.</param>
        /// 
        /// <returns>The response from the AssociateTeamMember service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.InvalidServiceRoleException">
        /// The service role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.LimitExceededException">
        /// A resource limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectConfigurationException">
        /// Project configuration information is required but not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.TeamMemberAlreadyAssociatedException">
        /// The team member is already associated with a role in this project.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/AssociateTeamMember">REST API Reference for AssociateTeamMember Operation</seealso>
        AssociateTeamMemberResponse AssociateTeamMember(AssociateTeamMemberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTeamMember operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTeamMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/AssociateTeamMember">REST API Reference for AssociateTeamMember Operation</seealso>
        IAsyncResult BeginAssociateTeamMember(AssociateTeamMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTeamMember.</param>
        /// 
        /// <returns>Returns a  AssociateTeamMemberResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/AssociateTeamMember">REST API Reference for AssociateTeamMember Operation</seealso>
        AssociateTeamMemberResponse EndAssociateTeamMember(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProject


        /// <summary>
        /// Reserved for future use. To create a project, use the AWS CodeStar console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.InvalidServiceRoleException">
        /// The service role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.LimitExceededException">
        /// A resource limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectAlreadyExistsException">
        /// An AWS CodeStar project with the same ID already exists in this region for the AWS
        /// account. AWS CodeStar project IDs must be unique within a region for the AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectConfigurationException">
        /// Project configuration information is required but not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectCreationFailedException">
        /// The project creation request was valid, but a nonspecific exception or error occurred
        /// during project creation. The project could not be created in AWS CodeStar.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse CreateProject(CreateProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateProject">REST API Reference for CreateProject Operation</seealso>
        IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateProject">REST API Reference for CreateProject Operation</seealso>
        CreateProjectResponse EndCreateProject(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUserProfile


        /// <summary>
        /// Creates a profile for a user that includes user preferences, such as the display name
        /// and email address assocciated with the user, in AWS CodeStar. The user profile is
        /// not project-specific. Information in the user profile is displayed wherever the user's
        /// information appears to other users in AWS CodeStar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.UserProfileAlreadyExistsException">
        /// A user profile with that name already exists in this region for the AWS account. AWS
        /// CodeStar user profile names must be unique within a region for the AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        IAsyncResult BeginCreateUserProfile(CreateUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserProfile.</param>
        /// 
        /// <returns>Returns a  CreateUserProfileResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        CreateUserProfileResponse EndCreateUserProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProject


        /// <summary>
        /// Deletes a project, including project resources. Does not delete users associated with
        /// the project, but does delete the IAM roles that allowed access to the project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.InvalidServiceRoleException">
        /// The service role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse DeleteProject(DeleteProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUserProfile


        /// <summary>
        /// Deletes a user profile in AWS CodeStar, including all personal preference data associated
        /// with that profile, such as display name and email address. It does not delete the
        /// history of that user, for example the history of commits made by that user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteUserProfile service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        DeleteUserProfileResponse DeleteUserProfile(DeleteUserProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserProfile operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        IAsyncResult BeginDeleteUserProfile(DeleteUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserProfile.</param>
        /// 
        /// <returns>Returns a  DeleteUserProfileResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DeleteUserProfile">REST API Reference for DeleteUserProfile Operation</seealso>
        DeleteUserProfileResponse EndDeleteUserProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProject


        /// <summary>
        /// Describes a project and its resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.InvalidServiceRoleException">
        /// The service role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectConfigurationException">
        /// Project configuration information is required but not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        DescribeProjectResponse DescribeProject(DescribeProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        IAsyncResult BeginDescribeProject(DescribeProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProject.</param>
        /// 
        /// <returns>Returns a  DescribeProjectResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        DescribeProjectResponse EndDescribeProject(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeUserProfile


        /// <summary>
        /// Describes a user in AWS CodeStar and the user attributes across all projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeUserProfile service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.UserProfileNotFoundException">
        /// The user profile was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        DescribeUserProfileResponse DescribeUserProfile(DescribeUserProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserProfile operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        IAsyncResult BeginDescribeUserProfile(DescribeUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUserProfile.</param>
        /// 
        /// <returns>Returns a  DescribeUserProfileResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DescribeUserProfile">REST API Reference for DescribeUserProfile Operation</seealso>
        DescribeUserProfileResponse EndDescribeUserProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateTeamMember


        /// <summary>
        /// Removes a user from a project. Removing a user from a project also removes the IAM
        /// policies from that user that allowed access to the project and its resources. Disassociating
        /// a team member does not remove that user's profile from AWS CodeStar. It does not remove
        /// the user from IAM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTeamMember service method.</param>
        /// 
        /// <returns>The response from the DisassociateTeamMember service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.InvalidServiceRoleException">
        /// The service role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DisassociateTeamMember">REST API Reference for DisassociateTeamMember Operation</seealso>
        DisassociateTeamMemberResponse DisassociateTeamMember(DisassociateTeamMemberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTeamMember operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateTeamMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DisassociateTeamMember">REST API Reference for DisassociateTeamMember Operation</seealso>
        IAsyncResult BeginDisassociateTeamMember(DisassociateTeamMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateTeamMember.</param>
        /// 
        /// <returns>Returns a  DisassociateTeamMemberResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/DisassociateTeamMember">REST API Reference for DisassociateTeamMember Operation</seealso>
        DisassociateTeamMemberResponse EndDisassociateTeamMember(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProjects


        /// <summary>
        /// Lists all projects in AWS CodeStar associated with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.InvalidNextTokenException">
        /// The next token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse ListProjects(ListProjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListProjects">REST API Reference for ListProjects Operation</seealso>
        IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListProjects">REST API Reference for ListProjects Operation</seealso>
        ListProjectsResponse EndListProjects(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResources


        /// <summary>
        /// Lists resources associated with a project in AWS CodeStar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.InvalidNextTokenException">
        /// The next token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListResources">REST API Reference for ListResources Operation</seealso>
        ListResourcesResponse ListResources(ListResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListResources">REST API Reference for ListResources Operation</seealso>
        IAsyncResult BeginListResources(ListResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResources.</param>
        /// 
        /// <returns>Returns a  ListResourcesResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListResources">REST API Reference for ListResources Operation</seealso>
        ListResourcesResponse EndListResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForProject


        /// <summary>
        /// Gets the tags for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForProject service method.</param>
        /// 
        /// <returns>The response from the ListTagsForProject service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.InvalidNextTokenException">
        /// The next token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListTagsForProject">REST API Reference for ListTagsForProject Operation</seealso>
        ListTagsForProjectResponse ListTagsForProject(ListTagsForProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForProject operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListTagsForProject">REST API Reference for ListTagsForProject Operation</seealso>
        IAsyncResult BeginListTagsForProject(ListTagsForProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForProject.</param>
        /// 
        /// <returns>Returns a  ListTagsForProjectResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListTagsForProject">REST API Reference for ListTagsForProject Operation</seealso>
        ListTagsForProjectResponse EndListTagsForProject(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTeamMembers


        /// <summary>
        /// Lists all team members associated with a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTeamMembers service method.</param>
        /// 
        /// <returns>The response from the ListTeamMembers service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.InvalidNextTokenException">
        /// The next token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListTeamMembers">REST API Reference for ListTeamMembers Operation</seealso>
        ListTeamMembersResponse ListTeamMembers(ListTeamMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTeamMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTeamMembers operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTeamMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListTeamMembers">REST API Reference for ListTeamMembers Operation</seealso>
        IAsyncResult BeginListTeamMembers(ListTeamMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTeamMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTeamMembers.</param>
        /// 
        /// <returns>Returns a  ListTeamMembersResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListTeamMembers">REST API Reference for ListTeamMembers Operation</seealso>
        ListTeamMembersResponse EndListTeamMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUserProfiles


        /// <summary>
        /// Lists all the user profiles configured for your AWS account in AWS CodeStar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserProfiles service method.</param>
        /// 
        /// <returns>The response from the ListUserProfiles service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.InvalidNextTokenException">
        /// The next token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        ListUserProfilesResponse ListUserProfiles(ListUserProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserProfiles operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        IAsyncResult BeginListUserProfiles(ListUserProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserProfiles.</param>
        /// 
        /// <returns>Returns a  ListUserProfilesResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/ListUserProfiles">REST API Reference for ListUserProfiles Operation</seealso>
        ListUserProfilesResponse EndListUserProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  TagProject


        /// <summary>
        /// Adds tags to a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagProject service method.</param>
        /// 
        /// <returns>The response from the TagProject service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.LimitExceededException">
        /// A resource limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/TagProject">REST API Reference for TagProject Operation</seealso>
        TagProjectResponse TagProject(TagProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagProject operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/TagProject">REST API Reference for TagProject Operation</seealso>
        IAsyncResult BeginTagProject(TagProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagProject.</param>
        /// 
        /// <returns>Returns a  TagProjectResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/TagProject">REST API Reference for TagProject Operation</seealso>
        TagProjectResponse EndTagProject(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagProject


        /// <summary>
        /// Removes tags from a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagProject service method.</param>
        /// 
        /// <returns>The response from the UntagProject service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.LimitExceededException">
        /// A resource limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UntagProject">REST API Reference for UntagProject Operation</seealso>
        UntagProjectResponse UntagProject(UntagProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagProject operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UntagProject">REST API Reference for UntagProject Operation</seealso>
        IAsyncResult BeginUntagProject(UntagProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagProject.</param>
        /// 
        /// <returns>Returns a  UntagProjectResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UntagProject">REST API Reference for UntagProject Operation</seealso>
        UntagProjectResponse EndUntagProject(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProject


        /// <summary>
        /// Updates a project in AWS CodeStar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse UpdateProject(UpdateProjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        IAsyncResult BeginUpdateProject(UpdateProjectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProject.</param>
        /// 
        /// <returns>Returns a  UpdateProjectResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        UpdateProjectResponse EndUpdateProject(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTeamMember


        /// <summary>
        /// Updates a team member's attributes in an AWS CodeStar project. For example, you can
        /// change a team member's role in the project, or change whether they have remote access
        /// to project resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTeamMember service method.</param>
        /// 
        /// <returns>The response from the UpdateTeamMember service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.InvalidServiceRoleException">
        /// The service role is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.LimitExceededException">
        /// A resource limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectConfigurationException">
        /// Project configuration information is required but not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ProjectNotFoundException">
        /// The specified AWS CodeStar project was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.TeamMemberNotFoundException">
        /// The specified team member was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateTeamMember">REST API Reference for UpdateTeamMember Operation</seealso>
        UpdateTeamMemberResponse UpdateTeamMember(UpdateTeamMemberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTeamMember operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTeamMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateTeamMember">REST API Reference for UpdateTeamMember Operation</seealso>
        IAsyncResult BeginUpdateTeamMember(UpdateTeamMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTeamMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTeamMember.</param>
        /// 
        /// <returns>Returns a  UpdateTeamMemberResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateTeamMember">REST API Reference for UpdateTeamMember Operation</seealso>
        UpdateTeamMemberResponse EndUpdateTeamMember(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUserProfile


        /// <summary>
        /// Updates a user's profile in AWS CodeStar. The user profile is not project-specific.
        /// Information in the user profile is displayed wherever the user's information appears
        /// to other users in AWS CodeStar.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateUserProfile service method, as returned by CodeStar.</returns>
        /// <exception cref="Amazon.CodeStar.Model.UserProfileNotFoundException">
        /// The user profile was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeStar.Model.ValidationException">
        /// The specified input is either not valid, or it could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation on AmazonCodeStarClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        IAsyncResult BeginUpdateUserProfile(UpdateUserProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserProfile.</param>
        /// 
        /// <returns>Returns a  UpdateUserProfileResult from CodeStar.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codestar-2017-04-19/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        UpdateUserProfileResponse EndUpdateUserProfile(IAsyncResult asyncResult);

        #endregion
        
    }
}