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

namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// Describes a single OCI platform (CPU architecture and operating system) available
    /// for a runtime version.
    /// </summary>
    public partial class Platform
    {
        /// <summary>
        /// Gets and sets the property Architecture. The CPU architecture of the platform, for
        /// example x86_64 or arm64.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property Digest. The content digest of the platform-specific image.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Digest { get; set; }

        /// <summary>
        /// Checks to see if the Digest property is set.
        /// </summary>
        internal bool IsSetDigest() => this.Digest != null;

        /// <summary>
        /// Gets and sets the property Os. The operating system of the platform.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Os { get; set; }

        /// <summary>
        /// Checks to see if the Os property is set.
        /// </summary>
        internal bool IsSetOs() => this.Os != null;
    }
}
