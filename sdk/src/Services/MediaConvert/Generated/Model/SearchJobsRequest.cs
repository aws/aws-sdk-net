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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Container for the parameters to the SearchJobs operation.
    /// Retrieve a JSON array that includes job details for up to twenty of your most recent
    /// jobs. Optionally filter results further according to input file, queue, or status.
    /// To retrieve the twenty next most recent jobs, use the nextToken string returned with
    /// the array.
    /// </summary>
    public partial class SearchJobsRequest : AmazonMediaConvertRequest
    {
        private string _inputFile;
        private int? _maxResults;
        private string _nextToken;
        private Order _order;
        private string _queue;
        private JobStatus _status;

        /// <summary>
        /// Gets and sets the property InputFile. Optional. Provide your input file URL or your
        /// partial input file name. The maximum length for an input file is 300 characters.
        /// </summary>
        public string InputFile
        {
            get { return this._inputFile; }
            set { this._inputFile = value; }
        }

        // Check to see if InputFile property is set
        internal bool IsSetInputFile()
        {
            return this._inputFile != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. Optional. Number of jobs, up to twenty, that
        /// will be returned at one time.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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
        /// Gets and sets the property NextToken. Optional. Use this string, provided with the
        /// response to a previous request, to request the next batch of jobs.
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
        /// Gets and sets the property Order. Optional. When you request lists of resources, you
        /// can specify whether they are sorted in ASCENDING or DESCENDING order. Default varies
        /// by resource.
        /// </summary>
        public Order Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order != null;
        }

        /// <summary>
        /// Gets and sets the property Queue. Optional. Provide a queue name, or a queue ARN,
        /// to return only jobs from that queue.
        /// </summary>
        public string Queue
        {
            get { return this._queue; }
            set { this._queue = value; }
        }

        // Check to see if Queue property is set
        internal bool IsSetQueue()
        {
            return this._queue != null;
        }

        /// <summary>
        /// Gets and sets the property Status. Optional. A job's status can be SUBMITTED, PROGRESSING,
        /// COMPLETE, CANCELED, or ERROR.
        /// </summary>
        public JobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}