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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Specifies the default recording frequency that Config uses to record configuration
    /// changes. Config supports <i>Continuous recording</i> and <i>Daily recording</i>.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Continuous recording allows you to record configuration changes continuously whenever
    /// a change occurs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Daily recording allows you record configuration data once every 24 hours, only if
    /// a change has occurred.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Firewall Manager depends on continuous recording to monitor your resources. If you
    /// are using Firewall Manager, it is recommended that you set the recording frequency
    /// to Continuous.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can also override the recording frequency for specific resource types.
    /// </para>
    /// </summary>
    public partial class RecordingMode
    {
        private RecordingFrequency _recordingFrequency;
        private List<RecordingModeOverride> _recordingModeOverrides = new List<RecordingModeOverride>();

        /// <summary>
        /// Gets and sets the property RecordingFrequency. 
        /// <para>
        /// The default recording frequency that Config uses to record configuration changes.
        /// </para>
        ///  <important> 
        /// <para>
        /// Daily recording is not supported for the following resource types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AWS::Config::ResourceCompliance</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::Config::ConformancePackCompliance</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS::Config::ConfigurationRecorder</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the <b>allSupported</b> (<code>ALL_SUPPORTED_RESOURCE_TYPES</code>) recording
        /// strategy, these resource types will be set to Continuous recording.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecordingFrequency RecordingFrequency
        {
            get { return this._recordingFrequency; }
            set { this._recordingFrequency = value; }
        }

        // Check to see if RecordingFrequency property is set
        internal bool IsSetRecordingFrequency()
        {
            return this._recordingFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property RecordingModeOverrides. 
        /// <para>
        /// An array of <code>recordingModeOverride</code> objects for you to specify your overrides
        /// for the recording mode. The <code>recordingModeOverride</code> object in the <code>recordingModeOverrides</code>
        /// array consists of three fields: a <code>description</code>, the new <code>recordingFrequency</code>,
        /// and an array of <code>resourceTypes</code> to override.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<RecordingModeOverride> RecordingModeOverrides
        {
            get { return this._recordingModeOverrides; }
            set { this._recordingModeOverrides = value; }
        }

        // Check to see if RecordingModeOverrides property is set
        internal bool IsSetRecordingModeOverrides()
        {
            return this._recordingModeOverrides != null && this._recordingModeOverrides.Count > 0; 
        }

    }
}