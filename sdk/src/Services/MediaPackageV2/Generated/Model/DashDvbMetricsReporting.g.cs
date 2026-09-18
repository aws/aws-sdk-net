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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// For use with DVB-DASH profiles only. The settings for error reporting from the playback
    /// device that you want Elemental MediaPackage to pass through to the manifest.
    /// </summary>
    public partial class DashDvbMetricsReporting
    {
        /// <summary>
        /// Gets and sets the property Probability. 
        /// <para>
        /// The number of playback devices per 1000 that will send error reports to the reporting
        /// URL. This represents the probability that a playback device will be a reporting player
        /// for this session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? Probability { get; set; }

        /// <summary>
        /// Checks to see if the Probability property is set.
        /// </summary>
        internal bool IsSetProbability() => this.Probability.HasValue;

        /// <summary>
        /// Gets and sets the property ReportingUrl. 
        /// <para>
        /// The URL where playback devices send error reports.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ReportingUrl { get; set; }

        /// <summary>
        /// Checks to see if the ReportingUrl property is set.
        /// </summary>
        internal bool IsSetReportingUrl() => this.ReportingUrl != null;
    }
}
