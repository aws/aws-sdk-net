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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Macie2.Model;

namespace Amazon.Macie2
{
    /// <summary>
    /// Interface for accessing Macie2
    ///
    /// Amazon Macie
    /// </summary>
    public partial interface IAmazonMacie2 : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMacie2PaginatorFactory Paginators { get; }
#endif


        
        #region  AcceptInvitation


        /// <summary>
        /// Accepts an Amazon Macie membership invitation that was received from a specific account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        IAsyncResult BeginAcceptInvitation(AcceptInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptInvitation.</param>
        /// 
        /// <returns>Returns a  AcceptInvitationResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        AcceptInvitationResponse EndAcceptInvitation(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetCustomDataIdentifiers


        /// <summary>
        /// Retrieves information about one or more custom data identifiers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCustomDataIdentifiers service method.</param>
        /// 
        /// <returns>The response from the BatchGetCustomDataIdentifiers service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/BatchGetCustomDataIdentifiers">REST API Reference for BatchGetCustomDataIdentifiers Operation</seealso>
        BatchGetCustomDataIdentifiersResponse BatchGetCustomDataIdentifiers(BatchGetCustomDataIdentifiersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetCustomDataIdentifiers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCustomDataIdentifiers operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetCustomDataIdentifiers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/BatchGetCustomDataIdentifiers">REST API Reference for BatchGetCustomDataIdentifiers Operation</seealso>
        IAsyncResult BeginBatchGetCustomDataIdentifiers(BatchGetCustomDataIdentifiersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetCustomDataIdentifiers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetCustomDataIdentifiers.</param>
        /// 
        /// <returns>Returns a  BatchGetCustomDataIdentifiersResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/BatchGetCustomDataIdentifiers">REST API Reference for BatchGetCustomDataIdentifiers Operation</seealso>
        BatchGetCustomDataIdentifiersResponse EndBatchGetCustomDataIdentifiers(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAllowList


        /// <summary>
        /// Creates and defines the settings for an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAllowList service method.</param>
        /// 
        /// <returns>The response from the CreateAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateAllowList">REST API Reference for CreateAllowList Operation</seealso>
        CreateAllowListResponse CreateAllowList(CreateAllowListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAllowList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAllowList operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAllowList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateAllowList">REST API Reference for CreateAllowList Operation</seealso>
        IAsyncResult BeginCreateAllowList(CreateAllowListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAllowList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAllowList.</param>
        /// 
        /// <returns>Returns a  CreateAllowListResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateAllowList">REST API Reference for CreateAllowList Operation</seealso>
        CreateAllowListResponse EndCreateAllowList(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateClassificationJob


        /// <summary>
        /// Creates and defines the settings for a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClassificationJob service method.</param>
        /// 
        /// <returns>The response from the CreateClassificationJob service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateClassificationJob">REST API Reference for CreateClassificationJob Operation</seealso>
        CreateClassificationJobResponse CreateClassificationJob(CreateClassificationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClassificationJob operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClassificationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateClassificationJob">REST API Reference for CreateClassificationJob Operation</seealso>
        IAsyncResult BeginCreateClassificationJob(CreateClassificationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClassificationJob.</param>
        /// 
        /// <returns>Returns a  CreateClassificationJobResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateClassificationJob">REST API Reference for CreateClassificationJob Operation</seealso>
        CreateClassificationJobResponse EndCreateClassificationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCustomDataIdentifier


        /// <summary>
        /// Creates and defines the criteria and other settings for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomDataIdentifier service method.</param>
        /// 
        /// <returns>The response from the CreateCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateCustomDataIdentifier">REST API Reference for CreateCustomDataIdentifier Operation</seealso>
        CreateCustomDataIdentifierResponse CreateCustomDataIdentifier(CreateCustomDataIdentifierRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomDataIdentifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomDataIdentifier operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomDataIdentifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateCustomDataIdentifier">REST API Reference for CreateCustomDataIdentifier Operation</seealso>
        IAsyncResult BeginCreateCustomDataIdentifier(CreateCustomDataIdentifierRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomDataIdentifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomDataIdentifier.</param>
        /// 
        /// <returns>Returns a  CreateCustomDataIdentifierResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateCustomDataIdentifier">REST API Reference for CreateCustomDataIdentifier Operation</seealso>
        CreateCustomDataIdentifierResponse EndCreateCustomDataIdentifier(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFindingsFilter


        /// <summary>
        /// Creates and defines the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsFilter service method.</param>
        /// 
        /// <returns>The response from the CreateFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateFindingsFilter">REST API Reference for CreateFindingsFilter Operation</seealso>
        CreateFindingsFilterResponse CreateFindingsFilter(CreateFindingsFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFindingsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFindingsFilter operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFindingsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateFindingsFilter">REST API Reference for CreateFindingsFilter Operation</seealso>
        IAsyncResult BeginCreateFindingsFilter(CreateFindingsFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFindingsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFindingsFilter.</param>
        /// 
        /// <returns>Returns a  CreateFindingsFilterResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateFindingsFilter">REST API Reference for CreateFindingsFilter Operation</seealso>
        CreateFindingsFilterResponse EndCreateFindingsFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInvitations


        /// <summary>
        /// Sends an Amazon Macie membership invitation to one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvitations service method.</param>
        /// 
        /// <returns>The response from the CreateInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateInvitations">REST API Reference for CreateInvitations Operation</seealso>
        CreateInvitationsResponse CreateInvitations(CreateInvitationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvitations operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateInvitations">REST API Reference for CreateInvitations Operation</seealso>
        IAsyncResult BeginCreateInvitations(CreateInvitationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInvitations.</param>
        /// 
        /// <returns>Returns a  CreateInvitationsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateInvitations">REST API Reference for CreateInvitations Operation</seealso>
        CreateInvitationsResponse EndCreateInvitations(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMember


        /// <summary>
        /// Associates an account with an Amazon Macie administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMember service method.</param>
        /// 
        /// <returns>The response from the CreateMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateMember">REST API Reference for CreateMember Operation</seealso>
        CreateMemberResponse CreateMember(CreateMemberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMember operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateMember">REST API Reference for CreateMember Operation</seealso>
        IAsyncResult BeginCreateMember(CreateMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMember.</param>
        /// 
        /// <returns>Returns a  CreateMemberResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateMember">REST API Reference for CreateMember Operation</seealso>
        CreateMemberResponse EndCreateMember(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSampleFindings


        /// <summary>
        /// Creates sample findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings service method.</param>
        /// 
        /// <returns>The response from the CreateSampleFindings service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        CreateSampleFindingsResponse CreateSampleFindings(CreateSampleFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSampleFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSampleFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        IAsyncResult BeginCreateSampleFindings(CreateSampleFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSampleFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSampleFindings.</param>
        /// 
        /// <returns>Returns a  CreateSampleFindingsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        CreateSampleFindingsResponse EndCreateSampleFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  DeclineInvitations


        /// <summary>
        /// Declines Amazon Macie membership invitations that were received from specific accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// 
        /// <returns>The response from the DeclineInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        DeclineInvitationsResponse DeclineInvitations(DeclineInvitationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeclineInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeclineInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        IAsyncResult BeginDeclineInvitations(DeclineInvitationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeclineInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeclineInvitations.</param>
        /// 
        /// <returns>Returns a  DeclineInvitationsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        DeclineInvitationsResponse EndDeclineInvitations(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAllowList


        /// <summary>
        /// Deletes an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAllowList service method.</param>
        /// 
        /// <returns>The response from the DeleteAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteAllowList">REST API Reference for DeleteAllowList Operation</seealso>
        DeleteAllowListResponse DeleteAllowList(DeleteAllowListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAllowList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAllowList operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAllowList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteAllowList">REST API Reference for DeleteAllowList Operation</seealso>
        IAsyncResult BeginDeleteAllowList(DeleteAllowListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAllowList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAllowList.</param>
        /// 
        /// <returns>Returns a  DeleteAllowListResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteAllowList">REST API Reference for DeleteAllowList Operation</seealso>
        DeleteAllowListResponse EndDeleteAllowList(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCustomDataIdentifier


        /// <summary>
        /// Soft deletes a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomDataIdentifier service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteCustomDataIdentifier">REST API Reference for DeleteCustomDataIdentifier Operation</seealso>
        DeleteCustomDataIdentifierResponse DeleteCustomDataIdentifier(DeleteCustomDataIdentifierRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomDataIdentifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomDataIdentifier operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomDataIdentifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteCustomDataIdentifier">REST API Reference for DeleteCustomDataIdentifier Operation</seealso>
        IAsyncResult BeginDeleteCustomDataIdentifier(DeleteCustomDataIdentifierRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomDataIdentifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomDataIdentifier.</param>
        /// 
        /// <returns>Returns a  DeleteCustomDataIdentifierResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteCustomDataIdentifier">REST API Reference for DeleteCustomDataIdentifier Operation</seealso>
        DeleteCustomDataIdentifierResponse EndDeleteCustomDataIdentifier(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFindingsFilter


        /// <summary>
        /// Deletes a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFindingsFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteFindingsFilter">REST API Reference for DeleteFindingsFilter Operation</seealso>
        DeleteFindingsFilterResponse DeleteFindingsFilter(DeleteFindingsFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFindingsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFindingsFilter operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFindingsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteFindingsFilter">REST API Reference for DeleteFindingsFilter Operation</seealso>
        IAsyncResult BeginDeleteFindingsFilter(DeleteFindingsFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFindingsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFindingsFilter.</param>
        /// 
        /// <returns>Returns a  DeleteFindingsFilterResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteFindingsFilter">REST API Reference for DeleteFindingsFilter Operation</seealso>
        DeleteFindingsFilterResponse EndDeleteFindingsFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInvitations


        /// <summary>
        /// Deletes Amazon Macie membership invitations that were received from specific accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// 
        /// <returns>The response from the DeleteInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        DeleteInvitationsResponse DeleteInvitations(DeleteInvitationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        IAsyncResult BeginDeleteInvitations(DeleteInvitationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInvitations.</param>
        /// 
        /// <returns>Returns a  DeleteInvitationsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        DeleteInvitationsResponse EndDeleteInvitations(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMember


        /// <summary>
        /// Deletes the association between an Amazon Macie administrator account and an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
        /// 
        /// <returns>The response from the DeleteMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        DeleteMemberResponse DeleteMember(DeleteMemberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        IAsyncResult BeginDeleteMember(DeleteMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMember.</param>
        /// 
        /// <returns>Returns a  DeleteMemberResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        DeleteMemberResponse EndDeleteMember(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBuckets


        /// <summary>
        /// Retrieves (queries) statistical data and other information about one or more S3 buckets
        /// that Amazon Macie monitors and analyzes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuckets service method.</param>
        /// 
        /// <returns>The response from the DescribeBuckets service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeBuckets">REST API Reference for DescribeBuckets Operation</seealso>
        DescribeBucketsResponse DescribeBuckets(DescribeBucketsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuckets operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBuckets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeBuckets">REST API Reference for DescribeBuckets Operation</seealso>
        IAsyncResult BeginDescribeBuckets(DescribeBucketsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBuckets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBuckets.</param>
        /// 
        /// <returns>Returns a  DescribeBucketsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeBuckets">REST API Reference for DescribeBuckets Operation</seealso>
        DescribeBucketsResponse EndDescribeBuckets(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClassificationJob


        /// <summary>
        /// Retrieves the status and settings for a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassificationJob service method.</param>
        /// 
        /// <returns>The response from the DescribeClassificationJob service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeClassificationJob">REST API Reference for DescribeClassificationJob Operation</seealso>
        DescribeClassificationJobResponse DescribeClassificationJob(DescribeClassificationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassificationJob operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClassificationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeClassificationJob">REST API Reference for DescribeClassificationJob Operation</seealso>
        IAsyncResult BeginDescribeClassificationJob(DescribeClassificationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClassificationJob.</param>
        /// 
        /// <returns>Returns a  DescribeClassificationJobResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeClassificationJob">REST API Reference for DescribeClassificationJob Operation</seealso>
        DescribeClassificationJobResponse EndDescribeClassificationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeOrganizationConfiguration


        /// <summary>
        /// Retrieves the Amazon Macie configuration settings for an organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        DescribeOrganizationConfigurationResponse DescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfiguration operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrganizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        IAsyncResult BeginDescribeOrganizationConfiguration(DescribeOrganizationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrganizationConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeOrganizationConfigurationResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DescribeOrganizationConfiguration">REST API Reference for DescribeOrganizationConfiguration Operation</seealso>
        DescribeOrganizationConfigurationResponse EndDescribeOrganizationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableMacie


        /// <summary>
        /// Disables Amazon Macie and deletes all settings and resources for a Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMacie service method.</param>
        /// 
        /// <returns>The response from the DisableMacie service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisableMacie">REST API Reference for DisableMacie Operation</seealso>
        DisableMacieResponse DisableMacie(DisableMacieRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableMacie operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableMacie operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableMacie
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisableMacie">REST API Reference for DisableMacie Operation</seealso>
        IAsyncResult BeginDisableMacie(DisableMacieRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableMacie operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableMacie.</param>
        /// 
        /// <returns>Returns a  DisableMacieResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisableMacie">REST API Reference for DisableMacie Operation</seealso>
        DisableMacieResponse EndDisableMacie(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableOrganizationAdminAccount


        /// <summary>
        /// Disables an account as the delegated Amazon Macie administrator account for an organization
        /// in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DisableOrganizationAdminAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        DisableOrganizationAdminAccountResponse DisableOrganizationAdminAccount(DisableOrganizationAdminAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationAdminAccount operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        IAsyncResult BeginDisableOrganizationAdminAccount(DisableOrganizationAdminAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableOrganizationAdminAccount.</param>
        /// 
        /// <returns>Returns a  DisableOrganizationAdminAccountResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisableOrganizationAdminAccount">REST API Reference for DisableOrganizationAdminAccount Operation</seealso>
        DisableOrganizationAdminAccountResponse EndDisableOrganizationAdminAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateFromAdministratorAccount


        /// <summary>
        /// Disassociates a member account from its Amazon Macie administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromAdministratorAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromAdministratorAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        DisassociateFromAdministratorAccountResponse DisassociateFromAdministratorAccount(DisassociateFromAdministratorAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFromAdministratorAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromAdministratorAccount operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFromAdministratorAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        IAsyncResult BeginDisassociateFromAdministratorAccount(DisassociateFromAdministratorAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFromAdministratorAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFromAdministratorAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateFromAdministratorAccountResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateFromAdministratorAccount">REST API Reference for DisassociateFromAdministratorAccount Operation</seealso>
        DisassociateFromAdministratorAccountResponse EndDisassociateFromAdministratorAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateFromMasterAccount


        /// <summary>
        /// (Deprecated) Disassociates a member account from its Amazon Macie administrator account.
        /// This operation has been replaced by the <link  linkend="DisassociateFromAdministratorAccount">DisassociateFromAdministratorAccount</link>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromMasterAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        DisassociateFromMasterAccountResponse DisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFromMasterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        IAsyncResult BeginDisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFromMasterAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateFromMasterAccountResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        DisassociateFromMasterAccountResponse EndDisassociateFromMasterAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateMember


        /// <summary>
        /// Disassociates an Amazon Macie administrator account from a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMember service method.</param>
        /// 
        /// <returns>The response from the DisassociateMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateMember">REST API Reference for DisassociateMember Operation</seealso>
        DisassociateMemberResponse DisassociateMember(DisassociateMemberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMember operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateMember">REST API Reference for DisassociateMember Operation</seealso>
        IAsyncResult BeginDisassociateMember(DisassociateMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMember.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/DisassociateMember">REST API Reference for DisassociateMember Operation</seealso>
        DisassociateMemberResponse EndDisassociateMember(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableMacie


        /// <summary>
        /// Enables Amazon Macie and specifies the configuration settings for a Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMacie service method.</param>
        /// 
        /// <returns>The response from the EnableMacie service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/EnableMacie">REST API Reference for EnableMacie Operation</seealso>
        EnableMacieResponse EnableMacie(EnableMacieRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableMacie operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMacie operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableMacie
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/EnableMacie">REST API Reference for EnableMacie Operation</seealso>
        IAsyncResult BeginEnableMacie(EnableMacieRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableMacie operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableMacie.</param>
        /// 
        /// <returns>Returns a  EnableMacieResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/EnableMacie">REST API Reference for EnableMacie Operation</seealso>
        EnableMacieResponse EndEnableMacie(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableOrganizationAdminAccount


        /// <summary>
        /// Designates an account as the delegated Amazon Macie administrator account for an organization
        /// in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the EnableOrganizationAdminAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        EnableOrganizationAdminAccountResponse EnableOrganizationAdminAccount(EnableOrganizationAdminAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationAdminAccount operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        IAsyncResult BeginEnableOrganizationAdminAccount(EnableOrganizationAdminAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableOrganizationAdminAccount.</param>
        /// 
        /// <returns>Returns a  EnableOrganizationAdminAccountResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/EnableOrganizationAdminAccount">REST API Reference for EnableOrganizationAdminAccount Operation</seealso>
        EnableOrganizationAdminAccountResponse EndEnableOrganizationAdminAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAdministratorAccount


        /// <summary>
        /// Retrieves information about the Amazon Macie administrator account for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdministratorAccount service method.</param>
        /// 
        /// <returns>The response from the GetAdministratorAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        GetAdministratorAccountResponse GetAdministratorAccount(GetAdministratorAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAdministratorAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAdministratorAccount operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAdministratorAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        IAsyncResult BeginGetAdministratorAccount(GetAdministratorAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAdministratorAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAdministratorAccount.</param>
        /// 
        /// <returns>Returns a  GetAdministratorAccountResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAdministratorAccount">REST API Reference for GetAdministratorAccount Operation</seealso>
        GetAdministratorAccountResponse EndGetAdministratorAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAllowList


        /// <summary>
        /// Retrieves the settings and status of an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAllowList service method.</param>
        /// 
        /// <returns>The response from the GetAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAllowList">REST API Reference for GetAllowList Operation</seealso>
        GetAllowListResponse GetAllowList(GetAllowListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAllowList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAllowList operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAllowList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAllowList">REST API Reference for GetAllowList Operation</seealso>
        IAsyncResult BeginGetAllowList(GetAllowListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAllowList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAllowList.</param>
        /// 
        /// <returns>Returns a  GetAllowListResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAllowList">REST API Reference for GetAllowList Operation</seealso>
        GetAllowListResponse EndGetAllowList(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAutomatedDiscoveryConfiguration


        /// <summary>
        /// Retrieves the configuration settings and status of automated sensitive data discovery
        /// for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedDiscoveryConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedDiscoveryConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAutomatedDiscoveryConfiguration">REST API Reference for GetAutomatedDiscoveryConfiguration Operation</seealso>
        GetAutomatedDiscoveryConfigurationResponse GetAutomatedDiscoveryConfiguration(GetAutomatedDiscoveryConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutomatedDiscoveryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedDiscoveryConfiguration operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutomatedDiscoveryConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAutomatedDiscoveryConfiguration">REST API Reference for GetAutomatedDiscoveryConfiguration Operation</seealso>
        IAsyncResult BeginGetAutomatedDiscoveryConfiguration(GetAutomatedDiscoveryConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutomatedDiscoveryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutomatedDiscoveryConfiguration.</param>
        /// 
        /// <returns>Returns a  GetAutomatedDiscoveryConfigurationResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetAutomatedDiscoveryConfiguration">REST API Reference for GetAutomatedDiscoveryConfiguration Operation</seealso>
        GetAutomatedDiscoveryConfigurationResponse EndGetAutomatedDiscoveryConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBucketStatistics


        /// <summary>
        /// Retrieves (queries) aggregated statistical data about all the S3 buckets that Amazon
        /// Macie monitors and analyzes for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketStatistics service method.</param>
        /// 
        /// <returns>The response from the GetBucketStatistics service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetBucketStatistics">REST API Reference for GetBucketStatistics Operation</seealso>
        GetBucketStatisticsResponse GetBucketStatistics(GetBucketStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketStatistics operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetBucketStatistics">REST API Reference for GetBucketStatistics Operation</seealso>
        IAsyncResult BeginGetBucketStatistics(GetBucketStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketStatistics.</param>
        /// 
        /// <returns>Returns a  GetBucketStatisticsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetBucketStatistics">REST API Reference for GetBucketStatistics Operation</seealso>
        GetBucketStatisticsResponse EndGetBucketStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetClassificationExportConfiguration


        /// <summary>
        /// Retrieves the configuration settings for storing data classification results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassificationExportConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetClassificationExportConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetClassificationExportConfiguration">REST API Reference for GetClassificationExportConfiguration Operation</seealso>
        GetClassificationExportConfigurationResponse GetClassificationExportConfiguration(GetClassificationExportConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetClassificationExportConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClassificationExportConfiguration operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClassificationExportConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetClassificationExportConfiguration">REST API Reference for GetClassificationExportConfiguration Operation</seealso>
        IAsyncResult BeginGetClassificationExportConfiguration(GetClassificationExportConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetClassificationExportConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClassificationExportConfiguration.</param>
        /// 
        /// <returns>Returns a  GetClassificationExportConfigurationResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetClassificationExportConfiguration">REST API Reference for GetClassificationExportConfiguration Operation</seealso>
        GetClassificationExportConfigurationResponse EndGetClassificationExportConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetClassificationScope


        /// <summary>
        /// Retrieves the classification scope settings for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassificationScope service method.</param>
        /// 
        /// <returns>The response from the GetClassificationScope service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetClassificationScope">REST API Reference for GetClassificationScope Operation</seealso>
        GetClassificationScopeResponse GetClassificationScope(GetClassificationScopeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetClassificationScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClassificationScope operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClassificationScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetClassificationScope">REST API Reference for GetClassificationScope Operation</seealso>
        IAsyncResult BeginGetClassificationScope(GetClassificationScopeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetClassificationScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClassificationScope.</param>
        /// 
        /// <returns>Returns a  GetClassificationScopeResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetClassificationScope">REST API Reference for GetClassificationScope Operation</seealso>
        GetClassificationScopeResponse EndGetClassificationScope(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCustomDataIdentifier


        /// <summary>
        /// Retrieves the criteria and other settings for a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomDataIdentifier service method.</param>
        /// 
        /// <returns>The response from the GetCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetCustomDataIdentifier">REST API Reference for GetCustomDataIdentifier Operation</seealso>
        GetCustomDataIdentifierResponse GetCustomDataIdentifier(GetCustomDataIdentifierRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCustomDataIdentifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCustomDataIdentifier operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCustomDataIdentifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetCustomDataIdentifier">REST API Reference for GetCustomDataIdentifier Operation</seealso>
        IAsyncResult BeginGetCustomDataIdentifier(GetCustomDataIdentifierRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCustomDataIdentifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCustomDataIdentifier.</param>
        /// 
        /// <returns>Returns a  GetCustomDataIdentifierResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetCustomDataIdentifier">REST API Reference for GetCustomDataIdentifier Operation</seealso>
        GetCustomDataIdentifierResponse EndGetCustomDataIdentifier(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFindings


        /// <summary>
        /// Retrieves the details of one or more findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindings">REST API Reference for GetFindings Operation</seealso>
        GetFindingsResponse GetFindings(GetFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindings operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindings">REST API Reference for GetFindings Operation</seealso>
        IAsyncResult BeginGetFindings(GetFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindings.</param>
        /// 
        /// <returns>Returns a  GetFindingsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindings">REST API Reference for GetFindings Operation</seealso>
        GetFindingsResponse EndGetFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFindingsFilter


        /// <summary>
        /// Retrieves the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsFilter service method.</param>
        /// 
        /// <returns>The response from the GetFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingsFilter">REST API Reference for GetFindingsFilter Operation</seealso>
        GetFindingsFilterResponse GetFindingsFilter(GetFindingsFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindingsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsFilter operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindingsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingsFilter">REST API Reference for GetFindingsFilter Operation</seealso>
        IAsyncResult BeginGetFindingsFilter(GetFindingsFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindingsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindingsFilter.</param>
        /// 
        /// <returns>Returns a  GetFindingsFilterResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingsFilter">REST API Reference for GetFindingsFilter Operation</seealso>
        GetFindingsFilterResponse EndGetFindingsFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFindingsPublicationConfiguration


        /// <summary>
        /// Retrieves the configuration settings for publishing findings to Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsPublicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetFindingsPublicationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingsPublicationConfiguration">REST API Reference for GetFindingsPublicationConfiguration Operation</seealso>
        GetFindingsPublicationConfigurationResponse GetFindingsPublicationConfiguration(GetFindingsPublicationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindingsPublicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsPublicationConfiguration operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindingsPublicationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingsPublicationConfiguration">REST API Reference for GetFindingsPublicationConfiguration Operation</seealso>
        IAsyncResult BeginGetFindingsPublicationConfiguration(GetFindingsPublicationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindingsPublicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindingsPublicationConfiguration.</param>
        /// 
        /// <returns>Returns a  GetFindingsPublicationConfigurationResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingsPublicationConfiguration">REST API Reference for GetFindingsPublicationConfiguration Operation</seealso>
        GetFindingsPublicationConfigurationResponse EndGetFindingsPublicationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFindingStatistics


        /// <summary>
        /// Retrieves (queries) aggregated statistical data about findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingStatistics service method.</param>
        /// 
        /// <returns>The response from the GetFindingStatistics service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingStatistics">REST API Reference for GetFindingStatistics Operation</seealso>
        GetFindingStatisticsResponse GetFindingStatistics(GetFindingStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindingStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindingStatistics operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindingStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingStatistics">REST API Reference for GetFindingStatistics Operation</seealso>
        IAsyncResult BeginGetFindingStatistics(GetFindingStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindingStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindingStatistics.</param>
        /// 
        /// <returns>Returns a  GetFindingStatisticsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetFindingStatistics">REST API Reference for GetFindingStatistics Operation</seealso>
        GetFindingStatisticsResponse EndGetFindingStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInvitationsCount


        /// <summary>
        /// Retrieves the count of Amazon Macie membership invitations that were received by an
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount service method.</param>
        /// 
        /// <returns>The response from the GetInvitationsCount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        GetInvitationsCountResponse GetInvitationsCount(GetInvitationsCountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvitationsCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvitationsCount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        IAsyncResult BeginGetInvitationsCount(GetInvitationsCountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvitationsCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvitationsCount.</param>
        /// 
        /// <returns>Returns a  GetInvitationsCountResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        GetInvitationsCountResponse EndGetInvitationsCount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMacieSession


        /// <summary>
        /// Retrieves the status and configuration settings for an Amazon Macie account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMacieSession service method.</param>
        /// 
        /// <returns>The response from the GetMacieSession service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMacieSession">REST API Reference for GetMacieSession Operation</seealso>
        GetMacieSessionResponse GetMacieSession(GetMacieSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMacieSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMacieSession operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMacieSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMacieSession">REST API Reference for GetMacieSession Operation</seealso>
        IAsyncResult BeginGetMacieSession(GetMacieSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMacieSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMacieSession.</param>
        /// 
        /// <returns>Returns a  GetMacieSessionResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMacieSession">REST API Reference for GetMacieSession Operation</seealso>
        GetMacieSessionResponse EndGetMacieSession(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMasterAccount


        /// <summary>
        /// (Deprecated) Retrieves information about the Amazon Macie administrator account for
        /// an account. This operation has been replaced by the <link  linkend="GetAdministratorAccount">GetAdministratorAccount</link>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// 
        /// <returns>The response from the GetMasterAccount service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        GetMasterAccountResponse GetMasterAccount(GetMasterAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMasterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        IAsyncResult BeginGetMasterAccount(GetMasterAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMasterAccount.</param>
        /// 
        /// <returns>Returns a  GetMasterAccountResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        GetMasterAccountResponse EndGetMasterAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMember


        /// <summary>
        /// Retrieves information about an account that's associated with an Amazon Macie administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMember service method.</param>
        /// 
        /// <returns>The response from the GetMember service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMember">REST API Reference for GetMember Operation</seealso>
        GetMemberResponse GetMember(GetMemberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMember operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMember">REST API Reference for GetMember Operation</seealso>
        IAsyncResult BeginGetMember(GetMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMember.</param>
        /// 
        /// <returns>Returns a  GetMemberResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetMember">REST API Reference for GetMember Operation</seealso>
        GetMemberResponse EndGetMember(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourceProfile


        /// <summary>
        /// Retrieves (queries) sensitive data discovery statistics and the sensitivity score
        /// for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceProfile service method.</param>
        /// 
        /// <returns>The response from the GetResourceProfile service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetResourceProfile">REST API Reference for GetResourceProfile Operation</seealso>
        GetResourceProfileResponse GetResourceProfile(GetResourceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceProfile operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetResourceProfile">REST API Reference for GetResourceProfile Operation</seealso>
        IAsyncResult BeginGetResourceProfile(GetResourceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceProfile.</param>
        /// 
        /// <returns>Returns a  GetResourceProfileResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetResourceProfile">REST API Reference for GetResourceProfile Operation</seealso>
        GetResourceProfileResponse EndGetResourceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRevealConfiguration


        /// <summary>
        /// Retrieves the status and configuration settings for retrieving occurrences of sensitive
        /// data reported by findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevealConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetRevealConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetRevealConfiguration">REST API Reference for GetRevealConfiguration Operation</seealso>
        GetRevealConfigurationResponse GetRevealConfiguration(GetRevealConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRevealConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRevealConfiguration operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRevealConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetRevealConfiguration">REST API Reference for GetRevealConfiguration Operation</seealso>
        IAsyncResult BeginGetRevealConfiguration(GetRevealConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRevealConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRevealConfiguration.</param>
        /// 
        /// <returns>Returns a  GetRevealConfigurationResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetRevealConfiguration">REST API Reference for GetRevealConfiguration Operation</seealso>
        GetRevealConfigurationResponse EndGetRevealConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSensitiveDataOccurrences


        /// <summary>
        /// Retrieves occurrences of sensitive data reported by a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitiveDataOccurrences service method.</param>
        /// 
        /// <returns>The response from the GetSensitiveDataOccurrences service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.UnprocessableEntityException">
        /// Provides information about an error that occurred due to an unprocessable entity.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrences">REST API Reference for GetSensitiveDataOccurrences Operation</seealso>
        GetSensitiveDataOccurrencesResponse GetSensitiveDataOccurrences(GetSensitiveDataOccurrencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSensitiveDataOccurrences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSensitiveDataOccurrences operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSensitiveDataOccurrences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrences">REST API Reference for GetSensitiveDataOccurrences Operation</seealso>
        IAsyncResult BeginGetSensitiveDataOccurrences(GetSensitiveDataOccurrencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSensitiveDataOccurrences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSensitiveDataOccurrences.</param>
        /// 
        /// <returns>Returns a  GetSensitiveDataOccurrencesResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrences">REST API Reference for GetSensitiveDataOccurrences Operation</seealso>
        GetSensitiveDataOccurrencesResponse EndGetSensitiveDataOccurrences(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSensitiveDataOccurrencesAvailability


        /// <summary>
        /// Checks whether occurrences of sensitive data can be retrieved for a finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitiveDataOccurrencesAvailability service method.</param>
        /// 
        /// <returns>The response from the GetSensitiveDataOccurrencesAvailability service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrencesAvailability">REST API Reference for GetSensitiveDataOccurrencesAvailability Operation</seealso>
        GetSensitiveDataOccurrencesAvailabilityResponse GetSensitiveDataOccurrencesAvailability(GetSensitiveDataOccurrencesAvailabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSensitiveDataOccurrencesAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSensitiveDataOccurrencesAvailability operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSensitiveDataOccurrencesAvailability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrencesAvailability">REST API Reference for GetSensitiveDataOccurrencesAvailability Operation</seealso>
        IAsyncResult BeginGetSensitiveDataOccurrencesAvailability(GetSensitiveDataOccurrencesAvailabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSensitiveDataOccurrencesAvailability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSensitiveDataOccurrencesAvailability.</param>
        /// 
        /// <returns>Returns a  GetSensitiveDataOccurrencesAvailabilityResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitiveDataOccurrencesAvailability">REST API Reference for GetSensitiveDataOccurrencesAvailability Operation</seealso>
        GetSensitiveDataOccurrencesAvailabilityResponse EndGetSensitiveDataOccurrencesAvailability(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSensitivityInspectionTemplate


        /// <summary>
        /// Retrieves the settings for the sensitivity inspection template for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSensitivityInspectionTemplate service method.</param>
        /// 
        /// <returns>The response from the GetSensitivityInspectionTemplate service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitivityInspectionTemplate">REST API Reference for GetSensitivityInspectionTemplate Operation</seealso>
        GetSensitivityInspectionTemplateResponse GetSensitivityInspectionTemplate(GetSensitivityInspectionTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSensitivityInspectionTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSensitivityInspectionTemplate operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSensitivityInspectionTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitivityInspectionTemplate">REST API Reference for GetSensitivityInspectionTemplate Operation</seealso>
        IAsyncResult BeginGetSensitivityInspectionTemplate(GetSensitivityInspectionTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSensitivityInspectionTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSensitivityInspectionTemplate.</param>
        /// 
        /// <returns>Returns a  GetSensitivityInspectionTemplateResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetSensitivityInspectionTemplate">REST API Reference for GetSensitivityInspectionTemplate Operation</seealso>
        GetSensitivityInspectionTemplateResponse EndGetSensitivityInspectionTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUsageStatistics


        /// <summary>
        /// Retrieves (queries) quotas and aggregated usage data for one or more accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageStatistics service method.</param>
        /// 
        /// <returns>The response from the GetUsageStatistics service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetUsageStatistics">REST API Reference for GetUsageStatistics Operation</seealso>
        GetUsageStatisticsResponse GetUsageStatistics(GetUsageStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsageStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsageStatistics operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsageStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetUsageStatistics">REST API Reference for GetUsageStatistics Operation</seealso>
        IAsyncResult BeginGetUsageStatistics(GetUsageStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsageStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsageStatistics.</param>
        /// 
        /// <returns>Returns a  GetUsageStatisticsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetUsageStatistics">REST API Reference for GetUsageStatistics Operation</seealso>
        GetUsageStatisticsResponse EndGetUsageStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUsageTotals


        /// <summary>
        /// Retrieves (queries) aggregated usage data for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageTotals service method.</param>
        /// 
        /// <returns>The response from the GetUsageTotals service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetUsageTotals">REST API Reference for GetUsageTotals Operation</seealso>
        GetUsageTotalsResponse GetUsageTotals(GetUsageTotalsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsageTotals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsageTotals operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsageTotals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetUsageTotals">REST API Reference for GetUsageTotals Operation</seealso>
        IAsyncResult BeginGetUsageTotals(GetUsageTotalsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsageTotals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsageTotals.</param>
        /// 
        /// <returns>Returns a  GetUsageTotalsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/GetUsageTotals">REST API Reference for GetUsageTotals Operation</seealso>
        GetUsageTotalsResponse EndGetUsageTotals(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAllowLists


        /// <summary>
        /// Retrieves a subset of information about all the allow lists for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAllowLists service method.</param>
        /// 
        /// <returns>The response from the ListAllowLists service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListAllowLists">REST API Reference for ListAllowLists Operation</seealso>
        ListAllowListsResponse ListAllowLists(ListAllowListsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAllowLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAllowLists operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAllowLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListAllowLists">REST API Reference for ListAllowLists Operation</seealso>
        IAsyncResult BeginListAllowLists(ListAllowListsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAllowLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAllowLists.</param>
        /// 
        /// <returns>Returns a  ListAllowListsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListAllowLists">REST API Reference for ListAllowLists Operation</seealso>
        ListAllowListsResponse EndListAllowLists(IAsyncResult asyncResult);

        #endregion
        
        #region  ListClassificationJobs


        /// <summary>
        /// Retrieves a subset of information about one or more classification jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClassificationJobs service method.</param>
        /// 
        /// <returns>The response from the ListClassificationJobs service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListClassificationJobs">REST API Reference for ListClassificationJobs Operation</seealso>
        ListClassificationJobsResponse ListClassificationJobs(ListClassificationJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListClassificationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClassificationJobs operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClassificationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListClassificationJobs">REST API Reference for ListClassificationJobs Operation</seealso>
        IAsyncResult BeginListClassificationJobs(ListClassificationJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClassificationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClassificationJobs.</param>
        /// 
        /// <returns>Returns a  ListClassificationJobsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListClassificationJobs">REST API Reference for ListClassificationJobs Operation</seealso>
        ListClassificationJobsResponse EndListClassificationJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListClassificationScopes


        /// <summary>
        /// Retrieves a subset of information about the classification scope for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClassificationScopes service method.</param>
        /// 
        /// <returns>The response from the ListClassificationScopes service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListClassificationScopes">REST API Reference for ListClassificationScopes Operation</seealso>
        ListClassificationScopesResponse ListClassificationScopes(ListClassificationScopesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListClassificationScopes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClassificationScopes operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClassificationScopes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListClassificationScopes">REST API Reference for ListClassificationScopes Operation</seealso>
        IAsyncResult BeginListClassificationScopes(ListClassificationScopesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClassificationScopes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClassificationScopes.</param>
        /// 
        /// <returns>Returns a  ListClassificationScopesResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListClassificationScopes">REST API Reference for ListClassificationScopes Operation</seealso>
        ListClassificationScopesResponse EndListClassificationScopes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCustomDataIdentifiers


        /// <summary>
        /// Retrieves a subset of information about all the custom data identifiers for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomDataIdentifiers service method.</param>
        /// 
        /// <returns>The response from the ListCustomDataIdentifiers service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListCustomDataIdentifiers">REST API Reference for ListCustomDataIdentifiers Operation</seealso>
        ListCustomDataIdentifiersResponse ListCustomDataIdentifiers(ListCustomDataIdentifiersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomDataIdentifiers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomDataIdentifiers operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomDataIdentifiers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListCustomDataIdentifiers">REST API Reference for ListCustomDataIdentifiers Operation</seealso>
        IAsyncResult BeginListCustomDataIdentifiers(ListCustomDataIdentifiersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomDataIdentifiers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomDataIdentifiers.</param>
        /// 
        /// <returns>Returns a  ListCustomDataIdentifiersResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListCustomDataIdentifiers">REST API Reference for ListCustomDataIdentifiers Operation</seealso>
        ListCustomDataIdentifiersResponse EndListCustomDataIdentifiers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFindings


        /// <summary>
        /// Retrieves a subset of information about one or more findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListFindings">REST API Reference for ListFindings Operation</seealso>
        ListFindingsResponse ListFindings(ListFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindings operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListFindings">REST API Reference for ListFindings Operation</seealso>
        IAsyncResult BeginListFindings(ListFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindings.</param>
        /// 
        /// <returns>Returns a  ListFindingsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListFindings">REST API Reference for ListFindings Operation</seealso>
        ListFindingsResponse EndListFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFindingsFilters


        /// <summary>
        /// Retrieves a subset of information about all the findings filters for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsFilters service method.</param>
        /// 
        /// <returns>The response from the ListFindingsFilters service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListFindingsFilters">REST API Reference for ListFindingsFilters Operation</seealso>
        ListFindingsFiltersResponse ListFindingsFilters(ListFindingsFiltersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFindingsFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsFilters operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFindingsFilters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListFindingsFilters">REST API Reference for ListFindingsFilters Operation</seealso>
        IAsyncResult BeginListFindingsFilters(ListFindingsFiltersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFindingsFilters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFindingsFilters.</param>
        /// 
        /// <returns>Returns a  ListFindingsFiltersResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListFindingsFilters">REST API Reference for ListFindingsFilters Operation</seealso>
        ListFindingsFiltersResponse EndListFindingsFilters(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInvitations


        /// <summary>
        /// Retrieves information about the Amazon Macie membership invitations that were received
        /// by an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        ListInvitationsResponse ListInvitations(ListInvitationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        IAsyncResult BeginListInvitations(ListInvitationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvitations.</param>
        /// 
        /// <returns>Returns a  ListInvitationsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        ListInvitationsResponse EndListInvitations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListManagedDataIdentifiers


        /// <summary>
        /// Retrieves information about all the managed data identifiers that Amazon Macie currently
        /// provides.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedDataIdentifiers service method.</param>
        /// 
        /// <returns>The response from the ListManagedDataIdentifiers service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListManagedDataIdentifiers">REST API Reference for ListManagedDataIdentifiers Operation</seealso>
        ListManagedDataIdentifiersResponse ListManagedDataIdentifiers(ListManagedDataIdentifiersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedDataIdentifiers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedDataIdentifiers operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedDataIdentifiers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListManagedDataIdentifiers">REST API Reference for ListManagedDataIdentifiers Operation</seealso>
        IAsyncResult BeginListManagedDataIdentifiers(ListManagedDataIdentifiersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedDataIdentifiers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedDataIdentifiers.</param>
        /// 
        /// <returns>Returns a  ListManagedDataIdentifiersResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListManagedDataIdentifiers">REST API Reference for ListManagedDataIdentifiers Operation</seealso>
        ListManagedDataIdentifiersResponse EndListManagedDataIdentifiers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMembers


        /// <summary>
        /// Retrieves information about the accounts that are associated with an Amazon Macie
        /// administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListMembers">REST API Reference for ListMembers Operation</seealso>
        ListMembersResponse ListMembers(ListMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListMembers">REST API Reference for ListMembers Operation</seealso>
        IAsyncResult BeginListMembers(ListMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMembers.</param>
        /// 
        /// <returns>Returns a  ListMembersResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListMembers">REST API Reference for ListMembers Operation</seealso>
        ListMembersResponse EndListMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOrganizationAdminAccounts


        /// <summary>
        /// Retrieves information about the delegated Amazon Macie administrator account for an
        /// organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationAdminAccounts service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        ListOrganizationAdminAccountsResponse ListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationAdminAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationAdminAccounts operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationAdminAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        IAsyncResult BeginListOrganizationAdminAccounts(ListOrganizationAdminAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationAdminAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationAdminAccounts.</param>
        /// 
        /// <returns>Returns a  ListOrganizationAdminAccountsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListOrganizationAdminAccounts">REST API Reference for ListOrganizationAdminAccounts Operation</seealso>
        ListOrganizationAdminAccountsResponse EndListOrganizationAdminAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceProfileArtifacts


        /// <summary>
        /// Retrieves information about objects that were selected from an S3 bucket for automated
        /// sensitive data discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceProfileArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListResourceProfileArtifacts service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileArtifacts">REST API Reference for ListResourceProfileArtifacts Operation</seealso>
        ListResourceProfileArtifactsResponse ListResourceProfileArtifacts(ListResourceProfileArtifactsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceProfileArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceProfileArtifacts operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceProfileArtifacts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileArtifacts">REST API Reference for ListResourceProfileArtifacts Operation</seealso>
        IAsyncResult BeginListResourceProfileArtifacts(ListResourceProfileArtifactsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceProfileArtifacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceProfileArtifacts.</param>
        /// 
        /// <returns>Returns a  ListResourceProfileArtifactsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileArtifacts">REST API Reference for ListResourceProfileArtifacts Operation</seealso>
        ListResourceProfileArtifactsResponse EndListResourceProfileArtifacts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceProfileDetections


        /// <summary>
        /// Retrieves information about the types and amount of sensitive data that Amazon Macie
        /// found in an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceProfileDetections service method.</param>
        /// 
        /// <returns>The response from the ListResourceProfileDetections service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileDetections">REST API Reference for ListResourceProfileDetections Operation</seealso>
        ListResourceProfileDetectionsResponse ListResourceProfileDetections(ListResourceProfileDetectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceProfileDetections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceProfileDetections operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceProfileDetections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileDetections">REST API Reference for ListResourceProfileDetections Operation</seealso>
        IAsyncResult BeginListResourceProfileDetections(ListResourceProfileDetectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceProfileDetections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceProfileDetections.</param>
        /// 
        /// <returns>Returns a  ListResourceProfileDetectionsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListResourceProfileDetections">REST API Reference for ListResourceProfileDetections Operation</seealso>
        ListResourceProfileDetectionsResponse EndListResourceProfileDetections(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSensitivityInspectionTemplates


        /// <summary>
        /// Retrieves a subset of information about the sensitivity inspection template for an
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSensitivityInspectionTemplates service method.</param>
        /// 
        /// <returns>The response from the ListSensitivityInspectionTemplates service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListSensitivityInspectionTemplates">REST API Reference for ListSensitivityInspectionTemplates Operation</seealso>
        ListSensitivityInspectionTemplatesResponse ListSensitivityInspectionTemplates(ListSensitivityInspectionTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSensitivityInspectionTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSensitivityInspectionTemplates operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSensitivityInspectionTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListSensitivityInspectionTemplates">REST API Reference for ListSensitivityInspectionTemplates Operation</seealso>
        IAsyncResult BeginListSensitivityInspectionTemplates(ListSensitivityInspectionTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSensitivityInspectionTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSensitivityInspectionTemplates.</param>
        /// 
        /// <returns>Returns a  ListSensitivityInspectionTemplatesResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListSensitivityInspectionTemplates">REST API Reference for ListSensitivityInspectionTemplates Operation</seealso>
        ListSensitivityInspectionTemplatesResponse EndListSensitivityInspectionTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves the tags (keys and values) that are associated with an Amazon Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutClassificationExportConfiguration


        /// <summary>
        /// Creates or updates the configuration settings for storing data classification results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutClassificationExportConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutClassificationExportConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/PutClassificationExportConfiguration">REST API Reference for PutClassificationExportConfiguration Operation</seealso>
        PutClassificationExportConfigurationResponse PutClassificationExportConfiguration(PutClassificationExportConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutClassificationExportConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutClassificationExportConfiguration operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutClassificationExportConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/PutClassificationExportConfiguration">REST API Reference for PutClassificationExportConfiguration Operation</seealso>
        IAsyncResult BeginPutClassificationExportConfiguration(PutClassificationExportConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutClassificationExportConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutClassificationExportConfiguration.</param>
        /// 
        /// <returns>Returns a  PutClassificationExportConfigurationResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/PutClassificationExportConfiguration">REST API Reference for PutClassificationExportConfiguration Operation</seealso>
        PutClassificationExportConfigurationResponse EndPutClassificationExportConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutFindingsPublicationConfiguration


        /// <summary>
        /// Updates the configuration settings for publishing findings to Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFindingsPublicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutFindingsPublicationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/PutFindingsPublicationConfiguration">REST API Reference for PutFindingsPublicationConfiguration Operation</seealso>
        PutFindingsPublicationConfigurationResponse PutFindingsPublicationConfiguration(PutFindingsPublicationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutFindingsPublicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFindingsPublicationConfiguration operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFindingsPublicationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/PutFindingsPublicationConfiguration">REST API Reference for PutFindingsPublicationConfiguration Operation</seealso>
        IAsyncResult BeginPutFindingsPublicationConfiguration(PutFindingsPublicationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutFindingsPublicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFindingsPublicationConfiguration.</param>
        /// 
        /// <returns>Returns a  PutFindingsPublicationConfigurationResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/PutFindingsPublicationConfiguration">REST API Reference for PutFindingsPublicationConfiguration Operation</seealso>
        PutFindingsPublicationConfigurationResponse EndPutFindingsPublicationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchResources


        /// <summary>
        /// Retrieves (queries) statistical data and other information about Amazon Web Services
        /// resources that Amazon Macie monitors and analyzes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchResources service method.</param>
        /// 
        /// <returns>The response from the SearchResources service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/SearchResources">REST API Reference for SearchResources Operation</seealso>
        SearchResourcesResponse SearchResources(SearchResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchResources operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/SearchResources">REST API Reference for SearchResources Operation</seealso>
        IAsyncResult BeginSearchResources(SearchResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchResources.</param>
        /// 
        /// <returns>Returns a  SearchResourcesResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/SearchResources">REST API Reference for SearchResources Operation</seealso>
        SearchResourcesResponse EndSearchResources(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates one or more tags (keys and values) that are associated with an Amazon
        /// Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TestCustomDataIdentifier


        /// <summary>
        /// Tests a custom data identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestCustomDataIdentifier service method.</param>
        /// 
        /// <returns>The response from the TestCustomDataIdentifier service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TestCustomDataIdentifier">REST API Reference for TestCustomDataIdentifier Operation</seealso>
        TestCustomDataIdentifierResponse TestCustomDataIdentifier(TestCustomDataIdentifierRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestCustomDataIdentifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestCustomDataIdentifier operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestCustomDataIdentifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TestCustomDataIdentifier">REST API Reference for TestCustomDataIdentifier Operation</seealso>
        IAsyncResult BeginTestCustomDataIdentifier(TestCustomDataIdentifierRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestCustomDataIdentifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestCustomDataIdentifier.</param>
        /// 
        /// <returns>Returns a  TestCustomDataIdentifierResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/TestCustomDataIdentifier">REST API Reference for TestCustomDataIdentifier Operation</seealso>
        TestCustomDataIdentifierResponse EndTestCustomDataIdentifier(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags (keys and values) from an Amazon Macie resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAllowList


        /// <summary>
        /// Updates the settings for an allow list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAllowList service method.</param>
        /// 
        /// <returns>The response from the UpdateAllowList service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAllowList">REST API Reference for UpdateAllowList Operation</seealso>
        UpdateAllowListResponse UpdateAllowList(UpdateAllowListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAllowList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAllowList operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAllowList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAllowList">REST API Reference for UpdateAllowList Operation</seealso>
        IAsyncResult BeginUpdateAllowList(UpdateAllowListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAllowList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAllowList.</param>
        /// 
        /// <returns>Returns a  UpdateAllowListResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAllowList">REST API Reference for UpdateAllowList Operation</seealso>
        UpdateAllowListResponse EndUpdateAllowList(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAutomatedDiscoveryConfiguration


        /// <summary>
        /// Enables or disables automated sensitive data discovery for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedDiscoveryConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateAutomatedDiscoveryConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAutomatedDiscoveryConfiguration">REST API Reference for UpdateAutomatedDiscoveryConfiguration Operation</seealso>
        UpdateAutomatedDiscoveryConfigurationResponse UpdateAutomatedDiscoveryConfiguration(UpdateAutomatedDiscoveryConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutomatedDiscoveryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedDiscoveryConfiguration operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAutomatedDiscoveryConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAutomatedDiscoveryConfiguration">REST API Reference for UpdateAutomatedDiscoveryConfiguration Operation</seealso>
        IAsyncResult BeginUpdateAutomatedDiscoveryConfiguration(UpdateAutomatedDiscoveryConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAutomatedDiscoveryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAutomatedDiscoveryConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateAutomatedDiscoveryConfigurationResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateAutomatedDiscoveryConfiguration">REST API Reference for UpdateAutomatedDiscoveryConfiguration Operation</seealso>
        UpdateAutomatedDiscoveryConfigurationResponse EndUpdateAutomatedDiscoveryConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateClassificationJob


        /// <summary>
        /// Changes the status of a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassificationJob service method.</param>
        /// 
        /// <returns>The response from the UpdateClassificationJob service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateClassificationJob">REST API Reference for UpdateClassificationJob Operation</seealso>
        UpdateClassificationJobResponse UpdateClassificationJob(UpdateClassificationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassificationJob operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClassificationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateClassificationJob">REST API Reference for UpdateClassificationJob Operation</seealso>
        IAsyncResult BeginUpdateClassificationJob(UpdateClassificationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClassificationJob.</param>
        /// 
        /// <returns>Returns a  UpdateClassificationJobResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateClassificationJob">REST API Reference for UpdateClassificationJob Operation</seealso>
        UpdateClassificationJobResponse EndUpdateClassificationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateClassificationScope


        /// <summary>
        /// Updates the classification scope settings for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassificationScope service method.</param>
        /// 
        /// <returns>The response from the UpdateClassificationScope service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateClassificationScope">REST API Reference for UpdateClassificationScope Operation</seealso>
        UpdateClassificationScopeResponse UpdateClassificationScope(UpdateClassificationScopeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClassificationScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassificationScope operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClassificationScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateClassificationScope">REST API Reference for UpdateClassificationScope Operation</seealso>
        IAsyncResult BeginUpdateClassificationScope(UpdateClassificationScopeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClassificationScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClassificationScope.</param>
        /// 
        /// <returns>Returns a  UpdateClassificationScopeResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateClassificationScope">REST API Reference for UpdateClassificationScope Operation</seealso>
        UpdateClassificationScopeResponse EndUpdateClassificationScope(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFindingsFilter


        /// <summary>
        /// Updates the criteria and other settings for a findings filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateFindingsFilter service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateFindingsFilter">REST API Reference for UpdateFindingsFilter Operation</seealso>
        UpdateFindingsFilterResponse UpdateFindingsFilter(UpdateFindingsFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFindingsFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFilter operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFindingsFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateFindingsFilter">REST API Reference for UpdateFindingsFilter Operation</seealso>
        IAsyncResult BeginUpdateFindingsFilter(UpdateFindingsFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFindingsFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFindingsFilter.</param>
        /// 
        /// <returns>Returns a  UpdateFindingsFilterResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateFindingsFilter">REST API Reference for UpdateFindingsFilter Operation</seealso>
        UpdateFindingsFilterResponse EndUpdateFindingsFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMacieSession


        /// <summary>
        /// Suspends or re-enables Amazon Macie, or updates the configuration settings for a Macie
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMacieSession service method.</param>
        /// 
        /// <returns>The response from the UpdateMacieSession service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateMacieSession">REST API Reference for UpdateMacieSession Operation</seealso>
        UpdateMacieSessionResponse UpdateMacieSession(UpdateMacieSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMacieSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMacieSession operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMacieSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateMacieSession">REST API Reference for UpdateMacieSession Operation</seealso>
        IAsyncResult BeginUpdateMacieSession(UpdateMacieSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMacieSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMacieSession.</param>
        /// 
        /// <returns>Returns a  UpdateMacieSessionResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateMacieSession">REST API Reference for UpdateMacieSession Operation</seealso>
        UpdateMacieSessionResponse EndUpdateMacieSession(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMemberSession


        /// <summary>
        /// Enables an Amazon Macie administrator to suspend or re-enable Macie for a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemberSession service method.</param>
        /// 
        /// <returns>The response from the UpdateMemberSession service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateMemberSession">REST API Reference for UpdateMemberSession Operation</seealso>
        UpdateMemberSessionResponse UpdateMemberSession(UpdateMemberSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMemberSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMemberSession operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMemberSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateMemberSession">REST API Reference for UpdateMemberSession Operation</seealso>
        IAsyncResult BeginUpdateMemberSession(UpdateMemberSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMemberSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMemberSession.</param>
        /// 
        /// <returns>Returns a  UpdateMemberSessionResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateMemberSession">REST API Reference for UpdateMemberSession Operation</seealso>
        UpdateMemberSessionResponse EndUpdateMemberSession(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOrganizationConfiguration


        /// <summary>
        /// Updates the Amazon Macie configuration settings for an organization in Organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateOrganizationConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ConflictException">
        /// Provides information about an error that occurred due to a versioning conflict for
        /// a specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        UpdateOrganizationConfigurationResponse UpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationConfiguration operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOrganizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        IAsyncResult BeginUpdateOrganizationConfiguration(UpdateOrganizationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOrganizationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateOrganizationConfigurationResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateOrganizationConfiguration">REST API Reference for UpdateOrganizationConfiguration Operation</seealso>
        UpdateOrganizationConfigurationResponse EndUpdateOrganizationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResourceProfile


        /// <summary>
        /// Updates the sensitivity score for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceProfile service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfile">REST API Reference for UpdateResourceProfile Operation</seealso>
        UpdateResourceProfileResponse UpdateResourceProfile(UpdateResourceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceProfile operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfile">REST API Reference for UpdateResourceProfile Operation</seealso>
        IAsyncResult BeginUpdateResourceProfile(UpdateResourceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceProfile.</param>
        /// 
        /// <returns>Returns a  UpdateResourceProfileResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfile">REST API Reference for UpdateResourceProfile Operation</seealso>
        UpdateResourceProfileResponse EndUpdateResourceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResourceProfileDetections


        /// <summary>
        /// Updates the sensitivity scoring settings for an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceProfileDetections service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceProfileDetections service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ServiceQuotaExceededException">
        /// Provides information about an error that occurred due to one or more service quotas
        /// for an account.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfileDetections">REST API Reference for UpdateResourceProfileDetections Operation</seealso>
        UpdateResourceProfileDetectionsResponse UpdateResourceProfileDetections(UpdateResourceProfileDetectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceProfileDetections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceProfileDetections operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourceProfileDetections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfileDetections">REST API Reference for UpdateResourceProfileDetections Operation</seealso>
        IAsyncResult BeginUpdateResourceProfileDetections(UpdateResourceProfileDetectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceProfileDetections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceProfileDetections.</param>
        /// 
        /// <returns>Returns a  UpdateResourceProfileDetectionsResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateResourceProfileDetections">REST API Reference for UpdateResourceProfileDetections Operation</seealso>
        UpdateResourceProfileDetectionsResponse EndUpdateResourceProfileDetections(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRevealConfiguration


        /// <summary>
        /// Updates the status and configuration settings for retrieving occurrences of sensitive
        /// data reported by findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevealConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateRevealConfiguration service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateRevealConfiguration">REST API Reference for UpdateRevealConfiguration Operation</seealso>
        UpdateRevealConfigurationResponse UpdateRevealConfiguration(UpdateRevealConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRevealConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevealConfiguration operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRevealConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateRevealConfiguration">REST API Reference for UpdateRevealConfiguration Operation</seealso>
        IAsyncResult BeginUpdateRevealConfiguration(UpdateRevealConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRevealConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRevealConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateRevealConfigurationResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateRevealConfiguration">REST API Reference for UpdateRevealConfiguration Operation</seealso>
        UpdateRevealConfigurationResponse EndUpdateRevealConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSensitivityInspectionTemplate


        /// <summary>
        /// Updates the settings for the sensitivity inspection template for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSensitivityInspectionTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateSensitivityInspectionTemplate service method, as returned by Macie2.</returns>
        /// <exception cref="Amazon.Macie2.Model.AccessDeniedException">
        /// Provides information about an error that occurred due to insufficient access to a
        /// specified resource.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.InternalServerException">
        /// Provides information about an error that occurred due to an unknown internal server
        /// error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ResourceNotFoundException">
        /// Provides information about an error that occurred because a specified resource wasn't
        /// found.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ThrottlingException">
        /// Provides information about an error that occurred because too many requests were sent
        /// during a certain amount of time.
        /// </exception>
        /// <exception cref="Amazon.Macie2.Model.ValidationException">
        /// Provides information about an error that occurred due to a syntax error in a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateSensitivityInspectionTemplate">REST API Reference for UpdateSensitivityInspectionTemplate Operation</seealso>
        UpdateSensitivityInspectionTemplateResponse UpdateSensitivityInspectionTemplate(UpdateSensitivityInspectionTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSensitivityInspectionTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSensitivityInspectionTemplate operation on AmazonMacie2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSensitivityInspectionTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateSensitivityInspectionTemplate">REST API Reference for UpdateSensitivityInspectionTemplate Operation</seealso>
        IAsyncResult BeginUpdateSensitivityInspectionTemplate(UpdateSensitivityInspectionTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSensitivityInspectionTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSensitivityInspectionTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateSensitivityInspectionTemplateResult from Macie2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie2-2020-01-01/UpdateSensitivityInspectionTemplate">REST API Reference for UpdateSensitivityInspectionTemplate Operation</seealso>
        UpdateSensitivityInspectionTemplateResponse EndUpdateSensitivityInspectionTemplate(IAsyncResult asyncResult);

        #endregion
        
    }
}