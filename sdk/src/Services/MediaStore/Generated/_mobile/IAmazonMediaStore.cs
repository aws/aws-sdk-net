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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MediaStore.Model;

namespace Amazon.MediaStore
{
    /// <summary>
    /// Interface for accessing MediaStore
    ///
    /// An AWS Elemental MediaStore container is a namespace that holds folders and objects.
    /// You use a container endpoint to create, read, and delete objects.
    /// </summary>
    public partial interface IAmazonMediaStore : IAmazonService, IDisposable
    {
                
        #region  CreateContainer


        /// <summary>
        /// Initiates the asynchronous execution of the CreateContainer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateContainer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/CreateContainer">REST API Reference for CreateContainer Operation</seealso>
        Task<CreateContainerResponse> CreateContainerAsync(CreateContainerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteContainer


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContainer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainer">REST API Reference for DeleteContainer Operation</seealso>
        Task<DeleteContainerResponse> DeleteContainerAsync(DeleteContainerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteContainerPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteContainerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainerPolicy">REST API Reference for DeleteContainerPolicy Operation</seealso>
        Task<DeleteContainerPolicyResponse> DeleteContainerPolicyAsync(DeleteContainerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCorsPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCorsPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCorsPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteCorsPolicy">REST API Reference for DeleteCorsPolicy Operation</seealso>
        Task<DeleteCorsPolicyResponse> DeleteCorsPolicyAsync(DeleteCorsPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeContainer


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeContainer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DescribeContainer">REST API Reference for DescribeContainer Operation</seealso>
        Task<DescribeContainerResponse> DescribeContainerAsync(DescribeContainerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetContainerPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetContainerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContainerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetContainerPolicy">REST API Reference for GetContainerPolicy Operation</seealso>
        Task<GetContainerPolicyResponse> GetContainerPolicyAsync(GetContainerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCorsPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetCorsPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCorsPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetCorsPolicy">REST API Reference for GetCorsPolicy Operation</seealso>
        Task<GetCorsPolicyResponse> GetCorsPolicyAsync(GetCorsPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListContainers


        /// <summary>
        /// Initiates the asynchronous execution of the ListContainers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListContainers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/ListContainers">REST API Reference for ListContainers Operation</seealso>
        Task<ListContainersResponse> ListContainersAsync(ListContainersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutContainerPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the PutContainerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutContainerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutContainerPolicy">REST API Reference for PutContainerPolicy Operation</seealso>
        Task<PutContainerPolicyResponse> PutContainerPolicyAsync(PutContainerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutCorsPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the PutCorsPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCorsPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutCorsPolicy">REST API Reference for PutCorsPolicy Operation</seealso>
        Task<PutCorsPolicyResponse> PutCorsPolicyAsync(PutCorsPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}