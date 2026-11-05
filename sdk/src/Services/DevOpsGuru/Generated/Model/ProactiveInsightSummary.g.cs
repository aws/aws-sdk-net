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
    /// Details about a proactive insight. This object is returned by <c>DescribeInsight.</c>
    /// </summary>
    public partial class ProactiveInsightSummary
    {
        /// <summary>
        /// Gets and sets the property AssociatedResourceArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the Amazon Web Services resources that generated
        /// this insight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedResourceArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedResourceArns property is set.
        /// </summary>
        internal bool IsSetAssociatedResourceArns() => this.AssociatedResourceArns != null && (this.AssociatedResourceArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the proactive insight. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InsightTimeRange.
        /// </summary>
        public InsightTimeRange InsightTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the InsightTimeRange property is set.
        /// </summary>
        internal bool IsSetInsightTimeRange() => this.InsightTimeRange != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the proactive insight. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 530)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PredictionTimeRange.
        /// </summary>
        public PredictionTimeRange PredictionTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the PredictionTimeRange property is set.
        /// </summary>
        internal bool IsSetPredictionTimeRange() => this.PredictionTimeRange != null;

        /// <summary>
        /// Gets and sets the property ResourceCollection.
        /// </summary>
        public ResourceCollection ResourceCollection { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCollection property is set.
        /// </summary>
        internal bool IsSetResourceCollection() => this.ResourceCollection != null;

        /// <summary>
        /// Gets and sets the property ServiceCollection. 
        /// <para>
        /// A collection of the names of Amazon Web Services services.
        /// </para>
        /// </summary>
        public ServiceCollection ServiceCollection { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCollection property is set.
        /// </summary>
        internal bool IsSetServiceCollection() => this.ServiceCollection != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the insight. For more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/working-with-insights.html#understanding-insights-severities">Understanding
        /// insight severities</a> in the <i>Amazon DevOps Guru User Guide</i>.
        /// </para>
        /// </summary>
        public InsightSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the proactive insight. 
        /// </para>
        /// </summary>
        public InsightStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
