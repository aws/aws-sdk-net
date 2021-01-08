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
    /// Container for the parameters to the UpdateHealthCheck operation.
    /// Updates an existing health check. Note that some values can't be updated. 
    /// 
    ///  
    /// <para>
    /// For more information about updating health checks, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/health-checks-creating-deleting.html">Creating,
    /// Updating, and Deleting Health Checks</a> in the <i>Amazon Route 53 Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdateHealthCheckRequest : AmazonRoute53Request
    {
        private string _healthCheckId;
        private long? _healthCheckVersion;
        private string _ipAddress;
        private int? _port;
        private string _resourcePath;
        private string _fullyQualifiedDomainName;
        private string _searchString;
        private int? _failureThreshold;
        private bool? _inverted;
        private bool? _disabled;
        private int? _healthThreshold;
        private List<string> _childHealthChecks = new List<string>();
        private bool? _enableSNI;
        private List<string> _regions = new List<string>();
        private AlarmIdentifier _alarmIdentifier;
        private InsufficientDataHealthStatus _insufficientDataHealthStatus;
        private List<string> _resetElements = new List<string>();

        /// <summary>
        /// Gets and sets the property HealthCheckId. 
        /// <para>
        /// The ID for the health check for which you want detailed information. When you created
        /// the health check, <code>CreateHealthCheck</code> returned the ID in the response,
        /// in the <code>HealthCheckId</code> element.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string HealthCheckId
        {
            get { return this._healthCheckId; }
            set { this._healthCheckId = value; }
        }

        // Check to see if HealthCheckId property is set
        internal bool IsSetHealthCheckId()
        {
            return this._healthCheckId != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckVersion. 
        /// <para>
        /// A sequential counter that Amazon Route 53 sets to <code>1</code> when you create a
        /// health check and increments by 1 each time you update settings for the health check.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you use <code>GetHealthCheck</code> or <code>ListHealthChecks</code>
        /// to get the current value of <code>HealthCheckVersion</code> for the health check that
        /// you want to update, and that you include that value in your <code>UpdateHealthCheck</code>
        /// request. This prevents Route 53 from overwriting an intervening update:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the value in the <code>UpdateHealthCheck</code> request matches the value of <code>HealthCheckVersion</code>
        /// in the health check, Route 53 updates the health check with the new settings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value of <code>HealthCheckVersion</code> in the health check is greater, the
        /// health check was changed after you got the version number. Route 53 does not update
        /// the health check, and it returns a <code>HealthCheckVersionMismatch</code> error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1)]
        public long HealthCheckVersion
        {
            get { return this._healthCheckVersion.GetValueOrDefault(); }
            set { this._healthCheckVersion = value; }
        }

        // Check to see if HealthCheckVersion property is set
        internal bool IsSetHealthCheckVersion()
        {
            return this._healthCheckVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IPAddress. 
        /// <para>
        /// The IPv4 or IPv6 IP address for the endpoint that you want Amazon Route 53 to perform
        /// health checks on. If you don't specify a value for <code>IPAddress</code>, Route 53
        /// sends a DNS request to resolve the domain name that you specify in <code>FullyQualifiedDomainName</code>
        /// at the interval that you specify in <code>RequestInterval</code>. Using an IP address
        /// that is returned by DNS, Route 53 then checks the health of the endpoint.
        /// </para>
        ///  
        /// <para>
        /// Use one of the following formats for the value of <code>IPAddress</code>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>IPv4 address</b>: four values between 0 and 255, separated by periods (.), for
        /// example, <code>192.0.2.44</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IPv6 address</b>: eight groups of four hexadecimal values, separated by colons
        /// (:), for example, <code>2001:0db8:85a3:0000:0000:abcd:0001:2345</code>. You can also
        /// shorten IPv6 addresses as described in RFC 5952, for example, <code>2001:db8:85a3::abcd:1:2345</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the endpoint is an EC2 instance, we recommend that you create an Elastic IP address,
        /// associate it with your EC2 instance, and specify the Elastic IP address for <code>IPAddress</code>.
        /// This ensures that the IP address of your instance never changes. For more information,
        /// see the applicable documentation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Linux: <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses (EIP)</a> in the <i>Amazon EC2 User Guide for Linux Instances</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Windows: <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses (EIP)</a> in the <i>Amazon EC2 User Guide for Windows Instances</i> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If a health check already has a value for <code>IPAddress</code>, you can change the
        /// value. However, you can't update an existing health check to add or remove the value
        /// of <code>IPAddress</code>. 
        /// </para>
        ///  </note> 
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
        /// Don't specify a value for <code>Port</code> when you specify a value for <code>Type</code>
        /// of <code>CLOUDWATCH_METRIC</code> or <code>CALCULATED</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourcePath. 
        /// <para>
        /// The path that you want Amazon Route 53 to request when performing health checks. The
        /// path can be any value for which your endpoint will return an HTTP status code of 2xx
        /// or 3xx when the endpoint is healthy, for example the file /docs/route53-health-check.html.
        /// You can also include query string parameters, for example, <code>/welcome.html?language=jp&amp;login=y</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Specify this value only if you want to change it.
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
        /// Amazon Route 53 behavior depends on whether you specify a value for <code>IPAddress</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If a health check already has a value for <code>IPAddress</code>, you can change the
        /// value. However, you can't update an existing health check to add or remove the value
        /// of <code>IPAddress</code>. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>If you specify a value for</b> <code>IPAddress</code>:
        /// </para>
        ///  
        /// <para>
        /// Route 53 sends health check requests to the specified IPv4 or IPv6 address and passes
        /// the value of <code>FullyQualifiedDomainName</code> in the <code>Host</code> header
        /// for all health checks except TCP health checks. This is typically the fully qualified
        /// DNS name of the endpoint on which you want Route 53 to perform health checks.
        /// </para>
        ///  
        /// <para>
        /// When Route 53 checks the health of an endpoint, here is how it constructs the <code>Host</code>
        /// header:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify a value of <code>80</code> for <code>Port</code> and <code>HTTP</code>
        /// or <code>HTTP_STR_MATCH</code> for <code>Type</code>, Route 53 passes the value of
        /// <code>FullyQualifiedDomainName</code> to the endpoint in the <code>Host</code> header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a value of <code>443</code> for <code>Port</code> and <code>HTTPS</code>
        /// or <code>HTTPS_STR_MATCH</code> for <code>Type</code>, Route 53 passes the value of
        /// <code>FullyQualifiedDomainName</code> to the endpoint in the <code>Host</code> header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify another value for <code>Port</code> and any value except <code>TCP</code>
        /// for <code>Type</code>, Route 53 passes <i> <code>FullyQualifiedDomainName</code>:<code>Port</code>
        /// </i> to the endpoint in the <code>Host</code> header.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a value for <code>FullyQualifiedDomainName</code>, Route 53 substitutes
        /// the value of <code>IPAddress</code> in the <code>Host</code> header in each of the
        /// above cases.
        /// </para>
        ///  
        /// <para>
        ///  <b>If you don't specify a value for</b> <code>IPAddress</code>:
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for <code>IPAddress</code>, Route 53 sends a DNS request
        /// to the domain that you specify in <code>FullyQualifiedDomainName</code> at the interval
        /// you specify in <code>RequestInterval</code>. Using an IPv4 address that is returned
        /// by DNS, Route 53 then checks the health of the endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't specify a value for <code>IPAddress</code>, Route 53 uses only IPv4 to
        /// send health checks to the endpoint. If there's no resource record set with a type
        /// of A for the name that you specify for <code>FullyQualifiedDomainName</code>, the
        /// health check fails with a "DNS resolution failed" error.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you want to check the health of weighted, latency, or failover resource record
        /// sets and you choose to specify the endpoint only by <code>FullyQualifiedDomainName</code>,
        /// we recommend that you create a separate health check for each endpoint. For example,
        /// create a health check for each HTTP server that is serving content for www.example.com.
        /// For the value of <code>FullyQualifiedDomainName</code>, specify the domain name of
        /// the server (such as <code>us-east-2-www.example.com</code>), not the name of the resource
        /// record sets (www.example.com).
        /// </para>
        ///  <important> 
        /// <para>
        /// In this configuration, if the value of <code>FullyQualifiedDomainName</code> matches
        /// the name of the resource record sets and you then associate the health check with
        /// those resource record sets, health check results will be unpredictable.
        /// </para>
        ///  </important> 
        /// <para>
        /// In addition, if the value of <code>Type</code> is <code>HTTP</code>, <code>HTTPS</code>,
        /// <code>HTTP_STR_MATCH</code>, or <code>HTTPS_STR_MATCH</code>, Route 53 passes the
        /// value of <code>FullyQualifiedDomainName</code> in the <code>Host</code> header, as
        /// it does when you specify a value for <code>IPAddress</code>. If the value of <code>Type</code>
        /// is <code>TCP</code>, Route 53 doesn't pass a <code>Host</code> header.
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
        /// If the value of <code>Type</code> is <code>HTTP_STR_MATCH</code> or <code>HTTPS_STR_MATCH</code>,
        /// the string that you want Amazon Route 53 to search for in the response body from the
        /// specified resource. If the string appears in the response body, Route 53 considers
        /// the resource healthy. (You can't change the value of <code>Type</code> when you update
        /// a health check.)
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
        /// If you don't specify a value for <code>FailureThreshold</code>, the default value
        /// is three health checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int FailureThreshold
        {
            get { return this._failureThreshold.GetValueOrDefault(); }
            set { this._failureThreshold = value; }
        }

        // Check to see if FailureThreshold property is set
        internal bool IsSetFailureThreshold()
        {
            return this._failureThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Inverted. 
        /// <para>
        /// Specify whether you want Amazon Route 53 to invert the status of a health check, for
        /// example, to consider a health check unhealthy when it otherwise would be considered
        /// healthy.
        /// </para>
        /// </summary>
        public bool Inverted
        {
            get { return this._inverted.GetValueOrDefault(); }
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
        public bool Disabled
        {
            get { return this._disabled.GetValueOrDefault(); }
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
        /// The number of child health checks that are associated with a <code>CALCULATED</code>
        /// health that Amazon Route 53 must consider healthy for the <code>CALCULATED</code>
        /// health check to be considered healthy. To specify the child health checks that you
        /// want to associate with a <code>CALCULATED</code> health check, use the <code>ChildHealthChecks</code>
        /// and <code>ChildHealthCheck</code> elements.
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
        /// If you specify <code>0</code>, Route 53 always considers this health check to be healthy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public int HealthThreshold
        {
            get { return this._healthThreshold.GetValueOrDefault(); }
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
        /// A complex type that contains one <code>ChildHealthCheck</code> element for each health
        /// check that you want to associate with a <code>CALCULATED</code> health check.
        /// </para>
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
            return this._childHealthChecks != null && this._childHealthChecks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableSNI. 
        /// <para>
        /// Specify whether you want Amazon Route 53 to send the value of <code>FullyQualifiedDomainName</code>
        /// to the endpoint in the <code>client_hello</code> message during <code>TLS</code> negotiation.
        /// This allows the endpoint to respond to <code>HTTPS</code> health check requests with
        /// the applicable SSL/TLS certificate.
        /// </para>
        ///  
        /// <para>
        /// Some endpoints require that HTTPS requests include the host name in the <code>client_hello</code>
        /// message. If you don't enable SNI, the status of the health check will be SSL alert
        /// <code>handshake_failure</code>. A health check can also have that status for other
        /// reasons. If SNI is enabled and you're still getting the error, check the SSL/TLS configuration
        /// on your endpoint and confirm that your certificate is valid.
        /// </para>
        ///  
        /// <para>
        /// The SSL/TLS certificate on your endpoint includes a domain name in the <code>Common
        /// Name</code> field and possibly several more in the <code>Subject Alternative Names</code>
        /// field. One of the domain names in the certificate should match the value that you
        /// specify for <code>FullyQualifiedDomainName</code>. If the endpoint responds to the
        /// <code>client_hello</code> message with a certificate that does not include the domain
        /// name that you specified in <code>FullyQualifiedDomainName</code>, a health checker
        /// will retry the handshake. In the second attempt, the health checker will omit <code>FullyQualifiedDomainName</code>
        /// from the <code>client_hello</code> message.
        /// </para>
        /// </summary>
        public bool EnableSNI
        {
            get { return this._enableSNI.GetValueOrDefault(); }
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
        /// A complex type that contains one <code>Region</code> element for each region that
        /// you want Amazon Route 53 health checkers to check the specified endpoint from.
        /// </para>
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
            return this._regions != null && this._regions.Count > 0; 
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
        ///  <code>Healthy</code>: Route 53 considers the health check to be healthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Unhealthy</code>: Route 53 considers the health check to be unhealthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastKnownStatus</code>: Route 53 uses the status of the health check from the
        /// last time CloudWatch had sufficient data to determine the alarm state. For new health
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
        /// Gets and sets the property ResetElements. 
        /// <para>
        /// A complex type that contains one <code>ResettableElementName</code> element for each
        /// element that you want to reset to the default value. Valid values for <code>ResettableElementName</code>
        /// include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ChildHealthChecks</code>: Amazon Route 53 resets <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_HealthCheckConfig.html#Route53-Type-HealthCheckConfig-ChildHealthChecks">ChildHealthChecks</a>
        /// to null.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FullyQualifiedDomainName</code>: Route 53 resets <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_UpdateHealthCheck.html#Route53-UpdateHealthCheck-request-FullyQualifiedDomainName">FullyQualifiedDomainName</a>.
        /// to null.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Regions</code>: Route 53 resets the <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_HealthCheckConfig.html#Route53-Type-HealthCheckConfig-Regions">Regions</a>
        /// list to the default set of regions. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResourcePath</code>: Route 53 resets <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_HealthCheckConfig.html#Route53-Type-HealthCheckConfig-ResourcePath">ResourcePath</a>
        /// to null.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=64)]
        public List<string> ResetElements
        {
            get { return this._resetElements; }
            set { this._resetElements = value; }
        }

        // Check to see if ResetElements property is set
        internal bool IsSetResetElements()
        {
            return this._resetElements != null && this._resetElements.Count > 0; 
        }

    }
}