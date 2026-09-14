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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Use these settings to set up encryption with a static key provider.
    /// </summary>
    public partial class StaticKeyProvider
    {
        /// <summary>
        /// Gets and sets the property KeyFormat. Relates to DRM implementation. Sets the value
        /// of the KEYFORMAT attribute. Must be 'identity' or a reverse DNS string. May be omitted
        /// to indicate an implicit value of 'identity'.
        /// </summary>
        public string KeyFormat { get; set; }

        /// <summary>
        /// Checks to see if the KeyFormat property is set.
        /// </summary>
        internal bool IsSetKeyFormat() => this.KeyFormat != null;

        /// <summary>
        /// Gets and sets the property KeyFormatVersions. Relates to DRM implementation. Either
        /// a single positive integer version value or a slash delimited list of version values
        /// (1/2/3).
        /// </summary>
        public string KeyFormatVersions { get; set; }

        /// <summary>
        /// Checks to see if the KeyFormatVersions property is set.
        /// </summary>
        internal bool IsSetKeyFormatVersions() => this.KeyFormatVersions != null;

        /// <summary>
        /// Gets and sets the property StaticKeyValue. Relates to DRM implementation. Use a 32-character
        /// hexidecimal string to specify Key Value.
        /// </summary>
        public string StaticKeyValue { get; set; }

        /// <summary>
        /// Checks to see if the StaticKeyValue property is set.
        /// </summary>
        internal bool IsSetStaticKeyValue() => this.StaticKeyValue != null;

        /// <summary>
        /// Gets and sets the property Url. Relates to DRM implementation. The location of the
        /// license server used for protecting content.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
