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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ECR.Model;

namespace Amazon.ECR
{
    /// <summary>
    /// Interface for accessing ECR
    ///
    /// Amazon EC2 Container Registry (Amazon ECR) is a managed AWS Docker registry service.
    /// Customers can use the familiar Docker CLI to push, pull, and manage images. Amazon
    /// ECR provides a secure, scalable, and reliable registry. Amazon ECR supports private
    /// Docker repositories with resource-based permissions using AWS IAM so that specific
    /// users or Amazon EC2 instances can access repositories and images. Developers can use
    /// the Docker CLI to author and manage images.
    /// </summary>
    public partial interface IAmazonECR : IAmazonService, IDisposable
    {

        
        #region  BatchCheckLayerAvailability


        /// <summary>
        /// Check the availability of multiple image layers in a specified registry and repository.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy, and it is not intended for general
        /// use by customers. Use the <code>docker</code> CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCheckLayerAvailability service method.</param>
        /// 
        /// <returns>The response from the BatchCheckLayerAvailability service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        BatchCheckLayerAvailabilityResponse BatchCheckLayerAvailability(BatchCheckLayerAvailabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCheckLayerAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCheckLayerAvailability operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCheckLayerAvailability
        ///         operation.</returns>
        IAsyncResult BeginBatchCheckLayerAvailability(BatchCheckLayerAvailabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCheckLayerAvailability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCheckLayerAvailability.</param>
        /// 
        /// <returns>Returns a  BatchCheckLayerAvailabilityResult from ECR.</returns>
        BatchCheckLayerAvailabilityResponse EndBatchCheckLayerAvailability(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteImage


        /// <summary>
        /// Deletes a list of specified images within a specified repository. Images are specified
        /// with either <code>imageTag</code> or <code>imageDigest</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteImage service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteImage service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        BatchDeleteImageResponse BatchDeleteImage(BatchDeleteImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteImage operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteImage
        ///         operation.</returns>
        IAsyncResult BeginBatchDeleteImage(BatchDeleteImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteImage.</param>
        /// 
        /// <returns>Returns a  BatchDeleteImageResult from ECR.</returns>
        BatchDeleteImageResponse EndBatchDeleteImage(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetImage


        /// <summary>
        /// Gets detailed information for specified images within a specified repository. Images
        /// are specified with either <code>imageTag</code> or <code>imageDigest</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetImage service method.</param>
        /// 
        /// <returns>The response from the BatchGetImage service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        BatchGetImageResponse BatchGetImage(BatchGetImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetImage operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetImage
        ///         operation.</returns>
        IAsyncResult BeginBatchGetImage(BatchGetImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetImage.</param>
        /// 
        /// <returns>Returns a  BatchGetImageResult from ECR.</returns>
        BatchGetImageResponse EndBatchGetImage(IAsyncResult asyncResult);

        #endregion
        
        #region  CompleteLayerUpload


        /// <summary>
        /// Inform Amazon ECR that the image layer upload for a specified registry, repository
        /// name, and upload ID, has completed. You can optionally provide a <code>sha256</code>
        /// digest of the image layer for data validation purposes.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy, and it is not intended for general
        /// use by customers. Use the <code>docker</code> CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteLayerUpload service method.</param>
        /// 
        /// <returns>The response from the CompleteLayerUpload service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.EmptyUploadException">
        /// The specified layer upload does not contain any layer parts.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidLayerException">
        /// The layer digest calculation performed by Amazon ECR upon receipt of the image layer
        /// does not match the digest specified.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LayerAlreadyExistsException">
        /// The image layer already exists in the associated repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LayerPartTooSmallException">
        /// Layer parts must be at least 5 MiB in size.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.UploadNotFoundException">
        /// The upload could not be found, or the specified upload id is not valid for this repository.
        /// </exception>
        CompleteLayerUploadResponse CompleteLayerUpload(CompleteLayerUploadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteLayerUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteLayerUpload operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCompleteLayerUpload
        ///         operation.</returns>
        IAsyncResult BeginCompleteLayerUpload(CompleteLayerUploadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CompleteLayerUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteLayerUpload.</param>
        /// 
        /// <returns>Returns a  CompleteLayerUploadResult from ECR.</returns>
        CompleteLayerUploadResponse EndCompleteLayerUpload(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRepository


        /// <summary>
        /// Creates an image repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository service method.</param>
        /// 
        /// <returns>The response from the CreateRepository service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LimitExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="http://docs.aws.amazon.com/AmazonECR/latest/userguide/service_limits.html">Amazon
        /// ECR Default Service Limits</a> in the Amazon EC2 Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryAlreadyExistsException">
        /// The specified repository already exists in the specified registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository operation on AmazonECRClient.</param>
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
        /// <returns>Returns a  CreateRepositoryResult from ECR.</returns>
        CreateRepositoryResponse EndCreateRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRepository


        /// <summary>
        /// Deletes an existing image repository. If a repository contains images, you must use
        /// the <code>force</code> option to delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteRepository service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotEmptyException">
        /// The specified repository contains images. To delete a repository that contains images,
        /// you must force the deletion with the <code>force</code> parameter.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository operation on AmazonECRClient.</param>
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
        /// <returns>Returns a  DeleteRepositoryResult from ECR.</returns>
        DeleteRepositoryResponse EndDeleteRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRepositoryPolicy


        /// <summary>
        /// Deletes the repository policy from a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteRepositoryPolicy service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryPolicyNotFoundException">
        /// The specified repository and registry combination does not have an associated repository
        /// policy.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        DeleteRepositoryPolicyResponse DeleteRepositoryPolicy(DeleteRepositoryPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryPolicy operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRepositoryPolicy
        ///         operation.</returns>
        IAsyncResult BeginDeleteRepositoryPolicy(DeleteRepositoryPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRepositoryPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteRepositoryPolicyResult from ECR.</returns>
        DeleteRepositoryPolicyResponse EndDeleteRepositoryPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRepositories


        /// <summary>
        /// Describes image repositories in a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositories service method.</param>
        /// 
        /// <returns>The response from the DescribeRepositories service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        DescribeRepositoriesResponse DescribeRepositories(DescribeRepositoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositories operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRepositories
        ///         operation.</returns>
        IAsyncResult BeginDescribeRepositories(DescribeRepositoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRepositories.</param>
        /// 
        /// <returns>Returns a  DescribeRepositoriesResult from ECR.</returns>
        DescribeRepositoriesResponse EndDescribeRepositories(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAuthorizationToken


        /// <summary>
        /// Retrieves a token that is valid for a specified registry for 12 hours. This command
        /// allows you to use the <code>docker</code> CLI to push and pull images with Amazon
        /// ECR. If you do not specify a registry, the default registry is assumed.
        /// 
        ///  
        /// <para>
        /// The <code>authorizationToken</code> returned for each registry specified is a base64
        /// encoded string that can be decoded and used in a <code>docker login</code> command
        /// to authenticate to a registry. The AWS CLI offers an <code>aws ecr get-login</code>
        /// command that simplifies the login process.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizationToken service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizationToken service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        GetAuthorizationTokenResponse GetAuthorizationToken(GetAuthorizationTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizationToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizationToken operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAuthorizationToken
        ///         operation.</returns>
        IAsyncResult BeginGetAuthorizationToken(GetAuthorizationTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizationToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizationToken.</param>
        /// 
        /// <returns>Returns a  GetAuthorizationTokenResult from ECR.</returns>
        GetAuthorizationTokenResponse EndGetAuthorizationToken(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDownloadUrlForLayer


        /// <summary>
        /// Retrieves the pre-signed Amazon S3 download URL corresponding to an image layer. You
        /// can only get URLs for image layers that are referenced in an image.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy, and it is not intended for general
        /// use by customers. Use the <code>docker</code> CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDownloadUrlForLayer service method.</param>
        /// 
        /// <returns>The response from the GetDownloadUrlForLayer service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LayerInaccessibleException">
        /// The specified layer is not available because it is not associated with an image. Unassociated
        /// image layers may be cleaned up at any time.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LayersNotFoundException">
        /// The specified layers could not be found, or the specified layer is not valid for this
        /// repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        GetDownloadUrlForLayerResponse GetDownloadUrlForLayer(GetDownloadUrlForLayerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDownloadUrlForLayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDownloadUrlForLayer operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDownloadUrlForLayer
        ///         operation.</returns>
        IAsyncResult BeginGetDownloadUrlForLayer(GetDownloadUrlForLayerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDownloadUrlForLayer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDownloadUrlForLayer.</param>
        /// 
        /// <returns>Returns a  GetDownloadUrlForLayerResult from ECR.</returns>
        GetDownloadUrlForLayerResponse EndGetDownloadUrlForLayer(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRepositoryPolicy


        /// <summary>
        /// Retrieves the repository policy for a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryPolicy service method.</param>
        /// 
        /// <returns>The response from the GetRepositoryPolicy service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryPolicyNotFoundException">
        /// The specified repository and registry combination does not have an associated repository
        /// policy.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        GetRepositoryPolicyResponse GetRepositoryPolicy(GetRepositoryPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryPolicy operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRepositoryPolicy
        ///         operation.</returns>
        IAsyncResult BeginGetRepositoryPolicy(GetRepositoryPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRepositoryPolicy.</param>
        /// 
        /// <returns>Returns a  GetRepositoryPolicyResult from ECR.</returns>
        GetRepositoryPolicyResponse EndGetRepositoryPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  InitiateLayerUpload


        /// <summary>
        /// Notify Amazon ECR that you intend to upload an image layer.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy, and it is not intended for general
        /// use by customers. Use the <code>docker</code> CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateLayerUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateLayerUpload service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        InitiateLayerUploadResponse InitiateLayerUpload(InitiateLayerUploadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateLayerUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateLayerUpload operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitiateLayerUpload
        ///         operation.</returns>
        IAsyncResult BeginInitiateLayerUpload(InitiateLayerUploadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InitiateLayerUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateLayerUpload.</param>
        /// 
        /// <returns>Returns a  InitiateLayerUploadResult from ECR.</returns>
        InitiateLayerUploadResponse EndInitiateLayerUpload(IAsyncResult asyncResult);

        #endregion
        
        #region  ListImages


        /// <summary>
        /// Lists all the image IDs for a given repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImages service method.</param>
        /// 
        /// <returns>The response from the ListImages service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        ListImagesResponse ListImages(ListImagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImages operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImages
        ///         operation.</returns>
        IAsyncResult BeginListImages(ListImagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImages.</param>
        /// 
        /// <returns>Returns a  ListImagesResult from ECR.</returns>
        ListImagesResponse EndListImages(IAsyncResult asyncResult);

        #endregion
        
        #region  PutImage


        /// <summary>
        /// Creates or updates the image manifest associated with an image.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy, and it is not intended for general
        /// use by customers. Use the <code>docker</code> CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutImage service method.</param>
        /// 
        /// <returns>The response from the PutImage service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.ImageAlreadyExistsException">
        /// The specified image has already been pushed, and there are no changes to the manifest
        /// or image tag since the last push.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LayersNotFoundException">
        /// The specified layers could not be found, or the specified layer is not valid for this
        /// repository.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LimitExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="http://docs.aws.amazon.com/AmazonECR/latest/userguide/service_limits.html">Amazon
        /// ECR Default Service Limits</a> in the Amazon EC2 Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        PutImageResponse PutImage(PutImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutImage operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutImage
        ///         operation.</returns>
        IAsyncResult BeginPutImage(PutImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutImage.</param>
        /// 
        /// <returns>Returns a  PutImageResult from ECR.</returns>
        PutImageResponse EndPutImage(IAsyncResult asyncResult);

        #endregion
        
        #region  SetRepositoryPolicy


        /// <summary>
        /// Applies a repository policy on a specified repository to control access permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetRepositoryPolicy service method.</param>
        /// 
        /// <returns>The response from the SetRepositoryPolicy service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        SetRepositoryPolicyResponse SetRepositoryPolicy(SetRepositoryPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetRepositoryPolicy operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetRepositoryPolicy
        ///         operation.</returns>
        IAsyncResult BeginSetRepositoryPolicy(SetRepositoryPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetRepositoryPolicy.</param>
        /// 
        /// <returns>Returns a  SetRepositoryPolicyResult from ECR.</returns>
        SetRepositoryPolicyResponse EndSetRepositoryPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  UploadLayerPart


        /// <summary>
        /// Uploads an image layer part to Amazon ECR.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy, and it is not intended for general
        /// use by customers. Use the <code>docker</code> CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadLayerPart service method.</param>
        /// 
        /// <returns>The response from the UploadLayerPart service method, as returned by ECR.</returns>
        /// <exception cref="Amazon.ECR.Model.InvalidLayerPartException">
        /// The layer part size is not valid, or the first byte specified is not consecutive to
        /// the last byte of a previous layer part upload.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.LimitExceededException">
        /// The operation did not succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="http://docs.aws.amazon.com/AmazonECR/latest/userguide/service_limits.html">Amazon
        /// ECR Default Service Limits</a> in the Amazon EC2 Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.RepositoryNotFoundException">
        /// The specified repository could not be found. Check the spelling of the specified repository
        /// and ensure that you are performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECR.Model.UploadNotFoundException">
        /// The upload could not be found, or the specified upload id is not valid for this repository.
        /// </exception>
        UploadLayerPartResponse UploadLayerPart(UploadLayerPartRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadLayerPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadLayerPart operation on AmazonECRClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadLayerPart
        ///         operation.</returns>
        IAsyncResult BeginUploadLayerPart(UploadLayerPartRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UploadLayerPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadLayerPart.</param>
        /// 
        /// <returns>Returns a  UploadLayerPartResult from ECR.</returns>
        UploadLayerPartResponse EndUploadLayerPart(IAsyncResult asyncResult);

        #endregion
        
    }
}