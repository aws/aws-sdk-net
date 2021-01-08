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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the ListPipelines operation.
    /// The ListPipelines operation gets a list of the pipelines associated with the current
    /// AWS account.
    /// </summary>
    public partial class ListPipelinesRequest : AmazonElasticTranscoderRequest
    {
        private string _ascending;
        private string _pageToken;

        /// <summary>
        /// Gets and sets the property Ascending. 
        /// <para>
        /// To list pipelines in chronological order by the date and time that they were created,
        /// enter <code>true</code>. To list pipelines in reverse chronological order, enter <code>false</code>.
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
        /// When Elastic Transcoder returns more than one page of results, use <code>pageToken</code>
        /// in subsequent <code>GET</code> requests to get each successive page of results. 
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

    }
}