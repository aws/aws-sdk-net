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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.OpenSearchServerless.Model;

namespace Amazon.OpenSearchServerless
{
    /// <summary>
    /// Interface for accessing OpenSearchServerless
    ///
    /// Use the Amazon OpenSearch Serverless API to create, configure, and manage OpenSearch
    /// Serverless collections and security policies.
    /// 
    ///  
    /// <para>
    /// OpenSearch Serverless is an on-demand, pre-provisioned serverless configuration for
    /// Amazon OpenSearch Service. OpenSearch Serverless removes the operational complexities
    /// of provisioning, configuring, and tuning your OpenSearch clusters. It enables you
    /// to easily search and analyze petabytes of data without having to worry about the underlying
    /// infrastructure and data management.
    /// </para>
    ///  
    /// <para>
    ///  To learn more about OpenSearch Serverless, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-overview.html">What
    /// is Amazon OpenSearch Serverless?</a> 
    /// </para>
    /// </summary>
    public partial interface IAmazonOpenSearchServerless : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IOpenSearchServerlessPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchGetCollection



        /// <summary>
        /// Returns attributes for one or more collections, including the collection endpoint
        /// and the OpenSearch Dashboards endpoint. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html">Creating
        /// and managing Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCollection service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/BatchGetCollection">REST API Reference for BatchGetCollection Operation</seealso>
        Task<BatchGetCollectionResponse> BatchGetCollectionAsync(BatchGetCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetVpcEndpoint



        /// <summary>
        /// Returns attributes for one or more VPC endpoints associated with the current account.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetVpcEndpoint service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/BatchGetVpcEndpoint">REST API Reference for BatchGetVpcEndpoint Operation</seealso>
        Task<BatchGetVpcEndpointResponse> BatchGetVpcEndpointAsync(BatchGetVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccessPolicy



        /// <summary>
        /// Creates a data access policy for OpenSearch Serverless. Access policies limit access
        /// to collections and the resources within them, and allow a user to access that data
        /// irrespective of the access mechanism or network source. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-data-access.html">Data
        /// access control for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateAccessPolicy">REST API Reference for CreateAccessPolicy Operation</seealso>
        Task<CreateAccessPolicyResponse> CreateAccessPolicyAsync(CreateAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCollection



        /// <summary>
        /// Creates a new OpenSearch Serverless collection. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html">Creating
        /// and managing Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCollection service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        Task<CreateCollectionResponse> CreateCollectionAsync(CreateCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSecurityConfig



        /// <summary>
        /// Specifies a security configuration for OpenSearch Serverless. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityConfig service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateSecurityConfig">REST API Reference for CreateSecurityConfig Operation</seealso>
        Task<CreateSecurityConfigResponse> CreateSecurityConfigAsync(CreateSecurityConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSecurityPolicy



        /// <summary>
        /// Creates a security policy to be used by one or more OpenSearch Serverless collections.
        /// Security policies provide access to a collection and its OpenSearch Dashboards endpoint
        /// from public networks or specific VPC endpoints. They also allow you to secure a collection
        /// with a KMS encryption key. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-network.html">Network
        /// access for Amazon OpenSearch Serverless</a> and <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-encryption.html">Encryption
        /// at rest for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateSecurityPolicy">REST API Reference for CreateSecurityPolicy Operation</seealso>
        Task<CreateSecurityPolicyResponse> CreateSecurityPolicyAsync(CreateSecurityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpcEndpoint



        /// <summary>
        /// Creates an OpenSearch Serverless-managed interface VPC endpoint. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcEndpoint service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(CreateVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccessPolicy



        /// <summary>
        /// Deletes an OpenSearch Serverless access policy. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-data-access.html">Data
        /// access control for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteAccessPolicy">REST API Reference for DeleteAccessPolicy Operation</seealso>
        Task<DeleteAccessPolicyResponse> DeleteAccessPolicyAsync(DeleteAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCollection



        /// <summary>
        /// Deletes an OpenSearch Serverless collection. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html">Creating
        /// and managing Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCollection service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        Task<DeleteCollectionResponse> DeleteCollectionAsync(DeleteCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSecurityConfig



        /// <summary>
        /// Deletes a security configuration for OpenSearch Serverless. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityConfig service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteSecurityConfig">REST API Reference for DeleteSecurityConfig Operation</seealso>
        Task<DeleteSecurityConfigResponse> DeleteSecurityConfigAsync(DeleteSecurityConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSecurityPolicy



        /// <summary>
        /// Deletes an OpenSearch Serverless security policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteSecurityPolicy">REST API Reference for DeleteSecurityPolicy Operation</seealso>
        Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicyAsync(DeleteSecurityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpcEndpoint



        /// <summary>
        /// Deletes an OpenSearch Serverless-managed interface endpoint. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcEndpoint service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteVpcEndpoint">REST API Reference for DeleteVpcEndpoint Operation</seealso>
        Task<DeleteVpcEndpointResponse> DeleteVpcEndpointAsync(DeleteVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccessPolicy



        /// <summary>
        /// Returns an OpenSearch Serverless access policy. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-data-access.html">Data
        /// access control for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetAccessPolicy">REST API Reference for GetAccessPolicy Operation</seealso>
        Task<GetAccessPolicyResponse> GetAccessPolicyAsync(GetAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccountSettings



        /// <summary>
        /// Returns account-level settings related to OpenSearch Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPoliciesStats



        /// <summary>
        /// Returns statistical information about your OpenSearch Serverless access policies,
        /// security configurations, and security policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPoliciesStats service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPoliciesStats service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetPoliciesStats">REST API Reference for GetPoliciesStats Operation</seealso>
        Task<GetPoliciesStatsResponse> GetPoliciesStatsAsync(GetPoliciesStatsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSecurityConfig



        /// <summary>
        /// Returns information about an OpenSearch Serverless security configuration. For more
        /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSecurityConfig service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetSecurityConfig">REST API Reference for GetSecurityConfig Operation</seealso>
        Task<GetSecurityConfigResponse> GetSecurityConfigAsync(GetSecurityConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSecurityPolicy



        /// <summary>
        /// Returns information about a configured OpenSearch Serverless security policy. For
        /// more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-network.html">Network
        /// access for Amazon OpenSearch Serverless</a> and <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-encryption.html">Encryption
        /// at rest for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSecurityPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetSecurityPolicy">REST API Reference for GetSecurityPolicy Operation</seealso>
        Task<GetSecurityPolicyResponse> GetSecurityPolicyAsync(GetSecurityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccessPolicies



        /// <summary>
        /// Returns information about a list of OpenSearch Serverless access policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessPolicies service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListAccessPolicies">REST API Reference for ListAccessPolicies Operation</seealso>
        Task<ListAccessPoliciesResponse> ListAccessPoliciesAsync(ListAccessPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCollections



        /// <summary>
        /// Lists all OpenSearch Serverless collections. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html">Creating
        /// and managing Amazon OpenSearch Serverless collections</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Make sure to include an empty request body {} if you don't include any collection
        /// filters in the request.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCollections service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListCollections">REST API Reference for ListCollections Operation</seealso>
        Task<ListCollectionsResponse> ListCollectionsAsync(ListCollectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSecurityConfigs



        /// <summary>
        /// Returns information about configured OpenSearch Serverless security configurations.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityConfigs service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListSecurityConfigs">REST API Reference for ListSecurityConfigs Operation</seealso>
        Task<ListSecurityConfigsResponse> ListSecurityConfigsAsync(ListSecurityConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSecurityPolicies



        /// <summary>
        /// Returns information about configured OpenSearch Serverless security policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityPolicies service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListSecurityPolicies">REST API Reference for ListSecurityPolicies Operation</seealso>
        Task<ListSecurityPoliciesResponse> ListSecurityPoliciesAsync(ListSecurityPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns the tags for an OpenSearch Serverless resource. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-collection.html">Tagging
        /// Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVpcEndpoints



        /// <summary>
        /// Returns the OpenSearch Serverless-managed interface VPC endpoints associated with
        /// the current account. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVpcEndpoints service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListVpcEndpoints">REST API Reference for ListVpcEndpoints Operation</seealso>
        Task<ListVpcEndpointsResponse> ListVpcEndpointsAsync(ListVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Associates tags with an OpenSearch Serverless resource. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-collection.html">Tagging
        /// Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a tag or set of tags from an OpenSearch Serverless resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-collection.html">Tagging
        /// Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccessPolicy



        /// <summary>
        /// Updates an OpenSearch Serverless access policy. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-data-access.html">Data
        /// access control for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateAccessPolicy">REST API Reference for UpdateAccessPolicy Operation</seealso>
        Task<UpdateAccessPolicyResponse> UpdateAccessPolicyAsync(UpdateAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccountSettings



        /// <summary>
        /// Update the OpenSearch Serverless settings for the current Amazon Web Services account.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-overview.html#serverless-scaling">Autoscaling</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        Task<UpdateAccountSettingsResponse> UpdateAccountSettingsAsync(UpdateAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCollection



        /// <summary>
        /// Updates an OpenSearch Serverless collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCollection service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateCollection">REST API Reference for UpdateCollection Operation</seealso>
        Task<UpdateCollectionResponse> UpdateCollectionAsync(UpdateCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSecurityConfig



        /// <summary>
        /// Updates a security configuration for OpenSearch Serverless. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityConfig service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateSecurityConfig">REST API Reference for UpdateSecurityConfig Operation</seealso>
        Task<UpdateSecurityConfigResponse> UpdateSecurityConfigAsync(UpdateSecurityConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSecurityPolicy



        /// <summary>
        /// Updates an OpenSearch Serverless security policy. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-network.html">Network
        /// access for Amazon OpenSearch Serverless</a> and <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-encryption.html">Encryption
        /// at rest for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateSecurityPolicy">REST API Reference for UpdateSecurityPolicy Operation</seealso>
        Task<UpdateSecurityPolicyResponse> UpdateSecurityPolicyAsync(UpdateSecurityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVpcEndpoint



        /// <summary>
        /// Updates an OpenSearch Serverless-managed interface endpoint. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVpcEndpoint service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a collection, thrown when a collection with the same name already exists
        /// or is being created. When deleting a collection, thrown when the collection is not
        /// in the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateVpcEndpoint">REST API Reference for UpdateVpcEndpoint Operation</seealso>
        Task<UpdateVpcEndpointResponse> UpdateVpcEndpointAsync(UpdateVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}