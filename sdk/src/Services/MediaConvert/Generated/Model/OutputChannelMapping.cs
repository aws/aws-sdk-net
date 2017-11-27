/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// OutputChannel mapping settings.
    /// </summary>
    public partial class OutputChannelMapping
    {
        private List<int> _inputChannels = new List<int>();

        /// <summary>
        /// Gets and sets the property InputChannels. List of input channels
        /// </summary>
        public List<int> InputChannels
        {
            get { return this._inputChannels; }
            set { this._inputChannels = value; }
        }

        // Check to see if InputChannels property is set
        internal bool IsSetInputChannels()
        {
            return this._inputChannels != null && this._inputChannels.Count > 0; 
        }

    }
}