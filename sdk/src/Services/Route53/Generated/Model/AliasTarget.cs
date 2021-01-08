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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <i>Alias resource record sets only:</i> Information about the AWS resource, such
    /// as a CloudFront distribution or an Amazon S3 bucket, that you want to route traffic
    /// to.
    /// 
    ///  
    /// <para>
    /// When creating resource record sets for a private hosted zone, note the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creating geolocation alias resource record sets or latency alias resource record sets
    /// in a private hosted zone is unsupported.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For information about creating failover resource record sets in a private hosted zone,
    /// see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-private-hosted-zones.html">Configuring
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
        /// <param name="hostedZoneId"> <i>Alias resource records sets only</i>: The value used depends on where you want to route traffic: <dl> <dt>Amazon API Gateway custom regional APIs and edge-optimized APIs</dt> <dd> Specify the hosted zone ID for your API. You can get the applicable value using the AWS CLI command <a href="https://docs.aws.amazon.com/cli/latest/reference/apigateway/get-domain-names.html">get-domain-names</a>: <ul> <li> For regional APIs, specify the value of <code>regionalHostedZoneId</code>. </li> <li> For edge-optimized APIs, specify the value of <code>distributionHostedZoneId</code>. </li> </ul> </dd> <dt>Amazon Virtual Private Cloud interface VPC endpoint</dt> <dd> Specify the hosted zone ID for your interface endpoint. You can get the value of <code>HostedZoneId</code> using the AWS CLI command <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/describe-vpc-endpoints.html">describe-vpc-endpoints</a>. </dd> <dt>CloudFront distribution</dt> <dd> Specify <code>Z2FDTNDATAQYW2</code>. <note> Alias resource record sets for CloudFront can't be created in a private zone. </note> </dd> <dt>Elastic Beanstalk environment</dt> <dd> Specify the hosted zone ID for the region that you created the environment in. The environment must have a regionalized subdomain. For a list of regions and the corresponding hosted zone IDs, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region">AWS Elastic Beanstalk</a> in the "AWS Service Endpoints" chapter of the <i>Amazon Web Services General Reference</i>. </dd> <dt>ELB load balancer</dt> <dd> Specify the value of the hosted zone ID for the load balancer. Use the following methods to get the hosted zone ID: <ul> <li>  <a href="https://docs.aws.amazon.com/general/latest/gr/elb.html">Service Endpoints</a> table in the "Elastic Load Balancing Endpoints and Quotas" topic in the <i>Amazon Web Services General Reference</i>: Use the value that corresponds with the region that you created your load balancer in. Note that there are separate columns for Application and Classic Load Balancers and for Network Load Balancers. </li> <li>  <b>AWS Management Console</b>: Go to the Amazon EC2 page, choose <b>Load Balancers</b> in the navigation pane, select the load balancer, and get the value of the <b>Hosted zone</b> field on the <b>Description</b> tab. </li> <li>  <b>Elastic Load Balancing API</b>: Use <code>DescribeLoadBalancers</code> to get the applicable value. For more information, see the applicable guide: <ul> <li> Classic Load Balancers: Use <a href="https://docs.aws.amazon.com/elasticloadbalancing/2012-06-01/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a> to get the value of <code>CanonicalHostedZoneNameId</code>. </li> <li> Application and Network Load Balancers: Use <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a> to get the value of <code>CanonicalHostedZoneId</code>. </li> </ul> </li> <li>  <b>AWS CLI</b>: Use <code>describe-load-balancers</code> to get the applicable value. For more information, see the applicable guide: <ul> <li> Classic Load Balancers: Use <a href="http://docs.aws.amazon.com/cli/latest/reference/elb/describe-load-balancers.html">describe-load-balancers</a> to get the value of <code>CanonicalHostedZoneNameId</code>. </li> <li> Application and Network Load Balancers: Use <a href="http://docs.aws.amazon.com/cli/latest/reference/elbv2/describe-load-balancers.html">describe-load-balancers</a> to get the value of <code>CanonicalHostedZoneId</code>. </li> </ul> </li> </ul> </dd> <dt>AWS Global Accelerator accelerator</dt> <dd> Specify <code>Z2BJ6XQ5FK7U4H</code>. </dd> <dt>An Amazon S3 bucket configured as a static website</dt> <dd> Specify the hosted zone ID for the region that you created the bucket in. For more information about valid values, see the table <a href="https://docs.aws.amazon.com/general/latest/gr/s3.html#s3_website_region_endpoints">Amazon S3 Website Endpoints</a> in the <i>Amazon Web Services General Reference</i>. </dd> <dt>Another Route 53 resource record set in your hosted zone</dt> <dd> Specify the hosted zone ID of your hosted zone. (An alias resource record set can't reference a resource record set in a different hosted zone.) </dd> </dl></param>
        /// <param name="dnsName"> <i>Alias resource record sets only:</i> The value that you specify depends on where you want to route queries: <dl> <dt>Amazon API Gateway custom regional APIs and edge-optimized APIs</dt> <dd> Specify the applicable domain name for your API. You can get the applicable value using the AWS CLI command <a href="https://docs.aws.amazon.com/cli/latest/reference/apigateway/get-domain-names.html">get-domain-names</a>: <ul> <li> For regional APIs, specify the value of <code>regionalDomainName</code>. </li> <li> For edge-optimized APIs, specify the value of <code>distributionDomainName</code>. This is the name of the associated CloudFront distribution, such as <code>da1b2c3d4e5.cloudfront.net</code>. </li> </ul> <note> The name of the record that you're creating must match a custom domain name for your API, such as <code>api.example.com</code>. </note> </dd> <dt>Amazon Virtual Private Cloud interface VPC endpoint</dt> <dd> Enter the API endpoint for the interface endpoint, such as <code>vpce-123456789abcdef01-example-us-east-1a.elasticloadbalancing.us-east-1.vpce.amazonaws.com</code>. For edge-optimized APIs, this is the domain name for the corresponding CloudFront distribution. You can get the value of <code>DnsName</code> using the AWS CLI command <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/describe-vpc-endpoints.html">describe-vpc-endpoints</a>. </dd> <dt>CloudFront distribution</dt> <dd> Specify the domain name that CloudFront assigned when you created your distribution. Your CloudFront distribution must include an alternate domain name that matches the name of the resource record set. For example, if the name of the resource record set is <i>acme.example.com</i>, your CloudFront distribution must include <i>acme.example.com</i> as one of the alternate domain names. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html">Using Alternate Domain Names (CNAMEs)</a> in the <i>Amazon CloudFront Developer Guide</i>. You can't create a resource record set in a private hosted zone to route traffic to a CloudFront distribution. <note> For failover alias records, you can't specify a CloudFront distribution for both the primary and secondary records. A distribution must include an alternate domain name that matches the name of the record. However, the primary and secondary records have the same name, and you can't include the same alternate domain name in more than one distribution.  </note> </dd> <dt>Elastic Beanstalk environment</dt> <dd> If the domain name for your Elastic Beanstalk environment includes the region that you deployed the environment in, you can create an alias record that routes traffic to the environment. For example, the domain name <code>my-environment.<i>us-west-2</i>.elasticbeanstalk.com</code> is a regionalized domain name.  <important> For environments that were created before early 2016, the domain name doesn't include the region. To route traffic to these environments, you must create a CNAME record instead of an alias record. Note that you can't create a CNAME record for the root domain name. For example, if your domain name is example.com, you can create a record that routes traffic for acme.example.com to your Elastic Beanstalk environment, but you can't create a record that routes traffic for example.com to your Elastic Beanstalk environment. </important> For Elastic Beanstalk environments that have regionalized subdomains, specify the <code>CNAME</code> attribute for the environment. You can use the following methods to get the value of the CNAME attribute: <ul> <li>  <i>AWS Management Console</i>: For information about how to get the value by using the console, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/customdomains.html">Using Custom Domains with AWS Elastic Beanstalk</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>. </li> <li>  <i>Elastic Beanstalk API</i>: Use the <code>DescribeEnvironments</code> action to get the value of the <code>CNAME</code> attribute. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/api/API_DescribeEnvironments.html">DescribeEnvironments</a> in the <i>AWS Elastic Beanstalk API Reference</i>. </li> <li>  <i>AWS CLI</i>: Use the <code>describe-environments</code> command to get the value of the <code>CNAME</code> attribute. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/reference/elasticbeanstalk/describe-environments.html">describe-environments</a> in the <i>AWS CLI Command Reference</i>. </li> </ul> </dd> <dt>ELB load balancer</dt> <dd> Specify the DNS name that is associated with the load balancer. Get the DNS name by using the AWS Management Console, the ELB API, or the AWS CLI.  <ul> <li>  <b>AWS Management Console</b>: Go to the EC2 page, choose <b>Load Balancers</b> in the navigation pane, choose the load balancer, choose the <b>Description</b> tab, and get the value of the <b>DNS name</b> field.  If you're routing traffic to a Classic Load Balancer, get the value that begins with <b>dualstack</b>. If you're routing traffic to another type of load balancer, get the value that applies to the record type, A or AAAA. </li> <li>  <b>Elastic Load Balancing API</b>: Use <code>DescribeLoadBalancers</code> to get the value of <code>DNSName</code>. For more information, see the applicable guide: <ul> <li> Classic Load Balancers: <a href="https://docs.aws.amazon.com/elasticloadbalancing/2012-06-01/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>  </li> <li> Application and Network Load Balancers: <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>  </li> </ul> </li> <li>  <b>AWS CLI</b>: Use <code>describe-load-balancers</code> to get the value of <code>DNSName</code>. For more information, see the applicable guide: <ul> <li> Classic Load Balancers: <a href="http://docs.aws.amazon.com/cli/latest/reference/elb/describe-load-balancers.html">describe-load-balancers</a>  </li> <li> Application and Network Load Balancers: <a href="http://docs.aws.amazon.com/cli/latest/reference/elbv2/describe-load-balancers.html">describe-load-balancers</a>  </li> </ul> </li> </ul> </dd> <dt>AWS Global Accelerator accelerator</dt> <dd> Specify the DNS name for your accelerator: <ul> <li>  <b>Global Accelerator API:</b> To get the DNS name, use <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/API_DescribeAccelerator.html">DescribeAccelerator</a>. </li> <li>  <b>AWS CLI:</b> To get the DNS name, use <a href="https://docs.aws.amazon.com/cli/latest/reference/globalaccelerator/describe-accelerator.html">describe-accelerator</a>. </li> </ul> </dd> <dt>Amazon S3 bucket that is configured as a static website</dt> <dd> Specify the domain name of the Amazon S3 website endpoint that you created the bucket in, for example, <code>s3-website.us-east-2.amazonaws.com</code>. For more information about valid values, see the table <a href="https://docs.aws.amazon.com/general/latest/gr/s3.html#s3_website_region_endpoints">Amazon S3 Website Endpoints</a> in the <i>Amazon Web Services General Reference</i>. For more information about using S3 buckets for websites, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/getting-started.html">Getting Started with Amazon Route 53</a> in the <i>Amazon Route 53 Developer Guide.</i>  </dd> <dt>Another Route 53 resource record set</dt> <dd> Specify the value of the <code>Name</code> element for a resource record set in the current hosted zone. <note> If you're creating an alias record that has the same name as the hosted zone (known as the zone apex), you can't specify the domain name for a record for which the value of <code>Type</code> is <code>CNAME</code>. This is because the alias record must have the same type as the record that you're routing traffic to, and creating a CNAME record for the zone apex isn't supported even for an alias record. </note> </dd> </dl></param>
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
        ///  <dl> <dt>Amazon API Gateway custom regional APIs and edge-optimized APIs</dt> <dd>
        /// 
        /// <para>
        /// Specify the hosted zone ID for your API. You can get the applicable value using the
        /// AWS CLI command <a href="https://docs.aws.amazon.com/cli/latest/reference/apigateway/get-domain-names.html">get-domain-names</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For regional APIs, specify the value of <code>regionalHostedZoneId</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For edge-optimized APIs, specify the value of <code>distributionHostedZoneId</code>.
        /// </para>
        ///  </li> </ul> </dd> <dt>Amazon Virtual Private Cloud interface VPC endpoint</dt> <dd>
        /// 
        /// <para>
        /// Specify the hosted zone ID for your interface endpoint. You can get the value of <code>HostedZoneId</code>
        /// using the AWS CLI command <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/describe-vpc-endpoints.html">describe-vpc-endpoints</a>.
        /// </para>
        ///  </dd> <dt>CloudFront distribution</dt> <dd> 
        /// <para>
        /// Specify <code>Z2FDTNDATAQYW2</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Alias resource record sets for CloudFront can't be created in a private zone.
        /// </para>
        ///  </note> </dd> <dt>Elastic Beanstalk environment</dt> <dd> 
        /// <para>
        /// Specify the hosted zone ID for the region that you created the environment in. The
        /// environment must have a regionalized subdomain. For a list of regions and the corresponding
        /// hosted zone IDs, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region">AWS
        /// Elastic Beanstalk</a> in the "AWS Service Endpoints" chapter of the <i>Amazon Web
        /// Services General Reference</i>.
        /// </para>
        ///  </dd> <dt>ELB load balancer</dt> <dd> 
        /// <para>
        /// Specify the value of the hosted zone ID for the load balancer. Use the following methods
        /// to get the hosted zone ID:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/general/latest/gr/elb.html">Service Endpoints</a>
        /// table in the "Elastic Load Balancing Endpoints and Quotas" topic in the <i>Amazon
        /// Web Services General Reference</i>: Use the value that corresponds with the region
        /// that you created your load balancer in. Note that there are separate columns for Application
        /// and Classic Load Balancers and for Network Load Balancers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AWS Management Console</b>: Go to the Amazon EC2 page, choose <b>Load Balancers</b>
        /// in the navigation pane, select the load balancer, and get the value of the <b>Hosted
        /// zone</b> field on the <b>Description</b> tab.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Elastic Load Balancing API</b>: Use <code>DescribeLoadBalancers</code> to get
        /// the applicable value. For more information, see the applicable guide:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Classic Load Balancers: Use <a href="https://docs.aws.amazon.com/elasticloadbalancing/2012-06-01/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>
        /// to get the value of <code>CanonicalHostedZoneNameId</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Application and Network Load Balancers: Use <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>
        /// to get the value of <code>CanonicalHostedZoneId</code>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>AWS CLI</b>: Use <code>describe-load-balancers</code> to get the applicable value.
        /// For more information, see the applicable guide:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Classic Load Balancers: Use <a href="http://docs.aws.amazon.com/cli/latest/reference/elb/describe-load-balancers.html">describe-load-balancers</a>
        /// to get the value of <code>CanonicalHostedZoneNameId</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Application and Network Load Balancers: Use <a href="http://docs.aws.amazon.com/cli/latest/reference/elbv2/describe-load-balancers.html">describe-load-balancers</a>
        /// to get the value of <code>CanonicalHostedZoneId</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>AWS Global Accelerator accelerator</dt> <dd> 
        /// <para>
        /// Specify <code>Z2BJ6XQ5FK7U4H</code>.
        /// </para>
        ///  </dd> <dt>An Amazon S3 bucket configured as a static website</dt> <dd> 
        /// <para>
        /// Specify the hosted zone ID for the region that you created the bucket in. For more
        /// information about valid values, see the table <a href="https://docs.aws.amazon.com/general/latest/gr/s3.html#s3_website_region_endpoints">Amazon
        /// S3 Website Endpoints</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  </dd> <dt>Another Route 53 resource record set in your hosted zone</dt> <dd> 
        /// <para>
        /// Specify the hosted zone ID of your hosted zone. (An alias resource record set can't
        /// reference a resource record set in a different hosted zone.)
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
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
        ///  <dl> <dt>Amazon API Gateway custom regional APIs and edge-optimized APIs</dt> <dd>
        /// 
        /// <para>
        /// Specify the applicable domain name for your API. You can get the applicable value
        /// using the AWS CLI command <a href="https://docs.aws.amazon.com/cli/latest/reference/apigateway/get-domain-names.html">get-domain-names</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For regional APIs, specify the value of <code>regionalDomainName</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For edge-optimized APIs, specify the value of <code>distributionDomainName</code>.
        /// This is the name of the associated CloudFront distribution, such as <code>da1b2c3d4e5.cloudfront.net</code>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The name of the record that you're creating must match a custom domain name for your
        /// API, such as <code>api.example.com</code>.
        /// </para>
        ///  </note> </dd> <dt>Amazon Virtual Private Cloud interface VPC endpoint</dt> <dd> 
        /// <para>
        /// Enter the API endpoint for the interface endpoint, such as <code>vpce-123456789abcdef01-example-us-east-1a.elasticloadbalancing.us-east-1.vpce.amazonaws.com</code>.
        /// For edge-optimized APIs, this is the domain name for the corresponding CloudFront
        /// distribution. You can get the value of <code>DnsName</code> using the AWS CLI command
        /// <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/describe-vpc-endpoints.html">describe-vpc-endpoints</a>.
        /// </para>
        ///  </dd> <dt>CloudFront distribution</dt> <dd> 
        /// <para>
        /// Specify the domain name that CloudFront assigned when you created your distribution.
        /// </para>
        ///  
        /// <para>
        /// Your CloudFront distribution must include an alternate domain name that matches the
        /// name of the resource record set. For example, if the name of the resource record set
        /// is <i>acme.example.com</i>, your CloudFront distribution must include <i>acme.example.com</i>
        /// as one of the alternate domain names. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/CNAMEs.html">Using
        /// Alternate Domain Names (CNAMEs)</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can't create a resource record set in a private hosted zone to route traffic to
        /// a CloudFront distribution.
        /// </para>
        ///  <note> 
        /// <para>
        /// For failover alias records, you can't specify a CloudFront distribution for both the
        /// primary and secondary records. A distribution must include an alternate domain name
        /// that matches the name of the record. However, the primary and secondary records have
        /// the same name, and you can't include the same alternate domain name in more than one
        /// distribution. 
        /// </para>
        ///  </note> </dd> <dt>Elastic Beanstalk environment</dt> <dd> 
        /// <para>
        /// If the domain name for your Elastic Beanstalk environment includes the region that
        /// you deployed the environment in, you can create an alias record that routes traffic
        /// to the environment. For example, the domain name <code>my-environment.<i>us-west-2</i>.elasticbeanstalk.com</code>
        /// is a regionalized domain name. 
        /// </para>
        ///  <important> 
        /// <para>
        /// For environments that were created before early 2016, the domain name doesn't include
        /// the region. To route traffic to these environments, you must create a CNAME record
        /// instead of an alias record. Note that you can't create a CNAME record for the root
        /// domain name. For example, if your domain name is example.com, you can create a record
        /// that routes traffic for acme.example.com to your Elastic Beanstalk environment, but
        /// you can't create a record that routes traffic for example.com to your Elastic Beanstalk
        /// environment.
        /// </para>
        ///  </important> 
        /// <para>
        /// For Elastic Beanstalk environments that have regionalized subdomains, specify the
        /// <code>CNAME</code> attribute for the environment. You can use the following methods
        /// to get the value of the CNAME attribute:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>AWS Management Console</i>: For information about how to get the value by using
        /// the console, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/customdomains.html">Using
        /// Custom Domains with AWS Elastic Beanstalk</a> in the <i>AWS Elastic Beanstalk Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Elastic Beanstalk API</i>: Use the <code>DescribeEnvironments</code> action to
        /// get the value of the <code>CNAME</code> attribute. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/api/API_DescribeEnvironments.html">DescribeEnvironments</a>
        /// in the <i>AWS Elastic Beanstalk API Reference</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>AWS CLI</i>: Use the <code>describe-environments</code> command to get the value
        /// of the <code>CNAME</code> attribute. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/reference/elasticbeanstalk/describe-environments.html">describe-environments</a>
        /// in the <i>AWS CLI Command Reference</i>.
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
        /// and get the value of the <b>DNS name</b> field. 
        /// </para>
        ///  
        /// <para>
        /// If you're routing traffic to a Classic Load Balancer, get the value that begins with
        /// <b>dualstack</b>. If you're routing traffic to another type of load balancer, get
        /// the value that applies to the record type, A or AAAA.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Elastic Load Balancing API</b>: Use <code>DescribeLoadBalancers</code> to get
        /// the value of <code>DNSName</code>. For more information, see the applicable guide:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Classic Load Balancers: <a href="https://docs.aws.amazon.com/elasticloadbalancing/2012-06-01/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Application and Network Load Balancers: <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/APIReference/API_DescribeLoadBalancers.html">DescribeLoadBalancers</a>
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>AWS CLI</b>: Use <code>describe-load-balancers</code> to get the value of <code>DNSName</code>.
        /// For more information, see the applicable guide:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Classic Load Balancers: <a href="http://docs.aws.amazon.com/cli/latest/reference/elb/describe-load-balancers.html">describe-load-balancers</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Application and Network Load Balancers: <a href="http://docs.aws.amazon.com/cli/latest/reference/elbv2/describe-load-balancers.html">describe-load-balancers</a>
        /// 
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>AWS Global Accelerator accelerator</dt> <dd> 
        /// <para>
        /// Specify the DNS name for your accelerator:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Global Accelerator API:</b> To get the DNS name, use <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/API_DescribeAccelerator.html">DescribeAccelerator</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AWS CLI:</b> To get the DNS name, use <a href="https://docs.aws.amazon.com/cli/latest/reference/globalaccelerator/describe-accelerator.html">describe-accelerator</a>.
        /// </para>
        ///  </li> </ul> </dd> <dt>Amazon S3 bucket that is configured as a static website</dt>
        /// <dd> 
        /// <para>
        /// Specify the domain name of the Amazon S3 website endpoint that you created the bucket
        /// in, for example, <code>s3-website.us-east-2.amazonaws.com</code>. For more information
        /// about valid values, see the table <a href="https://docs.aws.amazon.com/general/latest/gr/s3.html#s3_website_region_endpoints">Amazon
        /// S3 Website Endpoints</a> in the <i>Amazon Web Services General Reference</i>. For
        /// more information about using S3 buckets for websites, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/getting-started.html">Getting
        /// Started with Amazon Route 53</a> in the <i>Amazon Route 53 Developer Guide.</i> 
        /// </para>
        ///  </dd> <dt>Another Route 53 resource record set</dt> <dd> 
        /// <para>
        /// Specify the value of the <code>Name</code> element for a resource record set in the
        /// current hosted zone.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're creating an alias record that has the same name as the hosted zone (known
        /// as the zone apex), you can't specify the domain name for a record for which the value
        /// of <code>Type</code> is <code>CNAME</code>. This is because the alias record must
        /// have the same type as the record that you're routing traffic to, and creating a CNAME
        /// record for the zone apex isn't supported even for an alias record.
        /// </para>
        ///  </note> </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
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
        ///  <i>Applies only to alias, failover alias, geolocation alias, latency alias, and weighted
        /// alias resource record sets:</i> When <code>EvaluateTargetHealth</code> is <code>true</code>,
        /// an alias resource record set inherits the health of the referenced AWS resource, such
        /// as an ELB load balancer or another resource record set in the hosted zone.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <dl> <dt>CloudFront distributions</dt> <dd> 
        /// <para>
        /// You can't set <code>EvaluateTargetHealth</code> to <code>true</code> when the alias
        /// target is a CloudFront distribution.
        /// </para>
        ///  </dd> <dt>Elastic Beanstalk environments that have regionalized subdomains</dt> <dd>
        /// 
        /// <para>
        /// If you specify an Elastic Beanstalk environment in <code>DNSName</code> and the environment
        /// contains an ELB load balancer, Elastic Load Balancing routes queries only to the healthy
        /// Amazon EC2 instances that are registered with the load balancer. (An environment automatically
        /// contains an ELB load balancer if it includes more than one Amazon EC2 instance.) If
        /// you set <code>EvaluateTargetHealth</code> to <code>true</code> and either no Amazon
        /// EC2 instances are healthy or the load balancer itself is unhealthy, Route 53 routes
        /// queries to other available resources that are healthy, if any. 
        /// </para>
        ///  
        /// <para>
        /// If the environment contains a single Amazon EC2 instance, there are no special requirements.
        /// </para>
        ///  </dd> <dt>ELB load balancers</dt> <dd> 
        /// <para>
        /// Health checking behavior depends on the type of load balancer:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Classic Load Balancers</b>: If you specify an ELB Classic Load Balancer in <code>DNSName</code>,
        /// Elastic Load Balancing routes queries only to the healthy Amazon EC2 instances that
        /// are registered with the load balancer. If you set <code>EvaluateTargetHealth</code>
        /// to <code>true</code> and either no EC2 instances are healthy or the load balancer
        /// itself is unhealthy, Route 53 routes queries to other resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Application and Network Load Balancers</b>: If you specify an ELB Application
        /// or Network Load Balancer and you set <code>EvaluateTargetHealth</code> to <code>true</code>,
        /// Route 53 routes queries to the load balancer based on the health of the target groups
        /// that are associated with the load balancer:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For an Application or Network Load Balancer to be considered healthy, every target
        /// group that contains targets must contain at least one healthy target. If any target
        /// group contains only unhealthy targets, the load balancer is considered unhealthy,
        /// and Route 53 routes queries to other resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A target group that has no registered targets is considered unhealthy.
        /// </para>
        ///  </li> </ul> </li> </ul> <note> 
        /// <para>
        /// When you create a load balancer, you configure settings for Elastic Load Balancing
        /// health checks; they're not Route 53 health checks, but they perform a similar function.
        /// Do not create Route 53 health checks for the EC2 instances that you register with
        /// an ELB load balancer. 
        /// </para>
        ///  </note> </dd> <dt>S3 buckets</dt> <dd> 
        /// <para>
        /// There are no special requirements for setting <code>EvaluateTargetHealth</code> to
        /// <code>true</code> when the alias target is an S3 bucket.
        /// </para>
        ///  </dd> <dt>Other records in the same hosted zone</dt> <dd> 
        /// <para>
        /// If the AWS resource that you specify in <code>DNSName</code> is a record or a group
        /// of records (for example, a group of weighted records) but is not another alias record,
        /// we recommend that you associate a health check with all of the records in the alias
        /// target. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-complex-configs.html#dns-failover-complex-configs-hc-omitting">What
        /// Happens When You Omit Health Checks?</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// For more information and examples, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover.html">Amazon
        /// Route 53 Health Checks and DNS Failover</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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