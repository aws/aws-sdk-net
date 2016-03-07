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
    /// To update a health check, send a <code>POST</code> request to the <code>/<i>Route
    /// 53 API version</i>/healthcheck/<i>health check ID</i></code> resource. The request
    /// body must include a document with an <code>UpdateHealthCheckRequest</code> element.
    /// The response returns an <code>UpdateHealthCheckResponse</code> element, which contains
    /// metadata about the health check.
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
        /// Optional. When you specify a health check version, Amazon Route 53 compares this value
        /// with the current value in the health check, which prevents you from updating the health
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
        /// The port on which you want Amazon Route 53 to open a connection to perform health
        /// checks.
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
        /// the string that you want Amazon Route 53 to search for in the response body from the
        /// specified resource. If the string appears in the response body, Amazon Route 53 considers
        /// the resource healthy. Amazon Route 53 considers case when searching for <code>SearchString</code>
        /// in the response body.
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

        /// <summary>
        /// Gets and sets the property Inverted. 
        /// <para>
        /// A boolean value that indicates whether the status of health check should be inverted.
        /// For example, if a health check is healthy but <code>Inverted</code> is <code>True</code>,
        /// then Amazon Route 53 considers the health check to be unhealthy.
        /// </para>
        ///  
        /// <para>
        /// Specify this value only if you want to change it.
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
        ///  
        /// <para>
        /// Specify this value only if you want to change it.
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
        ///  
        /// <para>
        /// Specify this value only if you want to change it.
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
        /// to the endpoint in the <code>client_hello</code> message during TLS negotiation. If
        /// you don't specify a value for <code>EnableSNI</code>, Amazon Route 53 defaults to
        /// <code>true</code> when <code>Type</code> is <code>HTTPS</code> or <code>HTTPS_STR_MATCH</code>
        /// and defaults to <code>false</code> when <code>Type</code> is any other value.
        /// </para>
        ///  
        /// <para>
        /// Specify this value only if you want to change it.
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

    }
}