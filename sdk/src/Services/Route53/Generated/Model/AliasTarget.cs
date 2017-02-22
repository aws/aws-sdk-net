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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <i>Alias resource record sets only:</i> Information about the CloudFront distribution,
    /// Elastic Beanstalk environment, ELB load balancer, Amazon S3 bucket, or Amazon Route
    /// 53 resource record set that you're redirecting queries to. An Elastic Beanstalk environment
    /// must have a regionalized subdomain.
    /// 
    ///  
    /// <para>
    /// When creating resource record sets for a private hosted zone, note the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Resource record sets can't be created for CloudFront distributions in a private hosted
    /// zone.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Creating geolocation alias resource record sets or latency alias resource record sets
    /// in a private hosted zone is unsupported.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For information about creating failover resource record sets in a private hosted zone,
    /// see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-private-hosted-zones.html">Configuring
    /// Failover in a Private Hosted Zone</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AliasTarget
    {
        private string _hostedZoneId;
        private string _dnsName;
        private bool? _evaluateTargetHealth;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AliasTarget() { }

        /// <summary>
        /// Instantiates AliasTarget with the parameterized properties
        /// </summary>
        /// <param name="hostedZoneId"> <i>Alias resource records sets only</i>: The value used depends on where you want to route traffic: <dl> <dt>CloudFront distribution</dt> <dd> Specify <code>Z2FDTNDATAQYW2</code>. <note> Alias resource record sets for CloudFront can't be created in a private zone. </note> </dd> <dt>Elastic Beanstalk environment</dt> <dd> Specify the hosted zone ID for the region in which you created the environment. The environment must have a regionalized subdomain. For a list of regions and the corresponding hosted zone IDs, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region">AWS Elastic Beanstalk</a> in the "AWS Regions and Endpoints" chapter of the <i>Amazon Web Services General Reference</i>. </dd> <dt>ELB load balancer</dt> <dd> Specify the value of the hosted zone ID for the load balancer. Use the following methods to get the hosted zone ID: <ul> <li>  <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elb_region">Elastic Load Balancing</a> table in the "AWS Regions and Endpoints" chapter of the <i>Amazon Web Services General Reference</i>: Use the value in the "Amazon Route 53 Hosted Zone ID" column that corresponds with the region that you created your load balancer in. </li> <li>  <b>AWS Management Console</b>: Go to the Amazon EC2 page, click <b>Load Balancers</b> in the navigation pane, select the load balancer, and get the value of the <b>Hosted zone</b> field on the <b>Description</b> tab. </li> <li>  <b>Elastic Load Balancing API</b>: Use <code>DescribeLoadBalancers</code> to get the value of <code>CanonicalHostedZoneNameId</code>. For more information, see the applicable guide: <ul> <li> Classic Load Balancer: <a href="http://docs.aws.amazon.com/elasticloadbalancing/2012-06-01/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>  </li> <li> Application Load Balancer: <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>  </li> </ul> </li> <li>  <b>AWS CLI</b>: Use <code> <a href="http://docs.aws.amazon.com/cli/latest/reference/elb/describe-load-balancers.html">describe-load-balancers</a> </code> to get the value of <code>CanonicalHostedZoneNameID</code>. </li> </ul> </dd> <dt>An Amazon S3 bucket configured as a static website</dt> <dd> Specify the hosted zone ID for the region that you created the bucket in. For more information about valid values, see the <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Amazon Simple Storage Service Website Endpoints</a> table in the "AWS Regions and Endpoints" chapter of the <i>Amazon Web Services General Reference</i>. </dd> <dt>Another Amazon Route 53 resource record set in your hosted zone</dt> <dd> Specify the hosted zone ID of your hosted zone. (An alias resource record set can't reference a resource record set in a different hosted zone.) </dd> </dl></param>
        /// <param name="dnsName"> <i>Alias resource record sets only:</i> The value that you specify depends on where you want to route queries: <dl> <dt>CloudFront distribution</dt> <dd> Specify the domain name that CloudFront assigned when you created your distribution. Your CloudFront distribution must include an alternate domain name that matches the name of the resource record set. For example, if the name of the resource record set is <i>acme.example.com</i>, your CloudFront distribution must include <i>acme.example.com</i> as one of the alternate domain names. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html">Using Alternate Domain Names (CNAMEs)</a> in the <i>Amazon CloudFront Developer Guide</i>. </dd> <dt>Elastic Beanstalk environment</dt> <dd> Specify the <code>CNAME</code> attribute for the environment. (The environment must have a regionalized domain name.) You can use the following methods to get the value of the CNAME attribute: <ul> <li>  <i>AWS Management Console</i>: For information about how to get the value by using the console, see <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/customdomains.html">Using Custom Domains with AWS Elastic Beanstalk</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>. </li> <li>  <i>Elastic Beanstalk API</i>: Use the <code>DescribeEnvironments</code> action to get the value of the <code>CNAME</code> attribute. For more information, see <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/api/API_DescribeEnvironments.html">DescribeEnvironments</a> in the <i>AWS Elastic Beanstalk API Reference</i>. </li> <li>  <i>AWS CLI</i>: Use the <code>describe-environments</code> command to get the value of the <code>CNAME</code> attribute. For more information, see <a href="http://docs.aws.amazon.com/cli/latest/reference/elasticbeanstalk/describe-environments.html">describe-environments</a> in the <i>AWS Command Line Interface Reference</i>. </li> </ul> </dd> <dt>ELB load balancer</dt> <dd> Specify the DNS name that is associated with the load balancer. Get the DNS name by using the AWS Management Console, the ELB API, or the AWS CLI.  <ul> <li>  <b>AWS Management Console</b>: Go to the EC2 page, choose <b>Load Balancers</b> in the navigation pane, choose the load balancer, choose the <b>Description</b> tab, and get the value of the <b>DNS name</b> field. (If you're routing traffic to a Classic Load Balancer, get the value that begins with <b>dualstack</b>.)  </li> <li>  <b>Elastic Load Balancing API</b>: Use <code>DescribeLoadBalancers</code> to get the value of <code>DNSName</code>. For more information, see the applicable guide: <ul> <li> Classic Load Balancer: <a href="http://docs.aws.amazon.com/elasticloadbalancing/2012-06-01/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>  </li> <li> Application Load Balancer: <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>  </li> </ul> </li> <li>  <b>AWS CLI</b>: Use <code> <a href="http://docs.aws.amazon.com/cli/latest/reference/elb/describe-load-balancers.html">describe-load-balancers</a> </code> to get the value of <code>DNSName</code>. </li> </ul> </dd> <dt>Amazon S3 bucket that is configured as a static website</dt> <dd> Specify the domain name of the Amazon S3 website endpoint in which you created the bucket, for example, <code>s3-website-us-east-2.amazonaws.com</code>. For more information about valid values, see the table <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Amazon Simple Storage Service (S3) Website Endpoints</a> in the <i>Amazon Web Services General Reference</i>. For more information about using S3 buckets for websites, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/getting-started.html">Getting Started with Amazon Route 53</a> in the <i>Amazon Route 53 Developer Guide.</i>  </dd> <dt>Another Amazon Route 53 resource record set</dt> <dd> Specify the value of the <code>Name</code> element for a resource record set in the current hosted zone. </dd> </dl></param>
        public AliasTarget(string hostedZoneId, string dnsName)
        {
            _hostedZoneId = hostedZoneId;
            _dnsName = dnsName;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        ///  <i>Alias resource records sets only</i>: The value used depends on where you want
        /// to route traffic:
        /// </para>
        ///  <dl> <dt>CloudFront distribution</dt> <dd> 
        /// <para>
        /// Specify <code>Z2FDTNDATAQYW2</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Alias resource record sets for CloudFront can't be created in a private zone.
        /// </para>
        ///  </note> </dd> <dt>Elastic Beanstalk environment</dt> <dd> 
        /// <para>
        /// Specify the hosted zone ID for the region in which you created the environment. The
        /// environment must have a regionalized subdomain. For a list of regions and the corresponding
        /// hosted zone IDs, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region">AWS
        /// Elastic Beanstalk</a> in the "AWS Regions and Endpoints" chapter of the <i>Amazon
        /// Web Services General Reference</i>.
        /// </para>
        ///  </dd> <dt>ELB load balancer</dt> <dd> 
        /// <para>
        /// Specify the value of the hosted zone ID for the load balancer. Use the following methods
        /// to get the hosted zone ID:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elb_region">Elastic
        /// Load Balancing</a> table in the "AWS Regions and Endpoints" chapter of the <i>Amazon
        /// Web Services General Reference</i>: Use the value in the "Amazon Route 53 Hosted Zone
        /// ID" column that corresponds with the region that you created your load balancer in.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AWS Management Console</b>: Go to the Amazon EC2 page, click <b>Load Balancers</b>
        /// in the navigation pane, select the load balancer, and get the value of the <b>Hosted
        /// zone</b> field on the <b>Description</b> tab.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Elastic Load Balancing API</b>: Use <code>DescribeLoadBalancers</code> to get
        /// the value of <code>CanonicalHostedZoneNameId</code>. For more information, see the
        /// applicable guide:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Classic Load Balancer: <a href="http://docs.aws.amazon.com/elasticloadbalancing/2012-06-01/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Application Load Balancer: <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>AWS CLI</b>: Use <code> <a href="http://docs.aws.amazon.com/cli/latest/reference/elb/describe-load-balancers.html">describe-load-balancers</a>
        /// </code> to get the value of <code>CanonicalHostedZoneNameID</code>.
        /// </para>
        ///  </li> </ul> </dd> <dt>An Amazon S3 bucket configured as a static website</dt> <dd>
        /// 
        /// <para>
        /// Specify the hosted zone ID for the region that you created the bucket in. For more
        /// information about valid values, see the <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Amazon
        /// Simple Storage Service Website Endpoints</a> table in the "AWS Regions and Endpoints"
        /// chapter of the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  </dd> <dt>Another Amazon Route 53 resource record set in your hosted zone</dt> <dd>
        /// 
        /// <para>
        /// Specify the hosted zone ID of your hosted zone. (An alias resource record set can't
        /// reference a resource record set in a different hosted zone.)
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property DNSName. 
        /// <para>
        ///  <i>Alias resource record sets only:</i> The value that you specify depends on where
        /// you want to route queries:
        /// </para>
        ///  <dl> <dt>CloudFront distribution</dt> <dd> 
        /// <para>
        /// Specify the domain name that CloudFront assigned when you created your distribution.
        /// </para>
        ///  
        /// <para>
        /// Your CloudFront distribution must include an alternate domain name that matches the
        /// name of the resource record set. For example, if the name of the resource record set
        /// is <i>acme.example.com</i>, your CloudFront distribution must include <i>acme.example.com</i>
        /// as one of the alternate domain names. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html">Using
        /// Alternate Domain Names (CNAMEs)</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  </dd> <dt>Elastic Beanstalk environment</dt> <dd> 
        /// <para>
        /// Specify the <code>CNAME</code> attribute for the environment. (The environment must
        /// have a regionalized domain name.) You can use the following methods to get the value
        /// of the CNAME attribute:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>AWS Management Console</i>: For information about how to get the value by using
        /// the console, see <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/customdomains.html">Using
        /// Custom Domains with AWS Elastic Beanstalk</a> in the <i>AWS Elastic Beanstalk Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Elastic Beanstalk API</i>: Use the <code>DescribeEnvironments</code> action to
        /// get the value of the <code>CNAME</code> attribute. For more information, see <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/api/API_DescribeEnvironments.html">DescribeEnvironments</a>
        /// in the <i>AWS Elastic Beanstalk API Reference</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>AWS CLI</i>: Use the <code>describe-environments</code> command to get the value
        /// of the <code>CNAME</code> attribute. For more information, see <a href="http://docs.aws.amazon.com/cli/latest/reference/elasticbeanstalk/describe-environments.html">describe-environments</a>
        /// in the <i>AWS Command Line Interface Reference</i>.
        /// </para>
        ///  </li> </ul> </dd> <dt>ELB load balancer</dt> <dd> 
        /// <para>
        /// Specify the DNS name that is associated with the load balancer. Get the DNS name by
        /// using the AWS Management Console, the ELB API, or the AWS CLI. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>AWS Management Console</b>: Go to the EC2 page, choose <b>Load Balancers</b> in
        /// the navigation pane, choose the load balancer, choose the <b>Description</b> tab,
        /// and get the value of the <b>DNS name</b> field. (If you're routing traffic to a Classic
        /// Load Balancer, get the value that begins with <b>dualstack</b>.) 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Elastic Load Balancing API</b>: Use <code>DescribeLoadBalancers</code> to get
        /// the value of <code>DNSName</code>. For more information, see the applicable guide:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Classic Load Balancer: <a href="http://docs.aws.amazon.com/elasticloadbalancing/2012-06-01/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Application Load Balancer: <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>AWS CLI</b>: Use <code> <a href="http://docs.aws.amazon.com/cli/latest/reference/elb/describe-load-balancers.html">describe-load-balancers</a>
        /// </code> to get the value of <code>DNSName</code>.
        /// </para>
        ///  </li> </ul> </dd> <dt>Amazon S3 bucket that is configured as a static website</dt>
        /// <dd> 
        /// <para>
        /// Specify the domain name of the Amazon S3 website endpoint in which you created the
        /// bucket, for example, <code>s3-website-us-east-2.amazonaws.com</code>. For more information
        /// about valid values, see the table <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Amazon
        /// Simple Storage Service (S3) Website Endpoints</a> in the <i>Amazon Web Services General
        /// Reference</i>. For more information about using S3 buckets for websites, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/getting-started.html">Getting
        /// Started with Amazon Route 53</a> in the <i>Amazon Route 53 Developer Guide.</i> 
        /// </para>
        ///  </dd> <dt>Another Amazon Route 53 resource record set</dt> <dd> 
        /// <para>
        /// Specify the value of the <code>Name</code> element for a resource record set in the
        /// current hosted zone.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public string DNSName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DNSName property is set
        internal bool IsSetDNSName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluateTargetHealth. 
        /// <para>
        ///  <i>Applies only to alias, weighted alias, latency alias, and failover alias record
        /// sets:</i> If you set the value of <code>EvaluateTargetHealth</code> to <code>true</code>
        /// for the resource record set or sets in an alias, weighted alias, latency alias, or
        /// failover alias resource record set, and if you specify a value for <code> <a>HealthCheck$Id</a>
        /// </code> for every resource record set that is referenced by these alias resource record
        /// sets, the alias resource record sets inherit the health of the referenced resource
        /// record sets.
        /// </para>
        ///  
        /// <para>
        /// In this configuration, when Amazon Route 53 receives a DNS query for an alias resource
        /// record set:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Route 53 looks at the resource record sets that are referenced by the alias
        /// resource record sets to determine which health checks they're using.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Route 53 checks the current status of each health check. (Amazon Route 53 periodically
        /// checks the health of the endpoint that is specified in a health check; it doesn't
        /// perform the health check when the DNS query arrives.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Based on the status of the health checks, Amazon Route 53 determines which resource
        /// record sets are healthy. Unhealthy resource record sets are immediately removed from
        /// consideration. In addition, if all of the resource record sets that are referenced
        /// by an alias resource record set are unhealthy, that alias resource record set also
        /// is immediately removed from consideration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Based on the configuration of the alias resource record sets (weighted alias or latency
        /// alias, for example) and the configuration of the resource record sets that they reference,
        /// Amazon Route 53 chooses a resource record set from the healthy resource record sets,
        /// and responds to the query.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can't set <code>EvaluateTargetHealth</code> to <code>true</code> when the alias
        /// target is a CloudFront distribution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the AWS resource that you specify in <code>AliasTarget</code> is a resource record
        /// set or a group of resource record sets (for example, a group of weighted resource
        /// record sets), but it is not another alias resource record set, we recommend that you
        /// associate a health check with all of the resource record sets in the alias target.For
        /// more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-complex-configs.html#dns-failover-complex-configs-hc-omitting">What
        /// Happens When You Omit Health Checks?</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify an Elastic Beanstalk environment in <code>HostedZoneId</code> and <code>DNSName</code>,
        /// and if the environment contains an ELB load balancer, Elastic Load Balancing routes
        /// queries only to the healthy Amazon EC2 instances that are registered with the load
        /// balancer. (An environment automatically contains an ELB load balancer if it includes
        /// more than one EC2 instance.) If you set <code>EvaluateTargetHealth</code> to <code>true</code>
        /// and either no EC2 instances are healthy or the load balancer itself is unhealthy,
        /// Amazon Route 53 routes queries to other available resources that are healthy, if any.
        /// </para>
        ///  
        /// <para>
        /// If the environment contains a single EC2 instance, there are no special requirements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify an ELB load balancer in <code> <a>AliasTarget</a> </code>, Elastic
        /// Load Balancing routes queries only to the healthy EC2 instances that are registered
        /// with the load balancer. If no EC2 instances are healthy or if the load balancer itself
        /// is unhealthy, and if <code>EvaluateTargetHealth</code> is true for the corresponding
        /// alias resource record set, Amazon Route 53 routes queries to other resources. When
        /// you create a load balancer, you configure settings for Elastic Load Balancing health
        /// checks; they're not Amazon Route 53 health checks, but they perform a similar function.
        /// Do not create Amazon Route 53 health checks for the EC2 instances that you register
        /// with an ELB load balancer.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-complex-configs.html">How
        /// Health Checks Work in More Complex Amazon Route 53 Configurations</a> in the <i>Amazon
        /// Route 53 Developers Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// We recommend that you set <code>EvaluateTargetHealth</code> to true only when you
        /// have enough idle capacity to handle the failure of one or more endpoints.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information and examples, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover.html">Amazon
        /// Route 53 Health Checks and DNS Failover</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool EvaluateTargetHealth
        {
            get { return this._evaluateTargetHealth.GetValueOrDefault(); }
            set { this._evaluateTargetHealth = value; }
        }

        // Check to see if EvaluateTargetHealth property is set
        internal bool IsSetEvaluateTargetHealth()
        {
            return this._evaluateTargetHealth.HasValue; 
        }

    }
}