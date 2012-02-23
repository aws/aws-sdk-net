/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.Route53;
using Amazon.Route53.Model;

namespace Amazon.Route53
{
    /// <summary>
    /// Interface for accessing AmazonRoute53.
    ///  
    ///  
    /// </summary>
    public interface AmazonRoute53 : IDisposable
    {
        

         /// <summary>
         /// <para>This action deletes a hosted zone. To delete a hosted zone, send a <c>DELETE</c> request to the <c>2011-05-05/hostedzone/hosted zone
         /// ID </c> resource.</para> <para>For more information about deleting a hosted zone, see Deleting a Hosted Zone in the Amazon Route 53
         /// Developer Guide.</para> <para><b>IMPORTANT:</b> You can delete a hosted zone only if there are no resource record sets other than the
         /// default SOA record and NS resource record sets. If your hosted zone contains other resource record sets, you must delete them before you can
         /// delete your hosted zone. If you try to delete a hosted zone that contains other resource record sets, Route 53 will deny your request with a
         /// HostedZoneNotEmpty error. For information about deleting records from your hosted zone, see ChangeResourceRecordSets.</para>
         /// </summary>
         /// 
         /// <param name="deleteHostedZoneRequest">Container for the necessary parameters to execute the DeleteHostedZone service method on
         ///           AmazonRoute53.</param>
         /// 
         /// <returns>The response from the DeleteHostedZone service method, as returned by AmazonRoute53.</returns>
         /// 
         /// <exception cref="InvalidInputException"/>
         /// <exception cref="HostedZoneNotEmptyException"/>
        DeleteHostedZoneResponse DeleteHostedZone(DeleteHostedZoneRequest deleteHostedZoneRequest); 

         /// <summary>
         /// <para>Imagine all the resource record sets in a zone listed out in front of you. Imagine them sorted lexicographically first by DNS name
         /// (with the labels reversed, like "com.amazon.www" for example), and secondarily, lexicographically by record type. This operation retrieves
         /// at most MaxItems resource record sets from this list, in order, starting at a position specified by the Name and Type arguments:</para>
         /// <ul>
         /// <li>If both Name and Type are omitted, this means start the results at the first RRSET in the HostedZone.</li>
         /// <li>If Name is specified but Type is omitted, this means start the results at the first RRSET in the list whose name is greater than or
         /// equal to Name. </li>
         /// <li>If both Name and Type are specified, this means start the results at the first RRSET in the list whose name is greater than or equal to
         /// Name and whose type is greater than or equal to Type.</li>
         /// <li>It is an error to specify the Type but not the Name.</li>
         /// 
         /// </ul>
         /// <para>Use ListResourceRecordSets to retrieve a single known record set by specifying the record set's name and type, and setting MaxItems =
         /// 1</para> <para>To retrieve all the records in a HostedZone, first pause any processes making calls to ChangeResourceRecordSets. Initially
         /// call ListResourceRecordSets without a Name and Type to get the first page of record sets. For subsequent calls, set Name and Type to the
         /// NextName and NextType values returned by the previous response. </para> <para>In the presence of concurrent ChangeResourceRecordSets calls,
         /// there is no consistency of results across calls to ListResourceRecordSets. The only way to get a consistent multi-page snapshot of all
         /// RRSETs in a zone is to stop making changes while pagination is in progress.</para> <para>However, the results from ListResourceRecordSets
         /// are consistent within a page. If MakeChange calls are taking place concurrently, the result of each one will either be completely visible in
         /// your results or not at all. You will not see partial changes, or changes that do not ultimately succeed. (This follows from the fact that
         /// MakeChange is atomic) </para> <para>The results from ListResourceRecordSets are strongly consistent with ChangeResourceRecordSets. To be
         /// precise, if a single process makes a call to ChangeResourceRecordSets and receives a successful response, the effects of that change will be
         /// visible in a subsequent call to ListResourceRecordSets by that process.</para>
         /// </summary>
         /// 
         /// <param name="listResourceRecordSetsRequest">Container for the necessary parameters to execute the ListResourceRecordSets service method on
         ///           AmazonRoute53.</param>
         /// 
         /// <returns>The response from the ListResourceRecordSets service method, as returned by AmazonRoute53.</returns>
         /// 
         /// <exception cref="InvalidInputException"/>
        ListResourceRecordSetsResponse ListResourceRecordSets(ListResourceRecordSetsRequest listResourceRecordSetsRequest); 

         /// <summary>
         /// <para>Use this action to create or change your authoritative DNS information. To use this action, send a <c>POST</c> request to the
         /// <c>2011-05-05/hostedzone/hosted Zone ID/rrset</c> resource. The request body must include an XML document with a
         /// <c>ChangeResourceRecordSetsRequest</c> element.</para> <para>Changes are a list of change items and are considered transactional. For more
         /// information on transactional changes, also known as change batches, see Creating, Changing, and Deleting Resource Record Sets Using the
         /// Route 53 API in the <i>Amazon Route 53 Developer Guide</i> .</para> <para><b>IMPORTANT:</b>Due to the nature of transactional changes, you
         /// cannot delete the same resource record set more than once in a single change batch. If you attempt to delete the same change batch more than
         /// once, Route 53 returns an InvalidChangeBatch error.</para> <para>In response to a <c>ChangeResourceRecordSets</c> request, your DNS data is
         /// changed on all Route 53 DNS servers. Initially, the status of a change is <c>PENDING</c> . This means the change has not yet propagated to
         /// all the authoritative Route 53 DNS servers. When the change is propagated to all hosts, the change returns a status of <c>INSYNC</c>
         /// .</para> <para>Note the following limitations on a <c>ChangeResourceRecordSets</c> request:</para> <para>- A request cannot contain more
         /// than 100 Change elements.</para> <para>- A request cannot contain more than 1000 ResourceRecord elements.</para> <para>The sum of the number
         /// of characters (including spaces) in all <c>Value</c> elements in a request cannot exceed 32,000 characters.</para>
         /// </summary>
         /// 
         /// <param name="changeResourceRecordSetsRequest">Container for the necessary parameters to execute the ChangeResourceRecordSets service method
         ///           on AmazonRoute53.</param>
         /// 
         /// <returns>The response from the ChangeResourceRecordSets service method, as returned by AmazonRoute53.</returns>
         /// 
         /// <exception cref="InvalidInputException"/>
         /// <exception cref="InvalidChangeBatchException"/>
        ChangeResourceRecordSetsResponse ChangeResourceRecordSets(ChangeResourceRecordSetsRequest changeResourceRecordSetsRequest); 

         /// <summary>
         /// <para> This action returns the current status of a change batch request. The status is one of the following values:</para> <para>-
         /// <c>PENDING</c> indicates that the changes in this request have not replicated to all Route 53 DNS servers. This is the initial status of all
         /// change batch requests.</para> <para>- <c>INSYNC</c> indicates that the changes have replicated to all Amazon Route 53 DNS servers. </para>
         /// </summary>
         /// 
         /// <param name="getChangeRequest">Container for the necessary parameters to execute the GetChange service method on AmazonRoute53.</param>
         /// 
         /// <returns>The response from the GetChange service method, as returned by AmazonRoute53.</returns>
         /// 
         /// <exception cref="InvalidInputException"/>
        GetChangeResponse GetChange(GetChangeRequest getChangeRequest); 

         /// <summary>
         /// <para> This action creates a new hosted zone.</para> <para>To create a new hosted zone, send a <c>POST</c> request to the
         /// <c>2011-05-05/hostedzone</c> resource. The request body must include an XML document with a <c>CreateHostedZoneRequest</c> element. The
         /// response returns the <c>CreateHostedZoneResponse</c> element that contains metadata about the hosted zone.</para> <para>Route 53
         /// automatically creates a default SOA record and four NS records for the zone. The NS records in the hosted zone are the name servers you give
         /// your registrar to delegate your domain to. For more information about SOA and NS records, see NS and SOA Records that Route 53 Creates for a
         /// Hosted Zone in the <i>Amazon Route 53 Developer Guide</i> .</para> <para>When you create a zone, its initial status is <c>PENDING</c> . This
         /// means that it is not yet available on all DNS servers. The status of the zone changes to <c>INSYNC</c> when the NS and SOA records are
         /// available on all Route 53 DNS servers. </para>
         /// </summary>
         /// 
         /// <param name="createHostedZoneRequest">Container for the necessary parameters to execute the CreateHostedZone service method on
         ///           AmazonRoute53.</param>
         /// 
         /// <returns>The response from the CreateHostedZone service method, as returned by AmazonRoute53.</returns>
         /// 
         /// <exception cref="TooManyHostedZonesException"/>
         /// <exception cref="InvalidInputException"/>
         /// <exception cref="HostedZoneAlreadyExistsException"/>
         /// <exception cref="DelegationSetNotAvailableException"/>
         /// <exception cref="InvalidDomainNameException"/>
        CreateHostedZoneResponse CreateHostedZone(CreateHostedZoneRequest createHostedZoneRequest); 

         /// <summary>
         /// <para> To retrieve the delegation set for a hosted zone, send a <c>GET</c> request to the <c>2011-05-05/hostedzone/hosted zone ID </c>
         /// resource. The delegation set is the four Route 53 name servers that were assigned to the hosted zone when you created it.</para>
         /// </summary>
         /// 
         /// <param name="getHostedZoneRequest">Container for the necessary parameters to execute the GetHostedZone service method on
         ///           AmazonRoute53.</param>
         /// 
         /// <returns>The response from the GetHostedZone service method, as returned by AmazonRoute53.</returns>
         /// 
         /// <exception cref="InvalidInputException"/>
        GetHostedZoneResponse GetHostedZone(GetHostedZoneRequest getHostedZoneRequest); 

         /// <summary>
         /// <para> To retrieve a list of your hosted zones, send a <c>GET</c> request to the <c>2011-05-05/hostedzone</c> resource. The response to this
         /// request includes a <c>HostedZones</c> element with zero, one, or multiple <c>HostedZone</c> child elements. By default, the list of hosted
         /// zones is displayed on a single page. You can control the length of the page that is displayed by using the <c>MaxItems</c> parameter. You
         /// can use the <c>Marker</c> parameter to control the hosted zone that the list begins with. </para> <para><b>NOTE:</b> Amazon Route 53 returns
         /// a maximum of 100 items. If you set MaxItems to a value greater than 100, Amazon Route 53 returns only the first 100.</para>
         /// </summary>
         /// 
         /// <param name="listHostedZonesRequest">Container for the necessary parameters to execute the ListHostedZones service method on
         ///           AmazonRoute53.</param>
         /// 
         /// <returns>The response from the ListHostedZones service method, as returned by AmazonRoute53.</returns>
         /// 
         /// <exception cref="InvalidInputException"/>
        ListHostedZonesResponse ListHostedZones(ListHostedZonesRequest listHostedZonesRequest); 

         /// <summary>
         /// <para> To retrieve a list of your hosted zones, send a <c>GET</c> request to the <c>2011-05-05/hostedzone</c> resource. The response to this
         /// request includes a <c>HostedZones</c> element with zero, one, or multiple <c>HostedZone</c> child elements. By default, the list of hosted
         /// zones is displayed on a single page. You can control the length of the page that is displayed by using the <c>MaxItems</c> parameter. You
         /// can use the <c>Marker</c> parameter to control the hosted zone that the list begins with. </para> <para><b>NOTE:</b> Amazon Route 53 returns
         /// a maximum of 100 items. If you set MaxItems to a value greater than 100, Amazon Route 53 returns only the first 100.</para>
         /// </summary>
         /// 
         /// <returns>The response from the ListHostedZones service method, as returned by AmazonRoute53.</returns>
         /// 
         /// <exception cref="InvalidInputException"/>
        ListHostedZonesResponse ListHostedZones();
    }
}
    
