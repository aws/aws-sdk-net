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
    /// Container for the parameters to the CreateAnomalyDetector operation.
    /// Creates an anomaly detector.
    /// </summary>
    public partial class CreateAnomalyDetectorRequest : AmazonLookoutMetricsRequest
    {
        private AnomalyDetectorConfig _anomalyDetectorConfig;
        private string _anomalyDetectorDescription;
        private string _anomalyDetectorName;
        private string _kmsKeyArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorConfig. 
        /// <para>
        /// Contains information about the configuration of the anomaly detector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnomalyDetectorConfig AnomalyDetectorConfig
        {
            get { return this._anomalyDetectorConfig; }
            set { this._anomalyDetectorConfig = value; }
        }

        // Check to see if AnomalyDetectorConfig property is set
        internal bool IsSetAnomalyDetectorConfig()
        {
            return this._anomalyDetectorConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyDetectorDescription. 
        /// <para>
        /// A description of the detector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AnomalyDetectorDescription
        {
            get { return this._anomalyDetectorDescription; }
            set { this._anomalyDetectorDescription = value; }
        }

        // Check to see if AnomalyDetectorDescription property is set
        internal bool IsSetAnomalyDetectorDescription()
        {
            return this._anomalyDetectorDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyDetectorName. 
        /// <para>
        /// The name of the detector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string AnomalyDetectorName
        {
            get { return this._anomalyDetectorName; }
            set { this._anomalyDetectorName = value; }
        }

        // Check to see if AnomalyDetectorName property is set
        internal bool IsSetAnomalyDetectorName()
        {
            return this._anomalyDetectorName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the KMS key to use to encrypt your data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// to apply to the anomaly detector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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