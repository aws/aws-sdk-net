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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// An unusual cost pattern. This consists of the detailed metadata and the current status
    /// of the anomaly object.
    /// </summary>
    public partial class Anomaly
    {
        /// <summary>
        /// Gets and sets the property AnomalyEndDate. 
        /// <para>
        /// The last day the anomaly is detected. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 40)]
        public string AnomalyEndDate { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyEndDate property is set.
        /// </summary>
        internal bool IsSetAnomalyEndDate() => this.AnomalyEndDate != null;

        /// <summary>
        /// Gets and sets the property AnomalyId. 
        /// <para>
        /// The unique identifier for the anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string AnomalyId { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyId property is set.
        /// </summary>
        internal bool IsSetAnomalyId() => this.AnomalyId != null;

        /// <summary>
        /// Gets and sets the property AnomalyScore. 
        /// <para>
        /// The latest and maximum score for the anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnomalyScore AnomalyScore { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyScore property is set.
        /// </summary>
        internal bool IsSetAnomalyScore() => this.AnomalyScore != null;

        /// <summary>
        /// Gets and sets the property AnomalyStartDate. 
        /// <para>
        /// The first day the anomaly is detected. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 40)]
        public string AnomalyStartDate { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyStartDate property is set.
        /// </summary>
        internal bool IsSetAnomalyStartDate() => this.AnomalyStartDate != null;

        /// <summary>
        /// Gets and sets the property DimensionValue. 
        /// <para>
        /// The dimension for the anomaly (for example, an Amazon Web Services service in a service
        /// monitor). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DimensionValue { get; set; }

        /// <summary>
        /// Checks to see if the DimensionValue property is set.
        /// </summary>
        internal bool IsSetDimensionValue() => this.DimensionValue != null;

        /// <summary>
        /// Gets and sets the property Feedback. 
        /// <para>
        /// The feedback value. 
        /// </para>
        /// </summary>
        public AnomalyFeedbackType Feedback { get; set; }

        /// <summary>
        /// Checks to see if the Feedback property is set.
        /// </summary>
        internal bool IsSetFeedback() => this.Feedback != null;

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// The dollar impact for the anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Impact Impact { get; set; }

        /// <summary>
        /// Checks to see if the Impact property is set.
        /// </summary>
        internal bool IsSetImpact() => this.Impact != null;

        /// <summary>
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the cost monitor that generated this anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string MonitorArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitorArn property is set.
        /// </summary>
        internal bool IsSetMonitorArn() => this.MonitorArn != null;

        /// <summary>
        /// Gets and sets the property RootCauses. 
        /// <para>
        /// The list of identified root causes for the anomaly. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RootCause> RootCauses { get; set; } = AWSConfigs.InitializeCollections ? new List<RootCause>() : null;

        /// <summary>
        /// Checks to see if the RootCauses property is set.
        /// </summary>
        internal bool IsSetRootCauses() => this.RootCauses != null && (this.RootCauses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
