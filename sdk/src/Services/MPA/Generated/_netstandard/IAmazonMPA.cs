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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MPA.Model;

#pragma warning disable CS1570
namespace Amazon.MPA
{
    /// <summary>
    /// <para>Interface for accessing MPA</para>
    ///
    /// Multi-party approval is a capability of <a href="http://aws.amazon.com/organizations">Organizations</a>
    /// that allows you to protect a predefined list of operations through a distributed approval
    /// process. Use Multi-party approval to establish approval workflows and transform security
    /// processes into team-based decisions.
    /// 
    ///  
    /// <para>
    ///  <b>When to use Multi-party approval</b>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You need to align with the Zero Trust principle of "never trust, always verify"
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You need to make sure that the right humans have access to the right things in the
    /// right way
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You need distributed decision-making for sensitive or critical operations
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You need to protect against unintended operations on sensitive or critical resources
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You need formal reviews and approvals for auditing or compliance reasons
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/what-is.html">What
    /// is Multi-party approval</a> in the <i>Multi-party approval User Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonMPA : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMPAPaginatorFactory Paginators { get; }
#endif
                
        #region  CancelSession



        /// <summary>
        /// Cancels an approval session. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Session</a>
        /// in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSession service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ConflictException">
        /// The request cannot be completed because it conflicts with the current state of a resource.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/CancelSession">REST API Reference for CancelSession Operation</seealso>
        Task<CancelSessionResponse> CancelSessionAsync(CancelSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApprovalTeam



        /// <summary>
        /// Creates a new approval team. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Approval
        /// team</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApprovalTeam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApprovalTeam service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ConflictException">
        /// The request cannot be completed because it conflicts with the current state of a resource.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota for your account. Request a quota increase or
        /// reduce your request size.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/CreateApprovalTeam">REST API Reference for CreateApprovalTeam Operation</seealso>
        Task<CreateApprovalTeamResponse> CreateApprovalTeamAsync(CreateApprovalTeamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIdentitySource



        /// <summary>
        /// Creates a new identity source. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
        /// Source</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentitySource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIdentitySource service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota for your account. Request a quota increase or
        /// reduce your request size.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/CreateIdentitySource">REST API Reference for CreateIdentitySource Operation</seealso>
        Task<CreateIdentitySourceResponse> CreateIdentitySourceAsync(CreateIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIdentitySource



        /// <summary>
        /// Deletes an identity source. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
        /// Source</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentitySource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdentitySource service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ConflictException">
        /// The request cannot be completed because it conflicts with the current state of a resource.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/DeleteIdentitySource">REST API Reference for DeleteIdentitySource Operation</seealso>
        Task<DeleteIdentitySourceResponse> DeleteIdentitySourceAsync(DeleteIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInactiveApprovalTeamVersion



        /// <summary>
        /// Deletes an inactive approval team. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-health.html">Team
        /// health</a> in the <i>Multi-party approval User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can also use this operation to delete a team draft. For more information, see
        /// <a href="https://docs.aws.amazon.com/mpa/latest/userguide/update-team.html#update-team-draft-status">Interacting
        /// with drafts</a> in the <i>Multi-party approval User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInactiveApprovalTeamVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInactiveApprovalTeamVersion service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ConflictException">
        /// The request cannot be completed because it conflicts with the current state of a resource.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/DeleteInactiveApprovalTeamVersion">REST API Reference for DeleteInactiveApprovalTeamVersion Operation</seealso>
        Task<DeleteInactiveApprovalTeamVersionResponse> DeleteInactiveApprovalTeamVersionAsync(DeleteInactiveApprovalTeamVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApprovalTeam



        /// <summary>
        /// Returns details for an approval team.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApprovalTeam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApprovalTeam service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetApprovalTeam">REST API Reference for GetApprovalTeam Operation</seealso>
        Task<GetApprovalTeamResponse> GetApprovalTeamAsync(GetApprovalTeamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIdentitySource



        /// <summary>
        /// Returns details for an identity source. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
        /// Source</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentitySource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentitySource service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetIdentitySource">REST API Reference for GetIdentitySource Operation</seealso>
        Task<GetIdentitySourceResponse> GetIdentitySourceAsync(GetIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPolicyVersion



        /// <summary>
        /// Returns details for the version of a policy. Policies define the permissions for team
        /// resources.
        /// 
        ///  
        /// <para>
        /// The protected operation for a service integration might require specific permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-integrations.html">How
        /// other services work with Multi-party approval</a> in the <i>Multi-party approval User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicyVersion service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        Task<GetPolicyVersionResponse> GetPolicyVersionAsync(GetPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResourcePolicy



        /// <summary>
        /// Returns details about a policy for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InvalidParameterException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSession



        /// <summary>
        /// Returns details for an approval session. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Session</a>
        /// in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetSession">REST API Reference for GetSession Operation</seealso>
        Task<GetSessionResponse> GetSessionAsync(GetSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApprovalTeams



        /// <summary>
        /// Returns a list of approval teams.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApprovalTeams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApprovalTeams service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListApprovalTeams">REST API Reference for ListApprovalTeams Operation</seealso>
        Task<ListApprovalTeamsResponse> ListApprovalTeamsAsync(ListApprovalTeamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIdentitySources



        /// <summary>
        /// Returns a list of identity sources. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
        /// Source</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentitySources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentitySources service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListIdentitySources">REST API Reference for ListIdentitySources Operation</seealso>
        Task<ListIdentitySourcesResponse> ListIdentitySourcesAsync(ListIdentitySourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPolicies



        /// <summary>
        /// Returns a list of policies. Policies define the permissions for team resources.
        /// 
        ///  
        /// <para>
        /// The protected operation for a service integration might require specific permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-integrations.html">How
        /// other services work with Multi-party approval</a> in the <i>Multi-party approval User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPolicyVersions



        /// <summary>
        /// Returns a list of the versions for policies. Policies define the permissions for team
        /// resources.
        /// 
        ///  
        /// <para>
        /// The protected operation for a service integration might require specific permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-integrations.html">How
        /// other services work with Multi-party approval</a> in the <i>Multi-party approval User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicyVersions service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        Task<ListPolicyVersionsResponse> ListPolicyVersionsAsync(ListPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourcePolicies



        /// <summary>
        /// Returns a list of policies for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcePolicies service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListResourcePolicies">REST API Reference for ListResourcePolicies Operation</seealso>
        Task<ListResourcePoliciesResponse> ListResourcePoliciesAsync(ListResourcePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSessions



        /// <summary>
        /// Returns a list of approval sessions. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Session</a>
        /// in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListSessions">REST API Reference for ListSessions Operation</seealso>
        Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartActiveApprovalTeamDeletion



        /// <summary>
        /// Starts the deletion process for an active approval team.
        /// 
        ///  <note> 
        /// <para>
        ///  <b>Deletions require team approval</b> 
        /// </para>
        ///  
        /// <para>
        /// Requests to delete an active team must be approved by the team.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartActiveApprovalTeamDeletion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartActiveApprovalTeamDeletion service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ConflictException">
        /// The request cannot be completed because it conflicts with the current state of a resource.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/StartActiveApprovalTeamDeletion">REST API Reference for StartActiveApprovalTeamDeletion Operation</seealso>
        Task<StartActiveApprovalTeamDeletionResponse> StartActiveApprovalTeamDeletionAsync(StartActiveApprovalTeamDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Creates or updates a resource tag. Each tag is a label consisting of a user-defined
        /// key and value. Tags can help you manage, identify, organize, search for, and filter
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.TooManyTagsException">
        /// The request exceeds the maximum number of tags allowed for this resource. Remove some
        /// tags, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a resource tag. Each tag is a label consisting of a user-defined key and value.
        /// Tags can help you manage, identify, organize, search for, and filter resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApprovalTeam



        /// <summary>
        /// Updates an approval team. You can request to update the team description, approval
        /// threshold, and approvers in the team.
        /// 
        ///  <note> 
        /// <para>
        ///  <b>Updates require team approval</b> 
        /// </para>
        ///  
        /// <para>
        /// Updates to an active team must be approved by the team.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalTeam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApprovalTeam service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ConflictException">
        /// The request cannot be completed because it conflicts with the current state of a resource.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota for your account. Request a quota increase or
        /// reduce your request size.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/UpdateApprovalTeam">REST API Reference for UpdateApprovalTeam Operation</seealso>
        Task<UpdateApprovalTeamResponse> UpdateApprovalTeamAsync(UpdateApprovalTeamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonMPAConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonMPAConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonMPAConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonMPAConfig to create AmazonMPAClient");
            }

            return awsCredentials == null ? 
                    new AmazonMPAClient(serviceClientConfig) :
                    new AmazonMPAClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}