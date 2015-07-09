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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.CodeCommit.Model;

namespace Amazon.CodeCommit
{
    /// <summary>
    /// Interface for accessing CodeCommit
    ///
    /// AWS CodeCommit 
    /// <para>
    /// This is the <i>AWS CodeCommit API Reference</i>. This reference provides descriptions
    /// of the AWS CodeCommit API.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodeCommit API to work with the following objects:
    /// </para>
    ///  <ul> <li>Repositories</li> <li>Branches</li> <li>Commits</li> </ul> 
    /// <para>
    /// For information about how to use AWS CodeCommit, see the <i>AWS CodeCommit User Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCodeCommit : IDisposable
    {

        
        #region  BatchGetRepositories

        /// <summary>
        /// Gets information about one or more repositories.
        /// 
        ///  <note>
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a web page could expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a web page.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRepositories service method.</param>
        /// 
        /// <returns>The response from the BatchGetRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note>This exception only occurs when a specified repository name is not valid. Other
        /// exceptions occur when a required repository parameter is missing, or when a specified
        /// repository does not exist.</note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryNamesExceededException">
        /// The maximum number of allowed repository names was exceeded. Currently, this number
        /// is 25.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNamesRequiredException">
        /// A repository names object is required but was not specified.
        /// </exception>
        BatchGetRepositoriesResponse BatchGetRepositories(BatchGetRepositoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRepositories operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetRepositories
        ///         operation.</returns>
        IAsyncResult BeginBatchGetRepositories(BatchGetRepositoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetRepositories.</param>
        /// 
        /// <returns>Returns a  BatchGetRepositoriesResult from CodeCommit.</returns>
        BatchGetRepositoriesResponse EndBatchGetRepositories(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBranch

        /// <summary>
        /// Creates a new branch in a repository and points the branch to a commit.
        /// 
        ///  <note>Calling the create branch operation does not set a repository's default branch.
        /// To do this, call the update default branch operation.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch service method.</param>
        /// 
        /// <returns>The response from the CreateBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameExistsException">
        /// The specified branch name already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified branch name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note>This exception only occurs when a specified repository name is not valid. Other
        /// exceptions occur when a required repository parameter is missing, or when a specified
        /// repository does not exist.</note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        CreateBranchResponse CreateBranch(CreateBranchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBranch
        ///         operation.</returns>
        IAsyncResult BeginCreateBranch(CreateBranchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBranch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBranch.</param>
        /// 
        /// <returns>Returns a  CreateBranchResult from CodeCommit.</returns>
        CreateBranchResponse EndCreateBranch(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRepository

        /// <summary>
        /// Creates a new, empty repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository service method.</param>
        /// 
        /// <returns>The response from the CreateRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryDescriptionException">
        /// The specified repository description is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note>This exception only occurs when a specified repository name is not valid. Other
        /// exceptions occur when a required repository parameter is missing, or when a specified
        /// repository does not exist.</note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryLimitExceededException">
        /// A repository resource limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameExistsException">
        /// The specified repository name already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRepository
        ///         operation.</returns>
        IAsyncResult BeginCreateRepository(CreateRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRepository.</param>
        /// 
        /// <returns>Returns a  CreateRepositoryResult from CodeCommit.</returns>
        CreateRepositoryResponse EndCreateRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRepository

        /// <summary>
        /// Deletes a repository. If a specified repository was already deleted, a null repository
        /// ID will be returned.
        /// 
        ///  <important>Deleting a repository also deletes all associated objects and metadata.
        /// After a repository is deleted, all future push calls to the deleted repository will
        /// fail.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note>This exception only occurs when a specified repository name is not valid. Other
        /// exceptions occur when a required repository parameter is missing, or when a specified
        /// repository does not exist.</note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRepository
        ///         operation.</returns>
        IAsyncResult BeginDeleteRepository(DeleteRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRepository.</param>
        /// 
        /// <returns>Returns a  DeleteRepositoryResult from CodeCommit.</returns>
        DeleteRepositoryResponse EndDeleteRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBranch

        /// <summary>
        /// Retrieves information about a repository branch, including its name and the last commit
        /// ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBranch service method.</param>
        /// 
        /// <returns>The response from the GetBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified branch name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note>This exception only occurs when a specified repository name is not valid. Other
        /// exceptions occur when a required repository parameter is missing, or when a specified
        /// repository does not exist.</note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        GetBranchResponse GetBranch(GetBranchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBranch operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBranch
        ///         operation.</returns>
        IAsyncResult BeginGetBranch(GetBranchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBranch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBranch.</param>
        /// 
        /// <returns>Returns a  GetBranchResult from CodeCommit.</returns>
        GetBranchResponse EndGetBranch(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRepository

        /// <summary>
        /// Gets information about a repository.
        /// 
        ///  <note>
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a web page could expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a web page.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepository service method.</param>
        /// 
        /// <returns>The response from the GetRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note>This exception only occurs when a specified repository name is not valid. Other
        /// exceptions occur when a required repository parameter is missing, or when a specified
        /// repository does not exist.</note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        GetRepositoryResponse GetRepository(GetRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepository operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRepository
        ///         operation.</returns>
        IAsyncResult BeginGetRepository(GetRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRepository.</param>
        /// 
        /// <returns>Returns a  GetRepositoryResult from CodeCommit.</returns>
        GetRepositoryResponse EndGetRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBranches

        /// <summary>
        /// Gets information about one or more branches in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBranches service method.</param>
        /// 
        /// <returns>The response from the ListBranches service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note>This exception only occurs when a specified repository name is not valid. Other
        /// exceptions occur when a required repository parameter is missing, or when a specified
        /// repository does not exist.</note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        ListBranchesResponse ListBranches(ListBranchesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBranches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBranches operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBranches
        ///         operation.</returns>
        IAsyncResult BeginListBranches(ListBranchesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBranches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBranches.</param>
        /// 
        /// <returns>Returns a  ListBranchesResult from CodeCommit.</returns>
        ListBranchesResponse EndListBranches(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRepositories

        /// <summary>
        /// Gets information about one or more repositories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories service method.</param>
        /// 
        /// <returns>The response from the ListRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidOrderException">
        /// The specified sort order is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSortByException">
        /// The specified sort by value is not valid.
        /// </exception>
        ListRepositoriesResponse ListRepositories(ListRepositoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRepositories
        ///         operation.</returns>
        IAsyncResult BeginListRepositories(ListRepositoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRepositories.</param>
        /// 
        /// <returns>Returns a  ListRepositoriesResult from CodeCommit.</returns>
        ListRepositoriesResponse EndListRepositories(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDefaultBranch

        /// <summary>
        /// Sets or changes the default branch name for the specified repository.
        /// 
        ///  <note>If you use this operation to change the default branch name to the current
        /// default branch name, a success message is returned even though the default branch
        /// did not change.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultBranch service method.</param>
        /// 
        /// <returns>The response from the UpdateDefaultBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified branch name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note>This exception only occurs when a specified repository name is not valid. Other
        /// exceptions occur when a required repository parameter is missing, or when a specified
        /// repository does not exist.</note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        UpdateDefaultBranchResponse UpdateDefaultBranch(UpdateDefaultBranchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDefaultBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultBranch operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDefaultBranch
        ///         operation.</returns>
        IAsyncResult BeginUpdateDefaultBranch(UpdateDefaultBranchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDefaultBranch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDefaultBranch.</param>
        /// 
        /// <returns>Returns a  UpdateDefaultBranchResult from CodeCommit.</returns>
        UpdateDefaultBranchResponse EndUpdateDefaultBranch(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRepositoryDescription

        /// <summary>
        /// Sets or changes the comment or description for a repository.
        /// 
        ///  <note>
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a web page could expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a web page.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryDescription service method.</param>
        /// 
        /// <returns>The response from the UpdateRepositoryDescription service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryDescriptionException">
        /// The specified repository description is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note>This exception only occurs when a specified repository name is not valid. Other
        /// exceptions occur when a required repository parameter is missing, or when a specified
        /// repository does not exist.</note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        UpdateRepositoryDescriptionResponse UpdateRepositoryDescription(UpdateRepositoryDescriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRepositoryDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryDescription operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRepositoryDescription
        ///         operation.</returns>
        IAsyncResult BeginUpdateRepositoryDescription(UpdateRepositoryDescriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRepositoryDescription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRepositoryDescription.</param>
        /// 
        /// <returns>Returns a  UpdateRepositoryDescriptionResult from CodeCommit.</returns>
        UpdateRepositoryDescriptionResponse EndUpdateRepositoryDescription(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRepositoryName

        /// <summary>
        /// Renames a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryName service method.</param>
        /// 
        /// <returns>The response from the UpdateRepositoryName service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note>This exception only occurs when a specified repository name is not valid. Other
        /// exceptions occur when a required repository parameter is missing, or when a specified
        /// repository does not exist.</note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameExistsException">
        /// The specified repository name already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        UpdateRepositoryNameResponse UpdateRepositoryName(UpdateRepositoryNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRepositoryName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryName operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRepositoryName
        ///         operation.</returns>
        IAsyncResult BeginUpdateRepositoryName(UpdateRepositoryNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRepositoryName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRepositoryName.</param>
        /// 
        /// <returns>Returns a  UpdateRepositoryNameResult from CodeCommit.</returns>
        UpdateRepositoryNameResponse EndUpdateRepositoryName(IAsyncResult asyncResult);

        #endregion
        
    }
}