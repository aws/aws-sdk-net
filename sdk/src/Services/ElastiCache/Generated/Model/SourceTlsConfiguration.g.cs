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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The TLS configuration for connecting to the source during migration.
    /// </summary>
    public partial class SourceTlsConfiguration
    {
        /// <summary>
        /// Gets and sets the property SourceTlsCertificate. 
        /// <para>
        /// The TLS certificate used to verify the identity of the source during migration.
        /// </para>
        /// </summary>
        public string SourceTlsCertificate { get; set; }

        /// <summary>
        /// Checks to see if the SourceTlsCertificate property is set.
        /// </summary>
        internal bool IsSetSourceTlsCertificate() => this.SourceTlsCertificate != null;

        /// <summary>
        /// Gets and sets the property SourceTlsMode. 
        /// <para>
        /// The TLS mode to use when connecting to the source. Valid values are <c>none</c> and
        /// <c>verify-ca</c>.
        /// </para>
        /// </summary>
        public TlsMode SourceTlsMode { get; set; }

        /// <summary>
        /// Checks to see if the SourceTlsMode property is set.
        /// </summary>
        internal bool IsSetSourceTlsMode() => this.SourceTlsMode != null;
    }
}
