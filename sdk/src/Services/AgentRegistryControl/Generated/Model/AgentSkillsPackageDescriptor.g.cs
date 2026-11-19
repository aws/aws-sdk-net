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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Descriptor that names the source that the registry synchronizes a full skill package
    /// from. It holds only the source. The record's <c>artifact</c> member returns the package
    /// that the registry reads from this source.
    /// </summary>
    public partial class AgentSkillsPackageDescriptor
    {
        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the skill package. Specify an <c>s3://</c> URL of a ZIP object, or a
        /// GitHub folder URL together with <c>repositoryProvider</c> set to <c>GITHUB</c>. For
        /// a GitHub folder, the registry builds the package from every file in the folder.
        /// </para>
        /// </summary>
        public DescriptorSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
