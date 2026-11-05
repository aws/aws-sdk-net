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
    /// A time range that specifies when DevOps Guru opens and then closes an anomaly. This
    /// is different from <c>AnomalyTimeRange</c>, which specifies the time range when DevOps
    /// Guru actually observes the anomalous behavior.
    /// </summary>
    public partial class AnomalyReportedTimeRange
    {
        /// <summary>
        /// Gets and sets the property CloseTime. 
        /// <para>
        ///  The time when an anomaly is closed. 
        /// </para>
        /// </summary>
        public DateTime? CloseTime { get; set; }

        /// <summary>
        /// Checks to see if the CloseTime property is set.
        /// </summary>
        internal bool IsSetCloseTime() => this.CloseTime.HasValue;

        /// <summary>
        /// Gets and sets the property OpenTime. 
        /// <para>
        ///  The time when an anomaly is opened. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? OpenTime { get; set; }

        /// <summary>
        /// Checks to see if the OpenTime property is set.
        /// </summary>
        internal bool IsSetOpenTime() => this.OpenTime.HasValue;
    }
}
