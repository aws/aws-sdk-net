/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// A Common Media Application Format (CMAF) encryption configuration.
    /// </summary>
    public partial class CmafEncryption
    {
        private int? _keyRotationIntervalSeconds;
        private SpekeKeyProvider _spekeKeyProvider;

        /// <summary>
        /// Gets and sets the property KeyRotationIntervalSeconds. Time (in seconds) between each
        /// encryption key rotation.
        /// </summary>
        public int KeyRotationIntervalSeconds
        {
            get { return this._keyRotationIntervalSeconds.GetValueOrDefault(); }
            set { this._keyRotationIntervalSeconds = value; }
        }

        // Check to see if KeyRotationIntervalSeconds property is set
        internal bool IsSetKeyRotationIntervalSeconds()
        {
            return this._keyRotationIntervalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpekeKeyProvider.
        /// </summary>
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