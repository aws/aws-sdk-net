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

namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Defines the attributes of the private key.
    /// </summary>
    public partial class PrivateKeyAttributesV4
    {
        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        /// Defines the algorithm used to generate the private key.
        /// </para>
        /// </summary>
        public PrivateKeyAlgorithm Algorithm { get; set; }

        /// <summary>
        /// Checks to see if the Algorithm property is set.
        /// </summary>
        internal bool IsSetAlgorithm() => this.Algorithm != null;

        /// <summary>
        /// Gets and sets the property CryptoProviders. 
        /// <para>
        /// Defines the cryptographic providers used to generate the private key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> CryptoProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CryptoProviders property is set.
        /// </summary>
        internal bool IsSetCryptoProviders() => this.CryptoProviders != null && (this.CryptoProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeySpec. 
        /// <para>
        /// Defines the purpose of the private key. Set it to "KEY_EXCHANGE" or "SIGNATURE" value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeySpec KeySpec { get; set; }

        /// <summary>
        /// Checks to see if the KeySpec property is set.
        /// </summary>
        internal bool IsSetKeySpec() => this.KeySpec != null;

        /// <summary>
        /// Gets and sets the property KeyUsageProperty. 
        /// <para>
        /// The key usage property defines the purpose of the private key contained in the certificate.
        /// You can specify specific purposes using property flags or all by using property type
        /// ALL.
        /// </para>
        /// </summary>
        public KeyUsageProperty KeyUsageProperty { get; set; }

        /// <summary>
        /// Checks to see if the KeyUsageProperty property is set.
        /// </summary>
        internal bool IsSetKeyUsageProperty() => this.KeyUsageProperty != null;

        /// <summary>
        /// Gets and sets the property MinimalKeyLength. 
        /// <para>
        /// Set the minimum key length of the private key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? MinimalKeyLength { get; set; }

        /// <summary>
        /// Checks to see if the MinimalKeyLength property is set.
        /// </summary>
        internal bool IsSetMinimalKeyLength() => this.MinimalKeyLength.HasValue;
    }
}
