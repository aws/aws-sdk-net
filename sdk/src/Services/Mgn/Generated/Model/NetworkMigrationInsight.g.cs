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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// An insight produced during a network migration, such as a warning, decision, question,
    /// or other context beyond the migrated output.
    /// </summary>
    public partial class NetworkMigrationInsight
    {
        /// <summary>
        /// Gets and sets the property ConstructID. 
        /// <para>
        /// The unique identifier of the construct the insight relates to; absent for run-level
        /// and segment-level insights.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ConstructID { get; set; }

        /// <summary>
        /// Checks to see if the ConstructID property is set.
        /// </summary>
        internal bool IsSetConstructID() => this.ConstructID != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the insight was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property InsightID. 
        /// <para>
        /// The unique identifier of the insight.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string InsightID { get; set; }

        /// <summary>
        /// Checks to see if the InsightID property is set.
        /// </summary>
        internal bool IsSetInsightID() => this.InsightID != null;

        /// <summary>
        /// Gets and sets the property InsightLevel. 
        /// <para>
        /// The level that the insight applies to: the run, a segment, or a construct.
        /// </para>
        /// </summary>
        public InsightLevel InsightLevel { get; set; }

        /// <summary>
        /// Checks to see if the InsightLevel property is set.
        /// </summary>
        internal bool IsSetInsightLevel() => this.InsightLevel != null;

        /// <summary>
        /// Gets and sets the property InsightMessage. 
        /// <para>
        /// The content of the insight.
        /// </para>
        /// </summary>
        public InsightMessage InsightMessage { get; set; }

        /// <summary>
        /// Checks to see if the InsightMessage property is set.
        /// </summary>
        internal bool IsSetInsightMessage() => this.InsightMessage != null;

        /// <summary>
        /// Gets and sets the property InsightType. 
        /// <para>
        /// The type of the insight.
        /// </para>
        /// </summary>
        public InsightType InsightType { get; set; }

        /// <summary>
        /// Checks to see if the InsightType property is set.
        /// </summary>
        internal bool IsSetInsightType() => this.InsightType != null;

        /// <summary>
        /// Gets and sets the property NetworkMigrationDefinitionID. 
        /// <para>
        /// The unique identifier of the network migration definition the insight belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string NetworkMigrationDefinitionID { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMigrationDefinitionID property is set.
        /// </summary>
        internal bool IsSetNetworkMigrationDefinitionID() => this.NetworkMigrationDefinitionID != null;

        /// <summary>
        /// Gets and sets the property NetworkMigrationExecutionID. 
        /// <para>
        /// The unique identifier of the network migration execution the insight belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string NetworkMigrationExecutionID { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMigrationExecutionID property is set.
        /// </summary>
        internal bool IsSetNetworkMigrationExecutionID() => this.NetworkMigrationExecutionID != null;

        /// <summary>
        /// Gets and sets the property ProducerID. 
        /// <para>
        /// The identifier of the job or API request that produced the insight.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProducerID { get; set; }

        /// <summary>
        /// Checks to see if the ProducerID property is set.
        /// </summary>
        internal bool IsSetProducerID() => this.ProducerID != null;

        /// <summary>
        /// Gets and sets the property ProducerName. 
        /// <para>
        /// The job type or API name that produced the insight.
        /// </para>
        /// </summary>
        public InsightProducerName ProducerName { get; set; }

        /// <summary>
        /// Checks to see if the ProducerName property is set.
        /// </summary>
        internal bool IsSetProducerName() => this.ProducerName != null;

        /// <summary>
        /// Gets and sets the property ProducerType. 
        /// <para>
        /// Whether the insight was produced by a job or by an API request.
        /// </para>
        /// </summary>
        public InsightProducerType ProducerType { get; set; }

        /// <summary>
        /// Checks to see if the ProducerType property is set.
        /// </summary>
        internal bool IsSetProducerType() => this.ProducerType != null;

        /// <summary>
        /// Gets and sets the property SegmentID. 
        /// <para>
        /// The unique identifier of the segment the insight relates to; absent for run-level
        /// insights.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SegmentID { get; set; }

        /// <summary>
        /// Checks to see if the SegmentID property is set.
        /// </summary>
        internal bool IsSetSegmentID() => this.SegmentID != null;
    }
}
