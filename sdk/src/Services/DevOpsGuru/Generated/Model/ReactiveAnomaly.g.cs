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
    /// Details about a reactive anomaly. This object is returned by <c>ListAnomalies</c>.
    /// </summary>
    public partial class ReactiveAnomaly
    {
        /// <summary>
        /// Gets and sets the property AnomalyReportedTimeRange. 
        /// <para>
        ///  An <c>AnomalyReportedTimeRange</c> object that specifies the time range between when
        /// the anomaly is opened and the time when it is closed. 
        /// </para>
        /// </summary>
        public AnomalyReportedTimeRange AnomalyReportedTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyReportedTimeRange property is set.
        /// </summary>
        internal bool IsSetAnomalyReportedTimeRange() => this.AnomalyReportedTimeRange != null;

        /// <summary>
        /// Gets and sets the property AnomalyResources. 
        /// <para>
        /// The Amazon Web Services resources in which anomalous behavior was detected by DevOps
        /// Guru.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnomalyResource> AnomalyResources { get; set; } = AWSConfigs.InitializeCollections ? new List<AnomalyResource>() : null;

        /// <summary>
        /// Checks to see if the AnomalyResources property is set.
        /// </summary>
        internal bool IsSetAnomalyResources() => this.AnomalyResources != null && (this.AnomalyResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AnomalyTimeRange.
        /// </summary>
        public AnomalyTimeRange AnomalyTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyTimeRange property is set.
        /// </summary>
        internal bool IsSetAnomalyTimeRange() => this.AnomalyTimeRange != null;

        /// <summary>
        /// Gets and sets the property AssociatedInsightId. 
        /// <para>
        ///  The ID of the insight that contains this anomaly. An insight is composed of related
        /// anomalies. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string AssociatedInsightId { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedInsightId property is set.
        /// </summary>
        internal bool IsSetAssociatedInsightId() => this.AssociatedInsightId != null;

        /// <summary>
        /// Gets and sets the property CausalAnomalyId. 
        /// <para>
        /// The ID of the causal anomaly that is associated with this reactive anomaly. The ID
        /// of a `CAUSAL` anomaly is always `NULL`.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string CausalAnomalyId { get; set; }

        /// <summary>
        /// Checks to see if the CausalAnomalyId property is set.
        /// </summary>
        internal bool IsSetCausalAnomalyId() => this.CausalAnomalyId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the reactive anomaly.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the reactive anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the reactive anomaly.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceCollection.
        /// </summary>
        public ResourceCollection ResourceCollection { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCollection property is set.
        /// </summary>
        internal bool IsSetResourceCollection() => this.ResourceCollection != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the anomaly. The severity of anomalies that generate an insight determine
        /// that insight's severity. For more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/working-with-insights.html#understanding-insights-severities">Understanding
        /// insight severities</a> in the <i>Amazon DevOps Guru User Guide</i>.
        /// </para>
        /// </summary>
        public AnomalySeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property SourceDetails. 
        /// <para>
        ///  Details about the source of the analyzed operational data that triggered the anomaly.
        /// The one supported source is Amazon CloudWatch metrics. 
        /// </para>
        /// </summary>
        public AnomalySourceDetails SourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the SourceDetails property is set.
        /// </summary>
        internal bool IsSetSourceDetails() => this.SourceDetails != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the anomaly. 
        /// </para>
        /// </summary>
        public AnomalyStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the reactive anomaly. It can be one of the following types.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CAUSAL</c> - the anomaly can cause a new insight.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONTEXTUAL</c> - the anomaly contains additional information about an insight
        /// or its causal anomaly.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AnomalyType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
