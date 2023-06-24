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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Represents the output for <code>ListStreams</code>.
    /// </summary>
    public partial class ListStreamsResponse : AmazonWebServiceResponse
    {
        private bool? _hasMoreStreams;
        private string _nextToken;
        private List<string> _streamNames = new List<string>();
        private List<StreamSummary> _streamSummaries = new List<StreamSummary>();

        /// <summary>
        /// Gets and sets the property HasMoreStreams. 
        /// <para>
        /// If set to <code>true</code>, there are more streams available to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool HasMoreStreams
        {
            get { return this._hasMoreStreams.GetValueOrDefault(); }
            set { this._hasMoreStreams = value; }
        }

        // Check to see if HasMoreStreams property is set
        internal bool IsSetHasMoreStreams()
        {
            return this._hasMoreStreams.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=1048576)]
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
        /// Gets and sets the property StreamNames. 
        /// <para>
        /// The names of the streams that are associated with the Amazon Web Services account
        /// making the <code>ListStreams</code> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> StreamNames
        {
            get { return this._streamNames; }
            set { this._streamNames = value; }
        }

        // Check to see if StreamNames property is set
        internal bool IsSetStreamNames()
        {
            return this._streamNames != null && this._streamNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StreamSummaries.
        /// </summary>
        public List<StreamSummary> StreamSummaries
        {
            get { return this._streamSummaries; }
            set { this._streamSummaries = value; }
        }

        // Check to see if StreamSummaries property is set
        internal bool IsSetStreamSummaries()
        {
            return this._streamSummaries != null && this._streamSummaries.Count > 0; 
        }

    }
}