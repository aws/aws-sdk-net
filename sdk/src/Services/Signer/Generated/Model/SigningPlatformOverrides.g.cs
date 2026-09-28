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

namespace Amazon.Signer.Model
{
    /// <summary>
    /// Any overrides that are applied to the signing configuration of a signing platform.
    /// </summary>
    public partial class SigningPlatformOverrides
    {
        /// <summary>
        /// Gets and sets the property SigningConfiguration. 
        /// <para>
        /// A signing configuration that overrides the default encryption or hash algorithm of
        /// a signing job.
        /// </para>
        /// </summary>
        public SigningConfigurationOverrides SigningConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SigningConfiguration property is set.
        /// </summary>
        internal bool IsSetSigningConfiguration() => this.SigningConfiguration != null;

        /// <summary>
        /// Gets and sets the property SigningImageFormat. 
        /// <para>
        /// A signed image is a JSON object. When overriding the default signing platform configuration,
        /// a customer can select either of two signing formats, <c>JSONEmbedded</c> or <c>JSONDetached</c>.
        /// (A third format value, <c>JSON</c>, is reserved for future use.) With <c>JSONEmbedded</c>,
        /// the signing image has the payload embedded in it. With <c>JSONDetached</c>, the payload
        /// is not be embedded in the signing image.
        /// </para>
        /// </summary>
        public ImageFormat SigningImageFormat { get; set; }

        /// <summary>
        /// Checks to see if the SigningImageFormat property is set.
        /// </summary>
        internal bool IsSetSigningImageFormat() => this.SigningImageFormat != null;
    }
}
