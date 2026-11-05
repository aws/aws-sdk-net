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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Settings for one failover condition.
    /// </summary>
    public partial class FailoverConditionSettings
    {
        /// <summary>
        /// Gets and sets the property AudioSilenceSettings. MediaLive will perform a failover
        /// if the specified audio selector is silent for the specified period.
        /// </summary>
        public AudioSilenceFailoverSettings AudioSilenceSettings { get; set; }

        /// <summary>
        /// Checks to see if the AudioSilenceSettings property is set.
        /// </summary>
        internal bool IsSetAudioSilenceSettings() => this.AudioSilenceSettings != null;

        /// <summary>
        /// Gets and sets the property InputLossSettings. MediaLive will perform a failover if
        /// content is not detected in this input for the specified period.
        /// </summary>
        public InputLossFailoverSettings InputLossSettings { get; set; }

        /// <summary>
        /// Checks to see if the InputLossSettings property is set.
        /// </summary>
        internal bool IsSetInputLossSettings() => this.InputLossSettings != null;

        /// <summary>
        /// Gets and sets the property VideoBlackSettings. MediaLive will perform a failover if
        /// content is considered black for the specified period.
        /// </summary>
        public VideoBlackFailoverSettings VideoBlackSettings { get; set; }

        /// <summary>
        /// Checks to see if the VideoBlackSettings property is set.
        /// </summary>
        internal bool IsSetVideoBlackSettings() => this.VideoBlackSettings != null;
    }
}
