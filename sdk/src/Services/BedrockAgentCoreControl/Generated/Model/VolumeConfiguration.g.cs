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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration for a persistent volume attached to a capacity provider. This structure
    /// defines the storage backing for the persistent volumes used by agents that run on
    /// capacity provider instances.
    /// </summary>
    public partial class VolumeConfiguration
    {
        /// <summary>
        /// Gets and sets the property EbsConfiguration. 
        /// <para>
        /// The configuration for an Amazon EBS-backed persistent volume.
        /// </para>
        /// </summary>
        public EbsVolumeConfiguration EbsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EbsConfiguration property is set.
        /// </summary>
        internal bool IsSetEbsConfiguration() => this.EbsConfiguration != null;
    }
}
