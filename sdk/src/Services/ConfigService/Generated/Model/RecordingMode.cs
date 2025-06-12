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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// Daily recording allows you to receive a configuration item (CI) representing the most
    /// recent state of your resources over the last 24-hour period, only if it’s different
    /// from the previous CI recorded. 
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
        private List<RecordingModeOverride> _recordingModeOverrides = AWSConfigs.InitializeCollections ? new List<RecordingModeOverride>() : null;

        /// <summary>
        /// Gets and sets the property RecordingFrequency. 
        /// <para>
        /// The default recording frequency that Config uses to record configuration changes.
        /// </para>
        ///  <important> 
        /// <para>
        /// Daily recording cannot be specified for the following resource types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS::Config::ResourceCompliance</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Config::ConformancePackCompliance</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Config::ConfigurationRecorder</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the <b>allSupported</b> (<c>ALL_SUPPORTED_RESOURCE_TYPES</c>) recording strategy,
        /// these resource types will be set to Continuous recording.
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
        /// An array of <c>recordingModeOverride</c> objects for you to specify your overrides
        /// for the recording mode. The <c>recordingModeOverride</c> object in the <c>recordingModeOverrides</c>
        /// array consists of three fields: a <c>description</c>, the new <c>recordingFrequency</c>,
        /// and an array of <c>resourceTypes</c> to override.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._recordingModeOverrides != null && (this._recordingModeOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}