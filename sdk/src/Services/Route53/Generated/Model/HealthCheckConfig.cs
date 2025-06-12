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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains information about the health check.
    /// </summary>
    public partial class HealthCheckConfig
    {
        private string _ipAddress;
        private int? _port;
        private HealthCheckType _type;
        private string _resourcePath;
        private string _fullyQualifiedDomainName;
        private string _searchString;
        private int? _requestInterval;
        private int? _failureThreshold;
        private bool? _measureLatency;
        private bool? _inverted;
        private bool? _disabled;
        private int? _healthThreshold;
        private List<string> _childHealthChecks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _enableSNI;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AlarmIdentifier _alarmIdentifier;
        private InsufficientDataHealthStatus _insufficientDataHealthStatus;
        private string _routingControlArn;

        /// <summary>
        /// Gets and sets the property IPAddress. 
        /// <para>
        /// The IPv4 or IPv6 IP address of the endpoint that you want Amazon Route 53 to perform
        /// health checks on. If you don't specify a value for <c>IPAddress</c>, Route 53 sends
        /// a DNS request to resolve the domain name that you specify in <c>FullyQualifiedDomainName</c>
        /// at the interval that you specify in <c>RequestInterval</c>. Using an IP address returned
        /// by DNS, Route 53 then checks the health of the endpoint.
        /// </para>
        ///  
        /// <para>
        /// Use one of the following formats for the value of <c>IPAddress</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>IPv4 address</b>: four values between 0 and 255, separated by periods (.), for
        /// example, <c>192.0.2.44</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IPv6 address</b>: eight groups of four hexadecimal values, separated by colons
        /// (:), for example, <c>2001:0db8:85a3:0000:0000:abcd:0001:2345</c>. You can also shorten
        /// IPv6 addresses as described in RFC 5952, for example, <c>2001:db8:85a3::abcd:1:2345</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the endpoint is an EC2 instance, we recommend that you create an Elastic IP address,
        /// associate it with your EC2 instance, and specify the Elastic IP address for <c>IPAddress</c>.
        /// This ensures that the IP address of your instance will never change.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_UpdateHealthCheck.html#Route53-UpdateHealthCheck-request-FullyQualifiedDomainName">FullyQualifiedDomainName</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Route 53 can't check the health of endpoints for which the IP address
        /// is in local, private, non-routable, or multicast ranges. For more information about
        /// IP addresses for which you can't create health checks, see the following documents:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://tools.ietf.org/html/rfc5735">RFC 5735, Special Use IPv4 Addresses</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://tools.ietf.org/html/rfc6598">RFC 6598, IANA-Reserved IPv4 Prefix
        /// for Shared Address Space</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://tools.ietf.org/html/rfc5156">RFC 5156, Special-Use IPv6 Addresses</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When the value of <c>Type</c> is <c>CALCULATED</c> or <c>CLOUDWATCH_METRIC</c>, omit
        /// <c>IPAddress</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=45)]
        public string IPAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IPAddress property is set
        internal bool IsSetIPAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port on the endpoint that you want Amazon Route 53 to perform health checks on.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't specify a value for <c>Port</c> when you specify a value for <c>Type</c> of
        /// <c>CLOUDWATCH_METRIC</c> or <c>CALCULATED</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of health check that you want to create, which indicates how Amazon Route
        /// 53 determines whether an endpoint is healthy.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can't change the value of <c>Type</c> after you create a health check.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can create the following types of health checks:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>HTTP</b>: Route 53 tries to establish a TCP connection. If successful, Route 53
        /// submits an HTTP request and waits for an HTTP status code of 200 or greater and less
        /// than 400.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>HTTPS</b>: Route 53 tries to establish a TCP connection. If successful, Route
        /// 53 submits an HTTPS request and waits for an HTTP status code of 200 or greater and
        /// less than 400.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify <c>HTTPS</c> for the value of <c>Type</c>, the endpoint must support
        /// TLS v1.0, v1.1, or v1.2.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <b>HTTP_STR_MATCH</b>: Route 53 tries to establish a TCP connection. If successful,
        /// Route 53 submits an HTTP request and searches the first 5,120 bytes of the response
        /// body for the string that you specify in <c>SearchString</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>HTTPS_STR_MATCH</b>: Route 53 tries to establish a TCP connection. If successful,
        /// Route 53 submits an <c>HTTPS</c> request and searches the first 5,120 bytes of the
        /// response body for the string that you specify in <c>SearchString</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TCP</b>: Route 53 tries to establish a TCP connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CLOUDWATCH_METRIC</b>: The health check is associated with a CloudWatch alarm.
        /// If the state of the alarm is <c>OK</c>, the health check is considered healthy. If
        /// the state is <c>ALARM</c>, the health check is considered unhealthy. If CloudWatch
        /// doesn't have sufficient data to determine whether the state is <c>OK</c> or <c>ALARM</c>,
        /// the health check status depends on the setting for <c>InsufficientDataHealthStatus</c>:
        /// <c>Healthy</c>, <c>Unhealthy</c>, or <c>LastKnownStatus</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CALCULATED</b>: For health checks that monitor the status of other health checks,
        /// Route 53 adds up the number of health checks that Route 53 health checkers consider
        /// to be healthy and compares that number with the value of <c>HealthThreshold</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>RECOVERY_CONTROL</b>: The health check is associated with a Route53 Application
        /// Recovery Controller routing control. If the routing control state is <c>ON</c>, the
        /// health check is considered healthy. If the state is <c>OFF</c>, the health check is
        /// considered unhealthy. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-determining-health-of-endpoints.html">How
        /// Route 53 Determines Whether an Endpoint Is Healthy</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HealthCheckType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcePath. 
        /// <para>
        /// The path, if any, that you want Amazon Route 53 to request when performing health
        /// checks. The path can be any value for which your endpoint will return an HTTP status
        /// code of 2xx or 3xx when the endpoint is healthy, for example, the file /docs/route53-health-check.html.
        /// You can also include query string parameters, for example, <c>/welcome.html?language=jp&amp;login=y</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string ResourcePath
        {
            get { return this._resourcePath; }
            set { this._resourcePath = value; }
        }

        // Check to see if ResourcePath property is set
        internal bool IsSetResourcePath()
        {
            return this._resourcePath != null;
        }

        /// <summary>
        /// Gets and sets the property FullyQualifiedDomainName. 
        /// <para>
        /// Amazon Route 53 behavior depends on whether you specify a value for <c>IPAddress</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>If you specify a value for</b> <c>IPAddress</c>:
        /// </para>
        ///  
        /// <para>
        /// Amazon Route 53 sends health check requests to the specified IPv4 or IPv6 address
        /// and passes the value of <c>FullyQualifiedDomainName</c> in the <c>Host</c> header
        /// for all health checks except TCP health checks. This is typically the fully qualified
        /// DNS name of the endpoint on which you want Route 53 to perform health checks.
        /// </para>
        ///  
        /// <para>
        /// When Route 53 checks the health of an endpoint, here is how it constructs the <c>Host</c>
        /// header:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify a value of <c>80</c> for <c>Port</c> and <c>HTTP</c> or <c>HTTP_STR_MATCH</c>
        /// for <c>Type</c>, Route 53 passes the value of <c>FullyQualifiedDomainName</c> to the
        /// endpoint in the Host header. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a value of <c>443</c> for <c>Port</c> and <c>HTTPS</c> or <c>HTTPS_STR_MATCH</c>
        /// for <c>Type</c>, Route 53 passes the value of <c>FullyQualifiedDomainName</c> to the
        /// endpoint in the <c>Host</c> header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify another value for <c>Port</c> and any value except <c>TCP</c> for <c>Type</c>,
        /// Route 53 passes <c>FullyQualifiedDomainName:Port</c> to the endpoint in the <c>Host</c>
        /// header.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a value for <c>FullyQualifiedDomainName</c>, Route 53 substitutes
        /// the value of <c>IPAddress</c> in the <c>Host</c> header in each of the preceding cases.
        /// </para>
        ///  
        /// <para>
        ///  <b>If you don't specify a value for</b> <c>IPAddress</c>:
        /// </para>
        ///  
        /// <para>
        /// Route 53 sends a DNS request to the domain that you specify for <c>FullyQualifiedDomainName</c>
        /// at the interval that you specify for <c>RequestInterval</c>. Using an IPv4 address
        /// that DNS returns, Route 53 then checks the health of the endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't specify a value for <c>IPAddress</c>, Route 53 uses only IPv4 to send
        /// health checks to the endpoint. If there's no resource record set with a type of A
        /// for the name that you specify for <c>FullyQualifiedDomainName</c>, the health check
        /// fails with a "DNS resolution failed" error.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you want to check the health of weighted, latency, or failover resource record
        /// sets and you choose to specify the endpoint only by <c>FullyQualifiedDomainName</c>,
        /// we recommend that you create a separate health check for each endpoint. For example,
        /// create a health check for each HTTP server that is serving content for www.example.com.
        /// For the value of <c>FullyQualifiedDomainName</c>, specify the domain name of the server
        /// (such as us-east-2-www.example.com), not the name of the resource record sets (www.example.com).
        /// </para>
        ///  <important> 
        /// <para>
        /// In this configuration, if you create a health check for which the value of <c>FullyQualifiedDomainName</c>
        /// matches the name of the resource record sets and you then associate the health check
        /// with those resource record sets, health check results will be unpredictable.
        /// </para>
        ///  </important> 
        /// <para>
        /// In addition, if the value that you specify for <c>Type</c> is <c>HTTP</c>, <c>HTTPS</c>,
        /// <c>HTTP_STR_MATCH</c>, or <c>HTTPS_STR_MATCH</c>, Route 53 passes the value of <c>FullyQualifiedDomainName</c>
        /// in the <c>Host</c> header, as it does when you specify a value for <c>IPAddress</c>.
        /// If the value of <c>Type</c> is <c>TCP</c>, Route 53 doesn't pass a <c>Host</c> header.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string FullyQualifiedDomainName
        {
            get { return this._fullyQualifiedDomainName; }
            set { this._fullyQualifiedDomainName = value; }
        }

        // Check to see if FullyQualifiedDomainName property is set
        internal bool IsSetFullyQualifiedDomainName()
        {
            return this._fullyQualifiedDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property SearchString. 
        /// <para>
        /// If the value of Type is <c>HTTP_STR_MATCH</c> or <c>HTTPS_STR_MATCH</c>, the string
        /// that you want Amazon Route 53 to search for in the response body from the specified
        /// resource. If the string appears in the response body, Route 53 considers the resource
        /// healthy.
        /// </para>
        ///  
        /// <para>
        /// Route 53 considers case when searching for <c>SearchString</c> in the response body.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string SearchString
        {
            get { return this._searchString; }
            set { this._searchString = value; }
        }

        // Check to see if SearchString property is set
        internal bool IsSetSearchString()
        {
            return this._searchString != null;
        }

        /// <summary>
        /// Gets and sets the property RequestInterval. 
        /// <para>
        /// The number of seconds between the time that Amazon Route 53 gets a response from your
        /// endpoint and the time that it sends the next health check request. Each Route 53 health
        /// checker makes requests at this interval.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can't change the value of <c>RequestInterval</c> after you create a health check.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you don't specify a value for <c>RequestInterval</c>, the default value is <c>30</c>
        /// seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=30)]
        public int? RequestInterval
        {
            get { return this._requestInterval; }
            set { this._requestInterval = value; }
        }

        // Check to see if RequestInterval property is set
        internal bool IsSetRequestInterval()
        {
            return this._requestInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureThreshold. 
        /// <para>
        /// The number of consecutive health checks that an endpoint must pass or fail for Amazon
        /// Route 53 to change the current status of the endpoint from unhealthy to healthy or
        /// vice versa. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-determining-health-of-endpoints.html">How
        /// Amazon Route 53 Determines Whether an Endpoint Is Healthy</a> in the <i>Amazon Route
        /// 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for <c>FailureThreshold</c>, the default value is three
        /// health checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int? FailureThreshold
        {
            get { return this._failureThreshold; }
            set { this._failureThreshold = value; }
        }

        // Check to see if FailureThreshold property is set
        internal bool IsSetFailureThreshold()
        {
            return this._failureThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MeasureLatency. 
        /// <para>
        /// Specify whether you want Amazon Route 53 to measure the latency between health checkers
        /// in multiple Amazon Web Services regions and your endpoint, and to display CloudWatch
        /// latency graphs on the <b>Health Checks</b> page in the Route 53 console.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can't change the value of <c>MeasureLatency</c> after you create a health check.
        /// </para>
        ///  </important>
        /// </summary>
        public bool? MeasureLatency
        {
            get { return this._measureLatency; }
            set { this._measureLatency = value; }
        }

        // Check to see if MeasureLatency property is set
        internal bool IsSetMeasureLatency()
        {
            return this._measureLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Inverted. 
        /// <para>
        /// Specify whether you want Amazon Route 53 to invert the status of a health check, for
        /// example, to consider a health check unhealthy when it otherwise would be considered
        /// healthy.
        /// </para>
        /// </summary>
        public bool? Inverted
        {
            get { return this._inverted; }
            set { this._inverted = value; }
        }

        // Check to see if Inverted property is set
        internal bool IsSetInverted()
        {
            return this._inverted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// Stops Route 53 from performing health checks. When you disable a health check, here's
        /// what happens:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Health checks that check the health of endpoints:</b> Route 53 stops submitting
        /// requests to your application, server, or other resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Calculated health checks:</b> Route 53 stops aggregating the status of the referenced
        /// health checks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Health checks that monitor CloudWatch alarms:</b> Route 53 stops monitoring the
        /// corresponding CloudWatch metrics.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After you disable a health check, Route 53 considers the status of the health check
        /// to always be healthy. If you configured DNS failover, Route 53 continues to route
        /// traffic to the corresponding resources. If you want to stop routing traffic to a resource,
        /// change the value of <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_UpdateHealthCheck.html#Route53-UpdateHealthCheck-request-Inverted">Inverted</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Charges for a health check still apply when the health check is disabled. For more
        /// information, see <a href="http://aws.amazon.com/route53/pricing/">Amazon Route 53
        /// Pricing</a>.
        /// </para>
        /// </summary>
        public bool? Disabled
        {
            get { return this._disabled; }
            set { this._disabled = value; }
        }

        // Check to see if Disabled property is set
        internal bool IsSetDisabled()
        {
            return this._disabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthThreshold. 
        /// <para>
        /// The number of child health checks that are associated with a <c>CALCULATED</c> health
        /// check that Amazon Route 53 must consider healthy for the <c>CALCULATED</c> health
        /// check to be considered healthy. To specify the child health checks that you want to
        /// associate with a <c>CALCULATED</c> health check, use the <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_UpdateHealthCheck.html#Route53-UpdateHealthCheck-request-ChildHealthChecks">ChildHealthChecks</a>
        /// element.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify a number greater than the number of child health checks, Route 53 always
        /// considers this health check to be unhealthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>0</c>, Route 53 always considers this health check to be healthy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public int? HealthThreshold
        {
            get { return this._healthThreshold; }
            set { this._healthThreshold = value; }
        }

        // Check to see if HealthThreshold property is set
        internal bool IsSetHealthThreshold()
        {
            return this._healthThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChildHealthChecks. 
        /// <para>
        /// (CALCULATED Health Checks Only) A complex type that contains one <c>ChildHealthCheck</c>
        /// element for each health check that you want to associate with a <c>CALCULATED</c>
        /// health check.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=256)]
        public List<string> ChildHealthChecks
        {
            get { return this._childHealthChecks; }
            set { this._childHealthChecks = value; }
        }

        // Check to see if ChildHealthChecks property is set
        internal bool IsSetChildHealthChecks()
        {
            return this._childHealthChecks != null && (this._childHealthChecks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnableSNI. 
        /// <para>
        /// Specify whether you want Amazon Route 53 to send the value of <c>FullyQualifiedDomainName</c>
        /// to the endpoint in the <c>client_hello</c> message during TLS negotiation. This allows
        /// the endpoint to respond to <c>HTTPS</c> health check requests with the applicable
        /// SSL/TLS certificate.
        /// </para>
        ///  
        /// <para>
        /// Some endpoints require that <c>HTTPS</c> requests include the host name in the <c>client_hello</c>
        /// message. If you don't enable SNI, the status of the health check will be <c>SSL alert
        /// handshake_failure</c>. A health check can also have that status for other reasons.
        /// If SNI is enabled and you're still getting the error, check the SSL/TLS configuration
        /// on your endpoint and confirm that your certificate is valid.
        /// </para>
        ///  
        /// <para>
        /// The SSL/TLS certificate on your endpoint includes a domain name in the <c>Common Name</c>
        /// field and possibly several more in the <c>Subject Alternative Names</c> field. One
        /// of the domain names in the certificate should match the value that you specify for
        /// <c>FullyQualifiedDomainName</c>. If the endpoint responds to the <c>client_hello</c>
        /// message with a certificate that does not include the domain name that you specified
        /// in <c>FullyQualifiedDomainName</c>, a health checker will retry the handshake. In
        /// the second attempt, the health checker will omit <c>FullyQualifiedDomainName</c> from
        /// the <c>client_hello</c> message.
        /// </para>
        /// </summary>
        public bool? EnableSNI
        {
            get { return this._enableSNI; }
            set { this._enableSNI = value; }
        }

        // Check to see if EnableSNI property is set
        internal bool IsSetEnableSNI()
        {
            return this._enableSNI.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// A complex type that contains one <c>Region</c> element for each region from which
        /// you want Amazon Route 53 health checkers to check the specified endpoint.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify any regions, Route 53 health checkers automatically performs
        /// checks from all of the regions that are listed under <b>Valid Values</b>.
        /// </para>
        ///  
        /// <para>
        /// If you update a health check to remove a region that has been performing health checks,
        /// Route 53 will briefly continue to perform checks from that region to ensure that some
        /// health checkers are always checking the endpoint (for example, if you replace three
        /// regions with four different regions). 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AlarmIdentifier. 
        /// <para>
        /// A complex type that identifies the CloudWatch alarm that you want Amazon Route 53
        /// health checkers to use to determine whether the specified health check is healthy.
        /// </para>
        /// </summary>
        public AlarmIdentifier AlarmIdentifier
        {
            get { return this._alarmIdentifier; }
            set { this._alarmIdentifier = value; }
        }

        // Check to see if AlarmIdentifier property is set
        internal bool IsSetAlarmIdentifier()
        {
            return this._alarmIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property InsufficientDataHealthStatus. 
        /// <para>
        /// When CloudWatch has insufficient data about the metric to determine the alarm state,
        /// the status that you want Amazon Route 53 to assign to the health check:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Healthy</c>: Route 53 considers the health check to be healthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Unhealthy</c>: Route 53 considers the health check to be unhealthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LastKnownStatus</c>: Route 53 uses the status of the health check from the last
        /// time that CloudWatch had sufficient data to determine the alarm state. For new health
        /// checks that have no last known status, the default status for the health check is
        /// healthy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InsufficientDataHealthStatus InsufficientDataHealthStatus
        {
            get { return this._insufficientDataHealthStatus; }
            set { this._insufficientDataHealthStatus = value; }
        }

        // Check to see if InsufficientDataHealthStatus property is set
        internal bool IsSetInsufficientDataHealthStatus()
        {
            return this._insufficientDataHealthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingControlArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Route 53 Application Recovery Controller routing
        /// control.
        /// </para>
        ///  
        /// <para>
        /// For more information about Route 53 Application Recovery Controller, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/what-is-route-53-recovery.html">Route
        /// 53 Application Recovery Controller Developer Guide.</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RoutingControlArn
        {
            get { return this._routingControlArn; }
            set { this._routingControlArn = value; }
        }

        // Check to see if RoutingControlArn property is set
        internal bool IsSetRoutingControlArn()
        {
            return this._routingControlArn != null;
        }

    }
}