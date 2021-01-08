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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Output groups for this Live Event. Output groups contain information about where streams
    /// should be distributed.
    /// </summary>
    public partial class OutputGroup
    {
        private string _name;
        private OutputGroupSettings _outputGroupSettings;
        private List<Output> _outputs = new List<Output>();

        /// <summary>
        /// Gets and sets the property Name. Custom output group name optionally defined by the
        /// user.  Only letters, numbers, and the underscore character allowed; only 32 characters
        /// allowed.
        /// </summary>
        [AWSProperty(Max=32)]
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
        /// Gets and sets the property OutputGroupSettings. Settings associated with the output
        /// group.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Outputs.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Output> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && this._outputs.Count > 0; 
        }

    }
}