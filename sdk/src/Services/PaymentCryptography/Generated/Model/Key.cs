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
    public partial class Key
    {
        private DateTime? _createTimestamp;
        private DateTime? _deletePendingTimestamp;
        private DateTime? _deleteTimestamp;
        private bool? _enabled;
        private bool? _exportable;
        private string _keyArn;
        private KeyAttributes _keyAttributes;
        private string _keyCheckValue;
        private KeyCheckValueAlgorithm _keyCheckValueAlgorithm;
        private KeyOrigin _keyOrigin;
        private KeyState _keyState;
        private DateTime? _usageStartTimestamp;
        private DateTime? _usageStopTimestamp;

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time when the key was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTimestamp
        {
            get { return this._createTimestamp; }
            set { this._createTimestamp = value; }
        }

        // Check to see if CreateTimestamp property is set
        internal bool IsSetCreateTimestamp()
        {
            return this._createTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletePendingTimestamp. 
        /// <para>
        /// The date and time after which Amazon Web Services Payment Cryptography will delete
        /// the key. This value is present only when <c>KeyState</c> is <c>DELETE_PENDING</c>
        /// and the key is scheduled for deletion.
        /// </para>
        /// </summary>
        public DateTime? DeletePendingTimestamp
        {
            get { return this._deletePendingTimestamp; }
            set { this._deletePendingTimestamp = value; }
        }

        // Check to see if DeletePendingTimestamp property is set
        internal bool IsSetDeletePendingTimestamp()
        {
            return this._deletePendingTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteTimestamp. 
        /// <para>
        /// The date and time after which Amazon Web Services Payment Cryptography will delete
        /// the key. This value is present only when when the <c>KeyState</c> is <c>DELETE_COMPLETE</c>
        /// and the Amazon Web Services Payment Cryptography key is deleted.
        /// </para>
        /// </summary>
        public DateTime? DeleteTimestamp
        {
            get { return this._deleteTimestamp; }
            set { this._deleteTimestamp = value; }
        }

        // Check to see if DeleteTimestamp property is set
        internal bool IsSetDeleteTimestamp()
        {
            return this._deleteTimestamp.HasValue; 
        }

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
        /// Gets and sets the property KeyCheckValueAlgorithm. 
        /// <para>
        /// The algorithm that Amazon Web Services Payment Cryptography uses to calculate the
        /// key check value (KCV). It is used to validate the key integrity.
        /// </para>
        ///  
        /// <para>
        /// For TDES keys, the KCV is computed by encrypting 8 bytes, each with value of zero,
        /// with the key to be checked and retaining the 3 highest order bytes of the encrypted
        /// result. For AES keys, the KCV is computed using a CMAC algorithm where the input data
        /// is 16 bytes of zero and retaining the 3 highest order bytes of the encrypted result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyCheckValueAlgorithm KeyCheckValueAlgorithm
        {
            get { return this._keyCheckValueAlgorithm; }
            set { this._keyCheckValueAlgorithm = value; }
        }

        // Check to see if KeyCheckValueAlgorithm property is set
        internal bool IsSetKeyCheckValueAlgorithm()
        {
            return this._keyCheckValueAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property KeyOrigin. 
        /// <para>
        /// The source of the key material. For keys created within Amazon Web Services Payment
        /// Cryptography, the value is <c>AWS_PAYMENT_CRYPTOGRAPHY</c>. For keys imported into
        /// Amazon Web Services Payment Cryptography, the value is <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyOrigin KeyOrigin
        {
            get { return this._keyOrigin; }
            set { this._keyOrigin = value; }
        }

        // Check to see if KeyOrigin property is set
        internal bool IsSetKeyOrigin()
        {
            return this._keyOrigin != null;
        }

        /// <summary>
        /// Gets and sets the property KeyState. 
        /// <para>
        /// The state of key that is being created or deleted.
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
        /// Gets and sets the property UsageStartTimestamp. 
        /// <para>
        /// The date and time after which Amazon Web Services Payment Cryptography will start
        /// using the key material for cryptographic operations.
        /// </para>
        /// </summary>
        public DateTime? UsageStartTimestamp
        {
            get { return this._usageStartTimestamp; }
            set { this._usageStartTimestamp = value; }
        }

        // Check to see if UsageStartTimestamp property is set
        internal bool IsSetUsageStartTimestamp()
        {
            return this._usageStartTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsageStopTimestamp. 
        /// <para>
        /// The date and time after which Amazon Web Services Payment Cryptography will stop using
        /// the key material for cryptographic operations.
        /// </para>
        /// </summary>
        public DateTime? UsageStopTimestamp
        {
            get { return this._usageStopTimestamp; }
            set { this._usageStopTimestamp = value; }
        }

        // Check to see if UsageStopTimestamp property is set
        internal bool IsSetUsageStopTimestamp()
        {
            return this._usageStopTimestamp.HasValue; 
        }

    }
}