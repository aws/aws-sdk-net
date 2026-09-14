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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// If your output group type is CMAF, use these settings when doing DRM encryption with
    /// a SPEKE-compliant key provider. If your output group type is HLS, DASH, or Microsoft
    /// Smooth, use the SpekeKeyProvider settings instead.
    /// </summary>
    public partial class SpekeKeyProviderCmaf
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. If you want your key provider to encrypt
        /// the content keys that it provides to MediaConvert, set up a certificate with a master
        /// key using AWS Certificate Manager. Specify the certificate's Amazon Resource Name
        /// (ARN) here.
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property DashSignaledSystemIds. Specify the DRM system IDs that
        /// you want signaled in the DASH manifest that MediaConvert creates as part of this CMAF
        /// package. The DASH manifest can currently signal up to three system IDs. For more information,
        /// see https://dashif.org/identifiers/content_protection/.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DashSignaledSystemIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DashSignaledSystemIds property is set.
        /// </summary>
        internal bool IsSetDashSignaledSystemIds() => this.DashSignaledSystemIds != null && (this.DashSignaledSystemIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EncryptionContractConfiguration. Specify the SPEKE version,
        /// either v1.0 or v2.0, that MediaConvert uses when encrypting your output. For more
        /// information, see: https://docs.aws.amazon.com/speke/latest/documentation/speke-api-specification.html
        /// To use SPEKE v1.0: Leave blank. To use SPEKE v2.0: Specify a SPEKE v2.0 video preset
        /// and a SPEKE v2.0 audio preset.
        /// </summary>
        public EncryptionContractConfiguration EncryptionContractConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionContractConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionContractConfiguration() => this.EncryptionContractConfiguration != null;

        /// <summary>
        /// Gets and sets the property HlsSignaledSystemIds. Specify up to 3 DRM system IDs that
        /// you want signaled in the HLS manifest that MediaConvert creates as part of this CMAF
        /// package. For more information, see https://dashif.org/identifiers/content_protection/.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HlsSignaledSystemIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HlsSignaledSystemIds property is set.
        /// </summary>
        internal bool IsSetHlsSignaledSystemIds() => this.HlsSignaledSystemIds != null && (this.HlsSignaledSystemIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceId. Specify the resource ID that your SPEKE-compliant
        /// key provider uses to identify this content.
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property Url. Specify the URL to the key server that your SPEKE-compliant
        /// DRM key provider uses to provide keys for encrypting your content.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
