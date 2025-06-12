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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
        private AutomatedEncodingSettings _automatedEncodingSettings;
        private string _customName;
        private string _name;
        private OutputGroupSettings _outputGroupSettings;
        private List<Output> _outputs = AWSConfigs.InitializeCollections ? new List<Output>() : null;

        /// <summary>
        /// Gets and sets the property AutomatedEncodingSettings. Use automated encoding to have
        /// MediaConvert choose your encoding settings for you, based on characteristics of your
        /// input video.
        /// </summary>
        public AutomatedEncodingSettings AutomatedEncodingSettings
        {
            get { return this._automatedEncodingSettings; }
            set { this._automatedEncodingSettings = value; }
        }

        // Check to see if AutomatedEncodingSettings property is set
        internal bool IsSetAutomatedEncodingSettings()
        {
            return this._automatedEncodingSettings != null;
        }

        /// <summary>
        /// Gets and sets the property CustomName. Use Custom Group Name to specify a name for
        /// the output group. This value is displayed on the console and can make your job settings
        /// JSON more human-readable. It does not affect your outputs. Use up to twelve characters
        /// that are either letters, numbers, spaces, or underscores.
        /// </summary>
        public string CustomName
        {
            get { return this._customName; }
            set { this._customName = value; }
        }

        // Check to see if CustomName property is set
        internal bool IsSetCustomName()
        {
            return this._customName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. Name of the output group
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OutputGroupSettings. Output Group settings, including type
        /// </summary>
        public OutputGroupSettings OutputGroupSettings
        {
            get { return this._outputGroupSettings; }
            set { this._outputGroupSettings = value; }
        }

        // Check to see if OutputGroupSettings property is set
        internal bool IsSetOutputGroupSettings()
        {
            return this._outputGroupSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. This object holds groups of encoding settings,
        /// one group of settings per output.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Output> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && (this._outputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}