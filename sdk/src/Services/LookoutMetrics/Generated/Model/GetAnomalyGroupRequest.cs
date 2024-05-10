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
    /// Container for the parameters to the GetAnomalyGroup operation.
    /// Returns details about a group of anomalous metrics.
    /// </summary>
    public partial class GetAnomalyGroupRequest : AmazonLookoutMetricsRequest
    {
        private string _anomalyDetectorArn;
        private string _anomalyGroupId;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the anomaly detector.
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
        /// Gets and sets the property AnomalyGroupId. 
        /// <para>
        /// The ID of the anomaly group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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

    }
}