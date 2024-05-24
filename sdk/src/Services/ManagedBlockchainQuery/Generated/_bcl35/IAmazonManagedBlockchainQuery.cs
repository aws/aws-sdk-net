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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        /// Initiates the asynchronous execution of the BatchGetTokenBalance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTokenBalance operation on AmazonManagedBlockchainQueryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetTokenBalance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/BatchGetTokenBalance">REST API Reference for BatchGetTokenBalance Operation</seealso>
        IAsyncResult BeginBatchGetTokenBalance(BatchGetTokenBalanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetTokenBalance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetTokenBalance.</param>
        /// 
        /// <returns>Returns a  BatchGetTokenBalanceResult from ManagedBlockchainQuery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/BatchGetTokenBalance">REST API Reference for BatchGetTokenBalance Operation</seealso>
        BatchGetTokenBalanceResponse EndBatchGetTokenBalance(IAsyncResult asyncResult);

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
        GetAssetContractResponse GetAssetContract(GetAssetContractRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssetContract operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssetContract operation on AmazonManagedBlockchainQueryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssetContract
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/GetAssetContract">REST API Reference for GetAssetContract Operation</seealso>
        IAsyncResult BeginGetAssetContract(GetAssetContractRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssetContract operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssetContract.</param>
        /// 
        /// <returns>Returns a  GetAssetContractResult from ManagedBlockchainQuery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/GetAssetContract">REST API Reference for GetAssetContract Operation</seealso>
        GetAssetContractResponse EndGetAssetContract(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetTokenBalance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTokenBalance operation on AmazonManagedBlockchainQueryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTokenBalance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/GetTokenBalance">REST API Reference for GetTokenBalance Operation</seealso>
        IAsyncResult BeginGetTokenBalance(GetTokenBalanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTokenBalance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTokenBalance.</param>
        /// 
        /// <returns>Returns a  GetTokenBalanceResult from ManagedBlockchainQuery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/GetTokenBalance">REST API Reference for GetTokenBalance Operation</seealso>
        GetTokenBalanceResponse EndGetTokenBalance(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransaction operation on AmazonManagedBlockchainQueryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/GetTransaction">REST API Reference for GetTransaction Operation</seealso>
        IAsyncResult BeginGetTransaction(GetTransactionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTransaction.</param>
        /// 
        /// <returns>Returns a  GetTransactionResult from ManagedBlockchainQuery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/GetTransaction">REST API Reference for GetTransaction Operation</seealso>
        GetTransactionResponse EndGetTransaction(IAsyncResult asyncResult);

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
        ListAssetContractsResponse ListAssetContracts(ListAssetContractsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssetContracts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssetContracts operation on AmazonManagedBlockchainQueryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssetContracts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListAssetContracts">REST API Reference for ListAssetContracts Operation</seealso>
        IAsyncResult BeginListAssetContracts(ListAssetContractsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssetContracts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssetContracts.</param>
        /// 
        /// <returns>Returns a  ListAssetContractsResult from ManagedBlockchainQuery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListAssetContracts">REST API Reference for ListAssetContracts Operation</seealso>
        ListAssetContractsResponse EndListAssetContracts(IAsyncResult asyncResult);

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
        ListFilteredTransactionEventsResponse ListFilteredTransactionEvents(ListFilteredTransactionEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFilteredTransactionEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFilteredTransactionEvents operation on AmazonManagedBlockchainQueryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFilteredTransactionEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListFilteredTransactionEvents">REST API Reference for ListFilteredTransactionEvents Operation</seealso>
        IAsyncResult BeginListFilteredTransactionEvents(ListFilteredTransactionEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFilteredTransactionEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFilteredTransactionEvents.</param>
        /// 
        /// <returns>Returns a  ListFilteredTransactionEventsResult from ManagedBlockchainQuery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListFilteredTransactionEvents">REST API Reference for ListFilteredTransactionEvents Operation</seealso>
        ListFilteredTransactionEventsResponse EndListFilteredTransactionEvents(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTokenBalances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTokenBalances operation on AmazonManagedBlockchainQueryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTokenBalances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListTokenBalances">REST API Reference for ListTokenBalances Operation</seealso>
        IAsyncResult BeginListTokenBalances(ListTokenBalancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTokenBalances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTokenBalances.</param>
        /// 
        /// <returns>Returns a  ListTokenBalancesResult from ManagedBlockchainQuery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListTokenBalances">REST API Reference for ListTokenBalances Operation</seealso>
        ListTokenBalancesResponse EndListTokenBalances(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTransactionEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTransactionEvents operation on AmazonManagedBlockchainQueryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTransactionEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListTransactionEvents">REST API Reference for ListTransactionEvents Operation</seealso>
        IAsyncResult BeginListTransactionEvents(ListTransactionEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTransactionEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTransactionEvents.</param>
        /// 
        /// <returns>Returns a  ListTransactionEventsResult from ManagedBlockchainQuery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListTransactionEvents">REST API Reference for ListTransactionEvents Operation</seealso>
        ListTransactionEventsResponse EndListTransactionEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTransactions


        /// <summary>
        /// Lists all the transaction events for a transaction.
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
        /// Initiates the asynchronous execution of the ListTransactions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTransactions operation on AmazonManagedBlockchainQueryClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTransactions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListTransactions">REST API Reference for ListTransactions Operation</seealso>
        IAsyncResult BeginListTransactions(ListTransactionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTransactions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTransactions.</param>
        /// 
        /// <returns>Returns a  ListTransactionsResult from ManagedBlockchainQuery.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/managedblockchain-query-2023-05-04/ListTransactions">REST API Reference for ListTransactions Operation</seealso>
        ListTransactionsResponse EndListTransactions(IAsyncResult asyncResult);

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