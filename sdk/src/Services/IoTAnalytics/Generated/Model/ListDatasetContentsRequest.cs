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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the ListDatasetContents operation.
    /// Lists information about dataset contents that have been created.
    /// </summary>
    public partial class ListDatasetContentsRequest : AmazonIoTAnalyticsRequest
    {
        private string _datasetName;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _scheduledBefore;
        private DateTime? _scheduledOnOrAfter;

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset whose contents information you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results.
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
        /// Gets and sets the property ScheduledBefore. 
        /// <para>
        /// A filter to limit results to those dataset contents whose creation is scheduled before
        /// the given time. See the field <c>triggers.schedule</c> in the <c>CreateDataset</c>
        /// request. (timestamp)
        /// </para>
        /// </summary>
        public DateTime? ScheduledBefore
        {
            get { return this._scheduledBefore; }
            set { this._scheduledBefore = value; }
        }

        // Check to see if ScheduledBefore property is set
        internal bool IsSetScheduledBefore()
        {
            return this._scheduledBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduledOnOrAfter. 
        /// <para>
        /// A filter to limit results to those dataset contents whose creation is scheduled on
        /// or after the given time. See the field <c>triggers.schedule</c> in the <c>CreateDataset</c>
        /// request. (timestamp)
        /// </para>
        /// </summary>
        public DateTime? ScheduledOnOrAfter
        {
            get { return this._scheduledOnOrAfter; }
            set { this._scheduledOnOrAfter = value; }
        }

        // Check to see if ScheduledOnOrAfter property is set
        internal bool IsSetScheduledOnOrAfter()
        {
            return this._scheduledOnOrAfter.HasValue; 
        }

    }
}