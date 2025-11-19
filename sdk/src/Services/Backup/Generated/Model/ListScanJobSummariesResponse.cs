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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the ListScanJobSummaries operation.
    /// </summary>
    public partial class ListScanJobSummariesResponse : AmazonWebServiceResponse
    {
        private string _aggregationPeriod;
        private string _nextToken;
        private List<ScanJobSummary> _scanJobSummaries = AWSConfigs.InitializeCollections ? new List<ScanJobSummary>() : null;

        /// <summary>
        /// Gets and sets the property AggregationPeriod. 
        /// <para>
        /// The period for the returned results.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ONE_DAY</c>The daily job count for the prior 1 day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SEVEN_DAYS</c>The daily job count for the prior 7 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FOURTEEN_DAYS</c>The daily job count for the prior 14 days.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid Values: <c>'ONE_DAY'</c> | <c>'SEVEN_DAYS'</c> | <c>'FOURTEEN_DAYS'</c> 
        /// </para>
        /// </summary>
        public string AggregationPeriod
        {
            get { return this._aggregationPeriod; }
            set { this._aggregationPeriod = value; }
        }

        // Check to see if AggregationPeriod property is set
        internal bool IsSetAggregationPeriod()
        {
            return this._aggregationPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next item following a partial list of returned items. For example, if a request
        /// is made to return <c>MaxResults</c> number of items, <c>NextToken</c> allows you to
        /// return more items in your list starting at the location pointed to by the next token.
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
        /// Gets and sets the property ScanJobSummaries. 
        /// <para>
        /// The summary information.
        /// </para>
        /// </summary>
        public List<ScanJobSummary> ScanJobSummaries
        {
            get { return this._scanJobSummaries; }
            set { this._scanJobSummaries = value; }
        }

        // Check to see if ScanJobSummaries property is set
        internal bool IsSetScanJobSummaries()
        {
            return this._scanJobSummaries != null && (this._scanJobSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}