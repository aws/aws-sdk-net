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
    /// This action updates an existing health check.
    /// 
    ///  
    /// <para>
    ///  To update a health check, send a <code>POST</code> request to the <code>2013-04-01/healthcheck/<i>health
    /// check ID</i></code> resource. The request body must include an XML document with an
    /// <code>UpdateHealthCheckRequest</code> element. The response returns an <code>UpdateHealthCheckResponse</code>
    /// element, which contains metadata about the health check.
    /// </para>
    /// </summary>
    public partial class UpdateHealthCheckRequest : AmazonRoute53Request
    {
        private string _healthCheckId;
        private long? _healthCheckVersion;
        private string _iPAddress;
        private int? _port;
        private string _resourcePath;
        private string _fullyQualifiedDomainName;
        private string _searchString;
        private int? _failureThreshold;

        /// <summary>
        /// Gets and sets the property HealthCheckId. 
        /// <para>
        /// The ID of the health check to update.
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
        /// Optional. When you specify a health check version, Route 53 compares this value with
        /// the current value in the health check, which prevents you from updating the health
        /// check when the versions don't match. Using <code>HealthCheckVersion</code> lets you
        /// prevent overwriting another change to the health check.
        /// </para>
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
        /// The IP address of the resource that you want to check.
        /// </para>
        ///  
        /// <para>
        /// Specify this value only if you want to change it.
        /// </para>
        /// </summary>
        public string IPAddress
        {
            get { return this._iPAddress; }
            set { this._iPAddress = value; }
        }

        // Check to see if IPAddress property is set
        internal bool IsSetIPAddress()
        {
            return this._iPAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port on which you want Route 53 to open a connection to perform health checks.
        /// </para>
        ///  
        /// <para>
        /// Specify this value only if you want to change it.
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
        /// Fully qualified domain name of the instance to be health checked.
        /// </para>
        ///  
        /// <para>
        /// Specify this value only if you want to change it.
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
        /// the string that you want Route 53 to search for in the response body from the specified
        /// resource. If the string appears in the response body, Route 53 considers the resource
        /// healthy. 
        /// </para>
        ///  
        /// <para>
        /// Specify this value only if you want to change it.
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
        /// The number of consecutive health checks that an endpoint must pass or fail for Route
        /// 53 to change the current status of the endpoint from unhealthy to healthy or vice
        /// versa.
        /// </para>
        ///  
        /// <para>
        /// Valid values are integers between 1 and 10. For more information, see "How Amazon
        /// Route 53 Determines Whether an Endpoint Is Healthy" in the Amazon Route 53 Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        /// Specify this value only if you want to change it.
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

    }
}