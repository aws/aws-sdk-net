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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the Lightsail load balancer.
    /// </summary>
    public partial class LoadBalancer
    {
        private string _arn;
        private Dictionary<string, string> _configurationOptions = new Dictionary<string, string>();
        private DateTime? _createdAt;
        private string _dnsName;
        private string _healthCheckPath;
        private List<InstanceHealthSummary> _instanceHealthSummary = new List<InstanceHealthSummary>();
        private int? _instancePort;
        private ResourceLocation _location;
        private string _name;
        private LoadBalancerProtocol _protocol;
        private List<int> _publicPorts = new List<int>();
        private ResourceType _resourceType;
        private LoadBalancerState _state;
        private string _supportCode;
        private List<LoadBalancerTlsCertificateSummary> _tlsCertificateSummaries = new List<LoadBalancerTlsCertificateSummary>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationOptions. 
        /// <para>
        /// A string to string map of the configuration options for your load balancer. Valid
        /// values are listed below.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ConfigurationOptions
        {
            get { return this._configurationOptions; }
            set { this._configurationOptions = value; }
        }

        // Check to see if ConfigurationOptions property is set
        internal bool IsSetConfigurationOptions()
        {
            return this._configurationOptions != null && this._configurationOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date when your load balancer was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name of your Lightsail load balancer.
        /// </para>
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckPath. 
        /// <para>
        /// The path you specified to perform your health checks. If no path is specified, the
        /// load balancer tries to make a request to the default (root) page.
        /// </para>
        /// </summary>
        public string HealthCheckPath
        {
            get { return this._healthCheckPath; }
            set { this._healthCheckPath = value; }
        }

        // Check to see if HealthCheckPath property is set
        internal bool IsSetHealthCheckPath()
        {
            return this._healthCheckPath != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceHealthSummary. 
        /// <para>
        /// An array of InstanceHealthSummary objects describing the health of the load balancer.
        /// </para>
        /// </summary>
        public List<InstanceHealthSummary> InstanceHealthSummary
        {
            get { return this._instanceHealthSummary; }
            set { this._instanceHealthSummary = value; }
        }

        // Check to see if InstanceHealthSummary property is set
        internal bool IsSetInstanceHealthSummary()
        {
            return this._instanceHealthSummary != null && this._instanceHealthSummary.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstancePort. 
        /// <para>
        /// The port where the load balancer will direct traffic to your Lightsail instances.
        /// For HTTP traffic, it's port 80. For HTTPS traffic, it's port 443.
        /// </para>
        /// </summary>
        public int InstancePort
        {
            get { return this._instancePort.GetValueOrDefault(); }
            set { this._instancePort = value; }
        }

        // Check to see if InstancePort property is set
        internal bool IsSetInstancePort()
        {
            return this._instancePort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The AWS Region where your load balancer was created (e.g., <code>us-east-2a</code>).
        /// Lightsail automatically creates your load balancer across Availability Zones.
        /// </para>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the load balancer (e.g., <code>my-load-balancer</code>).
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol you have enabled for your load balancer. Valid values are below.
        /// </para>
        ///  
        /// <para>
        /// You can't just have <code>HTTP_HTTPS</code>, but you can have just <code>HTTP</code>.
        /// </para>
        /// </summary>
        public LoadBalancerProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property PublicPorts. 
        /// <para>
        /// An array of public port settings for your load balancer. For HTTP, use port 80. For
        /// HTTPS, use port 443.
        /// </para>
        /// </summary>
        public List<int> PublicPorts
        {
            get { return this._publicPorts; }
            set { this._publicPorts = value; }
        }

        // Check to see if PublicPorts property is set
        internal bool IsSetPublicPorts()
        {
            return this._publicPorts != null && this._publicPorts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type (e.g., <code>LoadBalancer</code>.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The status of your load balancer. Valid values are below.
        /// </para>
        /// </summary>
        public LoadBalancerState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code. Include this code in your email to support when you have questions
        /// about your Lightsail load balancer. This code enables our support team to look up
        /// your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode
        {
            get { return this._supportCode; }
            set { this._supportCode = value; }
        }

        // Check to see if SupportCode property is set
        internal bool IsSetSupportCode()
        {
            return this._supportCode != null;
        }

        /// <summary>
        /// Gets and sets the property TlsCertificateSummaries. 
        /// <para>
        /// An array of LoadBalancerTlsCertificateSummary objects that provide additional information
        /// about the SSL/TLS certificates. For example, if <code>true</code>, the certificate
        /// is attached to the load balancer.
        /// </para>
        /// </summary>
        public List<LoadBalancerTlsCertificateSummary> TlsCertificateSummaries
        {
            get { return this._tlsCertificateSummaries; }
            set { this._tlsCertificateSummaries = value; }
        }

        // Check to see if TlsCertificateSummaries property is set
        internal bool IsSetTlsCertificateSummaries()
        {
            return this._tlsCertificateSummaries != null && this._tlsCertificateSummaries.Count > 0; 
        }

    }
}