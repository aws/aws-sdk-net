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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// An object representing a configuration to record a stage stream.
    /// </summary>
    public partial class RecordingConfiguration
    {
        private RecordingConfigurationFormat _format;
        private CompositionRecordingHlsConfiguration _hlsConfiguration;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The recording format for storing a recording in Amazon S3.
        /// </para>
        /// </summary>
        public RecordingConfigurationFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property HlsConfiguration. 
        /// <para>
        /// An HLS configuration object to return information about how the recording will be
        /// configured.
        /// </para>
        /// </summary>
        public CompositionRecordingHlsConfiguration HlsConfiguration
        {
            get { return this._hlsConfiguration; }
            set { this._hlsConfiguration = value; }
        }

        // Check to see if HlsConfiguration property is set
        internal bool IsSetHlsConfiguration()
        {
            return this._hlsConfiguration != null;
        }

    }
}