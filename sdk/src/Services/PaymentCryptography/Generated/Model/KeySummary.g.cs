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
    /// Metadata about an Amazon Web Services Payment Cryptography key.
    /// </summary>
    public partial class KeySummary
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the key is enabled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Exportable. 
        /// <para>
        /// Specifies whether the key is exportable. This data is immutable after the key is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Exportable { get; set; }

        /// <summary>
        /// Checks to see if the Exportable property is set.
        /// </summary>
        internal bool IsSetExportable() => this.Exportable.HasValue;

        /// <summary>
        /// Gets and sets the property KeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 70, Max = 150)]
        public string KeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KeyArn property is set.
        /// </summary>
        internal bool IsSetKeyArn() => this.KeyArn != null;

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// The role of the key, the algorithm it supports, and the cryptographic operations allowed
        /// with the key. This data is immutable after the key is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyAttributes KeyAttributes { get; set; }

        /// <summary>
        /// Checks to see if the KeyAttributes property is set.
        /// </summary>
        internal bool IsSetKeyAttributes() => this.KeyAttributes != null;

        /// <summary>
        /// Gets and sets the property KeyCheckValue. 
        /// <para>
        /// The key check value (KCV) is used to check if all parties holding a given key have
        /// the same key or to detect that a key has changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 16)]
        public string KeyCheckValue { get; set; }

        /// <summary>
        /// Checks to see if the KeyCheckValue property is set.
        /// </summary>
        internal bool IsSetKeyCheckValue() => this.KeyCheckValue != null;

        /// <summary>
        /// Gets and sets the property KeyState. 
        /// <para>
        /// The state of an Amazon Web Services Payment Cryptography that is being created or
        /// deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyState KeyState { get; set; }

        /// <summary>
        /// Checks to see if the KeyState property is set.
        /// </summary>
        internal bool IsSetKeyState() => this.KeyState != null;

        /// <summary>
        /// Gets and sets the property MultiRegionKeyType. 
        /// <para>
        /// Indicates whether this key is a Multi-Region key and its role in the Multi-Region
        /// key hierarchy.
        /// </para>
        ///  
        /// <para>
        /// Multi-Region replication keys allow the same key material to be used across multiple
        /// Amazon Web Services Regions. This field specifies whether the key is a Primary Region
        /// key (PRK) (which can be replicated to other Amazon Web Services Regions) or a Replica
        /// Region key (RRK) (which is a copy of a PRK in another Region). For more information,
        /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-multi-region-replication.html">Multi-Region
        /// key replication</a>.
        /// </para>
        /// </summary>
        public MultiRegionKeyType MultiRegionKeyType { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionKeyType property is set.
        /// </summary>
        internal bool IsSetMultiRegionKeyType() => this.MultiRegionKeyType != null;

        /// <summary>
        /// Gets and sets the property PrimaryRegion.
        /// </summary>
        public string PrimaryRegion { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryRegion property is set.
        /// </summary>
        internal bool IsSetPrimaryRegion() => this.PrimaryRegion != null;
    }
}
