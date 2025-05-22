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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
        private int? _probability;
        private string _reportingUrl;

        /// <summary>
        /// Gets and sets the property Probability. 
        /// <para>
        /// The number of playback devices per 1000 that will send error reports to the reporting
        /// URL. This represents the probability that a playback device will be a reporting player
        /// for this session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? Probability
        {
            get { return this._probability; }
            set { this._probability = value; }
        }

        // Check to see if Probability property is set
        internal bool IsSetProbability()
        {
            return this._probability.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportingUrl. 
        /// <para>
        /// The URL where playback devices send error reports.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ReportingUrl
        {
            get { return this._reportingUrl; }
            set { this._reportingUrl = value; }
        }

        // Check to see if ReportingUrl property is set
        internal bool IsSetReportingUrl()
        {
            return this._reportingUrl != null;
        }

    }
}