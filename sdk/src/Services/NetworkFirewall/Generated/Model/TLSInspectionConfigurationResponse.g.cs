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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The high-level properties of a TLS inspection configuration. This, along with the
    /// <c>TLSInspectionConfiguration</c>, define the TLS inspection configuration. You can
    /// retrieve all objects for a TLS inspection configuration by calling <c>DescribeTLSInspectionConfiguration</c>.
    /// </summary>
    public partial class TLSInspectionConfigurationResponse
    {
        /// <summary>
        /// Gets and sets the property CertificateAuthority.
        /// </summary>
        public TlsCertificateData CertificateAuthority { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthority property is set.
        /// </summary>
        internal bool IsSetCertificateAuthority() => this.CertificateAuthority != null;

        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// A list of the certificates associated with the TLS inspection configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TlsCertificateData> Certificates { get; set; } = AWSConfigs.InitializeCollections ? new List<TlsCertificateData>() : null;

        /// <summary>
        /// Checks to see if the Certificates property is set.
        /// </summary>
        internal bool IsSetCertificates() => this.Certificates != null && (this.Certificates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the TLS inspection configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A complex type that contains the Amazon Web Services KMS encryption configuration
        /// settings for your TLS inspection configuration.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time that the TLS inspection configuration was changed.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfAssociations. 
        /// <para>
        /// The number of firewall policies that use this TLS inspection configuration.
        /// </para>
        /// </summary>
        public int? NumberOfAssociations { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAssociations property is set.
        /// </summary>
        internal bool IsSetNumberOfAssociations() => this.NumberOfAssociations.HasValue;

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the TLS inspection configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TLSInspectionConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the TLSInspectionConfigurationArn property is set.
        /// </summary>
        internal bool IsSetTLSInspectionConfigurationArn() => this.TLSInspectionConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationId. 
        /// <para>
        /// A unique identifier for the TLS inspection configuration. This ID is returned in the
        /// responses to create and list commands. You provide it to operations such as update
        /// and delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string TLSInspectionConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the TLSInspectionConfigurationId property is set.
        /// </summary>
        internal bool IsSetTLSInspectionConfigurationId() => this.TLSInspectionConfigurationId != null;

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationName. 
        /// <para>
        /// The descriptive name of the TLS inspection configuration. You can't change the name
        /// of a TLS inspection configuration after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string TLSInspectionConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the TLSInspectionConfigurationName property is set.
        /// </summary>
        internal bool IsSetTLSInspectionConfigurationName() => this.TLSInspectionConfigurationName != null;

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationStatus. 
        /// <para>
        /// Detailed information about the current status of a <a>TLSInspectionConfiguration</a>.
        /// You can retrieve this for a TLS inspection configuration by calling <a>DescribeTLSInspectionConfiguration</a>
        /// and providing the TLS inspection configuration name and ARN.
        /// </para>
        /// </summary>
        public ResourceStatus TLSInspectionConfigurationStatus { get; set; }

        /// <summary>
        /// Checks to see if the TLSInspectionConfigurationStatus property is set.
        /// </summary>
        internal bool IsSetTLSInspectionConfigurationStatus() => this.TLSInspectionConfigurationStatus != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
