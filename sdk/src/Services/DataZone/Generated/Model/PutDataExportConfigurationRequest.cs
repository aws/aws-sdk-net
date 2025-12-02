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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the PutDataExportConfiguration operation.
    /// Creates data export configuration details.
    /// 
    ///  
    /// <para>
    /// In the current release, you can enable exporting asset metadata only for one domain
    /// per Amazon Web Services account per region. If you disable exporting asset metadata
    /// feature for a domain where it's already enabled, you cannot enable this feature for
    /// another domain in the same Amazon Web Services account and region.
    /// </para>
    /// </summary>
    public partial class PutDataExportConfigurationRequest : AmazonDataZoneRequest
    {
        private string _clientToken;
        private string _domainIdentifier;
        private bool? _enableExport;
        private EncryptionConfiguration _encryptionConfiguration;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request. This field
        /// is automatically populated if not provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The domain ID where you want to create data export configuration details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnableExport. 
        /// <para>
        /// Specifies that the export is to be enabled as part of creating data export configuration
        /// details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool EnableExport
        {
            get { return this._enableExport.GetValueOrDefault(); }
            set { this._enableExport = value; }
        }

        // Check to see if EnableExport property is set
        internal bool IsSetEnableExport()
        {
            return this._enableExport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration as part of creating data export configuration details.
        /// </para>
        ///  
        /// <para>
        /// The KMS key provided here as part of encryptionConfiguration must have the required
        /// permissions as described in <a href="https://docs.aws.amazon.com/sagemaker-unified-studio/latest/adminguide/sagemaker-unified-studio-export-asset-metadata-kms-permissions.html">KMS
        /// permissions for exporting asset metadata in Amazon SageMaker Unified Studio</a>.
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

    }
}