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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// An Amazon CloudWatch log group that contains log anomalies and is used to generate
    /// an insight.
    /// </summary>
    public partial class AnomalousLogGroup
    {
        private DateTime? _impactEndTime;
        private DateTime? _impactStartTime;
        private List<LogAnomalyShowcase> _logAnomalyShowcases = AWSConfigs.InitializeCollections ? new List<LogAnomalyShowcase>() : null;
        private string _logGroupName;
        private int? _numberOfLogLinesScanned;

        /// <summary>
        /// Gets and sets the property ImpactEndTime. 
        /// <para>
        ///  The time the anomalous log events stopped. 
        /// </para>
        /// </summary>
        public DateTime? ImpactEndTime
        {
            get { return this._impactEndTime; }
            set { this._impactEndTime = value; }
        }

        // Check to see if ImpactEndTime property is set
        internal bool IsSetImpactEndTime()
        {
            return this._impactEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImpactStartTime. 
        /// <para>
        ///  The time the anomalous log events began. The impact start time indicates the time
        /// of the first log anomaly event that occurs. 
        /// </para>
        /// </summary>
        public DateTime? ImpactStartTime
        {
            get { return this._impactStartTime; }
            set { this._impactStartTime = value; }
        }

        // Check to see if ImpactStartTime property is set
        internal bool IsSetImpactStartTime()
        {
            return this._impactStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogAnomalyShowcases. 
        /// <para>
        ///  The log anomalies in the log group. Each log anomaly displayed represents a cluster
        /// of similar anomalous log events. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<LogAnomalyShowcase> LogAnomalyShowcases
        {
            get { return this._logAnomalyShowcases; }
            set { this._logAnomalyShowcases = value; }
        }

        // Check to see if LogAnomalyShowcases property is set
        internal bool IsSetLogAnomalyShowcases()
        {
            return this._logAnomalyShowcases != null && (this._logAnomalyShowcases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        ///  The name of the CloudWatch log group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfLogLinesScanned. 
        /// <para>
        ///  The number of log lines that were scanned for anomalous log events. 
        /// </para>
        /// </summary>
        public int? NumberOfLogLinesScanned
        {
            get { return this._numberOfLogLinesScanned; }
            set { this._numberOfLogLinesScanned = value; }
        }

        // Check to see if NumberOfLogLinesScanned property is set
        internal bool IsSetNumberOfLogLinesScanned()
        {
            return this._numberOfLogLinesScanned.HasValue; 
        }

    }
}