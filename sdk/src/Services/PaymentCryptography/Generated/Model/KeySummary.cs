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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
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
        private bool? _enabled;
        private bool? _exportable;
        private string _keyArn;
        private KeyAttributes _keyAttributes;
        private string _keyCheckValue;
        private KeyState _keyState;
        private MultiRegionKeyType _multiRegionKeyType;
        private string _primaryRegion;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the key is enabled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Exportable. 
        /// <para>
        /// Specifies whether the key is exportable. This data is immutable after the key is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Exportable
        {
            get { return this._exportable; }
            set { this._exportable = value; }
        }

        // Check to see if Exportable property is set
        internal bool IsSetExportable()
        {
            return this._exportable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=70, Max=150)]
        public string KeyArn
        {
            get { return this._keyArn; }
            set { this._keyArn = value; }
        }

        // Check to see if KeyArn property is set
        internal bool IsSetKeyArn()
        {
            return this._keyArn != null;
        }

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// The role of the key, the algorithm it supports, and the cryptographic operations allowed
        /// with the key. This data is immutable after the key is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyAttributes KeyAttributes
        {
            get { return this._keyAttributes; }
            set { this._keyAttributes = value; }
        }

        // Check to see if KeyAttributes property is set
        internal bool IsSetKeyAttributes()
        {
            return this._keyAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property KeyCheckValue. 
        /// <para>
        /// The key check value (KCV) is used to check if all parties holding a given key have
        /// the same key or to detect that a key has changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=16)]
        public string KeyCheckValue
        {
            get { return this._keyCheckValue; }
            set { this._keyCheckValue = value; }
        }

        // Check to see if KeyCheckValue property is set
        internal bool IsSetKeyCheckValue()
        {
            return this._keyCheckValue != null;
        }

        /// <summary>
        /// Gets and sets the property KeyState. 
        /// <para>
        /// The state of an Amazon Web Services Payment Cryptography that is being created or
        /// deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyState KeyState
        {
            get { return this._keyState; }
            set { this._keyState = value; }
        }

        // Check to see if KeyState property is set
        internal bool IsSetKeyState()
        {
            return this._keyState != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionKeyType. 
        /// <para>
        /// Indicates whether this key is a multi-region key and its role in the multi-region
        /// key hierarchy.
        /// </para>
        ///  
        /// <para>
        /// Multi-region keys allow the same key material to be used across multiple Amazon Web
        /// Services Regions. This field specifies whether the key is a primary key (which can
        /// be replicated to other regions) or a replica key (which is a copy of a primary key
        /// in another region).
        /// </para>
        /// </summary>
        public MultiRegionKeyType MultiRegionKeyType
        {
            get { return this._multiRegionKeyType; }
            set { this._multiRegionKeyType = value; }
        }

        // Check to see if MultiRegionKeyType property is set
        internal bool IsSetMultiRegionKeyType()
        {
            return this._multiRegionKeyType != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryRegion.
        /// </summary>
        public string PrimaryRegion
        {
            get { return this._primaryRegion; }
            set { this._primaryRegion = value; }
        }

        // Check to see if PrimaryRegion property is set
        internal bool IsSetPrimaryRegion()
        {
            return this._primaryRegion != null;
        }

    }
}