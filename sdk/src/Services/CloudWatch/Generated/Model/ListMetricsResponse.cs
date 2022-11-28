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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This is the response object from the ListMetrics operation.
    /// </summary>
    public partial class ListMetricsResponse : AmazonWebServiceResponse
    {
        private List<Metric> _metrics = new List<Metric>();
        private string _nextToken;
        private List<string> _owningAccounts = new List<string>();

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The metrics that match your request. 
        /// </para>
        /// </summary>
        public List<Metric> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that marks the start of the next batch of returned results. 
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property OwningAccounts. 
        /// <para>
        /// If you are using this operation in a monitoring account, this array contains the account
        /// IDs of the source accounts where the metrics in the returned data are from.
        /// </para>
        ///  
        /// <para>
        /// This field is a 1:1 mapping between each metric that is returned and the ID of the
        /// owning account.
        /// </para>
        /// </summary>
        public List<string> OwningAccounts
        {
            get { return this._owningAccounts; }
            set { this._owningAccounts = value; }
        }

        // Check to see if OwningAccounts property is set
        internal bool IsSetOwningAccounts()
        {
            return this._owningAccounts != null && this._owningAccounts.Count > 0; 
        }

    }
}