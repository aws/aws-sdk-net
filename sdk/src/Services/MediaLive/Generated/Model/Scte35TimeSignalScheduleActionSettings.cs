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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// SCTE-35 Time Signal Settings.
    /// </summary>
    public partial class Scte35TimeSignalScheduleActionSettings
    {
        private List<Scte35Descriptor> _scte35Descriptors = new List<Scte35Descriptor>();

        /// <summary>
        /// Gets and sets the property Scte35Descriptors. The list of SCTE-35 descriptors accompanying
        /// the SCTE-35 time_signal.
        /// </summary>
        public List<Scte35Descriptor> Scte35Descriptors
        {
            get { return this._scte35Descriptors; }
            set { this._scte35Descriptors = value; }
        }

        // Check to see if Scte35Descriptors property is set
        internal bool IsSetScte35Descriptors()
        {
            return this._scte35Descriptors != null && this._scte35Descriptors.Count > 0; 
        }

    }
}