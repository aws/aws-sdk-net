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
    /// Container for the parameters to the UpdateAnomalyDetector operation.
    /// Updates a detector. After activation, you can only change a detector's ingestion delay
    /// and description.
    /// </summary>
    public partial class UpdateAnomalyDetectorRequest : AmazonLookoutMetricsRequest
    {
        private string _anomalyDetectorArn;
        private AnomalyDetectorConfig _anomalyDetectorConfig;
        private string _anomalyDetectorDescription;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The ARN of the detector to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string AnomalyDetectorArn
        {
            get { return this._anomalyDetectorArn; }
            set { this._anomalyDetectorArn = value; }
        }

        // Check to see if AnomalyDetectorArn property is set
        internal bool IsSetAnomalyDetectorArn()
        {
            return this._anomalyDetectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property AnomalyDetectorConfig. 
        /// <para>
        /// Contains information about the configuration to which the detector will be updated.
        /// </para>
        /// </summary>
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
        /// The updated detector description.
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
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an AWS KMS encryption key.
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

    }
}