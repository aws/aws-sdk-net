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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
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
namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// An HTTP Live Streaming (HLS) encryption configuration.
    /// </summary>
    public partial class HlsEncryption
    {
        private string _constantInitializationVector;
        private EncryptionMethod _encryptionMethod;
        private int? _keyRotationIntervalSeconds;
        private bool? _repeatExtXKey;
        private SpekeKeyProvider _spekeKeyProvider;

        /// <summary>
        /// Gets and sets the property ConstantInitializationVector. A constant initialization
        /// vector for encryption (optional).When not specified the initialization vector will
        /// be periodically rotated.
        /// </summary>
        public string ConstantInitializationVector
        {
            get { return this._constantInitializationVector; }
            set { this._constantInitializationVector = value; }
        }

        // Check to see if ConstantInitializationVector property is set
        internal bool IsSetConstantInitializationVector()
        {
            return this._constantInitializationVector != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionMethod. The encryption method to use.
        /// </summary>
        public EncryptionMethod EncryptionMethod
        {
            get { return this._encryptionMethod; }
            set { this._encryptionMethod = value; }
        }

        // Check to see if EncryptionMethod property is set
        internal bool IsSetEncryptionMethod()
        {
            return this._encryptionMethod != null;
        }

        /// <summary>
        /// Gets and sets the property KeyRotationIntervalSeconds. Interval (in seconds) between
        /// each encryption key rotation.
        /// </summary>
        public int? KeyRotationIntervalSeconds
        {
            get { return this._keyRotationIntervalSeconds; }
            set { this._keyRotationIntervalSeconds = value; }
        }

        // Check to see if KeyRotationIntervalSeconds property is set
        internal bool IsSetKeyRotationIntervalSeconds()
        {
            return this._keyRotationIntervalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RepeatExtXKey. When enabled, the EXT-X-KEY tag will be
        /// repeated in output manifests.
        /// </summary>
        public bool? RepeatExtXKey
        {
            get { return this._repeatExtXKey; }
            set { this._repeatExtXKey = value; }
        }

        // Check to see if RepeatExtXKey property is set
        internal bool IsSetRepeatExtXKey()
        {
            return this._repeatExtXKey.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpekeKeyProvider.
        /// </summary>
        [AWSProperty(Required=true)]
        public SpekeKeyProvider SpekeKeyProvider
        {
            get { return this._spekeKeyProvider; }
            set { this._spekeKeyProvider = value; }
        }

        // Check to see if SpekeKeyProvider property is set
        internal bool IsSetSpekeKeyProvider()
        {
            return this._spekeKeyProvider != null;
        }

    }
}