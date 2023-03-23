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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// The configuration settings for the SNS topic sink.
    /// </summary>
    public partial class SnsTopicSinkConfiguration
    {
        private string _insightsTarget;

        /// <summary>
        /// Gets and sets the property InsightsTarget. 
        /// <para>
        /// The URL of the SNS sink, <a href="https://aws.amazon.com/kinesis/data-streams/">https://aws.amazon.com/kinesis/data-streams/</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string InsightsTarget
        {
            get { return this._insightsTarget; }
            set { this._insightsTarget = value; }
        }

        // Check to see if InsightsTarget property is set
        internal bool IsSetInsightsTarget()
        {
            return this._insightsTarget != null;
        }

    }
}