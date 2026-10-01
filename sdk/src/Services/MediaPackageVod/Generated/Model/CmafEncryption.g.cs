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
    /// A CMAF encryption configuration.
    /// </summary>
    public partial class CmafEncryption
    {
        /// <summary>
        /// Gets and sets the property ConstantInitializationVector. An optional 128-bit, 16-byte
        /// hex value represented by a 32-character string, used in conjunction with the key for
        /// encrypting blocks. If you don't specify a value, then MediaPackage creates the constant
        /// initialization vector (IV).
        /// </summary>
        public string ConstantInitializationVector { get; set; }

        /// <summary>
        /// Checks to see if the ConstantInitializationVector property is set.
        /// </summary>
        internal bool IsSetConstantInitializationVector() => this.ConstantInitializationVector != null;

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
