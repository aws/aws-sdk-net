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
    /// Container for the parameters to the UpdateHealthCheck operation.
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
        private int? _healthThreshold;
        private List<string> _childHealthChecks = new List<string>();
        private bool? _enableSNI;
        private List<string> _regions = new List<string>();
        private AlarmIdentifier _alarmIdentifier;
        private InsufficientDataHealthStatus _insufficientDataHealthStatus;

        /// <summary>
        /// Gets and sets the property HealthCheckId. 
        /// <para>
        /// The ID for the health check for which you want detailed information. When you created
        /// the health check, <code>CreateHealthCheck</code> returned the ID in the response,
        /// in the <code>HealthCheckId</code> element.
        /// </para>
        /// </summary>
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
        /// health check and increments by <code>1</code> each time you update settings for the
        /// health check.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you use <code>GetHealthCheck</code> or <code>ListHealthChecks</code>
        /// to get the current value of <code>HealthCheckVersion</code> for the health check that
        /// you want to update, and that you include that value in your <code>UpdateHealthCheck</code>
        /// request. This prevents Amazon Route 53 from overwriting an intervening update:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// f the value in the <code>UpdateHealthCheck</code> request matches the value of <code>HealthCheckVersion</code>
        /// in the health check, Amazon Route 53 updates the health check with the new settings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value of <code>HealthCheckVersion</code> in the health check is greater, the
        /// health check was changed after you got the version number. Amazon Route 53 does not
        /// update the health check, and it returns a <code>HealthCheckVersionMismatch</code>
        /// error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// The IPv4 IP address of the endpoint on which you want Amazon Route 53 to perform health
        /// checks. If you don't specify a value for <code>IPAddress</code>, Amazon Route 53 sends
        /// a DNS request to resolve the domain name that you specify in <code>FullyQualifiedDomainName</code>
        /// at the interval you specify in <code>RequestInterval</code>. Using an IP address that
        /// DNS returns, Amazon Route 53 then checks the health of the endpoint.
        /// </para>
        ///  
        /// <para>
        /// f the endpoint is an Amazon EC2 instance, we recommend that you create an Elastic
        /// IP address, associate it with your Amazon EC2 instance, and specify the Elastic IP
        /// address for <code>IPAddress</code>. This ensures that the IP address of your instance
        /// never changes. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses (EIP)</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If a health check already has a value for <code>IPAddress</code>, you can change the
        /// value. However, you can't update an existing health check to add or remove the value
        /// of <code>IPAddress</code>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a>UpdateHealthCheckRequest$FullyQualifiedDomainName</a>.
        /// </para>
        /// </summary>
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
        /// The port on the endpoint on which you want Amazon Route 53 to perform health checks.
        /// </para>
        /// </summary>
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
        /// 
        /// </para>
        ///  
        /// <para>
        /// Specify this value only if you want to change it.
        /// </para>
        /// </summary>
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
        ///  <b>If you specify</b> <code>IPAddress</code>:
        /// </para>
        ///  
        /// <para>
        /// The value that you want Amazon Route 53 to pass in the <code>Host</code> header in
        /// all health checks except TCP health checks. This is typically the fully qualified
        /// DNS name of the endpoint on which you want Amazon Route 53 to perform health checks.
        /// When Amazon Route 53 checks the health of an endpoint, here is how it constructs the
        /// <code>Host</code> header:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify a value of <code>80</code> for <code>Port</code> and <code>HTTP</code>
        /// or <code>HTTP_STR_MATCH</code> for <code>Type</code>, Amazon Route 53 passes the value
        /// of <code>FullyQualifiedDomainName</code> to the endpoint in the <code>Host</code>
        /// header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a value of <code>443</code> for <code>Port</code> and <code>HTTPS</code>
        /// or <code>HTTPS_STR_MATCH</code> for <code>Type</code>, Amazon Route 53 passes the
        /// value of <code>FullyQualifiedDomainName</code> to the endpoint in the Host header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify another value for <code>Port</code> and any value except <code>TCP</code>
        /// for <code>Type</code>, Amazon Route 53 passes <i> <code>FullyQualifiedDomainName</code>:<code>Port</code>
        /// </i> to the endpoint in the Host header.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a value for <code>FullyQualifiedDomainName</code>, Amazon Route
        /// 53 substitutes the value of <code>IPAddress</code> in the <code>Host</code> header
        /// in each of the above cases.
        /// </para>
        ///  
        /// <para>
        ///  <b>If you don't specify</b> <code>IPAddress</code>:
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for <code>IPAddress</code>, Amazon Route 53 sends a DNS
        /// request to the domain that you specify in <code>FullyQualifiedDomainName</code> at
        /// the interval you specify in <code>RequestInterval</code>. Using an IP address that
        /// DNS returns, Amazon Route 53 then checks the health of the endpoint.
        /// </para>
        ///  
        /// <para>
        /// If you want to check the health of weighted, latency, or failover resource record
        /// sets and you choose to specify the endpoint only by <code>FullyQualifiedDomainName</code>,
        /// we recommend that you create a separate health check for each endpoint. For example,
        /// create a health check for each HTTP server that is serving content for www.example.com.
        /// For the value of <code>FullyQualifiedDomainName</code>, specify the domain name of
        /// the server (such as <code>us-east-1-www.example.com</code>), not the name of the resource
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
        /// <code>HTTP_STR_MATCH</code>, or <code>HTTPS_STR_MATCH</code>, Amazon Route 53 passes
        /// the value of <code>FullyQualifiedDomainName</code> in the <code>Host</code> header,
        /// as it does when you specify a value for <code>IPAddress</code>. If the value of <code>Type</code>
        /// is <code>TCP</code>, Amazon Route 53 doesn't pass a <code>Host</code> header.
        /// </para>
        /// </summary>
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
        /// If the value of <code>Type</code> is <code>HTTP_STR_MATCH</code> or <code>HTTP_STR_MATCH</code>,
        /// the string that you want Amazon Route 53 to search for in the response body from the
        /// specified resource. If the string appears in the response body, Amazon Route 53 considers
        /// the resource healthy. (You can't change the value of <code>Type</code> when you update
        /// a health check.)
        /// </para>
        /// </summary>
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
        /// vice versa. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-failover-determining-health-of-endpoints.html">How
        /// Amazon Route 53 Determines Whether an Endpoint Is Healthy</a> in the <i>Amazon Route
        /// 53 Developer Guide</i>.
        /// </para>
        /// </summary>
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
        /// If you specify a number greater than the number of child health checks, Amazon Route
        /// 53 always considers this health check to be unhealthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <code>0</code>, Amazon Route 53 always considers this health check
        /// to be healthy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// A complex type that contains one Region element for each region from which you want
        /// Amazon Route 53 health checkers to check the specified endpoint.
        /// </para>
        /// </summary>
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

    }
}