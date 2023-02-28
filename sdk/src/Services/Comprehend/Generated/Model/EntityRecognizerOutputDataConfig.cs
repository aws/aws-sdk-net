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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Output data configuration.
    /// </summary>
    public partial class EntityRecognizerOutputDataConfig
    {
        private string _flywheelStatsS3Prefix;

        /// <summary>
        /// Gets and sets the property FlywheelStatsS3Prefix. 
        /// <para>
        /// The Amazon S3 prefix for the data lake location of the flywheel statistics.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FlywheelStatsS3Prefix
        {
            get { return this._flywheelStatsS3Prefix; }
            set { this._flywheelStatsS3Prefix = value; }
        }

        // Check to see if FlywheelStatsS3Prefix property is set
        internal bool IsSetFlywheelStatsS3Prefix()
        {
            return this._flywheelStatsS3Prefix != null;
        }

    }
}