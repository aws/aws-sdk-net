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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// This is the response object from the UpdatePrivateConnectionCertificate operation.
    /// </summary>
    public partial class UpdatePrivateConnectionCertificateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CertificateExpiryTime. 
        /// <para>
        /// The date and time the connection's certificate expires, in UTC format.
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
        /// The DNS resolution mode for the resource gateway.
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
        /// A message describing why the private connection entered a failed state, if applicable.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property HostAddress. 
        /// <para>
        /// The IP address or DNS name of the target resource.
        /// </para>
        /// </summary>
        public string HostAddress { get; set; }

        /// <summary>
        /// Checks to see if the HostAddress property is set.
        /// </summary>
        internal bool IsSetHostAddress() => this.HostAddress != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the private connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationId. 
        /// <para>
        /// The identifier or ARN of the VPC Lattice resource configuration.
        /// </para>
        /// </summary>
        public string ResourceConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationId property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationId() => this.ResourceConfigurationId != null;

        /// <summary>
        /// Gets and sets the property ResourceGatewayId. 
        /// <para>
        /// The identifier or ARN of the VPC Lattice resource gateway.
        /// </para>
        /// </summary>
        public string ResourceGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGatewayId property is set.
        /// </summary>
        internal bool IsSetResourceGatewayId() => this.ResourceGatewayId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the private connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrivateConnectionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags attached to the private connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the private connection, indicating whether it is service-managed or self-managed.
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
        /// The identifier of the VPC the resource gateway is created in.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
