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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Aggregated details about the measures contributing to the anomaly group, and the measures
    /// potentially impacted by the anomaly group.
    /// </summary>
    public partial class InterMetricImpactDetails
    {
        private string _anomalyGroupId;
        private double? _contributionPercentage;
        private string _metricName;
        private RelationshipType _relationshipType;

        /// <summary>
        /// Gets and sets the property AnomalyGroupId. 
        /// <para>
        /// The ID of the anomaly group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string AnomalyGroupId
        {
            get { return this._anomalyGroupId; }
            set { this._anomalyGroupId = value; }
        }

        // Check to see if AnomalyGroupId property is set
        internal bool IsSetAnomalyGroupId()
        {
            return this._anomalyGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ContributionPercentage. 
        /// <para>
        /// For potential causes (<c>CAUSE_OF_INPUT_ANOMALY_GROUP</c>), the percentage contribution
        /// the measure has in causing the anomalies.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? ContributionPercentage
        {
            get { return this._contributionPercentage; }
            set { this._contributionPercentage = value; }
        }

        // Check to see if ContributionPercentage property is set
        internal bool IsSetContributionPercentage()
        {
            return this._contributionPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the measure.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property RelationshipType. 
        /// <para>
        /// Whether a measure is a potential cause of the anomaly group (<c>CAUSE_OF_INPUT_ANOMALY_GROUP</c>),
        /// or whether the measure is impacted by the anomaly group (<c>EFFECT_OF_INPUT_ANOMALY_GROUP</c>).
        /// </para>
        /// </summary>
        public RelationshipType RelationshipType
        {
            get { return this._relationshipType; }
            set { this._relationshipType = value; }
        }

        // Check to see if RelationshipType property is set
        internal bool IsSetRelationshipType()
        {
            return this._relationshipType != null;
        }

    }
}