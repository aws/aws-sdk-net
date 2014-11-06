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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Route53.Model;

namespace Amazon.Route53
{
    /// <summary>
    /// Interface for accessing Route53
    ///
    /// 
    /// </summary>
    public partial interface IAmazonRoute53 : IDisposable
    {
                
        #region  AssociateVPCWithHostedZone

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVPCWithHostedZone operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AssociateVPCWithHostedZoneResponse> AssociateVPCWithHostedZoneAsync(AssociateVPCWithHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ChangeResourceRecordSets

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeResourceRecordSets operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ChangeResourceRecordSetsResponse> ChangeResourceRecordSetsAsync(ChangeResourceRecordSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ChangeTagsForResource

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeTagsForResource operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ChangeTagsForResourceResponse> ChangeTagsForResourceAsync(ChangeTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHealthCheck

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHealthCheck operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateHealthCheckResponse> CreateHealthCheckAsync(CreateHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHostedZone

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHostedZone operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateHostedZoneResponse> CreateHostedZoneAsync(CreateHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateReusableDelegationSet

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReusableDelegationSet operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateReusableDelegationSetResponse> CreateReusableDelegationSetAsync(CreateReusableDelegationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHealthCheck

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHealthCheck operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteHealthCheckResponse> DeleteHealthCheckAsync(DeleteHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHostedZone

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHostedZone operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteHostedZoneResponse> DeleteHostedZoneAsync(DeleteHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteReusableDelegationSet

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReusableDelegationSet operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteReusableDelegationSetResponse> DeleteReusableDelegationSetAsync(DeleteReusableDelegationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateVPCFromHostedZone

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVPCFromHostedZone operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisassociateVPCFromHostedZoneResponse> DisassociateVPCFromHostedZoneAsync(DisassociateVPCFromHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetChange

        /// <summary>
        /// Initiates the asynchronous execution of the GetChange operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChange operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetChangeResponse> GetChangeAsync(GetChangeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCheckerIpRanges

        /// <summary>
        /// Initiates the asynchronous execution of the GetCheckerIpRanges operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetCheckerIpRangesResponse> GetCheckerIpRangesAsync(GetCheckerIpRangesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGeoLocation

        /// <summary>
        /// Initiates the asynchronous execution of the GetGeoLocation operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetGeoLocationResponse> GetGeoLocationAsync(GetGeoLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHealthCheck

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheck operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHealthCheckResponse> GetHealthCheckAsync(GetHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHealthCheckCount

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckCount operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHealthCheckCountResponse> GetHealthCheckCountAsync(GetHealthCheckCountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHealthCheckLastFailureReason

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckLastFailureReason operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHealthCheckLastFailureReasonResponse> GetHealthCheckLastFailureReasonAsync(GetHealthCheckLastFailureReasonRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHealthCheckStatus

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckStatus operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHealthCheckStatusResponse> GetHealthCheckStatusAsync(GetHealthCheckStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHostedZone

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZone operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHostedZoneResponse> GetHostedZoneAsync(GetHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetReusableDelegationSet

        /// <summary>
        /// Initiates the asynchronous execution of the GetReusableDelegationSet operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetReusableDelegationSetResponse> GetReusableDelegationSetAsync(GetReusableDelegationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGeoLocations

        /// <summary>
        /// Initiates the asynchronous execution of the ListGeoLocations operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeoLocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListGeoLocationsResponse> ListGeoLocationsAsync(ListGeoLocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHealthChecks

        /// <summary>
        /// Initiates the asynchronous execution of the ListHealthChecks operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHealthChecks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListHealthChecksResponse> ListHealthChecksAsync(ListHealthChecksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHostedZones

        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZones operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZones operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListHostedZonesResponse> ListHostedZonesAsync(ListHostedZonesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourceRecordSets

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceRecordSets operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListResourceRecordSetsResponse> ListResourceRecordSetsAsync(ListResourceRecordSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListReusableDelegationSets

        /// <summary>
        /// Initiates the asynchronous execution of the ListReusableDelegationSets operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(ListReusableDelegationSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResources

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResources operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForResourcesResponse> ListTagsForResourcesAsync(ListTagsForResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHealthCheck

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHealthCheck operation.
        /// <seealso cref="Amazon.Route53.IAmazonRoute53"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateHealthCheckResponse> UpdateHealthCheckAsync(UpdateHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}