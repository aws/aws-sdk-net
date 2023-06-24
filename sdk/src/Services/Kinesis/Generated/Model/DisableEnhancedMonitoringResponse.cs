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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Represents the output for <a>EnableEnhancedMonitoring</a> and <a>DisableEnhancedMonitoring</a>.
    /// </summary>
    public partial class DisableEnhancedMonitoringResponse : AmazonWebServiceResponse
    {
        private List<string> _currentShardLevelMetrics = new List<string>();
        private List<string> _desiredShardLevelMetrics = new List<string>();
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property CurrentShardLevelMetrics. 
        /// <para>
        /// Represents the current state of the metrics that are in the enhanced state before
        /// the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public List<string> CurrentShardLevelMetrics
        {
            get { return this._currentShardLevelMetrics; }
            set { this._currentShardLevelMetrics = value; }
        }

        // Check to see if CurrentShardLevelMetrics property is set
        internal bool IsSetCurrentShardLevelMetrics()
        {
            return this._currentShardLevelMetrics != null && this._currentShardLevelMetrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DesiredShardLevelMetrics. 
        /// <para>
        /// Represents the list of all the metrics that would be in the enhanced state after the
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public List<string> DesiredShardLevelMetrics
        {
            get { return this._desiredShardLevelMetrics; }
            set { this._desiredShardLevelMetrics = value; }
        }

        // Check to see if DesiredShardLevelMetrics property is set
        internal bool IsSetDesiredShardLevelMetrics()
        {
            return this._desiredShardLevelMetrics != null && this._desiredShardLevelMetrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the Kinesis data stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}