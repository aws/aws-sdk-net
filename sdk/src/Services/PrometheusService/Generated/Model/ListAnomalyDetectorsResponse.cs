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
    /// This is the response object from the ListAnomalyDetectors operation.
    /// </summary>
    public partial class ListAnomalyDetectorsResponse : AmazonWebServiceResponse
    {
        private List<AnomalyDetectorSummary> _anomalyDetectors = AWSConfigs.InitializeCollections ? new List<AnomalyDetectorSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AnomalyDetectors. 
        /// <para>
        /// The list of anomaly detectors in the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AnomalyDetectorSummary> AnomalyDetectors
        {
            get { return this._anomalyDetectors; }
            set { this._anomalyDetectors = value; }
        }

        // Check to see if AnomalyDetectors property is set
        internal bool IsSetAnomalyDetectors()
        {
            return this._anomalyDetectors != null && (this._anomalyDetectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}