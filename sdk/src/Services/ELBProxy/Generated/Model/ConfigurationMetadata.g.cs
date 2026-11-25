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

namespace Amazon.ELBProxy.Model
{
    /// <summary>
    /// The configuration metadata for a proxy.
    /// </summary>
    public partial class ConfigurationMetadata
    {
        /// <summary>
        /// Gets and sets the property ConfigArchiveHash. The SHA-256 hash of the configuration
        /// archive. This value is absent when the proxy does not have a configuration archive.
        /// </summary>
        public string ConfigArchiveHash { get; set; }

        /// <summary>
        /// Checks to see if the ConfigArchiveHash property is set.
        /// </summary>
        internal bool IsSetConfigArchiveHash() => this.ConfigArchiveHash != null;

        /// <summary>
        /// Gets and sets the property ConfigArchiveLastUpdatedAt. The date and time that the
        /// configuration archive was last updated.
        /// </summary>
        public DateTime? ConfigArchiveLastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the ConfigArchiveLastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetConfigArchiveLastUpdatedAt() => this.ConfigArchiveLastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ConfigFileHash. The SHA-256 hash of the configuration file.
        /// </summary>
        public string ConfigFileHash { get; set; }

        /// <summary>
        /// Checks to see if the ConfigFileHash property is set.
        /// </summary>
        internal bool IsSetConfigFileHash() => this.ConfigFileHash != null;

        /// <summary>
        /// Gets and sets the property ConfigFileLastUpdatedAt. The date and time that the configuration
        /// file was last updated.
        /// </summary>
        public DateTime? ConfigFileLastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the ConfigFileLastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetConfigFileLastUpdatedAt() => this.ConfigFileLastUpdatedAt.HasValue;
    }
}
