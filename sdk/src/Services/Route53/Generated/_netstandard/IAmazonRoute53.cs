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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Route53.Model;

#pragma warning disable CS1570
namespace Amazon.Route53
{
    /// <summary>
    /// <para>Interface for accessing Route53</para>
    ///
    /// Amazon Route 53 is a highly available and scalable Domain Name System (DNS) web service.
    /// 
    ///  
    /// <para>
    /// You can use Route 53 to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Register domain names.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/welcome-domain-registration.html">How
    /// domain registration works</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Route internet traffic to the resources for your domain
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/welcome-dns-service.html">How
    /// internet traffic is routed to your website or web application</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Check the health of your resources.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/welcome-health-checks.html">How
    /// Route 53 checks the health of your resources</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonRoute53 : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRoute53PaginatorFactory Paginators { get; }
#endif
                
        #region  ActivateKeySigningKey



        /// <summary>
        /// Activates a key-signing key (KSK) so that it can be used for signing by DNSSEC. This
        /// operation changes the KSK status to <c>ACTIVE</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateKeySigningKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateKeySigningKey service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidKeySigningKeyStatusException">
        /// The key-signing key (KSK) status isn't valid or another KSK has the status <c>INTERNAL_FAILURE</c>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidKMSArnException">
        /// The KeyManagementServiceArn that you specified isn't valid to use with DNSSEC signing.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidSigningStatusException">
        /// Your hosted zone status isn't valid for this operation. In the hosted zone, change
        /// the status to enable <c>DNSSEC</c> or disable <c>DNSSEC</c>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchKeySigningKeyException">
        /// The specified key-signing key (KSK) doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ActivateKeySigningKey">REST API Reference for ActivateKeySigningKey Operation</seealso>
        Task<ActivateKeySigningKeyResponse> ActivateKeySigningKeyAsync(ActivateKeySigningKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateVPCWithHostedZone



        /// <summary>
        /// Associates an Amazon VPC with a private hosted zone. 
        /// 
        ///  <important> 
        /// <para>
        /// To perform the association, the VPC and the private hosted zone must already exist.
        /// You can't convert a public hosted zone into a private hosted zone.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// If you want to associate a VPC that was created by using one Amazon Web Services account
        /// with a private hosted zone that was created by using a different account, the Amazon
        /// Web Services account that created the private hosted zone must first submit a <c>CreateVPCAssociationAuthorization</c>
        /// request. Then the account that created the VPC must submit an <c>AssociateVPCWithHostedZone</c>
        /// request.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// When granting access, the hosted zone and the Amazon VPC must belong to the same partition.
        /// A partition is a group of Amazon Web Services Regions. Each Amazon Web Services account
        /// is scoped to one partition.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported partitions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aws</c> - Amazon Web Services Regions
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-cn</c> - China Regions
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-us-gov</c> - Amazon Web Services GovCloud (US) Region
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Access
        /// Management</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateVPCWithHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingDomainExistsException">
        /// The cause of this error depends on the operation that you're performing:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Create a public hosted zone:</b> Two hosted zones that have the same name or that
        /// have a parent/child relationship (example.com and test.example.com) can't have any
        /// common name servers. You tried to create a hosted zone that has the same name as an
        /// existing hosted zone or that's the parent or child of an existing hosted zone, and
        /// you specified a delegation set that shares one or more name servers with the existing
        /// hosted zone. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_CreateReusableDelegationSet.html">CreateReusableDelegationSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Create a private hosted zone:</b> A hosted zone with the specified name already
        /// exists and is already associated with the Amazon VPC that you specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Associate VPCs with a private hosted zone:</b> The VPC that you specified is already
        /// associated with another hosted zone that has the same name.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The VPC ID that you specified either isn't a valid ID or the current account is not
        /// authorized to access this VPC.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LimitsExceededException">
        /// This operation can't be completed because the current account has reached the limit
        /// on the resource you are trying to create. To request a higher limit, <a href="http://aws.amazon.com/route53-request">create
        /// a case</a> with the Amazon Web Services Support Center.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NotAuthorizedException">
        /// Associating the specified VPC with the specified hosted zone has not been authorized.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// If Amazon Route 53 can't process a request before the next request arrives, it will
        /// reject subsequent requests for the same hosted zone and return an <c>HTTP 400 error</c>
        /// (<c>Bad request</c>). If Route 53 returns this error repeatedly for the same request,
        /// we recommend that you wait, in intervals of increasing duration, before you try the
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PublicZoneVPCAssociationException">
        /// You're trying to associate a VPC with a public hosted zone. Amazon Route 53 doesn't
        /// support associating a VPC with a public hosted zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/AssociateVPCWithHostedZone">REST API Reference for AssociateVPCWithHostedZone Operation</seealso>
        Task<AssociateVPCWithHostedZoneResponse> AssociateVPCWithHostedZoneAsync(AssociateVPCWithHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ChangeCidrCollection



        /// <summary>
        /// Creates, changes, or deletes CIDR blocks within a collection. Contains authoritative
        /// IP information mapping blocks to one or multiple locations.
        /// 
        ///  
        /// <para>
        /// A change request can update multiple locations in a collection at a time, which is
        /// helpful if you want to move one or more CIDR blocks from one location to another in
        /// one transaction, without downtime. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Limits</b> 
        /// </para>
        ///  
        /// <para>
        /// The max number of CIDR blocks included in the request is 1000. As a result, big updates
        /// require multiple API calls.
        /// </para>
        ///  
        /// <para>
        ///  <b> PUT and DELETE_IF_EXISTS</b> 
        /// </para>
        ///  
        /// <para>
        /// Use <c>ChangeCidrCollection</c> to perform the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PUT</c>: Create a CIDR block within the specified collection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> DELETE_IF_EXISTS</c>: Delete an existing CIDR block from the collection.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeCidrCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChangeCidrCollection service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.CidrBlockInUseException">
        /// This CIDR block is already in use.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.CidrCollectionVersionMismatchException">
        /// The CIDR collection version you provided, doesn't match the one in the <c>ListCidrCollections</c>
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LimitsExceededException">
        /// This operation can't be completed because the current account has reached the limit
        /// on the resource you are trying to create. To request a higher limit, <a href="http://aws.amazon.com/route53-request">create
        /// a case</a> with the Amazon Web Services Support Center.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchCidrCollectionException">
        /// The CIDR collection you specified, doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ChangeCidrCollection">REST API Reference for ChangeCidrCollection Operation</seealso>
        Task<ChangeCidrCollectionResponse> ChangeCidrCollectionAsync(ChangeCidrCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ChangeResourceRecordSets



        /// <summary>
        /// Creates, changes, or deletes a resource record set, which contains authoritative DNS
        /// information for a specified domain name or subdomain name. For example, you can use
        /// <c>ChangeResourceRecordSets</c> to create a resource record set that routes traffic
        /// for test.example.com to a web server that has an IP address of 192.0.2.44.
        /// 
        ///  
        /// <para>
        ///  <b>Deleting Resource Record Sets</b> 
        /// </para>
        ///  
        /// <para>
        /// To delete a resource record set, you must specify all the same values that you specified
        /// when you created it.
        /// </para>
        ///  
        /// <para>
        ///  <b>Change Batches and Transactional Changes</b> 
        /// </para>
        ///  
        /// <para>
        /// The request body must include a document with a <c>ChangeResourceRecordSetsRequest</c>
        /// element. The request body contains a list of change items, known as a change batch.
        /// Change batches are considered transactional changes. Route 53 validates the changes
        /// in the request and then either makes all or none of the changes in the change batch
        /// request. This ensures that DNS routing isn't adversely affected by partial changes
        /// to the resource record sets in a hosted zone. 
        /// </para>
        ///  
        /// <para>
        /// For example, suppose a change batch request contains two changes: it deletes the <c>CNAME</c>
        /// resource record set for www.example.com and creates an alias resource record set for
        /// www.example.com. If validation for both records succeeds, Route 53 deletes the first
        /// resource record set and creates the second resource record set in a single operation.
        /// If validation for either the <c>DELETE</c> or the <c>CREATE</c> action fails, then
        /// the request is canceled, and the original <c>CNAME</c> record continues to exist.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you try to delete the same resource record set more than once in a single change
        /// batch, Route 53 returns an <c>InvalidChangeBatch</c> error.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Traffic Flow</b> 
        /// </para>
        ///  
        /// <para>
        /// To create resource record sets for complex routing configurations, use either the
        /// traffic flow visual editor in the Route 53 console or the API actions for traffic
        /// policies and traffic policy instances. Save the configuration as a traffic policy,
        /// then associate the traffic policy with one or more domain names (such as example.com)
        /// or subdomain names (such as www.example.com), in the same hosted zone or in multiple
        /// hosted zones. You can roll back the updates if the new configuration isn't performing
        /// as expected. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/traffic-flow.html">Using
        /// Traffic Flow to Route DNS Traffic</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Create, Delete, and Upsert</b> 
        /// </para>
        ///  
        /// <para>
        /// Use <c>ChangeResourceRecordsSetsRequest</c> to perform the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE</c>: Creates a resource record set that has the specified values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE</c>: Deletes an existing resource record set that has the specified values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPSERT</c>: If a resource set doesn't exist, Route 53 creates it. If a resource
        /// set exists Route 53 updates it with the values in the request. 
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
        /// update by using <c>ChangeResourceRecordSets</c>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Change Propagation to Route 53 DNS Servers</b> 
        /// </para>
        ///  
        /// <para>
        /// When you submit a <c>ChangeResourceRecordSets</c> request, Route 53 propagates your
        /// changes to all of the Route 53 authoritative DNS servers managing the hosted zone.
        /// While your changes are propagating, <c>GetChange</c> returns a status of <c>PENDING</c>.
        /// When propagation is complete, <c>GetChange</c> returns a status of <c>INSYNC</c>.
        /// Changes generally propagate to all Route 53 name servers managing the hosted zone
        /// within 60 seconds. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetChange.html">GetChange</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Limits on ChangeResourceRecordSets Requests</b> 
        /// </para>
        ///  
        /// <para>
        /// For information about the limits on a <c>ChangeResourceRecordSets</c> request, see
        /// <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html">Limits</a>
        /// in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeResourceRecordSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// No health check exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// If Amazon Route 53 can't process a request before the next request arrives, it will
        /// reject subsequent requests for the same hosted zone and return an <c>HTTP 400 error</c>
        /// (<c>Bad request</c>). If Route 53 returns this error repeatedly for the same request,
        /// we recommend that you wait, in intervals of increasing duration, before you try the
        /// request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ChangeResourceRecordSets">REST API Reference for ChangeResourceRecordSets Operation</seealso>
        Task<ChangeResourceRecordSetsResponse> ChangeResourceRecordSetsAsync(ChangeResourceRecordSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ChangeTagsForResource



        /// <summary>
        /// Adds, edits, or deletes tags for a health check or a hosted zone.
        /// 
        ///  
        /// <para>
        /// For information about using tags for cost allocation, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>Billing and Cost Management User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChangeTagsForResource service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// If Amazon Route 53 can't process a request before the next request arrives, it will
        /// reject subsequent requests for the same hosted zone and return an <c>HTTP 400 error</c>
        /// (<c>Bad request</c>). If Route 53 returns this error repeatedly for the same request,
        /// we recommend that you wait, in intervals of increasing duration, before you try the
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ChangeTagsForResource">REST API Reference for ChangeTagsForResource Operation</seealso>
        Task<ChangeTagsForResourceResponse> ChangeTagsForResourceAsync(ChangeTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCidrCollection



        /// <summary>
        /// Creates a CIDR collection in the current Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCidrCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCidrCollection service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.CidrCollectionAlreadyExistsException">
        /// A CIDR collection with this name and a different caller reference already exists in
        /// this account.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LimitsExceededException">
        /// This operation can't be completed because the current account has reached the limit
        /// on the resource you are trying to create. To request a higher limit, <a href="http://aws.amazon.com/route53-request">create
        /// a case</a> with the Amazon Web Services Support Center.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateCidrCollection">REST API Reference for CreateCidrCollection Operation</seealso>
        Task<CreateCidrCollectionResponse> CreateCidrCollectionAsync(CreateCidrCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHealthCheck



        /// <summary>
        /// Creates a new health check.
        /// 
        ///  
        /// <para>
        /// For information about adding health checks to resource record sets, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_ResourceRecordSet.html#Route53-Type-ResourceRecordSet-HealthCheckId">HealthCheckId</a>
        /// in <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_ChangeResourceRecordSets.html">ChangeResourceRecordSets</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>ELB Load Balancers</b> 
        /// </para>
        ///  
        /// <para>
        /// If you're registering EC2 instances with an Elastic Load Balancing (ELB) load balancer,
        /// do not create Amazon Route 53 health checks for the EC2 instances. When you register
        /// an EC2 instance with a load balancer, you configure settings for an ELB health check,
        /// which performs a similar function to a Route 53 health check.
        /// </para>
        ///  
        /// <para>
        ///  <b>Private Hosted Zones</b> 
        /// </para>
        ///  
        /// <para>
        /// You can associate health checks with failover resource record sets in a private hosted
        /// zone. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Route 53 health checkers are outside the VPC. To check the health of an endpoint within
        /// a VPC by IP address, you must assign a public IP address to the instance in the VPC.
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
        /// a CloudWatch metric that checks the status of the Amazon EC2 <c>StatusCheckFailed</c>
        /// metric, add an alarm to the metric, and then create a health check that is based on
        /// the state of the alarm. For information about creating CloudWatch metrics and alarms
        /// by using the CloudWatch console, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/WhatIsCloudWatch.html">Amazon
        /// CloudWatch User Guide</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckAlreadyExistsException">
        /// The health check you're attempting to create already exists. Amazon Route 53 returns
        /// this error when you submit a request that has the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The same value for <c>CallerReference</c> as an existing health check, and one or
        /// more values that differ from the existing health check that has the same caller reference.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The same value for <c>CallerReference</c> as a health check that you created and later
        /// deleted, regardless of the other settings in the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyHealthChecksException">
        /// This health check can't be created because the current account has reached the limit
        /// on the number of active health checks.
        /// 
        ///  
        /// <para>
        /// For information about default limits, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html">Limits</a>
        /// in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about how to get the current limit for an account, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetAccountLimit.html">GetAccountLimit</a>.
        /// To request a higher limit, <a href="http://aws.amazon.com/route53-request">create
        /// a case</a> with the Amazon Web Services Support Center.
        /// </para>
        ///  
        /// <para>
        /// You have reached the maximum number of active health checks for an Amazon Web Services
        /// account. To request a higher limit, <a href="http://aws.amazon.com/route53-request">create
        /// a case</a> with the Amazon Web Services Support Center.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateHealthCheck">REST API Reference for CreateHealthCheck Operation</seealso>
        Task<CreateHealthCheckResponse> CreateHealthCheckAsync(CreateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateHostedZone



        /// <summary>
        /// Creates a new public or private hosted zone. You create records in a public hosted
        /// zone to define how you want to route traffic on the internet for a domain, such as
        /// example.com, and its subdomains (apex.example.com, acme.example.com). You create records
        /// in a private hosted zone to define how you want to route traffic for a domain and
        /// its subdomains within one or more Amazon Virtual Private Clouds (Amazon VPCs). 
        /// 
        ///  <important> 
        /// <para>
        /// You can't convert a public hosted zone to a private hosted zone or vice versa. Instead,
        /// you must create a new hosted zone with the same name and create new resource record
        /// sets.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about charges for hosted zones, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
        /// Route 53 Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can't create a hosted zone for a top-level domain (TLD) such as .com.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For public hosted zones, Route 53 automatically creates a default SOA record and four
        /// NS records for the zone. For more information about SOA and NS records, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/SOA-NSrecords.html">NS
        /// and SOA Records that Route 53 Creates for a Hosted Zone</a> in the <i>Amazon Route
        /// 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you want to use the same name servers for multiple public hosted zones, you can
        /// optionally associate a reusable delegation set with the hosted zone. See the <c>DelegationSetId</c>
        /// element.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your domain is registered with a registrar other than Route 53, you must update
        /// the name servers with your registrar to make Route 53 the DNS service for the domain.
        /// For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/MigratingDNS.html">Migrating
        /// DNS Service for an Existing Domain to Amazon Route 53</a> in the <i>Amazon Route 53
        /// Developer Guide</i>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you submit a <c>CreateHostedZone</c> request, the initial status of the hosted
        /// zone is <c>PENDING</c>. For public hosted zones, this means that the NS and SOA records
        /// are not yet available on all Route 53 DNS servers. When the NS and SOA records are
        /// available, the status of the zone changes to <c>INSYNC</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>CreateHostedZone</c> request requires the caller to have an <c>ec2:DescribeVpcs</c>
        /// permission.
        /// </para>
        ///  <note> 
        /// <para>
        /// When creating private hosted zones, the Amazon VPC must belong to the same partition
        /// where the hosted zone is created. A partition is a group of Amazon Web Services Regions.
        /// Each Amazon Web Services account is scoped to one partition.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported partitions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aws</c> - Amazon Web Services Regions
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-cn</c> - China Regions
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-us-gov</c> - Amazon Web Services GovCloud (US) Region
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Access
        /// Management</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHostedZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingDomainExistsException">
        /// The cause of this error depends on the operation that you're performing:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Create a public hosted zone:</b> Two hosted zones that have the same name or that
        /// have a parent/child relationship (example.com and test.example.com) can't have any
        /// common name servers. You tried to create a hosted zone that has the same name as an
        /// existing hosted zone or that's the parent or child of an existing hosted zone, and
        /// you specified a delegation set that shares one or more name servers with the existing
        /// hosted zone. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_CreateReusableDelegationSet.html">CreateReusableDelegationSet</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Create a private hosted zone:</b> A hosted zone with the specified name already
        /// exists and is already associated with the Amazon VPC that you specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Associate VPCs with a private hosted zone:</b> The VPC that you specified is already
        /// associated with another hosted zone that has the same name.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotAvailableException">
        /// You can create a hosted zone that has the same name as an existing hosted zone (example.com
        /// is common), but there is a limit to the number of hosted zones that have the same
        /// name. If you get this error, Amazon Route 53 has reached that limit. If you own the
        /// domain name and Route 53 generates this error, contact Customer Support.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZoneAlreadyExistsException">
        /// The hosted zone you're trying to create already exists. Amazon Route 53 returns this
        /// error when a hosted zone has already been created with the specified <c>CallerReference</c>.
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
        /// This operation can't be completed either because the current account has reached the
        /// limit on the number of hosted zones or because you've reached the limit on the number
        /// of hosted zones that can be associated with a reusable delegation set.
        /// 
        ///  
        /// <para>
        /// For information about default limits, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html">Limits</a>
        /// in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To get the current limit on hosted zones that can be created by an account, see <a
        /// href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetAccountLimit.html">GetAccountLimit</a>.
        /// </para>
        ///  
        /// <para>
        /// To get the current limit on hosted zones that can be associated with a reusable delegation
        /// set, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetReusableDelegationSetLimit.html">GetReusableDelegationSetLimit</a>.
        /// </para>
        ///  
        /// <para>
        /// To request a higher limit, <a href="http://aws.amazon.com/route53-request">create
        /// a case</a> with the Amazon Web Services Support Center.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateHostedZone">REST API Reference for CreateHostedZone Operation</seealso>
        Task<CreateHostedZoneResponse> CreateHostedZoneAsync(CreateHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateKeySigningKey



        /// <summary>
        /// Creates a new key-signing key (KSK) associated with a hosted zone. You can only have
        /// two KSKs per hosted zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeySigningKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKeySigningKey service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidArgumentException">
        /// Parameter name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidKeySigningKeyNameException">
        /// The key-signing key (KSK) name that you specified isn't a valid name.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidKeySigningKeyStatusException">
        /// The key-signing key (KSK) status isn't valid or another KSK has the status <c>INTERNAL_FAILURE</c>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidKMSArnException">
        /// The KeyManagementServiceArn that you specified isn't valid to use with DNSSEC signing.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidSigningStatusException">
        /// Your hosted zone status isn't valid for this operation. In the hosted zone, change
        /// the status to enable <c>DNSSEC</c> or disable <c>DNSSEC</c>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.KeySigningKeyAlreadyExistsException">
        /// You've already created a key-signing key (KSK) with this name or with the same customer
        /// managed key ARN.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyKeySigningKeysException">
        /// You've reached the limit for the number of key-signing keys (KSKs). Remove at least
        /// one KSK, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateKeySigningKey">REST API Reference for CreateKeySigningKey Operation</seealso>
        Task<CreateKeySigningKeyResponse> CreateKeySigningKeyAsync(CreateKeySigningKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateQueryLoggingConfig



        /// <summary>
        /// Creates a configuration for DNS query logging. After you create a query logging configuration,
        /// Amazon Route 53 begins to publish log data to an Amazon CloudWatch Logs log group.
        /// 
        ///  
        /// <para>
        /// DNS query logs contain information about the queries that Route 53 receives for a
        /// specified public hosted zone, such as the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Route 53 edge location that responded to the DNS query
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain or subdomain that was requested
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DNS record type, such as A or AAAA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DNS response code, such as <c>NoError</c> or <c>ServFail</c> 
        /// </para>
        ///  </li> </ul> <dl> <dt>Log Group and Resource Policy</dt> <dd> 
        /// <para>
        /// Before you create a query logging configuration, perform the following operations.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you create a query logging configuration using the Route 53 console, Route 53 performs
        /// these operations automatically.
        /// </para>
        ///  </note> <ol> <li> 
        /// <para>
        /// Create a CloudWatch Logs log group, and make note of the ARN, which you specify when
        /// you create a query logging configuration. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must create the log group in the us-east-1 region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must use the same Amazon Web Services account to create the log group and the
        /// hosted zone that you want to configure query logging for.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you create log groups for query logging, we recommend that you use a consistent
        /// prefix, for example:
        /// </para>
        ///  
        /// <para>
        ///  <c>/aws/route53/<i>hosted zone name</i> </c> 
        /// </para>
        ///  
        /// <para>
        /// In the next step, you'll create a resource policy, which controls access to one or
        /// more log groups and the associated Amazon Web Services resources, such as Route 53
        /// hosted zones. There's a limit on the number of resource policies that you can create,
        /// so we recommend that you use a consistent prefix so you can use the same resource
        /// policy for all the log groups that you create for query logging.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Create a CloudWatch Logs resource policy, and give it the permissions that Route 53
        /// needs to create log streams and to send query logs to log streams. You must create
        /// the CloudWatch Logs resource policy in the us-east-1 region. For the value of <c>Resource</c>,
        /// specify the ARN for the log group that you created in the previous step. To use the
        /// same resource policy for all the CloudWatch Logs log groups that you created for query
        /// logging configurations, replace the hosted zone name with <c>*</c>, for example:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:logs:us-east-1:123412341234:log-group:/aws/route53/*</c> 
        /// </para>
        ///  
        /// <para>
        /// To avoid the confused deputy problem, a security issue where an entity without a permission
        /// for an action can coerce a more-privileged entity to perform it, you can optionally
        /// limit the permissions that a service has to a resource in a resource-based policy
        /// by supplying the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>aws:SourceArn</c>, supply the hosted zone ARN used in creating the query logging
        /// configuration. For example, <c>aws:SourceArn: arn:aws:route53:::hostedzone/hosted
        /// zone ID</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>aws:SourceAccount</c>, supply the account ID for the account that creates the
        /// query logging configuration. For example, <c>aws:SourceAccount:111111111111</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/confused-deputy.html">The
        /// confused deputy problem</a> in the <i>Amazon Web Services IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't use the CloudWatch console to create or edit a resource policy. You must
        /// use the CloudWatch API, one of the Amazon Web Services SDKs, or the CLI.
        /// </para>
        ///  </note> </li> </ol> </dd> <dt>Log Streams and Edge Locations</dt> <dd> 
        /// <para>
        /// When Route 53 finishes creating the configuration for DNS query logging, it does the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a log stream for an edge location the first time that the edge location responds
        /// to DNS queries for the specified hosted zone. That log stream is used to log all queries
        /// that Route 53 responds to for that edge location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Begins to send query logs to the applicable log stream.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The name of each log stream is in the following format:
        /// </para>
        ///  
        /// <para>
        ///  <c> <i>hosted zone ID</i>/<i>edge location code</i> </c> 
        /// </para>
        ///  
        /// <para>
        /// The edge location code is a three-letter code and an arbitrarily assigned number,
        /// for example, DFW3. The three-letter code typically corresponds with the International
        /// Air Transport Association airport code for an airport near the edge location. (These
        /// abbreviations might change in the future.) For a list of edge locations, see "The
        /// Route 53 Global Network" on the <a href="http://aws.amazon.com/route53/details/">Route
        /// 53 Product Details</a> page.
        /// </para>
        ///  </dd> <dt>Queries That Are Logged</dt> <dd> 
        /// <para>
        /// Query logs contain only the queries that DNS resolvers forward to Route 53. If a DNS
        /// resolver has already cached the response to a query (such as the IP address for a
        /// load balancer for example.com), the resolver will continue to return the cached response.
        /// It doesn't forward another query to Route 53 until the TTL for the corresponding resource
        /// record set expires. Depending on how many DNS queries are submitted for a resource
        /// record set, and depending on the TTL for that resource record set, query logs might
        /// contain information about only one query out of every several thousand queries that
        /// are submitted to DNS. For more information about how DNS works, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/welcome-dns-service.html">Routing
        /// Internet Traffic to Your Website or Web Application</a> in the <i>Amazon Route 53
        /// Developer Guide</i>.
        /// </para>
        ///  </dd> <dt>Log File Format</dt> <dd> 
        /// <para>
        /// For a list of the values in each query log and the format of each value, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/query-logs.html">Logging
        /// DNS Queries</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  </dd> <dt>Pricing</dt> <dd> 
        /// <para>
        /// For information about charges for query logs, see <a href="http://aws.amazon.com/cloudwatch/pricing/">Amazon
        /// CloudWatch Pricing</a>.
        /// </para>
        ///  </dd> <dt>How to Stop Logging</dt> <dd> 
        /// <para>
        /// If you want Route 53 to stop sending query logs to CloudWatch Logs, delete the query
        /// logging configuration. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_DeleteQueryLoggingConfig.html">DeleteQueryLoggingConfig</a>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueryLoggingConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueryLoggingConfig service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InsufficientCloudWatchLogsResourcePolicyException">
        /// Amazon Route 53 doesn't have the permissions required to create log streams and send
        /// query logs to log streams. Possible causes include the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// There is no resource policy that specifies the log group ARN in the value for <c>Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The resource policy that includes the log group ARN in the value for <c>Resource</c>
        /// doesn't have the necessary permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The resource policy hasn't finished propagating yet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Key management service (KMS) key you specified doesn’t exist or it can’t be used
        /// with the log group associated with query log. Update or provide a resource policy
        /// to grant permissions for the KMS key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Key management service (KMS) key you specified is marked as disabled for the log
        /// group associated with query log. Update or provide a resource policy to grant permissions
        /// for the KMS key.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchCloudWatchLogsLogGroupException">
        /// There is no CloudWatch Logs log group with the specified ARN.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.QueryLoggingConfigAlreadyExistsException">
        /// You can create only one query logging configuration for a hosted zone, and a query
        /// logging configuration already exists for this hosted zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateQueryLoggingConfig">REST API Reference for CreateQueryLoggingConfig Operation</seealso>
        Task<CreateQueryLoggingConfigResponse> CreateQueryLoggingConfigAsync(CreateQueryLoggingConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateReusableDelegationSet



        /// <summary>
        /// Creates a delegation set (a group of four name servers) that can be reused by multiple
        /// hosted zones that were created by the same Amazon Web Services account. 
        /// 
        ///  
        /// <para>
        /// You can also create a reusable delegation set that uses the four name servers that
        /// are associated with an existing hosted zone. Specify the hosted zone ID in the <c>CreateReusableDelegationSet</c>
        /// request.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't associate a reusable delegation set with a private hosted zone.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information about using a reusable delegation set to configure white label name
        /// servers, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/white-label-name-servers.html">Configuring
        /// White Label Name Servers</a>.
        /// </para>
        ///  
        /// <para>
        /// The process for migrating existing hosted zones to use a reusable delegation set is
        /// comparable to the process for configuring white label name servers. You need to perform
        /// the following steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a reusable delegation set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Recreate hosted zones, and reduce the TTL to 60 seconds or less.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Recreate resource record sets in the new hosted zones.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change the registrar's name servers to use the name servers for the new hosted zones.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Monitor traffic for the website or application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change TTLs back to their original values.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you want to migrate existing hosted zones to use a reusable delegation set, the
        /// existing hosted zones can't use any of the name servers that are assigned to the reusable
        /// delegation set. If one or more hosted zones do use one or more name servers that are
        /// assigned to the reusable delegation set, you can do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For small numbers of hosted zones—up to a few hundred—it's relatively easy to create
        /// reusable delegation sets until you get one that has four name servers that don't overlap
        /// with any of the name servers in your hosted zones.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For larger numbers of hosted zones, the easiest solution is to use more than one reusable
        /// delegation set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For larger numbers of hosted zones, you can also migrate hosted zones that have overlapping
        /// name servers to hosted zones that don't have overlapping name servers, then migrate
        /// the hosted zones again to use the reusable delegation set.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReusableDelegationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// domain name and Route 53 generates this error, contact Customer Support.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZoneNotFoundException">
        /// The specified HostedZone can't be found.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidArgumentException">
        /// Parameter name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LimitsExceededException">
        /// This operation can't be completed because the current account has reached the limit
        /// on the resource you are trying to create. To request a higher limit, <a href="http://aws.amazon.com/route53-request">create
        /// a case</a> with the Amazon Web Services Support Center.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateReusableDelegationSet">REST API Reference for CreateReusableDelegationSet Operation</seealso>
        Task<CreateReusableDelegationSetResponse> CreateReusableDelegationSetAsync(CreateReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrafficPolicy



        /// <summary>
        /// Creates a traffic policy, which you use to create multiple DNS resource record sets
        /// for one domain name (such as example.com) or one subdomain name (such as www.example.com).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrafficPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidTrafficPolicyDocumentException">
        /// The format of the traffic policy document that you specified in the <c>Document</c>
        /// element is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyTrafficPoliciesException">
        /// This traffic policy can't be created because the current account has reached the limit
        /// on the number of traffic policies.
        /// 
        ///  
        /// <para>
        /// For information about default limits, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html">Limits</a>
        /// in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To get the current limit for an account, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetAccountLimit.html">GetAccountLimit</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To request a higher limit, <a href="http://aws.amazon.com/route53-request">create
        /// a case</a> with the Amazon Web Services Support Center.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TrafficPolicyAlreadyExistsException">
        /// A traffic policy that has the same value for <c>Name</c> already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateTrafficPolicy">REST API Reference for CreateTrafficPolicy Operation</seealso>
        Task<CreateTrafficPolicyResponse> CreateTrafficPolicyAsync(CreateTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrafficPolicyInstance



        /// <summary>
        /// Creates resource record sets in a specified hosted zone based on the settings in a
        /// specified traffic policy version. In addition, <c>CreateTrafficPolicyInstance</c>
        /// associates the resource record sets with a specified domain name (such as example.com)
        /// or subdomain name (such as www.example.com). Amazon Route 53 responds to DNS queries
        /// for the domain or subdomain name by using the resource record sets that <c>CreateTrafficPolicyInstance</c>
        /// created.
        /// 
        ///  <note> 
        /// <para>
        /// After you submit an <c>CreateTrafficPolicyInstance</c> request, there's a brief delay
        /// while Amazon Route 53 creates the resource record sets that are specified in the traffic
        /// policy definition. Use <c>GetTrafficPolicyInstance</c> with the <c>id</c> of new traffic
        /// policy instance to confirm that the <c>CreateTrafficPolicyInstance</c> request completed
        /// successfully. For more information, see the <c>State</c> response element.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// This traffic policy instance can't be created because the current account has reached
        /// the limit on the number of traffic policy instances.
        /// 
        ///  
        /// <para>
        /// For information about default limits, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html">Limits</a>
        /// in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about how to get the current limit for an account, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetAccountLimit.html">GetAccountLimit</a>.
        /// </para>
        ///  
        /// <para>
        /// To request a higher limit, <a href="http://aws.amazon.com/route53-request">create
        /// a case</a> with the Amazon Web Services Support Center.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TrafficPolicyInstanceAlreadyExistsException">
        /// There is already a traffic policy instance with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateTrafficPolicyInstance">REST API Reference for CreateTrafficPolicyInstance Operation</seealso>
        Task<CreateTrafficPolicyInstanceResponse> CreateTrafficPolicyInstanceAsync(CreateTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicyVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrafficPolicyVersion service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidTrafficPolicyDocumentException">
        /// The format of the traffic policy document that you specified in the <c>Document</c>
        /// element is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyTrafficPolicyVersionsForCurrentPolicyException">
        /// This traffic policy version can't be created because you've reached the limit of 1000
        /// on the number of versions that you can create for the current traffic policy.
        /// 
        ///  
        /// <para>
        /// To create more traffic policy versions, you can use <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetTrafficPolicy.html">GetTrafficPolicy</a>
        /// to get the traffic policy document for a specified traffic policy version, and then
        /// use <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_CreateTrafficPolicy.html">CreateTrafficPolicy</a>
        /// to create a new traffic policy using the traffic policy document.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateTrafficPolicyVersion">REST API Reference for CreateTrafficPolicyVersion Operation</seealso>
        Task<CreateTrafficPolicyVersionResponse> CreateTrafficPolicyVersionAsync(CreateTrafficPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVPCAssociationAuthorization



        /// <summary>
        /// Authorizes the Amazon Web Services account that created a specified VPC to submit
        /// an <c>AssociateVPCWithHostedZone</c> request to associate the VPC with a specified
        /// hosted zone that was created by a different account. To submit a <c>CreateVPCAssociationAuthorization</c>
        /// request, you must use the account that created the hosted zone. After you authorize
        /// the association, use the account that created the VPC to submit an <c>AssociateVPCWithHostedZone</c>
        /// request.
        /// 
        ///  <note> 
        /// <para>
        /// If you want to associate multiple VPCs that you created by using one account with
        /// a hosted zone that you created by using a different account, you must submit one authorization
        /// request for each VPC.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVPCAssociationAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVPCAssociationAuthorization service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
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
        /// a <c>DeleteVPCAssociationAuthorization</c> request to remove an existing authorization.
        /// To get a list of existing authorizations, submit a <c>ListVPCAssociationAuthorizations</c>
        /// request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/CreateVPCAssociationAuthorization">REST API Reference for CreateVPCAssociationAuthorization Operation</seealso>
        Task<CreateVPCAssociationAuthorizationResponse> CreateVPCAssociationAuthorizationAsync(CreateVPCAssociationAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeactivateKeySigningKey



        /// <summary>
        /// Deactivates a key-signing key (KSK) so that it will not be used for signing by DNSSEC.
        /// This operation changes the KSK status to <c>INACTIVE</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateKeySigningKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateKeySigningKey service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidKeySigningKeyStatusException">
        /// The key-signing key (KSK) status isn't valid or another KSK has the status <c>INTERNAL_FAILURE</c>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidSigningStatusException">
        /// Your hosted zone status isn't valid for this operation. In the hosted zone, change
        /// the status to enable <c>DNSSEC</c> or disable <c>DNSSEC</c>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.KeySigningKeyInParentDSRecordException">
        /// The key-signing key (KSK) is specified in a parent DS record.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.KeySigningKeyInUseException">
        /// The key-signing key (KSK) that you specified can't be deactivated because it's the
        /// only KSK for a currently-enabled DNSSEC. Disable DNSSEC signing, or add or enable
        /// another KSK.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchKeySigningKeyException">
        /// The specified key-signing key (KSK) doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeactivateKeySigningKey">REST API Reference for DeactivateKeySigningKey Operation</seealso>
        Task<DeactivateKeySigningKeyResponse> DeactivateKeySigningKeyAsync(DeactivateKeySigningKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCidrCollection



        /// <summary>
        /// Deletes a CIDR collection in the current Amazon Web Services account. The collection
        /// must be empty before it can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCidrCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCidrCollection service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.CidrCollectionInUseException">
        /// This CIDR collection is in use, and isn't empty.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchCidrCollectionException">
        /// The CIDR collection you specified, doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteCidrCollection">REST API Reference for DeleteCidrCollection Operation</seealso>
        Task<DeleteCidrCollectionResponse> DeleteCidrCollectionAsync(DeleteCidrCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHealthCheck



        /// <summary>
        /// Deletes a health check.
        /// 
        ///  <important> 
        /// <para>
        /// Amazon Route 53 does not prevent you from deleting a health check even if the health
        /// check is associated with one or more resource record sets. If you delete a health
        /// check and you don't update the associated resource record sets, the future status
        /// of the health check can't be predicted and may change. This will affect the routing
        /// of DNS queries for your DNS failover configuration. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/health-checks-creating-deleting.html#health-checks-deleting.html">Replacing
        /// and Deleting Health Checks</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you're using Cloud Map and you configured Cloud Map to create a Route 53 health
        /// check when you register an instance, you can't use the Route 53 <c>DeleteHealthCheck</c>
        /// command to delete the health check. The health check is deleted automatically when
        /// you deregister the instance; there can be a delay of several hours before the health
        /// check is deleted from Route 53. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHealthCheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckInUseException">
        /// This error code is not in use.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteHealthCheck">REST API Reference for DeleteHealthCheck Operation</seealso>
        Task<DeleteHealthCheckResponse> DeleteHealthCheckAsync(DeleteHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHostedZone



        /// <summary>
        /// Deletes a hosted zone.
        /// 
        ///  
        /// <para>
        /// If the hosted zone was created by another service, such as Cloud Map, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DeleteHostedZone.html#delete-public-hosted-zone-created-by-another-service">Deleting
        /// Public Hosted Zones That Were Created by Another Service</a> in the <i>Amazon Route 53
        /// Developer Guide</i> for information about how to delete it. (The process is the same
        /// for public and private hosted zones that were created by another service.)
        /// </para>
        ///  
        /// <para>
        /// If you want to keep your domain registration but you want to stop routing internet
        /// traffic to your website or web application, we recommend that you delete resource
        /// record sets in the hosted zone instead of deleting the hosted zone.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you delete a hosted zone, you can't undelete it. You must create a new hosted zone
        /// and update the name servers for your domain registration, which can require up to
        /// 48 hours to take effect. (If you delegated responsibility for a subdomain to a hosted
        /// zone and you delete the child hosted zone, you must update the name servers in the
        /// parent hosted zone.) In addition, if you delete a hosted zone, someone could hijack
        /// the domain and route traffic to their own resources using your domain name.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you want to avoid the monthly charge for the hosted zone, you can transfer DNS
        /// service for the domain to a free DNS service. When you transfer DNS service, you have
        /// to update the name servers for the domain registration. If the domain is registered
        /// with Route 53, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_UpdateDomainNameservers.html">UpdateDomainNameservers</a>
        /// for information about how to replace Route 53 name servers with name servers for the
        /// new DNS service. If the domain is registered with another registrar, use the method
        /// provided by the registrar to update name servers for the domain registration. For
        /// more information, perform an internet search on "free DNS service."
        /// </para>
        ///  
        /// <para>
        /// You can delete a hosted zone only if it contains only the default SOA record and NS
        /// resource record sets. If the hosted zone contains other resource record sets, you
        /// must delete them before you can delete the hosted zone. If you try to delete a hosted
        /// zone that contains other resource record sets, the request fails, and Route 53 returns
        /// a <c>HostedZoneNotEmpty</c> error. For information about deleting records from your
        /// hosted zone, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_ChangeResourceRecordSets.html">ChangeResourceRecordSets</a>.
        /// </para>
        ///  
        /// <para>
        /// To verify that the hosted zone has been deleted, do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <c>GetHostedZone</c> action to request information about the hosted zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <c>ListHostedZones</c> action to get a list of the hosted zones associated
        /// with the current Amazon Web Services account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostedZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// reject subsequent requests for the same hosted zone and return an <c>HTTP 400 error</c>
        /// (<c>Bad request</c>). If Route 53 returns this error repeatedly for the same request,
        /// we recommend that you wait, in intervals of increasing duration, before you try the
        /// request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteHostedZone">REST API Reference for DeleteHostedZone Operation</seealso>
        Task<DeleteHostedZoneResponse> DeleteHostedZoneAsync(DeleteHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteKeySigningKey



        /// <summary>
        /// Deletes a key-signing key (KSK). Before you can delete a KSK, you must deactivate
        /// it. The KSK must be deactivated before you can delete it regardless of whether the
        /// hosted zone is enabled for DNSSEC signing.
        /// 
        ///  
        /// <para>
        /// You can use <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_DeactivateKeySigningKey.html">DeactivateKeySigningKey</a>
        /// to deactivate the key before you delete it.
        /// </para>
        ///  
        /// <para>
        /// Use <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetDNSSEC.html">GetDNSSEC</a>
        /// to verify that the KSK is in an <c>INACTIVE</c> status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeySigningKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKeySigningKey service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidKeySigningKeyStatusException">
        /// The key-signing key (KSK) status isn't valid or another KSK has the status <c>INTERNAL_FAILURE</c>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidKMSArnException">
        /// The KeyManagementServiceArn that you specified isn't valid to use with DNSSEC signing.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidSigningStatusException">
        /// Your hosted zone status isn't valid for this operation. In the hosted zone, change
        /// the status to enable <c>DNSSEC</c> or disable <c>DNSSEC</c>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchKeySigningKeyException">
        /// The specified key-signing key (KSK) doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteKeySigningKey">REST API Reference for DeleteKeySigningKey Operation</seealso>
        Task<DeleteKeySigningKeyResponse> DeleteKeySigningKeyAsync(DeleteKeySigningKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteQueryLoggingConfig



        /// <summary>
        /// Deletes a configuration for DNS query logging. If you delete a configuration, Amazon
        /// Route 53 stops sending query logs to CloudWatch Logs. Route 53 doesn't delete any
        /// logs that are already in CloudWatch Logs.
        /// 
        ///  
        /// <para>
        /// For more information about DNS query logs, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_CreateQueryLoggingConfig.html">CreateQueryLoggingConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueryLoggingConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueryLoggingConfig service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchQueryLoggingConfigException">
        /// There is no DNS query logging configuration with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteQueryLoggingConfig">REST API Reference for DeleteQueryLoggingConfig Operation</seealso>
        Task<DeleteQueryLoggingConfigResponse> DeleteQueryLoggingConfigAsync(DeleteQueryLoggingConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteReusableDelegationSet



        /// <summary>
        /// Deletes a reusable delegation set.
        /// 
        ///  <important> 
        /// <para>
        /// You can delete a reusable delegation set only if it isn't associated with any hosted
        /// zones.
        /// </para>
        ///  </important> 
        /// <para>
        /// To verify that the reusable delegation set is not associated with any hosted zones,
        /// submit a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetReusableDelegationSet.html">GetReusableDelegationSet</a>
        /// request and specify the ID of the reusable delegation set that you want to delete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReusableDelegationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteReusableDelegationSetResponse> DeleteReusableDelegationSetAsync(DeleteReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrafficPolicy



        /// <summary>
        /// Deletes a traffic policy.
        /// 
        ///  
        /// <para>
        /// When you delete a traffic policy, Route 53 sets a flag on the policy to indicate that
        /// it has been deleted. However, Route 53 never fully deletes the traffic policy. Note
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Deleted traffic policies aren't listed if you run <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_ListTrafficPolicies.html">ListTrafficPolicies</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  There's no way to get a list of deleted policies.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you retain the ID of the policy, you can get information about the policy, including
        /// the traffic policy document, by running <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetTrafficPolicy.html">GetTrafficPolicy</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrafficPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
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
        Task<DeleteTrafficPolicyResponse> DeleteTrafficPolicyAsync(DeleteTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrafficPolicyInstance



        /// <summary>
        /// Deletes a traffic policy instance and all of the resource record sets that Amazon
        /// Route 53 created when you created the instance.
        /// 
        ///  <note> 
        /// <para>
        /// In the Route 53 console, traffic policy instances are known as policy records.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicyInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// reject subsequent requests for the same hosted zone and return an <c>HTTP 400 error</c>
        /// (<c>Bad request</c>). If Route 53 returns this error repeatedly for the same request,
        /// we recommend that you wait, in intervals of increasing duration, before you try the
        /// request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DeleteTrafficPolicyInstance">REST API Reference for DeleteTrafficPolicyInstance Operation</seealso>
        Task<DeleteTrafficPolicyInstanceResponse> DeleteTrafficPolicyInstanceAsync(DeleteTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVPCAssociationAuthorization



        /// <summary>
        /// Removes authorization to submit an <c>AssociateVPCWithHostedZone</c> request to associate
        /// a specified VPC with a hosted zone that was created by a different account. You must
        /// use the account that created the hosted zone to submit a <c>DeleteVPCAssociationAuthorization</c>
        /// request.
        /// 
        ///  <important> 
        /// <para>
        /// Sending this request only prevents the Amazon Web Services account that created the
        /// VPC from associating the VPC with the Amazon Route 53 hosted zone in the future. If
        /// the VPC is already associated with the hosted zone, <c>DeleteVPCAssociationAuthorization</c>
        /// won't disassociate the VPC from the hosted zone. If you want to delete an existing
        /// association, use <c>DisassociateVPCFromHostedZone</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVPCAssociationAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVPCAssociationAuthorization service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
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
        Task<DeleteVPCAssociationAuthorizationResponse> DeleteVPCAssociationAuthorizationAsync(DeleteVPCAssociationAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableHostedZoneDNSSEC



        /// <summary>
        /// Disables DNSSEC signing in a specific hosted zone. This action does not deactivate
        /// any key-signing keys (KSKs) that are active in the hosted zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableHostedZoneDNSSEC service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableHostedZoneDNSSEC service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DNSSECNotFoundException">
        /// The hosted zone doesn't have any DNSSEC resources.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidArgumentException">
        /// Parameter name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidKeySigningKeyStatusException">
        /// The key-signing key (KSK) status isn't valid or another KSK has the status <c>INTERNAL_FAILURE</c>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidKMSArnException">
        /// The KeyManagementServiceArn that you specified isn't valid to use with DNSSEC signing.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.KeySigningKeyInParentDSRecordException">
        /// The key-signing key (KSK) is specified in a parent DS record.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/DisableHostedZoneDNSSEC">REST API Reference for DisableHostedZoneDNSSEC Operation</seealso>
        Task<DisableHostedZoneDNSSECResponse> DisableHostedZoneDNSSECAsync(DisableHostedZoneDNSSECRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateVPCFromHostedZone



        /// <summary>
        /// Disassociates an Amazon Virtual Private Cloud (Amazon VPC) from an Amazon Route 53
        /// private hosted zone. Note the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You can't disassociate the last Amazon VPC from a private hosted zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't convert a private hosted zone into a public hosted zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can submit a <c>DisassociateVPCFromHostedZone</c> request using either the account
        /// that created the hosted zone or the account that created the Amazon VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Some services, such as Cloud Map and Amazon Elastic File System (Amazon EFS) automatically
        /// create hosted zones and associate VPCs with the hosted zones. A service can create
        /// a hosted zone using your account or using its own account. You can disassociate a
        /// VPC from a hosted zone only if the service created the hosted zone using your account.
        /// </para>
        ///  
        /// <para>
        /// When you run <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_ListHostedZonesByVPC.html">DisassociateVPCFromHostedZone</a>,
        /// if the hosted zone has a value for <c>OwningAccount</c>, you can use <c>DisassociateVPCFromHostedZone</c>.
        /// If the hosted zone has a value for <c>OwningService</c>, you can't use <c>DisassociateVPCFromHostedZone</c>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// When revoking access, the hosted zone and the Amazon VPC must belong to the same partition.
        /// A partition is a group of Amazon Web Services Regions. Each Amazon Web Services account
        /// is scoped to one partition.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported partitions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aws</c> - Amazon Web Services Regions
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-cn</c> - China Regions
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-us-gov</c> - Amazon Web Services GovCloud (US) Region
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Access
        /// Management</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVPCFromHostedZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateVPCFromHostedZoneResponse> DisassociateVPCFromHostedZoneAsync(DisassociateVPCFromHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableHostedZoneDNSSEC



        /// <summary>
        /// Enables DNSSEC signing in a specific hosted zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableHostedZoneDNSSEC service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableHostedZoneDNSSEC service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DNSSECNotFoundException">
        /// The hosted zone doesn't have any DNSSEC resources.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZonePartiallyDelegatedException">
        /// The hosted zone nameservers don't match the parent nameservers. The hosted zone and
        /// parent must have the same nameservers.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidArgumentException">
        /// Parameter name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidKeySigningKeyStatusException">
        /// The key-signing key (KSK) status isn't valid or another KSK has the status <c>INTERNAL_FAILURE</c>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidKMSArnException">
        /// The KeyManagementServiceArn that you specified isn't valid to use with DNSSEC signing.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.KeySigningKeyWithActiveStatusNotFoundException">
        /// A key-signing key (KSK) with <c>ACTIVE</c> status wasn't found.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/EnableHostedZoneDNSSEC">REST API Reference for EnableHostedZoneDNSSEC Operation</seealso>
        Task<EnableHostedZoneDNSSECResponse> EnableHostedZoneDNSSECAsync(EnableHostedZoneDNSSECRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccountLimit



        /// <summary>
        /// Gets the specified limit for the current account, for example, the maximum number
        /// of health checks that you can create using the account.
        /// 
        ///  
        /// <para>
        /// For the default limit, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html">Limits</a>
        /// in the <i>Amazon Route 53 Developer Guide</i>. To request a higher limit, <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=service-limit-increase&amp;limitType=service-code-route53">open
        /// a case</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can also view account limits in Amazon Web Services Trusted Advisor. Sign in to
        /// the Amazon Web Services Management Console and open the Trusted Advisor console at
        /// <a href="https://console.aws.amazon.com/trustedadvisor">https://console.aws.amazon.com/trustedadvisor/</a>.
        /// Then choose <b>Service limits</b> in the navigation pane.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountLimit service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetAccountLimit">REST API Reference for GetAccountLimit Operation</seealso>
        Task<GetAccountLimitResponse> GetAccountLimitAsync(GetAccountLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetChange



        /// <summary>
        /// Returns the current status of a change batch request. The status is one of the following
        /// values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> indicates that the changes in this request have not propagated to
        /// all Amazon Route 53 DNS servers managing the hosted zone. This is the initial status
        /// of all change batch requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSYNC</c> indicates that the changes have propagated to all Route 53 DNS servers
        /// managing the hosted zone. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChange service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChange service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchChangeException">
        /// A change with the specified change ID does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetChange">REST API Reference for GetChange Operation</seealso>
        Task<GetChangeResponse> GetChangeAsync(GetChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCheckerIpRanges



        /// <summary>
        /// Route 53 does not perform authorization for this API because it retrieves information
        /// that is already available to the public.
        /// 
        ///  <important> 
        /// <para>
        ///  <c>GetCheckerIpRanges</c> still works, but we recommend that you download ip-ranges.json,
        /// which includes IP address ranges for all Amazon Web Services services. For more information,
        /// see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/route-53-ip-addresses.html">IP
        /// Address Ranges of Amazon Route 53 Servers</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCheckerIpRanges service method, as returned by Route53.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetCheckerIpRanges">REST API Reference for GetCheckerIpRanges Operation</seealso>
        Task<GetCheckerIpRangesResponse> GetCheckerIpRangesAsync(GetCheckerIpRangesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDNSSEC



        /// <summary>
        /// Returns information about DNSSEC for a specific hosted zone, including the key-signing
        /// keys (KSKs) in the hosted zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDNSSEC service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDNSSEC service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidArgumentException">
        /// Parameter name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetDNSSEC">REST API Reference for GetDNSSEC Operation</seealso>
        Task<GetDNSSECResponse> GetDNSSECAsync(GetDNSSECRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGeoLocation



        /// <summary>
        /// Gets information about whether a specified geographic location is supported for Amazon
        /// Route 53 geolocation resource record sets.
        /// 
        ///  
        /// <para>
        /// Route 53 does not perform authorization for this API because it retrieves information
        /// that is already available to the public.
        /// </para>
        ///  
        /// <para>
        /// Use the following syntax to determine whether a continent is supported for geolocation:
        /// </para>
        ///  
        /// <para>
        ///  <c>GET /2013-04-01/geolocation?continentcode=<i>two-letter abbreviation for a continent</i>
        /// </c> 
        /// </para>
        ///  
        /// <para>
        /// Use the following syntax to determine whether a country is supported for geolocation:
        /// </para>
        ///  
        /// <para>
        ///  <c>GET /2013-04-01/geolocation?countrycode=<i>two-character country code</i> </c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Use the following syntax to determine whether a subdivision of a country is supported
        /// for geolocation:
        /// </para>
        ///  
        /// <para>
        ///  <c>GET /2013-04-01/geolocation?countrycode=<i>two-character country code</i>&amp;subdivisioncode=<i>subdivision
        /// code</i> </c> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeoLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGeoLocation service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchGeoLocationException">
        /// Amazon Route 53 doesn't support the specified geographic location. For a list of supported
        /// geolocation codes, see the <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GeoLocation.html">GeoLocation</a>
        /// data type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetGeoLocation">REST API Reference for GetGeoLocation Operation</seealso>
        Task<GetGeoLocationResponse> GetGeoLocationAsync(GetGeoLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHealthCheck



        /// <summary>
        /// Gets information about a specified health check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you're trying to access is unsupported on this Amazon Route 53 endpoint.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheck">REST API Reference for GetHealthCheck Operation</seealso>
        Task<GetHealthCheckResponse> GetHealthCheckAsync(GetHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHealthCheckCount



        /// <summary>
        /// Retrieves the number of health checks that are associated with the current Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHealthCheckCount service method, as returned by Route53.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheckCount">REST API Reference for GetHealthCheckCount Operation</seealso>
        Task<GetHealthCheckCountResponse> GetHealthCheckCountAsync(GetHealthCheckCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHealthCheckLastFailureReason



        /// <summary>
        /// Gets the reason that a specified health check failed most recently.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckLastFailureReason service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHealthCheckLastFailureReason service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheckLastFailureReason">REST API Reference for GetHealthCheckLastFailureReason Operation</seealso>
        Task<GetHealthCheckLastFailureReasonResponse> GetHealthCheckLastFailureReasonAsync(GetHealthCheckLastFailureReasonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHealthCheckStatus



        /// <summary>
        /// Gets status of a specified health check. 
        /// 
        ///  <important> 
        /// <para>
        /// This API is intended for use during development to diagnose behavior. It doesn’t support
        /// production use-cases with high query rates that require immediate and actionable responses.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHealthCheckStatus service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheckStatus">REST API Reference for GetHealthCheckStatus Operation</seealso>
        Task<GetHealthCheckStatusResponse> GetHealthCheckStatusAsync(GetHealthCheckStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHostedZone



        /// <summary>
        /// Gets information about a specified hosted zone including the four name servers assigned
        /// to the hosted zone.
        /// 
        ///  
        /// <para>
        ///  <code/> returns the VPCs associated with the specified hosted zone and does not reflect
        /// the VPC associations by Route 53 Profiles. To get the associations to a Profile, call
        /// the <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53profiles_ListProfileAssociations.html">ListProfileAssociations</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZone">REST API Reference for GetHostedZone Operation</seealso>
        Task<GetHostedZoneResponse> GetHostedZoneAsync(GetHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHostedZoneCount


        /// <summary>
        /// Retrieves the number of hosted zones that are associated with the current Amazon Web
        /// Services account.
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
        /// Retrieves the number of hosted zones that are associated with the current Amazon Web
        /// Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZoneCount">REST API Reference for GetHostedZoneCount Operation</seealso>
        Task<GetHostedZoneCountResponse> GetHostedZoneCountAsync(GetHostedZoneCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHostedZoneLimit



        /// <summary>
        /// Gets the specified limit for a specified hosted zone, for example, the maximum number
        /// of records that you can create in the hosted zone. 
        /// 
        ///  
        /// <para>
        /// For the default limit, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html">Limits</a>
        /// in the <i>Amazon Route 53 Developer Guide</i>. To request a higher limit, <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=service-limit-increase&amp;limitType=service-code-route53">open
        /// a case</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHostedZoneLimit service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HostedZoneNotPrivateException">
        /// The specified hosted zone is a public hosted zone, not a private hosted zone.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZoneLimit">REST API Reference for GetHostedZoneLimit Operation</seealso>
        Task<GetHostedZoneLimitResponse> GetHostedZoneLimitAsync(GetHostedZoneLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetQueryLoggingConfig



        /// <summary>
        /// Gets information about a specified configuration for DNS query logging.
        /// 
        ///  
        /// <para>
        /// For more information about DNS query logs, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_CreateQueryLoggingConfig.html">CreateQueryLoggingConfig</a>
        /// and <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/query-logs.html">Logging
        /// DNS Queries</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryLoggingConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryLoggingConfig service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchQueryLoggingConfigException">
        /// There is no DNS query logging configuration with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetQueryLoggingConfig">REST API Reference for GetQueryLoggingConfig Operation</seealso>
        Task<GetQueryLoggingConfigResponse> GetQueryLoggingConfigAsync(GetQueryLoggingConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetReusableDelegationSet



        /// <summary>
        /// Retrieves information about a specified reusable delegation set, including the four
        /// name servers that are assigned to the delegation set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetReusableDelegationSetResponse> GetReusableDelegationSetAsync(GetReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetReusableDelegationSetLimit



        /// <summary>
        /// Gets the maximum number of hosted zones that you can associate with the specified
        /// reusable delegation set.
        /// 
        ///  
        /// <para>
        /// For the default limit, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html">Limits</a>
        /// in the <i>Amazon Route 53 Developer Guide</i>. To request a higher limit, <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=service-limit-increase&amp;limitType=service-code-route53">open
        /// a case</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReusableDelegationSetLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReusableDelegationSetLimit service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetReusableDelegationSetLimit">REST API Reference for GetReusableDelegationSetLimit Operation</seealso>
        Task<GetReusableDelegationSetLimitResponse> GetReusableDelegationSetLimitAsync(GetReusableDelegationSetLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTrafficPolicy



        /// <summary>
        /// Gets information about a specific traffic policy version.
        /// 
        ///  
        /// <para>
        /// For information about how of deleting a traffic policy affects the response from <c>GetTrafficPolicy</c>,
        /// see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_DeleteTrafficPolicy.html">DeleteTrafficPolicy</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrafficPolicy service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetTrafficPolicy">REST API Reference for GetTrafficPolicy Operation</seealso>
        Task<GetTrafficPolicyResponse> GetTrafficPolicyAsync(GetTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTrafficPolicyInstance



        /// <summary>
        /// Gets information about a specified traffic policy instance.
        /// 
        ///  <note> 
        /// <para>
        ///  Use <c>GetTrafficPolicyInstance</c> with the <c>id</c> of new traffic policy instance
        /// to confirm that the <c>CreateTrafficPolicyInstance</c> or an <c>UpdateTrafficPolicyInstance</c>
        /// request completed successfully. For more information, see the <c>State</c> response
        /// element.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// In the Route 53 console, traffic policy instances are known as policy records.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrafficPolicyInstance service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetTrafficPolicyInstance">REST API Reference for GetTrafficPolicyInstance Operation</seealso>
        Task<GetTrafficPolicyInstanceResponse> GetTrafficPolicyInstanceAsync(GetTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTrafficPolicyInstanceCount



        /// <summary>
        /// Gets the number of traffic policy instances that are associated with the current Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstanceCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrafficPolicyInstanceCount service method, as returned by Route53.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetTrafficPolicyInstanceCount">REST API Reference for GetTrafficPolicyInstanceCount Operation</seealso>
        Task<GetTrafficPolicyInstanceCountResponse> GetTrafficPolicyInstanceCountAsync(GetTrafficPolicyInstanceCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCidrBlocks



        /// <summary>
        /// Returns a paginated list of location objects and their CIDR blocks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCidrBlocks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCidrBlocks service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchCidrCollectionException">
        /// The CIDR collection you specified, doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchCidrLocationException">
        /// The CIDR collection location doesn't match any locations in your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListCidrBlocks">REST API Reference for ListCidrBlocks Operation</seealso>
        Task<ListCidrBlocksResponse> ListCidrBlocksAsync(ListCidrBlocksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCidrCollections



        /// <summary>
        /// Returns a paginated list of CIDR collections in the Amazon Web Services account (metadata
        /// only).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCidrCollections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCidrCollections service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListCidrCollections">REST API Reference for ListCidrCollections Operation</seealso>
        Task<ListCidrCollectionsResponse> ListCidrCollectionsAsync(ListCidrCollectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCidrLocations



        /// <summary>
        /// Returns a paginated list of CIDR locations for the given collection (metadata only,
        /// does not include CIDR blocks).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCidrLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCidrLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchCidrCollectionException">
        /// The CIDR collection you specified, doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListCidrLocations">REST API Reference for ListCidrLocations Operation</seealso>
        Task<ListCidrLocationsResponse> ListCidrLocationsAsync(ListCidrLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGeoLocations


        /// <summary>
        /// Retrieves a list of supported geographic locations.
        /// 
        ///  
        /// <para>
        /// Countries are listed first, and continents are listed last. If Amazon Route 53 supports
        /// subdivisions for a country (for example, states or provinces), the subdivisions for
        /// that country are listed in alphabetical order immediately after the corresponding
        /// country.
        /// </para>
        ///  
        /// <para>
        /// Route 53 does not perform authorization for this API because it retrieves information
        /// that is already available to the public.
        /// </para>
        ///  
        /// <para>
        /// For a list of supported geolocation codes, see the <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GeoLocation.html">GeoLocation</a>
        /// data type.
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
        /// Retrieves a list of supported geographic locations.
        /// 
        ///  
        /// <para>
        /// Countries are listed first, and continents are listed last. If Amazon Route 53 supports
        /// subdivisions for a country (for example, states or provinces), the subdivisions for
        /// that country are listed in alphabetical order immediately after the corresponding
        /// country.
        /// </para>
        ///  
        /// <para>
        /// Route 53 does not perform authorization for this API because it retrieves information
        /// that is already available to the public.
        /// </para>
        ///  
        /// <para>
        /// For a list of supported geolocation codes, see the <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GeoLocation.html">GeoLocation</a>
        /// data type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeoLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeoLocations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListGeoLocations">REST API Reference for ListGeoLocations Operation</seealso>
        Task<ListGeoLocationsResponse> ListGeoLocationsAsync(ListGeoLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHealthChecks


        /// <summary>
        /// Retrieve a list of the health checks that are associated with the current Amazon Web
        /// Services account.
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
        /// Retrieve a list of the health checks that are associated with the current Amazon Web
        /// Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHealthChecks service method.</param>
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
        Task<ListHealthChecksResponse> ListHealthChecksAsync(ListHealthChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHostedZones


        /// <summary>
        /// Retrieves a list of the public and private hosted zones that are associated with the
        /// current Amazon Web Services account. The response includes a <c>HostedZones</c> child
        /// element for each hosted zone.
        /// 
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of hosted zones, you can use the <c>maxitems</c> parameter to list them in groups
        /// of up to 100.
        /// </para>
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
        /// Retrieves a list of the public and private hosted zones that are associated with the
        /// current Amazon Web Services account. The response includes a <c>HostedZones</c> child
        /// element for each hosted zone.
        /// 
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of hosted zones, you can use the <c>maxitems</c> parameter to list them in groups
        /// of up to 100.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZones service method.</param>
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
        Task<ListHostedZonesResponse> ListHostedZonesAsync(ListHostedZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHostedZonesByName



        /// <summary>
        /// Retrieves a list of your hosted zones in lexicographic order. The response includes
        /// a <c>HostedZones</c> child element for each hosted zone created by the current Amazon
        /// Web Services account. 
        /// 
        ///  
        /// <para>
        ///  <c>ListHostedZonesByName</c> sorts hosted zones by name with the labels reversed.
        /// For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>com.example.www.</c> 
        /// </para>
        ///  
        /// <para>
        /// Note the trailing dot, which can change the sort order in some circumstances.
        /// </para>
        ///  
        /// <para>
        /// If the domain name includes escape characters or Punycode, <c>ListHostedZonesByName</c>
        /// alphabetizes the domain name using the escaped or Punycoded value, which is the format
        /// that Amazon Route 53 saves in its database. For example, to create a hosted zone for
        /// exämple.com, you specify ex\344mple.com for the domain name. <c>ListHostedZonesByName</c>
        /// alphabetizes it as:
        /// </para>
        ///  
        /// <para>
        ///  <c>com.ex\344mple.</c> 
        /// </para>
        ///  
        /// <para>
        /// The labels are reversed and alphabetized using the escaped value. For more information
        /// about valid domain name formats, including internationalized domain names, see <a
        /// href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html">DNS
        /// Domain Name Format</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Route 53 returns up to 100 items in each response. If you have a lot of hosted zones,
        /// use the <c>MaxItems</c> parameter to list them in groups of up to 100. The response
        /// includes values that help navigate from one group of <c>MaxItems</c> hosted zones
        /// to the next:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>DNSName</c> and <c>HostedZoneId</c> elements in the response contain the values,
        /// if any, specified for the <c>dnsname</c> and <c>hostedzoneid</c> parameters in the
        /// request that produced the current response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>MaxItems</c> element in the response contains the value, if any, that you specified
        /// for the <c>maxitems</c> parameter in the request that produced the current response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value of <c>IsTruncated</c> in the response is true, there are more hosted
        /// zones associated with the current Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        /// If <c>IsTruncated</c> is false, this response includes the last hosted zone that is
        /// associated with the current account. The <c>NextDNSName</c> element and <c>NextHostedZoneId</c>
        /// elements are omitted from the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>NextDNSName</c> and <c>NextHostedZoneId</c> elements in the response contain
        /// the domain name and the hosted zone ID of the next hosted zone that is associated
        /// with the current Amazon Web Services account. If you want to list more hosted zones,
        /// make another call to <c>ListHostedZonesByName</c>, and specify the value of <c>NextDNSName</c>
        /// and <c>NextHostedZoneId</c> in the <c>dnsname</c> and <c>hostedzoneid</c> parameters,
        /// respectively.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZonesByName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHostedZonesByName service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidDomainNameException">
        /// The specified domain name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHostedZonesByName">REST API Reference for ListHostedZonesByName Operation</seealso>
        Task<ListHostedZonesByNameResponse> ListHostedZonesByNameAsync(ListHostedZonesByNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHostedZonesByVPC



        /// <summary>
        /// Lists all the private hosted zones that a specified VPC is associated with, regardless
        /// of which Amazon Web Services account or Amazon Web Services service owns the hosted
        /// zones. The <c>HostedZoneOwner</c> structure in the response contains one of the following
        /// values:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// An <c>OwningAccount</c> element, which contains the account number of either the current
        /// Amazon Web Services account or another Amazon Web Services account. Some services,
        /// such as Cloud Map, create hosted zones using the current account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <c>OwningService</c> element, which identifies the Amazon Web Services service
        /// that created and owns the hosted zone. For example, if a hosted zone was created by
        /// Amazon Elastic File System (Amazon EFS), the value of <c>Owner</c> is <c>efs.amazonaws.com</c>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>ListHostedZonesByVPC</c> returns the hosted zones associated with the specified
        /// VPC and does not reflect the hosted zone associations to VPCs via Route 53 Profiles.
        /// To get the associations to a Profile, call the <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53profiles_ListProfileResourceAssociations.html">ListProfileResourceAssociations</a>
        /// API.
        /// </para>
        ///  <note> 
        /// <para>
        /// When listing private hosted zones, the hosted zone and the Amazon VPC must belong
        /// to the same partition where the hosted zones were created. A partition is a group
        /// of Amazon Web Services Regions. Each Amazon Web Services account is scoped to one
        /// partition.
        /// </para>
        ///  
        /// <para>
        /// The following are the supported partitions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aws</c> - Amazon Web Services Regions
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-cn</c> - China Regions
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-us-gov</c> - Amazon Web Services GovCloud (US) Region
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Access
        /// Management</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostedZonesByVPC service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHostedZonesByVPC service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidPaginationTokenException">
        /// The value that you specified to get the second or subsequent page of results is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListHostedZonesByVPC">REST API Reference for ListHostedZonesByVPC Operation</seealso>
        Task<ListHostedZonesByVPCResponse> ListHostedZonesByVPCAsync(ListHostedZonesByVPCRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListQueryLoggingConfigs



        /// <summary>
        /// Lists the configurations for DNS query logging that are associated with the current
        /// Amazon Web Services account or the configuration that is associated with a specified
        /// hosted zone.
        /// 
        ///  
        /// <para>
        /// For more information about DNS query logs, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_CreateQueryLoggingConfig.html">CreateQueryLoggingConfig</a>.
        /// Additional information, including the format of DNS query logs, appears in <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/query-logs.html">Logging
        /// DNS Queries</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueryLoggingConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueryLoggingConfigs service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidPaginationTokenException">
        /// The value that you specified to get the second or subsequent page of results is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListQueryLoggingConfigs">REST API Reference for ListQueryLoggingConfigs Operation</seealso>
        Task<ListQueryLoggingConfigsResponse> ListQueryLoggingConfigsAsync(ListQueryLoggingConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourceRecordSets



        /// <summary>
        /// Lists the resource record sets in a specified hosted zone.
        /// 
        ///  
        /// <para>
        ///  <c>ListResourceRecordSets</c> returns up to 300 resource record sets at a time in
        /// ASCII order, beginning at a position specified by the <c>name</c> and <c>type</c>
        /// elements.
        /// </para>
        ///  
        /// <para>
        ///  <b>Sort order</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>ListResourceRecordSets</c> sorts results first by DNS name with the labels reversed,
        /// for example:
        /// </para>
        ///  
        /// <para>
        ///  <c>com.example.www.</c> 
        /// </para>
        ///  
        /// <para>
        /// Note the trailing dot, which can change the sort order when the record name contains
        /// characters that appear before <c>.</c> (decimal 46) in the ASCII table. These characters
        /// include the following: <c>! " # $ % &amp; ' ( ) * + , -</c> 
        /// </para>
        ///  
        /// <para>
        /// When multiple records have the same DNS name, <c>ListResourceRecordSets</c> sorts
        /// results by the record type.
        /// </para>
        ///  
        /// <para>
        ///  <b>Specifying where to start listing records</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use the name and type elements to specify the resource record set that the
        /// list begins with:
        /// </para>
        ///  <dl> <dt>If you do not specify Name or Type</dt> <dd> 
        /// <para>
        /// The results begin with the first resource record set that the hosted zone contains.
        /// </para>
        ///  </dd> <dt>If you specify Name but not Type</dt> <dd> 
        /// <para>
        /// The results begin with the first resource record set in the list whose name is greater
        /// than or equal to <c>Name</c>.
        /// </para>
        ///  </dd> <dt>If you specify Type but not Name</dt> <dd> 
        /// <para>
        /// Amazon Route 53 returns the <c>InvalidInput</c> error.
        /// </para>
        ///  </dd> <dt>If you specify both Name and Type</dt> <dd> 
        /// <para>
        /// The results begin with the first resource record set in the list whose name is greater
        /// than or equal to <c>Name</c>, and whose type is greater than or equal to <c>Type</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Type is only used to sort between records with the same record Name.
        /// </para>
        ///  </note> </dd> </dl> 
        /// <para>
        ///  <b>Resource record sets that are PENDING</b> 
        /// </para>
        ///  
        /// <para>
        /// This action returns the most current version of the records. This includes records
        /// that are <c>PENDING</c>, and that are not yet available on all Route 53 DNS servers.
        /// </para>
        ///  
        /// <para>
        ///  <b>Changing resource record sets</b> 
        /// </para>
        ///  
        /// <para>
        /// To ensure that you get an accurate listing of the resource record sets for a hosted
        /// zone at a point in time, do not submit a <c>ChangeResourceRecordSets</c> request while
        /// you're paging through the results of a <c>ListResourceRecordSets</c> request. If you
        /// do, some pages may display results without the latest changes while other pages display
        /// results with the latest changes.
        /// </para>
        ///  
        /// <para>
        ///  <b>Displaying the next page of results</b> 
        /// </para>
        ///  
        /// <para>
        /// If a <c>ListResourceRecordSets</c> command returns more than one page of results,
        /// the value of <c>IsTruncated</c> is <c>true</c>. To display the next page of results,
        /// get the values of <c>NextRecordName</c>, <c>NextRecordType</c>, and <c>NextRecordIdentifier</c>
        /// (if any) from the response. Then submit another <c>ListResourceRecordSets</c> request,
        /// and specify those values for <c>StartRecordName</c>, <c>StartRecordType</c>, and <c>StartRecordIdentifier</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceRecordSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceRecordSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListResourceRecordSets">REST API Reference for ListResourceRecordSets Operation</seealso>
        Task<ListResourceRecordSetsResponse> ListResourceRecordSetsAsync(ListResourceRecordSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListReusableDelegationSets


        /// <summary>
        /// Retrieves a list of the reusable delegation sets that are associated with the current
        /// Amazon Web Services account.
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
        /// Retrieves a list of the reusable delegation sets that are associated with the current
        /// Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListReusableDelegationSets">REST API Reference for ListReusableDelegationSets Operation</seealso>
        Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(ListReusableDelegationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists tags for one health check or hosted zone. 
        /// 
        ///  
        /// <para>
        /// For information about using tags for cost allocation, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>Billing and Cost Management User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// If Amazon Route 53 can't process a request before the next request arrives, it will
        /// reject subsequent requests for the same hosted zone and return an <c>HTTP 400 error</c>
        /// (<c>Bad request</c>). If Route 53 returns this error repeatedly for the same request,
        /// we recommend that you wait, in intervals of increasing duration, before you try the
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResources



        /// <summary>
        /// Lists tags for up to 10 health checks or hosted zones.
        /// 
        ///  
        /// <para>
        /// For information about using tags for cost allocation, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>Billing and Cost Management User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResources service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// If Amazon Route 53 can't process a request before the next request arrives, it will
        /// reject subsequent requests for the same hosted zone and return an <c>HTTP 400 error</c>
        /// (<c>Bad request</c>). If Route 53 returns this error repeatedly for the same request,
        /// we recommend that you wait, in intervals of increasing duration, before you try the
        /// request again.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTagsForResources">REST API Reference for ListTagsForResources Operation</seealso>
        Task<ListTagsForResourcesResponse> ListTagsForResourcesAsync(ListTagsForResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrafficPolicies



        /// <summary>
        /// Gets information about the latest version for every traffic policy that is associated
        /// with the current Amazon Web Services account. Policies are listed in the order that
        /// they were created in. 
        /// 
        ///  
        /// <para>
        /// For information about how of deleting a traffic policy affects the response from <c>ListTrafficPolicies</c>,
        /// see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_DeleteTrafficPolicy.html">DeleteTrafficPolicy</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrafficPolicies service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicies">REST API Reference for ListTrafficPolicies Operation</seealso>
        Task<ListTrafficPoliciesResponse> ListTrafficPoliciesAsync(ListTrafficPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrafficPolicyInstances



        /// <summary>
        /// Gets information about the traffic policy instances that you created by using the
        /// current Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// After you submit an <c>UpdateTrafficPolicyInstance</c> request, there's a brief delay
        /// while Amazon Route 53 creates the resource record sets that are specified in the traffic
        /// policy definition. For more information, see the <c>State</c> response element.
        /// </para>
        ///  </note> 
        /// <para>
        /// Route 53 returns a maximum of 100 items in each response. If you have a lot of traffic
        /// policy instances, you can use the <c>MaxItems</c> parameter to list them in groups
        /// of up to 100.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrafficPolicyInstances service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyInstanceException">
        /// No traffic policy instance exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyInstances">REST API Reference for ListTrafficPolicyInstances Operation</seealso>
        Task<ListTrafficPolicyInstancesResponse> ListTrafficPolicyInstancesAsync(ListTrafficPolicyInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrafficPolicyInstancesByHostedZone



        /// <summary>
        /// Gets information about the traffic policy instances that you created in a specified
        /// hosted zone.
        /// 
        ///  <note> 
        /// <para>
        /// After you submit a <c>CreateTrafficPolicyInstance</c> or an <c>UpdateTrafficPolicyInstance</c>
        /// request, there's a brief delay while Amazon Route 53 creates the resource record sets
        /// that are specified in the traffic policy definition. For more information, see the
        /// <c>State</c> response element.
        /// </para>
        ///  </note> 
        /// <para>
        /// Route 53 returns a maximum of 100 items in each response. If you have a lot of traffic
        /// policy instances, you can use the <c>MaxItems</c> parameter to list them in groups
        /// of up to 100.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByHostedZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTrafficPolicyInstancesByHostedZoneResponse> ListTrafficPolicyInstancesByHostedZoneAsync(ListTrafficPolicyInstancesByHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrafficPolicyInstancesByPolicy



        /// <summary>
        /// Gets information about the traffic policy instances that you created by using a specify
        /// traffic policy version.
        /// 
        ///  <note> 
        /// <para>
        /// After you submit a <c>CreateTrafficPolicyInstance</c> or an <c>UpdateTrafficPolicyInstance</c>
        /// request, there's a brief delay while Amazon Route 53 creates the resource record sets
        /// that are specified in the traffic policy definition. For more information, see the
        /// <c>State</c> response element.
        /// </para>
        ///  </note> 
        /// <para>
        /// Route 53 returns a maximum of 100 items in each response. If you have a lot of traffic
        /// policy instances, you can use the <c>MaxItems</c> parameter to list them in groups
        /// of up to 100.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyInstancesByPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTrafficPolicyInstancesByPolicyResponse> ListTrafficPolicyInstancesByPolicyAsync(ListTrafficPolicyInstancesByPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrafficPolicyVersions



        /// <summary>
        /// Gets information about all of the versions for a specified traffic policy.
        /// 
        ///  
        /// <para>
        /// Traffic policy versions are listed in numerical order by <c>VersionNumber</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicyVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrafficPolicyVersions service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicyVersions">REST API Reference for ListTrafficPolicyVersions Operation</seealso>
        Task<ListTrafficPolicyVersionsResponse> ListTrafficPolicyVersionsAsync(ListTrafficPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVPCAssociationAuthorizations



        /// <summary>
        /// Gets a list of the VPCs that were created by other accounts and that can be associated
        /// with a specified hosted zone because you've submitted one or more <c>CreateVPCAssociationAuthorization</c>
        /// requests. 
        /// 
        ///  
        /// <para>
        /// The response includes a <c>VPCs</c> element with a <c>VPC</c> child element for each
        /// VPC that can be associated with the hosted zone.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVPCAssociationAuthorizations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVPCAssociationAuthorizations service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidPaginationTokenException">
        /// The value that you specified to get the second or subsequent page of results is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListVPCAssociationAuthorizations">REST API Reference for ListVPCAssociationAuthorizations Operation</seealso>
        Task<ListVPCAssociationAuthorizationsResponse> ListVPCAssociationAuthorizationsAsync(ListVPCAssociationAuthorizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestDNSAnswer



        /// <summary>
        /// Gets the value that Amazon Route 53 returns in response to a DNS request for a specified
        /// record name and type. You can optionally specify the IP address of a DNS resolver,
        /// an EDNS0 client subnet IP address, and a subnet mask. 
        /// 
        ///  
        /// <para>
        /// This call only supports querying public hosted zones.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>TestDnsAnswer </c> returns information similar to what you would expect from
        /// the answer section of the <c>dig</c> command. Therefore, if you query for the name
        /// servers of a subdomain that point to the parent name servers, those will not be returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestDNSAnswer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestDNSAnswer service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/TestDNSAnswer">REST API Reference for TestDNSAnswer Operation</seealso>
        Task<TestDNSAnswerResponse> TestDNSAnswerAsync(TestDNSAnswerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHealthCheck



        /// <summary>
        /// Updates an existing health check. Note that some values can't be updated. 
        /// 
        ///  
        /// <para>
        /// For more information about updating health checks, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/health-checks-creating-deleting.html">Creating,
        /// Updating, and Deleting Health Checks</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckVersionMismatchException">
        /// The value of <c>HealthCheckVersion</c> in the request doesn't match the value of <c>HealthCheckVersion</c>
        /// in the health check.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateHealthCheck">REST API Reference for UpdateHealthCheck Operation</seealso>
        Task<UpdateHealthCheckResponse> UpdateHealthCheckAsync(UpdateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHostedZoneComment



        /// <summary>
        /// Updates the comment for a specified hosted zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostedZoneComment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateHostedZoneComment service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PriorRequestNotCompleteException">
        /// If Amazon Route 53 can't process a request before the next request arrives, it will
        /// reject subsequent requests for the same hosted zone and return an <c>HTTP 400 error</c>
        /// (<c>Bad request</c>). If Route 53 returns this error repeatedly for the same request,
        /// we recommend that you wait, in intervals of increasing duration, before you try the
        /// request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateHostedZoneComment">REST API Reference for UpdateHostedZoneComment Operation</seealso>
        Task<UpdateHostedZoneCommentResponse> UpdateHostedZoneCommentAsync(UpdateHostedZoneCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrafficPolicyComment



        /// <summary>
        /// Updates the comment for a specified traffic policy version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyComment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrafficPolicyComment service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConcurrentModificationException">
        /// Another user submitted a request to create, update, or delete the object at the same
        /// time that you did. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchTrafficPolicyException">
        /// No traffic policy exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateTrafficPolicyComment">REST API Reference for UpdateTrafficPolicyComment Operation</seealso>
        Task<UpdateTrafficPolicyCommentResponse> UpdateTrafficPolicyCommentAsync(UpdateTrafficPolicyCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrafficPolicyInstance



        /// <summary>
        /// <note> 
        /// <para>
        /// After you submit a <c>UpdateTrafficPolicyInstance</c> request, there's a brief delay
        /// while Route 53 creates the resource record sets that are specified in the traffic
        /// policy definition. Use <c>GetTrafficPolicyInstance</c> with the <c>id</c> of updated
        /// traffic policy instance confirm that the <c>UpdateTrafficPolicyInstance</c> request
        /// completed successfully. For more information, see the <c>State</c> response element.
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates the resource record sets in a specified hosted zone that were created based
        /// on the settings in a specified traffic policy version.
        /// </para>
        ///  
        /// <para>
        /// When you update a traffic policy instance, Amazon Route 53 continues to respond to
        /// DNS queries for the root resource record set name (such as example.com) while it replaces
        /// one group of resource record sets with another. Route 53 performs the following operations:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Route 53 creates a new group of resource record sets based on the specified traffic
        /// policy. This is true regardless of how significant the differences are between the
        /// existing resource record sets and the new resource record sets. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When all of the new resource record sets have been created, Route 53 starts to respond
        /// to DNS queries for the root resource record set name (such as example.com) by using
        /// the new resource record sets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Route 53 deletes the old group of resource record sets that are associated with the
        /// root resource record set name.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicyInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrafficPolicyInstance service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingTypesException">
        /// You tried to update a traffic policy instance by using a traffic policy version that
        /// has a different DNS type than the current type for the instance. You specified the
        /// type in the JSON document in the <c>CreateTrafficPolicy</c> or <c>CreateTrafficPolicyVersion</c>request.
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
        /// reject subsequent requests for the same hosted zone and return an <c>HTTP 400 error</c>
        /// (<c>Bad request</c>). If Route 53 returns this error repeatedly for the same request,
        /// we recommend that you wait, in intervals of increasing duration, before you try the
        /// request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/UpdateTrafficPolicyInstance">REST API Reference for UpdateTrafficPolicyInstance Operation</seealso>
        Task<UpdateTrafficPolicyInstanceResponse> UpdateTrafficPolicyInstanceAsync(UpdateTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonRoute53Config))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonRoute53Config();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonRoute53Config;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonRoute53Config to create AmazonRoute53Client");
            }

            return awsCredentials == null ? 
                    new AmazonRoute53Client(serviceClientConfig) :
                    new AmazonRoute53Client(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}