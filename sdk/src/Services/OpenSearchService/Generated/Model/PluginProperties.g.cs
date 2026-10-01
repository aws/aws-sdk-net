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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Basic information about the plugin.
    /// </summary>
    public partial class PluginProperties
    {
        /// <summary>
        /// Gets and sets the property ClassName. 
        /// <para>
        /// The name of the class to load.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ClassName { get; set; }

        /// <summary>
        /// Checks to see if the ClassName property is set.
        /// </summary>
        internal bool IsSetClassName() => this.ClassName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property UncompressedSizeInBytes. 
        /// <para>
        /// The uncompressed size of the plugin.
        /// </para>
        /// </summary>
        public long? UncompressedSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the UncompressedSizeInBytes property is set.
        /// </summary>
        internal bool IsSetUncompressedSizeInBytes() => this.UncompressedSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
