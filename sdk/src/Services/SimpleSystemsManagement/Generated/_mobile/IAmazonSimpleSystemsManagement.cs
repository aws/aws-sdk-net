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
    /// AWS Simple Systems Management enables you to configure and manage your EC2 instances.
    /// You can create a configuration document and then associate it with one or more running
    /// instances.
    /// 
    ///  
    /// <para>
    /// You can use a configuration document to automate the following tasks for your Windows
    /// instances:
    /// </para>
    ///  <ul> <li>
    /// <para>
    /// Install, repair, or uninstall software using an MSI package
    /// </para>
    /// </li> <li>
    /// <para>
    /// Run PowerShell scripts
    /// </para>
    /// </li> <li>
    /// <para>
    /// Join an AWS Directory
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