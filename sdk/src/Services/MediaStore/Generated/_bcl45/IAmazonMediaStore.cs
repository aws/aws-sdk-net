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
        /// Creates a storage container to hold objects. A container is similar to a bucket in
        /// the Amazon S3 service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateContainer service method.</param>
        /// 
        /// <returns>The response from the CreateContainer service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// Resource already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.LimitExceededException">
        /// A service limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/CreateContainer">REST API Reference for CreateContainer Operation</seealso>
        CreateContainerResponse CreateContainer(CreateContainerRequest request);


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
        Task<CreateContainerResponse> CreateContainerAsync(CreateContainerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteContainer


        /// <summary>
        /// Deletes the specified container. Before you make a <code>DeleteContainer</code> request,
        /// delete any objects in the container or in any folders in the container. You can delete
        /// only empty containers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainer service method.</param>
        /// 
        /// <returns>The response from the DeleteContainer service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// Resource already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// Could not perform an operation on a container that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainer">REST API Reference for DeleteContainer Operation</seealso>
        DeleteContainerResponse DeleteContainer(DeleteContainerRequest request);


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
        Task<DeleteContainerResponse> DeleteContainerAsync(DeleteContainerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteContainerPolicy


        /// <summary>
        /// Deletes the access policy that is associated with the specified container.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteContainerPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteContainerPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// Resource already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// Could not perform an operation on a container that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// Could not perform an operation on a policy that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteContainerPolicy">REST API Reference for DeleteContainerPolicy Operation</seealso>
        DeleteContainerPolicyResponse DeleteContainerPolicy(DeleteContainerPolicyRequest request);


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
        Task<DeleteContainerPolicyResponse> DeleteContainerPolicyAsync(DeleteContainerPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCorsPolicy


        /// <summary>
        /// Deletes the cross-origin resource sharing (CORS) configuration information that is
        /// set for the container.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>MediaStore:DeleteCorsPolicy</code>
        /// action. The container owner has this permission by default and can grant this permission
        /// to others.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCorsPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteCorsPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// Resource already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// Could not perform an operation on a container that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.CorsPolicyNotFoundException">
        /// Could not perform an operation on a policy that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DeleteCorsPolicy">REST API Reference for DeleteCorsPolicy Operation</seealso>
        DeleteCorsPolicyResponse DeleteCorsPolicy(DeleteCorsPolicyRequest request);


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
        Task<DeleteCorsPolicyResponse> DeleteCorsPolicyAsync(DeleteCorsPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeContainer


        /// <summary>
        /// Retrieves the properties of the requested container. This request is commonly used
        /// to retrieve the endpoint of a container. An endpoint is a value assigned by the service
        /// when a new container is created. A container's endpoint does not change after it has
        /// been assigned. The <code>DescribeContainer</code> request returns a single <code>Container</code>
        /// object based on <code>ContainerName</code>. To return all <code>Container</code> objects
        /// that are associated with a specified AWS account, use <a>ListContainers</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContainer service method.</param>
        /// 
        /// <returns>The response from the DescribeContainer service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// Could not perform an operation on a container that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/DescribeContainer">REST API Reference for DescribeContainer Operation</seealso>
        DescribeContainerResponse DescribeContainer(DescribeContainerRequest request);


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
        Task<DescribeContainerResponse> DescribeContainerAsync(DescribeContainerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContainerPolicy


        /// <summary>
        /// Retrieves the access policy for the specified container. For information about the
        /// data that is included in an access policy, see the <a href="https://aws.amazon.com/documentation/iam/">AWS
        /// Identity and Access Management User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContainerPolicy service method.</param>
        /// 
        /// <returns>The response from the GetContainerPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// Resource already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// Could not perform an operation on a container that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.PolicyNotFoundException">
        /// Could not perform an operation on a policy that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetContainerPolicy">REST API Reference for GetContainerPolicy Operation</seealso>
        GetContainerPolicyResponse GetContainerPolicy(GetContainerPolicyRequest request);


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
        Task<GetContainerPolicyResponse> GetContainerPolicyAsync(GetContainerPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCorsPolicy


        /// <summary>
        /// Returns the cross-origin resource sharing (CORS) configuration information that is
        /// set for the container.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>MediaStore:GetCorsPolicy</code>
        /// action. By default, the container owner has this permission and can grant it to others.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCorsPolicy service method.</param>
        /// 
        /// <returns>The response from the GetCorsPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// Resource already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// Could not perform an operation on a container that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.CorsPolicyNotFoundException">
        /// Could not perform an operation on a policy that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/GetCorsPolicy">REST API Reference for GetCorsPolicy Operation</seealso>
        GetCorsPolicyResponse GetCorsPolicy(GetCorsPolicyRequest request);


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
        Task<GetCorsPolicyResponse> GetCorsPolicyAsync(GetCorsPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListContainers


        /// <summary>
        /// Lists the properties of all containers in AWS Elemental MediaStore. 
        /// 
        ///  
        /// <para>
        /// You can query to receive all the containers in one response. Or you can include the
        /// <code>MaxResults</code> parameter to receive a limited number of containers in each
        /// response. In this case, the response includes a token. To get the next set of containers,
        /// send the command again, this time with the <code>NextToken</code> parameter (with
        /// the returned token as its value). The next set of responses appears, with a token
        /// if there are still more containers to receive. 
        /// </para>
        ///  
        /// <para>
        /// See also <a>DescribeContainer</a>, which gets the properties of one container. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContainers service method.</param>
        /// 
        /// <returns>The response from the ListContainers service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/ListContainers">REST API Reference for ListContainers Operation</seealso>
        ListContainersResponse ListContainers(ListContainersRequest request);


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
        Task<ListContainersResponse> ListContainersAsync(ListContainersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutContainerPolicy


        /// <summary>
        /// Creates an access policy for the specified container to restrict the users and clients
        /// that can access it. For information about the data that is included in an access policy,
        /// see the <a href="https://aws.amazon.com/documentation/iam/">AWS Identity and Access
        /// Management User Guide</a>.
        /// 
        ///  
        /// <para>
        /// For this release of the REST API, you can create only one policy for a container.
        /// If you enter <code>PutContainerPolicy</code> twice, the second command modifies the
        /// existing policy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutContainerPolicy service method.</param>
        /// 
        /// <returns>The response from the PutContainerPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// Resource already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// Could not perform an operation on a container that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutContainerPolicy">REST API Reference for PutContainerPolicy Operation</seealso>
        PutContainerPolicyResponse PutContainerPolicy(PutContainerPolicyRequest request);


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
        Task<PutContainerPolicyResponse> PutContainerPolicyAsync(PutContainerPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutCorsPolicy


        /// <summary>
        /// Sets the cross-origin resource sharing (CORS) configuration on a container so that
        /// the container can service cross-origin requests. For example, you might want to enable
        /// a request whose origin is http://www.example.com to access your AWS Elemental MediaStore
        /// container at my.example.container.com by using the browser's XMLHttpRequest capability.
        /// 
        ///  
        /// <para>
        /// To enable CORS on a container, you attach a CORS policy to the container. In the CORS
        /// policy, you configure rules that identify origins and the HTTP methods that can be
        /// executed on your container. The policy can contain up to 398,000 characters. You can
        /// add up to 100 rules to a CORS policy. If more than one rule applies, the service uses
        /// the first applicable rule listed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCorsPolicy service method.</param>
        /// 
        /// <returns>The response from the PutCorsPolicy service method, as returned by MediaStore.</returns>
        /// <exception cref="Amazon.MediaStore.Model.ContainerInUseException">
        /// Resource already exists or is being updated.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.ContainerNotFoundException">
        /// Could not perform an operation on a container that does not exist.
        /// </exception>
        /// <exception cref="Amazon.MediaStore.Model.InternalServerErrorException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediastore-2017-09-01/PutCorsPolicy">REST API Reference for PutCorsPolicy Operation</seealso>
        PutCorsPolicyResponse PutCorsPolicy(PutCorsPolicyRequest request);


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
        Task<PutCorsPolicyResponse> PutCorsPolicyAsync(PutCorsPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}