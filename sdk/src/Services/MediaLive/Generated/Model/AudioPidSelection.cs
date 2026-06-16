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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Audio Pid Selection
    /// </summary>
    public partial class AudioPidSelection
    {
        private int? _pid;
        private List<AudioPid> _pids = AWSConfigs.InitializeCollections ? new List<AudioPid>() : null;

        /// <summary>
        /// Gets and sets the property Pid. Selects a specific PID from within a source.
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Pid
        {
            get { return this._pid; }
            set { this._pid = value; }
        }

        // Check to see if Pid property is set
        internal bool IsSetPid()
        {
            return this._pid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pids. Selects one or more unique PIDs from within a source.When
        /// using 'pids', you can specify per-PID audio pre-mixer settings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AudioPid> Pids
        {
            get { return this._pids; }
            set { this._pids = value; }
        }

        // Check to see if Pids property is set
        internal bool IsSetPids()
        {
            return this._pids != null && (this._pids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}