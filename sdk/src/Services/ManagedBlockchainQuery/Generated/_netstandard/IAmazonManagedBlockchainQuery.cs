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
 * Do not modify this file. This file is generated from the managedblockchain-query-2023-05-04.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ManagedBlockchainQuery.Model;

#pragma warning disable CS1570
namespace Amazon.ManagedBlockchainQuery
{
    /// <summary>
    /// <para>Interface for accessing ManagedBlockchainQuery</para>
    ///
    /// Amazon Managed Blockchain (AMB) Query provides you with convenient access to multi-blockchain
    /// network data, which makes it easier for you to extract contextual data related to
    /// blockchain activity. You can use AMB Query to read data from public blockchain networks,
    /// such as Bitcoin Mainnet and Ethereum Mainnet. You can also get information such as
    /// the current and historical balances of addresses, or you can get a list of blockchain
    /// transactions for a given time period. Additionally, you can get details of a given
    /// transaction, such as transaction events, which you can further analyze or use in business
    /// logic for your applications.
    /// </summary>
    public partial interface IAmazonManagedBlockchainQuery : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IManagedBlockchainQueryPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchGetTokenBalance



        /// <summary>
        /// Gets the token balance for a batch of tokens by using the <c>BatchGetTokenBalance</c>
        /// action for every token in the request.
        /// 
        ///  <note> 
        /// <para>
        /// Only the native tokens BTC and ETH, and the ERC-20, ERC-721, and ERC 1155 token standards
        /// are supported.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTokenBalance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetTokenBalance service method, as returned by ManagedBlockchainQuery.</returns>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.AccessDeniedException">
        /// The Amazon Web Services account doesn’t have access to this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.InternalServerException">
        /// The request processing has failed because of an internal error in the service.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded for this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is when you create resources that exceed
        /// your service limit for this resource type. Request a limit increase or delete unused
        /// resources, if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ValidationException">
        /// The resource passed is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/BatchGetTokenBalance">REST API Reference for BatchGetTokenBalance Operation</seealso>
        Task<BatchGetTokenBalanceResponse> BatchGetTokenBalanceAsync(BatchGetTokenBalanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAssetContract



        /// <summary>
        /// Gets the information about a specific contract deployed on the blockchain.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// The Bitcoin blockchain networks do not support this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Metadata is currently only available for some <c>ERC-20</c> contracts. Metadata will
        /// be available for additional contracts in the future.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetContract service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssetContract service method, as returned by ManagedBlockchainQuery.</returns>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.AccessDeniedException">
        /// The Amazon Web Services account doesn’t have access to this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.InternalServerException">
        /// The request processing has failed because of an internal error in the service.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded for this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is when you create resources that exceed
        /// your service limit for this resource type. Request a limit increase or delete unused
        /// resources, if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ValidationException">
        /// The resource passed is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/GetAssetContract">REST API Reference for GetAssetContract Operation</seealso>
        Task<GetAssetContractResponse> GetAssetContractAsync(GetAssetContractRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTokenBalance



        /// <summary>
        /// Gets the balance of a specific token, including native tokens, for a given address
        /// (wallet or contract) on the blockchain.
        /// 
        ///  <note> 
        /// <para>
        /// Only the native tokens BTC and ETH, and the ERC-20, ERC-721, and ERC 1155 token standards
        /// are supported.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTokenBalance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTokenBalance service method, as returned by ManagedBlockchainQuery.</returns>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.AccessDeniedException">
        /// The Amazon Web Services account doesn’t have access to this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.InternalServerException">
        /// The request processing has failed because of an internal error in the service.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded for this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is when you create resources that exceed
        /// your service limit for this resource type. Request a limit increase or delete unused
        /// resources, if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ValidationException">
        /// The resource passed is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/GetTokenBalance">REST API Reference for GetTokenBalance Operation</seealso>
        Task<GetTokenBalanceResponse> GetTokenBalanceAsync(GetTokenBalanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTransaction



        /// <summary>
        /// Gets the details of a transaction.
        /// 
        ///  <note> 
        /// <para>
        /// This action will return transaction details for all transactions that are <i>confirmed</i>
        /// on the blockchain, even if they have not reached <a href="https://docs.aws.amazon.com/managed-blockchain/latest/ambq-dg/key-concepts.html#finality">finality</a>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransaction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransaction service method, as returned by ManagedBlockchainQuery.</returns>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.AccessDeniedException">
        /// The Amazon Web Services account doesn’t have access to this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.InternalServerException">
        /// The request processing has failed because of an internal error in the service.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded for this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is when you create resources that exceed
        /// your service limit for this resource type. Request a limit increase or delete unused
        /// resources, if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ValidationException">
        /// The resource passed is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/GetTransaction">REST API Reference for GetTransaction Operation</seealso>
        Task<GetTransactionResponse> GetTransactionAsync(GetTransactionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssetContracts



        /// <summary>
        /// Lists all the contracts for a given contract type deployed by an address (either a
        /// contract address or a wallet address).
        /// 
        ///  
        /// <para>
        /// The Bitcoin blockchain networks do not support this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetContracts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetContracts service method, as returned by ManagedBlockchainQuery.</returns>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.AccessDeniedException">
        /// The Amazon Web Services account doesn’t have access to this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.InternalServerException">
        /// The request processing has failed because of an internal error in the service.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded for this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is when you create resources that exceed
        /// your service limit for this resource type. Request a limit increase or delete unused
        /// resources, if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ValidationException">
        /// The resource passed is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListAssetContracts">REST API Reference for ListAssetContracts Operation</seealso>
        Task<ListAssetContractsResponse> ListAssetContractsAsync(ListAssetContractsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFilteredTransactionEvents



        /// <summary>
        /// Lists all the transaction events for an address on the blockchain.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is only supported on the Bitcoin networks.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFilteredTransactionEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFilteredTransactionEvents service method, as returned by ManagedBlockchainQuery.</returns>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.AccessDeniedException">
        /// The Amazon Web Services account doesn’t have access to this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.InternalServerException">
        /// The request processing has failed because of an internal error in the service.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded for this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is when you create resources that exceed
        /// your service limit for this resource type. Request a limit increase or delete unused
        /// resources, if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ValidationException">
        /// The resource passed is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListFilteredTransactionEvents">REST API Reference for ListFilteredTransactionEvents Operation</seealso>
        Task<ListFilteredTransactionEventsResponse> ListFilteredTransactionEventsAsync(ListFilteredTransactionEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTokenBalances



        /// <summary>
        /// This action returns the following for a given blockchain network:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Lists all token balances owned by an address (either a contract address or a wallet
        /// address).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lists all token balances for all tokens created by a contract.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lists all token balances for a given token.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You must always specify the network property of the <c>tokenFilter</c> when using
        /// this operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTokenBalances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTokenBalances service method, as returned by ManagedBlockchainQuery.</returns>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.AccessDeniedException">
        /// The Amazon Web Services account doesn’t have access to this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.InternalServerException">
        /// The request processing has failed because of an internal error in the service.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded for this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is when you create resources that exceed
        /// your service limit for this resource type. Request a limit increase or delete unused
        /// resources, if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ValidationException">
        /// The resource passed is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListTokenBalances">REST API Reference for ListTokenBalances Operation</seealso>
        Task<ListTokenBalancesResponse> ListTokenBalancesAsync(ListTokenBalancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTransactionEvents



        /// <summary>
        /// Lists all the transaction events for a transaction 
        /// 
        ///  <note> 
        /// <para>
        /// This action will return transaction details for all transactions that are <i>confirmed</i>
        /// on the blockchain, even if they have not reached <a href="https://docs.aws.amazon.com/managed-blockchain/latest/ambq-dg/key-concepts.html#finality">finality</a>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransactionEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTransactionEvents service method, as returned by ManagedBlockchainQuery.</returns>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.AccessDeniedException">
        /// The Amazon Web Services account doesn’t have access to this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.InternalServerException">
        /// The request processing has failed because of an internal error in the service.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded for this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is when you create resources that exceed
        /// your service limit for this resource type. Request a limit increase or delete unused
        /// resources, if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ValidationException">
        /// The resource passed is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListTransactionEvents">REST API Reference for ListTransactionEvents Operation</seealso>
        Task<ListTransactionEventsResponse> ListTransactionEventsAsync(ListTransactionEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTransactions



        /// <summary>
        /// Lists all the transaction events for a transaction.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransactions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTransactions service method, as returned by ManagedBlockchainQuery.</returns>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.AccessDeniedException">
        /// The Amazon Web Services account doesn’t have access to this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.InternalServerException">
        /// The request processing has failed because of an internal error in the service.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded for this resource.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ThrottlingException">
        /// The request or operation couldn't be performed because a service is throttling requests.
        /// The most common source of throttling errors is when you create resources that exceed
        /// your service limit for this resource type. Request a limit increase or delete unused
        /// resources, if possible.
        /// </exception>
        /// <exception cref="Amazon.ManagedBlockchainQuery.Model.ValidationException">
        /// The resource passed is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListTransactions">REST API Reference for ListTransactions Operation</seealso>
        Task<ListTransactionsResponse> ListTransactionsAsync(ListTransactionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonManagedBlockchainQueryConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonManagedBlockchainQueryConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonManagedBlockchainQueryConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonManagedBlockchainQueryConfig to create AmazonManagedBlockchainQueryClient");
            }

            return awsCredentials == null ? 
                    new AmazonManagedBlockchainQueryClient(serviceClientConfig) :
                    new AmazonManagedBlockchainQueryClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}