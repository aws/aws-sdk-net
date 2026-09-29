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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Tool descriptions sourced from a configuration bundle version.
    /// </summary>
    public partial class ToolDescriptionConfigurationBundle
    {
        /// <summary>
        /// Gets and sets the property BundleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BundleArn { get; set; }

        /// <summary>
        /// Checks to see if the BundleArn property is set.
        /// </summary>
        internal bool IsSetBundleArn() => this.BundleArn != null;

        /// <summary>
        /// Gets and sets the property Tools. 
        /// <para>
        /// The list of tool entries mapping tool names to their JSON paths within the bundle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ConfigurationBundleToolEntry> Tools { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigurationBundleToolEntry>() : null;

        /// <summary>
        /// Checks to see if the Tools property is set.
        /// </summary>
        internal bool IsSetTools() => this.Tools != null && (this.Tools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version identifier of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
