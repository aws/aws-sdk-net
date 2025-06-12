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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
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
    public partial class PrivateKeyAttributesV2
    {
        private List<string> _cryptoProviders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private KeySpec _keySpec;
        private int? _minimalKeyLength;

        /// <summary>
        /// Gets and sets the property CryptoProviders. 
        /// <para>
        /// Defines the cryptographic providers used to generate the private key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> CryptoProviders
        {
            get { return this._cryptoProviders; }
            set { this._cryptoProviders = value; }
        }

        // Check to see if CryptoProviders property is set
        internal bool IsSetCryptoProviders()
        {
            return this._cryptoProviders != null && (this._cryptoProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeySpec. 
        /// <para>
        /// Defines the purpose of the private key. Set it to "KEY_EXCHANGE" or "SIGNATURE" value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeySpec KeySpec
        {
            get { return this._keySpec; }
            set { this._keySpec = value; }
        }

        // Check to see if KeySpec property is set
        internal bool IsSetKeySpec()
        {
            return this._keySpec != null;
        }

        /// <summary>
        /// Gets and sets the property MinimalKeyLength. 
        /// <para>
        /// Set the minimum key length of the private key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? MinimalKeyLength
        {
            get { return this._minimalKeyLength; }
            set { this._minimalKeyLength = value; }
        }

        // Check to see if MinimalKeyLength property is set
        internal bool IsSetMinimalKeyLength()
        {
            return this._minimalKeyLength.HasValue; 
        }

    }
}