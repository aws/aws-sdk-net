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
    /// Details about a reactive anomaly. This object is returned by <code>DescribeAnomaly.</code>
    /// </summary>
    public partial class ReactiveAnomalySummary
    {
        private AnomalyTimeRange _anomalyTimeRange;
        private string _associatedInsightId;
        private string _id;
        private ResourceCollection _resourceCollection;
        private AnomalySeverity _severity;
        private AnomalySourceDetails _sourceDetails;
        private AnomalyStatus _status;

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
        /// Gets and sets the property Id. 
        /// <para>
        ///  The ID of the reactive anomaly. 
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
        ///  The severity of the reactive anomaly. 
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the reactive anomaly. 
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

    }
}