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
        /// The VPC and the hosted zone must already exist, and you must have created a private
        /// hosted zone. You cannot convert a public hosted zone into a private hosted zone.
        /// </para>
        ///  </important> 
        /// <para>
        /// Send a <code>POST</code> request to the <code>/<i>Amazon Route 53 API version</i>/hostedzone/<i>hosted
        /// zone ID</i>/associatevpc</code> resource. The request body must include an XML document
        /// with a <code>AssociateVPCWithHostedZoneRequest</code> element. The response returns
        /// the <code>AssociateVPCWithHostedZoneResponse</code> element.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you used different accounts to create the hosted zone and to create the Amazon
        /// VPCs that you want to associate with the hosted zone, we need to update account permissions
        /// for you. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/hosted-zone-private-associate-vpcs-different-accounts.html">Associating
        /// Amazon VPCs and Private Hosted Zones That You Create with Different AWS Accounts</a>
        /// in the Amazon Route 53 Developer Guide.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVPCWithHostedZone service method.</param>
        /// 
        /// <returns>The response from the AssociateVPCWithHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.ConflictingDomainExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
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
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.PublicZoneVPCAssociationException">
        /// The hosted zone specified in <code>HostedZoneId</code> is a public hosted zone.
        /// </exception>
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
        /// The request body must include a document with a <code>ChangeResourceRecordSetsRequest</code>
        /// element. The request body contains a list of change items, known as a change batch.
        /// Change batches are considered transactional changes. When using the Amazon Route 53
        /// API to change resource record sets, Amazon Route 53 either makes all or none of the
        /// changes in a change batch request. This ensures that Amazon Route 53 never partially
        /// implements the intended changes to the resource record sets in a hosted zone. 
        /// </para>
        ///  
        /// <para>
        /// For example, a change batch request that deletes the <code>CNAME</code>record for
        /// www.example.com and creates an alias resource record set for www.example.com. Amazon
        /// Route 53 deletes the first resource record set and creates the second resource record
        /// set in a single operation. If either the <code>DELETE</code> or the <code>CREATE</code>
        /// action fails, then both changes (plus any other changes in the batch) fail, and the
        /// original <code>CNAME</code> record continues to exist.
        /// </para>
        ///  <important> 
        /// <para>
        /// Due to the nature of transactional changes, you cannot delete the same resource record
        /// set more than once in a single change batch. If you attempt to delete the same change
        /// batch more than once, Amazon Route 53 returns an <code>InvalidChangeBatch</code> error.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// To create resource record sets for complex routing configurations, use either the
        /// traffic flow visual editor in the Amazon Route 53 console or the API actions for traffic
        /// policies and traffic policy instances. Save the configuration as a traffic policy,
        /// then associate the traffic policy with one or more domain names (such as example.com)
        /// or subdomain names (such as www.example.com), in the same hosted zone or in multiple
        /// hosted zones. You can roll back the updates if the new configuration isn't performing
        /// as expected. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/traffic-flow.html">Using
        /// Traffic Flow to Route DNS Traffic</a> in the Amazon Route 53 API Reference or <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/actions-on-polices">Actions
        /// on Traffic Policies and Traffic Policy Instances</a> in this guide.
        /// </para>
        ///  </note> 
        /// <para>
        /// Use <code>ChangeResourceRecordsSetsRequest</code> to perform the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATE</code>:Creates a resource record set that has the specified values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE</code>: Deletes an existing resource record set that has the specified
        /// values for <code>Name</code>, <code>Type</code>, <code>Set Identifier</code> (for
        /// code latency, weighted, geolocation, and failover resource record sets), and <code>TTL</code>
        /// (except alias resource record sets, for which the TTL is determined by the AWS resource
        /// you're routing queries to).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPSERT</code>: If a resource record set does not already exist, AWS creates
        /// it. If a resource set does exist, Amazon Route 53 updates it with the values in the
        /// request. Amazon Route 53 can update an existing resource record set only when all
        /// of the following values match: <code>Name</code>, <code>Type</code>, and <code>Set
        /// Identifier</code> (for weighted, latency, geolocation, and failover resource record
        /// sets).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In response to a <code>ChangeResourceRecordSets</code> request, the DNS data is changed
        /// on all Amazon Route 53 DNS servers. Initially, the status of a change is <code>PENDING</code>,
        /// meaning the change has not yet propagated to all the authoritative Amazon Route 53
        /// DNS servers. When the change is propagated to all hosts, the change returns a status
        /// of <code>INSYNC</code>.
        /// </para>
        ///  
        /// <para>
        /// After sending a change request, confirm your change has propagated to all Amazon Route
        /// 53 DNS servers. Changes generally propagate to all Amazon Route 53 name servers in
        /// a few minutes. In rare circumstances, propagation can take up to 30 minutes. For more
        /// information, see <a>GetChange</a>.
        /// </para>
        ///  
        /// <para>
        /// Note the following limitations on a <code>ChangeResourceRecordSets</code> request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  A request cannot contain more than 100 Change elements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  A request cannot contain more than 1000 ResourceRecord elements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The sum of the number of characters (including spaces) in all <code>Value</code> elements
        /// in a request cannot exceed 32,000 characters.
        /// </para>
        ///  </li> <li> <note> 
        /// <para>
        /// If the value of the Action element in a ChangeResourceRecordSets request is <code>UPSERT</code>
        /// and the resource record set already exists, Amazon Route 53 automatically performs
        /// a <code>DELETE</code> request and a <code>CREATE</code> request. When Amazon Route
        /// 53 calculates the number of characters in the Value elements of a change batch request,
        /// it adds the number of characters in the Value element of the resource record set being
        /// deleted and the number of characters in the Value element of the resource record set
        /// being created.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The same resource cannot be deleted more than once in a single batch.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If the value of the Action element in a ChangeResourceRecordSets request is <code>UPSERT</code>
        /// and the resource record set already exists, Amazon Route 53 automatically performs
        /// a <code>DELETE</code> request and a <code>CREATE</code> request. When Amazon Route
        /// 53 calculates the number of characters in the Value elements of a change batch request,
        /// it adds the number of characters in the Value element of the resource record set being
        /// deleted and the number of characters in the Value element of the resource record set
        /// being created.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on transactional changes, see <a>ChangeResourceRecordSets</a>.
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
        /// 
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
        /// 
        /// </exception>
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
        /// To create a new health check, send a <code>POST</code> request to the <code>/2013-04-01/healthcheck</code>
        /// resource. The request body must include an XML document with a <code>CreateHealthCheckRequest</code>
        /// element. The response returns the <code>CreateHealthCheckResponse</code> element,
        /// containing the health check ID specified when adding health check to a resource record
        /// set. For information about adding health checks to resource record sets, see <a>ResourceRecordSet$HealthCheckId</a>
        /// in <a>ChangeResourceRecordSets</a>. 
        /// </para>
        ///  
        /// <para>
        /// If you are registering Amazon EC2 instances with an Elastic Load Balancing (ELB) load
        /// balancer, do not create Amazon Route 53 health checks for the Amazon EC2 instances.
        /// When you register an Amazon EC2 instance with a load balancer, you configure settings
        /// for an ELB health check, which performs a similar function to an Amazon Route 53 health
        /// check.
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
        /// CloudWatch Developer Guide</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the CreateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckAlreadyExistsException">
        /// The health check you're attempting to create already exists.
        /// 
        ///  
        /// <para>
        /// Amazon Route 53 returns this error when a health check has already been created with
        /// the specified value for <code>CallerReference</code>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyHealthChecksException">
        /// 
        /// </exception>
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
        /// Creates a new public hosted zone, used to specify how the Domain Name System (DNS)
        /// routes traffic on the Internet for a domain, such as example.com, and its subdomains.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// Public hosted zones cannot be converted to a private hosted zone or vice versa. Instead,
        /// create a new hosted zone with the same name and create new resource record sets.
        /// </para>
        ///  </important> 
        /// <para>
        /// Send a <code>POST</code> request to the <code>/<i>Amazon Route 53 API version</i>/hostedzone</code>
        /// resource. The request body must include an XML document with a <code>CreateHostedZoneRequest</code>
        /// element. The response returns the <code>CreateHostedZoneResponse</code> element containing
        /// metadata about the hosted zone.
        /// </para>
        ///  
        /// <para>
        /// Fore more information about charges for hosted zones, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/pricing/">AmazonAmazon
        /// Route 53 Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot create a hosted zone for a top-level domain (TLD).
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
        /// You can create a hosted zone that has the same name as an existing hosted zone (example.com
        /// is common), but there is a limit to the number of hosted zones that have the same
        /// name. If you get this error, Amazon Route 53 has reached that limit. If you own the
        /// domain name and Amazon Route 53 generates this error, contact Customer Support.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.DelegationSetNotReusableException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.HostedZoneAlreadyExistsException">
        /// The hosted zone you are trying to create already exists. Amazon Route 53 returns this
        /// error when a hosted zone has already been created with the specified <code>CallerReference</code>.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidDomainNameException">
        /// The specified domain name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidVPCIdException">
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Amazon
        /// Route 53 returns this error when the VPC specified by <code>VPCId</code> does not
        /// belong to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchDelegationSetException">
        /// A reusable delegation set with the specified ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.TooManyHostedZonesException">
        /// This hosted zone cannot be created because the hosted zone limit is exceeded. To request
        /// a limit increase, go to the Amazon Route 53 <a href="http://aws.amazon.com/route53-request/">Contact
        /// Us</a> page.
        /// </exception>
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
        /// Creates a delegation set (a group of four anem servers) that can be reused by multiple
        /// hosted zones. If a hosted zoned ID is specified, <code>CreateReusableDelegationSet</code>
        /// marks the delegation set associated with that zone as reusable
        /// 
        ///  
        /// <para>
        /// Send a <code>POST</code> request to the <code>/<i>Amazon Route 53 API version</i>/delegationset</code>
        /// resource. The request body must include an XML document with a <code>CreateReusableDelegationSetRequest</code>
        /// element.
        /// </para>
        ///  <note> 
        /// <para>
        /// A reusable delegation set cannot be associated with a private hosted zone/
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
        /// The specified HostedZone cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidArgumentException">
        /// Parameter name and problem.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LimitsExceededException">
        /// The limits specified for a resource have been exceeded.
        /// </exception>
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
        /// 
        ///  
        /// <para>
        /// Send a <code>POST</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicy</code>
        /// resource. The request body must include a document with a <code>CreateTrafficPolicyRequest</code>
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
        /// 
        ///  
        /// <para>
        /// Send a <code>POST</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicyinstance</code>
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
        /// 
        ///  
        /// <para>
        /// Send a <code>POST</code> request to the <code>/<i>Amazon Route 53 version</i>/trafficpolicy/</code>
        /// resource. The request body includes a document with a <code>CreateTrafficPolicyVersionRequest</code>
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
        public Task<CreateTrafficPolicyVersionResponse> CreateTrafficPolicyVersionAsync(CreateTrafficPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrafficPolicyVersionRequestMarshaller();
            var unmarshaller = CreateTrafficPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrafficPolicyVersionRequest,CreateTrafficPolicyVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// of the health check cannot be predicted and may change. This will affect the routing
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
        public Task<DeleteTrafficPolicyInstanceResponse> DeleteTrafficPolicyInstanceAsync(DeleteTrafficPolicyInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTrafficPolicyInstanceRequestMarshaller();
            var unmarshaller = DeleteTrafficPolicyInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrafficPolicyInstanceRequest,DeleteTrafficPolicyInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateVPCFromHostedZone


        /// <summary>
        /// Disassociates a VPC from a Amazon Route 53 private hosted zone. 
        /// 
        ///  
        /// <para>
        /// Send a <code>POST</code> request to the <code>/<i>Amazon Route 53 API version</i>/hostedzone/<i>hosted
        /// zone ID</i>/disassociatevpc</code> resource. The request body must include an XML
        /// document with a <code>DisassociateVPCFromHostedZoneRequest</code> element. The response
        /// returns the <code>DisassociateVPCFromHostedZoneResponse</code> element.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can only disassociate a VPC from a private hosted zone when two or more VPCs are
        /// associated with that hosted zone. You cannot convert a private hosted zone into a
        /// public hosted zone.
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
        /// The hosted zone you are trying to create for your VPC_ID does not belong to you. Amazon
        /// Route 53 returns this error when the VPC specified by <code>VPCId</code> does not
        /// belong to you.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.LastVPCAssociationException">
        /// Only one VPC is currently associated with the hosted zone. You cannot convert a private
        /// hosted zone into a public hosted zone by disassociating the last VPC from a hosted
        /// zone.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.VPCAssociationNotFoundException">
        /// The specified VPC and hosted zone are not currently associated.
        /// </exception>
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
        /// 
        /// </exception>
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
        public Task<GetChangeResponse> GetChangeAsync(GetChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetChangeRequestMarshaller();
            var unmarshaller = GetChangeResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangeRequest,GetChangeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetChangeDetails


        /// <summary>
        /// Returns the status and changes of a change batch request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeDetails service method.</param>
        /// 
        /// <returns>The response from the GetChangeDetails service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchChangeException">
        /// 
        /// </exception>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        public GetChangeDetailsResponse GetChangeDetails(GetChangeDetailsRequest request)
        {
            var marshaller = new GetChangeDetailsRequestMarshaller();
            var unmarshaller = GetChangeDetailsResponseUnmarshaller.Instance;

            return Invoke<GetChangeDetailsRequest,GetChangeDetailsResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetChangeDetailsResponse> GetChangeDetailsAsync(GetChangeDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetChangeDetailsRequestMarshaller();
            var unmarshaller = GetChangeDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangeDetailsRequest,GetChangeDetailsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCheckerIpRanges


        /// <summary>
        /// Retrieves a list of the IP ranges used by Amazon Route 53 health checkers to check
        /// the health of your resources. Send a <code>GET</code> request to the <code>/<i>Amazon
        /// Route 53 API version</i>/checkeripranges</code> resource. Use these IP addresses to
        /// configure router and firewall rules to allow health checkers to check the health of
        /// your resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCheckerIpRanges service method.</param>
        /// 
        /// <returns>The response from the GetCheckerIpRanges service method, as returned by Route53.</returns>
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
        /// Gets information about a specified health check. Send a <code>GET</code> request to
        /// the <code>/2013-04-01/healthcheck/<i>health check ID</i> </code> resource. For more
        /// information about using the console to perform this operation, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover.html">Amazon
        /// Route 53 Health Checks and DNS Failover</a> in the Amazon Route 53 Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheck service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.IncompatibleVersionException">
        /// The resource you are trying to access is unsupported on this Amazon Route 53 endpoint.
        /// Please consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the ID that you specified in the <code>DeleteHealthCheck</code>
        /// request.
        /// </exception>
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
        /// To retrieve a count of all your health checks, send a <code>GET</code> request to
        /// the <code>/2013-04-01/healthcheckcount</code> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthCheckCount service method.</param>
        /// 
        /// <returns>The response from the GetHealthCheckCount service method, as returned by Route53.</returns>
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
        /// Retrieves a count of all your hosted zones. Send a <code>GET</code> request to the
        /// <code>/2013-04-01/hostedzonecount</code> resource.
        /// </summary>
        /// 
        /// <returns>The response from the GetHostedZoneCount service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        public GetHostedZoneCountResponse GetHostedZoneCount()
        {
            return GetHostedZoneCount(new GetHostedZoneCountRequest());
        }


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
        public GetHostedZoneCountResponse GetHostedZoneCount(GetHostedZoneCountRequest request)
        {
            var marshaller = new GetHostedZoneCountRequestMarshaller();
            var unmarshaller = GetHostedZoneCountResponseUnmarshaller.Instance;

            return Invoke<GetHostedZoneCountRequest,GetHostedZoneCountResponse>(request, marshaller, unmarshaller);
        }


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
        public Task<GetTrafficPolicyInstanceCountResponse> GetTrafficPolicyInstanceCountAsync(GetTrafficPolicyInstanceCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTrafficPolicyInstanceCountRequestMarshaller();
            var unmarshaller = GetTrafficPolicyInstanceCountResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrafficPolicyInstanceCountRequest,GetTrafficPolicyInstanceCountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListChangeBatchesByHostedZone


        /// <summary>
        /// Gets the list of ChangeBatches in a given time period for a given hosted zone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByHostedZone service method.</param>
        /// 
        /// <returns>The response from the ListChangeBatchesByHostedZone service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        public ListChangeBatchesByHostedZoneResponse ListChangeBatchesByHostedZone(ListChangeBatchesByHostedZoneRequest request)
        {
            var marshaller = new ListChangeBatchesByHostedZoneRequestMarshaller();
            var unmarshaller = ListChangeBatchesByHostedZoneResponseUnmarshaller.Instance;

            return Invoke<ListChangeBatchesByHostedZoneRequest,ListChangeBatchesByHostedZoneResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListChangeBatchesByHostedZoneResponse> ListChangeBatchesByHostedZoneAsync(ListChangeBatchesByHostedZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListChangeBatchesByHostedZoneRequestMarshaller();
            var unmarshaller = ListChangeBatchesByHostedZoneResponseUnmarshaller.Instance;

            return InvokeAsync<ListChangeBatchesByHostedZoneRequest,ListChangeBatchesByHostedZoneResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListChangeBatchesByRRSet


        /// <summary>
        /// Gets the list of ChangeBatches in a given time period for a given hosted zone and
        /// RRSet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeBatchesByRRSet service method.</param>
        /// 
        /// <returns>The response from the ListChangeBatchesByRRSet service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHostedZoneException">
        /// No hosted zone exists with the ID that you specified.
        /// </exception>
        [Obsolete("This operation is deprecated because it is an experimental feature not intended for use.")]
        public ListChangeBatchesByRRSetResponse ListChangeBatchesByRRSet(ListChangeBatchesByRRSetRequest request)
        {
            var marshaller = new ListChangeBatchesByRRSetRequestMarshaller();
            var unmarshaller = ListChangeBatchesByRRSetResponseUnmarshaller.Instance;

            return Invoke<ListChangeBatchesByRRSetRequest,ListChangeBatchesByRRSetResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListChangeBatchesByRRSetResponse> ListChangeBatchesByRRSetAsync(ListChangeBatchesByRRSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListChangeBatchesByRRSetRequestMarshaller();
            var unmarshaller = ListChangeBatchesByRRSetResponseUnmarshaller.Instance;

            return InvokeAsync<ListChangeBatchesByRRSetRequest,ListChangeBatchesByRRSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public ListGeoLocationsResponse ListGeoLocations()
        {
            return ListGeoLocations(new ListGeoLocationsRequest());
        }


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
        public ListGeoLocationsResponse ListGeoLocations(ListGeoLocationsRequest request)
        {
            var marshaller = new ListGeoLocationsRequestMarshaller();
            var unmarshaller = ListGeoLocationsResponseUnmarshaller.Instance;

            return Invoke<ListGeoLocationsRequest,ListGeoLocationsResponse>(request, marshaller, unmarshaller);
        }


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
        /// The resource you are trying to access is unsupported on this Amazon Route 53 endpoint.
        /// Please consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        public ListHealthChecksResponse ListHealthChecks()
        {
            return ListHealthChecks(new ListHealthChecksRequest());
        }


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
        /// The resource you are trying to access is unsupported on this Amazon Route 53 endpoint.
        /// Please consider using a newer endpoint or a tool that does so.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        public ListHealthChecksResponse ListHealthChecks(ListHealthChecksRequest request)
        {
            var marshaller = new ListHealthChecksRequestMarshaller();
            var unmarshaller = ListHealthChecksResponseUnmarshaller.Instance;

            return Invoke<ListHealthChecksRequest,ListHealthChecksResponse>(request, marshaller, unmarshaller);
        }


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
        public ListHostedZonesResponse ListHostedZones()
        {
            return ListHostedZones(new ListHostedZonesRequest());
        }


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
        public ListHostedZonesResponse ListHostedZones(ListHostedZonesRequest request)
        {
            var marshaller = new ListHostedZonesRequestMarshaller();
            var unmarshaller = ListHostedZonesResponseUnmarshaller.Instance;

            return Invoke<ListHostedZonesRequest,ListHostedZonesResponse>(request, marshaller, unmarshaller);
        }


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
        /// 
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
        public ListReusableDelegationSetsResponse ListReusableDelegationSets()
        {
            return ListReusableDelegationSets(new ListReusableDelegationSetsRequest());
        }


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
        public ListReusableDelegationSetsResponse ListReusableDelegationSets(ListReusableDelegationSetsRequest request)
        {
            var marshaller = new ListReusableDelegationSetsRequestMarshaller();
            var unmarshaller = ListReusableDelegationSetsResponseUnmarshaller.Instance;

            return Invoke<ListReusableDelegationSetsRequest,ListReusableDelegationSetsResponse>(request, marshaller, unmarshaller);
        }


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
        /// 
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
        /// 
        /// </exception>
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
        /// 
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
        /// 
        /// </exception>
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
        /// The response includes three values that help you navigate from one group of <code>maxitems</code>maxitems
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
        public Task<ListTrafficPolicyVersionsResponse> ListTrafficPolicyVersionsAsync(ListTrafficPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTrafficPolicyVersionsRequestMarshaller();
            var unmarshaller = ListTrafficPolicyVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrafficPolicyVersionsRequest,ListTrafficPolicyVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TestDNSAnswer


        /// <summary>
        /// 
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
        /// Updates an existing health check.
        /// 
        ///  
        /// <para>
        /// Send a <code>POST</code> request to the <code>/<i>Amazon Route 53 API version</i>/healthcheck/<i>health
        /// check ID</i> </code> resource. The request body must include an XML document with
        /// an <code>UpdateHealthCheckRequest</code> element. For more information about updating
        /// health checks, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/health-checks-creating-deleting.html">Creating,
        /// Updating, and Deleting Health Checks</a> in the Amazon Route 53 Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHealthCheck service method.</param>
        /// 
        /// <returns>The response from the UpdateHealthCheck service method, as returned by Route53.</returns>
        /// <exception cref="Amazon.Route53.Model.HealthCheckVersionMismatchException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.InvalidInputException">
        /// The input is not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53.Model.NoSuchHealthCheckException">
        /// No health check exists with the ID that you specified in the <code>DeleteHealthCheck</code>
        /// request.
        /// </exception>
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
        /// 
        ///  
        /// <para>
        /// Send a <code>POST</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicy/</code>
        /// resource.
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
        /// Send a <code>POST</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicyinstance/<i>traffic
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