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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ECRPublic.Model;

namespace Amazon.ECRPublic
{
    /// <summary>
    /// Interface for accessing ECRPublic
    ///
    /// Amazon Elastic Container Registry Public 
    /// <para>
    /// Amazon Elastic Container Registry Public (Amazon ECR Public) is a managed container
    /// image registry service. Amazon ECR provides both public and private registries to
    /// host your container images. You can use the Docker CLI or your preferred client to
    /// push, pull, and manage images. Amazon ECR provides a secure, scalable, and reliable
    /// registry for your Docker or Open Container Initiative (OCI) images. Amazon ECR supports
    /// public repositories with this API. For information about the Amazon ECR API for private
    /// repositories, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/APIReference/Welcome.html">Amazon
    /// Elastic Container Registry API Reference</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonECRPublic : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IECRPublicPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchCheckLayerAvailability


        /// <summary>
        /// Checks the availability of one or more image layers that are within a repository in
        /// a public registry. When an image is pushed to a repository, each image layer is checked
        /// to verify if it has been uploaded before. If it has been uploaded, then the image
        /// layer is skipped.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy and is not generally used by customers
        /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
        /// CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCheckLayerAvailability service method.</param>
        /// 
        /// <returns>The response from the BatchCheckLayerAvailability service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/BatchCheckLayerAvailability">REST API Reference for BatchCheckLayerAvailability Operation</seealso>
        BatchCheckLayerAvailabilityResponse BatchCheckLayerAvailability(BatchCheckLayerAvailabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCheckLayerAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCheckLayerAvailability operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCheckLayerAvailability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/BatchCheckLayerAvailability">REST API Reference for BatchCheckLayerAvailability Operation</seealso>
        IAsyncResult BeginBatchCheckLayerAvailability(BatchCheckLayerAvailabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCheckLayerAvailability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCheckLayerAvailability.</param>
        /// 
        /// <returns>Returns a  BatchCheckLayerAvailabilityResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/BatchCheckLayerAvailability">REST API Reference for BatchCheckLayerAvailability Operation</seealso>
        BatchCheckLayerAvailabilityResponse EndBatchCheckLayerAvailability(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteImage


        /// <summary>
        /// Deletes a list of specified images that are within a repository in a public registry.
        /// Images are specified with either an <code>imageTag</code> or <code>imageDigest</code>.
        /// 
        ///  
        /// <para>
        /// You can remove a tag from an image by specifying the image's tag in your request.
        /// When you remove the last tag from an image, the image is deleted from your repository.
        /// </para>
        ///  
        /// <para>
        /// You can completely delete an image (and all of its tags) by specifying the digest
        /// of the image in your request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteImage service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteImage service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/BatchDeleteImage">REST API Reference for BatchDeleteImage Operation</seealso>
        BatchDeleteImageResponse BatchDeleteImage(BatchDeleteImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteImage operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/BatchDeleteImage">REST API Reference for BatchDeleteImage Operation</seealso>
        IAsyncResult BeginBatchDeleteImage(BatchDeleteImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteImage.</param>
        /// 
        /// <returns>Returns a  BatchDeleteImageResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/BatchDeleteImage">REST API Reference for BatchDeleteImage Operation</seealso>
        BatchDeleteImageResponse EndBatchDeleteImage(IAsyncResult asyncResult);

        #endregion
        
        #region  CompleteLayerUpload


        /// <summary>
        /// Informs Amazon ECR that the image layer upload is complete for a specified public
        /// registry, repository name, and upload ID. You can optionally provide a <code>sha256</code>
        /// digest of the image layer for data validation purposes.
        /// 
        ///  
        /// <para>
        /// When an image is pushed, the CompleteLayerUpload API is called once for each new image
        /// layer to verify that the upload is complete.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy and is not generally used by customers
        /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
        /// CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteLayerUpload service method.</param>
        /// 
        /// <returns>The response from the CompleteLayerUpload service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.EmptyUploadException">
        /// The specified layer upload doesn't contain any layer parts.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidLayerException">
        /// The layer digest calculation performed by Amazon ECR when the image layer doesn't
        /// match the digest specified.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LayerAlreadyExistsException">
        /// The image layer already exists in the associated repository.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LayerPartTooSmallException">
        /// Layer parts must be at least 5 MiB in size.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UploadNotFoundException">
        /// The upload can't be found, or the specified upload ID isn't valid for this repository.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/CompleteLayerUpload">REST API Reference for CompleteLayerUpload Operation</seealso>
        CompleteLayerUploadResponse CompleteLayerUpload(CompleteLayerUploadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteLayerUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteLayerUpload operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCompleteLayerUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/CompleteLayerUpload">REST API Reference for CompleteLayerUpload Operation</seealso>
        IAsyncResult BeginCompleteLayerUpload(CompleteLayerUploadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CompleteLayerUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteLayerUpload.</param>
        /// 
        /// <returns>Returns a  CompleteLayerUploadResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/CompleteLayerUpload">REST API Reference for CompleteLayerUpload Operation</seealso>
        CompleteLayerUploadResponse EndCompleteLayerUpload(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRepository


        /// <summary>
        /// Creates a repository in a public registry. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/Repositories.html">Amazon
        /// ECR repositories</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository service method.</param>
        /// 
        /// <returns>The response from the CreateRepository service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidTagParameterException">
        /// An invalid parameter has been specified. Tag keys can have a maximum character length
        /// of 128 characters, and tag values can have a maximum length of 256 characters.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LimitExceededException">
        /// The operation didn't succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/service-quotas.html">Amazon
        /// ECR Service Quotas</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryAlreadyExistsException">
        /// The specified repository already exists in the specified registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.TooManyTagsException">
        /// The list of tags on the repository is over the limit. The maximum number of tags that
        /// can be applied to a repository is 50.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        IAsyncResult BeginCreateRepository(CreateRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRepository.</param>
        /// 
        /// <returns>Returns a  CreateRepositoryResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        CreateRepositoryResponse EndCreateRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRepository


        /// <summary>
        /// Deletes a repository in a public registry. If the repository contains images, you
        /// must either manually delete all images in the repository or use the <code>force</code>
        /// option. This option deletes all images on your behalf before deleting the repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteRepository service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotEmptyException">
        /// The specified repository contains images. To delete a repository that contains images,
        /// you must force the deletion with the <code>force</code> parameter.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        IAsyncResult BeginDeleteRepository(DeleteRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRepository.</param>
        /// 
        /// <returns>Returns a  DeleteRepositoryResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        DeleteRepositoryResponse EndDeleteRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRepositoryPolicy


        /// <summary>
        /// Deletes the repository policy that's associated with the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteRepositoryPolicy service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryPolicyNotFoundException">
        /// The specified repository and registry combination doesn't have an associated repository
        /// policy.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DeleteRepositoryPolicy">REST API Reference for DeleteRepositoryPolicy Operation</seealso>
        DeleteRepositoryPolicyResponse DeleteRepositoryPolicy(DeleteRepositoryPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepositoryPolicy operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRepositoryPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DeleteRepositoryPolicy">REST API Reference for DeleteRepositoryPolicy Operation</seealso>
        IAsyncResult BeginDeleteRepositoryPolicy(DeleteRepositoryPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRepositoryPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteRepositoryPolicyResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DeleteRepositoryPolicy">REST API Reference for DeleteRepositoryPolicy Operation</seealso>
        DeleteRepositoryPolicyResponse EndDeleteRepositoryPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImages


        /// <summary>
        /// Returns metadata that's related to the images in a repository in a public registry.
        /// 
        ///  <note> 
        /// <para>
        /// Beginning with Docker version 1.9, the Docker client compresses image layers before
        /// pushing them to a V2 Docker registry. The output of the <code>docker images</code>
        /// command shows the uncompressed image size. Therefore, it might return a larger image
        /// size than the image sizes that are returned by <a>DescribeImages</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.ImageNotFoundException">
        /// The image requested doesn't exist in the specified repository.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        DescribeImagesResponse DescribeImages(DescribeImagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        IAsyncResult BeginDescribeImages(DescribeImagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImages.</param>
        /// 
        /// <returns>Returns a  DescribeImagesResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        DescribeImagesResponse EndDescribeImages(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImageTags


        /// <summary>
        /// Returns the image tag details for a repository in a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageTags service method.</param>
        /// 
        /// <returns>The response from the DescribeImageTags service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeImageTags">REST API Reference for DescribeImageTags Operation</seealso>
        DescribeImageTagsResponse DescribeImageTags(DescribeImageTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageTags operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImageTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeImageTags">REST API Reference for DescribeImageTags Operation</seealso>
        IAsyncResult BeginDescribeImageTags(DescribeImageTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImageTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImageTags.</param>
        /// 
        /// <returns>Returns a  DescribeImageTagsResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeImageTags">REST API Reference for DescribeImageTags Operation</seealso>
        DescribeImageTagsResponse EndDescribeImageTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRegistries


        /// <summary>
        /// Returns details for a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistries service method.</param>
        /// 
        /// <returns>The response from the DescribeRegistries service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeRegistries">REST API Reference for DescribeRegistries Operation</seealso>
        DescribeRegistriesResponse DescribeRegistries(DescribeRegistriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegistries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistries operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRegistries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeRegistries">REST API Reference for DescribeRegistries Operation</seealso>
        IAsyncResult BeginDescribeRegistries(DescribeRegistriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRegistries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRegistries.</param>
        /// 
        /// <returns>Returns a  DescribeRegistriesResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeRegistries">REST API Reference for DescribeRegistries Operation</seealso>
        DescribeRegistriesResponse EndDescribeRegistries(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRepositories


        /// <summary>
        /// Describes repositories that are in a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositories service method.</param>
        /// 
        /// <returns>The response from the DescribeRepositories service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeRepositories">REST API Reference for DescribeRepositories Operation</seealso>
        DescribeRepositoriesResponse DescribeRepositories(DescribeRepositoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositories operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRepositories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeRepositories">REST API Reference for DescribeRepositories Operation</seealso>
        IAsyncResult BeginDescribeRepositories(DescribeRepositoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRepositories.</param>
        /// 
        /// <returns>Returns a  DescribeRepositoriesResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/DescribeRepositories">REST API Reference for DescribeRepositories Operation</seealso>
        DescribeRepositoriesResponse EndDescribeRepositories(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAuthorizationToken


        /// <summary>
        /// Retrieves an authorization token. An authorization token represents your IAM authentication
        /// credentials. You can use it to access any Amazon ECR registry that your IAM principal
        /// has access to. The authorization token is valid for 12 hours. This API requires the
        /// <code>ecr-public:GetAuthorizationToken</code> and <code>sts:GetServiceBearerToken</code>
        /// permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizationToken service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizationToken service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetAuthorizationToken">REST API Reference for GetAuthorizationToken Operation</seealso>
        GetAuthorizationTokenResponse GetAuthorizationToken(GetAuthorizationTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizationToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizationToken operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAuthorizationToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetAuthorizationToken">REST API Reference for GetAuthorizationToken Operation</seealso>
        IAsyncResult BeginGetAuthorizationToken(GetAuthorizationTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizationToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizationToken.</param>
        /// 
        /// <returns>Returns a  GetAuthorizationTokenResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetAuthorizationToken">REST API Reference for GetAuthorizationToken Operation</seealso>
        GetAuthorizationTokenResponse EndGetAuthorizationToken(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRegistryCatalogData


        /// <summary>
        /// Retrieves catalog metadata for a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistryCatalogData service method.</param>
        /// 
        /// <returns>The response from the GetRegistryCatalogData service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRegistryCatalogData">REST API Reference for GetRegistryCatalogData Operation</seealso>
        GetRegistryCatalogDataResponse GetRegistryCatalogData(GetRegistryCatalogDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRegistryCatalogData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegistryCatalogData operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRegistryCatalogData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRegistryCatalogData">REST API Reference for GetRegistryCatalogData Operation</seealso>
        IAsyncResult BeginGetRegistryCatalogData(GetRegistryCatalogDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRegistryCatalogData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRegistryCatalogData.</param>
        /// 
        /// <returns>Returns a  GetRegistryCatalogDataResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRegistryCatalogData">REST API Reference for GetRegistryCatalogData Operation</seealso>
        GetRegistryCatalogDataResponse EndGetRegistryCatalogData(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRepositoryCatalogData


        /// <summary>
        /// Retrieve catalog metadata for a repository in a public registry. This metadata is
        /// displayed publicly in the Amazon ECR Public Gallery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryCatalogData service method.</param>
        /// 
        /// <returns>The response from the GetRepositoryCatalogData service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryCatalogDataNotFoundException">
        /// The repository catalog data doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRepositoryCatalogData">REST API Reference for GetRepositoryCatalogData Operation</seealso>
        GetRepositoryCatalogDataResponse GetRepositoryCatalogData(GetRepositoryCatalogDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRepositoryCatalogData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryCatalogData operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRepositoryCatalogData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRepositoryCatalogData">REST API Reference for GetRepositoryCatalogData Operation</seealso>
        IAsyncResult BeginGetRepositoryCatalogData(GetRepositoryCatalogDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRepositoryCatalogData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRepositoryCatalogData.</param>
        /// 
        /// <returns>Returns a  GetRepositoryCatalogDataResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRepositoryCatalogData">REST API Reference for GetRepositoryCatalogData Operation</seealso>
        GetRepositoryCatalogDataResponse EndGetRepositoryCatalogData(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRepositoryPolicy


        /// <summary>
        /// Retrieves the repository policy for the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryPolicy service method.</param>
        /// 
        /// <returns>The response from the GetRepositoryPolicy service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryPolicyNotFoundException">
        /// The specified repository and registry combination doesn't have an associated repository
        /// policy.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRepositoryPolicy">REST API Reference for GetRepositoryPolicy Operation</seealso>
        GetRepositoryPolicyResponse GetRepositoryPolicy(GetRepositoryPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryPolicy operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRepositoryPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRepositoryPolicy">REST API Reference for GetRepositoryPolicy Operation</seealso>
        IAsyncResult BeginGetRepositoryPolicy(GetRepositoryPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRepositoryPolicy.</param>
        /// 
        /// <returns>Returns a  GetRepositoryPolicyResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/GetRepositoryPolicy">REST API Reference for GetRepositoryPolicy Operation</seealso>
        GetRepositoryPolicyResponse EndGetRepositoryPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  InitiateLayerUpload


        /// <summary>
        /// Notifies Amazon ECR that you intend to upload an image layer.
        /// 
        ///  
        /// <para>
        /// When an image is pushed, the InitiateLayerUpload API is called once for each image
        /// layer that hasn't already been uploaded. Whether an image layer uploads is determined
        /// by the BatchCheckLayerAvailability API action.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy and is not generally used by customers
        /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
        /// CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateLayerUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateLayerUpload service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/InitiateLayerUpload">REST API Reference for InitiateLayerUpload Operation</seealso>
        InitiateLayerUploadResponse InitiateLayerUpload(InitiateLayerUploadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateLayerUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateLayerUpload operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitiateLayerUpload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/InitiateLayerUpload">REST API Reference for InitiateLayerUpload Operation</seealso>
        IAsyncResult BeginInitiateLayerUpload(InitiateLayerUploadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InitiateLayerUpload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateLayerUpload.</param>
        /// 
        /// <returns>Returns a  InitiateLayerUploadResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/InitiateLayerUpload">REST API Reference for InitiateLayerUpload Operation</seealso>
        InitiateLayerUploadResponse EndInitiateLayerUpload(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List the tags for an Amazon ECR Public resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutImage


        /// <summary>
        /// Creates or updates the image manifest and tags that are associated with an image.
        /// 
        ///  
        /// <para>
        /// When an image is pushed and all new image layers have been uploaded, the PutImage
        /// API is called once to create or update the image manifest and the tags that are associated
        /// with the image.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy and is not generally used by customers
        /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
        /// CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutImage service method.</param>
        /// 
        /// <returns>The response from the PutImage service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.ImageAlreadyExistsException">
        /// The specified image has already been pushed, and there were no changes to the manifest
        /// or image tag after the last push.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ImageDigestDoesNotMatchException">
        /// The specified image digest doesn't match the digest that Amazon ECR calculated for
        /// the image.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ImageTagAlreadyExistsException">
        /// The specified image is tagged with a tag that already exists. The repository is configured
        /// for tag immutability.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LayersNotFoundException">
        /// The specified layers can't be found, or the specified layer isn't valid for this repository.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LimitExceededException">
        /// The operation didn't succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/service-quotas.html">Amazon
        /// ECR Service Quotas</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ReferencedImagesNotFoundException">
        /// The manifest list is referencing an image that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutImage">REST API Reference for PutImage Operation</seealso>
        PutImageResponse PutImage(PutImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutImage operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutImage">REST API Reference for PutImage Operation</seealso>
        IAsyncResult BeginPutImage(PutImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutImage.</param>
        /// 
        /// <returns>Returns a  PutImageResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutImage">REST API Reference for PutImage Operation</seealso>
        PutImageResponse EndPutImage(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRegistryCatalogData


        /// <summary>
        /// Create or update the catalog data for a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRegistryCatalogData service method.</param>
        /// 
        /// <returns>The response from the PutRegistryCatalogData service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutRegistryCatalogData">REST API Reference for PutRegistryCatalogData Operation</seealso>
        PutRegistryCatalogDataResponse PutRegistryCatalogData(PutRegistryCatalogDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRegistryCatalogData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRegistryCatalogData operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRegistryCatalogData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutRegistryCatalogData">REST API Reference for PutRegistryCatalogData Operation</seealso>
        IAsyncResult BeginPutRegistryCatalogData(PutRegistryCatalogDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRegistryCatalogData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRegistryCatalogData.</param>
        /// 
        /// <returns>Returns a  PutRegistryCatalogDataResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutRegistryCatalogData">REST API Reference for PutRegistryCatalogData Operation</seealso>
        PutRegistryCatalogDataResponse EndPutRegistryCatalogData(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRepositoryCatalogData


        /// <summary>
        /// Creates or updates the catalog data for a repository in a public registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRepositoryCatalogData service method.</param>
        /// 
        /// <returns>The response from the PutRepositoryCatalogData service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutRepositoryCatalogData">REST API Reference for PutRepositoryCatalogData Operation</seealso>
        PutRepositoryCatalogDataResponse PutRepositoryCatalogData(PutRepositoryCatalogDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRepositoryCatalogData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRepositoryCatalogData operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRepositoryCatalogData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutRepositoryCatalogData">REST API Reference for PutRepositoryCatalogData Operation</seealso>
        IAsyncResult BeginPutRepositoryCatalogData(PutRepositoryCatalogDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRepositoryCatalogData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRepositoryCatalogData.</param>
        /// 
        /// <returns>Returns a  PutRepositoryCatalogDataResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/PutRepositoryCatalogData">REST API Reference for PutRepositoryCatalogData Operation</seealso>
        PutRepositoryCatalogDataResponse EndPutRepositoryCatalogData(IAsyncResult asyncResult);

        #endregion
        
        #region  SetRepositoryPolicy


        /// <summary>
        /// Applies a repository policy to the specified public repository to control access permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/repository-policies.html">Amazon
        /// ECR Repository Policies</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetRepositoryPolicy service method.</param>
        /// 
        /// <returns>The response from the SetRepositoryPolicy service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/SetRepositoryPolicy">REST API Reference for SetRepositoryPolicy Operation</seealso>
        SetRepositoryPolicyResponse SetRepositoryPolicy(SetRepositoryPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetRepositoryPolicy operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetRepositoryPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/SetRepositoryPolicy">REST API Reference for SetRepositoryPolicy Operation</seealso>
        IAsyncResult BeginSetRepositoryPolicy(SetRepositoryPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetRepositoryPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetRepositoryPolicy.</param>
        /// 
        /// <returns>Returns a  SetRepositoryPolicyResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/SetRepositoryPolicy">REST API Reference for SetRepositoryPolicy Operation</seealso>
        SetRepositoryPolicyResponse EndSetRepositoryPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the specified tags to a resource with the specified <code>resourceArn</code>.
        /// If existing tags on a resource aren't specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags associated with that resource are also
        /// deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidTagParameterException">
        /// An invalid parameter has been specified. Tag keys can have a maximum character length
        /// of 128 characters, and tag values can have a maximum length of 256 characters.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.TooManyTagsException">
        /// The list of tags on the repository is over the limit. The maximum number of tags that
        /// can be applied to a repository is 50.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidTagParameterException">
        /// An invalid parameter has been specified. Tag keys can have a maximum character length
        /// of 128 characters, and tag values can have a maximum length of 256 characters.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.TooManyTagsException">
        /// The list of tags on the repository is over the limit. The maximum number of tags that
        /// can be applied to a repository is 50.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UploadLayerPart


        /// <summary>
        /// Uploads an image layer part to Amazon ECR.
        /// 
        ///  
        /// <para>
        /// When an image is pushed, each new image layer is uploaded in parts. The maximum size
        /// of each image layer part can be 20971520 bytes (about 20MB). The UploadLayerPart API
        /// is called once for each new image layer part.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is used by the Amazon ECR proxy and is not generally used by customers
        /// for pulling and pushing images. In most cases, you should use the <code>docker</code>
        /// CLI to pull, tag, and push images.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadLayerPart service method.</param>
        /// 
        /// <returns>The response from the UploadLayerPart service method, as returned by ECRPublic.</returns>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidLayerPartException">
        /// The layer part size isn't valid, or the first byte specified isn't consecutive to
        /// the last byte of a previous layer part upload.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.LimitExceededException">
        /// The operation didn't succeed because it would have exceeded a service limit for your
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/service-quotas.html">Amazon
        /// ECR Service Quotas</a> in the Amazon Elastic Container Registry User Guide.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RegistryNotFoundException">
        /// The registry doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.RepositoryNotFoundException">
        /// The specified repository can't be found. Check the spelling of the specified repository
        /// and ensure that you're performing operations on the correct registry.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UnsupportedCommandException">
        /// The action isn't supported in this Region.
        /// </exception>
        /// <exception cref="Amazon.ECRPublic.Model.UploadNotFoundException">
        /// The upload can't be found, or the specified upload ID isn't valid for this repository.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/UploadLayerPart">REST API Reference for UploadLayerPart Operation</seealso>
        UploadLayerPartResponse UploadLayerPart(UploadLayerPartRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadLayerPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadLayerPart operation on AmazonECRPublicClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadLayerPart
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/UploadLayerPart">REST API Reference for UploadLayerPart Operation</seealso>
        IAsyncResult BeginUploadLayerPart(UploadLayerPartRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UploadLayerPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadLayerPart.</param>
        /// 
        /// <returns>Returns a  UploadLayerPartResult from ECRPublic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ecr-public-2020-10-30/UploadLayerPart">REST API Reference for UploadLayerPart Operation</seealso>
        UploadLayerPartResponse EndUploadLayerPart(IAsyncResult asyncResult);

        #endregion
        
    }
}