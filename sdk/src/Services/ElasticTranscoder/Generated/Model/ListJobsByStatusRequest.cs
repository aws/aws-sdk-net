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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobsByStatus operation.
    /// The ListJobsByStatus operation gets a list of jobs that have a specified status. The
    /// response body contains one element for each job that satisfies the search criteria.
    /// </summary>
    public partial class ListJobsByStatusRequest : AmazonElasticTranscoderRequest
    {
        private string _ascending;
        private string _pageToken;
        private string _status;

        /// <summary>
        /// Gets and sets the property Ascending. 
        /// <para>
        ///  To list jobs in chronological order by the date and time that they were submitted,
        /// enter <c>true</c>. To list jobs in reverse chronological order, enter <c>false</c>.
        /// 
        /// </para>
        /// </summary>
        public string Ascending
        {
            get { return this._ascending; }
            set { this._ascending = value; }
        }

        // Check to see if Ascending property is set
        internal bool IsSetAscending()
        {
            return this._ascending != null;
        }

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        ///  When Elastic Transcoder returns more than one page of results, use <c>pageToken</c>
        /// in subsequent <c>GET</c> requests to get each successive page of results. 
        /// </para>
        /// </summary>
        public string PageToken
        {
            get { return this._pageToken; }
            set { this._pageToken = value; }
        }

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this._pageToken != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// To get information about all of the jobs associated with the current AWS account that
        /// have a given status, specify the following status: <c>Submitted</c>, <c>Progressing</c>,
        /// <c>Complete</c>, <c>Canceled</c>, or <c>Error</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
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