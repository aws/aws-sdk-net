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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The configuration for pre-roll ad insertion.
    /// </summary>
    public partial class LivePreRollConfiguration
    {
        /// <summary>
        /// Gets and sets the property AdDecisionServerConfiguration. 
        /// <para>
        /// The configuration for the ad decision server (ADS) for live pre-roll ads. The configuration
        /// contains settings that control how MediaTailor processes VAST responses for pre-roll
        /// ad breaks.
        /// </para>
        /// </summary>
        public PreRollAdDecisionServerConfiguration AdDecisionServerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AdDecisionServerConfiguration property is set.
        /// </summary>
        internal bool IsSetAdDecisionServerConfiguration() => this.AdDecisionServerConfiguration != null;

        /// <summary>
        /// Gets and sets the property AdDecisionServerUrl. 
        /// <para>
        /// The URL for the ad decision server (ADS) for pre-roll ads. This includes the specification
        /// of static parameters and placeholders for dynamic parameters. AWS Elemental MediaTailor
        /// substitutes player-specific and session-specific parameters as needed when calling
        /// the ADS. Alternately, for testing, you can provide a static VAST URL. The maximum
        /// length is 25,000 characters.
        /// </para>
        /// </summary>
        public string AdDecisionServerUrl { get; set; }

        /// <summary>
        /// Checks to see if the AdDecisionServerUrl property is set.
        /// </summary>
        internal bool IsSetAdDecisionServerUrl() => this.AdDecisionServerUrl != null;

        /// <summary>
        /// Gets and sets the property MaxDurationSeconds. 
        /// <para>
        /// The maximum allowed duration for the pre-roll ad avail. AWS Elemental MediaTailor
        /// won't play pre-roll ads to exceed this duration, regardless of the total duration
        /// of ads that the ADS returns.
        /// </para>
        /// </summary>
        public int? MaxDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaxDurationSeconds property is set.
        /// </summary>
        internal bool IsSetMaxDurationSeconds() => this.MaxDurationSeconds.HasValue;
    }
}
