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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The high-level properties of a TLS inspection configuration. This, along with the
    /// <code>TLSInspectionConfiguration</code>, define the TLS inspection configuration.
    /// You can retrieve all objects for a TLS inspection configuration by calling <code>DescribeTLSInspectionConfiguration</code>.
    /// </summary>
    public partial class TLSInspectionConfigurationResponse
    {
        private List<TlsCertificateData> _certificates = new List<TlsCertificateData>();
        private string _description;
        private EncryptionConfiguration _encryptionConfiguration;
        private DateTime? _lastModifiedTime;
        private int? _numberOfAssociations;
        private List<Tag> _tags = new List<Tag>();
        private string _tlsInspectionConfigurationArn;
        private string _tlsInspectionConfigurationId;
        private string _tlsInspectionConfigurationName;
        private ResourceStatus _tlsInspectionConfigurationStatus;

        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// A list of the certificates associated with the TLS inspection configuration.
        /// </para>
        /// </summary>
        public List<TlsCertificateData> Certificates
        {
            get { return this._certificates; }
            set { this._certificates = value; }
        }

        // Check to see if Certificates property is set
        internal bool IsSetCertificates()
        {
            return this._certificates != null && this._certificates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the TLS inspection configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A complex type that contains the Amazon Web Services KMS encryption configuration
        /// settings for your TLS inspection configuration.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time that the TLS inspection configuration was changed.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfAssociations. 
        /// <para>
        /// The number of firewall policies that use this TLS inspection configuration.
        /// </para>
        /// </summary>
        public int NumberOfAssociations
        {
            get { return this._numberOfAssociations.GetValueOrDefault(); }
            set { this._numberOfAssociations = value; }
        }

        // Check to see if NumberOfAssociations property is set
        internal bool IsSetNumberOfAssociations()
        {
            return this._numberOfAssociations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the TLS inspection configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TLSInspectionConfigurationArn
        {
            get { return this._tlsInspectionConfigurationArn; }
            set { this._tlsInspectionConfigurationArn = value; }
        }

        // Check to see if TLSInspectionConfigurationArn property is set
        internal bool IsSetTLSInspectionConfigurationArn()
        {
            return this._tlsInspectionConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationId. 
        /// <para>
        /// A unique identifier for the TLS inspection configuration. This ID is returned in the
        /// responses to create and list commands. You provide it to operations such as update
        /// and delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string TLSInspectionConfigurationId
        {
            get { return this._tlsInspectionConfigurationId; }
            set { this._tlsInspectionConfigurationId = value; }
        }

        // Check to see if TLSInspectionConfigurationId property is set
        internal bool IsSetTLSInspectionConfigurationId()
        {
            return this._tlsInspectionConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationName. 
        /// <para>
        /// The descriptive name of the TLS inspection configuration. You can't change the name
        /// of a TLS inspection configuration after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TLSInspectionConfigurationName
        {
            get { return this._tlsInspectionConfigurationName; }
            set { this._tlsInspectionConfigurationName = value; }
        }

        // Check to see if TLSInspectionConfigurationName property is set
        internal bool IsSetTLSInspectionConfigurationName()
        {
            return this._tlsInspectionConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationStatus. 
        /// <para>
        /// Detailed information about the current status of a <a>TLSInspectionConfiguration</a>.
        /// You can retrieve this for a TLS inspection configuration by calling <a>DescribeTLSInspectionConfiguration</a>
        /// and providing the TLS inspection configuration name and ARN.
        /// </para>
        /// </summary>
        public ResourceStatus TLSInspectionConfigurationStatus
        {
            get { return this._tlsInspectionConfigurationStatus; }
            set { this._tlsInspectionConfigurationStatus = value; }
        }

        // Check to see if TLSInspectionConfigurationStatus property is set
        internal bool IsSetTLSInspectionConfigurationStatus()
        {
            return this._tlsInspectionConfigurationStatus != null;
        }

    }
}