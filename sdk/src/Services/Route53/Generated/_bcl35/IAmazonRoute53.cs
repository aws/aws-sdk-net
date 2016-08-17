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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Route53.Model;

namespace Amazon.Route53
{
    /// <summary>
    /// Interface for accessing Route53
    ///
    /// 
    /// </summary>
    public partial interface IAmazonRoute53 : IAmazonService, IDisposable
    {

        
        #region  AssociateVPCWithHostedZone


        /// <summary>
        /// This action associates a VPC with an hosted zone. 
        /// 
        ///  
        /// <para>
        /// To associate a VPC with an hosted zone, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/hostedzone/<i>hosted zone ID</i>/associatevpc</code> resource.
        /// The request body must include a document with a <code>AssociateVPCWithHostedZoneRequest</code>
        /// element. The response returns the <code>AssociateVPCWithHostedZoneResponse</code>
        /// element that contains <code>ChangeInfo</code> for you to track the progress of the
        /// <code>AssociateVPCWithHostedZoneRequest</code> you made. See <code>GetChange</code>
        /// operation for how to track the progress of your change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone service method.</param>
        /// 
        /// <returns>The response from the AssociateVPCWithHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingDomainExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Amazon
        /// Route 53 returns this error when the VPC specified by <code>VPCId</code> does not
        /// belong to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LimitsExceededException">
        /// The limits specified for a resource have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PublicZoneVPCAssociationException">
        /// The hosted zone you are trying to associate VPC with doesn't have any VPC association.
        /// Amazon Route 53 currently doesn't support associate a VPC with a public hosted zone.
        /// </exception>
        AssociateVPCWithHostedZoneResponse AssociateVPCWithHostedZone(AssociateVPCWithHostedZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVPCWithHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateVPCWithHostedZone
        ///         operation.</returns>
        IAsyncResult BeginAssociateVPCWithHostedZone(AssociateVPCWithHostedZoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateVPCWithHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateVPCWithHostedZone.</param>
        /// 
        /// <returns>Returns a  AssociateVPCWithHostedZoneResult from Route53.</returns>
        AssociateVPCWithHostedZoneResponse EndAssociateVPCWithHostedZone(IAsyncResult asyncResult);

        #endregion
        
        #region  ChangeResourceRecordSets


        /// <summary>
        /// Use this action to create or change your authoritative DNS information. To use this
        /// action, send a <code>POST</code> request to the <code>/<i>Route 53 API version</i>/hostedzone/<i>hosted
        /// Zone ID</i>/rrset</code> resource. The request body must include a document with a
        /// <code>ChangeResourceRecordSetsRequest</code> element.
        /// 
        ///  
        /// <para>
        /// Changes are a list of change items and are considered transactional. For more information
        /// on transactional changes, also known as change batches, see <a href="http://docs.aws.amazon.com/Route53/latest/APIReference/API_ChangeResourceRecordSets.html">POST
        /// ChangeResourceRecordSets</a> in the <i>Amazon Route 53 API Reference</i>.
        /// </para>
        ///  <important>Due to the nature of transactional changes, you cannot delete the same
        /// resource record set more than once in a single change batch. If you attempt to delete
        /// the same change batch more than once, Amazon Route 53 returns an <code>InvalidChangeBatch</code>
        /// error.</important> 
        /// <para>
        /// In response to a <code>ChangeResourceRecordSets</code> request, your DNS data is changed
        /// on all Amazon Route 53 DNS servers. Initially, the status of a change is <code>PENDING</code>.
        /// This means the change has not yet propagated to all the authoritative Amazon Route
        /// 53 DNS servers. When the change is propagated to all hosts, the change returns a status
        /// of <code>INSYNC</code>.
        /// </para>
        ///  
        /// <para>
        /// Note the following limitations on a <code>ChangeResourceRecordSets</code> request:
        /// </para>
        ///  <ul> <li>A request cannot contain more than 100 Change elements.</li> <li> A request
        /// cannot contain more than 1000 ResourceRecord elements.</li> <li>The sum of the number
        /// of characters (including spaces) in all <code>Value</code> elements in a request cannot
        /// exceed 32,000 characters.</li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets service method.</param>
        /// 
        /// <returns>The response from the ChangeResourceRecordSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidChangeBatchException">
        /// This error contains a list of one or more error messages. Each error message indicates
        /// one error in the change batch.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        ChangeResourceRecordSetsResponse ChangeResourceRecordSets(ChangeResourceRecordSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndChangeResourceRecordSets
        ///         operation.</returns>
        IAsyncResult BeginChangeResourceRecordSets(ChangeResourceRecordSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ChangeResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangeResourceRecordSets.</param>
        /// 
        /// <returns>Returns a  ChangeResourceRecordSetsResult from Route53.</returns>
        ChangeResourceRecordSetsResponse EndChangeResourceRecordSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ChangeTagsForResource


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ChangeTagsForResource service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// 
        /// </exception>
        ChangeTagsForResourceResponse ChangeTagsForResource(ChangeTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndChangeTagsForResource
        ///         operation.</returns>
        IAsyncResult BeginChangeTagsForResource(ChangeTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ChangeTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangeTagsForResource.</param>
        /// 
        /// <returns>Returns a  ChangeTagsForResourceResult from Route53.</returns>
        ChangeTagsForResourceResponse EndChangeTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateHealthCheck


        /// <summary>
        /// This action creates a new health check.
        /// 
        ///  
        /// <para>
        /// To create a new health check, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/healthcheck</code> resource. The request body must include a document
        /// with a <code>CreateHealthCheckRequest</code> element. The response returns the <code>CreateHealthCheckResponse</code>
        /// element that contains metadata about the health check.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the CreateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckAlreadyExistsException">
        /// The health check you are trying to create already exists. Amazon Route 53 returns
        /// this error when a health check has already been created with the specified <code>CallerReference</code>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyHealthChecksException">
        /// 
        /// </exception>
        CreateHealthCheckResponse CreateHealthCheck(CreateHealthCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHealthCheck
        ///         operation.</returns>
        IAsyncResult BeginCreateHealthCheck(CreateHealthCheckRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHealthCheck.</param>
        /// 
        /// <returns>Returns a  CreateHealthCheckResult from Route53.</returns>
        CreateHealthCheckResponse EndCreateHealthCheck(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateHostedZone


        /// <summary>
        /// This action creates a new hosted zone.
        /// 
        ///  
        /// <para>
        /// To create a new hosted zone, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/hostedzone</code> resource. The request body must include a document
        /// with a <code>CreateHostedZoneRequest</code> element. The response returns the <code>CreateHostedZoneResponse</code>
        /// element that contains metadata about the hosted zone.
        /// </para>
        ///  
        /// <para>
        /// Amazon Route 53 automatically creates a default SOA record and four NS records for
        /// the zone. The NS records in the hosted zone are the name servers you give your registrar
        /// to delegate your domain to. For more information about SOA and NS records, see <a
        /// href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/SOA-NSrecords.html">NS
        /// and SOA Records that Amazon Route 53 Creates for a Hosted Zone</a> in the <i>Amazon
        /// Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you create a zone, its initial status is <code>PENDING</code>. This means that
        /// it is not yet available on all DNS servers. The status of the zone changes to <code>INSYNC</code>
        /// when the NS and SOA records are available on all Amazon Route 53 DNS servers. 
        /// </para>
        ///  
        /// <para>
        /// When trying to create a hosted zone using a reusable delegation set, you could specify
        /// an optional DelegationSetId, and Route53 would assign those 4 NS records for the zone,
        /// instead of alloting a new one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone service method.</param>
        /// 
        /// <returns>The response from the CreateHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingDomainExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotAvailableException">
        /// Amazon Route 53 allows some duplicate domain names, but there is a maximum number
        /// of duplicate names. This error indicates that you have reached that maximum. If you
        /// want to create another hosted zone with the same name and Amazon Route 53 generates
        /// this error, you can request an increase to the limit on the <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZoneAlreadyExistsException">
        /// The hosted zone you are trying to create already exists. Amazon Route 53 returns this
        /// error when a hosted zone has already been created with the specified <code>CallerReference</code>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidDomainNameException">
        /// This error indicates that the specified domain name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Amazon
        /// Route 53 returns this error when the VPC specified by <code>VPCId</code> does not
        /// belong to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyHostedZonesException">
        /// This error indicates that you've reached the maximum number of hosted zones that can
        /// be created for the current AWS account. You can request an increase to the limit on
        /// the <a href="http://aws.amazon.com/route53-request/">Contact Us</a> page.
        /// </exception>
        CreateHostedZoneResponse CreateHostedZone(CreateHostedZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHostedZone
        ///         operation.</returns>
        IAsyncResult BeginCreateHostedZone(CreateHostedZoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHostedZone.</param>
        /// 
        /// <returns>Returns a  CreateHostedZoneResult from Route53.</returns>
        CreateHostedZoneResponse EndCreateHostedZone(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateReusableDelegationSet


        /// <summary>
        /// This action creates a reusable delegationSet.
        /// 
        ///  
        /// <para>
        /// To create a new reusable delegationSet, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/delegationset</code> resource. The request body must include a
        /// document with a <code>CreateReusableDelegationSetRequest</code> element. The response
        /// returns the <code>CreateReusableDelegationSetResponse</code> element that contains
        /// metadata about the delegationSet. 
        /// </para>
        ///  
        /// <para>
        /// If the optional parameter HostedZoneId is specified, it marks the delegationSet associated
        /// with that particular hosted zone as reusable. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the CreateReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetAlreadyCreatedException">
        /// A delegation set with the same owner and caller reference combination has already
        /// been created.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetAlreadyReusableException">
        /// The specified delegation set has already been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotAvailableException">
        /// Amazon Route 53 allows some duplicate domain names, but there is a maximum number
        /// of duplicate names. This error indicates that you have reached that maximum. If you
        /// want to create another hosted zone with the same name and Amazon Route 53 generates
        /// this error, you can request an increase to the limit on the <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZoneNotFoundException">
        /// The specified HostedZone cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidArgumentException">
        /// At least one of the specified arguments is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LimitsExceededException">
        /// The limits specified for a resource have been exceeded.
        /// </exception>
        CreateReusableDelegationSetResponse CreateReusableDelegationSet(CreateReusableDelegationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReusableDelegationSet operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReusableDelegationSet
        ///         operation.</returns>
        IAsyncResult BeginCreateReusableDelegationSet(CreateReusableDelegationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReusableDelegationSet.</param>
        /// 
        /// <returns>Returns a  CreateReusableDelegationSetResult from Route53.</returns>
        CreateReusableDelegationSetResponse EndCreateReusableDelegationSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTrafficPolicy


        /// <summary>
        /// Creates a traffic policy, which you use to create multiple DNS resource record sets
        /// for one domain name (such as example.com) or one subdomain name (such as www.example.com).
        /// 
        ///  
        /// <para>
        /// To create a traffic policy, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/trafficpolicy</code> resource. The request body must include a
        /// document with a <code>CreateTrafficPolicyRequest</code> element. The response includes
        /// the <code>CreateTrafficPolicyResponse</code> element, which contains information about
        /// the new traffic policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateTrafficPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidTrafficPolicyDocumentException">
        /// The format of the traffic policy document that you specified in the <code>Document</code>
        /// element is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyTrafficPoliciesException">
        /// You've created the maximum number of traffic policies that can be created for the
        /// current AWS account. You can request an increase to the limit on the <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TrafficPolicyAlreadyExistsException">
        /// A traffic policy that has the same value for <code>Name</code> already exists.
        /// </exception>
        CreateTrafficPolicyResponse CreateTrafficPolicy(CreateTrafficPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrafficPolicy
        ///         operation.</returns>
        IAsyncResult BeginCreateTrafficPolicy(CreateTrafficPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrafficPolicy.</param>
        /// 
        /// <returns>Returns a  CreateTrafficPolicyResult from Route53.</returns>
        CreateTrafficPolicyResponse EndCreateTrafficPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTrafficPolicyInstance


        /// <summary>
        /// Creates resource record sets in a specified hosted zone based on the settings in a
        /// specified traffic policy version. In addition, <code>CreateTrafficPolicyInstance</code>
        /// associates the resource record sets with a specified domain name (such as example.com)
        /// or subdomain name (such as www.example.com). Amazon Route 53 responds to DNS queries
        /// for the domain or subdomain name by using the resource record sets that <code>CreateTrafficPolicyInstance</code>
        /// created.
        /// 
        ///  
        /// <para>
        /// To create a traffic policy instance, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/trafficpolicyinstance</code> resource. The request body must include
        /// a document with a <code>CreateTrafficPolicyRequest</code> element. The response returns
        /// the <code>CreateTrafficPolicyInstanceResponse</code> element, which contains information
        /// about the traffic policy instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyInstance service method.</param>
        /// 
        /// <returns>The response from the CreateTrafficPolicyInstance service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyTrafficPolicyInstancesException">
        /// You've created the maximum number of traffic policy instances that can be created
        /// for the current AWS account. You can request an increase to the limit on the <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TrafficPolicyInstanceAlreadyExistsException">
        /// Traffic policy instance with given Id already exists.
        /// </exception>
        CreateTrafficPolicyInstanceResponse CreateTrafficPolicyInstance(CreateTrafficPolicyInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyInstance operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrafficPolicyInstance
        ///         operation.</returns>
        IAsyncResult BeginCreateTrafficPolicyInstance(CreateTrafficPolicyInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrafficPolicyInstance.</param>
        /// 
        /// <returns>Returns a  CreateTrafficPolicyInstanceResult from Route53.</returns>
        CreateTrafficPolicyInstanceResponse EndCreateTrafficPolicyInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTrafficPolicyVersion


        /// <summary>
        /// Creates a new version of an existing traffic policy. When you create a new version
        /// of a traffic policy, you specify the ID of the traffic policy that you want to update
        /// and a JSON-formatted document that describes the new version.
        /// 
        ///  
        /// <para>
        /// You use traffic policies to create multiple DNS resource record sets for one domain
        /// name (such as example.com) or one subdomain name (such as www.example.com).
        /// </para>
        ///  
        /// <para>
        /// To create a new version, send a <code>POST</code> request to the <code>/<i>Route 53
        /// API version</i>/trafficpolicy/</code> resource. The request body includes a document
        /// with a <code>CreateTrafficPolicyVersionRequest</code> element. The response returns
        /// the <code>CreateTrafficPolicyVersionResponse</code> element, which contains information
        /// about the new version of the traffic policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the CreateTrafficPolicyVersion service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to update the object at the same time that you did.
        /// Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidTrafficPolicyDocumentException">
        /// The format of the traffic policy document that you specified in the <code>Document</code>
        /// element is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        CreateTrafficPolicyVersionResponse CreateTrafficPolicyVersion(CreateTrafficPolicyVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyVersion operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrafficPolicyVersion
        ///         operation.</returns>
        IAsyncResult BeginCreateTrafficPolicyVersion(CreateTrafficPolicyVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrafficPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrafficPolicyVersion.</param>
        /// 
        /// <returns>Returns a  CreateTrafficPolicyVersionResult from Route53.</returns>
        CreateTrafficPolicyVersionResponse EndCreateTrafficPolicyVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteHealthCheck


        /// <summary>
        /// This action deletes a health check. To delete a health check, send a <code>DELETE</code>
        /// request to the <code>/<i>Route 53 API version</i>/healthcheck/<i>health check ID</i></code>
        /// resource.
        /// 
        ///  <important> You can delete a health check only if there are no resource record sets
        /// associated with this health check. If resource record sets are associated with this
        /// health check, you must disassociate them before you can delete your health check.
        /// If you try to delete a health check that is associated with resource record sets,
        /// Amazon Route 53 will deny your request with a <code>HealthCheckInUse</code> error.
        /// For information about disassociating the records from your health check, see <code>ChangeResourceRecordSets</code>.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck service method.</param>
        /// 
        /// <returns>The response from the DeleteHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckInUseException">
        /// There are resource records associated with this health check. Before you can delete
        /// the health check, you must disassociate it from the resource record sets.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        DeleteHealthCheckResponse DeleteHealthCheck(DeleteHealthCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHealthCheck
        ///         operation.</returns>
        IAsyncResult BeginDeleteHealthCheck(DeleteHealthCheckRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHealthCheck.</param>
        /// 
        /// <returns>Returns a  DeleteHealthCheckResult from Route53.</returns>
        DeleteHealthCheckResponse EndDeleteHealthCheck(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteHostedZone


        /// <summary>
        /// This action deletes a hosted zone. To delete a hosted zone, send a <code>DELETE</code>
        /// request to the <code>/<i>Route 53 API version</i>/hostedzone/<i>hosted zone ID</i></code>
        /// resource.
        /// 
        ///  <important>You can delete a hosted zone only if there are no resource record sets
        /// other than the default SOA record and NS resource record sets. If your hosted zone
        /// contains other resource record sets, you must delete them before you can delete your
        /// hosted zone. If you try to delete a hosted zone that contains other resource record
        /// sets, Amazon Route 53 will deny your request with a <code>HostedZoneNotEmpty</code>
        /// error. For information about deleting records from your hosted zone, see <code>ChangeResourceRecordSets</code>.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone service method.</param>
        /// 
        /// <returns>The response from the DeleteHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HostedZoneNotEmptyException">
        /// The hosted zone contains resource record sets in addition to the default NS and SOA
        /// resource record sets. Before you can delete the hosted zone, you must delete the additional
        /// resource record sets.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidDomainNameException">
        /// This error indicates that the specified domain name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        DeleteHostedZoneResponse DeleteHostedZone(DeleteHostedZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHostedZone
        ///         operation.</returns>
        IAsyncResult BeginDeleteHostedZone(DeleteHostedZoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHostedZone.</param>
        /// 
        /// <returns>Returns a  DeleteHostedZoneResult from Route53.</returns>
        DeleteHostedZoneResponse EndDeleteHostedZone(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReusableDelegationSet


        /// <summary>
        /// This action deletes a reusable delegation set. To delete a reusable delegation set,
        /// send a <code>DELETE</code> request to the <code>/<i>Route 53 API version</i>/delegationset/<i>delegation
        /// set ID</i></code> resource.
        /// 
        ///  <important> You can delete a reusable delegation set only if there are no associated
        /// hosted zones. If your reusable delegation set contains associated hosted zones, you
        /// must delete them before you can delete your reusable delegation set. If you try to
        /// delete a reusable delegation set that contains associated hosted zones, Amazon Route
        /// 53 will deny your request with a <code>DelegationSetInUse</code> error.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetInUseException">
        /// The specified delegation contains associated hosted zones which must be deleted before
        /// the reusable delegation set can be deleted.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        DeleteReusableDelegationSetResponse DeleteReusableDelegationSet(DeleteReusableDelegationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReusableDelegationSet
        ///         operation.</returns>
        IAsyncResult BeginDeleteReusableDelegationSet(DeleteReusableDelegationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReusableDelegationSet.</param>
        /// 
        /// <returns>Returns a  DeleteReusableDelegationSetResult from Route53.</returns>
        DeleteReusableDelegationSetResponse EndDeleteReusableDelegationSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTrafficPolicy


        /// <summary>
        /// Deletes a traffic policy. To delete a traffic policy, send a <code>DELETE</code> request
        /// to the <code>/<i>Route 53 API version</i>/trafficpolicy</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteTrafficPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to update the object at the same time that you did.
        /// Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TrafficPolicyInUseException">
        /// One or more traffic policy instances were created by using the specified traffic policy.
        /// </exception>
        DeleteTrafficPolicyResponse DeleteTrafficPolicy(DeleteTrafficPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrafficPolicy
        ///         operation.</returns>
        IAsyncResult BeginDeleteTrafficPolicy(DeleteTrafficPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrafficPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteTrafficPolicyResult from Route53.</returns>
        DeleteTrafficPolicyResponse EndDeleteTrafficPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTrafficPolicyInstance


        /// <summary>
        /// Deletes a traffic policy instance and all of the resource record sets that Amazon
        /// Route 53 created when you created the instance.
        /// 
        ///  
        /// <para>
        /// To delete a traffic policy instance, send a <code>DELETE</code> request to the <code>/<i>Route
        /// 53 API version</i>/trafficpolicy/<i>traffic policy instance ID</i></code> resource.
        /// </para>
        ///  <important>When you delete a traffic policy instance, Amazon Route 53 also deletes
        /// all of the resource record sets that were created when you created the traffic policy
        /// instance.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicyInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteTrafficPolicyInstance service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        DeleteTrafficPolicyInstanceResponse DeleteTrafficPolicyInstance(DeleteTrafficPolicyInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicyInstance operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrafficPolicyInstance
        ///         operation.</returns>
        IAsyncResult BeginDeleteTrafficPolicyInstance(DeleteTrafficPolicyInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrafficPolicyInstance.</param>
        /// 
        /// <returns>Returns a  DeleteTrafficPolicyInstanceResult from Route53.</returns>
        DeleteTrafficPolicyInstanceResponse EndDeleteTrafficPolicyInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateVPCFromHostedZone


        /// <summary>
        /// This action disassociates a VPC from an hosted zone. 
        /// 
        ///  
        /// <para>
        /// To disassociate a VPC to a hosted zone, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/hostedzone/<i>hosted zone ID</i>/disassociatevpc</code> resource.
        /// The request body must include a document with a <code>DisassociateVPCFromHostedZoneRequest</code>
        /// element. The response returns the <code>DisassociateVPCFromHostedZoneResponse</code>
        /// element that contains <code>ChangeInfo</code> for you to track the progress of the
        /// <code>DisassociateVPCFromHostedZoneRequest</code> you made. See <code>GetChange</code>
        /// operation for how to track the progress of your change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone service method.</param>
        /// 
        /// <returns>The response from the DisassociateVPCFromHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Amazon
        /// Route 53 returns this error when the VPC specified by <code>VPCId</code> does not
        /// belong to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LastVPCAssociationException">
        /// The VPC you are trying to disassociate from the hosted zone is the last the VPC that
        /// is associated with the hosted zone. Amazon Route 53 currently doesn't support disassociate
        /// the last VPC from the hosted zone.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.VPCAssociationNotFoundException">
        /// The VPC you specified is not currently associated with the hosted zone.
        /// </exception>
        DisassociateVPCFromHostedZoneResponse DisassociateVPCFromHostedZone(DisassociateVPCFromHostedZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVPCFromHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateVPCFromHostedZone
        ///         operation.</returns>
        IAsyncResult BeginDisassociateVPCFromHostedZone(DisassociateVPCFromHostedZoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateVPCFromHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateVPCFromHostedZone.</param>
        /// 
        /// <returns>Returns a  DisassociateVPCFromHostedZoneResult from Route53.</returns>
        DisassociateVPCFromHostedZoneResponse EndDisassociateVPCFromHostedZone(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChange


        /// <summary>
        /// This action returns the current status of a change batch request. The status is one
        /// of the following values:
        /// 
        ///  
        /// <para>
        /// - <code>PENDING</code> indicates that the changes in this request have not replicated
        /// to all Amazon Route 53 DNS servers. This is the initial status of all change batch
        /// requests.
        /// </para>
        ///  
        /// <para>
        /// - <code>INSYNC</code> indicates that the changes have replicated to all Amazon Route
        /// 53 DNS servers. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChange service method.</param>
        /// 
        /// <returns>The response from the GetChange service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchChangeException">
        /// 
        /// </exception>
        GetChangeResponse GetChange(GetChangeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChange operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChange operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChange
        ///         operation.</returns>
        IAsyncResult BeginGetChange(GetChangeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChange operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChange.</param>
        /// 
        /// <returns>Returns a  GetChangeResult from Route53.</returns>
        GetChangeResponse EndGetChange(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChangeDetails


        /// <summary>
        /// This action returns the status and changes of a change batch request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeDetails service method.</param>
        /// 
        /// <returns>The response from the GetChangeDetails service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchChangeException">
        /// 
        /// </exception>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        GetChangeDetailsResponse GetChangeDetails(GetChangeDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChangeDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChangeDetails operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChangeDetails
        ///         operation.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        IAsyncResult BeginGetChangeDetails(GetChangeDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChangeDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChangeDetails.</param>
        /// 
        /// <returns>Returns a  GetChangeDetailsResult from Route53.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        GetChangeDetailsResponse EndGetChangeDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCheckerIpRanges


        /// <summary>
        /// To retrieve a list of the IP ranges used by Amazon Route 53 health checkers to check
        /// the health of your resources, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/checkeripranges</code> resource. You can use these IP addresses
        /// to configure router and firewall rules to allow health checkers to check the health
        /// of your resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges service method.</param>
        /// 
        /// <returns>The response from the GetCheckerIpRanges service method, as returned by Route53.</returns>
        GetCheckerIpRangesResponse GetCheckerIpRanges(GetCheckerIpRangesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCheckerIpRanges operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCheckerIpRanges
        ///         operation.</returns>
        IAsyncResult BeginGetCheckerIpRanges(GetCheckerIpRangesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCheckerIpRanges operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCheckerIpRanges.</param>
        /// 
        /// <returns>Returns a  GetCheckerIpRangesResult from Route53.</returns>
        GetCheckerIpRangesResponse EndGetCheckerIpRanges(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGeoLocation


        /// <summary>
        /// To retrieve a single geo location, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/geolocation</code> resource with one of these options: continentcode
        /// | countrycode | countrycode and subdivisioncode.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation service method.</param>
        /// 
        /// <returns>The response from the GetGeoLocation service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchGeoLocationException">
        /// The geo location you are trying to get does not exist.
        /// </exception>
        GetGeoLocationResponse GetGeoLocation(GetGeoLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGeoLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGeoLocation
        ///         operation.</returns>
        IAsyncResult BeginGetGeoLocation(GetGeoLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGeoLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGeoLocation.</param>
        /// 
        /// <returns>Returns a  GetGeoLocationResult from Route53.</returns>
        GetGeoLocationResponse EndGetGeoLocation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHealthCheck


        /// <summary>
        /// To retrieve the health check, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/healthcheck/<i>health check ID</i></code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Amazon Route 53 endpoint.
        /// Please consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        GetHealthCheckResponse GetHealthCheck(GetHealthCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHealthCheck
        ///         operation.</returns>
        IAsyncResult BeginGetHealthCheck(GetHealthCheckRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHealthCheck.</param>
        /// 
        /// <returns>Returns a  GetHealthCheckResult from Route53.</returns>
        GetHealthCheckResponse EndGetHealthCheck(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHealthCheckCount


        /// <summary>
        /// To retrieve a count of all your health checks, send a <code>GET</code> request to
        /// the <code>/<i>Route 53 API version</i>/healthcheckcount</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckCount service method, as returned by Route53.</returns>
        GetHealthCheckCountResponse GetHealthCheckCount(GetHealthCheckCountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHealthCheckCount
        ///         operation.</returns>
        IAsyncResult BeginGetHealthCheckCount(GetHealthCheckCountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHealthCheckCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHealthCheckCount.</param>
        /// 
        /// <returns>Returns a  GetHealthCheckCountResult from Route53.</returns>
        GetHealthCheckCountResponse EndGetHealthCheckCount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHealthCheckLastFailureReason


        /// <summary>
        /// If you want to learn why a health check is currently failing or why it failed most
        /// recently (if at all), you can get the failure reason for the most recent failure.
        /// Send a <code>GET</code> request to the <code>/<i>Route 53 API version</i>/healthcheck/<i>health
        /// check ID</i>/lastfailurereason</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckLastFailureReason service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        GetHealthCheckLastFailureReasonResponse GetHealthCheckLastFailureReason(GetHealthCheckLastFailureReasonRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckLastFailureReason operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHealthCheckLastFailureReason
        ///         operation.</returns>
        IAsyncResult BeginGetHealthCheckLastFailureReason(GetHealthCheckLastFailureReasonRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHealthCheckLastFailureReason operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHealthCheckLastFailureReason.</param>
        /// 
        /// <returns>Returns a  GetHealthCheckLastFailureReasonResult from Route53.</returns>
        GetHealthCheckLastFailureReasonResponse EndGetHealthCheckLastFailureReason(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHealthCheckStatus


        /// <summary>
        /// To retrieve the health check status, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/healthcheck/<i>health check ID</i>/status</code> resource. You
        /// can use this call to get a health check's current status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckStatus service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        GetHealthCheckStatusResponse GetHealthCheckStatus(GetHealthCheckStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHealthCheckStatus
        ///         operation.</returns>
        IAsyncResult BeginGetHealthCheckStatus(GetHealthCheckStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHealthCheckStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHealthCheckStatus.</param>
        /// 
        /// <returns>Returns a  GetHealthCheckStatusResult from Route53.</returns>
        GetHealthCheckStatusResponse EndGetHealthCheckStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHostedZone


        /// <summary>
        /// To retrieve the delegation set for a hosted zone, send a <code>GET</code> request
        /// to the <code>/<i>Route 53 API version</i>/hostedzone/<i>hosted zone ID</i></code>
        /// resource. The delegation set is the four Amazon Route 53 name servers that were assigned
        /// to the hosted zone when you created it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone service method.</param>
        /// 
        /// <returns>The response from the GetHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        GetHostedZoneResponse GetHostedZone(GetHostedZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHostedZone
        ///         operation.</returns>
        IAsyncResult BeginGetHostedZone(GetHostedZoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostedZone.</param>
        /// 
        /// <returns>Returns a  GetHostedZoneResult from Route53.</returns>
        GetHostedZoneResponse EndGetHostedZone(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHostedZoneCount


        /// <summary>
        /// To retrieve a count of all your hosted zones, send a <code>GET</code> request to the
        /// <code>/<i>Route 53 API version</i>/hostedzonecount</code> resource.
        /// </summary>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        GetHostedZoneCountResponse GetHostedZoneCount();

        /// <summary>
        /// To retrieve a count of all your hosted zones, send a <code>GET</code> request to the
        /// <code>/<i>Route 53 API version</i>/hostedzonecount</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneCount service method.</param>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        GetHostedZoneCountResponse GetHostedZoneCount(GetHostedZoneCountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZoneCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneCount operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHostedZoneCount
        ///         operation.</returns>
        IAsyncResult BeginGetHostedZoneCount(GetHostedZoneCountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHostedZoneCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostedZoneCount.</param>
        /// 
        /// <returns>Returns a  GetHostedZoneCountResult from Route53.</returns>
        GetHostedZoneCountResponse EndGetHostedZoneCount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReusableDelegationSet


        /// <summary>
        /// To retrieve the reusable delegation set, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/delegationset/<i>delegation set ID</i></code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the GetReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        GetReusableDelegationSetResponse GetReusableDelegationSet(GetReusableDelegationSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReusableDelegationSet
        ///         operation.</returns>
        IAsyncResult BeginGetReusableDelegationSet(GetReusableDelegationSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReusableDelegationSet.</param>
        /// 
        /// <returns>Returns a  GetReusableDelegationSetResult from Route53.</returns>
        GetReusableDelegationSetResponse EndGetReusableDelegationSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTrafficPolicy


        /// <summary>
        /// Gets information about a specific traffic policy version. To get the information,
        /// send a <code>GET</code> request to the <code>/<i>Route 53 API version</i>/trafficpolicy</code>
        /// resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the GetTrafficPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        GetTrafficPolicyResponse GetTrafficPolicy(GetTrafficPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrafficPolicy
        ///         operation.</returns>
        IAsyncResult BeginGetTrafficPolicy(GetTrafficPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrafficPolicy.</param>
        /// 
        /// <returns>Returns a  GetTrafficPolicyResult from Route53.</returns>
        GetTrafficPolicyResponse EndGetTrafficPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTrafficPolicyInstance


        /// <summary>
        /// Gets information about a specified traffic policy instance.
        /// 
        ///  
        /// <para>
        /// To get information about the traffic policy instance, send a <code>GET</code> request
        /// to the <code>/<i>Route 53 API version</i>/trafficpolicyinstance</code> resource.
        /// </para>
        ///  <note>After you submit a <code>CreateTrafficPolicyInstance</code> or an <code>UpdateTrafficPolicyInstance</code>
        /// request, there's a brief delay while Amazon Route 53 creates the resource record sets
        /// that are specified in the traffic policy definition. For more information, see the
        /// <code>State</code> response element.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstance service method.</param>
        /// 
        /// <returns>The response from the GetTrafficPolicyInstance service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        GetTrafficPolicyInstanceResponse GetTrafficPolicyInstance(GetTrafficPolicyInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstance operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrafficPolicyInstance
        ///         operation.</returns>
        IAsyncResult BeginGetTrafficPolicyInstance(GetTrafficPolicyInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrafficPolicyInstance.</param>
        /// 
        /// <returns>Returns a  GetTrafficPolicyInstanceResult from Route53.</returns>
        GetTrafficPolicyInstanceResponse EndGetTrafficPolicyInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTrafficPolicyInstanceCount


        /// <summary>
        /// Gets the number of traffic policy instances that are associated with the current AWS
        /// account.
        /// 
        ///  
        /// <para>
        /// To get the number of traffic policy instances, send a <code>GET</code> request to
        /// the <code>/<i>Route 53 API version</i>/trafficpolicyinstancecount</code> resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstanceCount service method.</param>
        /// 
        /// <returns>The response from the GetTrafficPolicyInstanceCount service method, as returned by Route53.</returns>
        GetTrafficPolicyInstanceCountResponse GetTrafficPolicyInstanceCount(GetTrafficPolicyInstanceCountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicyInstanceCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstanceCount operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrafficPolicyInstanceCount
        ///         operation.</returns>
        IAsyncResult BeginGetTrafficPolicyInstanceCount(GetTrafficPolicyInstanceCountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrafficPolicyInstanceCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrafficPolicyInstanceCount.</param>
        /// 
        /// <returns>Returns a  GetTrafficPolicyInstanceCountResult from Route53.</returns>
        GetTrafficPolicyInstanceCountResponse EndGetTrafficPolicyInstanceCount(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChangeBatchesByHostedZone


        /// <summary>
        /// This action gets the list of ChangeBatches in a given time period for a given hosted
        /// zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByHostedZone service method.</param>
        /// 
        /// <returns>The response from the ListChangeBatchesByHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        ListChangeBatchesByHostedZoneResponse ListChangeBatchesByHostedZone(ListChangeBatchesByHostedZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChangeBatchesByHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByHostedZone operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChangeBatchesByHostedZone
        ///         operation.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        IAsyncResult BeginListChangeBatchesByHostedZone(ListChangeBatchesByHostedZoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChangeBatchesByHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChangeBatchesByHostedZone.</param>
        /// 
        /// <returns>Returns a  ListChangeBatchesByHostedZoneResult from Route53.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        ListChangeBatchesByHostedZoneResponse EndListChangeBatchesByHostedZone(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChangeBatchesByRRSet


        /// <summary>
        /// This action gets the list of ChangeBatches in a given time period for a given hosted
        /// zone and RRSet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByRRSet service method.</param>
        /// 
        /// <returns>The response from the ListChangeBatchesByRRSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        ListChangeBatchesByRRSetResponse ListChangeBatchesByRRSet(ListChangeBatchesByRRSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChangeBatchesByRRSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByRRSet operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChangeBatchesByRRSet
        ///         operation.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        IAsyncResult BeginListChangeBatchesByRRSet(ListChangeBatchesByRRSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChangeBatchesByRRSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChangeBatchesByRRSet.</param>
        /// 
        /// <returns>Returns a  ListChangeBatchesByRRSetResult from Route53.</returns>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        ListChangeBatchesByRRSetResponse EndListChangeBatchesByRRSet(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGeoLocations


        /// <summary>
        /// To retrieve a list of supported geo locations, send a <code>GET</code> request to
        /// the <code>/<i>Route 53 API version</i>/geolocations</code> resource. The response
        /// to this request includes a <code>GeoLocationDetailsList</code> element with zero,
        /// one, or multiple <code>GeoLocationDetails</code> child elements. The list is sorted
        /// by country code, and then subdivision code, followed by continents at the end of the
        /// list. 
        /// 
        ///  
        /// <para>
        /// By default, the list of geo locations is displayed on a single page. You can control
        /// the length of the page that is displayed by using the <code>MaxItems</code> parameter.
        /// If the list is truncated, <code>IsTruncated</code> will be set to <i>true</i> and
        /// a combination of <code>NextContinentCode, NextCountryCode, NextSubdivisionCode</code>
        /// will be populated. You can pass these as parameters to <code>StartContinentCode, StartCountryCode,
        /// StartSubdivisionCode</code> to control the geo location that the list begins with.
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListGeoLocationsResponse ListGeoLocations();

        /// <summary>
        /// To retrieve a list of supported geo locations, send a <code>GET</code> request to
        /// the <code>/<i>Route 53 API version</i>/geolocations</code> resource. The response
        /// to this request includes a <code>GeoLocationDetailsList</code> element with zero,
        /// one, or multiple <code>GeoLocationDetails</code> child elements. The list is sorted
        /// by country code, and then subdivision code, followed by continents at the end of the
        /// list. 
        /// 
        ///  
        /// <para>
        /// By default, the list of geo locations is displayed on a single page. You can control
        /// the length of the page that is displayed by using the <code>MaxItems</code> parameter.
        /// If the list is truncated, <code>IsTruncated</code> will be set to <i>true</i> and
        /// a combination of <code>NextContinentCode, NextCountryCode, NextSubdivisionCode</code>
        /// will be populated. You can pass these as parameters to <code>StartContinentCode, StartCountryCode,
        /// StartSubdivisionCode</code> to control the geo location that the list begins with.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeoLocations service method.</param>
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListGeoLocationsResponse ListGeoLocations(ListGeoLocationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGeoLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeoLocations operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGeoLocations
        ///         operation.</returns>
        IAsyncResult BeginListGeoLocations(ListGeoLocationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGeoLocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGeoLocations.</param>
        /// 
        /// <returns>Returns a  ListGeoLocationsResult from Route53.</returns>
        ListGeoLocationsResponse EndListGeoLocations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHealthChecks


        /// <summary>
        /// To retrieve a list of your health checks, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/healthcheck</code> resource. The response to this request includes
        /// a <code>HealthChecks</code> element with zero, one, or multiple <code>HealthCheck</code>
        /// child elements. By default, the list of health checks is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the health check
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Amazon Route 53 endpoint.
        /// Please consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListHealthChecksResponse ListHealthChecks();

        /// <summary>
        /// To retrieve a list of your health checks, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/healthcheck</code> resource. The response to this request includes
        /// a <code>HealthChecks</code> element with zero, one, or multiple <code>HealthCheck</code>
        /// child elements. By default, the list of health checks is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the health check
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHealthChecks service method.</param>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Amazon Route 53 endpoint.
        /// Please consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListHealthChecksResponse ListHealthChecks(ListHealthChecksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHealthChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHealthChecks operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHealthChecks
        ///         operation.</returns>
        IAsyncResult BeginListHealthChecks(ListHealthChecksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHealthChecks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHealthChecks.</param>
        /// 
        /// <returns>Returns a  ListHealthChecksResult from Route53.</returns>
        ListHealthChecksResponse EndListHealthChecks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHostedZones


        /// <summary>
        /// To retrieve a list of your hosted zones, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/hostedzone</code> resource. The response to this request includes
        /// a <code>HostedZones</code> element with zero, one, or multiple <code>HostedZone</code>
        /// child elements. By default, the list of hosted zones is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the hosted zone
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        ListHostedZonesResponse ListHostedZones();

        /// <summary>
        /// To retrieve a list of your hosted zones, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/hostedzone</code> resource. The response to this request includes
        /// a <code>HostedZones</code> element with zero, one, or multiple <code>HostedZone</code>
        /// child elements. By default, the list of hosted zones is displayed on a single page.
        /// You can control the length of the page that is displayed by using the <code>MaxItems</code>
        /// parameter. You can use the <code>Marker</code> parameter to control the hosted zone
        /// that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZones service method.</param>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// The specified delegation set has not been marked as reusable.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// The specified delegation set does not exist.
        /// </exception>
        ListHostedZonesResponse ListHostedZones(ListHostedZonesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZones operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHostedZones
        ///         operation.</returns>
        IAsyncResult BeginListHostedZones(ListHostedZonesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHostedZones operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHostedZones.</param>
        /// 
        /// <returns>Returns a  ListHostedZonesResult from Route53.</returns>
        ListHostedZonesResponse EndListHostedZones(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHostedZonesByName


        /// <summary>
        /// To retrieve a list of your hosted zones in lexicographic order, send a <code>GET</code>
        /// request to the <code>/<i>Route 53 API version</i>/hostedzonesbyname</code> resource.
        /// The response to this request includes a <code>HostedZones</code> element with zero
        /// or more <code>HostedZone</code> child elements lexicographically ordered by DNS name.
        /// By default, the list of hosted zones is displayed on a single page. You can control
        /// the length of the page that is displayed by using the <code>MaxItems</code> parameter.
        /// You can use the <code>DNSName</code> and <code>HostedZoneId</code> parameters to control
        /// the hosted zone that the list begins with.
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZonesByName service method.</param>
        /// 
        /// <returns>The response from the ListHostedZonesByName service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidDomainNameException">
        /// This error indicates that the specified domain name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListHostedZonesByNameResponse ListHostedZonesByName(ListHostedZonesByNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZonesByName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZonesByName operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHostedZonesByName
        ///         operation.</returns>
        IAsyncResult BeginListHostedZonesByName(ListHostedZonesByNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHostedZonesByName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHostedZonesByName.</param>
        /// 
        /// <returns>Returns a  ListHostedZonesByNameResult from Route53.</returns>
        ListHostedZonesByNameResponse EndListHostedZonesByName(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceRecordSets


        /// <summary>
        /// List the resource record sets in a specified hosted zone. Send a GET request to the
        /// <code>2013-04-01/hostedzone/<i>hosted zone ID</i>/rrset</code> resource.
        /// 
        ///  
        /// <para>
        /// <code>ListResourceRecordSets</code> returns up to 100 resource record sets at a time
        /// in ASCII order, beginning at a position specified by the name and type elements. The
        /// action sorts results first by DNS name with the labels reversed, for example:
        /// </para>
        ///  
        /// <para>
        /// <code>com.example.www.</code>
        /// </para>
        ///  
        /// <para>
        /// Note the trailing dot, which can change the sort order in some circumstances. When
        /// multiple records have the same DNS name, the action sorts results by the record type.
        /// </para>
        ///  
        /// <para>
        /// You can use the name and type elements to adjust the beginning position of the list
        /// of resource record sets returned:
        /// </para>
        ///  <ul> <li><b>If you do not specify <code>Name</code> or <code>Type</code></b>: The
        /// results begin with the first resource record set that the hosted zone contains.</li>
        /// <li><b>If you specify <code>Name</code> but not <code>Type</code></b>: The results
        /// begin with the first resource record set in the list whose name is greater than or
        /// equal to Name.</li> <li><b>If you specify <code>Type</code> but not <code>Name</code></b>:
        /// Amazon Route 53 returns the <code>InvalidInput</code> error.</li> <li><b>If you specify
        /// both <code>Name</code> and <code>Type</code></b>: The results begin with the first
        /// resource record set in the list whose name is greater than or equal to <code>Name</code>,
        /// and whose type is greater than or equal to <code>Type</code>.</li> </ul> 
        /// <para>
        /// This action returns the most current version of the records. This includes records
        /// that are <code>PENDING</code>, and that are not yet available on all Amazon Route
        /// 53 DNS servers.
        /// </para>
        ///  
        /// <para>
        /// To ensure that you get an accurate listing of the resource record sets for a hosted
        /// zone at a point in time, do not submit a <code>ChangeResourceRecordSets</code> request
        /// while you are paging through the results of a <code>ListResourceRecordSets</code>
        /// request. If you do, some pages may display results without the latest changes while
        /// other pages display results with the latest changes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets service method.</param>
        /// 
        /// <returns>The response from the ListResourceRecordSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        ListResourceRecordSetsResponse ListResourceRecordSets(ListResourceRecordSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceRecordSets
        ///         operation.</returns>
        IAsyncResult BeginListResourceRecordSets(ListResourceRecordSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceRecordSets.</param>
        /// 
        /// <returns>Returns a  ListResourceRecordSetsResult from Route53.</returns>
        ListResourceRecordSetsResponse EndListResourceRecordSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReusableDelegationSets


        /// <summary>
        /// To retrieve a list of your reusable delegation sets, send a <code>GET</code> request
        /// to the <code>/<i>Route 53 API version</i>/delegationset</code> resource. The response
        /// to this request includes a <code>DelegationSets</code> element with zero, one, or
        /// multiple <code>DelegationSet</code> child elements. By default, the list of delegation
        /// sets is displayed on a single page. You can control the length of the page that is
        /// displayed by using the <code>MaxItems</code> parameter. You can use the <code>Marker</code>
        /// parameter to control the delegation set that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListReusableDelegationSetsResponse ListReusableDelegationSets();

        /// <summary>
        /// To retrieve a list of your reusable delegation sets, send a <code>GET</code> request
        /// to the <code>/<i>Route 53 API version</i>/delegationset</code> resource. The response
        /// to this request includes a <code>DelegationSets</code> element with zero, one, or
        /// multiple <code>DelegationSet</code> child elements. By default, the list of delegation
        /// sets is displayed on a single page. You can control the length of the page that is
        /// displayed by using the <code>MaxItems</code> parameter. You can use the <code>Marker</code>
        /// parameter to control the delegation set that the list begins with. 
        /// 
        ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
        /// greater than 100, Amazon Route 53 returns only the first 100.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets service method.</param>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListReusableDelegationSetsResponse ListReusableDelegationSets(ListReusableDelegationSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReusableDelegationSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReusableDelegationSets
        ///         operation.</returns>
        IAsyncResult BeginListReusableDelegationSets(ListReusableDelegationSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReusableDelegationSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReusableDelegationSets.</param>
        /// 
        /// <returns>Returns a  ListReusableDelegationSetsResult from Route53.</returns>
        ListReusableDelegationSetsResponse EndListReusableDelegationSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// 
        /// </exception>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Route53.</returns>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResources


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResources service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// 
        /// </exception>
        ListTagsForResourcesResponse ListTagsForResources(ListTagsForResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResources
        ///         operation.</returns>
        IAsyncResult BeginListTagsForResources(ListTagsForResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResources.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourcesResult from Route53.</returns>
        ListTagsForResourcesResponse EndListTagsForResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrafficPolicies


        /// <summary>
        /// Gets information about the latest version for every traffic policy that is associated
        /// with the current AWS account. To get the information, send a <code>GET</code> request
        /// to the <code>/<i>Route 53 API version</i>/trafficpolicy</code> resource.
        /// 
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of traffic policies, you can use the <code>maxitems</code> parameter to list them
        /// in groups of up to 100.
        /// </para>
        ///  
        /// <para>
        /// The response includes three values that help you navigate from one group of <code>maxitems</code>
        /// traffic policies to the next:
        /// </para>
        ///  <ul> <li><b>IsTruncated</b></li> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
        /// are more traffic policies associated with the current AWS account.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy that is associated with the current account.
        /// </para>
        ///  <li><b>TrafficPolicyIdMarker</b></li> 
        /// <para>
        /// If <code>IsTruncated</code> is <code>true</code>, <code>TrafficPolicyIdMarker</code>
        /// is the ID of the first traffic policy in the next group of <code>MaxItems</code> traffic
        /// policies. If you want to list more traffic policies, make another call to <code>ListTrafficPolicies</code>,
        /// and specify the value of the <code>TrafficPolicyIdMarker</code> element from the response
        /// in the <code>TrafficPolicyIdMarker</code> request parameter.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, the <code>TrafficPolicyIdMarker</code>
        /// element is omitted from the response.
        /// </para>
        ///  <li><b>MaxItems</b></li> 
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicies service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        ListTrafficPoliciesResponse ListTrafficPolicies(ListTrafficPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrafficPolicies
        ///         operation.</returns>
        IAsyncResult BeginListTrafficPolicies(ListTrafficPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrafficPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrafficPolicies.</param>
        /// 
        /// <returns>Returns a  ListTrafficPoliciesResult from Route53.</returns>
        ListTrafficPoliciesResponse EndListTrafficPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrafficPolicyInstances


        /// <summary>
        /// Gets information about the traffic policy instances that you created by using the
        /// current AWS account.
        /// 
        ///  <note>After you submit an <code>UpdateTrafficPolicyInstance</code> request, there's
        /// a brief delay while Amazon Route 53 creates the resource record sets that are specified
        /// in the traffic policy definition. For more information, see the <code>State</code>
        /// response element.</note> 
        /// <para>
        /// To get information about the traffic policy instances that are associated with the
        /// current AWS account, send a <code>GET</code> request to the <code>/<i>Route 53 API
        /// version</i>/trafficpolicyinstance</code> resource.
        /// </para>
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of traffic policy instances, you can use the <code>MaxItems</code> parameter to list
        /// them in groups of up to 100.
        /// </para>
        ///  
        /// <para>
        /// The response includes five values that help you navigate from one group of <code>MaxItems</code>
        /// traffic policy instances to the next:
        /// </para>
        ///  <ul> <li><b>IsTruncated</b></li> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
        /// are more traffic policy instances associated with the current AWS account.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy instance that is associated with the current account.
        /// </para>
        ///  <li><b>MaxItems</b></li> 
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  <li><b>HostedZoneIdMarker</b>, <b>TrafficPolicyInstanceNameMarker</b>, and <b>TrafficPolicyInstanceTypeMarker</b></li>
        /// 
        /// <para>
        /// If <code>IsTruncated</code> is <code>true</code>, these three values in the response
        /// represent the first traffic policy instance in the next group of <code>MaxItems</code>
        /// traffic policy instances. To list more traffic policy instances, make another call
        /// to <code>ListTrafficPolicyInstances</code>, and specify these values in the corresponding
        /// request parameters.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, all three elements are omitted
        /// from the response.
        /// </para>
        ///  </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstances service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicyInstances service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        ListTrafficPolicyInstancesResponse ListTrafficPolicyInstances(ListTrafficPolicyInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstances operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrafficPolicyInstances
        ///         operation.</returns>
        IAsyncResult BeginListTrafficPolicyInstances(ListTrafficPolicyInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrafficPolicyInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrafficPolicyInstances.</param>
        /// 
        /// <returns>Returns a  ListTrafficPolicyInstancesResult from Route53.</returns>
        ListTrafficPolicyInstancesResponse EndListTrafficPolicyInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrafficPolicyInstancesByHostedZone


        /// <summary>
        /// Gets information about the traffic policy instances that you created in a specified
        /// hosted zone.
        /// 
        ///  <note>After you submit an <code>UpdateTrafficPolicyInstance</code> request, there's
        /// a brief delay while Amazon Route 53 creates the resource record sets that are specified
        /// in the traffic policy definition. For more information, see the <code>State</code>
        /// response element.</note> 
        /// <para>
        /// To get information about the traffic policy instances that you created in a specified
        /// hosted zone, send a <code>GET</code> request to the <code>/<i>Route 53 API version</i>/trafficpolicyinstance</code>
        /// resource and include the ID of the hosted zone.
        /// </para>
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of traffic policy instances, you can use the <code>MaxItems</code> parameter to list
        /// them in groups of up to 100.
        /// </para>
        ///  
        /// <para>
        /// The response includes four values that help you navigate from one group of <code>MaxItems</code>
        /// traffic policy instances to the next:
        /// </para>
        ///  <ul> <li><b>IsTruncated</b></li> 
        /// <para>
        /// If the value of <code/>IsTruncated in the response is <code>true</code>, there are
        /// more traffic policy instances associated with the current AWS account.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy instance that is associated with the current account.
        /// </para>
        ///  <li><b>MaxItems</b></li> 
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  <li><b>TrafficPolicyInstanceNameMarker</b> and <b>TrafficPolicyInstanceTypeMarker</b></li>
        /// 
        /// <para>
        /// If <code>IsTruncated</code> is <code>true</code>, these two values in the response
        /// represent the first traffic policy instance in the next group of <code>MaxItems</code>
        /// traffic policy instances. To list more traffic policy instances, make another call
        /// to <code>ListTrafficPolicyInstancesByHostedZone</code>, and specify these values in
        /// the corresponding request parameters.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, all three elements are omitted
        /// from the response.
        /// </para>
        ///  </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByHostedZone service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicyInstancesByHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        ListTrafficPolicyInstancesByHostedZoneResponse ListTrafficPolicyInstancesByHostedZone(ListTrafficPolicyInstancesByHostedZoneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstancesByHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByHostedZone operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrafficPolicyInstancesByHostedZone
        ///         operation.</returns>
        IAsyncResult BeginListTrafficPolicyInstancesByHostedZone(ListTrafficPolicyInstancesByHostedZoneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrafficPolicyInstancesByHostedZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrafficPolicyInstancesByHostedZone.</param>
        /// 
        /// <returns>Returns a  ListTrafficPolicyInstancesByHostedZoneResult from Route53.</returns>
        ListTrafficPolicyInstancesByHostedZoneResponse EndListTrafficPolicyInstancesByHostedZone(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrafficPolicyInstancesByPolicy


        /// <summary>
        /// Gets information about the traffic policy instances that you created by using a specify
        /// traffic policy version.
        /// 
        ///  <note>After you submit a <code>CreateTrafficPolicyInstance</code> or an <code>UpdateTrafficPolicyInstance</code>
        /// request, there's a brief delay while Amazon Route 53 creates the resource record sets
        /// that are specified in the traffic policy definition. For more information, see the
        /// <code>State</code> response element.</note> 
        /// <para>
        /// To get information about the traffic policy instances that you created by using a
        /// specify traffic policy version, send a <code>GET</code> request to the <code>/<i>Route
        /// 53 API version</i>/trafficpolicyinstance</code> resource and include the ID and version
        /// of the traffic policy.
        /// </para>
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of traffic policy instances, you can use the <code>MaxItems</code> parameter to list
        /// them in groups of up to 100.
        /// </para>
        ///  
        /// <para>
        /// The response includes five values that help you navigate from one group of <code>MaxItems</code>
        /// traffic policy instances to the next:
        /// </para>
        ///  <ul> <li><b>IsTruncated</b> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
        /// are more traffic policy instances associated with the specified traffic policy.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy instance that is associated with the specified traffic policy.
        /// </para>
        ///  </li> <li><b>MaxItems</b> 
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  </li> <li><b>HostedZoneIdMarker</b>, <b>TrafficPolicyInstanceNameMarker</b>, and
        /// <b>TrafficPolicyInstanceTypeMarker</b> 
        /// <para>
        /// If <code>IsTruncated</code> is <code>true</code>, these values in the response represent
        /// the first traffic policy instance in the next group of <code>MaxItems</code> traffic
        /// policy instances. To list more traffic policy instances, make another call to <code>ListTrafficPolicyInstancesByPolicy</code>,
        /// and specify these values in the corresponding request parameters.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, all three elements are omitted
        /// from the response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByPolicy service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicyInstancesByPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        ListTrafficPolicyInstancesByPolicyResponse ListTrafficPolicyInstancesByPolicy(ListTrafficPolicyInstancesByPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstancesByPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByPolicy operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrafficPolicyInstancesByPolicy
        ///         operation.</returns>
        IAsyncResult BeginListTrafficPolicyInstancesByPolicy(ListTrafficPolicyInstancesByPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrafficPolicyInstancesByPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrafficPolicyInstancesByPolicy.</param>
        /// 
        /// <returns>Returns a  ListTrafficPolicyInstancesByPolicyResult from Route53.</returns>
        ListTrafficPolicyInstancesByPolicyResponse EndListTrafficPolicyInstancesByPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrafficPolicyVersions


        /// <summary>
        /// Gets information about all of the versions for a specified traffic policy. <code>ListTrafficPolicyVersions</code>
        /// lists only versions that have not been deleted.
        /// 
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of traffic policies, you can use the <code>maxitems</code> parameter to list them
        /// in groups of up to 100.
        /// </para>
        ///  
        /// <para>
        /// The response includes three values that help you navigate from one group of <code>maxitems</code>maxitems
        /// traffic policies to the next:
        /// </para>
        ///  <ul> <li><b>IsTruncated</b></li> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
        /// are more traffic policy versions associated with the specified traffic policy.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy version that is associated with the specified traffic policy.
        /// </para>
        ///  <li><b>TrafficPolicyVersionMarker</b></li> 
        /// <para>
        /// The ID of the next traffic policy version that is associated with the current AWS
        /// account. If you want to list more traffic policies, make another call to <code>ListTrafficPolicyVersions</code>,
        /// and specify the value of the <code>TrafficPolicyVersionMarker</code> element in the
        /// <code>TrafficPolicyVersionMarker</code> request parameter.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, Amazon Route 53 omits the <code>TrafficPolicyVersionMarker</code>
        /// element from the response.
        /// </para>
        ///  <li><b>MaxItems</b></li> 
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyVersions service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicyVersions service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        ListTrafficPolicyVersionsResponse ListTrafficPolicyVersions(ListTrafficPolicyVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyVersions operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrafficPolicyVersions
        ///         operation.</returns>
        IAsyncResult BeginListTrafficPolicyVersions(ListTrafficPolicyVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrafficPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrafficPolicyVersions.</param>
        /// 
        /// <returns>Returns a  ListTrafficPolicyVersionsResult from Route53.</returns>
        ListTrafficPolicyVersionsResponse EndListTrafficPolicyVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateHealthCheck


        /// <summary>
        /// This action updates an existing health check.
        /// 
        ///  
        /// <para>
        /// To update a health check, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/healthcheck/<i>health check ID</i></code> resource. The request
        /// body must include a document with an <code>UpdateHealthCheckRequest</code> element.
        /// The response returns an <code>UpdateHealthCheckResponse</code> element, which contains
        /// metadata about the health check.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the UpdateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckVersionMismatchException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// The health check you are trying to get or delete does not exist.
        /// </exception>
        UpdateHealthCheckResponse UpdateHealthCheck(UpdateHealthCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHealthCheck
        ///         operation.</returns>
        IAsyncResult BeginUpdateHealthCheck(UpdateHealthCheckRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHealthCheck.</param>
        /// 
        /// <returns>Returns a  UpdateHealthCheckResult from Route53.</returns>
        UpdateHealthCheckResponse EndUpdateHealthCheck(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateHostedZoneComment


        /// <summary>
        /// To update the hosted zone comment, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/hostedzone/<i>hosted zone ID</i></code> resource. The request body
        /// must include a document with a <code>UpdateHostedZoneCommentRequest</code> element.
        /// The response to this request includes the modified <code>HostedZone</code> element.
        /// 
        ///  <note> The comment can have a maximum length of 256 characters.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneComment service method.</param>
        /// 
        /// <returns>The response from the UpdateHostedZoneComment service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// 
        /// </exception>
        UpdateHostedZoneCommentResponse UpdateHostedZoneComment(UpdateHostedZoneCommentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHostedZoneComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneComment operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHostedZoneComment
        ///         operation.</returns>
        IAsyncResult BeginUpdateHostedZoneComment(UpdateHostedZoneCommentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHostedZoneComment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHostedZoneComment.</param>
        /// 
        /// <returns>Returns a  UpdateHostedZoneCommentResult from Route53.</returns>
        UpdateHostedZoneCommentResponse EndUpdateHostedZoneComment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTrafficPolicyComment


        /// <summary>
        /// Updates the comment for a specified traffic policy version.
        /// 
        ///  
        /// <para>
        /// To update the comment, send a <code>POST</code> request to the <code>/<i>Route 53
        /// API version</i>/trafficpolicy/</code> resource.
        /// </para>
        ///  
        /// <para>
        /// The request body must include a document with an <code>UpdateTrafficPolicyCommentRequest</code>
        /// element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyComment service method.</param>
        /// 
        /// <returns>The response from the UpdateTrafficPolicyComment service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to update the object at the same time that you did.
        /// Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        UpdateTrafficPolicyCommentResponse UpdateTrafficPolicyComment(UpdateTrafficPolicyCommentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrafficPolicyComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyComment operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrafficPolicyComment
        ///         operation.</returns>
        IAsyncResult BeginUpdateTrafficPolicyComment(UpdateTrafficPolicyCommentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrafficPolicyComment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrafficPolicyComment.</param>
        /// 
        /// <returns>Returns a  UpdateTrafficPolicyCommentResult from Route53.</returns>
        UpdateTrafficPolicyCommentResponse EndUpdateTrafficPolicyComment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTrafficPolicyInstance


        /// <summary>
        /// Updates the resource record sets in a specified hosted zone that were created based
        /// on the settings in a specified traffic policy version.
        /// 
        ///  <important>The DNS type of the resource record sets that you're updating must match
        /// the DNS type in the JSON document that is associated with the traffic policy version
        /// that you're using to update the traffic policy instance.</important> 
        /// <para>
        /// When you update a traffic policy instance, Amazon Route 53 continues to respond to
        /// DNS queries for the root resource record set name (such as example.com) while it replaces
        /// one group of resource record sets with another. Amazon Route 53 performs the following
        /// operations:
        /// </para>
        ///  <ol> <li>Amazon Route 53 creates a new group of resource record sets based on the
        /// specified traffic policy. This is true regardless of how substantial the differences
        /// are between the existing resource record sets and the new resource record sets. </li>
        /// <li>When all of the new resource record sets have been created, Amazon Route 53 starts
        /// to respond to DNS queries for the root resource record set name (such as example.com)
        /// by using the new resource record sets.</li> <li>Amazon Route 53 deletes the old group
        /// of resource record sets that are associated with the root resource record set name.</li>
        /// </ol> 
        /// <para>
        /// To update a traffic policy instance, send a <code>POST</code> request to the <code>/<i>Route
        /// 53 API version</i>/trafficpolicyinstance/<i>traffic policy ID</i></code> resource.
        /// The request body must include a document with an <code>UpdateTrafficPolicyInstanceRequest</code>
        /// element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateTrafficPolicyInstance service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingTypesException">
        /// You tried to update a traffic policy instance by using a traffic policy version that
        /// has a different DNS type than the current type for the instance. You specified the
        /// type in the JSON document in the <code>CreateTrafficPolicy</code> or <code>CreateTrafficPolicyVersion</code>request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// Some value specified in the request is invalid or the XML document is malformed.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// The request was rejected because Amazon Route 53 was still processing a prior request.
        /// </exception>
        UpdateTrafficPolicyInstanceResponse UpdateTrafficPolicyInstance(UpdateTrafficPolicyInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyInstance operation on AmazonRoute53Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrafficPolicyInstance
        ///         operation.</returns>
        IAsyncResult BeginUpdateTrafficPolicyInstance(UpdateTrafficPolicyInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrafficPolicyInstance.</param>
        /// 
        /// <returns>Returns a  UpdateTrafficPolicyInstanceResult from Route53.</returns>
        UpdateTrafficPolicyInstanceResponse EndUpdateTrafficPolicyInstance(IAsyncResult asyncResult);

        #endregion
        
    }
}