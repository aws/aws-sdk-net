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
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AssociateVPCWithHostedZoneResponse> AssociateVPCWithHostedZoneAsync(AssociateVPCWithHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ChangeResourceRecordSets


        /// <summary>
        /// Initiates the asynchronous execution of the ChangeResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ChangeResourceRecordSetsResponse> ChangeResourceRecordSetsAsync(ChangeResourceRecordSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ChangeTagsForResource


        /// <summary>
        /// Initiates the asynchronous execution of the ChangeTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ChangeTagsForResourceResponse> ChangeTagsForResourceAsync(ChangeTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHealthCheck


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateHealthCheckResponse> CreateHealthCheckAsync(CreateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHostedZone


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateHostedZoneResponse> CreateHostedZoneAsync(CreateHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateReusableDelegationSet


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateReusableDelegationSetResponse> CreateReusableDelegationSetAsync(CreateReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrafficPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateTrafficPolicyResponse> CreateTrafficPolicyAsync(CreateTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrafficPolicyInstance


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateTrafficPolicyInstanceResponse> CreateTrafficPolicyInstanceAsync(CreateTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrafficPolicyVersion


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateTrafficPolicyVersionResponse> CreateTrafficPolicyVersionAsync(CreateTrafficPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHealthCheck


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteHealthCheckResponse> DeleteHealthCheckAsync(DeleteHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHostedZone


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteHostedZoneResponse> DeleteHostedZoneAsync(DeleteHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteReusableDelegationSet


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteReusableDelegationSetResponse> DeleteReusableDelegationSetAsync(DeleteReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrafficPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTrafficPolicyResponse> DeleteTrafficPolicyAsync(DeleteTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrafficPolicyInstance


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTrafficPolicyInstanceResponse> DeleteTrafficPolicyInstanceAsync(DeleteTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateVPCFromHostedZone


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVPCFromHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisassociateVPCFromHostedZoneResponse> DisassociateVPCFromHostedZoneAsync(DisassociateVPCFromHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetChange


        /// <summary>
        /// Initiates the asynchronous execution of the GetChange operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChange operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetChangeResponse> GetChangeAsync(GetChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetChangeDetails


        /// <summary>
        /// Initiates the asynchronous execution of the GetChangeDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChangeDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        Task<GetChangeDetailsResponse> GetChangeDetailsAsync(GetChangeDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCheckerIpRanges


        /// <summary>
        /// Initiates the asynchronous execution of the GetCheckerIpRanges operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetCheckerIpRangesResponse> GetCheckerIpRangesAsync(GetCheckerIpRangesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGeoLocation


        /// <summary>
        /// Initiates the asynchronous execution of the GetGeoLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetGeoLocationResponse> GetGeoLocationAsync(GetGeoLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHealthCheck


        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHealthCheckResponse> GetHealthCheckAsync(GetHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHealthCheckCount


        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHealthCheckCountResponse> GetHealthCheckCountAsync(GetHealthCheckCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHealthCheckLastFailureReason


        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckLastFailureReason operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHealthCheckLastFailureReasonResponse> GetHealthCheckLastFailureReasonAsync(GetHealthCheckLastFailureReasonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHealthCheckStatus


        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHealthCheckStatusResponse> GetHealthCheckStatusAsync(GetHealthCheckStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHostedZone


        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHostedZoneResponse> GetHostedZoneAsync(GetHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHostedZoneCount


        /// <summary>
        /// Retrieves a count of all your hosted zones. Send a <code>GET</code> request to the
        /// <code>/2013-04-01/hostedzonecount</code> resource.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        Task<GetHostedZoneCountResponse> GetHostedZoneCountAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZoneCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetHostedZoneCountResponse> GetHostedZoneCountAsync(GetHostedZoneCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetReusableDelegationSet


        /// <summary>
        /// Initiates the asynchronous execution of the GetReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetReusableDelegationSetResponse> GetReusableDelegationSetAsync(GetReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTrafficPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetTrafficPolicyResponse> GetTrafficPolicyAsync(GetTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTrafficPolicyInstance


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetTrafficPolicyInstanceResponse> GetTrafficPolicyInstanceAsync(GetTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTrafficPolicyInstanceCount


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicyInstanceCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstanceCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetTrafficPolicyInstanceCountResponse> GetTrafficPolicyInstanceCountAsync(GetTrafficPolicyInstanceCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChangeBatchesByHostedZone


        /// <summary>
        /// Initiates the asynchronous execution of the ListChangeBatchesByHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        Task<ListChangeBatchesByHostedZoneResponse> ListChangeBatchesByHostedZoneAsync(ListChangeBatchesByHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChangeBatchesByRRSet


        /// <summary>
        /// Initiates the asynchronous execution of the ListChangeBatchesByRRSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByRRSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        Task<ListChangeBatchesByRRSetResponse> ListChangeBatchesByRRSetAsync(ListChangeBatchesByRRSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGeoLocations


        /// <summary>
        /// Retrieves a list of supported geo locations. Send a <code>GET</code> request to the
        /// <code>/2013-04-01/geolocations</code> resource. The response to this request includes
        /// a <code>GeoLocationDetailsList</code> element for each location that Amazon Route
        /// 53 supports.
        /// 
        ///  
        /// <para>
        /// Countries are listed first, and continents are listed last. If Amazon Route 53 supports
        /// subdivisions for a country (for example, states or provinces), the subdivisions for
        /// that country are listed in alphabetical order immediately after the corresponding
        /// country. 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        Task<ListGeoLocationsResponse> ListGeoLocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListGeoLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeoLocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListGeoLocationsResponse> ListGeoLocationsAsync(ListGeoLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHealthChecks


        /// <summary>
        /// Retrieve a list of your health checks. Send a <code>GET</code> request to the <code>/2013-04-01/healthcheck</code>
        /// resource. The response to this request includes a <code>HealthChecks</code> element
        /// with zero or more <code>HealthCheck</code> child elements. By default, the list of
        /// health checks is displayed on a single page. You can control the length of the page
        /// that is displayed by using the <code>MaxItems</code> parameter. You can use the <code>Marker</code>
        /// parameter to control the health check that the list begins with.
        /// 
        ///  
        /// <para>
        /// For information about listing health checks using the Amazon Route 53 console, see
        /// <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover.html">Amazon
        /// Route 53 Health Checks and DNS Failover</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Amazon Route 53 endpoint.
        /// Please consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        Task<ListHealthChecksResponse> ListHealthChecksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListHealthChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHealthChecks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListHealthChecksResponse> ListHealthChecksAsync(ListHealthChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHostedZones


        /// <summary>
        /// To retrieve a list of your public and private hosted zones, send a <code>GET</code>
        /// request to the <code>/2013-04-01/hostedzone</code> resource. The response to this
        /// request includes a <code>HostedZones</code> child element for each hosted zone created
        /// by the current AWS account.
        /// 
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of hosted zones, you can use the <code>maxitems</code> parameter to list them in groups
        /// of up to 100. The response includes four values that help navigate from one group
        /// of <code>maxitems</code> hosted zones to the next:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>MaxItems</code>is the value specified for the <code>maxitems</code> parameter
        /// in the request that produced the current response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is true, there are more hosted
        /// zones associated with the current AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NextMarker</code>is the hosted zone ID of the next hosted zone that is associated
        /// with the current AWS account. If you want to list more hosted zones, make another
        /// call to <code>ListHostedZones</code>, and specify the value of the <code>NextMarker</code>
        /// element in the marker parameter. 
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is false, the <code>NextMarker</code> element is omitted
        /// from the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you're making the second or subsequent call to <code>ListHostedZones</code>, the
        /// <code>Marker</code> element matches the value that you specified in the <code>marker</code>
        /// parameter in the previous request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        Task<ListHostedZonesResponse> ListHostedZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZones operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListHostedZonesResponse> ListHostedZonesAsync(ListHostedZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHostedZonesByName


        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZonesByName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZonesByName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListHostedZonesByNameResponse> ListHostedZonesByNameAsync(ListHostedZonesByNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourceRecordSets


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListResourceRecordSetsResponse> ListResourceRecordSetsAsync(ListResourceRecordSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListReusableDelegationSets


        /// <summary>
        /// To retrieve a list of your reusable delegation sets, send a <code>GET</code> request
        /// to the <code>/2013-04-01/delegationset</code> resource. The response to this request
        /// includes a <code>DelegationSets</code> element with zero, one, or multiple <code>DelegationSet</code>
        /// child elements. By default, the list of delegation sets is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the delegation
        /// set that the list begins with. 
        /// 
        ///  <note> 
        /// <para>
        ///  Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value greater
        /// than 100, Amazon Route 53 returns only the first 100.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListReusableDelegationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(ListReusableDelegationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResources


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForResourcesResponse> ListTagsForResourcesAsync(ListTagsForResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrafficPolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTrafficPoliciesResponse> ListTrafficPoliciesAsync(ListTrafficPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrafficPolicyInstances


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTrafficPolicyInstancesResponse> ListTrafficPolicyInstancesAsync(ListTrafficPolicyInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrafficPolicyInstancesByHostedZone


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstancesByHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTrafficPolicyInstancesByHostedZoneResponse> ListTrafficPolicyInstancesByHostedZoneAsync(ListTrafficPolicyInstancesByHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrafficPolicyInstancesByPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstancesByPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTrafficPolicyInstancesByPolicyResponse> ListTrafficPolicyInstancesByPolicyAsync(ListTrafficPolicyInstancesByPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrafficPolicyVersions


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTrafficPolicyVersionsResponse> ListTrafficPolicyVersionsAsync(ListTrafficPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestDNSAnswer


        /// <summary>
        /// Initiates the asynchronous execution of the TestDNSAnswer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestDNSAnswer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TestDNSAnswerResponse> TestDNSAnswerAsync(TestDNSAnswerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHealthCheck


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateHealthCheckResponse> UpdateHealthCheckAsync(UpdateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHostedZoneComment


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHostedZoneComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateHostedZoneCommentResponse> UpdateHostedZoneCommentAsync(UpdateHostedZoneCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrafficPolicyComment


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrafficPolicyComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateTrafficPolicyCommentResponse> UpdateTrafficPolicyCommentAsync(UpdateTrafficPolicyCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrafficPolicyInstance


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateTrafficPolicyInstanceResponse> UpdateTrafficPolicyInstanceAsync(UpdateTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}