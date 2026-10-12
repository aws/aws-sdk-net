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

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Optional metadata for export associated with the key material. This data is signed
    /// but transmitted in clear text.
    /// </summary>
    public partial class KeyBlockHeaders
    {
        /// <summary>
        /// Gets and sets the property KeyExportability. 
        /// <para>
        /// Specifies subsequent exportability of the key within the key block after it is received
        /// by the receiving party. It can be used to further restrict exportability of the key
        /// after export from Amazon Web Services Payment Cryptography.
        /// </para>
        ///  
        /// <para>
        /// When set to <c>EXPORTABLE</c>, the key can be subsequently exported by the receiver
        /// under a KEK using TR-31 or TR-34 key block export only. When set to <c>NON_EXPORTABLE</c>,
        /// the key cannot be subsequently exported by the receiver. When set to <c>SENSITIVE</c>,
        /// the key can be exported by the receiver under a KEK using TR-31, TR-34, RSA wrap and
        /// unwrap cryptogram or using a symmetric cryptogram key export method. For further information
        /// refer to <a href="https://webstore.ansi.org/standards/ascx9/ansix91432022">ANSI X9.143-2022</a>.
        /// </para>
        /// </summary>
        public KeyExportability KeyExportability { get; set; }

        /// <summary>
        /// Checks to see if the KeyExportability property is set.
        /// </summary>
        internal bool IsSetKeyExportability() => this.KeyExportability != null;

        /// <summary>
        /// Gets and sets the property KeyModesOfUse.
        /// </summary>
        public KeyModesOfUse KeyModesOfUse { get; set; }

        /// <summary>
        /// Checks to see if the KeyModesOfUse property is set.
        /// </summary>
        internal bool IsSetKeyModesOfUse() => this.KeyModesOfUse != null;

        /// <summary>
        /// Gets and sets the property KeyVersion. 
        /// <para>
        /// Parameter used to indicate the version of the key carried in the key block or indicate
        /// the value carried in the key block is a component of a key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string KeyVersion { get; set; }

        /// <summary>
        /// Checks to see if the KeyVersion property is set.
        /// </summary>
        internal bool IsSetKeyVersion() => this.KeyVersion != null;

        /// <summary>
        /// Gets and sets the property OptionalBlocks. 
        /// <para>
        /// Parameter used to indicate the type of optional data in key block headers. Refer to
        /// <a href="https://webstore.ansi.org/standards/ascx9/ansix91432022">ANSI X9.143-2022</a>
        /// for information on allowed data type for optional blocks.
        /// </para>
        ///  
        /// <para>
        /// Optional block character limit is 112 characters. For each optional block, 2 characters
        /// are reserved for optional block ID and 2 characters reserved for optional block length.
        /// More than one optional blocks can be included as long as the combined length does
        /// not increase 112 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> OptionalBlocks { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the OptionalBlocks property is set.
        /// </summary>
        internal bool IsSetOptionalBlocks() => this.OptionalBlocks != null && (this.OptionalBlocks.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
