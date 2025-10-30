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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Container for the parameters to the PutAnomalyDetector operation.
    /// When you call <c>PutAnomalyDetector</c>, the operation creates a new anomaly detector
    /// if one doesn't exist, or updates an existing one. Each call to this operation triggers
    /// a complete retraining of the detector, which includes querying the minimum required
    /// samples and backfilling the detector with historical data. This process occurs regardless
    /// of whether you're making a minor change like updating the evaluation interval or making
    /// more substantial modifications. The operation serves as the single method for creating,
    /// updating, and retraining anomaly detectors.
    /// </summary>
    public partial class PutAnomalyDetectorRequest : AmazonPrometheusServiceRequest
    {
        private string _anomalyDetectorId;
        private string _clientToken;
        private AnomalyDetectorConfiguration _configuration;
        private int? _evaluationIntervalInSeconds;
        private Dictionary<string, string> _labels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AnomalyDetectorMissingDataAction _missingDataAction;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorId. 
        /// <para>
        /// The identifier of the anomaly detector to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AnomalyDetectorId
        {
            get { return this._anomalyDetectorId; }
            set { this._anomalyDetectorId = value; }
        }

        // Check to see if AnomalyDetectorId property is set
        internal bool IsSetAnomalyDetectorId()
        {
            return this._anomalyDetectorId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The algorithm configuration for the anomaly detector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnomalyDetectorConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationIntervalInSeconds. 
        /// <para>
        /// The frequency, in seconds, at which the anomaly detector evaluates metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min=30, Max=86400)]
        public int EvaluationIntervalInSeconds
        {
            get { return this._evaluationIntervalInSeconds.GetValueOrDefault(); }
            set { this._evaluationIntervalInSeconds = value; }
        }

        // Check to see if EvaluationIntervalInSeconds property is set
        internal bool IsSetEvaluationIntervalInSeconds()
        {
            return this._evaluationIntervalInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// The Amazon Managed Service for Prometheus metric labels to associate with the anomaly
        /// detector.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MissingDataAction. 
        /// <para>
        /// Specifies the action to take when data is missing during evaluation.
        /// </para>
        /// </summary>
        public AnomalyDetectorMissingDataAction MissingDataAction
        {
            get { return this._missingDataAction; }
            set { this._missingDataAction = value; }
        }

        // Check to see if MissingDataAction property is set
        internal bool IsSetMissingDataAction()
        {
            return this._missingDataAction != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The identifier of the workspace containing the anomaly detector to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}