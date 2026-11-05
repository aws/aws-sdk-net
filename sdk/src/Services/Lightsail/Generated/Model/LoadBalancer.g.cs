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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a load balancer.
    /// </summary>
    public partial class LoadBalancer
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ConfigurationOptions. 
        /// <para>
        /// A string to string map of the configuration options for your load balancer. Valid
        /// values are listed below.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ConfigurationOptions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ConfigurationOptions property is set.
        /// </summary>
        internal bool IsSetConfigurationOptions() => this.ConfigurationOptions != null && (this.ConfigurationOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date when your load balancer was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name of your Lightsail load balancer.
        /// </para>
        /// </summary>
        public string DnsName { get; set; }

        /// <summary>
        /// Checks to see if the DnsName property is set.
        /// </summary>
        internal bool IsSetDnsName() => this.DnsName != null;

        /// <summary>
        /// Gets and sets the property HealthCheckPath. 
        /// <para>
        /// The path you specified to perform your health checks. If no path is specified, the
        /// load balancer tries to make a request to the default (root) page.
        /// </para>
        /// </summary>
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckPath property is set.
        /// </summary>
        internal bool IsSetHealthCheckPath() => this.HealthCheckPath != null;

        /// <summary>
        /// Gets and sets the property HttpsRedirectionEnabled. 
        /// <para>
        /// A Boolean value that indicates whether HTTPS redirection is enabled for the load balancer.
        /// </para>
        /// </summary>
        public bool? HttpsRedirectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the HttpsRedirectionEnabled property is set.
        /// </summary>
        internal bool IsSetHttpsRedirectionEnabled() => this.HttpsRedirectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceHealthSummary. 
        /// <para>
        /// An array of InstanceHealthSummary objects describing the health of the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceHealthSummary> InstanceHealthSummary { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceHealthSummary>() : null;

        /// <summary>
        /// Checks to see if the InstanceHealthSummary property is set.
        /// </summary>
        internal bool IsSetInstanceHealthSummary() => this.InstanceHealthSummary != null && (this.InstanceHealthSummary.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstancePort. 
        /// <para>
        /// The port where the load balancer will direct traffic to your Lightsail instances.
        /// For HTTP traffic, it's port 80. For HTTPS traffic, it's port 443.
        /// </para>
        /// </summary>
        public int? InstancePort { get; set; }

        /// <summary>
        /// Checks to see if the InstancePort property is set.
        /// </summary>
        internal bool IsSetInstancePort() => this.InstancePort.HasValue;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type of the load balancer.
        /// </para>
        ///  
        /// <para>
        /// The possible values are <c>ipv4</c> for IPv4 only, <c>ipv6</c> for IPv6 only, and
        /// <c>dualstack</c> for IPv4 and IPv6.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The AWS Region where your load balancer was created (<c>us-east-2a</c>). Lightsail
        /// automatically creates your load balancer across Availability Zones.
        /// </para>
        /// </summary>
        public ResourceLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the load balancer (<c>my-load-balancer</c>).
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol you have enabled for your load balancer. Valid values are below.
        /// </para>
        ///  
        /// <para>
        /// You can't just have <c>HTTP_HTTPS</c>, but you can have just <c>HTTP</c>.
        /// </para>
        /// </summary>
        public LoadBalancerProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property PublicPorts. 
        /// <para>
        /// An array of public port settings for your load balancer. For HTTP, use port 80. For
        /// HTTPS, use port 443.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> PublicPorts { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the PublicPorts property is set.
        /// </summary>
        internal bool IsSetPublicPorts() => this.PublicPorts != null && (this.PublicPorts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type (<c>LoadBalancer</c>.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The status of your load balancer. Valid values are below.
        /// </para>
        /// </summary>
        public LoadBalancerState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code. Include this code in your email to support when you have questions
        /// about your Lightsail load balancer. This code enables our support team to look up
        /// your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode { get; set; }

        /// <summary>
        /// Checks to see if the SupportCode property is set.
        /// </summary>
        internal bool IsSetSupportCode() => this.SupportCode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource. For more information about tags
        /// in Lightsail, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-tags">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TlsCertificateSummaries. 
        /// <para>
        /// An array of LoadBalancerTlsCertificateSummary objects that provide additional information
        /// about the SSL/TLS certificates. For example, if <c>true</c>, the certificate is attached
        /// to the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LoadBalancerTlsCertificateSummary> TlsCertificateSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<LoadBalancerTlsCertificateSummary>() : null;

        /// <summary>
        /// Checks to see if the TlsCertificateSummaries property is set.
        /// </summary>
        internal bool IsSetTlsCertificateSummaries() => this.TlsCertificateSummaries != null && (this.TlsCertificateSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TlsPolicyName. 
        /// <para>
        /// The name of the TLS security policy for the load balancer.
        /// </para>
        /// </summary>
        public string TlsPolicyName { get; set; }

        /// <summary>
        /// Checks to see if the TlsPolicyName property is set.
        /// </summary>
        internal bool IsSetTlsPolicyName() => this.TlsPolicyName != null;
    }
}
