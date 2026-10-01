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

namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// An HTTP Live Streaming (HLS) encryption configuration.
    /// </summary>
    public partial class HlsEncryption
    {
        /// <summary>
        /// Gets and sets the property ConstantInitializationVector. A constant initialization
        /// vector for encryption (optional). When not specified the initialization vector will
        /// be periodically rotated.
        /// </summary>
        public string ConstantInitializationVector { get; set; }

        /// <summary>
        /// Checks to see if the ConstantInitializationVector property is set.
        /// </summary>
        internal bool IsSetConstantInitializationVector() => this.ConstantInitializationVector != null;

        /// <summary>
        /// Gets and sets the property EncryptionMethod. The encryption method to use.
        /// </summary>
        public EncryptionMethod EncryptionMethod { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionMethod property is set.
        /// </summary>
        internal bool IsSetEncryptionMethod() => this.EncryptionMethod != null;

        /// <summary>
        /// Gets and sets the property SpekeKeyProvider.
        /// </summary>
        [AWSProperty(Required = true)]
        public SpekeKeyProvider SpekeKeyProvider { get; set; }

        /// <summary>
        /// Checks to see if the SpekeKeyProvider property is set.
        /// </summary>
        internal bool IsSetSpekeKeyProvider() => this.SpekeKeyProvider != null;
    }
}
