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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the GetAnomalies operation.
    /// </summary>
    public partial class GetAnomaliesResponse : AmazonWebServiceResponse
    {
        private List<Anomaly> _anomalies = new List<Anomaly>();
        private string _nextPageToken;

        /// <summary>
        /// Gets and sets the property Anomalies. 
        /// <para>
        ///  A list of cost anomalies. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Anomaly> Anomalies
        {
            get { return this._anomalies; }
            set { this._anomalies = value; }
        }

        // Check to see if Anomalies property is set
        internal bool IsSetAnomalies()
        {
            return this._anomalies != null && this._anomalies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        ///  The token to retrieve the next set of results. AWS provides the token when the response
        /// from a previous call has more results than the maximum page size. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

    }
}