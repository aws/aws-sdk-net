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
    /// Group of outputs
    /// </summary>
    public partial class OutputGroup
    {
        /// <summary>
        /// Gets and sets the property AutomatedEncodingSettings. Use automated encoding to have
        /// MediaConvert choose your encoding settings for you, based on characteristics of your
        /// input video.
        /// </summary>
        public AutomatedEncodingSettings AutomatedEncodingSettings { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedEncodingSettings property is set.
        /// </summary>
        internal bool IsSetAutomatedEncodingSettings() => this.AutomatedEncodingSettings != null;

        /// <summary>
        /// Gets and sets the property CustomName. Use Custom Group Name to specify a name for
        /// the output group. This value is displayed on the console and can make your job settings
        /// JSON more human-readable. It does not affect your outputs. Use up to twelve characters
        /// that are either letters, numbers, spaces, or underscores.
        /// </summary>
        public string CustomName { get; set; }

        /// <summary>
        /// Checks to see if the CustomName property is set.
        /// </summary>
        internal bool IsSetCustomName() => this.CustomName != null;

        /// <summary>
        /// Gets and sets the property Name. Name of the output group
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputGroupSettings. Output Group settings, including type
        /// </summary>
        public OutputGroupSettings OutputGroupSettings { get; set; }

        /// <summary>
        /// Checks to see if the OutputGroupSettings property is set.
        /// </summary>
        internal bool IsSetOutputGroupSettings() => this.OutputGroupSettings != null;

        /// <summary>
        /// Gets and sets the property Outputs. This object holds groups of encoding settings,
        /// one group of settings per output.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Output> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<Output>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
