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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Details about a proactive anomaly. This object is returned by <code>DescribeAnomaly.</code>
    /// </summary>
    public partial class ProactiveAnomalySummary
    {
        private AnomalyReportedTimeRange _anomalyReportedTimeRange;
        private List<AnomalyResource> _anomalyResources = new List<AnomalyResource>();
        private AnomalyTimeRange _anomalyTimeRange;
        private string _associatedInsightId;
        private string _description;
        private string _id;
        private double? _limit;
        private PredictionTimeRange _predictionTimeRange;
        private ResourceCollection _resourceCollection;
        private AnomalySeverity _severity;
        private AnomalySourceDetails _sourceDetails;
        private AnomalySourceMetadata _sourceMetadata;
        private AnomalyStatus _status;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property AnomalyReportedTimeRange. 
        /// <para>
        ///  An <code>AnomalyReportedTimeRange</code> object that specifies the time range between
        /// when the anomaly is opened and the time when it is closed. 
        /// </para>
        /// </summary>
        public AnomalyReportedTimeRange AnomalyReportedTimeRange
        {
            get { return this._anomalyReportedTimeRange; }
            set { this._anomalyReportedTimeRange = value; }
        }

        // Check to see if AnomalyReportedTimeRange property is set
        internal bool IsSetAnomalyReportedTimeRange()
        {
            return this._anomalyReportedTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyResources. 
        /// <para>
        /// Information about a resource in which DevOps Guru detected anomalous behavior.
        /// </para>
        /// </summary>
        public List<AnomalyResource> AnomalyResources
        {
            get { return this._anomalyResources; }
            set { this._anomalyResources = value; }
        }

        // Check to see if AnomalyResources property is set
        internal bool IsSetAnomalyResources()
        {
            return this._anomalyResources != null && this._anomalyResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AnomalyTimeRange.
        /// </summary>
        public AnomalyTimeRange AnomalyTimeRange
        {
            get { return this._anomalyTimeRange; }
            set { this._anomalyTimeRange = value; }
        }

        // Check to see if AnomalyTimeRange property is set
        internal bool IsSetAnomalyTimeRange()
        {
            return this._anomalyTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedInsightId. 
        /// <para>
        ///  The ID of the insight that contains this anomaly. An insight is composed of related
        /// anomalies. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AssociatedInsightId
        {
            get { return this._associatedInsightId; }
            set { this._associatedInsightId = value; }
        }

        // Check to see if AssociatedInsightId property is set
        internal bool IsSetAssociatedInsightId()
        {
            return this._associatedInsightId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the proactive anomaly. 
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the anomaly.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        ///  A threshold that was exceeded by behavior in analyzed resources. Exceeding this threshold
        /// is related to the anomalous behavior that generated this anomaly. 
        /// </para>
        /// </summary>
        public double Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredictionTimeRange.
        /// </summary>
        public PredictionTimeRange PredictionTimeRange
        {
            get { return this._predictionTimeRange; }
            set { this._predictionTimeRange = value; }
        }

        // Check to see if PredictionTimeRange property is set
        internal bool IsSetPredictionTimeRange()
        {
            return this._predictionTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCollection.
        /// </summary>
        public ResourceCollection ResourceCollection
        {
            get { return this._resourceCollection; }
            set { this._resourceCollection = value; }
        }

        // Check to see if ResourceCollection property is set
        internal bool IsSetResourceCollection()
        {
            return this._resourceCollection != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the anomaly. The severity of anomalies that generate an insight determine
        /// that insight's severity. For more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/working-with-insights.html#understanding-insights-severities">Understanding
        /// insight severities</a> in the <i>Amazon DevOps Guru User Guide</i>.
        /// </para>
        /// </summary>
        public AnomalySeverity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDetails. 
        /// <para>
        ///  Details about the source of the analyzed operational data that triggered the anomaly.
        /// The one supported source is Amazon CloudWatch metrics. 
        /// </para>
        /// </summary>
        public AnomalySourceDetails SourceDetails
        {
            get { return this._sourceDetails; }
            set { this._sourceDetails = value; }
        }

        // Check to see if SourceDetails property is set
        internal bool IsSetSourceDetails()
        {
            return this._sourceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SourceMetadata. 
        /// <para>
        /// The metadata of the source which detects proactive anomalies.
        /// </para>
        /// </summary>
        public AnomalySourceMetadata SourceMetadata
        {
            get { return this._sourceMetadata; }
            set { this._sourceMetadata = value; }
        }

        // Check to see if SourceMetadata property is set
        internal bool IsSetSourceMetadata()
        {
            return this._sourceMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the anomaly.
        /// </para>
        /// </summary>
        public AnomalyStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        ///  The time of the anomaly's most recent update. 
        /// </para>
        /// </summary>
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}