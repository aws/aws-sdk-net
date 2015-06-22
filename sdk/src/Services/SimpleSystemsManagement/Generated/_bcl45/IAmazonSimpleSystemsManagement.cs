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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.SimpleSystemsManagement.Model;

namespace Amazon.SimpleSystemsManagement
{
    /// <summary>
    /// Interface for accessing SimpleSystemsManagement
    ///
    /// Amazon EC2 Simple Systems Manager (SSM) enables you to configure and manage your EC2
    /// instances. You can create a configuration document and then associate it with one
    /// or more running instances.
    /// 
    ///  
    /// <para>
    /// You can use a configuration document to automate the following tasks for your Windows
    /// instances:
    /// </para>
    ///  <ul> <li>
    /// <para>
    /// Join an AWS Directory
    /// </para>
    /// </li> <li>
    /// <para>
    /// Install, repair, or uninstall software using an MSI package
    /// </para>
    /// </li> <li>
    /// <para>
    /// Run PowerShell scripts
    /// </para>
    /// </li> <li>
    /// <para>
    /// Configure CloudWatch Logs to monitor applications and systems
    /// </para>
    /// </li> </ul> 
    /// <para>
    /// Note that configuration documents are not supported on Linux instances.
    /// </para>
    /// </summary>
    public partial interface IAmazonSimpleSystemsManagement : IDisposable
    {

        
        #region  CreateAssociation

        /// <summary>
        /// Associates the specified configuration document with the specified instance.
        /// 
        ///  
        /// <para>
        /// When you associate a configuration document with an instance, the configuration agent
        /// on the instance processes the configuration document and configures the instance as
        /// specified.
        /// </para>
        ///  
        /// <para>
        /// If you associate a configuration document with an instance that already has an associated
        /// configuration document, we replace the current configuration document with the new
        /// configuration document.
        /// </para>
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="name">The name of the configuration document.</param>
        /// 
        /// <returns>The response from the CreateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationAlreadyExistsException">
        /// The specified association already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// You must specify the ID of a running instance.
        /// </exception>
        CreateAssociationResponse CreateAssociation(string instanceId, string name);

        /// <summary>
        /// Associates the specified configuration document with the specified instance.
        /// 
        ///  
        /// <para>
        /// When you associate a configuration document with an instance, the configuration agent
        /// on the instance processes the configuration document and configures the instance as
        /// specified.
        /// </para>
        ///  
        /// <para>
        /// If you associate a configuration document with an instance that already has an associated
        /// configuration document, we replace the current configuration document with the new
        /// configuration document.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationAlreadyExistsException">
        /// The specified association already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// You must specify the ID of a running instance.
        /// </exception>
        CreateAssociationResponse CreateAssociation(CreateAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateAssociationResponse> CreateAssociationAsync(CreateAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAssociationBatch

        /// <summary>
        /// Associates the specified configuration documents with the specified instances.
        /// 
        ///  
        /// <para>
        /// When you associate a configuration document with an instance, the configuration agent
        /// on the instance processes the configuration document and configures the instance as
        /// specified.
        /// </para>
        ///  
        /// <para>
        /// If you associate a configuration document with an instance that already has an associated
        /// configuration document, we replace the current configuration document with the new
        /// configuration document.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociationBatch service method.</param>
        /// 
        /// <returns>The response from the CreateAssociationBatch service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You cannot specify an instance ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// You must specify the ID of a running instance.
        /// </exception>
        CreateAssociationBatchResponse CreateAssociationBatch(CreateAssociationBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssociationBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociationBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateAssociationBatchResponse> CreateAssociationBatchAsync(CreateAssociationBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDocument

        /// <summary>
        /// Creates a configuration document.
        /// 
        ///  
        /// <para>
        /// After you create a configuration document, you can use <a>CreateAssociation</a> to
        /// associate it with one or more running instances.
        /// </para>
        /// </summary>
        /// <param name="content">A valid JSON file. For more information about the contents of this file, see <a href="http://docs.aws.amazon.com/ssm/latest/APIReference/aws-ssm-document.html">Configuration Document</a>.</param>
        /// <param name="name">A name for the configuration document.</param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified configuration document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 100 active configuration documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the configuration document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a configuration document is 64 KB.
        /// </exception>
        CreateDocumentResponse CreateDocument(string content, string name);

        /// <summary>
        /// Creates a configuration document.
        /// 
        ///  
        /// <para>
        /// After you create a configuration document, you can use <a>CreateAssociation</a> to
        /// associate it with one or more running instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocument service method.</param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified configuration document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 100 active configuration documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the configuration document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a configuration document is 64 KB.
        /// </exception>
        CreateDocumentResponse CreateDocument(CreateDocumentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDocumentResponse> CreateDocumentAsync(CreateDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAssociation

        /// <summary>
        /// Disassociates the specified configuration document from the specified instance.
        /// 
        ///  
        /// <para>
        /// When you disassociate a configuration document from an instance, it does not change
        /// the configuration of the instance. To change the configuration state of an instance
        /// after you disassociate a configuration document, you must create a new configuration
        /// document with the desired configuration and associate it with the instance.
        /// </para>
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="name">The name of the configuration document.</param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// You must specify the ID of a running instance.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        DeleteAssociationResponse DeleteAssociation(string instanceId, string name);

        /// <summary>
        /// Disassociates the specified configuration document from the specified instance.
        /// 
        ///  
        /// <para>
        /// When you disassociate a configuration document from an instance, it does not change
        /// the configuration of the instance. To change the configuration state of an instance
        /// after you disassociate a configuration document, you must create a new configuration
        /// document with the desired configuration and associate it with the instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// You must specify the ID of a running instance.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        DeleteAssociationResponse DeleteAssociation(DeleteAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteAssociationResponse> DeleteAssociationAsync(DeleteAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDocument

        /// <summary>
        /// Deletes the specified configuration document.
        /// 
        ///  
        /// <para>
        /// You must use <a>DeleteAssociation</a> to disassociate all instances that are associated
        /// with the configuration document before you can delete it.
        /// </para>
        /// </summary>
        /// <param name="name">The name of the configuration document.</param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate a configuration document from all instances before you can delete
        /// it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        DeleteDocumentResponse DeleteDocument(string name);

        /// <summary>
        /// Deletes the specified configuration document.
        /// 
        ///  
        /// <para>
        /// You must use <a>DeleteAssociation</a> to disassociate all instances that are associated
        /// with the configuration document before you can delete it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument service method.</param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate a configuration document from all instances before you can delete
        /// it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDocumentResponse> DeleteDocumentAsync(DeleteDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAssociation

        /// <summary>
        /// Describes the associations for the specified configuration document or instance.
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="name">The name of the configuration document.</param>
        /// 
        /// <returns>The response from the DescribeAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// You must specify the ID of a running instance.
        /// </exception>
        DescribeAssociationResponse DescribeAssociation(string instanceId, string name);

        /// <summary>
        /// Describes the associations for the specified configuration document or instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociation service method.</param>
        /// 
        /// <returns>The response from the DescribeAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// You must specify the ID of a running instance.
        /// </exception>
        DescribeAssociationResponse DescribeAssociation(DescribeAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAssociationResponse> DescribeAssociationAsync(DescribeAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDocument

        /// <summary>
        /// Describes the specified configuration document.
        /// </summary>
        /// <param name="name">The name of the configuration document.</param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        DescribeDocumentResponse DescribeDocument(string name);

        /// <summary>
        /// Describes the specified configuration document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocument service method.</param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        DescribeDocumentResponse DescribeDocument(DescribeDocumentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDocumentResponse> DescribeDocumentAsync(DescribeDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDocument

        /// <summary>
        /// Gets the contents of the specified configuration document.
        /// </summary>
        /// <param name="name">The name of the configuration document.</param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        GetDocumentResponse GetDocument(string name);

        /// <summary>
        /// Gets the contents of the specified configuration document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocument service method.</param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        GetDocumentResponse GetDocument(GetDocumentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssociations

        /// <summary>
        /// Lists the associations for the specified configuration document or instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        ListAssociationsResponse ListAssociations(ListAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListAssociationsResponse> ListAssociationsAsync(ListAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDocuments

        /// <summary>
        /// Describes one or more of your configuration documents.
        /// </summary>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        ListDocumentsResponse ListDocuments();

        /// <summary>
        /// Describes one or more of your configuration documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments service method.</param>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token is not valid.
        /// </exception>
        ListDocumentsResponse ListDocuments(ListDocumentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDocumentsResponse> ListDocumentsAsync(ListDocumentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAssociationStatus

        /// <summary>
        /// Updates the status of the configuration document associated with the specified instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociationStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateAssociationStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The configuration document is not valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// You must specify the ID of a running instance.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.StatusUnchangedException">
        /// The updated status is the same as the current status.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        UpdateAssociationStatusResponse UpdateAssociationStatus(UpdateAssociationStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateAssociationStatusResponse> UpdateAssociationStatusAsync(UpdateAssociationStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}