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

namespace Amazon.ManagedBlockchainQuery
{
    /// <summary>
    /// Interface for accessing ManagedBlockchainQuery
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IManagedBlockchainQueryPaginatorFactory Paginators { get; }

        
        #region  BatchGetTokenBalance


        /// <summary>
        /// Gets the token balance for a batch of tokens by using the <code>GetTokenBalance</code>
        /// action for every token in the request.
        /// 
        ///  <note> 
        /// <para>
        /// Only the native tokens BTC,ETH, and the ERC-20, ERC-721, and ERC 1155 token standards
        /// are supported.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTokenBalance service method.</param>
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
        BatchGetTokenBalanceResponse BatchGetTokenBalance(BatchGetTokenBalanceRequest request);



        /// <summary>
        /// Gets the token balance for a batch of tokens by using the <code>GetTokenBalance</code>
        /// action for every token in the request.
        /// 
        ///  <note> 
        /// <para>
        /// Only the native tokens BTC,ETH, and the ERC-20, ERC-721, and ERC 1155 token standards
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
        Task<BatchGetTokenBalanceResponse> BatchGetTokenBalanceAsync(BatchGetTokenBalanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTokenBalance


        /// <summary>
        /// Gets the balance of a specific token, including native tokens, for a given address
        /// (wallet or contract) on the blockchain.
        /// 
        ///  <note> 
        /// <para>
        /// Only the native tokens BTC,ETH, and the ERC-20, ERC-721, and ERC 1155 token standards
        /// are supported.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTokenBalance service method.</param>
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
        GetTokenBalanceResponse GetTokenBalance(GetTokenBalanceRequest request);



        /// <summary>
        /// Gets the balance of a specific token, including native tokens, for a given address
        /// (wallet or contract) on the blockchain.
        /// 
        ///  <note> 
        /// <para>
        /// Only the native tokens BTC,ETH, and the ERC-20, ERC-721, and ERC 1155 token standards
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
        Task<GetTokenBalanceResponse> GetTokenBalanceAsync(GetTokenBalanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTransaction


        /// <summary>
        /// Get the details of a transaction.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransaction service method.</param>
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
        GetTransactionResponse GetTransaction(GetTransactionRequest request);



        /// <summary>
        /// Get the details of a transaction.
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
        Task<GetTransactionResponse> GetTransactionAsync(GetTransactionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTokenBalances


        /// <summary>
        /// This action returns the following for a given a blockchain network:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Lists all token balances owned by an address (either a contact address or a wallet
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
        /// You must always specify the network property of the <code>tokenFilter</code> when
        /// using this operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTokenBalances service method.</param>
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
        ListTokenBalancesResponse ListTokenBalances(ListTokenBalancesRequest request);



        /// <summary>
        /// This action returns the following for a given a blockchain network:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Lists all token balances owned by an address (either a contact address or a wallet
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
        /// You must always specify the network property of the <code>tokenFilter</code> when
        /// using this operation.
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
        Task<ListTokenBalancesResponse> ListTokenBalancesAsync(ListTokenBalancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTransactionEvents


        /// <summary>
        /// An array of <code>TransactionEvent</code> objects. Each object contains details about
        /// the transaction event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransactionEvents service method.</param>
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
        ListTransactionEventsResponse ListTransactionEvents(ListTransactionEventsRequest request);



        /// <summary>
        /// An array of <code>TransactionEvent</code> objects. Each object contains details about
        /// the transaction event.
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
        Task<ListTransactionEventsResponse> ListTransactionEventsAsync(ListTransactionEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTransactions


        /// <summary>
        /// Lists all of the transactions on a given wallet address or to a specific contract.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransactions service method.</param>
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
        ListTransactionsResponse ListTransactions(ListTransactionsRequest request);



        /// <summary>
        /// Lists all of the transactions on a given wallet address or to a specific contract.
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
        Task<ListTransactionsResponse> ListTransactionsAsync(ListTransactionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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