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
        /// Associates an Amazon VPC with a private hosted zone. 
        /// 
        ///  <important> 
        /// <para>
        /// To perform the association, the VPC and the private hosted zone must already exist.
        /// You can't convert a public hosted zone into a private hosted zone.
        /// </para>
        ///  </important> 
        /// <para>
        /// Send a <code>POST</code> request to the <code>/2013-04-01/hostedzone/<i>hosted zone
        /// ID</i>/associatevpc</code> resource. The request body must include a document with
        /// an <code>AssociateVPCWithHostedZoneRequest</code> element. The response contains a
        /// <code>ChangeInfo</code> data type that you can use to track the progress of the request.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to associate a VPC that was created by using one AWS account with a private
        /// hosted zone that was created by using a different account, the AWS account that created
        /// the private hosted zone must first submit a <code>CreateVPCAssociationAuthorization</code>
        /// request. Then the account that created the VPC must submit an <code>AssociateVPCWithHostedZone</code>
        /// request.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone service method.</param>
        /// 
        /// <returns>The response from the AssociateVPCWithHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingDomainExistsException">
        /// You specified an Amazon VPC that you're already using for another hosted zone, and
        /// the domain that you specified for one of the hosted zones is a subdomain of the domain
        /// that you specified for the other hosted zone. For example, you can't use the same
        /// Amazon VPC for the hosted zones for example.com and test.example.com.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The VPC ID that you specified either isn't a valid ID or the current account is not
        /// authorized to access this VPC.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LimitsExceededException">
        /// The limits specified for a resource have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NotAuthorizedException">
        /// Associating the specified VPC with the specified hosted zone has not been authorized.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PublicZoneVPCAssociationException">
        /// You're trying to associate a VPC with a public hosted zone. Amazon Route 53 doesn't
        /// support associating a VPC with a public hosted zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/AssociateVPCWithHostedZone">REST API Reference for AssociateVPCWithHostedZone Operation</seealso>
        AssociateVPCWithHostedZoneResponse AssociateVPCWithHostedZone(AssociateVPCWithHostedZoneRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVPCWithHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/AssociateVPCWithHostedZone">REST API Reference for AssociateVPCWithHostedZone Operation</seealso>
        Task<AssociateVPCWithHostedZoneResponse> AssociateVPCWithHostedZoneAsync(AssociateVPCWithHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ChangeResourceRecordSets


        /// <summary>
        /// Create, change, update, or delete authoritative DNS information on all Amazon Route
        /// 53 servers. Send a <code>POST</code> request to: 
        /// 
        ///  
        /// <para>
        ///  <code>/2013-04-01/hostedzone/<i>Amazon Route 53 hosted Zone ID</i>/rrset</code> resource.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Change Batches and Transactional Changes</b> 
        /// </para>
        ///  
        /// <para>
        /// The request body must include a document with a <code>ChangeResourceRecordSetsRequest</code>
        /// element. The request body contains a list of change items, known as a change batch.
        /// Change batches are considered transactional changes. When using the Amazon Route 53
        /// API to change resource record sets, Amazon Route 53 either makes all or none of the
        /// changes in a change batch request. This ensures that Amazon Route 53 never partially
        /// implements the intended changes to the resource record sets in a hosted zone. 
        /// </para>
        ///  
        /// <para>
        /// For example, a change batch request that deletes the <code>CNAME</code> record for
        /// www.example.com and creates an alias resource record set for www.example.com. Amazon
        /// Route 53 deletes the first resource record set and creates the second resource record
        /// set in a single operation. If either the <code>DELETE</code> or the <code>CREATE</code>
        /// action fails, then both changes (plus any other changes in the batch) fail, and the
        /// original <code>CNAME</code> record continues to exist.
        /// </para>
        ///  <important> 
        /// <para>
        /// Due to the nature of transactional changes, you can't delete the same resource record
        /// set more than once in a single change batch. If you attempt to delete the same change
        /// batch more than once, Amazon Route 53 returns an <code>InvalidChangeBatch</code> error.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Traffic Flow</b> 
        /// </para>
        ///  
        /// <para>
        /// To create resource record sets for complex routing configurations, use either the
        /// traffic flow visual editor in the Amazon Route 53 console or the API actions for traffic
        /// policies and traffic policy instances. Save the configuration as a traffic policy,
        /// then associate the traffic policy with one or more domain names (such as example.com)
        /// or subdomain names (such as www.example.com), in the same hosted zone or in multiple
        /// hosted zones. You can roll back the updates if the new configuration isn't performing
        /// as expected. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/traffic-flow.html">Using
        /// Traffic Flow to Route DNS Traffic</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Create, Delete, and Upsert</b> 
        /// </para>
        ///  
        /// <para>
        /// Use <code>ChangeResourceRecordsSetsRequest</code> to perform the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATE</code>: Creates a resource record set that has the specified values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE</code>: Deletes an existing resource record set that has the specified
        /// values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPSERT</code>: If a resource record set does not already exist, AWS creates
        /// it. If a resource set does exist, Amazon Route 53 updates it with the values in the
        /// request. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Syntaxes for Creating, Updating, and Deleting Resource Record Sets</b> 
        /// </para>
        ///  
        /// <para>
        /// The syntax for a request depends on the type of resource record set that you want
        /// to create, delete, or update, such as weighted, alias, or failover. The XML elements
        /// in your request must appear in the order listed in the syntax. 
        /// </para>
        ///  
        /// <para>
        /// For an example for each type of resource record set, see "Examples."
        /// </para>
        ///  
        /// <para>
        /// Don't refer to the syntax in the "Parameter Syntax" section, which includes all of
        /// the elements for every kind of resource record set that you can create, delete, or
        /// update by using <code>ChangeResourceRecordSets</code>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Change Propagation to Amazon Route 53 DNS Servers</b> 
        /// </para>
        ///  
        /// <para>
        /// When you submit a <code>ChangeResourceRecordSets</code> request, Amazon Route 53 propagates
        /// your changes to all of the Amazon Route 53 authoritative DNS servers. While your changes
        /// are propagating, <code>GetChange</code> returns a status of <code>PENDING</code>.
        /// When propagation is complete, <code>GetChange</code> returns a status of <code>INSYNC</code>.
        /// Changes generally propagate to all Amazon Route 53 name servers in a few minutes.
        /// In rare circumstances, propagation can take up to 30 minutes. For more information,
        /// see <a>GetChange</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Limits on ChangeResourceRecordSets Requests</b> 
        /// </para>
        ///  
        /// <para>
        /// For information about the limits on a <code>ChangeResourceRecordSets</code> request,
        /// see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html">Limits</a>
        /// in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets service method.</param>
        /// 
        /// <returns>The response from the ChangeResourceRecordSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidChangeBatchException">
        /// This exception contains a list of messages that might contain one or more error messages.
        /// Each error message indicates one error in the change batch.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the ID that you specified in the <code>DeleteHealthCheck</code>
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// If Amazon Route 53 can't process a request before the next request arrives, it will
        /// reject subsequent requests for the same hosted zone and return an <code>HTTP 400 error</code>
        /// (<code>Bad request</code>). If Amazon Route 53 returns this error repeatedly for the
        /// same request, we recommend that you wait, in intervals of increasing duration, before
        /// you try the request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ChangeResourceRecordSets">REST API Reference for ChangeResourceRecordSets Operation</seealso>
        ChangeResourceRecordSetsResponse ChangeResourceRecordSets(ChangeResourceRecordSetsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ChangeResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ChangeResourceRecordSets">REST API Reference for ChangeResourceRecordSets Operation</seealso>
        Task<ChangeResourceRecordSetsResponse> ChangeResourceRecordSetsAsync(ChangeResourceRecordSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ChangeTagsForResource


        /// <summary>
        /// Adds, edits, or deletes tags for a health check or a hosted zone.
        /// 
        ///  
        /// <para>
        /// For information about using tags for cost allocation, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ChangeTagsForResource service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the ID that you specified in the <code>DeleteHealthCheck</code>
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// If Amazon Route 53 can't process a request before the next request arrives, it will
        /// reject subsequent requests for the same hosted zone and return an <code>HTTP 400 error</code>
        /// (<code>Bad request</code>). If Amazon Route 53 returns this error repeatedly for the
        /// same request, we recommend that you wait, in intervals of increasing duration, before
        /// you try the request again.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ChangeTagsForResource">REST API Reference for ChangeTagsForResource Operation</seealso>
        ChangeTagsForResourceResponse ChangeTagsForResource(ChangeTagsForResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ChangeTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ChangeTagsForResource">REST API Reference for ChangeTagsForResource Operation</seealso>
        Task<ChangeTagsForResourceResponse> ChangeTagsForResourceAsync(ChangeTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateHealthCheck


        /// <summary>
        /// Creates a new health check.
        /// 
        ///  
        /// <para>
        /// To create a new health check, send a <code>POST</code> request to the <code>/2013-04-01/healthcheck</code>
        /// resource. The request body must include a document with a <code>CreateHealthCheckRequest</code>
        /// element. The response returns the <code>CreateHealthCheckResponse</code> element,
        /// containing the health check ID specified when adding health check to a resource record
        /// set. For information about adding health checks to resource record sets, see <a>ResourceRecordSet$HealthCheckId</a>
        /// in <a>ChangeResourceRecordSets</a>. 
        /// </para>
        ///  
        /// <para>
        /// If you're registering EC2 instances with an Elastic Load Balancing (ELB) load balancer,
        /// do not create Amazon Route 53 health checks for the EC2 instances. When you register
        /// an EC2 instance with a load balancer, you configure settings for an ELB health check,
        /// which performs a similar function to an Amazon Route 53 health check.
        /// </para>
        ///  
        /// <para>
        /// You can associate health checks with failover resource record sets in a private hosted
        /// zone. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Route 53 health checkers are outside the VPC. To check the health of an endpoint
        /// within a VPC by IP address, you must assign a public IP address to the instance in
        /// the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can configure a health checker to check the health of an external resource that
        /// the instance relies on, such as a database server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can create a CloudWatch metric, associate an alarm with the metric, and then create
        /// a health check that is based on the state of the alarm. For example, you might create
        /// a CloudWatch metric that checks the status of the Amazon EC2 <code>StatusCheckFailed</code>
        /// metric, add an alarm to the metric, and then create a health check that is based on
        /// the state of the alarm. For information about creating CloudWatch metrics and alarms
        /// by using the CloudWatch console, see the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/WhatIsCloudWatch.html">Amazon
        /// CloudWatch User Guide</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the CreateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckAlreadyExistsException">
        /// The health check you're attempting to create already exists. Amazon Route 53 returns
        /// this error when a health check has already been created with the specified value for
        /// <code>CallerReference</code>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyHealthChecksException">
        /// You have reached the maximum number of active health checks for an AWS account. The
        /// default limit is 100. To request a higher limit, <a href="http://aws.amazon.com/route53-request">create
        /// a case</a> with the AWS Support Center.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateHealthCheck">REST API Reference for CreateHealthCheck Operation</seealso>
        CreateHealthCheckResponse CreateHealthCheck(CreateHealthCheckRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateHealthCheck">REST API Reference for CreateHealthCheck Operation</seealso>
        Task<CreateHealthCheckResponse> CreateHealthCheckAsync(CreateHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateHostedZone


        /// <summary>
        /// Creates a new public hosted zone, used to specify how the Domain Name System (DNS)
        /// routes traffic on the Internet for a domain, such as example.com, and its subdomains.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// Public hosted zones can't be converted to a private hosted zone or vice versa. Instead,
        /// create a new hosted zone with the same name and create new resource record sets.
        /// </para>
        ///  </important> 
        /// <para>
        /// Send a <code>POST</code> request to the <code>/2013-04-01/hostedzone</code> resource.
        /// The request body must include a document with a <code>CreateHostedZoneRequest</code>
        /// element. The response returns the <code>CreateHostedZoneResponse</code> element containing
        /// metadata about the hosted zone.
        /// </para>
        ///  
        /// <para>
        /// Fore more information about charges for hosted zones, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
        /// Route 53 Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can't create a hosted zone for a top-level domain (TLD).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Route 53 automatically creates a default SOA record and four NS records for
        /// the zone. For more information about SOA and NS records, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/SOA-NSrecords.html">NS
        /// and SOA Records that Amazon Route 53 Creates for a Hosted Zone</a> in the <i>Amazon
        /// Route 53 Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your domain is registered with a registrar other than Amazon Route 53, you must
        /// update the name servers with your registrar to make Amazon Route 53 your DNS service.
        /// For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/creating-migrating.html">Configuring
        /// Amazon Route 53 as your DNS Service</a> in the <i>Amazon Route 53 Developer's Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After creating a zone, its initial status is <code>PENDING</code>. This means that
        /// it is not yet available on all DNS servers. The status of the zone changes to <code>INSYNC</code>
        /// when the NS and SOA records are available on all Amazon Route 53 DNS servers. 
        /// </para>
        ///  
        /// <para>
        /// When trying to create a hosted zone using a reusable delegation set, specify an optional
        /// DelegationSetId, and Amazon Route 53 would assign those 4 NS records for the zone,
        /// instead of allotting a new one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone service method.</param>
        /// 
        /// <returns>The response from the CreateHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingDomainExistsException">
        /// You specified an Amazon VPC that you're already using for another hosted zone, and
        /// the domain that you specified for one of the hosted zones is a subdomain of the domain
        /// that you specified for the other hosted zone. For example, you can't use the same
        /// Amazon VPC for the hosted zones for example.com and test.example.com.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotAvailableException">
        /// You can create a hosted zone that has the same name as an existing hosted zone (example.com
        /// is common), but there is a limit to the number of hosted zones that have the same
        /// name. If you get this error, Amazon Route 53 has reached that limit. If you own the
        /// domain name and Amazon Route 53 generates this error, contact Customer Support.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZoneAlreadyExistsException">
        /// The hosted zone you're trying to create already exists. Amazon Route 53 returns this
        /// error when a hosted zone has already been created with the specified <code>CallerReference</code>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidDomainNameException">
        /// The specified domain name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The VPC ID that you specified either isn't a valid ID or the current account is not
        /// authorized to access this VPC.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyHostedZonesException">
        /// This hosted zone can't be created because the hosted zone limit is exceeded. To request
        /// a limit increase, go to the Amazon Route 53 <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateHostedZone">REST API Reference for CreateHostedZone Operation</seealso>
        CreateHostedZoneResponse CreateHostedZone(CreateHostedZoneRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateHostedZone">REST API Reference for CreateHostedZone Operation</seealso>
        Task<CreateHostedZoneResponse> CreateHostedZoneAsync(CreateHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReusableDelegationSet


        /// <summary>
        /// Creates a delegation set (a group of four name servers) that can be reused by multiple
        /// hosted zones. If a hosted zoned ID is specified, <code>CreateReusableDelegationSet</code>
        /// marks the delegation set associated with that zone as reusable
        /// 
        ///  
        /// <para>
        /// Send a <code>POST</code> request to the <code>/2013-04-01/delegationset</code> resource.
        /// The request body must include a document with a <code>CreateReusableDelegationSetRequest</code>
        /// element.
        /// </para>
        ///  <note> 
        /// <para>
        /// A reusable delegation set can't be associated with a private hosted zone/
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, including a procedure on how to create and configure a reusable
        /// delegation set (also known as white label name servers), see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/white-label-name-servers.html">Configuring
        /// White Label Name Servers</a>.
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
        /// You can create a hosted zone that has the same name as an existing hosted zone (example.com
        /// is common), but there is a limit to the number of hosted zones that have the same
        /// name. If you get this error, Amazon Route 53 has reached that limit. If you own the
        /// domain name and Amazon Route 53 generates this error, contact Customer Support.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZoneNotFoundException">
        /// The specified HostedZone can't be found.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidArgumentException">
        /// Parameter name is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LimitsExceededException">
        /// The limits specified for a resource have been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateReusableDelegationSet">REST API Reference for CreateReusableDelegationSet Operation</seealso>
        CreateReusableDelegationSetResponse CreateReusableDelegationSet(CreateReusableDelegationSetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateReusableDelegationSet">REST API Reference for CreateReusableDelegationSet Operation</seealso>
        Task<CreateReusableDelegationSetResponse> CreateReusableDelegationSetAsync(CreateReusableDelegationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTrafficPolicy


        /// <summary>
        /// Creates a traffic policy, which you use to create multiple DNS resource record sets
        /// for one domain name (such as example.com) or one subdomain name (such as www.example.com).
        /// 
        ///  
        /// <para>
        /// Send a <code>POST</code> request to the <code>/2013-04-01/trafficpolicy</code> resource.
        /// The request body must include a document with a <code>CreateTrafficPolicyRequest</code>
        /// element. The response includes the <code>CreateTrafficPolicyResponse</code> element,
        /// which contains information about the new traffic policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateTrafficPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateTrafficPolicy">REST API Reference for CreateTrafficPolicy Operation</seealso>
        CreateTrafficPolicyResponse CreateTrafficPolicy(CreateTrafficPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateTrafficPolicy">REST API Reference for CreateTrafficPolicy Operation</seealso>
        Task<CreateTrafficPolicyResponse> CreateTrafficPolicyAsync(CreateTrafficPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Send a <code>POST</code> request to the <code>/2013-04-01/trafficpolicyinstance</code>
        /// resource. The request body must include a document with a <code>CreateTrafficPolicyRequest</code>
        /// element. The response returns the <code>CreateTrafficPolicyInstanceResponse</code>
        /// element, which contains information about the traffic policy instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyInstance service method.</param>
        /// 
        /// <returns>The response from the CreateTrafficPolicyInstance service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateTrafficPolicyInstance">REST API Reference for CreateTrafficPolicyInstance Operation</seealso>
        CreateTrafficPolicyInstanceResponse CreateTrafficPolicyInstance(CreateTrafficPolicyInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateTrafficPolicyInstance">REST API Reference for CreateTrafficPolicyInstance Operation</seealso>
        Task<CreateTrafficPolicyInstanceResponse> CreateTrafficPolicyInstanceAsync(CreateTrafficPolicyInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTrafficPolicyVersion


        /// <summary>
        /// Creates a new version of an existing traffic policy. When you create a new version
        /// of a traffic policy, you specify the ID of the traffic policy that you want to update
        /// and a JSON-formatted document that describes the new version. You use traffic policies
        /// to create multiple DNS resource record sets for one domain name (such as example.com)
        /// or one subdomain name (such as www.example.com). You can create a maximum of 1000
        /// versions of a traffic policy. If you reach the limit and need to create another version,
        /// you'll need to start a new traffic policy.
        /// 
        ///  
        /// <para>
        /// Send a <code>POST</code> request to the <code>/2013-04-01/trafficpolicy/</code> resource.
        /// The request body includes a document with a <code>CreateTrafficPolicyVersionRequest</code>
        /// element. The response returns the <code>CreateTrafficPolicyVersionResponse</code>
        /// element, which contains information about the new version of the traffic policy.
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
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidTrafficPolicyDocumentException">
        /// The format of the traffic policy document that you specified in the <code>Document</code>
        /// element is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateTrafficPolicyVersion">REST API Reference for CreateTrafficPolicyVersion Operation</seealso>
        CreateTrafficPolicyVersionResponse CreateTrafficPolicyVersion(CreateTrafficPolicyVersionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateTrafficPolicyVersion">REST API Reference for CreateTrafficPolicyVersion Operation</seealso>
        Task<CreateTrafficPolicyVersionResponse> CreateTrafficPolicyVersionAsync(CreateTrafficPolicyVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateVPCAssociationAuthorization


        /// <summary>
        /// Authorizes the AWS account that created a specified VPC to submit an <code>AssociateVPCWithHostedZone</code>
        /// request to associate the VPC with a specified hosted zone that was created by a different
        /// account. To submit a <code>CreateVPCAssociationAuthorization</code> request, you must
        /// use the account that created the hosted zone. After you authorize the association,
        /// use the account that created the VPC to submit an <code>AssociateVPCWithHostedZone</code>
        /// request.
        /// 
        ///  <note> 
        /// <para>
        /// If you want to associate multiple VPCs that you created by using one account with
        /// a hosted zone that you created by using a different account, you must submit one authorization
        /// request for each VPC.
        /// </para>
        ///  </note> 
        /// <para>
        /// Send a <code>POST</code> request to the <code>/2013-04-01/hostedzone/<i>hosted zone
        /// ID</i>/authorizevpcassociation</code> resource. The request body must include a document
        /// with a <code>CreateVPCAssociationAuthorizationRequest</code> element. The response
        /// contains information about the authorization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVPCAssociationAuthorization service method.</param>
        /// 
        /// <returns>The response from the CreateVPCAssociationAuthorization service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to update the object at the same time that you did.
        /// Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The VPC ID that you specified either isn't a valid ID or the current account is not
        /// authorized to access this VPC.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyVPCAssociationAuthorizationsException">
        /// You've created the maximum number of authorizations that can be created for the specified
        /// hosted zone. To authorize another VPC to be associated with the hosted zone, submit
        /// a <code>DeleteVPCAssociationAuthorization</code> request to remove an existing authorization.
        /// To get a list of existing authorizations, submit a <code>ListVPCAssociationAuthorizations</code>
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateVPCAssociationAuthorization">REST API Reference for CreateVPCAssociationAuthorization Operation</seealso>
        CreateVPCAssociationAuthorizationResponse CreateVPCAssociationAuthorization(CreateVPCAssociationAuthorizationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVPCAssociationAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVPCAssociationAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateVPCAssociationAuthorization">REST API Reference for CreateVPCAssociationAuthorization Operation</seealso>
        Task<CreateVPCAssociationAuthorizationResponse> CreateVPCAssociationAuthorizationAsync(CreateVPCAssociationAuthorizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteHealthCheck


        /// <summary>
        /// Deletes a health check. Send a <code>DELETE</code> request to the <code>/2013-04-01/healthcheck/<i>health
        /// check ID</i> </code> resource.
        /// 
        ///  <important> 
        /// <para>
        /// Amazon Route 53 does not prevent you from deleting a health check even if the health
        /// check is associated with one or more resource record sets. If you delete a health
        /// check and you don't update the associated resource record sets, the future status
        /// of the health check can't be predicted and may change. This will affect the routing
        /// of DNS queries for your DNS failover configuration. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/health-checks-creating-deleting.html#health-checks-deleting.html">Replacing
        /// and Deleting Health Checks</a> in the Amazon Route 53 Developer Guide.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck service method.</param>
        /// 
        /// <returns>The response from the DeleteHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckInUseException">
        /// The health check ID for this health check is referenced in the <code>HealthCheckId</code>
        /// element in one of the resource record sets in one of the hosted zones that are owned
        /// by the current AWS account.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the ID that you specified in the <code>DeleteHealthCheck</code>
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteHealthCheck">REST API Reference for DeleteHealthCheck Operation</seealso>
        DeleteHealthCheckResponse DeleteHealthCheck(DeleteHealthCheckRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteHealthCheck">REST API Reference for DeleteHealthCheck Operation</seealso>
        Task<DeleteHealthCheckResponse> DeleteHealthCheckAsync(DeleteHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteHostedZone


        /// <summary>
        /// Deletes a hosted zone. Send a <code>DELETE</code> request to the <code>/<i>Amazon
        /// Route 53 API version</i>/hostedzone/<i>hosted zone ID</i> </code> resource.
        /// 
        ///  <important> 
        /// <para>
        /// Delete a hosted zone only if there are no resource record sets other than the default
        /// SOA record and NS resource record sets. If the hosted zone contains other resource
        /// record sets, delete them before deleting the hosted zone. If you try to delete a hosted
        /// zone that contains other resource record sets, Amazon Route 53 denies your request
        /// with a <code>HostedZoneNotEmpty</code> error. For information about deleting records
        /// from your hosted zone, see <a>ChangeResourceRecordSets</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone service method.</param>
        /// 
        /// <returns>The response from the DeleteHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HostedZoneNotEmptyException">
        /// The hosted zone contains resource records that are not SOA or NS records.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidDomainNameException">
        /// The specified domain name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// If Amazon Route 53 can't process a request before the next request arrives, it will
        /// reject subsequent requests for the same hosted zone and return an <code>HTTP 400 error</code>
        /// (<code>Bad request</code>). If Amazon Route 53 returns this error repeatedly for the
        /// same request, we recommend that you wait, in intervals of increasing duration, before
        /// you try the request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteHostedZone">REST API Reference for DeleteHostedZone Operation</seealso>
        DeleteHostedZoneResponse DeleteHostedZone(DeleteHostedZoneRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteHostedZone">REST API Reference for DeleteHostedZone Operation</seealso>
        Task<DeleteHostedZoneResponse> DeleteHostedZoneAsync(DeleteHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReusableDelegationSet


        /// <summary>
        /// Deletes a reusable delegation set. Send a <code>DELETE</code> request to the <code>/2013-04-01/delegationset/<i>delegation
        /// set ID</i> </code> resource.
        /// 
        ///  <important> 
        /// <para>
        ///  You can delete a reusable delegation set only if there are no associated hosted zones.
        /// </para>
        ///  </important> 
        /// <para>
        /// To verify that the reusable delegation set is not associated with any hosted zones,
        /// run the <a>GetReusableDelegationSet</a> action and specify the ID of the reusable
        /// delegation set that you want to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the DeleteReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetInUseException">
        /// The specified delegation contains associated hosted zones which must be deleted before
        /// the reusable delegation set can be deleted.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteReusableDelegationSet">REST API Reference for DeleteReusableDelegationSet Operation</seealso>
        DeleteReusableDelegationSetResponse DeleteReusableDelegationSet(DeleteReusableDelegationSetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteReusableDelegationSet">REST API Reference for DeleteReusableDelegationSet Operation</seealso>
        Task<DeleteReusableDelegationSetResponse> DeleteReusableDelegationSetAsync(DeleteReusableDelegationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTrafficPolicy


        /// <summary>
        /// Deletes a traffic policy.
        /// 
        ///  
        /// <para>
        /// Send a <code>DELETE</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicy</code>
        /// resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteTrafficPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to update the object at the same time that you did.
        /// Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TrafficPolicyInUseException">
        /// One or more traffic policy instances were created by using the specified traffic policy.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteTrafficPolicy">REST API Reference for DeleteTrafficPolicy Operation</seealso>
        DeleteTrafficPolicyResponse DeleteTrafficPolicy(DeleteTrafficPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteTrafficPolicy">REST API Reference for DeleteTrafficPolicy Operation</seealso>
        Task<DeleteTrafficPolicyResponse> DeleteTrafficPolicyAsync(DeleteTrafficPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTrafficPolicyInstance


        /// <summary>
        /// Deletes a traffic policy instance and all of the resource record sets that Amazon
        /// Route 53 created when you created the instance.
        /// 
        ///  
        /// <para>
        /// Send a <code>DELETE</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicy/<i>traffic
        /// policy instance ID</i> </code> resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// In the Amazon Route 53 console, traffic policy instances are known as policy records.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicyInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteTrafficPolicyInstance service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// If Amazon Route 53 can't process a request before the next request arrives, it will
        /// reject subsequent requests for the same hosted zone and return an <code>HTTP 400 error</code>
        /// (<code>Bad request</code>). If Amazon Route 53 returns this error repeatedly for the
        /// same request, we recommend that you wait, in intervals of increasing duration, before
        /// you try the request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteTrafficPolicyInstance">REST API Reference for DeleteTrafficPolicyInstance Operation</seealso>
        DeleteTrafficPolicyInstanceResponse DeleteTrafficPolicyInstance(DeleteTrafficPolicyInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteTrafficPolicyInstance">REST API Reference for DeleteTrafficPolicyInstance Operation</seealso>
        Task<DeleteTrafficPolicyInstanceResponse> DeleteTrafficPolicyInstanceAsync(DeleteTrafficPolicyInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVPCAssociationAuthorization


        /// <summary>
        /// Removes authorization to submit an <code>AssociateVPCWithHostedZone</code> request
        /// to associate a specified VPC with a hosted zone that was created by a different account.
        /// You must use the account that created the hosted zone to submit a <code>DeleteVPCAssociationAuthorization</code>
        /// request.
        /// 
        ///  <important> 
        /// <para>
        /// Sending this request only prevents the AWS account that created the VPC from associating
        /// the VPC with the Amazon Route 53 hosted zone in the future. If the VPC is already
        /// associated with the hosted zone, <code>DeleteVPCAssociationAuthorization</code> won't
        /// disassociate the VPC from the hosted zone. If you want to delete an existing association,
        /// use <code>DisassociateVPCFromHostedZone</code>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Send a <code>DELETE</code> request to the <code>/2013-04-01/hostedzone/<i>hosted zone
        /// ID</i>/deauthorizevpcassociation</code> resource. The request body must include a
        /// document with a <code>DeleteVPCAssociationAuthorizationRequest</code> element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVPCAssociationAuthorization service method.</param>
        /// 
        /// <returns>The response from the DeleteVPCAssociationAuthorization service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to update the object at the same time that you did.
        /// Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The VPC ID that you specified either isn't a valid ID or the current account is not
        /// authorized to access this VPC.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.VPCAssociationAuthorizationNotFoundException">
        /// The VPC that you specified is not authorized to be associated with the hosted zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteVPCAssociationAuthorization">REST API Reference for DeleteVPCAssociationAuthorization Operation</seealso>
        DeleteVPCAssociationAuthorizationResponse DeleteVPCAssociationAuthorization(DeleteVPCAssociationAuthorizationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVPCAssociationAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVPCAssociationAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteVPCAssociationAuthorization">REST API Reference for DeleteVPCAssociationAuthorization Operation</seealso>
        Task<DeleteVPCAssociationAuthorizationResponse> DeleteVPCAssociationAuthorizationAsync(DeleteVPCAssociationAuthorizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateVPCFromHostedZone


        /// <summary>
        /// Disassociates a VPC from a Amazon Route 53 private hosted zone. 
        /// 
        ///  <note> 
        /// <para>
        /// You can't disassociate the last VPC from a private hosted zone.
        /// </para>
        ///  </note> 
        /// <para>
        /// Send a <code>POST</code> request to the <code>/2013-04-01/hostedzone/<i>hosted zone
        /// ID</i>/disassociatevpc</code> resource. The request body must include a document with
        /// a <code>DisassociateVPCFromHostedZoneRequest</code> element. The response includes
        /// a <code>DisassociateVPCFromHostedZoneResponse</code> element.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can't disassociate a VPC from a private hosted zone when only one VPC is associated
        /// with the hosted zone. You also can't convert a private hosted zone into a public hosted
        /// zone.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone service method.</param>
        /// 
        /// <returns>The response from the DisassociateVPCFromHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The VPC ID that you specified either isn't a valid ID or the current account is not
        /// authorized to access this VPC.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LastVPCAssociationException">
        /// The VPC that you're trying to disassociate from the private hosted zone is the last
        /// VPC that is associated with the hosted zone. Amazon Route 53 doesn't support disassociating
        /// the last VPC from a hosted zone.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.VPCAssociationNotFoundException">
        /// The specified VPC and hosted zone are not currently associated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DisassociateVPCFromHostedZone">REST API Reference for DisassociateVPCFromHostedZone Operation</seealso>
        DisassociateVPCFromHostedZoneResponse DisassociateVPCFromHostedZone(DisassociateVPCFromHostedZoneRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVPCFromHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DisassociateVPCFromHostedZone">REST API Reference for DisassociateVPCFromHostedZone Operation</seealso>
        Task<DisassociateVPCFromHostedZoneResponse> DisassociateVPCFromHostedZoneAsync(DisassociateVPCFromHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetChange


        /// <summary>
        /// Returns the current status of a change batch request. The status is one of the following
        /// values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>PENDING</code> indicates that the changes in this request have not replicated
        /// to all Amazon Route 53 DNS servers. This is the initial status of all change batch
        /// requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INSYNC</code> indicates that the changes have replicated to all Amazon Route
        /// 53 DNS servers. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChange service method.</param>
        /// 
        /// <returns>The response from the GetChange service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchChangeException">
        /// A change with the specified change ID does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetChange">REST API Reference for GetChange Operation</seealso>
        GetChangeResponse GetChange(GetChangeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetChange operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChange operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetChange">REST API Reference for GetChange Operation</seealso>
        Task<GetChangeResponse> GetChangeAsync(GetChangeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCheckerIpRanges


        /// <summary>
        /// <code>GetCheckerIpRanges</code> still works, but we recommend that you download ip-ranges.json,
        /// which includes IP address ranges for all AWS services. For more information, see <a
        /// href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/route-53-ip-addresses.html">IP
        /// Address Ranges of Amazon Route 53 Servers</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges service method.</param>
        /// 
        /// <returns>The response from the GetCheckerIpRanges service method, as returned by Route53.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetCheckerIpRanges">REST API Reference for GetCheckerIpRanges Operation</seealso>
        GetCheckerIpRangesResponse GetCheckerIpRanges(GetCheckerIpRangesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCheckerIpRanges operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetCheckerIpRanges">REST API Reference for GetCheckerIpRanges Operation</seealso>
        Task<GetCheckerIpRangesResponse> GetCheckerIpRangesAsync(GetCheckerIpRangesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGeoLocation


        /// <summary>
        /// Retrieves a single geo location. Send a <code>GET</code> request to the <code>/2013-04-01/geolocation</code>
        /// resource with one of these options: continentcode | countrycode | countrycode and
        /// subdivisioncode.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation service method.</param>
        /// 
        /// <returns>The response from the GetGeoLocation service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchGeoLocationException">
        /// Amazon Route 53 doesn't support the specified geolocation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetGeoLocation">REST API Reference for GetGeoLocation Operation</seealso>
        GetGeoLocationResponse GetGeoLocation(GetGeoLocationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetGeoLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetGeoLocation">REST API Reference for GetGeoLocation Operation</seealso>
        Task<GetGeoLocationResponse> GetGeoLocationAsync(GetGeoLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHealthCheck


        /// <summary>
        /// Gets information about a specified health check. Send a <code>GET</code> request to
        /// the <code>/2013-04-01/healthcheck/<i>health check ID</i> </code> resource. For more
        /// information about using the console to perform this operation, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover.html">Amazon
        /// Route 53 Health Checks and DNS Failover</a> in the Amazon Route 53 Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you're trying to access is unsupported on this Amazon Route 53 endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the ID that you specified in the <code>DeleteHealthCheck</code>
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheck">REST API Reference for GetHealthCheck Operation</seealso>
        GetHealthCheckResponse GetHealthCheck(GetHealthCheckRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheck">REST API Reference for GetHealthCheck Operation</seealso>
        Task<GetHealthCheckResponse> GetHealthCheckAsync(GetHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHealthCheckCount


        /// <summary>
        /// To retrieve a count of all your health checks, send a <code>GET</code> request to
        /// the <code>/2013-04-01/healthcheckcount</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckCount service method, as returned by Route53.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheckCount">REST API Reference for GetHealthCheckCount Operation</seealso>
        GetHealthCheckCountResponse GetHealthCheckCount(GetHealthCheckCountRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheckCount">REST API Reference for GetHealthCheckCount Operation</seealso>
        Task<GetHealthCheckCountResponse> GetHealthCheckCountAsync(GetHealthCheckCountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHealthCheckLastFailureReason


        /// <summary>
        /// If you want to learn why a health check is currently failing or why it failed most
        /// recently (if at all), you can get the failure reason for the most recent failure.
        /// Send a <code>GET</code> request to the <code>/<i>Amazon Route 53 API version</i>/healthcheck/<i>health
        /// check ID</i>/lastfailurereason</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckLastFailureReason service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the ID that you specified in the <code>DeleteHealthCheck</code>
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheckLastFailureReason">REST API Reference for GetHealthCheckLastFailureReason Operation</seealso>
        GetHealthCheckLastFailureReasonResponse GetHealthCheckLastFailureReason(GetHealthCheckLastFailureReasonRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckLastFailureReason operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheckLastFailureReason">REST API Reference for GetHealthCheckLastFailureReason Operation</seealso>
        Task<GetHealthCheckLastFailureReasonResponse> GetHealthCheckLastFailureReasonAsync(GetHealthCheckLastFailureReasonRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHealthCheckStatus


        /// <summary>
        /// Gets status of a specified health check. Send a <code>GET</code> request to the <code>/2013-04-01/healthcheck/<i>health
        /// check ID</i>/status</code> resource. You can use this call to get a health check's
        /// current status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckStatus service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the ID that you specified in the <code>DeleteHealthCheck</code>
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheckStatus">REST API Reference for GetHealthCheckStatus Operation</seealso>
        GetHealthCheckStatusResponse GetHealthCheckStatus(GetHealthCheckStatusRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetHealthCheckStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheckStatus">REST API Reference for GetHealthCheckStatus Operation</seealso>
        Task<GetHealthCheckStatusResponse> GetHealthCheckStatusAsync(GetHealthCheckStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHostedZone


        /// <summary>
        /// Retrieves the delegation set for a hosted zone, including the four name servers assigned
        /// to the hosted zone. Send a <code>GET</code> request to the <code>/<i>Amazon Route
        /// 53 API version</i>/hostedzone/<i>hosted zone ID</i> </code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone service method.</param>
        /// 
        /// <returns>The response from the GetHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZone">REST API Reference for GetHostedZone Operation</seealso>
        GetHostedZoneResponse GetHostedZone(GetHostedZoneRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZone">REST API Reference for GetHostedZone Operation</seealso>
        Task<GetHostedZoneResponse> GetHostedZoneAsync(GetHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetHostedZoneCount


        /// <summary>
        /// Retrieves a count of all your hosted zones. Send a <code>GET</code> request to the
        /// <code>/2013-04-01/hostedzonecount</code> resource.
        /// </summary>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZoneCount">REST API Reference for GetHostedZoneCount Operation</seealso>
        GetHostedZoneCountResponse GetHostedZoneCount();


        /// <summary>
        /// Retrieves a count of all your hosted zones. Send a <code>GET</code> request to the
        /// <code>/2013-04-01/hostedzonecount</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneCount service method.</param>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZoneCount">REST API Reference for GetHostedZoneCount Operation</seealso>
        GetHostedZoneCountResponse GetHostedZoneCount(GetHostedZoneCountRequest request);


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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZoneCount">REST API Reference for GetHostedZoneCount Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZoneCount">REST API Reference for GetHostedZoneCount Operation</seealso>
        Task<GetHostedZoneCountResponse> GetHostedZoneCountAsync(GetHostedZoneCountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetReusableDelegationSet


        /// <summary>
        /// Retrieves the reusable delegation set. Send a <code>GET</code> request to the <code>/2013-04-01/delegationset/<i>delegation
        /// set ID</i> </code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet service method.</param>
        /// 
        /// <returns>The response from the GetReusableDelegationSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetReusableDelegationSet">REST API Reference for GetReusableDelegationSet Operation</seealso>
        GetReusableDelegationSetResponse GetReusableDelegationSet(GetReusableDelegationSetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetReusableDelegationSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetReusableDelegationSet">REST API Reference for GetReusableDelegationSet Operation</seealso>
        Task<GetReusableDelegationSetResponse> GetReusableDelegationSetAsync(GetReusableDelegationSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTrafficPolicy


        /// <summary>
        /// Gets information about a specific traffic policy version.
        /// 
        ///  
        /// <para>
        /// Send a <code>GET</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicy</code>
        /// resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the GetTrafficPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetTrafficPolicy">REST API Reference for GetTrafficPolicy Operation</seealso>
        GetTrafficPolicyResponse GetTrafficPolicy(GetTrafficPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetTrafficPolicy">REST API Reference for GetTrafficPolicy Operation</seealso>
        Task<GetTrafficPolicyResponse> GetTrafficPolicyAsync(GetTrafficPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTrafficPolicyInstance


        /// <summary>
        /// Gets information about a specified traffic policy instance.
        /// 
        ///  
        /// <para>
        /// Send a <code>GET</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicyinstance</code>
        /// resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// After you submit a <code>CreateTrafficPolicyInstance</code> or an <code>UpdateTrafficPolicyInstance</code>
        /// request, there's a brief delay while Amazon Route 53 creates the resource record sets
        /// that are specified in the traffic policy definition. For more information, see the
        /// <code>State</code> response element.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// In the Amazon Route 53 console, traffic policy instances are known as policy records.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstance service method.</param>
        /// 
        /// <returns>The response from the GetTrafficPolicyInstance service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetTrafficPolicyInstance">REST API Reference for GetTrafficPolicyInstance Operation</seealso>
        GetTrafficPolicyInstanceResponse GetTrafficPolicyInstance(GetTrafficPolicyInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetTrafficPolicyInstance">REST API Reference for GetTrafficPolicyInstance Operation</seealso>
        Task<GetTrafficPolicyInstanceResponse> GetTrafficPolicyInstanceAsync(GetTrafficPolicyInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTrafficPolicyInstanceCount


        /// <summary>
        /// Gets the number of traffic policy instances that are associated with the current AWS
        /// account.
        /// 
        ///  
        /// <para>
        /// To get the number of traffic policy instances, send a <code>GET</code> request to
        /// the <code>/2013-04-01/trafficpolicyinstancecount</code> resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstanceCount service method.</param>
        /// 
        /// <returns>The response from the GetTrafficPolicyInstanceCount service method, as returned by Route53.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetTrafficPolicyInstanceCount">REST API Reference for GetTrafficPolicyInstanceCount Operation</seealso>
        GetTrafficPolicyInstanceCountResponse GetTrafficPolicyInstanceCount(GetTrafficPolicyInstanceCountRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicyInstanceCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstanceCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetTrafficPolicyInstanceCount">REST API Reference for GetTrafficPolicyInstanceCount Operation</seealso>
        Task<GetTrafficPolicyInstanceCountResponse> GetTrafficPolicyInstanceCountAsync(GetTrafficPolicyInstanceCountRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListGeoLocations">REST API Reference for ListGeoLocations Operation</seealso>
        ListGeoLocationsResponse ListGeoLocations();


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
        /// <param name="request">Container for the necessary parameters to execute the ListGeoLocations service method.</param>
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListGeoLocations">REST API Reference for ListGeoLocations Operation</seealso>
        ListGeoLocationsResponse ListGeoLocations(ListGeoLocationsRequest request);


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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListGeoLocations">REST API Reference for ListGeoLocations Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListGeoLocations">REST API Reference for ListGeoLocations Operation</seealso>
        Task<ListGeoLocationsResponse> ListGeoLocationsAsync(ListGeoLocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you're trying to access is unsupported on this Amazon Route 53 endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHealthChecks">REST API Reference for ListHealthChecks Operation</seealso>
        ListHealthChecksResponse ListHealthChecks();


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
        /// <param name="request">Container for the necessary parameters to execute the ListHealthChecks service method.</param>
        /// 
        /// <returns>The response from the ListHealthChecks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you're trying to access is unsupported on this Amazon Route 53 endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHealthChecks">REST API Reference for ListHealthChecks Operation</seealso>
        ListHealthChecksResponse ListHealthChecks(ListHealthChecksRequest request);


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
        /// The resource you're trying to access is unsupported on this Amazon Route 53 endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHealthChecks">REST API Reference for ListHealthChecks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHealthChecks">REST API Reference for ListHealthChecks Operation</seealso>
        Task<ListHealthChecksResponse> ListHealthChecksAsync(ListHealthChecksRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ///  <code>MaxItems</code> is the value specified for the <code>maxitems</code> parameter
        /// in the request that produced the current response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is true, there are more hosted
        /// zones associated with the current AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NextMarker</code> is the hosted zone ID of the next hosted zone that is associated
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHostedZones">REST API Reference for ListHostedZones Operation</seealso>
        ListHostedZonesResponse ListHostedZones();


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
        ///  <code>MaxItems</code> is the value specified for the <code>maxitems</code> parameter
        /// in the request that produced the current response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is true, there are more hosted
        /// zones associated with the current AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NextMarker</code> is the hosted zone ID of the next hosted zone that is associated
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
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZones service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHostedZones">REST API Reference for ListHostedZones Operation</seealso>
        ListHostedZonesResponse ListHostedZones(ListHostedZonesRequest request);


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
        ///  <code>MaxItems</code> is the value specified for the <code>maxitems</code> parameter
        /// in the request that produced the current response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is true, there are more hosted
        /// zones associated with the current AWS account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NextMarker</code> is the hosted zone ID of the next hosted zone that is associated
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHostedZones">REST API Reference for ListHostedZones Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHostedZones">REST API Reference for ListHostedZones Operation</seealso>
        Task<ListHostedZonesResponse> ListHostedZonesAsync(ListHostedZonesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListHostedZonesByName


        /// <summary>
        /// Retrieves a list of your hosted zones in lexicographic order. Send a <code>GET</code>
        /// request to the <code>/2013-04-01/hostedzonesbyname</code> resource. The response includes
        /// a <code>HostedZones</code> child element for each hosted zone created by the current
        /// AWS account. 
        /// 
        ///  
        /// <para>
        ///  <code>ListHostedZonesByName</code> sorts hosted zones by name with the labels reversed.
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>com.example.www.</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note the trailing dot, which can change the sort order in some circumstances.
        /// </para>
        ///  
        /// <para>
        /// If the domain name includes escape characters or Punycode, <code>ListHostedZonesByName</code>
        /// alphabetizes the domain name using the escaped or Punycoded value, which is the format
        /// that Amazon Route 53 saves in its database. For example, to create a hosted zone for
        /// example.com, specify ex\344mple.com for the domain name. <code>ListHostedZonesByName</code>
        /// alphabetizes it as:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>com.ex\344mple.</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The labels are reversed and alphabetized using the escaped value. For more information
        /// about valid domain name formats, including internationalized domain names, see <a
        /// href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html">DNS
        /// Domain Name Format</a> in the Amazon Route 53 Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// Amazon Route 53 returns up to 100 items in each response. If you have a lot of hosted
        /// zones, use the <code>MaxItems</code> parameter to list them in groups of up to 100.
        /// The response includes values that help navigate from one group of <code>MaxItems</code>
        /// hosted zones to the next:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>DNSName</code> and <code>HostedZoneId</code> elements in the response contain
        /// the values, if any, specified for the <code>dnsname</code> and <code>hostedzoneid</code>
        /// parameters in the request that produced the current response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>MaxItems</code> element in the response contains the value, if any, that
        /// you specified for the <code>maxitems</code> parameter in the request that produced
        /// the current response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is true, there are more hosted
        /// zones associated with the current AWS account. 
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is false, this response includes the last hosted zone
        /// that is associated with the current account. The <code>NextDNSName</code> element
        /// and <code>NextHostedZoneId</code> elements are omitted from the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>NextDNSName</code> and <code>NextHostedZoneId</code> elements in the response
        /// contain the domain name and the hosted zone ID of the next hosted zone that is associated
        /// with the current AWS account. If you want to list more hosted zones, make another
        /// call to <code>ListHostedZonesByName</code>, and specify the value of <code>NextDNSName</code>
        /// and <code>NextHostedZoneId</code> in the <code>dnsname</code> and <code>hostedzoneid</code>
        /// parameters, respectively.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZonesByName service method.</param>
        /// 
        /// <returns>The response from the ListHostedZonesByName service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidDomainNameException">
        /// The specified domain name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHostedZonesByName">REST API Reference for ListHostedZonesByName Operation</seealso>
        ListHostedZonesByNameResponse ListHostedZonesByName(ListHostedZonesByNameRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZonesByName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZonesByName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHostedZonesByName">REST API Reference for ListHostedZonesByName Operation</seealso>
        Task<ListHostedZonesByNameResponse> ListHostedZonesByNameAsync(ListHostedZonesByNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourceRecordSets


        /// <summary>
        /// Lists the resource record sets in a specified hosted zone.
        /// 
        ///  
        /// <para>
        ///  <code>ListResourceRecordSets</code> returns up to 100 resource record sets at a time
        /// in ASCII order, beginning at a position specified by the <code>name</code> and <code>type</code>
        /// elements. The action sorts results first by DNS name with the labels reversed, for
        /// example:
        /// </para>
        ///  
        /// <para>
        ///  <code>com.example.www.</code> 
        /// </para>
        ///  
        /// <para>
        /// Note the trailing dot, which can change the sort order in some circumstances.
        /// </para>
        ///  
        /// <para>
        /// When multiple records have the same DNS name, the action sorts results by the record
        /// type.
        /// </para>
        ///  
        /// <para>
        /// You can use the name and type elements to adjust the beginning position of the list
        /// of resource record sets returned:
        /// </para>
        ///  <dl> <dt>If you do not specify Name or Type</dt> <dd> 
        /// <para>
        /// The results begin with the first resource record set that the hosted zone contains.
        /// </para>
        ///  </dd> <dt>If you specify Name but not Type</dt> <dd> 
        /// <para>
        /// The results begin with the first resource record set in the list whose name is greater
        /// than or equal to <code>Name</code>.
        /// </para>
        ///  </dd> <dt>If you specify Type but not Name</dt> <dd> 
        /// <para>
        /// Amazon Route 53 returns the <code>InvalidInput</code> error.
        /// </para>
        ///  </dd> <dt>If you specify both Name and Type</dt> <dd> 
        /// <para>
        /// The results begin with the first resource record set in the list whose name is greater
        /// than or equal to <code>Name</code>, and whose type is greater than or equal to <code>Type</code>.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// This action returns the most current version of the records. This includes records
        /// that are <code>PENDING</code>, and that are not yet available on all Amazon Route
        /// 53 DNS servers.
        /// </para>
        ///  
        /// <para>
        /// To ensure that you get an accurate listing of the resource record sets for a hosted
        /// zone at a point in time, do not submit a <code>ChangeResourceRecordSets</code> request
        /// while you're paging through the results of a <code>ListResourceRecordSets</code> request.
        /// If you do, some pages may display results without the latest changes while other pages
        /// display results with the latest changes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets service method.</param>
        /// 
        /// <returns>The response from the ListResourceRecordSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListResourceRecordSets">REST API Reference for ListResourceRecordSets Operation</seealso>
        ListResourceRecordSetsResponse ListResourceRecordSets(ListResourceRecordSetsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceRecordSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListResourceRecordSets">REST API Reference for ListResourceRecordSets Operation</seealso>
        Task<ListResourceRecordSetsResponse> ListResourceRecordSetsAsync(ListResourceRecordSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListReusableDelegationSets">REST API Reference for ListReusableDelegationSets Operation</seealso>
        ListReusableDelegationSetsResponse ListReusableDelegationSets();


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
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets service method.</param>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListReusableDelegationSets">REST API Reference for ListReusableDelegationSets Operation</seealso>
        ListReusableDelegationSetsResponse ListReusableDelegationSets(ListReusableDelegationSetsRequest request);


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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListReusableDelegationSets">REST API Reference for ListReusableDelegationSets Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListReusableDelegationSets">REST API Reference for ListReusableDelegationSets Operation</seealso>
        Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(ListReusableDelegationSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for one health check or hosted zone. 
        /// 
        ///  
        /// <para>
        /// For information about using tags for cost allocation, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the ID that you specified in the <code>DeleteHealthCheck</code>
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// If Amazon Route 53 can't process a request before the next request arrives, it will
        /// reject subsequent requests for the same hosted zone and return an <code>HTTP 400 error</code>
        /// (<code>Bad request</code>). If Amazon Route 53 returns this error repeatedly for the
        /// same request, we recommend that you wait, in intervals of increasing duration, before
        /// you try the request again.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResources


        /// <summary>
        /// Lists tags for up to 10 health checks or hosted zones.
        /// 
        ///  
        /// <para>
        /// For information about using tags for cost allocation, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResources service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the ID that you specified in the <code>DeleteHealthCheck</code>
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// If Amazon Route 53 can't process a request before the next request arrives, it will
        /// reject subsequent requests for the same hosted zone and return an <code>HTTP 400 error</code>
        /// (<code>Bad request</code>). If Amazon Route 53 returns this error repeatedly for the
        /// same request, we recommend that you wait, in intervals of increasing duration, before
        /// you try the request again.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTagsForResources">REST API Reference for ListTagsForResources Operation</seealso>
        ListTagsForResourcesResponse ListTagsForResources(ListTagsForResourcesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTagsForResources">REST API Reference for ListTagsForResources Operation</seealso>
        Task<ListTagsForResourcesResponse> ListTagsForResourcesAsync(ListTagsForResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTrafficPolicies


        /// <summary>
        /// Gets information about the latest version for every traffic policy that is associated
        /// with the current AWS account. Send a <code>GET</code> request to the <code>/<i>Amazon
        /// Route 53 API version</i>/trafficpolicy</code> resource.
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
        ///  <ul> <li> 
        /// <para>
        ///  <b>IsTruncated</b> 
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
        /// are more traffic policies associated with the current AWS account.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy that is associated with the current account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TrafficPolicyIdMarker</b> 
        /// </para>
        ///  
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
        ///  </li> <li> 
        /// <para>
        ///  <b>MaxItems</b> 
        /// </para>
        ///  
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicies service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicies">REST API Reference for ListTrafficPolicies Operation</seealso>
        ListTrafficPoliciesResponse ListTrafficPolicies(ListTrafficPoliciesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicies">REST API Reference for ListTrafficPolicies Operation</seealso>
        Task<ListTrafficPoliciesResponse> ListTrafficPoliciesAsync(ListTrafficPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTrafficPolicyInstances


        /// <summary>
        /// Gets information about the traffic policy instances that you created by using the
        /// current AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// After you submit an <code>UpdateTrafficPolicyInstance</code> request, there's a brief
        /// delay while Amazon Route 53 creates the resource record sets that are specified in
        /// the traffic policy definition. For more information, see the <code>State</code> response
        /// element.
        /// </para>
        ///  </note> 
        /// <para>
        /// Send a <code>GET</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicyinstance</code>
        /// resource.
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
        ///  <ul> <li> 
        /// <para>
        ///  <b>IsTruncated</b> 
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
        /// are more traffic policy instances associated with the current AWS account.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy instance that is associated with the current account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MaxItems</b> 
        /// </para>
        ///  
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>HostedZoneIdMarker</b>, <b>TrafficPolicyInstanceNameMarker</b>, and <b>TrafficPolicyInstanceTypeMarker</b>
        /// 
        /// </para>
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
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstances service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicyInstances service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyInstances">REST API Reference for ListTrafficPolicyInstances Operation</seealso>
        ListTrafficPolicyInstancesResponse ListTrafficPolicyInstances(ListTrafficPolicyInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyInstances">REST API Reference for ListTrafficPolicyInstances Operation</seealso>
        Task<ListTrafficPolicyInstancesResponse> ListTrafficPolicyInstancesAsync(ListTrafficPolicyInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTrafficPolicyInstancesByHostedZone


        /// <summary>
        /// Gets information about the traffic policy instances that you created in a specified
        /// hosted zone.
        /// 
        ///  <note> 
        /// <para>
        /// After you submit an <code>UpdateTrafficPolicyInstance</code> request, there's a brief
        /// delay while Amazon Route 53 creates the resource record sets that are specified in
        /// the traffic policy definition. For more information, see the <code>State</code> response
        /// element.
        /// </para>
        ///  </note> 
        /// <para>
        /// Send a <code>GET</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicyinstance</code>
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
        ///  <ul> <li> 
        /// <para>
        ///  <b>IsTruncated</b> 
        /// </para>
        ///  
        /// <para>
        /// If the value of <code/>IsTruncated in the response is <code>true</code>, there are
        /// more traffic policy instances associated with the current AWS account.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy instance that is associated with the current account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MaxItems</b> 
        /// </para>
        ///  
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TrafficPolicyInstanceNameMarker</b> and <b>TrafficPolicyInstanceTypeMarker</b>
        /// 
        /// </para>
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
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByHostedZone service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicyInstancesByHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyInstancesByHostedZone">REST API Reference for ListTrafficPolicyInstancesByHostedZone Operation</seealso>
        ListTrafficPolicyInstancesByHostedZoneResponse ListTrafficPolicyInstancesByHostedZone(ListTrafficPolicyInstancesByHostedZoneRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstancesByHostedZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByHostedZone operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyInstancesByHostedZone">REST API Reference for ListTrafficPolicyInstancesByHostedZone Operation</seealso>
        Task<ListTrafficPolicyInstancesByHostedZoneResponse> ListTrafficPolicyInstancesByHostedZoneAsync(ListTrafficPolicyInstancesByHostedZoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTrafficPolicyInstancesByPolicy


        /// <summary>
        /// Gets information about the traffic policy instances that you created by using a specify
        /// traffic policy version.
        /// 
        ///  <note> 
        /// <para>
        /// After you submit a <code>CreateTrafficPolicyInstance</code> or an <code>UpdateTrafficPolicyInstance</code>
        /// request, there's a brief delay while Amazon Route 53 creates the resource record sets
        /// that are specified in the traffic policy definition. For more information, see the
        /// <code>State</code> response element.
        /// </para>
        ///  </note> 
        /// <para>
        /// Send a <code>GET</code> request to the <code>/<i>Route 53 API version</i>/trafficpolicyinstance</code>
        /// resource and include the ID and version of the traffic policy.
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
        ///  <ul> <li> 
        /// <para>
        ///  <b>IsTruncated</b> 
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
        /// are more traffic policy instances associated with the specified traffic policy.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy instance that is associated with the specified traffic policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MaxItems</b> 
        /// </para>
        ///  
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>HostedZoneIdMarker</b>, <b>TrafficPolicyInstanceNameMarker</b>, and <b>TrafficPolicyInstanceTypeMarker</b>
        /// 
        /// </para>
        ///  
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
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyInstancesByPolicy">REST API Reference for ListTrafficPolicyInstancesByPolicy Operation</seealso>
        ListTrafficPolicyInstancesByPolicyResponse ListTrafficPolicyInstancesByPolicy(ListTrafficPolicyInstancesByPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyInstancesByPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyInstancesByPolicy">REST API Reference for ListTrafficPolicyInstancesByPolicy Operation</seealso>
        Task<ListTrafficPolicyInstancesByPolicyResponse> ListTrafficPolicyInstancesByPolicyAsync(ListTrafficPolicyInstancesByPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTrafficPolicyVersions


        /// <summary>
        /// Gets information about all of the versions for a specified traffic policy.
        /// 
        ///  
        /// <para>
        /// Send a <code>GET</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicy</code>
        /// resource and specify the ID of the traffic policy for which you want to list versions.
        /// </para>
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
        ///  <ul> <li> 
        /// <para>
        ///  <b>IsTruncated</b> 
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
        /// are more traffic policy versions associated with the specified traffic policy.
        /// </para>
        ///  
        /// <para>
        /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
        /// traffic policy version that is associated with the specified traffic policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TrafficPolicyVersionMarker</b> 
        /// </para>
        ///  
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
        ///  </li> <li> 
        /// <para>
        ///  <b>MaxItems</b> 
        /// </para>
        ///  
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the request
        /// that produced the current response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyVersions service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicyVersions service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyVersions">REST API Reference for ListTrafficPolicyVersions Operation</seealso>
        ListTrafficPolicyVersionsResponse ListTrafficPolicyVersions(ListTrafficPolicyVersionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyVersions">REST API Reference for ListTrafficPolicyVersions Operation</seealso>
        Task<ListTrafficPolicyVersionsResponse> ListTrafficPolicyVersionsAsync(ListTrafficPolicyVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVPCAssociationAuthorizations


        /// <summary>
        /// Gets a list of the VPCs that were created by other accounts and that can be associated
        /// with a specified hosted zone because you've submitted one or more <code>CreateVPCAssociationAuthorization</code>
        /// requests. 
        /// 
        ///  
        /// <para>
        /// Send a <code>GET</code> request to the <code>/2013-04-01/hostedzone/<i>hosted zone
        /// ID</i>/authorizevpcassociation</code> resource. The response to this request includes
        /// a <code>VPCs</code> element with a <code>VPC</code> child element for each VPC that
        /// can be associated with the hosted zone.
        /// </para>
        ///  
        /// <para>
        /// Amazon Route 53 returns up to 50 VPCs per page. To return fewer VPCs per page, include
        /// the <code>MaxResults</code> parameter: 
        /// </para>
        ///  
        /// <para>
        ///  <code>/2013-04-01/hostedzone/<i>hosted zone ID</i>/authorizevpcassociation?MaxItems=<i>VPCs
        /// per page</i> </code> 
        /// </para>
        ///  
        /// <para>
        /// If the response includes a <code>NextToken</code> element, there are more VPCs to
        /// list. To get the next page of VPCs, submit another <code>ListVPCAssociationAuthorizations</code>
        /// request, and include the value of the <code>NextToken</code> element from the response
        /// in the <code>NextToken</code> request parameter:
        /// </para>
        ///  
        /// <para>
        ///  <code>/2013-04-01/hostedzone/<i>hosted zone ID</i>/authorizevpcassociation?MaxItems=<i>VPCs
        /// per page</i>&amp;NextToken=<i/> </code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVPCAssociationAuthorizations service method.</param>
        /// 
        /// <returns>The response from the ListVPCAssociationAuthorizations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidPaginationTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListVPCAssociationAuthorizations">REST API Reference for ListVPCAssociationAuthorizations Operation</seealso>
        ListVPCAssociationAuthorizationsResponse ListVPCAssociationAuthorizations(ListVPCAssociationAuthorizationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListVPCAssociationAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVPCAssociationAuthorizations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListVPCAssociationAuthorizations">REST API Reference for ListVPCAssociationAuthorizations Operation</seealso>
        Task<ListVPCAssociationAuthorizationsResponse> ListVPCAssociationAuthorizationsAsync(ListVPCAssociationAuthorizationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestDNSAnswer


        /// <summary>
        /// Gets the value that Amazon Route 53 returns in response to a DNS request for a specified
        /// record name and type. You can optionally specify the IP address of a DNS resolver,
        /// an EDNS0 client subnet IP address, and a subnet mask.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestDNSAnswer service method.</param>
        /// 
        /// <returns>The response from the TestDNSAnswer service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/TestDNSAnswer">REST API Reference for TestDNSAnswer Operation</seealso>
        TestDNSAnswerResponse TestDNSAnswer(TestDNSAnswerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TestDNSAnswer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestDNSAnswer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/TestDNSAnswer">REST API Reference for TestDNSAnswer Operation</seealso>
        Task<TestDNSAnswerResponse> TestDNSAnswerAsync(TestDNSAnswerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateHealthCheck


        /// <summary>
        /// Updates an existing health check.
        /// 
        ///  
        /// <para>
        /// Send a <code>POST</code> request to the <code>/2013-04-01/healthcheck/<i>health check
        /// ID</i> </code> resource. The request body must include a document with an <code>UpdateHealthCheckRequest</code>
        /// element. For more information about updating health checks, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/health-checks-creating-deleting.html">Creating,
        /// Updating, and Deleting Health Checks</a> in the Amazon Route 53 Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the UpdateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckVersionMismatchException">
        /// The value of <code>HealthCheckVersion</code> in the request doesn't match the value
        /// of <code>HealthCheckVersion</code> in the health check.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the ID that you specified in the <code>DeleteHealthCheck</code>
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateHealthCheck">REST API Reference for UpdateHealthCheck Operation</seealso>
        UpdateHealthCheckResponse UpdateHealthCheck(UpdateHealthCheckRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateHealthCheck">REST API Reference for UpdateHealthCheck Operation</seealso>
        Task<UpdateHealthCheckResponse> UpdateHealthCheckAsync(UpdateHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateHostedZoneComment


        /// <summary>
        /// Updates the hosted zone comment. Send a <code>POST</code> request to the <code>/2013-04-01/hostedzone/<i>hosted
        /// zone ID</i> </code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneComment service method.</param>
        /// 
        /// <returns>The response from the UpdateHostedZoneComment service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateHostedZoneComment">REST API Reference for UpdateHostedZoneComment Operation</seealso>
        UpdateHostedZoneCommentResponse UpdateHostedZoneComment(UpdateHostedZoneCommentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHostedZoneComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateHostedZoneComment">REST API Reference for UpdateHostedZoneComment Operation</seealso>
        Task<UpdateHostedZoneCommentResponse> UpdateHostedZoneCommentAsync(UpdateHostedZoneCommentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTrafficPolicyComment


        /// <summary>
        /// Updates the comment for a specified traffic policy version.
        /// 
        ///  
        /// <para>
        /// Send a <code>POST</code> request to the <code>/2013-04-01/trafficpolicy/</code> resource.
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
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateTrafficPolicyComment">REST API Reference for UpdateTrafficPolicyComment Operation</seealso>
        UpdateTrafficPolicyCommentResponse UpdateTrafficPolicyComment(UpdateTrafficPolicyCommentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrafficPolicyComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateTrafficPolicyComment">REST API Reference for UpdateTrafficPolicyComment Operation</seealso>
        Task<UpdateTrafficPolicyCommentResponse> UpdateTrafficPolicyCommentAsync(UpdateTrafficPolicyCommentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTrafficPolicyInstance


        /// <summary>
        /// Updates the resource record sets in a specified hosted zone that were created based
        /// on the settings in a specified traffic policy version.
        /// 
        ///  
        /// <para>
        /// Send a <code>POST</code> request to the <code>/2013-04-01/trafficpolicyinstance/<i>traffic
        /// policy ID</i> </code> resource. The request body must include a document with an <code>UpdateTrafficPolicyInstanceRequest</code>
        /// element.
        /// </para>
        ///  
        /// <para>
        /// When you update a traffic policy instance, Amazon Route 53 continues to respond to
        /// DNS queries for the root resource record set name (such as example.com) while it replaces
        /// one group of resource record sets with another. Amazon Route 53 performs the following
        /// operations:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Amazon Route 53 creates a new group of resource record sets based on the specified
        /// traffic policy. This is true regardless of how substantial the differences are between
        /// the existing resource record sets and the new resource record sets. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When all of the new resource record sets have been created, Amazon Route 53 starts
        /// to respond to DNS queries for the root resource record set name (such as example.com)
        /// by using the new resource record sets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Route 53 deletes the old group of resource record sets that are associated
        /// with the root resource record set name.
        /// </para>
        ///  </li> </ol>
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
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// If Amazon Route 53 can't process a request before the next request arrives, it will
        /// reject subsequent requests for the same hosted zone and return an <code>HTTP 400 error</code>
        /// (<code>Bad request</code>). If Amazon Route 53 returns this error repeatedly for the
        /// same request, we recommend that you wait, in intervals of increasing duration, before
        /// you try the request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateTrafficPolicyInstance">REST API Reference for UpdateTrafficPolicyInstance Operation</seealso>
        UpdateTrafficPolicyInstanceResponse UpdateTrafficPolicyInstance(UpdateTrafficPolicyInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrafficPolicyInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateTrafficPolicyInstance">REST API Reference for UpdateTrafficPolicyInstance Operation</seealso>
        Task<UpdateTrafficPolicyInstanceResponse> UpdateTrafficPolicyInstanceAsync(UpdateTrafficPolicyInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}