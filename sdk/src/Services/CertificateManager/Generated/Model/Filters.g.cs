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

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// This structure can be used in the <a>ListCertificates</a> action to filter the output
    /// of the certificate list.
    /// </summary>
    public partial class Filters
    {
        /// <summary>
        /// Gets and sets the property ExportOption. 
        /// <para>
        /// Specify <c>ENABLED</c> or <c>DISABLED</c> to identify certificates that can be exported.
        /// </para>
        /// </summary>
        public CertificateExport ExportOption { get; set; }

        /// <summary>
        /// Checks to see if the ExportOption property is set.
        /// </summary>
        internal bool IsSetExportOption() => this.ExportOption != null;

        /// <summary>
        /// Gets and sets the property ExtendedKeyUsage. 
        /// <para>
        /// Specify one or more <a>ExtendedKeyUsage</a> extension values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExtendedKeyUsage { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExtendedKeyUsage property is set.
        /// </summary>
        internal bool IsSetExtendedKeyUsage() => this.ExtendedKeyUsage != null && (this.ExtendedKeyUsage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeyTypes. 
        /// <para>
        /// Specify one or more algorithms that can be used to generate key pairs.
        /// </para>
        ///  
        /// <para>
        /// Default filtering returns only <c>RSA_1024</c> and <c>RSA_2048</c> certificates that
        /// have at least one domain. To return other certificate types, provide the desired type
        /// signatures in a comma-separated list. For example, <c>"keyTypes": ["RSA_2048","RSA_4096"]</c>
        /// returns both <c>RSA_2048</c> and <c>RSA_4096</c> certificates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KeyTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the KeyTypes property is set.
        /// </summary>
        internal bool IsSetKeyTypes() => this.KeyTypes != null && (this.KeyTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// Specify one or more <a>KeyUsage</a> extension values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KeyUsage { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the KeyUsage property is set.
        /// </summary>
        internal bool IsSetKeyUsage() => this.KeyUsage != null && (this.KeyUsage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// Identifies the Amazon Web Services service that manages the certificate issued by
        /// ACM.
        /// </para>
        /// </summary>
        public CertificateManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;
    }
}
