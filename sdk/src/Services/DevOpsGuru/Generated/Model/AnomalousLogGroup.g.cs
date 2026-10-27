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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// An Amazon CloudWatch log group that contains log anomalies and is used to generate
    /// an insight.
    /// </summary>
    public partial class AnomalousLogGroup
    {
        /// <summary>
        /// Gets and sets the property ImpactEndTime. 
        /// <para>
        ///  The time the anomalous log events stopped. 
        /// </para>
        /// </summary>
        public DateTime? ImpactEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ImpactEndTime property is set.
        /// </summary>
        internal bool IsSetImpactEndTime() => this.ImpactEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ImpactStartTime. 
        /// <para>
        ///  The time the anomalous log events began. The impact start time indicates the time
        /// of the first log anomaly event that occurs. 
        /// </para>
        /// </summary>
        public DateTime? ImpactStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ImpactStartTime property is set.
        /// </summary>
        internal bool IsSetImpactStartTime() => this.ImpactStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property LogAnomalyShowcases. 
        /// <para>
        ///  The log anomalies in the log group. Each log anomaly displayed represents a cluster
        /// of similar anomalous log events. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<LogAnomalyShowcase> LogAnomalyShowcases { get; set; } = AWSConfigs.InitializeCollections ? new List<LogAnomalyShowcase>() : null;

        /// <summary>
        /// Checks to see if the LogAnomalyShowcases property is set.
        /// </summary>
        internal bool IsSetLogAnomalyShowcases() => this.LogAnomalyShowcases != null && (this.LogAnomalyShowcases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        ///  The name of the CloudWatch log group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property NumberOfLogLinesScanned. 
        /// <para>
        ///  The number of log lines that were scanned for anomalous log events. 
        /// </para>
        /// </summary>
        public int? NumberOfLogLinesScanned { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfLogLinesScanned property is set.
        /// </summary>
        internal bool IsSetNumberOfLogLinesScanned() => this.NumberOfLogLinesScanned.HasValue;
    }
}
