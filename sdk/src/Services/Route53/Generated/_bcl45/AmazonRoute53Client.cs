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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Route53.Model;
using Amazon.Route53.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53
{
    /// <summary>
    /// Implementation for accessing Route53
    ///
    /// 
    /// </summary>
    public partial class AmazonRoute53Client : AmazonServiceClient, IAmazonRoute53
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRoute53Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53Config()) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(AmazonRoute53Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53Client(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials and an
        /// AmazonRoute53Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(AWSCredentials credentials, AmazonRoute53Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.Route53.Internal.AmazonRoute53PostMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.ErrorCallbackHandler>(new Amazon.Route53.Internal.AmazonRoute53PreMarshallHandler());
        }    

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

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
        public AssociateVPCWithHostedZoneResponse AssociateVPCWithHostedZone(AssociateVPCWithHostedZoneRequest request)
        {
            var marshaller = new AssociateVPCWithHostedZoneRequestMarshaller();
            var unmarshaller = AssociateVPCWithHostedZoneResponseUnmarshaller.Instance;

            return Invoke<AssociateVPCWithHostedZoneRequest,AssociateVPCWithHostedZoneResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<AssociateVPCWithHostedZoneResponse> AssociateVPCWithHostedZoneAsync(AssociateVPCWithHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateVPCWithHostedZoneRequestMarshaller();
            var unmarshaller = AssociateVPCWithHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateVPCWithHostedZoneRequest,AssociateVPCWithHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ChangeResourceRecordSets


        /// <summary>
        /// Creates, changes, or deletes a resource record set, which contains authoritative DNS
        /// information for a specified domain name or subdomain name. For example, you can use
        /// <code>ChangeResourceRecordSets</code> to create a resource record set that routes
        /// traffic for test.example.com to a web server that has an IP address of 192.0.2.44.
        /// 
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
        public ChangeResourceRecordSetsResponse ChangeResourceRecordSets(ChangeResourceRecordSetsRequest request)
        {
            var marshaller = new ChangeResourceRecordSetsRequestMarshaller();
            var unmarshaller = ChangeResourceRecordSetsResponseUnmarshaller.Instance;

            return Invoke<ChangeResourceRecordSetsRequest,ChangeResourceRecordSetsResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ChangeResourceRecordSetsResponse> ChangeResourceRecordSetsAsync(ChangeResourceRecordSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ChangeResourceRecordSetsRequestMarshaller();
            var unmarshaller = ChangeResourceRecordSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ChangeResourceRecordSetsRequest,ChangeResourceRecordSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public ChangeTagsForResourceResponse ChangeTagsForResource(ChangeTagsForResourceRequest request)
        {
            var marshaller = new ChangeTagsForResourceRequestMarshaller();
            var unmarshaller = ChangeTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ChangeTagsForResourceRequest,ChangeTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ChangeTagsForResourceResponse> ChangeTagsForResourceAsync(ChangeTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ChangeTagsForResourceRequestMarshaller();
            var unmarshaller = ChangeTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ChangeTagsForResourceRequest,ChangeTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHealthCheck


        /// <summary>
        /// Creates a new health check.
        /// 
        ///  
        /// <para>
        /// For information about adding health checks to resource record sets, see <a>ResourceRecordSet$HealthCheckId</a>
        /// in <a>ChangeResourceRecordSets</a>. 
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
        /// which performs a similar function to an Amazon Route 53 health check.
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
        /// this error when you submit a request that has the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The same value for <code>CallerReference</code> as an existing health check, and one
        /// or more values that differ from the existing health check that has the same caller
        /// reference.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The same value for <code>CallerReference</code> as a health check that you created
        /// and later deleted, regardless of the other settings in the request.
        /// </para>
        ///  </li> </ul>
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
        public CreateHealthCheckResponse CreateHealthCheck(CreateHealthCheckRequest request)
        {
            var marshaller = new CreateHealthCheckRequestMarshaller();
            var unmarshaller = CreateHealthCheckResponseUnmarshaller.Instance;

            return Invoke<CreateHealthCheckRequest,CreateHealthCheckResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<CreateHealthCheckResponse> CreateHealthCheckAsync(CreateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHealthCheckRequestMarshaller();
            var unmarshaller = CreateHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHealthCheckRequest,CreateHealthCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHostedZone


        /// <summary>
        /// Creates a new public hosted zone, which you use to specify how the Domain Name System
        /// (DNS) routes traffic on the Internet for a domain, such as example.com, and its subdomains.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// You can't convert a public hosted zones to a private hosted zone or vice versa. Instead,
        /// you must create a new hosted zone with the same name and create new resource record
        /// sets.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about charges for hosted zones, see <a href="http://aws.amazon.com/route53/pricing/">Amazon
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
        ///  
        /// <para>
        /// If you want to use the same name servers for multiple hosted zones, you can optionally
        /// associate a reusable delegation set with the hosted zone. See the <code>DelegationSetId</code>
        /// element.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your domain is registered with a registrar other than Amazon Route 53, you must
        /// update the name servers with your registrar to make Amazon Route 53 your DNS service.
        /// For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/creating-migrating.html">Configuring
        /// Amazon Route 53 as your DNS Service</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you submit a <code>CreateHostedZone</code> request, the initial status of the
        /// hosted zone is <code>PENDING</code>. This means that the NS and SOA records are not
        /// yet available on all Amazon Route 53 DNS servers. When the NS and SOA records are
        /// available, the status of the zone changes to <code>INSYNC</code>.
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
        public CreateHostedZoneResponse CreateHostedZone(CreateHostedZoneRequest request)
        {
            var marshaller = new CreateHostedZoneRequestMarshaller();
            var unmarshaller = CreateHostedZoneResponseUnmarshaller.Instance;

            return Invoke<CreateHostedZoneRequest,CreateHostedZoneResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<CreateHostedZoneResponse> CreateHostedZoneAsync(CreateHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHostedZoneRequestMarshaller();
            var unmarshaller = CreateHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHostedZoneRequest,CreateHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateReusableDelegationSet


        /// <summary>
        /// Creates a delegation set (a group of four name servers) that can be reused by multiple
        /// hosted zones. If a hosted zoned ID is specified, <code>CreateReusableDelegationSet</code>
        /// marks the delegation set associated with that zone as reusable
        /// 
        ///  <note> 
        /// <para>
        /// A reusable delegation set can't be associated with a private hosted zone.
        /// </para>
        ///  </note> 
        /// <para>
        /// For information on how to use a reusable delegation set to configure white label name
        /// servers, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/white-label-name-servers.html">Configuring
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
        public CreateReusableDelegationSetResponse CreateReusableDelegationSet(CreateReusableDelegationSetRequest request)
        {
            var marshaller = new CreateReusableDelegationSetRequestMarshaller();
            var unmarshaller = CreateReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<CreateReusableDelegationSetRequest,CreateReusableDelegationSetResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<CreateReusableDelegationSetResponse> CreateReusableDelegationSetAsync(CreateReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateReusableDelegationSetRequestMarshaller();
            var unmarshaller = CreateReusableDelegationSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReusableDelegationSetRequest,CreateReusableDelegationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTrafficPolicy


        /// <summary>
        /// Creates a traffic policy, which you use to create multiple DNS resource record sets
        /// for one domain name (such as example.com) or one subdomain name (such as www.example.com).
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
        public CreateTrafficPolicyResponse CreateTrafficPolicy(CreateTrafficPolicyRequest request)
        {
            var marshaller = new CreateTrafficPolicyRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyRequest,CreateTrafficPolicyResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<CreateTrafficPolicyResponse> CreateTrafficPolicyAsync(CreateTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrafficPolicyRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyRequest,CreateTrafficPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTrafficPolicyInstance


        /// <summary>
        /// Creates resource record sets in a specified hosted zone based on the settings in a
        /// specified traffic policy version. In addition, <code>CreateTrafficPolicyInstance</code>
        /// associates the resource record sets with a specified domain name (such as example.com)
        /// or subdomain name (such as www.example.com). Amazon Route 53 responds to DNS queries
        /// for the domain or subdomain name by using the resource record sets that <code>CreateTrafficPolicyInstance</code>
        /// created.
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
        public CreateTrafficPolicyInstanceResponse CreateTrafficPolicyInstance(CreateTrafficPolicyInstanceRequest request)
        {
            var marshaller = new CreateTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyInstanceRequest,CreateTrafficPolicyInstanceResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<CreateTrafficPolicyInstanceResponse> CreateTrafficPolicyInstanceAsync(CreateTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyInstanceRequest,CreateTrafficPolicyInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateTrafficPolicyVersionResponse CreateTrafficPolicyVersion(CreateTrafficPolicyVersionRequest request)
        {
            var marshaller = new CreateTrafficPolicyVersionRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyVersionRequest,CreateTrafficPolicyVersionResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<CreateTrafficPolicyVersionResponse> CreateTrafficPolicyVersionAsync(CreateTrafficPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrafficPolicyVersionRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyVersionRequest,CreateTrafficPolicyVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateVPCAssociationAuthorizationResponse CreateVPCAssociationAuthorization(CreateVPCAssociationAuthorizationRequest request)
        {
            var marshaller = new CreateVPCAssociationAuthorizationRequestMarshaller();
            var unmarshaller = CreateVPCAssociationAuthorizationResponseUnmarshaller.Instance;

            return Invoke<CreateVPCAssociationAuthorizationRequest,CreateVPCAssociationAuthorizationResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<CreateVPCAssociationAuthorizationResponse> CreateVPCAssociationAuthorizationAsync(CreateVPCAssociationAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVPCAssociationAuthorizationRequestMarshaller();
            var unmarshaller = CreateVPCAssociationAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVPCAssociationAuthorizationRequest,CreateVPCAssociationAuthorizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// of DNS queries for your DNS failover configuration. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/health-checks-creating-deleting.html#health-checks-deleting.html">Replacing
        /// and Deleting Health Checks</a> in the <i>Amazon Route 53 Developer Guide</i>.
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
        public DeleteHealthCheckResponse DeleteHealthCheck(DeleteHealthCheckRequest request)
        {
            var marshaller = new DeleteHealthCheckRequestMarshaller();
            var unmarshaller = DeleteHealthCheckResponseUnmarshaller.Instance;

            return Invoke<DeleteHealthCheckRequest,DeleteHealthCheckResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DeleteHealthCheckResponse> DeleteHealthCheckAsync(DeleteHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHealthCheckRequestMarshaller();
            var unmarshaller = DeleteHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHealthCheckRequest,DeleteHealthCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteHostedZone


        /// <summary>
        /// Deletes a hosted zone.
        /// 
        ///  <important> 
        /// <para>
        /// If the name servers for the hosted zone are associated with a domain and if you want
        /// to make the domain unavailable on the Internet, we recommend that you delete the name
        /// servers from the domain to prevent future DNS queries from possibly being misrouted.
        /// If the domain is registered with Amazon Route 53, see <code>UpdateDomainNameservers</code>.
        /// If the domain is registered with another registrar, use the method provided by the
        /// registrar to delete name servers for the domain.
        /// </para>
        ///  
        /// <para>
        /// Some domain registries don't allow you to remove all of the name servers for a domain.
        /// If the registry for your domain requires one or more name servers, we recommend that
        /// you delete the hosted zone only if you transfer DNS service to another service provider,
        /// and you replace the name servers for the domain with name servers from the new provider.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can delete a hosted zone only if it contains only the default SOA record and NS
        /// resource record sets. If the hosted zone contains other resource record sets, you
        /// must delete them before you can delete the hosted zone. If you try to delete a hosted
        /// zone that contains other resource record sets, the request fails, and Amazon Route
        /// 53 returns a <code>HostedZoneNotEmpty</code> error. For information about deleting
        /// records from your hosted zone, see <a>ChangeResourceRecordSets</a>.
        /// </para>
        ///  
        /// <para>
        /// To verify that the hosted zone has been deleted, do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <code>GetHostedZone</code> action to request information about the hosted
        /// zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <code>ListHostedZones</code> action to get a list of the hosted zones associated
        /// with the current AWS account.
        /// </para>
        ///  </li> </ul>
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
        public DeleteHostedZoneResponse DeleteHostedZone(DeleteHostedZoneRequest request)
        {
            var marshaller = new DeleteHostedZoneRequestMarshaller();
            var unmarshaller = DeleteHostedZoneResponseUnmarshaller.Instance;

            return Invoke<DeleteHostedZoneRequest,DeleteHostedZoneResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DeleteHostedZoneResponse> DeleteHostedZoneAsync(DeleteHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHostedZoneRequestMarshaller();
            var unmarshaller = DeleteHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHostedZoneRequest,DeleteHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// submit a <a>GetReusableDelegationSet</a> request and specify the ID of the reusable
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
        public DeleteReusableDelegationSetResponse DeleteReusableDelegationSet(DeleteReusableDelegationSetRequest request)
        {
            var marshaller = new DeleteReusableDelegationSetRequestMarshaller();
            var unmarshaller = DeleteReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteReusableDelegationSetRequest,DeleteReusableDelegationSetResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DeleteReusableDelegationSetResponse> DeleteReusableDelegationSetAsync(DeleteReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteReusableDelegationSetRequestMarshaller();
            var unmarshaller = DeleteReusableDelegationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReusableDelegationSetRequest,DeleteReusableDelegationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrafficPolicy


        /// <summary>
        /// Deletes a traffic policy.
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
        public DeleteTrafficPolicyResponse DeleteTrafficPolicy(DeleteTrafficPolicyRequest request)
        {
            var marshaller = new DeleteTrafficPolicyRequestMarshaller();
            var unmarshaller = DeleteTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteTrafficPolicyRequest,DeleteTrafficPolicyResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DeleteTrafficPolicyResponse> DeleteTrafficPolicyAsync(DeleteTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTrafficPolicyRequestMarshaller();
            var unmarshaller = DeleteTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrafficPolicyRequest,DeleteTrafficPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrafficPolicyInstance


        /// <summary>
        /// Deletes a traffic policy instance and all of the resource record sets that Amazon
        /// Route 53 created when you created the instance.
        /// 
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
        public DeleteTrafficPolicyInstanceResponse DeleteTrafficPolicyInstance(DeleteTrafficPolicyInstanceRequest request)
        {
            var marshaller = new DeleteTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = DeleteTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteTrafficPolicyInstanceRequest,DeleteTrafficPolicyInstanceResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DeleteTrafficPolicyInstanceResponse> DeleteTrafficPolicyInstanceAsync(DeleteTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = DeleteTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrafficPolicyInstanceRequest,DeleteTrafficPolicyInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteVPCAssociationAuthorizationResponse DeleteVPCAssociationAuthorization(DeleteVPCAssociationAuthorizationRequest request)
        {
            var marshaller = new DeleteVPCAssociationAuthorizationRequestMarshaller();
            var unmarshaller = DeleteVPCAssociationAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteVPCAssociationAuthorizationRequest,DeleteVPCAssociationAuthorizationResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DeleteVPCAssociationAuthorizationResponse> DeleteVPCAssociationAuthorizationAsync(DeleteVPCAssociationAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVPCAssociationAuthorizationRequestMarshaller();
            var unmarshaller = DeleteVPCAssociationAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVPCAssociationAuthorizationRequest,DeleteVPCAssociationAuthorizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateVPCFromHostedZone


        /// <summary>
        /// Disassociates a VPC from a Amazon Route 53 private hosted zone. 
        /// 
        ///  <note> 
        /// <para>
        /// You can't disassociate the last VPC from a private hosted zone.
        /// </para>
        ///  </note> <important> 
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
        public DisassociateVPCFromHostedZoneResponse DisassociateVPCFromHostedZone(DisassociateVPCFromHostedZoneRequest request)
        {
            var marshaller = new DisassociateVPCFromHostedZoneRequestMarshaller();
            var unmarshaller = DisassociateVPCFromHostedZoneResponseUnmarshaller.Instance;

            return Invoke<DisassociateVPCFromHostedZoneRequest,DisassociateVPCFromHostedZoneResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DisassociateVPCFromHostedZoneResponse> DisassociateVPCFromHostedZoneAsync(DisassociateVPCFromHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateVPCFromHostedZoneRequestMarshaller();
            var unmarshaller = DisassociateVPCFromHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateVPCFromHostedZoneRequest,DisassociateVPCFromHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetChange


        /// <summary>
        /// Returns the current status of a change batch request. The status is one of the following
        /// values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>PENDING</code> indicates that the changes in this request have not propagated
        /// to all Amazon Route 53 DNS servers. This is the initial status of all change batch
        /// requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INSYNC</code> indicates that the changes have propagated to all Amazon Route
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
        public GetChangeResponse GetChange(GetChangeRequest request)
        {
            var marshaller = new GetChangeRequestMarshaller();
            var unmarshaller = GetChangeResponseUnmarshaller.Instance;

            return Invoke<GetChangeRequest,GetChangeResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetChangeResponse> GetChangeAsync(GetChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetChangeRequestMarshaller();
            var unmarshaller = GetChangeResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangeRequest,GetChangeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public GetCheckerIpRangesResponse GetCheckerIpRanges(GetCheckerIpRangesRequest request)
        {
            var marshaller = new GetCheckerIpRangesRequestMarshaller();
            var unmarshaller = GetCheckerIpRangesResponseUnmarshaller.Instance;

            return Invoke<GetCheckerIpRangesRequest,GetCheckerIpRangesResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetCheckerIpRangesResponse> GetCheckerIpRangesAsync(GetCheckerIpRangesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCheckerIpRangesRequestMarshaller();
            var unmarshaller = GetCheckerIpRangesResponseUnmarshaller.Instance;

            return InvokeAsync<GetCheckerIpRangesRequest,GetCheckerIpRangesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGeoLocation


        /// <summary>
        /// Gets information about whether a specified geographic location is supported for Amazon
        /// Route 53 geolocation resource record sets.
        /// 
        ///  
        /// <para>
        /// Use the following syntax to determine whether a continent is supported for geolocation:
        /// </para>
        ///  
        /// <para>
        ///  <code>GET /2013-04-01/geolocation?ContinentCode=<i>two-letter abbreviation for a
        /// continent</i> </code> 
        /// </para>
        ///  
        /// <para>
        /// Use the following syntax to determine whether a country is supported for geolocation:
        /// </para>
        ///  
        /// <para>
        ///  <code>GET /2013-04-01/geolocation?CountryCode=<i>two-character country code</i> </code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Use the following syntax to determine whether a subdivision of a country is supported
        /// for geolocation:
        /// </para>
        ///  
        /// <para>
        ///  <code>GET /2013-04-01/geolocation?CountryCode=<i>two-character country code</i>&amp;SubdivisionCode=<i>subdivision
        /// code</i> </code> 
        /// </para>
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
        public GetGeoLocationResponse GetGeoLocation(GetGeoLocationRequest request)
        {
            var marshaller = new GetGeoLocationRequestMarshaller();
            var unmarshaller = GetGeoLocationResponseUnmarshaller.Instance;

            return Invoke<GetGeoLocationRequest,GetGeoLocationResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetGeoLocationResponse> GetGeoLocationAsync(GetGeoLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetGeoLocationRequestMarshaller();
            var unmarshaller = GetGeoLocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetGeoLocationRequest,GetGeoLocationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheck


        /// <summary>
        /// Gets information about a specified health check.
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
        public GetHealthCheckResponse GetHealthCheck(GetHealthCheckRequest request)
        {
            var marshaller = new GetHealthCheckRequestMarshaller();
            var unmarshaller = GetHealthCheckResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckRequest,GetHealthCheckResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetHealthCheckResponse> GetHealthCheckAsync(GetHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHealthCheckRequestMarshaller();
            var unmarshaller = GetHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckRequest,GetHealthCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheckCount


        /// <summary>
        /// Retrieves the number of health checks that are associated with the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckCount service method, as returned by Route53.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHealthCheckCount">REST API Reference for GetHealthCheckCount Operation</seealso>
        public GetHealthCheckCountResponse GetHealthCheckCount(GetHealthCheckCountRequest request)
        {
            var marshaller = new GetHealthCheckCountRequestMarshaller();
            var unmarshaller = GetHealthCheckCountResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckCountRequest,GetHealthCheckCountResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetHealthCheckCountResponse> GetHealthCheckCountAsync(GetHealthCheckCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHealthCheckCountRequestMarshaller();
            var unmarshaller = GetHealthCheckCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckCountRequest,GetHealthCheckCountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheckLastFailureReason


        /// <summary>
        /// Gets the reason that a specified health check failed most recently.
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
        public GetHealthCheckLastFailureReasonResponse GetHealthCheckLastFailureReason(GetHealthCheckLastFailureReasonRequest request)
        {
            var marshaller = new GetHealthCheckLastFailureReasonRequestMarshaller();
            var unmarshaller = GetHealthCheckLastFailureReasonResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckLastFailureReasonRequest,GetHealthCheckLastFailureReasonResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetHealthCheckLastFailureReasonResponse> GetHealthCheckLastFailureReasonAsync(GetHealthCheckLastFailureReasonRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHealthCheckLastFailureReasonRequestMarshaller();
            var unmarshaller = GetHealthCheckLastFailureReasonResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckLastFailureReasonRequest,GetHealthCheckLastFailureReasonResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHealthCheckStatus


        /// <summary>
        /// Gets status of a specified health check.
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
        public GetHealthCheckStatusResponse GetHealthCheckStatus(GetHealthCheckStatusRequest request)
        {
            var marshaller = new GetHealthCheckStatusRequestMarshaller();
            var unmarshaller = GetHealthCheckStatusResponseUnmarshaller.Instance;

            return Invoke<GetHealthCheckStatusRequest,GetHealthCheckStatusResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetHealthCheckStatusResponse> GetHealthCheckStatusAsync(GetHealthCheckStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHealthCheckStatusRequestMarshaller();
            var unmarshaller = GetHealthCheckStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetHealthCheckStatusRequest,GetHealthCheckStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHostedZone


        /// <summary>
        /// Gets information about a specified hosted zone including the four name servers assigned
        /// to the hosted zone.
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
        public GetHostedZoneResponse GetHostedZone(GetHostedZoneRequest request)
        {
            var marshaller = new GetHostedZoneRequestMarshaller();
            var unmarshaller = GetHostedZoneResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneRequest,GetHostedZoneResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetHostedZoneResponse> GetHostedZoneAsync(GetHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHostedZoneRequestMarshaller();
            var unmarshaller = GetHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostedZoneRequest,GetHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHostedZoneCount


        /// <summary>
        /// Retrieves the number of hosted zones that are associated with the current AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZoneCount">REST API Reference for GetHostedZoneCount Operation</seealso>
        public GetHostedZoneCountResponse GetHostedZoneCount()
        {
            return GetHostedZoneCount(new GetHostedZoneCountRequest());
        }


        /// <summary>
        /// Retrieves the number of hosted zones that are associated with the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostedZoneCount service method.</param>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetHostedZoneCount">REST API Reference for GetHostedZoneCount Operation</seealso>
        public GetHostedZoneCountResponse GetHostedZoneCount(GetHostedZoneCountRequest request)
        {
            var marshaller = new GetHostedZoneCountRequestMarshaller();
            var unmarshaller = GetHostedZoneCountResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneCountRequest,GetHostedZoneCountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves the number of hosted zones that are associated with the current AWS account.
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
        public Task<GetHostedZoneCountResponse> GetHostedZoneCountAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetHostedZoneCountAsync(new GetHostedZoneCountRequest(), cancellationToken);
        }
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
        public Task<GetHostedZoneCountResponse> GetHostedZoneCountAsync(GetHostedZoneCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetHostedZoneCountRequestMarshaller();
            var unmarshaller = GetHostedZoneCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostedZoneCountRequest,GetHostedZoneCountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetReusableDelegationSet


        /// <summary>
        /// Retrieves information about a specified reusable delegation set, including the four
        /// name servers that are assigned to the delegation set.
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
        public GetReusableDelegationSetResponse GetReusableDelegationSet(GetReusableDelegationSetRequest request)
        {
            var marshaller = new GetReusableDelegationSetRequestMarshaller();
            var unmarshaller = GetReusableDelegationSetResponseUnmarshaller.Instance;

            return Invoke<GetReusableDelegationSetRequest,GetReusableDelegationSetResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetReusableDelegationSetResponse> GetReusableDelegationSetAsync(GetReusableDelegationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetReusableDelegationSetRequestMarshaller();
            var unmarshaller = GetReusableDelegationSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetReusableDelegationSetRequest,GetReusableDelegationSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTrafficPolicy


        /// <summary>
        /// Gets information about a specific traffic policy version.
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
        public GetTrafficPolicyResponse GetTrafficPolicy(GetTrafficPolicyRequest request)
        {
            var marshaller = new GetTrafficPolicyRequestMarshaller();
            var unmarshaller = GetTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyRequest,GetTrafficPolicyResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetTrafficPolicyResponse> GetTrafficPolicyAsync(GetTrafficPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTrafficPolicyRequestMarshaller();
            var unmarshaller = GetTrafficPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyRequest,GetTrafficPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTrafficPolicyInstance


        /// <summary>
        /// Gets information about a specified traffic policy instance.
        /// 
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
        public GetTrafficPolicyInstanceResponse GetTrafficPolicyInstance(GetTrafficPolicyInstanceRequest request)
        {
            var marshaller = new GetTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = GetTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyInstanceRequest,GetTrafficPolicyInstanceResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetTrafficPolicyInstanceResponse> GetTrafficPolicyInstanceAsync(GetTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = GetTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyInstanceRequest,GetTrafficPolicyInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTrafficPolicyInstanceCount


        /// <summary>
        /// Gets the number of traffic policy instances that are associated with the current AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicyInstanceCount service method.</param>
        /// 
        /// <returns>The response from the GetTrafficPolicyInstanceCount service method, as returned by Route53.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/GetTrafficPolicyInstanceCount">REST API Reference for GetTrafficPolicyInstanceCount Operation</seealso>
        public GetTrafficPolicyInstanceCountResponse GetTrafficPolicyInstanceCount(GetTrafficPolicyInstanceCountRequest request)
        {
            var marshaller = new GetTrafficPolicyInstanceCountRequestMarshaller();
            var unmarshaller = GetTrafficPolicyInstanceCountResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyInstanceCountRequest,GetTrafficPolicyInstanceCountResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetTrafficPolicyInstanceCountResponse> GetTrafficPolicyInstanceCountAsync(GetTrafficPolicyInstanceCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTrafficPolicyInstanceCountRequestMarshaller();
            var unmarshaller = GetTrafficPolicyInstanceCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyInstanceCountRequest,GetTrafficPolicyInstanceCountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGeoLocations


        /// <summary>
        /// Retrieves a list of supported geo locations.
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
        public ListGeoLocationsResponse ListGeoLocations()
        {
            return ListGeoLocations(new ListGeoLocationsRequest());
        }


        /// <summary>
        /// Retrieves a list of supported geo locations.
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
        public ListGeoLocationsResponse ListGeoLocations(ListGeoLocationsRequest request)
        {
            var marshaller = new ListGeoLocationsRequestMarshaller();
            var unmarshaller = ListGeoLocationsResponseUnmarshaller.Instance;

            return Invoke<ListGeoLocationsRequest,ListGeoLocationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves a list of supported geo locations.
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
        public Task<ListGeoLocationsResponse> ListGeoLocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListGeoLocationsAsync(new ListGeoLocationsRequest(), cancellationToken);
        }
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
        public Task<ListGeoLocationsResponse> ListGeoLocationsAsync(ListGeoLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListGeoLocationsRequestMarshaller();
            var unmarshaller = ListGeoLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGeoLocationsRequest,ListGeoLocationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHealthChecks


        /// <summary>
        /// Retrieve a list of the health checks that are associated with the current AWS account.
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
        public ListHealthChecksResponse ListHealthChecks()
        {
            return ListHealthChecks(new ListHealthChecksRequest());
        }


        /// <summary>
        /// Retrieve a list of the health checks that are associated with the current AWS account.
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
        public ListHealthChecksResponse ListHealthChecks(ListHealthChecksRequest request)
        {
            var marshaller = new ListHealthChecksRequestMarshaller();
            var unmarshaller = ListHealthChecksResponseUnmarshaller.Instance;

            return Invoke<ListHealthChecksRequest,ListHealthChecksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieve a list of the health checks that are associated with the current AWS account.
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
        public Task<ListHealthChecksResponse> ListHealthChecksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListHealthChecksAsync(new ListHealthChecksRequest(), cancellationToken);
        }
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
        public Task<ListHealthChecksResponse> ListHealthChecksAsync(ListHealthChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListHealthChecksRequestMarshaller();
            var unmarshaller = ListHealthChecksResponseUnmarshaller.Instance;

            return InvokeAsync<ListHealthChecksRequest,ListHealthChecksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHostedZones


        /// <summary>
        /// Retrieves a list of the public and private hosted zones that are associated with the
        /// current AWS account. The response includes a <code>HostedZones</code> child element
        /// for each hosted zone.
        /// 
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of hosted zones, you can use the <code>maxitems</code> parameter to list them in groups
        /// of up to 100.
        /// </para>
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
        public ListHostedZonesResponse ListHostedZones()
        {
            return ListHostedZones(new ListHostedZonesRequest());
        }


        /// <summary>
        /// Retrieves a list of the public and private hosted zones that are associated with the
        /// current AWS account. The response includes a <code>HostedZones</code> child element
        /// for each hosted zone.
        /// 
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of hosted zones, you can use the <code>maxitems</code> parameter to list them in groups
        /// of up to 100.
        /// </para>
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
        public ListHostedZonesResponse ListHostedZones(ListHostedZonesRequest request)
        {
            var marshaller = new ListHostedZonesRequestMarshaller();
            var unmarshaller = ListHostedZonesResponseUnmarshaller.Instance;

            return Invoke<ListHostedZonesRequest,ListHostedZonesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves a list of the public and private hosted zones that are associated with the
        /// current AWS account. The response includes a <code>HostedZones</code> child element
        /// for each hosted zone.
        /// 
        ///  
        /// <para>
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of hosted zones, you can use the <code>maxitems</code> parameter to list them in groups
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
        public Task<ListHostedZonesResponse> ListHostedZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListHostedZonesAsync(new ListHostedZonesRequest(), cancellationToken);
        }
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
        public Task<ListHostedZonesResponse> ListHostedZonesAsync(ListHostedZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListHostedZonesRequestMarshaller();
            var unmarshaller = ListHostedZonesResponseUnmarshaller.Instance;

            return InvokeAsync<ListHostedZonesRequest,ListHostedZonesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHostedZonesByName


        /// <summary>
        /// Retrieves a list of your hosted zones in lexicographic order. The response includes
        /// a <code>HostedZones</code> child element for each hosted zone created by the current
        /// AWS account. 
        /// 
        ///  
        /// <para>
        ///  <code>ListHostedZonesByName</code> sorts hosted zones by name with the labels reversed.
        /// For example:
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
        /// If the domain name includes escape characters or Punycode, <code>ListHostedZonesByName</code>
        /// alphabetizes the domain name using the escaped or Punycoded value, which is the format
        /// that Amazon Route 53 saves in its database. For example, to create a hosted zone for
        /// exämple.com, you specify ex\344mple.com for the domain name. <code>ListHostedZonesByName</code>
        /// alphabetizes it as:
        /// </para>
        ///  
        /// <para>
        ///  <code>com.ex\344mple.</code> 
        /// </para>
        ///  
        /// <para>
        /// The labels are reversed and alphabetized using the escaped value. For more information
        /// about valid domain name formats, including internationalized domain names, see <a
        /// href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html">DNS
        /// Domain Name Format</a> in the <i>Amazon Route 53 Developer Guide</i>.
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
        public ListHostedZonesByNameResponse ListHostedZonesByName(ListHostedZonesByNameRequest request)
        {
            var marshaller = new ListHostedZonesByNameRequestMarshaller();
            var unmarshaller = ListHostedZonesByNameResponseUnmarshaller.Instance;

            return Invoke<ListHostedZonesByNameRequest,ListHostedZonesByNameResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListHostedZonesByNameResponse> ListHostedZonesByNameAsync(ListHostedZonesByNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListHostedZonesByNameRequestMarshaller();
            var unmarshaller = ListHostedZonesByNameResponseUnmarshaller.Instance;

            return InvokeAsync<ListHostedZonesByNameRequest,ListHostedZonesByNameResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public ListResourceRecordSetsResponse ListResourceRecordSets(ListResourceRecordSetsRequest request)
        {
            var marshaller = new ListResourceRecordSetsRequestMarshaller();
            var unmarshaller = ListResourceRecordSetsResponseUnmarshaller.Instance;

            return Invoke<ListResourceRecordSetsRequest,ListResourceRecordSetsResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListResourceRecordSetsResponse> ListResourceRecordSetsAsync(ListResourceRecordSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListResourceRecordSetsRequestMarshaller();
            var unmarshaller = ListResourceRecordSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceRecordSetsRequest,ListResourceRecordSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListReusableDelegationSets


        /// <summary>
        /// Retrieves a list of the reusable delegation sets that are associated with the current
        /// AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListReusableDelegationSets">REST API Reference for ListReusableDelegationSets Operation</seealso>
        public ListReusableDelegationSetsResponse ListReusableDelegationSets()
        {
            return ListReusableDelegationSets(new ListReusableDelegationSetsRequest());
        }


        /// <summary>
        /// Retrieves a list of the reusable delegation sets that are associated with the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReusableDelegationSets service method.</param>
        /// 
        /// <returns>The response from the ListReusableDelegationSets service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListReusableDelegationSets">REST API Reference for ListReusableDelegationSets Operation</seealso>
        public ListReusableDelegationSetsResponse ListReusableDelegationSets(ListReusableDelegationSetsRequest request)
        {
            var marshaller = new ListReusableDelegationSetsRequestMarshaller();
            var unmarshaller = ListReusableDelegationSetsResponseUnmarshaller.Instance;

            return Invoke<ListReusableDelegationSetsRequest,ListReusableDelegationSetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves a list of the reusable delegation sets that are associated with the current
        /// AWS account.
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
        public Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListReusableDelegationSetsAsync(new ListReusableDelegationSetsRequest(), cancellationToken);
        }
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
        public Task<ListReusableDelegationSetsResponse> ListReusableDelegationSetsAsync(ListReusableDelegationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListReusableDelegationSetsRequestMarshaller();
            var unmarshaller = ListReusableDelegationSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReusableDelegationSetsRequest,ListReusableDelegationSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public ListTagsForResourcesResponse ListTagsForResources(ListTagsForResourcesRequest request)
        {
            var marshaller = new ListTagsForResourcesRequestMarshaller();
            var unmarshaller = ListTagsForResourcesResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourcesRequest,ListTagsForResourcesResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListTagsForResourcesResponse> ListTagsForResourcesAsync(ListTagsForResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourcesRequestMarshaller();
            var unmarshaller = ListTagsForResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourcesRequest,ListTagsForResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicies


        /// <summary>
        /// Gets information about the latest version for every traffic policy that is associated
        /// with the current AWS account. Policies are listed in the order in which they were
        /// created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicies service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-2013-04-01/ListTrafficPolicies">REST API Reference for ListTrafficPolicies Operation</seealso>
        public ListTrafficPoliciesResponse ListTrafficPolicies(ListTrafficPoliciesRequest request)
        {
            var marshaller = new ListTrafficPoliciesRequestMarshaller();
            var unmarshaller = ListTrafficPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPoliciesRequest,ListTrafficPoliciesResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListTrafficPoliciesResponse> ListTrafficPoliciesAsync(ListTrafficPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPoliciesRequestMarshaller();
            var unmarshaller = ListTrafficPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPoliciesRequest,ListTrafficPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of traffic policy instances, you can use the <code>MaxItems</code> parameter to list
        /// them in groups of up to 100.
        /// </para>
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
        public ListTrafficPolicyInstancesResponse ListTrafficPolicyInstances(ListTrafficPolicyInstancesRequest request)
        {
            var marshaller = new ListTrafficPolicyInstancesRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyInstancesRequest,ListTrafficPolicyInstancesResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListTrafficPolicyInstancesResponse> ListTrafficPolicyInstancesAsync(ListTrafficPolicyInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPolicyInstancesRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyInstancesRequest,ListTrafficPolicyInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyInstancesByHostedZone


        /// <summary>
        /// Gets information about the traffic policy instances that you created in a specified
        /// hosted zone.
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
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of traffic policy instances, you can use the <code>MaxItems</code> parameter to list
        /// them in groups of up to 100.
        /// </para>
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
        public ListTrafficPolicyInstancesByHostedZoneResponse ListTrafficPolicyInstancesByHostedZone(ListTrafficPolicyInstancesByHostedZoneRequest request)
        {
            var marshaller = new ListTrafficPolicyInstancesByHostedZoneRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesByHostedZoneResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyInstancesByHostedZoneRequest,ListTrafficPolicyInstancesByHostedZoneResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListTrafficPolicyInstancesByHostedZoneResponse> ListTrafficPolicyInstancesByHostedZoneAsync(ListTrafficPolicyInstancesByHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPolicyInstancesByHostedZoneRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesByHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyInstancesByHostedZoneRequest,ListTrafficPolicyInstancesByHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
        /// of traffic policy instances, you can use the <code>MaxItems</code> parameter to list
        /// them in groups of up to 100.
        /// </para>
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
        public ListTrafficPolicyInstancesByPolicyResponse ListTrafficPolicyInstancesByPolicy(ListTrafficPolicyInstancesByPolicyRequest request)
        {
            var marshaller = new ListTrafficPolicyInstancesByPolicyRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesByPolicyResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyInstancesByPolicyRequest,ListTrafficPolicyInstancesByPolicyResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListTrafficPolicyInstancesByPolicyResponse> ListTrafficPolicyInstancesByPolicyAsync(ListTrafficPolicyInstancesByPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPolicyInstancesByPolicyRequestMarshaller();
            var unmarshaller = ListTrafficPolicyInstancesByPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyInstancesByPolicyRequest,ListTrafficPolicyInstancesByPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTrafficPolicyVersions


        /// <summary>
        /// Gets information about all of the versions for a specified traffic policy.
        /// 
        ///  
        /// <para>
        /// Traffic policy versions are listed in numerical order by <code>VersionNumber</code>.
        /// </para>
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
        public ListTrafficPolicyVersionsResponse ListTrafficPolicyVersions(ListTrafficPolicyVersionsRequest request)
        {
            var marshaller = new ListTrafficPolicyVersionsRequestMarshaller();
            var unmarshaller = ListTrafficPolicyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPolicyVersionsRequest,ListTrafficPolicyVersionsResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListTrafficPolicyVersionsResponse> ListTrafficPolicyVersionsAsync(ListTrafficPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPolicyVersionsRequestMarshaller();
            var unmarshaller = ListTrafficPolicyVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyVersionsRequest,ListTrafficPolicyVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListVPCAssociationAuthorizations


        /// <summary>
        /// Gets a list of the VPCs that were created by other accounts and that can be associated
        /// with a specified hosted zone because you've submitted one or more <code>CreateVPCAssociationAuthorization</code>
        /// requests. 
        /// 
        ///  
        /// <para>
        /// The response includes a <code>VPCs</code> element with a <code>VPC</code> child element
        /// for each VPC that can be associated with the hosted zone.
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
        public ListVPCAssociationAuthorizationsResponse ListVPCAssociationAuthorizations(ListVPCAssociationAuthorizationsRequest request)
        {
            var marshaller = new ListVPCAssociationAuthorizationsRequestMarshaller();
            var unmarshaller = ListVPCAssociationAuthorizationsResponseUnmarshaller.Instance;

            return Invoke<ListVPCAssociationAuthorizationsRequest,ListVPCAssociationAuthorizationsResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListVPCAssociationAuthorizationsResponse> ListVPCAssociationAuthorizationsAsync(ListVPCAssociationAuthorizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListVPCAssociationAuthorizationsRequestMarshaller();
            var unmarshaller = ListVPCAssociationAuthorizationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVPCAssociationAuthorizationsRequest,ListVPCAssociationAuthorizationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public TestDNSAnswerResponse TestDNSAnswer(TestDNSAnswerRequest request)
        {
            var marshaller = new TestDNSAnswerRequestMarshaller();
            var unmarshaller = TestDNSAnswerResponseUnmarshaller.Instance;

            return Invoke<TestDNSAnswerRequest,TestDNSAnswerResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<TestDNSAnswerResponse> TestDNSAnswerAsync(TestDNSAnswerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TestDNSAnswerRequestMarshaller();
            var unmarshaller = TestDNSAnswerResponseUnmarshaller.Instance;

            return InvokeAsync<TestDNSAnswerRequest,TestDNSAnswerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateHealthCheck


        /// <summary>
        /// Updates an existing health check. Note that some values can't be updated. 
        /// 
        ///  
        /// <para>
        /// For more information about updating health checks, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/health-checks-creating-deleting.html">Creating,
        /// Updating, and Deleting Health Checks</a> in the <i>Amazon Route 53 Developer Guide</i>.
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
        public UpdateHealthCheckResponse UpdateHealthCheck(UpdateHealthCheckRequest request)
        {
            var marshaller = new UpdateHealthCheckRequestMarshaller();
            var unmarshaller = UpdateHealthCheckResponseUnmarshaller.Instance;

            return Invoke<UpdateHealthCheckRequest,UpdateHealthCheckResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<UpdateHealthCheckResponse> UpdateHealthCheckAsync(UpdateHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateHealthCheckRequestMarshaller();
            var unmarshaller = UpdateHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHealthCheckRequest,UpdateHealthCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateHostedZoneComment


        /// <summary>
        /// Updates the comment for a specified hosted zone.
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
        public UpdateHostedZoneCommentResponse UpdateHostedZoneComment(UpdateHostedZoneCommentRequest request)
        {
            var marshaller = new UpdateHostedZoneCommentRequestMarshaller();
            var unmarshaller = UpdateHostedZoneCommentResponseUnmarshaller.Instance;

            return Invoke<UpdateHostedZoneCommentRequest,UpdateHostedZoneCommentResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<UpdateHostedZoneCommentResponse> UpdateHostedZoneCommentAsync(UpdateHostedZoneCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateHostedZoneCommentRequestMarshaller();
            var unmarshaller = UpdateHostedZoneCommentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateHostedZoneCommentRequest,UpdateHostedZoneCommentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrafficPolicyComment


        /// <summary>
        /// Updates the comment for a specified traffic policy version.
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
        public UpdateTrafficPolicyCommentResponse UpdateTrafficPolicyComment(UpdateTrafficPolicyCommentRequest request)
        {
            var marshaller = new UpdateTrafficPolicyCommentRequestMarshaller();
            var unmarshaller = UpdateTrafficPolicyCommentResponseUnmarshaller.Instance;

            return Invoke<UpdateTrafficPolicyCommentRequest,UpdateTrafficPolicyCommentResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<UpdateTrafficPolicyCommentResponse> UpdateTrafficPolicyCommentAsync(UpdateTrafficPolicyCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTrafficPolicyCommentRequestMarshaller();
            var unmarshaller = UpdateTrafficPolicyCommentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrafficPolicyCommentRequest,UpdateTrafficPolicyCommentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrafficPolicyInstance


        /// <summary>
        /// Updates the resource record sets in a specified hosted zone that were created based
        /// on the settings in a specified traffic policy version.
        /// 
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
        /// traffic policy. This is true regardless of how significant the differences are between
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
        public UpdateTrafficPolicyInstanceResponse UpdateTrafficPolicyInstance(UpdateTrafficPolicyInstanceRequest request)
        {
            var marshaller = new UpdateTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = UpdateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateTrafficPolicyInstanceRequest,UpdateTrafficPolicyInstanceResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<UpdateTrafficPolicyInstanceResponse> UpdateTrafficPolicyInstanceAsync(UpdateTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = UpdateTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrafficPolicyInstanceRequest,UpdateTrafficPolicyInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}