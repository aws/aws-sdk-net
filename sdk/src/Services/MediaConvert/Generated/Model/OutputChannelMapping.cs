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
    /// OutputChannel mapping settings.
    /// </summary>
    public partial class OutputChannelMapping
    {
        private List<int> _inputChannels = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<double> _inputChannelsFineTune = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Gets and sets the property InputChannels. Use this setting to specify your remix values
        /// when they are integers, such as -10, 0, or 4.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> InputChannels
        {
            get { return this._inputChannels; }
            set { this._inputChannels = value; }
        }

        // Check to see if InputChannels property is set
        internal bool IsSetInputChannels()
        {
            return this._inputChannels != null && (this._inputChannels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InputChannelsFineTune. Use this setting to specify your
        /// remix values when they have a decimal component, such as -10.312, 0.08, or 4.9. MediaConvert
        /// rounds your remixing values to the nearest thousandth.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> InputChannelsFineTune
        {
            get { return this._inputChannelsFineTune; }
            set { this._inputChannelsFineTune = value; }
        }

        // Check to see if InputChannelsFineTune property is set
        internal bool IsSetInputChannelsFineTune()
        {
            return this._inputChannelsFineTune != null && (this._inputChannelsFineTune.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}