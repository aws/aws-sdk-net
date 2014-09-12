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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Route53Domains.Model;

namespace Amazon.Route53Domains
{
    /// <summary>
    /// Interface for accessing Route53Domains
    ///
    /// 
    /// </summary>
    public partial interface IAmazonRoute53Domains : IDisposable
    {
                
        #region  CheckDomainAvailability


        /// <summary>
        /// Initiates the asynchronous execution of the CheckDomainAvailability operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDomainAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CheckDomainAvailabilityResponse> CheckDomainAvailabilityAsync(CheckDomainAvailabilityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableDomainTransferLock


        /// <summary>
        /// Initiates the asynchronous execution of the DisableDomainTransferLock operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableDomainTransferLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableDomainTransferLockResponse> DisableDomainTransferLockAsync(DisableDomainTransferLockRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableDomainTransferLock


        /// <summary>
        /// Initiates the asynchronous execution of the EnableDomainTransferLock operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableDomainTransferLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableDomainTransferLockResponse> EnableDomainTransferLockAsync(EnableDomainTransferLockRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDomainDetail


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainDetail operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDomainDetailResponse> GetDomainDetailAsync(GetDomainDetailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetOperationDetail


        /// <summary>
        /// Initiates the asynchronous execution of the GetOperationDetail operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperationDetail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetOperationDetailResponse> GetOperationDetailAsync(GetOperationDetailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomains


        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOperations


        /// <summary>
        /// Initiates the asynchronous execution of the ListOperations operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOperations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterDomain


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDomain operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RetrieveDomainAuthCode


        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveDomainAuthCode operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveDomainAuthCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RetrieveDomainAuthCodeResponse> RetrieveDomainAuthCodeAsync(RetrieveDomainAuthCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TransferDomain


        /// <summary>
        /// Initiates the asynchronous execution of the TransferDomain operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TransferDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TransferDomainResponse> TransferDomainAsync(TransferDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDomainContact


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainContact operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDomainContactResponse> UpdateDomainContactAsync(UpdateDomainContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDomainContactPrivacy


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainContactPrivacy operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainContactPrivacy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDomainContactPrivacyResponse> UpdateDomainContactPrivacyAsync(UpdateDomainContactPrivacyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDomainNameservers


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainNameservers operation.
        /// <seealso cref="Amazon.Route53Domains.IAmazonRoute53Domains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainNameservers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDomainNameserversResponse> UpdateDomainNameserversAsync(UpdateDomainNameserversRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}