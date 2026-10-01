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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Summary of a Private Connection.
    /// </summary>
    public partial class PrivateConnectionSummary
    {
        /// <summary>
        /// Gets and sets the property CertificateExpiryTime. 
        /// <para>
        /// The expiry time of the certificate associated with the Private Connection. Only present
        /// when a certificate is associated.
        /// </para>
        /// </summary>
        public DateTime? CertificateExpiryTime { get; set; }

        /// <summary>
        /// Checks to see if the CertificateExpiryTime property is set.
        /// </summary>
        internal bool IsSetCertificateExpiryTime() => this.CertificateExpiryTime.HasValue;

        /// <summary>
        /// Gets and sets the property DnsResolution. 
        /// <para>
        /// DNS resolution mode for the Private Connection's resource gateway.
        /// </para>
        /// </summary>
        public ResourceConfigDnsResolution DnsResolution { get; set; }

        /// <summary>
        /// Checks to see if the DnsResolution property is set.
        /// </summary>
        internal bool IsSetDnsResolution() => this.DnsResolution != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Message describing the reason for a failed Private Connection, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property HostAddress. 
        /// <para>
        /// IP address or DNS name of the target resource. Only present for service-managed Private
        /// Connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string HostAddress { get; set; }

        /// <summary>
        /// Checks to see if the HostAddress property is set.
        /// </summary>
        internal bool IsSetHostAddress() => this.HostAddress != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Private Connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 30)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationId. 
        /// <para>
        /// The Resource Configuration ARN. Only present for self-managed Private Connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationId property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationId() => this.ResourceConfigurationId != null;

        /// <summary>
        /// Gets and sets the property ResourceGatewayId. 
        /// <para>
        /// The service-managed Resource Gateway ARN. Only present for service-managed Private
        /// Connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGatewayId property is set.
        /// </summary>
        internal bool IsSetResourceGatewayId() => this.ResourceGatewayId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Private Connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrivateConnectionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the Private Connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrivateConnectionType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// VPC identifier of the service-managed Resource Gateway. Only present for service-managed
        /// Private Connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 50)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
