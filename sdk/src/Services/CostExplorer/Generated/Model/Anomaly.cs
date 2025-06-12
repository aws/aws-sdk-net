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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
        private string _anomalyEndDate;
        private string _anomalyId;
        private AnomalyScore _anomalyScore;
        private string _anomalyStartDate;
        private string _dimensionValue;
        private AnomalyFeedbackType _feedback;
        private Impact _impact;
        private string _monitorArn;
        private List<RootCause> _rootCauses = AWSConfigs.InitializeCollections ? new List<RootCause>() : null;

        /// <summary>
        /// Gets and sets the property AnomalyEndDate. 
        /// <para>
        /// The last day the anomaly is detected. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public string AnomalyEndDate
        {
            get { return this._anomalyEndDate; }
            set { this._anomalyEndDate = value; }
        }

        // Check to see if AnomalyEndDate property is set
        internal bool IsSetAnomalyEndDate()
        {
            return this._anomalyEndDate != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyId. 
        /// <para>
        /// The unique identifier for the anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string AnomalyId
        {
            get { return this._anomalyId; }
            set { this._anomalyId = value; }
        }

        // Check to see if AnomalyId property is set
        internal bool IsSetAnomalyId()
        {
            return this._anomalyId != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyScore. 
        /// <para>
        /// The latest and maximum score for the anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnomalyScore AnomalyScore
        {
            get { return this._anomalyScore; }
            set { this._anomalyScore = value; }
        }

        // Check to see if AnomalyScore property is set
        internal bool IsSetAnomalyScore()
        {
            return this._anomalyScore != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyStartDate. 
        /// <para>
        /// The first day the anomaly is detected. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public string AnomalyStartDate
        {
            get { return this._anomalyStartDate; }
            set { this._anomalyStartDate = value; }
        }

        // Check to see if AnomalyStartDate property is set
        internal bool IsSetAnomalyStartDate()
        {
            return this._anomalyStartDate != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionValue. 
        /// <para>
        /// The dimension for the anomaly (for example, an Amazon Web Services service in a service
        /// monitor). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DimensionValue
        {
            get { return this._dimensionValue; }
            set { this._dimensionValue = value; }
        }

        // Check to see if DimensionValue property is set
        internal bool IsSetDimensionValue()
        {
            return this._dimensionValue != null;
        }

        /// <summary>
        /// Gets and sets the property Feedback. 
        /// <para>
        /// The feedback value. 
        /// </para>
        /// </summary>
        public AnomalyFeedbackType Feedback
        {
            get { return this._feedback; }
            set { this._feedback = value; }
        }

        // Check to see if Feedback property is set
        internal bool IsSetFeedback()
        {
            return this._feedback != null;
        }

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// The dollar impact for the anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Impact Impact
        {
            get { return this._impact; }
            set { this._impact = value; }
        }

        // Check to see if Impact property is set
        internal bool IsSetImpact()
        {
            return this._impact != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the cost monitor that generated this anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string MonitorArn
        {
            get { return this._monitorArn; }
            set { this._monitorArn = value; }
        }

        // Check to see if MonitorArn property is set
        internal bool IsSetMonitorArn()
        {
            return this._monitorArn != null;
        }

        /// <summary>
        /// Gets and sets the property RootCauses. 
        /// <para>
        /// The list of identified root causes for the anomaly. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RootCause> RootCauses
        {
            get { return this._rootCauses; }
            set { this._rootCauses = value; }
        }

        // Check to see if RootCauses property is set
        internal bool IsSetRootCauses()
        {
            return this._rootCauses != null && (this._rootCauses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}