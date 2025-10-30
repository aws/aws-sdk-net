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
    /// Detailed information about an anomaly detector.
    /// </summary>
    public partial class AnomalyDetectorDescription
    {
        private string _alias;
        private string _anomalyDetectorId;
        private string _arn;
        private AnomalyDetectorConfiguration _configuration;
        private DateTime? _createdAt;
        private int? _evaluationIntervalInSeconds;
        private Dictionary<string, string> _labels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AnomalyDetectorMissingDataAction _missingDataAction;
        private DateTime? _modifiedAt;
        private AnomalyDetectorStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The user-friendly name of the anomaly detector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyDetectorId. 
        /// <para>
        /// The unique identifier of the anomaly detector.
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the anomaly detector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The algorithm configuration of the anomaly detector.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the anomaly detector was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
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
        /// The Amazon Managed Service for Prometheus metric labels associated with the anomaly
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
        /// The action taken when data is missing during evaluation.
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
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The timestamp when the anomaly detector was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ModifiedAt
        {
            get { return this._modifiedAt.GetValueOrDefault(); }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the anomaly detector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnomalyDetectorStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags applied to the anomaly detector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}