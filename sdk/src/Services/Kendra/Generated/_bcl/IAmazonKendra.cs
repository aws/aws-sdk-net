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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Kendra.Model;

#pragma warning disable CS1570
namespace Amazon.Kendra
{
    /// <summary>
    /// <para>Interface for accessing Kendra</para>
    ///
    /// Amazon Kendra is a service for indexing large document sets.
    /// </summary>
    public partial interface IAmazonKendra : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IKendraPaginatorFactory Paginators { get; }

        
        #region  AssociateEntitiesToExperience


        /// <summary>
        /// Grants users or groups in your IAM Identity Center identity source access to your
        /// Amazon Kendra experience. You can create an Amazon Kendra experience such as a search
        /// application. For more information on creating a search application experience, see
        /// <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEntitiesToExperience service method.</param>
        /// 
        /// <returns>The response from the AssociateEntitiesToExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/AssociateEntitiesToExperience">REST API Reference for AssociateEntitiesToExperience Operation</seealso>
        AssociateEntitiesToExperienceResponse AssociateEntitiesToExperience(AssociateEntitiesToExperienceRequest request);



        /// <summary>
        /// Grants users or groups in your IAM Identity Center identity source access to your
        /// Amazon Kendra experience. You can create an Amazon Kendra experience such as a search
        /// application. For more information on creating a search application experience, see
        /// <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEntitiesToExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateEntitiesToExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/AssociateEntitiesToExperience">REST API Reference for AssociateEntitiesToExperience Operation</seealso>
        Task<AssociateEntitiesToExperienceResponse> AssociateEntitiesToExperienceAsync(AssociateEntitiesToExperienceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociatePersonasToEntities


        /// <summary>
        /// Defines the specific permissions of users or groups in your IAM Identity Center identity
        /// source with access to your Amazon Kendra experience. You can create an Amazon Kendra
        /// experience such as a search application. For more information on creating a search
        /// application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePersonasToEntities service method.</param>
        /// 
        /// <returns>The response from the AssociatePersonasToEntities service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/AssociatePersonasToEntities">REST API Reference for AssociatePersonasToEntities Operation</seealso>
        AssociatePersonasToEntitiesResponse AssociatePersonasToEntities(AssociatePersonasToEntitiesRequest request);



        /// <summary>
        /// Defines the specific permissions of users or groups in your IAM Identity Center identity
        /// source with access to your Amazon Kendra experience. You can create an Amazon Kendra
        /// experience such as a search application. For more information on creating a search
        /// application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePersonasToEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePersonasToEntities service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/AssociatePersonasToEntities">REST API Reference for AssociatePersonasToEntities Operation</seealso>
        Task<AssociatePersonasToEntitiesResponse> AssociatePersonasToEntitiesAsync(AssociatePersonasToEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteDocument


        /// <summary>
        /// Removes one or more documents from an index. The documents must have been added with
        /// the <c>BatchPutDocument</c> API.
        /// 
        ///  
        /// <para>
        /// The documents are deleted asynchronously. You can see the progress of the deletion
        /// by using Amazon Web Services CloudWatch. Any error messages related to the processing
        /// of the batch are sent to your Amazon Web Services CloudWatch log. You can also use
        /// the <c>BatchGetDocumentStatus</c> API to monitor the progress of deleting your documents.
        /// </para>
        ///  
        /// <para>
        /// Deleting documents from an index using <c>BatchDeleteDocument</c> could take up to
        /// an hour or more, depending on the number of documents you want to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDocument service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteDocument service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchDeleteDocument">REST API Reference for BatchDeleteDocument Operation</seealso>
        BatchDeleteDocumentResponse BatchDeleteDocument(BatchDeleteDocumentRequest request);



        /// <summary>
        /// Removes one or more documents from an index. The documents must have been added with
        /// the <c>BatchPutDocument</c> API.
        /// 
        ///  
        /// <para>
        /// The documents are deleted asynchronously. You can see the progress of the deletion
        /// by using Amazon Web Services CloudWatch. Any error messages related to the processing
        /// of the batch are sent to your Amazon Web Services CloudWatch log. You can also use
        /// the <c>BatchGetDocumentStatus</c> API to monitor the progress of deleting your documents.
        /// </para>
        ///  
        /// <para>
        /// Deleting documents from an index using <c>BatchDeleteDocument</c> could take up to
        /// an hour or more, depending on the number of documents you want to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteDocument service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchDeleteDocument">REST API Reference for BatchDeleteDocument Operation</seealso>
        Task<BatchDeleteDocumentResponse> BatchDeleteDocumentAsync(BatchDeleteDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteFeaturedResultsSet


        /// <summary>
        /// Removes one or more sets of featured results. Features results are placed above all
        /// other results for certain queries. If there's an exact match of a query, then one
        /// or more specific documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteFeaturedResultsSet service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchDeleteFeaturedResultsSet">REST API Reference for BatchDeleteFeaturedResultsSet Operation</seealso>
        BatchDeleteFeaturedResultsSetResponse BatchDeleteFeaturedResultsSet(BatchDeleteFeaturedResultsSetRequest request);



        /// <summary>
        /// Removes one or more sets of featured results. Features results are placed above all
        /// other results for certain queries. If there's an exact match of a query, then one
        /// or more specific documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteFeaturedResultsSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchDeleteFeaturedResultsSet">REST API Reference for BatchDeleteFeaturedResultsSet Operation</seealso>
        Task<BatchDeleteFeaturedResultsSetResponse> BatchDeleteFeaturedResultsSetAsync(BatchDeleteFeaturedResultsSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetDocumentStatus


        /// <summary>
        /// Returns the indexing status for one or more documents submitted with the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchPutDocument.html">
        /// BatchPutDocument</a> API.
        /// 
        ///  
        /// <para>
        /// When you use the <c>BatchPutDocument</c> API, documents are indexed asynchronously.
        /// You can use the <c>BatchGetDocumentStatus</c> API to get the current status of a list
        /// of documents so that you can determine if they have been successfully indexed.
        /// </para>
        ///  
        /// <para>
        /// You can also use the <c>BatchGetDocumentStatus</c> API to check the status of the
        /// <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchDeleteDocument.html">
        /// BatchDeleteDocument</a> API. When a document is deleted from the index, Amazon Kendra
        /// returns <c>NOT_FOUND</c> as the status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDocumentStatus service method.</param>
        /// 
        /// <returns>The response from the BatchGetDocumentStatus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchGetDocumentStatus">REST API Reference for BatchGetDocumentStatus Operation</seealso>
        BatchGetDocumentStatusResponse BatchGetDocumentStatus(BatchGetDocumentStatusRequest request);



        /// <summary>
        /// Returns the indexing status for one or more documents submitted with the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchPutDocument.html">
        /// BatchPutDocument</a> API.
        /// 
        ///  
        /// <para>
        /// When you use the <c>BatchPutDocument</c> API, documents are indexed asynchronously.
        /// You can use the <c>BatchGetDocumentStatus</c> API to get the current status of a list
        /// of documents so that you can determine if they have been successfully indexed.
        /// </para>
        ///  
        /// <para>
        /// You can also use the <c>BatchGetDocumentStatus</c> API to check the status of the
        /// <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchDeleteDocument.html">
        /// BatchDeleteDocument</a> API. When a document is deleted from the index, Amazon Kendra
        /// returns <c>NOT_FOUND</c> as the status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDocumentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetDocumentStatus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchGetDocumentStatus">REST API Reference for BatchGetDocumentStatus Operation</seealso>
        Task<BatchGetDocumentStatusResponse> BatchGetDocumentStatusAsync(BatchGetDocumentStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchPutDocument


        /// <summary>
        /// Adds one or more documents to an index.
        /// 
        ///  
        /// <para>
        /// The <c>BatchPutDocument</c> API enables you to ingest inline documents or a set of
        /// documents stored in an Amazon S3 bucket. Use this API to ingest your text and unstructured
        /// text into an index, add custom attributes to the documents, and to attach an access
        /// control list to the documents added to the index.
        /// </para>
        ///  
        /// <para>
        /// The documents are indexed asynchronously. You can see the progress of the batch using
        /// Amazon Web Services CloudWatch. Any error messages related to processing the batch
        /// are sent to your Amazon Web Services CloudWatch log. You can also use the <c>BatchGetDocumentStatus</c>
        /// API to monitor the progress of indexing your documents.
        /// </para>
        ///  
        /// <para>
        /// For an example of ingesting inline documents using Python and Java SDKs, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/in-adding-binary-doc.html">Adding
        /// files directly to an index</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutDocument service method.</param>
        /// 
        /// <returns>The response from the BatchPutDocument service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchPutDocument">REST API Reference for BatchPutDocument Operation</seealso>
        BatchPutDocumentResponse BatchPutDocument(BatchPutDocumentRequest request);



        /// <summary>
        /// Adds one or more documents to an index.
        /// 
        ///  
        /// <para>
        /// The <c>BatchPutDocument</c> API enables you to ingest inline documents or a set of
        /// documents stored in an Amazon S3 bucket. Use this API to ingest your text and unstructured
        /// text into an index, add custom attributes to the documents, and to attach an access
        /// control list to the documents added to the index.
        /// </para>
        ///  
        /// <para>
        /// The documents are indexed asynchronously. You can see the progress of the batch using
        /// Amazon Web Services CloudWatch. Any error messages related to processing the batch
        /// are sent to your Amazon Web Services CloudWatch log. You can also use the <c>BatchGetDocumentStatus</c>
        /// API to monitor the progress of indexing your documents.
        /// </para>
        ///  
        /// <para>
        /// For an example of ingesting inline documents using Python and Java SDKs, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/in-adding-binary-doc.html">Adding
        /// files directly to an index</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutDocument service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/BatchPutDocument">REST API Reference for BatchPutDocument Operation</seealso>
        Task<BatchPutDocumentResponse> BatchPutDocumentAsync(BatchPutDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ClearQuerySuggestions


        /// <summary>
        /// Clears existing query suggestions from an index.
        /// 
        ///  
        /// <para>
        /// This deletes existing suggestions only, not the queries in the query log. After you
        /// clear suggestions, Amazon Kendra learns new suggestions based on new queries added
        /// to the query log from the time you cleared suggestions. If you do not see any new
        /// suggestions, then please allow Amazon Kendra to collect enough queries to learn new
        /// suggestions.
        /// </para>
        ///  
        /// <para>
        ///  <c>ClearQuerySuggestions</c> is currently not supported in the Amazon Web Services
        /// GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClearQuerySuggestions service method.</param>
        /// 
        /// <returns>The response from the ClearQuerySuggestions service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ClearQuerySuggestions">REST API Reference for ClearQuerySuggestions Operation</seealso>
        ClearQuerySuggestionsResponse ClearQuerySuggestions(ClearQuerySuggestionsRequest request);



        /// <summary>
        /// Clears existing query suggestions from an index.
        /// 
        ///  
        /// <para>
        /// This deletes existing suggestions only, not the queries in the query log. After you
        /// clear suggestions, Amazon Kendra learns new suggestions based on new queries added
        /// to the query log from the time you cleared suggestions. If you do not see any new
        /// suggestions, then please allow Amazon Kendra to collect enough queries to learn new
        /// suggestions.
        /// </para>
        ///  
        /// <para>
        ///  <c>ClearQuerySuggestions</c> is currently not supported in the Amazon Web Services
        /// GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClearQuerySuggestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ClearQuerySuggestions service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ClearQuerySuggestions">REST API Reference for ClearQuerySuggestions Operation</seealso>
        Task<ClearQuerySuggestionsResponse> ClearQuerySuggestionsAsync(ClearQuerySuggestionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAccessControlConfiguration


        /// <summary>
        /// Creates an access configuration for your documents. This includes user and group access
        /// information for your documents. This is useful for user context filtering, where search
        /// results are filtered based on the user or their group access to documents.
        /// 
        ///  
        /// <para>
        /// You can use this to re-configure your existing document level access control without
        /// indexing all of your documents again. For example, your index contains top-secret
        /// company documents that only certain employees or users should access. One of these
        /// users leaves the company or switches to a team that should be blocked from accessing
        /// top-secret documents. The user still has access to top-secret documents because the
        /// user had access when your documents were previously indexed. You can create a specific
        /// access control configuration for the user with deny access. You can later update the
        /// access control configuration to allow access if the user returns to the company and
        /// re-joins the 'top-secret' team. You can re-configure access control for your documents
        /// as circumstances change.
        /// </para>
        ///  
        /// <para>
        /// To apply your access control configuration to certain documents, you call the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchPutDocument.html">BatchPutDocument</a>
        /// API with the <c>AccessControlConfigurationId</c> included in the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_Document.html">Document</a>
        /// object. If you use an S3 bucket as a data source, you update the <c>.metadata.json</c>
        /// with the <c>AccessControlConfigurationId</c> and synchronize your data source. Amazon
        /// Kendra currently only supports access control configuration for S3 data sources and
        /// documents indexed using the <c>BatchPutDocument</c> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessControlConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateAccessControlConfiguration service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateAccessControlConfiguration">REST API Reference for CreateAccessControlConfiguration Operation</seealso>
        CreateAccessControlConfigurationResponse CreateAccessControlConfiguration(CreateAccessControlConfigurationRequest request);



        /// <summary>
        /// Creates an access configuration for your documents. This includes user and group access
        /// information for your documents. This is useful for user context filtering, where search
        /// results are filtered based on the user or their group access to documents.
        /// 
        ///  
        /// <para>
        /// You can use this to re-configure your existing document level access control without
        /// indexing all of your documents again. For example, your index contains top-secret
        /// company documents that only certain employees or users should access. One of these
        /// users leaves the company or switches to a team that should be blocked from accessing
        /// top-secret documents. The user still has access to top-secret documents because the
        /// user had access when your documents were previously indexed. You can create a specific
        /// access control configuration for the user with deny access. You can later update the
        /// access control configuration to allow access if the user returns to the company and
        /// re-joins the 'top-secret' team. You can re-configure access control for your documents
        /// as circumstances change.
        /// </para>
        ///  
        /// <para>
        /// To apply your access control configuration to certain documents, you call the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchPutDocument.html">BatchPutDocument</a>
        /// API with the <c>AccessControlConfigurationId</c> included in the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_Document.html">Document</a>
        /// object. If you use an S3 bucket as a data source, you update the <c>.metadata.json</c>
        /// with the <c>AccessControlConfigurationId</c> and synchronize your data source. Amazon
        /// Kendra currently only supports access control configuration for S3 data sources and
        /// documents indexed using the <c>BatchPutDocument</c> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessControlConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessControlConfiguration service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateAccessControlConfiguration">REST API Reference for CreateAccessControlConfiguration Operation</seealso>
        Task<CreateAccessControlConfigurationResponse> CreateAccessControlConfigurationAsync(CreateAccessControlConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDataSource


        /// <summary>
        /// Creates a data source connector that you want to use with an Amazon Kendra index.
        /// 
        ///  
        /// <para>
        /// You specify a name, data source connector type and description for your data source.
        /// You also specify configuration information for the data source connector.
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateDataSource</c> is a synchronous operation. The operation returns 200 if
        /// the data source was successfully created. Otherwise, an exception is raised.
        /// </para>
        ///  
        /// <para>
        /// For an example of creating an index and data source using the Python SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-python.html">Getting
        /// started with Python SDK</a>. For an example of creating an index and data source using
        /// the Java SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-java.html">Getting
        /// started with Java SDK</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request);



        /// <summary>
        /// Creates a data source connector that you want to use with an Amazon Kendra index.
        /// 
        ///  
        /// <para>
        /// You specify a name, data source connector type and description for your data source.
        /// You also specify configuration information for the data source connector.
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateDataSource</c> is a synchronous operation. The operation returns 200 if
        /// the data source was successfully created. Otherwise, an exception is raised.
        /// </para>
        ///  
        /// <para>
        /// For an example of creating an index and data source using the Python SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-python.html">Getting
        /// started with Python SDK</a>. For an example of creating an index and data source using
        /// the Java SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-java.html">Getting
        /// started with Java SDK</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateExperience


        /// <summary>
        /// Creates an Amazon Kendra experience such as a search application. For more information
        /// on creating a search application experience, including using the Python and Java SDKs,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperience service method.</param>
        /// 
        /// <returns>The response from the CreateExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateExperience">REST API Reference for CreateExperience Operation</seealso>
        CreateExperienceResponse CreateExperience(CreateExperienceRequest request);



        /// <summary>
        /// Creates an Amazon Kendra experience such as a search application. For more information
        /// on creating a search application experience, including using the Python and Java SDKs,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateExperience">REST API Reference for CreateExperience Operation</seealso>
        Task<CreateExperienceResponse> CreateExperienceAsync(CreateExperienceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFaq


        /// <summary>
        /// Creates a set of frequently ask questions (FAQs) using a specified FAQ file stored
        /// in an Amazon S3 bucket.
        /// 
        ///  
        /// <para>
        /// Adding FAQs to an index is an asynchronous operation.
        /// </para>
        ///  
        /// <para>
        /// For an example of adding an FAQ to an index using Python and Java SDKs, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/in-creating-faq.html#using-faq-file">Using
        /// your FAQ file</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFaq service method.</param>
        /// 
        /// <returns>The response from the CreateFaq service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateFaq">REST API Reference for CreateFaq Operation</seealso>
        CreateFaqResponse CreateFaq(CreateFaqRequest request);



        /// <summary>
        /// Creates a set of frequently ask questions (FAQs) using a specified FAQ file stored
        /// in an Amazon S3 bucket.
        /// 
        ///  
        /// <para>
        /// Adding FAQs to an index is an asynchronous operation.
        /// </para>
        ///  
        /// <para>
        /// For an example of adding an FAQ to an index using Python and Java SDKs, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/in-creating-faq.html#using-faq-file">Using
        /// your FAQ file</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFaq service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFaq service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateFaq">REST API Reference for CreateFaq Operation</seealso>
        Task<CreateFaqResponse> CreateFaqAsync(CreateFaqRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFeaturedResultsSet


        /// <summary>
        /// Creates a set of featured results to display at the top of the search results page.
        /// Featured results are placed above all other results for certain queries. You map specific
        /// queries to specific documents for featuring in the results. If a query contains an
        /// exact match, then one or more specific documents are featured in the search results.
        /// 
        ///  
        /// <para>
        /// You can create up to 50 sets of featured results per index. You can request to increase
        /// this limit by contacting <a href="http://aws.amazon.com/contact-us/">Support</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeaturedResultsSet service method.</param>
        /// 
        /// <returns>The response from the CreateFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.FeaturedResultsConflictException">
        /// An error message with a list of conflicting queries used across different sets of
        /// featured results. This occurred with the request for a new featured results set. Check
        /// that the queries you specified for featured results are unique per featured results
        /// set for each index.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateFeaturedResultsSet">REST API Reference for CreateFeaturedResultsSet Operation</seealso>
        CreateFeaturedResultsSetResponse CreateFeaturedResultsSet(CreateFeaturedResultsSetRequest request);



        /// <summary>
        /// Creates a set of featured results to display at the top of the search results page.
        /// Featured results are placed above all other results for certain queries. You map specific
        /// queries to specific documents for featuring in the results. If a query contains an
        /// exact match, then one or more specific documents are featured in the search results.
        /// 
        ///  
        /// <para>
        /// You can create up to 50 sets of featured results per index. You can request to increase
        /// this limit by contacting <a href="http://aws.amazon.com/contact-us/">Support</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeaturedResultsSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.FeaturedResultsConflictException">
        /// An error message with a list of conflicting queries used across different sets of
        /// featured results. This occurred with the request for a new featured results set. Check
        /// that the queries you specified for featured results are unique per featured results
        /// set for each index.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateFeaturedResultsSet">REST API Reference for CreateFeaturedResultsSet Operation</seealso>
        Task<CreateFeaturedResultsSetResponse> CreateFeaturedResultsSetAsync(CreateFeaturedResultsSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateIndex


        /// <summary>
        /// Creates an Amazon Kendra index. Index creation is an asynchronous API. To determine
        /// if index creation has completed, check the <c>Status</c> field returned from a call
        /// to <c>DescribeIndex</c>. The <c>Status</c> field is set to <c>ACTIVE</c> when the
        /// index is ready to use.
        /// 
        ///  
        /// <para>
        /// Once the index is active, you can index your documents using the <c>BatchPutDocument</c>
        /// API or using one of the supported <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-sources.html">data
        /// sources</a>.
        /// </para>
        ///  
        /// <para>
        /// For an example of creating an index and data source using the Python SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-python.html">Getting
        /// started with Python SDK</a>. For an example of creating an index and data source using
        /// the Java SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-java.html">Getting
        /// started with Java SDK</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
        /// 
        /// <returns>The response from the CreateIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        CreateIndexResponse CreateIndex(CreateIndexRequest request);



        /// <summary>
        /// Creates an Amazon Kendra index. Index creation is an asynchronous API. To determine
        /// if index creation has completed, check the <c>Status</c> field returned from a call
        /// to <c>DescribeIndex</c>. The <c>Status</c> field is set to <c>ACTIVE</c> when the
        /// index is ready to use.
        /// 
        ///  
        /// <para>
        /// Once the index is active, you can index your documents using the <c>BatchPutDocument</c>
        /// API or using one of the supported <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-sources.html">data
        /// sources</a>.
        /// </para>
        ///  
        /// <para>
        /// For an example of creating an index and data source using the Python SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-python.html">Getting
        /// started with Python SDK</a>. For an example of creating an index and data source using
        /// the Java SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-java.html">Getting
        /// started with Java SDK</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceAlreadyExistException">
        /// The resource you want to use already exists. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        Task<CreateIndexResponse> CreateIndexAsync(CreateIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateQuerySuggestionsBlockList


        /// <summary>
        /// Creates a block list to exlcude certain queries from suggestions.
        /// 
        ///  
        /// <para>
        /// Any query that contains words or phrases specified in the block list is blocked or
        /// filtered out from being shown as a suggestion.
        /// </para>
        ///  
        /// <para>
        /// You need to provide the file location of your block list text file in your S3 bucket.
        /// In your text file, enter each block word or phrase on a separate line.
        /// </para>
        ///  
        /// <para>
        /// For information on the current quota limits for block lists, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas
        /// for Amazon Kendra</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateQuerySuggestionsBlockList</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        ///  
        /// <para>
        /// For an example of creating a block list for query suggestions using the Python SDK,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/query-suggestions.html#query-suggestions-blocklist">Query
        /// suggestions block list</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuerySuggestionsBlockList service method.</param>
        /// 
        /// <returns>The response from the CreateQuerySuggestionsBlockList service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateQuerySuggestionsBlockList">REST API Reference for CreateQuerySuggestionsBlockList Operation</seealso>
        CreateQuerySuggestionsBlockListResponse CreateQuerySuggestionsBlockList(CreateQuerySuggestionsBlockListRequest request);



        /// <summary>
        /// Creates a block list to exlcude certain queries from suggestions.
        /// 
        ///  
        /// <para>
        /// Any query that contains words or phrases specified in the block list is blocked or
        /// filtered out from being shown as a suggestion.
        /// </para>
        ///  
        /// <para>
        /// You need to provide the file location of your block list text file in your S3 bucket.
        /// In your text file, enter each block word or phrase on a separate line.
        /// </para>
        ///  
        /// <para>
        /// For information on the current quota limits for block lists, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas
        /// for Amazon Kendra</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateQuerySuggestionsBlockList</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        ///  
        /// <para>
        /// For an example of creating a block list for query suggestions using the Python SDK,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/query-suggestions.html#query-suggestions-blocklist">Query
        /// suggestions block list</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuerySuggestionsBlockList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQuerySuggestionsBlockList service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateQuerySuggestionsBlockList">REST API Reference for CreateQuerySuggestionsBlockList Operation</seealso>
        Task<CreateQuerySuggestionsBlockListResponse> CreateQuerySuggestionsBlockListAsync(CreateQuerySuggestionsBlockListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateThesaurus


        /// <summary>
        /// Creates a thesaurus for an index. The thesaurus contains a list of synonyms in Solr
        /// format.
        /// 
        ///  
        /// <para>
        /// For an example of adding a thesaurus file to an index, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/index-synonyms-adding-thesaurus-file.html">Adding
        /// custom synonyms to an index</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThesaurus service method.</param>
        /// 
        /// <returns>The response from the CreateThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateThesaurus">REST API Reference for CreateThesaurus Operation</seealso>
        CreateThesaurusResponse CreateThesaurus(CreateThesaurusRequest request);



        /// <summary>
        /// Creates a thesaurus for an index. The thesaurus contains a list of synonyms in Solr
        /// format.
        /// 
        ///  
        /// <para>
        /// For an example of adding a thesaurus file to an index, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/index-synonyms-adding-thesaurus-file.html">Adding
        /// custom synonyms to an index</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThesaurus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/CreateThesaurus">REST API Reference for CreateThesaurus Operation</seealso>
        Task<CreateThesaurusResponse> CreateThesaurusAsync(CreateThesaurusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAccessControlConfiguration


        /// <summary>
        /// Deletes an access control configuration that you created for your documents in an
        /// index. This includes user and group access information for your documents. This is
        /// useful for user context filtering, where search results are filtered based on the
        /// user or their group access to documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessControlConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessControlConfiguration service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteAccessControlConfiguration">REST API Reference for DeleteAccessControlConfiguration Operation</seealso>
        DeleteAccessControlConfigurationResponse DeleteAccessControlConfiguration(DeleteAccessControlConfigurationRequest request);



        /// <summary>
        /// Deletes an access control configuration that you created for your documents in an
        /// index. This includes user and group access information for your documents. This is
        /// useful for user context filtering, where search results are filtered based on the
        /// user or their group access to documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessControlConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessControlConfiguration service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteAccessControlConfiguration">REST API Reference for DeleteAccessControlConfiguration Operation</seealso>
        Task<DeleteAccessControlConfigurationResponse> DeleteAccessControlConfigurationAsync(DeleteAccessControlConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDataSource


        /// <summary>
        /// Deletes an Amazon Kendra data source connector. An exception is not thrown if the
        /// data source is already being deleted. While the data source is being deleted, the
        /// <c>Status</c> field returned by a call to the <c>DescribeDataSource</c> API is set
        /// to <c>DELETING</c>. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/delete-data-source.html">Deleting
        /// Data Sources</a>.
        /// 
        ///  
        /// <para>
        /// Deleting an entire data source or re-syncing your index after deleting specific documents
        /// from a data source could take up to an hour or more, depending on the number of documents
        /// you want to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request);



        /// <summary>
        /// Deletes an Amazon Kendra data source connector. An exception is not thrown if the
        /// data source is already being deleted. While the data source is being deleted, the
        /// <c>Status</c> field returned by a call to the <c>DescribeDataSource</c> API is set
        /// to <c>DELETING</c>. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/delete-data-source.html">Deleting
        /// Data Sources</a>.
        /// 
        ///  
        /// <para>
        /// Deleting an entire data source or re-syncing your index after deleting specific documents
        /// from a data source could take up to an hour or more, depending on the number of documents
        /// you want to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteExperience


        /// <summary>
        /// Deletes your Amazon Kendra experience such as a search application. For more information
        /// on creating a search application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperience service method.</param>
        /// 
        /// <returns>The response from the DeleteExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteExperience">REST API Reference for DeleteExperience Operation</seealso>
        DeleteExperienceResponse DeleteExperience(DeleteExperienceRequest request);



        /// <summary>
        /// Deletes your Amazon Kendra experience such as a search application. For more information
        /// on creating a search application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteExperience">REST API Reference for DeleteExperience Operation</seealso>
        Task<DeleteExperienceResponse> DeleteExperienceAsync(DeleteExperienceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFaq


        /// <summary>
        /// Removes an FAQ from an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFaq service method.</param>
        /// 
        /// <returns>The response from the DeleteFaq service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteFaq">REST API Reference for DeleteFaq Operation</seealso>
        DeleteFaqResponse DeleteFaq(DeleteFaqRequest request);



        /// <summary>
        /// Removes an FAQ from an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFaq service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFaq service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteFaq">REST API Reference for DeleteFaq Operation</seealso>
        Task<DeleteFaqResponse> DeleteFaqAsync(DeleteFaqRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIndex


        /// <summary>
        /// Deletes an Amazon Kendra index. An exception is not thrown if the index is already
        /// being deleted. While the index is being deleted, the <c>Status</c> field returned
        /// by a call to the <c>DescribeIndex</c> API is set to <c>DELETING</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex service method.</param>
        /// 
        /// <returns>The response from the DeleteIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        DeleteIndexResponse DeleteIndex(DeleteIndexRequest request);



        /// <summary>
        /// Deletes an Amazon Kendra index. An exception is not thrown if the index is already
        /// being deleted. While the index is being deleted, the <c>Status</c> field returned
        /// by a call to the <c>DescribeIndex</c> API is set to <c>DELETING</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        Task<DeleteIndexResponse> DeleteIndexAsync(DeleteIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePrincipalMapping


        /// <summary>
        /// Deletes a group so that all users and sub groups that belong to the group can no longer
        /// access documents only available to that group.
        /// 
        ///  
        /// <para>
        /// For example, after deleting the group "Summer Interns", all interns who belonged to
        /// that group no longer see intern-only documents in their search results.
        /// </para>
        ///  
        /// <para>
        /// If you want to delete or replace users or sub groups of a group, you need to use the
        /// <c>PutPrincipalMapping</c> operation. For example, if a user in the group "Engineering"
        /// leaves the engineering team and another user takes their place, you provide an updated
        /// list of users or sub groups that belong to the "Engineering" group when calling <c>PutPrincipalMapping</c>.
        /// You can update your internal list of users or sub groups and input this list when
        /// calling <c>PutPrincipalMapping</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>DeletePrincipalMapping</c> is currently not supported in the Amazon Web Services
        /// GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrincipalMapping service method.</param>
        /// 
        /// <returns>The response from the DeletePrincipalMapping service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeletePrincipalMapping">REST API Reference for DeletePrincipalMapping Operation</seealso>
        DeletePrincipalMappingResponse DeletePrincipalMapping(DeletePrincipalMappingRequest request);



        /// <summary>
        /// Deletes a group so that all users and sub groups that belong to the group can no longer
        /// access documents only available to that group.
        /// 
        ///  
        /// <para>
        /// For example, after deleting the group "Summer Interns", all interns who belonged to
        /// that group no longer see intern-only documents in their search results.
        /// </para>
        ///  
        /// <para>
        /// If you want to delete or replace users or sub groups of a group, you need to use the
        /// <c>PutPrincipalMapping</c> operation. For example, if a user in the group "Engineering"
        /// leaves the engineering team and another user takes their place, you provide an updated
        /// list of users or sub groups that belong to the "Engineering" group when calling <c>PutPrincipalMapping</c>.
        /// You can update your internal list of users or sub groups and input this list when
        /// calling <c>PutPrincipalMapping</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>DeletePrincipalMapping</c> is currently not supported in the Amazon Web Services
        /// GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrincipalMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePrincipalMapping service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeletePrincipalMapping">REST API Reference for DeletePrincipalMapping Operation</seealso>
        Task<DeletePrincipalMappingResponse> DeletePrincipalMappingAsync(DeletePrincipalMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteQuerySuggestionsBlockList


        /// <summary>
        /// Deletes a block list used for query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// A deleted block list might not take effect right away. Amazon Kendra needs to refresh
        /// the entire suggestions list to add back the queries that were previously blocked.
        /// </para>
        ///  
        /// <para>
        ///  <c>DeleteQuerySuggestionsBlockList</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuerySuggestionsBlockList service method.</param>
        /// 
        /// <returns>The response from the DeleteQuerySuggestionsBlockList service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteQuerySuggestionsBlockList">REST API Reference for DeleteQuerySuggestionsBlockList Operation</seealso>
        DeleteQuerySuggestionsBlockListResponse DeleteQuerySuggestionsBlockList(DeleteQuerySuggestionsBlockListRequest request);



        /// <summary>
        /// Deletes a block list used for query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// A deleted block list might not take effect right away. Amazon Kendra needs to refresh
        /// the entire suggestions list to add back the queries that were previously blocked.
        /// </para>
        ///  
        /// <para>
        ///  <c>DeleteQuerySuggestionsBlockList</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuerySuggestionsBlockList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQuerySuggestionsBlockList service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteQuerySuggestionsBlockList">REST API Reference for DeleteQuerySuggestionsBlockList Operation</seealso>
        Task<DeleteQuerySuggestionsBlockListResponse> DeleteQuerySuggestionsBlockListAsync(DeleteQuerySuggestionsBlockListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteThesaurus


        /// <summary>
        /// Deletes an Amazon Kendra thesaurus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThesaurus service method.</param>
        /// 
        /// <returns>The response from the DeleteThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteThesaurus">REST API Reference for DeleteThesaurus Operation</seealso>
        DeleteThesaurusResponse DeleteThesaurus(DeleteThesaurusRequest request);



        /// <summary>
        /// Deletes an Amazon Kendra thesaurus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThesaurus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DeleteThesaurus">REST API Reference for DeleteThesaurus Operation</seealso>
        Task<DeleteThesaurusResponse> DeleteThesaurusAsync(DeleteThesaurusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAccessControlConfiguration


        /// <summary>
        /// Gets information about an access control configuration that you created for your documents
        /// in an index. This includes user and group access information for your documents. This
        /// is useful for user context filtering, where search results are filtered based on the
        /// user or their group access to documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessControlConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeAccessControlConfiguration service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeAccessControlConfiguration">REST API Reference for DescribeAccessControlConfiguration Operation</seealso>
        DescribeAccessControlConfigurationResponse DescribeAccessControlConfiguration(DescribeAccessControlConfigurationRequest request);



        /// <summary>
        /// Gets information about an access control configuration that you created for your documents
        /// in an index. This includes user and group access information for your documents. This
        /// is useful for user context filtering, where search results are filtered based on the
        /// user or their group access to documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessControlConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccessControlConfiguration service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeAccessControlConfiguration">REST API Reference for DescribeAccessControlConfiguration Operation</seealso>
        Task<DescribeAccessControlConfigurationResponse> DescribeAccessControlConfigurationAsync(DescribeAccessControlConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDataSource


        /// <summary>
        /// Gets information about an Amazon Kendra data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        DescribeDataSourceResponse DescribeDataSource(DescribeDataSourceRequest request);



        /// <summary>
        /// Gets information about an Amazon Kendra data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeDataSource">REST API Reference for DescribeDataSource Operation</seealso>
        Task<DescribeDataSourceResponse> DescribeDataSourceAsync(DescribeDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeExperience


        /// <summary>
        /// Gets information about your Amazon Kendra experience such as a search application.
        /// For more information on creating a search application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExperience service method.</param>
        /// 
        /// <returns>The response from the DescribeExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeExperience">REST API Reference for DescribeExperience Operation</seealso>
        DescribeExperienceResponse DescribeExperience(DescribeExperienceRequest request);



        /// <summary>
        /// Gets information about your Amazon Kendra experience such as a search application.
        /// For more information on creating a search application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeExperience">REST API Reference for DescribeExperience Operation</seealso>
        Task<DescribeExperienceResponse> DescribeExperienceAsync(DescribeExperienceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFaq


        /// <summary>
        /// Gets information about an FAQ list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFaq service method.</param>
        /// 
        /// <returns>The response from the DescribeFaq service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeFaq">REST API Reference for DescribeFaq Operation</seealso>
        DescribeFaqResponse DescribeFaq(DescribeFaqRequest request);



        /// <summary>
        /// Gets information about an FAQ list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFaq service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFaq service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeFaq">REST API Reference for DescribeFaq Operation</seealso>
        Task<DescribeFaqResponse> DescribeFaqAsync(DescribeFaqRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFeaturedResultsSet


        /// <summary>
        /// Gets information about a set of featured results. Features results are placed above
        /// all other results for certain queries. If there's an exact match of a query, then
        /// one or more specific documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeaturedResultsSet service method.</param>
        /// 
        /// <returns>The response from the DescribeFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeFeaturedResultsSet">REST API Reference for DescribeFeaturedResultsSet Operation</seealso>
        DescribeFeaturedResultsSetResponse DescribeFeaturedResultsSet(DescribeFeaturedResultsSetRequest request);



        /// <summary>
        /// Gets information about a set of featured results. Features results are placed above
        /// all other results for certain queries. If there's an exact match of a query, then
        /// one or more specific documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFeaturedResultsSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeFeaturedResultsSet">REST API Reference for DescribeFeaturedResultsSet Operation</seealso>
        Task<DescribeFeaturedResultsSetResponse> DescribeFeaturedResultsSetAsync(DescribeFeaturedResultsSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeIndex


        /// <summary>
        /// Gets information about an Amazon Kendra index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndex service method.</param>
        /// 
        /// <returns>The response from the DescribeIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeIndex">REST API Reference for DescribeIndex Operation</seealso>
        DescribeIndexResponse DescribeIndex(DescribeIndexRequest request);



        /// <summary>
        /// Gets information about an Amazon Kendra index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeIndex">REST API Reference for DescribeIndex Operation</seealso>
        Task<DescribeIndexResponse> DescribeIndexAsync(DescribeIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePrincipalMapping


        /// <summary>
        /// Describes the processing of <c>PUT</c> and <c>DELETE</c> actions for mapping users
        /// to their groups. This includes information on the status of actions currently processing
        /// or yet to be processed, when actions were last updated, when actions were received
        /// by Amazon Kendra, the latest action that should process and apply after other actions,
        /// and useful error messages if an action could not be processed.
        /// 
        ///  
        /// <para>
        ///  <c>DescribePrincipalMapping</c> is currently not supported in the Amazon Web Services
        /// GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrincipalMapping service method.</param>
        /// 
        /// <returns>The response from the DescribePrincipalMapping service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribePrincipalMapping">REST API Reference for DescribePrincipalMapping Operation</seealso>
        DescribePrincipalMappingResponse DescribePrincipalMapping(DescribePrincipalMappingRequest request);



        /// <summary>
        /// Describes the processing of <c>PUT</c> and <c>DELETE</c> actions for mapping users
        /// to their groups. This includes information on the status of actions currently processing
        /// or yet to be processed, when actions were last updated, when actions were received
        /// by Amazon Kendra, the latest action that should process and apply after other actions,
        /// and useful error messages if an action could not be processed.
        /// 
        ///  
        /// <para>
        ///  <c>DescribePrincipalMapping</c> is currently not supported in the Amazon Web Services
        /// GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrincipalMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePrincipalMapping service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribePrincipalMapping">REST API Reference for DescribePrincipalMapping Operation</seealso>
        Task<DescribePrincipalMappingResponse> DescribePrincipalMappingAsync(DescribePrincipalMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeQuerySuggestionsBlockList


        /// <summary>
        /// Gets information about a block list used for query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// This is used to check the current settings that are applied to a block list.
        /// </para>
        ///  
        /// <para>
        ///  <c>DescribeQuerySuggestionsBlockList</c> is currently not supported in the Amazon
        /// Web Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuerySuggestionsBlockList service method.</param>
        /// 
        /// <returns>The response from the DescribeQuerySuggestionsBlockList service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeQuerySuggestionsBlockList">REST API Reference for DescribeQuerySuggestionsBlockList Operation</seealso>
        DescribeQuerySuggestionsBlockListResponse DescribeQuerySuggestionsBlockList(DescribeQuerySuggestionsBlockListRequest request);



        /// <summary>
        /// Gets information about a block list used for query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// This is used to check the current settings that are applied to a block list.
        /// </para>
        ///  
        /// <para>
        ///  <c>DescribeQuerySuggestionsBlockList</c> is currently not supported in the Amazon
        /// Web Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuerySuggestionsBlockList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQuerySuggestionsBlockList service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeQuerySuggestionsBlockList">REST API Reference for DescribeQuerySuggestionsBlockList Operation</seealso>
        Task<DescribeQuerySuggestionsBlockListResponse> DescribeQuerySuggestionsBlockListAsync(DescribeQuerySuggestionsBlockListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeQuerySuggestionsConfig


        /// <summary>
        /// Gets information on the settings of query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// This is used to check the current settings applied to query suggestions.
        /// </para>
        ///  
        /// <para>
        ///  <c>DescribeQuerySuggestionsConfig</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuerySuggestionsConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeQuerySuggestionsConfig service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeQuerySuggestionsConfig">REST API Reference for DescribeQuerySuggestionsConfig Operation</seealso>
        DescribeQuerySuggestionsConfigResponse DescribeQuerySuggestionsConfig(DescribeQuerySuggestionsConfigRequest request);



        /// <summary>
        /// Gets information on the settings of query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// This is used to check the current settings applied to query suggestions.
        /// </para>
        ///  
        /// <para>
        ///  <c>DescribeQuerySuggestionsConfig</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuerySuggestionsConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQuerySuggestionsConfig service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeQuerySuggestionsConfig">REST API Reference for DescribeQuerySuggestionsConfig Operation</seealso>
        Task<DescribeQuerySuggestionsConfigResponse> DescribeQuerySuggestionsConfigAsync(DescribeQuerySuggestionsConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeThesaurus


        /// <summary>
        /// Gets information about an Amazon Kendra thesaurus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThesaurus service method.</param>
        /// 
        /// <returns>The response from the DescribeThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeThesaurus">REST API Reference for DescribeThesaurus Operation</seealso>
        DescribeThesaurusResponse DescribeThesaurus(DescribeThesaurusRequest request);



        /// <summary>
        /// Gets information about an Amazon Kendra thesaurus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThesaurus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DescribeThesaurus">REST API Reference for DescribeThesaurus Operation</seealso>
        Task<DescribeThesaurusResponse> DescribeThesaurusAsync(DescribeThesaurusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateEntitiesFromExperience


        /// <summary>
        /// Prevents users or groups in your IAM Identity Center identity source from accessing
        /// your Amazon Kendra experience. You can create an Amazon Kendra experience such as
        /// a search application. For more information on creating a search application experience,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateEntitiesFromExperience service method.</param>
        /// 
        /// <returns>The response from the DisassociateEntitiesFromExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DisassociateEntitiesFromExperience">REST API Reference for DisassociateEntitiesFromExperience Operation</seealso>
        DisassociateEntitiesFromExperienceResponse DisassociateEntitiesFromExperience(DisassociateEntitiesFromExperienceRequest request);



        /// <summary>
        /// Prevents users or groups in your IAM Identity Center identity source from accessing
        /// your Amazon Kendra experience. You can create an Amazon Kendra experience such as
        /// a search application. For more information on creating a search application experience,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateEntitiesFromExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateEntitiesFromExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DisassociateEntitiesFromExperience">REST API Reference for DisassociateEntitiesFromExperience Operation</seealso>
        Task<DisassociateEntitiesFromExperienceResponse> DisassociateEntitiesFromExperienceAsync(DisassociateEntitiesFromExperienceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociatePersonasFromEntities


        /// <summary>
        /// Removes the specific permissions of users or groups in your IAM Identity Center identity
        /// source with access to your Amazon Kendra experience. You can create an Amazon Kendra
        /// experience such as a search application. For more information on creating a search
        /// application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePersonasFromEntities service method.</param>
        /// 
        /// <returns>The response from the DisassociatePersonasFromEntities service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DisassociatePersonasFromEntities">REST API Reference for DisassociatePersonasFromEntities Operation</seealso>
        DisassociatePersonasFromEntitiesResponse DisassociatePersonasFromEntities(DisassociatePersonasFromEntitiesRequest request);



        /// <summary>
        /// Removes the specific permissions of users or groups in your IAM Identity Center identity
        /// source with access to your Amazon Kendra experience. You can create an Amazon Kendra
        /// experience such as a search application. For more information on creating a search
        /// application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePersonasFromEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociatePersonasFromEntities service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/DisassociatePersonasFromEntities">REST API Reference for DisassociatePersonasFromEntities Operation</seealso>
        Task<DisassociatePersonasFromEntitiesResponse> DisassociatePersonasFromEntitiesAsync(DisassociatePersonasFromEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetQuerySuggestions


        /// <summary>
        /// Fetches the queries that are suggested to your users.
        /// 
        ///  
        /// <para>
        ///  <c>GetQuerySuggestions</c> is currently not supported in the Amazon Web Services
        /// GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuerySuggestions service method.</param>
        /// 
        /// <returns>The response from the GetQuerySuggestions service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/GetQuerySuggestions">REST API Reference for GetQuerySuggestions Operation</seealso>
        GetQuerySuggestionsResponse GetQuerySuggestions(GetQuerySuggestionsRequest request);



        /// <summary>
        /// Fetches the queries that are suggested to your users.
        /// 
        ///  
        /// <para>
        ///  <c>GetQuerySuggestions</c> is currently not supported in the Amazon Web Services
        /// GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuerySuggestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQuerySuggestions service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/GetQuerySuggestions">REST API Reference for GetQuerySuggestions Operation</seealso>
        Task<GetQuerySuggestionsResponse> GetQuerySuggestionsAsync(GetQuerySuggestionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSnapshots


        /// <summary>
        /// Retrieves search metrics data. The data provides a snapshot of how your users interact
        /// with your search application and how effective the application is.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshots service method.</param>
        /// 
        /// <returns>The response from the GetSnapshots service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InvalidRequestException">
        /// The input to the request is not valid. Please provide the correct input and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/GetSnapshots">REST API Reference for GetSnapshots Operation</seealso>
        GetSnapshotsResponse GetSnapshots(GetSnapshotsRequest request);



        /// <summary>
        /// Retrieves search metrics data. The data provides a snapshot of how your users interact
        /// with your search application and how effective the application is.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSnapshots service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InvalidRequestException">
        /// The input to the request is not valid. Please provide the correct input and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/GetSnapshots">REST API Reference for GetSnapshots Operation</seealso>
        Task<GetSnapshotsResponse> GetSnapshotsAsync(GetSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAccessControlConfigurations


        /// <summary>
        /// Lists one or more access control configurations for an index. This includes user and
        /// group access information for your documents. This is useful for user context filtering,
        /// where search results are filtered based on the user or their group access to documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessControlConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListAccessControlConfigurations service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListAccessControlConfigurations">REST API Reference for ListAccessControlConfigurations Operation</seealso>
        ListAccessControlConfigurationsResponse ListAccessControlConfigurations(ListAccessControlConfigurationsRequest request);



        /// <summary>
        /// Lists one or more access control configurations for an index. This includes user and
        /// group access information for your documents. This is useful for user context filtering,
        /// where search results are filtered based on the user or their group access to documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessControlConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessControlConfigurations service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListAccessControlConfigurations">REST API Reference for ListAccessControlConfigurations Operation</seealso>
        Task<ListAccessControlConfigurationsResponse> ListAccessControlConfigurationsAsync(ListAccessControlConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDataSources


        /// <summary>
        /// Lists the data source connectors that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request);



        /// <summary>
        /// Lists the data source connectors that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDataSourceSyncJobs


        /// <summary>
        /// Gets statistics about synchronizing a data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceSyncJobs service method.</param>
        /// 
        /// <returns>The response from the ListDataSourceSyncJobs service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListDataSourceSyncJobs">REST API Reference for ListDataSourceSyncJobs Operation</seealso>
        ListDataSourceSyncJobsResponse ListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request);



        /// <summary>
        /// Gets statistics about synchronizing a data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceSyncJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSourceSyncJobs service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListDataSourceSyncJobs">REST API Reference for ListDataSourceSyncJobs Operation</seealso>
        Task<ListDataSourceSyncJobsResponse> ListDataSourceSyncJobsAsync(ListDataSourceSyncJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEntityPersonas


        /// <summary>
        /// Lists specific permissions of users and groups with access to your Amazon Kendra experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntityPersonas service method.</param>
        /// 
        /// <returns>The response from the ListEntityPersonas service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListEntityPersonas">REST API Reference for ListEntityPersonas Operation</seealso>
        ListEntityPersonasResponse ListEntityPersonas(ListEntityPersonasRequest request);



        /// <summary>
        /// Lists specific permissions of users and groups with access to your Amazon Kendra experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntityPersonas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntityPersonas service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListEntityPersonas">REST API Reference for ListEntityPersonas Operation</seealso>
        Task<ListEntityPersonasResponse> ListEntityPersonasAsync(ListEntityPersonasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListExperienceEntities


        /// <summary>
        /// Lists users or groups in your IAM Identity Center identity source that are granted
        /// access to your Amazon Kendra experience. You can create an Amazon Kendra experience
        /// such as a search application. For more information on creating a search application
        /// experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperienceEntities service method.</param>
        /// 
        /// <returns>The response from the ListExperienceEntities service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListExperienceEntities">REST API Reference for ListExperienceEntities Operation</seealso>
        ListExperienceEntitiesResponse ListExperienceEntities(ListExperienceEntitiesRequest request);



        /// <summary>
        /// Lists users or groups in your IAM Identity Center identity source that are granted
        /// access to your Amazon Kendra experience. You can create an Amazon Kendra experience
        /// such as a search application. For more information on creating a search application
        /// experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperienceEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperienceEntities service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListExperienceEntities">REST API Reference for ListExperienceEntities Operation</seealso>
        Task<ListExperienceEntitiesResponse> ListExperienceEntitiesAsync(ListExperienceEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListExperiences


        /// <summary>
        /// Lists one or more Amazon Kendra experiences. You can create an Amazon Kendra experience
        /// such as a search application. For more information on creating a search application
        /// experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiences service method.</param>
        /// 
        /// <returns>The response from the ListExperiences service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListExperiences">REST API Reference for ListExperiences Operation</seealso>
        ListExperiencesResponse ListExperiences(ListExperiencesRequest request);



        /// <summary>
        /// Lists one or more Amazon Kendra experiences. You can create an Amazon Kendra experience
        /// such as a search application. For more information on creating a search application
        /// experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperiences service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListExperiences">REST API Reference for ListExperiences Operation</seealso>
        Task<ListExperiencesResponse> ListExperiencesAsync(ListExperiencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFaqs


        /// <summary>
        /// Gets a list of FAQ lists associated with an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFaqs service method.</param>
        /// 
        /// <returns>The response from the ListFaqs service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListFaqs">REST API Reference for ListFaqs Operation</seealso>
        ListFaqsResponse ListFaqs(ListFaqsRequest request);



        /// <summary>
        /// Gets a list of FAQ lists associated with an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFaqs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFaqs service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListFaqs">REST API Reference for ListFaqs Operation</seealso>
        Task<ListFaqsResponse> ListFaqsAsync(ListFaqsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFeaturedResultsSets


        /// <summary>
        /// Lists all your sets of featured results for a given index. Features results are placed
        /// above all other results for certain queries. If there's an exact match of a query,
        /// then one or more specific documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeaturedResultsSets service method.</param>
        /// 
        /// <returns>The response from the ListFeaturedResultsSets service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListFeaturedResultsSets">REST API Reference for ListFeaturedResultsSets Operation</seealso>
        ListFeaturedResultsSetsResponse ListFeaturedResultsSets(ListFeaturedResultsSetsRequest request);



        /// <summary>
        /// Lists all your sets of featured results for a given index. Features results are placed
        /// above all other results for certain queries. If there's an exact match of a query,
        /// then one or more specific documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeaturedResultsSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFeaturedResultsSets service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListFeaturedResultsSets">REST API Reference for ListFeaturedResultsSets Operation</seealso>
        Task<ListFeaturedResultsSetsResponse> ListFeaturedResultsSetsAsync(ListFeaturedResultsSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroupsOlderThanOrderingId


        /// <summary>
        /// Provides a list of groups that are mapped to users before a given ordering or timestamp
        /// identifier.
        /// 
        ///  
        /// <para>
        ///  <c>ListGroupsOlderThanOrderingId</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsOlderThanOrderingId service method.</param>
        /// 
        /// <returns>The response from the ListGroupsOlderThanOrderingId service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListGroupsOlderThanOrderingId">REST API Reference for ListGroupsOlderThanOrderingId Operation</seealso>
        ListGroupsOlderThanOrderingIdResponse ListGroupsOlderThanOrderingId(ListGroupsOlderThanOrderingIdRequest request);



        /// <summary>
        /// Provides a list of groups that are mapped to users before a given ordering or timestamp
        /// identifier.
        /// 
        ///  
        /// <para>
        ///  <c>ListGroupsOlderThanOrderingId</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsOlderThanOrderingId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupsOlderThanOrderingId service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListGroupsOlderThanOrderingId">REST API Reference for ListGroupsOlderThanOrderingId Operation</seealso>
        Task<ListGroupsOlderThanOrderingIdResponse> ListGroupsOlderThanOrderingIdAsync(ListGroupsOlderThanOrderingIdRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIndices


        /// <summary>
        /// Lists the Amazon Kendra indexes that you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndices service method.</param>
        /// 
        /// <returns>The response from the ListIndices service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListIndices">REST API Reference for ListIndices Operation</seealso>
        ListIndicesResponse ListIndices(ListIndicesRequest request);



        /// <summary>
        /// Lists the Amazon Kendra indexes that you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIndices service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListIndices">REST API Reference for ListIndices Operation</seealso>
        Task<ListIndicesResponse> ListIndicesAsync(ListIndicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListQuerySuggestionsBlockLists


        /// <summary>
        /// Lists the block lists used for query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// For information on the current quota limits for block lists, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas
        /// for Amazon Kendra</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>ListQuerySuggestionsBlockLists</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuerySuggestionsBlockLists service method.</param>
        /// 
        /// <returns>The response from the ListQuerySuggestionsBlockLists service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListQuerySuggestionsBlockLists">REST API Reference for ListQuerySuggestionsBlockLists Operation</seealso>
        ListQuerySuggestionsBlockListsResponse ListQuerySuggestionsBlockLists(ListQuerySuggestionsBlockListsRequest request);



        /// <summary>
        /// Lists the block lists used for query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// For information on the current quota limits for block lists, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas
        /// for Amazon Kendra</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>ListQuerySuggestionsBlockLists</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuerySuggestionsBlockLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQuerySuggestionsBlockLists service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListQuerySuggestionsBlockLists">REST API Reference for ListQuerySuggestionsBlockLists Operation</seealso>
        Task<ListQuerySuggestionsBlockListsResponse> ListQuerySuggestionsBlockListsAsync(ListQuerySuggestionsBlockListsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets a list of tags associated with a specified resource. Indexes, FAQs, and data
        /// sources can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// The resource you want to use isn't available. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Gets a list of tags associated with a specified resource. Indexes, FAQs, and data
        /// sources can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// The resource you want to use isn't available. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListThesauri


        /// <summary>
        /// Lists the thesauri for an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThesauri service method.</param>
        /// 
        /// <returns>The response from the ListThesauri service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListThesauri">REST API Reference for ListThesauri Operation</seealso>
        ListThesauriResponse ListThesauri(ListThesauriRequest request);



        /// <summary>
        /// Lists the thesauri for an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThesauri service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThesauri service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/ListThesauri">REST API Reference for ListThesauri Operation</seealso>
        Task<ListThesauriResponse> ListThesauriAsync(ListThesauriRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutPrincipalMapping


        /// <summary>
        /// Maps users to their groups so that you only need to provide the user ID when you issue
        /// the query.
        /// 
        ///  
        /// <para>
        /// You can also map sub groups to groups. For example, the group "Company Intellectual
        /// Property Teams" includes sub groups "Research" and "Engineering". These sub groups
        /// include their own list of users or people who work in these teams. Only users who
        /// work in research and engineering, and therefore belong in the intellectual property
        /// group, can see top-secret company documents in their search results.
        /// </para>
        ///  
        /// <para>
        /// This is useful for user context filtering, where search results are filtered based
        /// on the user or their group access to documents. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/user-context-filter.html">Filtering
        /// on user context</a>.
        /// </para>
        ///  
        /// <para>
        /// If more than five <c>PUT</c> actions for a group are currently processing, a validation
        /// exception is thrown.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPrincipalMapping service method.</param>
        /// 
        /// <returns>The response from the PutPrincipalMapping service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/PutPrincipalMapping">REST API Reference for PutPrincipalMapping Operation</seealso>
        PutPrincipalMappingResponse PutPrincipalMapping(PutPrincipalMappingRequest request);



        /// <summary>
        /// Maps users to their groups so that you only need to provide the user ID when you issue
        /// the query.
        /// 
        ///  
        /// <para>
        /// You can also map sub groups to groups. For example, the group "Company Intellectual
        /// Property Teams" includes sub groups "Research" and "Engineering". These sub groups
        /// include their own list of users or people who work in these teams. Only users who
        /// work in research and engineering, and therefore belong in the intellectual property
        /// group, can see top-secret company documents in their search results.
        /// </para>
        ///  
        /// <para>
        /// This is useful for user context filtering, where search results are filtered based
        /// on the user or their group access to documents. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/user-context-filter.html">Filtering
        /// on user context</a>.
        /// </para>
        ///  
        /// <para>
        /// If more than five <c>PUT</c> actions for a group are currently processing, a validation
        /// exception is thrown.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPrincipalMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPrincipalMapping service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/PutPrincipalMapping">REST API Reference for PutPrincipalMapping Operation</seealso>
        Task<PutPrincipalMappingResponse> PutPrincipalMappingAsync(PutPrincipalMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Query


        /// <summary>
        /// Searches an index given an input query.
        /// 
        ///  <note> 
        /// <para>
        /// If you are working with large language models (LLMs) or implementing retrieval augmented
        /// generation (RAG) systems, you can use Amazon Kendra's <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_Retrieve.html">Retrieve</a>
        /// API, which can return longer semantically relevant passages. We recommend using the
        /// <c>Retrieve</c> API instead of filing a service limit increase to increase the <c>Query</c>
        /// API document excerpt length.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can configure boosting or relevance tuning at the query level to override boosting
        /// at the index level, filter based on document fields/attributes and faceted search,
        /// and filter based on the user or their group access to documents. You can also include
        /// certain fields in the response that might provide useful additional information.
        /// </para>
        ///  
        /// <para>
        /// A query response contains three types of results.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Relevant suggested answers. The answers can be either a text excerpt or table excerpt.
        /// The answer can be highlighted in the excerpt.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Matching FAQs or questions-answer from your FAQ file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Relevant documents. This result type includes an excerpt of the document with the
        /// document title. The searched terms can be highlighted in the excerpt.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify that the query return only one type of result using the <c>QueryResultTypeFilter</c>
        /// parameter. Each query returns the 100 most relevant results. If you filter result
        /// type to only question-answers, a maximum of four results are returned. If you filter
        /// result type to only answers, a maximum of three results are returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Query service method.</param>
        /// 
        /// <returns>The response from the Query service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/Query">REST API Reference for Query Operation</seealso>
        QueryResponse Query(QueryRequest request);



        /// <summary>
        /// Searches an index given an input query.
        /// 
        ///  <note> 
        /// <para>
        /// If you are working with large language models (LLMs) or implementing retrieval augmented
        /// generation (RAG) systems, you can use Amazon Kendra's <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_Retrieve.html">Retrieve</a>
        /// API, which can return longer semantically relevant passages. We recommend using the
        /// <c>Retrieve</c> API instead of filing a service limit increase to increase the <c>Query</c>
        /// API document excerpt length.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can configure boosting or relevance tuning at the query level to override boosting
        /// at the index level, filter based on document fields/attributes and faceted search,
        /// and filter based on the user or their group access to documents. You can also include
        /// certain fields in the response that might provide useful additional information.
        /// </para>
        ///  
        /// <para>
        /// A query response contains three types of results.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Relevant suggested answers. The answers can be either a text excerpt or table excerpt.
        /// The answer can be highlighted in the excerpt.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Matching FAQs or questions-answer from your FAQ file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Relevant documents. This result type includes an excerpt of the document with the
        /// document title. The searched terms can be highlighted in the excerpt.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify that the query return only one type of result using the <c>QueryResultTypeFilter</c>
        /// parameter. Each query returns the 100 most relevant results. If you filter result
        /// type to only question-answers, a maximum of four results are returned. If you filter
        /// result type to only answers, a maximum of three results are returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Query service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Query service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/Query">REST API Reference for Query Operation</seealso>
        Task<QueryResponse> QueryAsync(QueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Retrieve


        /// <summary>
        /// Retrieves relevant passages or text excerpts given an input query.
        /// 
        ///  
        /// <para>
        /// This API is similar to the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_Query.html">Query</a>
        /// API. However, by default, the <c>Query</c> API only returns excerpt passages of up
        /// to 100 token words. With the <c>Retrieve</c> API, you can retrieve longer passages
        /// of up to 200 token words and up to 100 semantically relevant passages. This doesn't
        /// include question-answer or FAQ type responses from your index. The passages are text
        /// excerpts that can be semantically extracted from multiple documents and multiple parts
        /// of the same document. If in extreme cases your documents produce zero passages using
        /// the <c>Retrieve</c> API, you can alternatively use the <c>Query</c> API and its types
        /// of responses.
        /// </para>
        ///  
        /// <para>
        /// You can also do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Override boosting at the index level
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Filter based on document fields or attributes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Filter based on the user or their group access to documents
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// View the confidence score bucket for a retrieved passage result. The confidence bucket
        /// provides a relative ranking that indicates how confident Amazon Kendra is that the
        /// response is relevant to the query.
        /// </para>
        ///  <note> 
        /// <para>
        /// Confidence score buckets are currently available only for English.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// You can also include certain fields in the response that might provide useful additional
        /// information.
        /// </para>
        ///  
        /// <para>
        /// The <c>Retrieve</c> API shares the number of <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_CapacityUnitsConfiguration.html">query
        /// capacity units</a> that you set for your index. For more information on what's included
        /// in a single capacity unit and the default base capacity for an index, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/adjusting-capacity.html">Adjusting
        /// capacity</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Retrieve service method.</param>
        /// 
        /// <returns>The response from the Retrieve service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/Retrieve">REST API Reference for Retrieve Operation</seealso>
        RetrieveResponse Retrieve(RetrieveRequest request);



        /// <summary>
        /// Retrieves relevant passages or text excerpts given an input query.
        /// 
        ///  
        /// <para>
        /// This API is similar to the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_Query.html">Query</a>
        /// API. However, by default, the <c>Query</c> API only returns excerpt passages of up
        /// to 100 token words. With the <c>Retrieve</c> API, you can retrieve longer passages
        /// of up to 200 token words and up to 100 semantically relevant passages. This doesn't
        /// include question-answer or FAQ type responses from your index. The passages are text
        /// excerpts that can be semantically extracted from multiple documents and multiple parts
        /// of the same document. If in extreme cases your documents produce zero passages using
        /// the <c>Retrieve</c> API, you can alternatively use the <c>Query</c> API and its types
        /// of responses.
        /// </para>
        ///  
        /// <para>
        /// You can also do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Override boosting at the index level
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Filter based on document fields or attributes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Filter based on the user or their group access to documents
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// View the confidence score bucket for a retrieved passage result. The confidence bucket
        /// provides a relative ranking that indicates how confident Amazon Kendra is that the
        /// response is relevant to the query.
        /// </para>
        ///  <note> 
        /// <para>
        /// Confidence score buckets are currently available only for English.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// You can also include certain fields in the response that might provide useful additional
        /// information.
        /// </para>
        ///  
        /// <para>
        /// The <c>Retrieve</c> API shares the number of <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_CapacityUnitsConfiguration.html">query
        /// capacity units</a> that you set for your index. For more information on what's included
        /// in a single capacity unit and the default base capacity for an index, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/adjusting-capacity.html">Adjusting
        /// capacity</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Retrieve service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Retrieve service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/Retrieve">REST API Reference for Retrieve Operation</seealso>
        Task<RetrieveResponse> RetrieveAsync(RetrieveRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartDataSourceSyncJob


        /// <summary>
        /// Starts a synchronization job for a data source connector. If a synchronization job
        /// is already in progress, Amazon Kendra returns a <c>ResourceInUseException</c> exception.
        /// 
        ///  
        /// <para>
        /// Re-syncing your data source with your index after modifying, adding, or deleting documents
        /// from your data source respository could take up to an hour or more, depending on the
        /// number of documents to sync.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceSyncJob service method.</param>
        /// 
        /// <returns>The response from the StartDataSourceSyncJob service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceInUseException">
        /// The resource you want to use is currently in use. Please check you have provided the
        /// correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/StartDataSourceSyncJob">REST API Reference for StartDataSourceSyncJob Operation</seealso>
        StartDataSourceSyncJobResponse StartDataSourceSyncJob(StartDataSourceSyncJobRequest request);



        /// <summary>
        /// Starts a synchronization job for a data source connector. If a synchronization job
        /// is already in progress, Amazon Kendra returns a <c>ResourceInUseException</c> exception.
        /// 
        ///  
        /// <para>
        /// Re-syncing your data source with your index after modifying, adding, or deleting documents
        /// from your data source respository could take up to an hour or more, depending on the
        /// number of documents to sync.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceSyncJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDataSourceSyncJob service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceInUseException">
        /// The resource you want to use is currently in use. Please check you have provided the
        /// correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/StartDataSourceSyncJob">REST API Reference for StartDataSourceSyncJob Operation</seealso>
        Task<StartDataSourceSyncJobResponse> StartDataSourceSyncJobAsync(StartDataSourceSyncJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopDataSourceSyncJob


        /// <summary>
        /// Stops a synchronization job that is currently running. You can't stop a scheduled
        /// synchronization job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataSourceSyncJob service method.</param>
        /// 
        /// <returns>The response from the StopDataSourceSyncJob service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/StopDataSourceSyncJob">REST API Reference for StopDataSourceSyncJob Operation</seealso>
        StopDataSourceSyncJobResponse StopDataSourceSyncJob(StopDataSourceSyncJobRequest request);



        /// <summary>
        /// Stops a synchronization job that is currently running. You can't stop a scheduled
        /// synchronization job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataSourceSyncJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDataSourceSyncJob service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/StopDataSourceSyncJob">REST API Reference for StopDataSourceSyncJob Operation</seealso>
        Task<StopDataSourceSyncJobResponse> StopDataSourceSyncJobAsync(StopDataSourceSyncJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SubmitFeedback


        /// <summary>
        /// Enables you to provide feedback to Amazon Kendra to improve the performance of your
        /// index.
        /// 
        ///  
        /// <para>
        ///  <c>SubmitFeedback</c> is currently not supported in the Amazon Web Services GovCloud
        /// (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitFeedback service method.</param>
        /// 
        /// <returns>The response from the SubmitFeedback service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// The resource you want to use isn't available. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/SubmitFeedback">REST API Reference for SubmitFeedback Operation</seealso>
        SubmitFeedbackResponse SubmitFeedback(SubmitFeedbackRequest request);



        /// <summary>
        /// Enables you to provide feedback to Amazon Kendra to improve the performance of your
        /// index.
        /// 
        ///  
        /// <para>
        ///  <c>SubmitFeedback</c> is currently not supported in the Amazon Web Services GovCloud
        /// (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitFeedback service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// The resource you want to use isn't available. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/SubmitFeedback">REST API Reference for SubmitFeedback Operation</seealso>
        Task<SubmitFeedbackResponse> SubmitFeedbackAsync(SubmitFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tag to the specified index, FAQ, or data source resource. If the
        /// tag already exists, the existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// The resource you want to use isn't available. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds the specified tag to the specified index, FAQ, or data source resource. If the
        /// tag already exists, the existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// The resource you want to use isn't available. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from an index, FAQ, or a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// The resource you want to use isn't available. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes a tag from an index, FAQ, or a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceUnavailableException">
        /// The resource you want to use isn't available. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAccessControlConfiguration


        /// <summary>
        /// Updates an access control configuration for your documents in an index. This includes
        /// user and group access information for your documents. This is useful for user context
        /// filtering, where search results are filtered based on the user or their group access
        /// to documents.
        /// 
        ///  
        /// <para>
        /// You can update an access control configuration you created without indexing all of
        /// your documents again. For example, your index contains top-secret company documents
        /// that only certain employees or users should access. You created an 'allow' access
        /// control configuration for one user who recently joined the 'top-secret' team, switching
        /// from a team with 'deny' access to top-secret documents. However, the user suddenly
        /// returns to their previous team and should no longer have access to top secret documents.
        /// You can update the access control configuration to re-configure access control for
        /// your documents as circumstances change.
        /// </para>
        ///  
        /// <para>
        /// You call the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchPutDocument.html">BatchPutDocument</a>
        /// API to apply the updated access control configuration, with the <c>AccessControlConfigurationId</c>
        /// included in the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_Document.html">Document</a>
        /// object. If you use an S3 bucket as a data source, you synchronize your data source
        /// to apply the <c>AccessControlConfigurationId</c> in the <c>.metadata.json</c> file.
        /// Amazon Kendra currently only supports access control configuration for S3 data sources
        /// and documents indexed using the <c>BatchPutDocument</c> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessControlConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessControlConfiguration service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateAccessControlConfiguration">REST API Reference for UpdateAccessControlConfiguration Operation</seealso>
        UpdateAccessControlConfigurationResponse UpdateAccessControlConfiguration(UpdateAccessControlConfigurationRequest request);



        /// <summary>
        /// Updates an access control configuration for your documents in an index. This includes
        /// user and group access information for your documents. This is useful for user context
        /// filtering, where search results are filtered based on the user or their group access
        /// to documents.
        /// 
        ///  
        /// <para>
        /// You can update an access control configuration you created without indexing all of
        /// your documents again. For example, your index contains top-secret company documents
        /// that only certain employees or users should access. You created an 'allow' access
        /// control configuration for one user who recently joined the 'top-secret' team, switching
        /// from a team with 'deny' access to top-secret documents. However, the user suddenly
        /// returns to their previous team and should no longer have access to top secret documents.
        /// You can update the access control configuration to re-configure access control for
        /// your documents as circumstances change.
        /// </para>
        ///  
        /// <para>
        /// You call the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchPutDocument.html">BatchPutDocument</a>
        /// API to apply the updated access control configuration, with the <c>AccessControlConfigurationId</c>
        /// included in the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_Document.html">Document</a>
        /// object. If you use an S3 bucket as a data source, you synchronize your data source
        /// to apply the <c>AccessControlConfigurationId</c> in the <c>.metadata.json</c> file.
        /// Amazon Kendra currently only supports access control configuration for S3 data sources
        /// and documents indexed using the <c>BatchPutDocument</c> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessControlConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessControlConfiguration service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateAccessControlConfiguration">REST API Reference for UpdateAccessControlConfiguration Operation</seealso>
        Task<UpdateAccessControlConfigurationResponse> UpdateAccessControlConfigurationAsync(UpdateAccessControlConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDataSource


        /// <summary>
        /// Updates an Amazon Kendra data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request);



        /// <summary>
        /// Updates an Amazon Kendra data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateExperience


        /// <summary>
        /// Updates your Amazon Kendra experience such as a search application. For more information
        /// on creating a search application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperience service method.</param>
        /// 
        /// <returns>The response from the UpdateExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateExperience">REST API Reference for UpdateExperience Operation</seealso>
        UpdateExperienceResponse UpdateExperience(UpdateExperienceRequest request);



        /// <summary>
        /// Updates your Amazon Kendra experience such as a search application. For more information
        /// on creating a search application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
        /// a search experience with no code</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateExperience service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateExperience">REST API Reference for UpdateExperience Operation</seealso>
        Task<UpdateExperienceResponse> UpdateExperienceAsync(UpdateExperienceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFeaturedResultsSet


        /// <summary>
        /// Updates a set of featured results. Features results are placed above all other results
        /// for certain queries. You map specific queries to specific documents for featuring
        /// in the results. If a query contains an exact match of a query, then one or more specific
        /// documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeaturedResultsSet service method.</param>
        /// 
        /// <returns>The response from the UpdateFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.FeaturedResultsConflictException">
        /// An error message with a list of conflicting queries used across different sets of
        /// featured results. This occurred with the request for a new featured results set. Check
        /// that the queries you specified for featured results are unique per featured results
        /// set for each index.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateFeaturedResultsSet">REST API Reference for UpdateFeaturedResultsSet Operation</seealso>
        UpdateFeaturedResultsSetResponse UpdateFeaturedResultsSet(UpdateFeaturedResultsSetRequest request);



        /// <summary>
        /// Updates a set of featured results. Features results are placed above all other results
        /// for certain queries. You map specific queries to specific documents for featuring
        /// in the results. If a query contains an exact match of a query, then one or more specific
        /// documents are featured in the search results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeaturedResultsSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFeaturedResultsSet service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.FeaturedResultsConflictException">
        /// An error message with a list of conflicting queries used across different sets of
        /// featured results. This occurred with the request for a new featured results set. Check
        /// that the queries you specified for featured results are unique per featured results
        /// set for each index.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateFeaturedResultsSet">REST API Reference for UpdateFeaturedResultsSet Operation</seealso>
        Task<UpdateFeaturedResultsSetResponse> UpdateFeaturedResultsSetAsync(UpdateFeaturedResultsSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIndex


        /// <summary>
        /// Updates an Amazon Kendra index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndex service method.</param>
        /// 
        /// <returns>The response from the UpdateIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateIndex">REST API Reference for UpdateIndex Operation</seealso>
        UpdateIndexResponse UpdateIndex(UpdateIndexRequest request);



        /// <summary>
        /// Updates an Amazon Kendra index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIndex service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra service. Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateIndex">REST API Reference for UpdateIndex Operation</seealso>
        Task<UpdateIndexResponse> UpdateIndexAsync(UpdateIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateQuerySuggestionsBlockList


        /// <summary>
        /// Updates a block list used for query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// Updates to a block list might not take effect right away. Amazon Kendra needs to refresh
        /// the entire suggestions list to apply any updates to the block list. Other changes
        /// not related to the block list apply immediately.
        /// </para>
        ///  
        /// <para>
        /// If a block list is updating, then you need to wait for the first update to finish
        /// before submitting another update.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kendra supports partial updates, so you only need to provide the fields you
        /// want to update.
        /// </para>
        ///  
        /// <para>
        ///  <c>UpdateQuerySuggestionsBlockList</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuerySuggestionsBlockList service method.</param>
        /// 
        /// <returns>The response from the UpdateQuerySuggestionsBlockList service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateQuerySuggestionsBlockList">REST API Reference for UpdateQuerySuggestionsBlockList Operation</seealso>
        UpdateQuerySuggestionsBlockListResponse UpdateQuerySuggestionsBlockList(UpdateQuerySuggestionsBlockListRequest request);



        /// <summary>
        /// Updates a block list used for query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// Updates to a block list might not take effect right away. Amazon Kendra needs to refresh
        /// the entire suggestions list to apply any updates to the block list. Other changes
        /// not related to the block list apply immediately.
        /// </para>
        ///  
        /// <para>
        /// If a block list is updating, then you need to wait for the first update to finish
        /// before submitting another update.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kendra supports partial updates, so you only need to provide the fields you
        /// want to update.
        /// </para>
        ///  
        /// <para>
        ///  <c>UpdateQuerySuggestionsBlockList</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuerySuggestionsBlockList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQuerySuggestionsBlockList service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateQuerySuggestionsBlockList">REST API Reference for UpdateQuerySuggestionsBlockList Operation</seealso>
        Task<UpdateQuerySuggestionsBlockListResponse> UpdateQuerySuggestionsBlockListAsync(UpdateQuerySuggestionsBlockListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateQuerySuggestionsConfig


        /// <summary>
        /// Updates the settings of query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// Amazon Kendra supports partial updates, so you only need to provide the fields you
        /// want to update.
        /// </para>
        ///  
        /// <para>
        /// If an update is currently processing, you need to wait for the update to finish before
        /// making another update.
        /// </para>
        ///  
        /// <para>
        /// Updates to query suggestions settings might not take effect right away. The time for
        /// your updated settings to take effect depends on the updates made and the number of
        /// search queries in your index.
        /// </para>
        ///  
        /// <para>
        /// You can still enable/disable query suggestions at any time.
        /// </para>
        ///  
        /// <para>
        ///  <c>UpdateQuerySuggestionsConfig</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuerySuggestionsConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateQuerySuggestionsConfig service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateQuerySuggestionsConfig">REST API Reference for UpdateQuerySuggestionsConfig Operation</seealso>
        UpdateQuerySuggestionsConfigResponse UpdateQuerySuggestionsConfig(UpdateQuerySuggestionsConfigRequest request);



        /// <summary>
        /// Updates the settings of query suggestions for an index.
        /// 
        ///  
        /// <para>
        /// Amazon Kendra supports partial updates, so you only need to provide the fields you
        /// want to update.
        /// </para>
        ///  
        /// <para>
        /// If an update is currently processing, you need to wait for the update to finish before
        /// making another update.
        /// </para>
        ///  
        /// <para>
        /// Updates to query suggestions settings might not take effect right away. The time for
        /// your updated settings to take effect depends on the updates made and the number of
        /// search queries in your index.
        /// </para>
        ///  
        /// <para>
        /// You can still enable/disable query suggestions at any time.
        /// </para>
        ///  
        /// <para>
        ///  <c>UpdateQuerySuggestionsConfig</c> is currently not supported in the Amazon Web
        /// Services GovCloud (US-West) region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuerySuggestionsConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQuerySuggestionsConfig service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateQuerySuggestionsConfig">REST API Reference for UpdateQuerySuggestionsConfig Operation</seealso>
        Task<UpdateQuerySuggestionsConfigResponse> UpdateQuerySuggestionsConfigAsync(UpdateQuerySuggestionsConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateThesaurus


        /// <summary>
        /// Updates a thesaurus for an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThesaurus service method.</param>
        /// 
        /// <returns>The response from the UpdateThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateThesaurus">REST API Reference for UpdateThesaurus Operation</seealso>
        UpdateThesaurusResponse UpdateThesaurus(UpdateThesaurusRequest request);



        /// <summary>
        /// Updates a thesaurus for an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThesaurus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThesaurus service method, as returned by Kendra.</returns>
        /// <exception cref="Amazon.Kendra.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistences with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra service. Please
        /// wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ResourceNotFoundException">
        /// The resource you want to use doesn’t exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Kendra.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra service. Please
        /// provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-2019-02-03/UpdateThesaurus">REST API Reference for UpdateThesaurus Operation</seealso>
        Task<UpdateThesaurusResponse> UpdateThesaurusAsync(UpdateThesaurusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}