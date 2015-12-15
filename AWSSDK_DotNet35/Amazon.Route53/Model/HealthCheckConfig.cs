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
    /// A complex type that contains the health check configuration.
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
        private int? _healthThreshold;
        private List<string> _childHealthChecks = new List<string>();

        /// <summary>
        /// Gets and sets the property IPAddress. 
        /// <para>
        /// IP Address of the instance being checked. 
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
        /// Port on which connection will be opened to the instance to health check. For HTTP
        /// and HTTP_STR_MATCH this defaults to 80 if the port is not specified. For HTTPS and
        /// HTTPS_STR_MATCH this defaults to 443 if the port is not specified.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of health check to be performed. Currently supported types are TCP, HTTP,
        /// HTTPS, HTTP_STR_MATCH, and HTTPS_STR_MATCH.
        /// </para>
        /// </summary>
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
        /// Path to ping on the instance to check the health. Required for HTTP, HTTPS, HTTP_STR_MATCH,
        /// and HTTPS_STR_MATCH health checks. The HTTP request is issued to the instance on the
        /// given port and path.
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
        /// Fully qualified domain name of the instance to be health checked.
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
        /// A string to search for in the body of a health check response. Required for HTTP_STR_MATCH
        /// and HTTPS_STR_MATCH health checks.
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
        /// Gets and sets the property RequestInterval. 
        /// <para>
        /// The number of seconds between the time that Amazon Route 53 gets a response from your
        /// endpoint and the time that it sends the next health-check request.
        /// </para>
        ///  
        /// <para>
        /// Each Amazon Route 53 health checker makes requests at this interval. Valid values
        /// are 10 and 30. The default value is 30.
        /// </para>
        /// </summary>
        public int RequestInterval
        {
            get { return this._requestInterval.GetValueOrDefault(); }
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
        /// vice versa.
        /// </para>
        ///  
        /// <para>
        /// Valid values are integers between 1 and 10. For more information, see "How Amazon
        /// Route 53 Determines Whether an Endpoint Is Healthy" in the Amazon Route 53 Developer
        /// Guide.
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
        /// Gets and sets the property MeasureLatency. 
        /// <para>
        /// A Boolean value that indicates whether you want Amazon Route 53 to measure the latency
        /// between health checkers in multiple AWS regions and your endpoint and to display CloudWatch
        /// latency graphs in the Amazon Route 53 console.
        /// </para>
        /// </summary>
        public bool MeasureLatency
        {
            get { return this._measureLatency.GetValueOrDefault(); }
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
        /// A boolean value that indicates whether the status of health check should be inverted.
        /// For example, if a health check is healthy but <code>Inverted</code> is <code>True</code>,
        /// then Amazon Route 53 considers the health check to be unhealthy.
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
        /// The minimum number of child health checks that must be healthy for Amazon Route 53
        /// to consider the parent health check to be healthy. Valid values are integers between
        /// 0 and 256, inclusive.
        /// </para>
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
        /// For a specified parent health check, a list of <code>HealthCheckId</code> values for
        /// the associated child health checks.
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

    }
}