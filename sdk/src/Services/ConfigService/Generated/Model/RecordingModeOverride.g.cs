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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// An object for you to specify your overrides for the recording mode.
    /// </summary>
    public partial class RecordingModeOverride
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description that you provide for the override.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property RecordingFrequency. 
        /// <para>
        /// The recording frequency that will be applied to all the resource types specified in
        /// the override.
        /// </para>
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
        /// </summary>
        [AWSProperty(Required = true)]
        public RecordingFrequency RecordingFrequency { get; set; }

        /// <summary>
        /// Checks to see if the RecordingFrequency property is set.
        /// </summary>
        internal bool IsSetRecordingFrequency() => this.RecordingFrequency != null;

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// A comma-separated list that specifies which resource types Config includes in the
        /// override.
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
        ///  </li> </ul> </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null && (this.ResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
