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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ZonalStatisticsConfigInput
    {
        private List<string> _statistics = new List<string>();
        private List<string> _targetBands = new List<string>();
        private string _zoneS3Path;

        /// <summary>
        /// Gets and sets the property Statistics.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && this._statistics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetBands.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> TargetBands
        {
            get { return this._targetBands; }
            set { this._targetBands = value; }
        }

        // Check to see if TargetBands property is set
        internal bool IsSetTargetBands()
        {
            return this._targetBands != null && this._targetBands.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ZoneS3Path.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ZoneS3Path
        {
            get { return this._zoneS3Path; }
            set { this._zoneS3Path = value; }
        }

        // Check to see if ZoneS3Path property is set
        internal bool IsSetZoneS3Path()
        {
            return this._zoneS3Path != null;
        }

    }
}