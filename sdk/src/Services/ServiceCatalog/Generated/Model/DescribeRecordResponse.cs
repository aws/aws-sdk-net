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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the DescribeRecord operation.
    /// </summary>
    public partial class DescribeRecordResponse : AmazonWebServiceResponse
    {
        private string _nextPageToken;
        private RecordDetail _recordDetail;
        private List<RecordOutput> _recordOutputs = new List<RecordOutput>();

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The page token to use to retrieve the next set of results. If there are no additional
        /// results, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2024)]
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

        /// <summary>
        /// Gets and sets the property RecordDetail. 
        /// <para>
        /// Information about the product.
        /// </para>
        /// </summary>
        public RecordDetail RecordDetail
        {
            get { return this._recordDetail; }
            set { this._recordDetail = value; }
        }

        // Check to see if RecordDetail property is set
        internal bool IsSetRecordDetail()
        {
            return this._recordDetail != null;
        }

        /// <summary>
        /// Gets and sets the property RecordOutputs. 
        /// <para>
        /// Information about the product created as the result of a request. For example, the
        /// output for a CloudFormation-backed product that creates an S3 bucket would include
        /// the S3 bucket URL.
        /// </para>
        /// </summary>
        public List<RecordOutput> RecordOutputs
        {
            get { return this._recordOutputs; }
            set { this._recordOutputs = value; }
        }

        // Check to see if RecordOutputs property is set
        internal bool IsSetRecordOutputs()
        {
            return this._recordOutputs != null && this._recordOutputs.Count > 0; 
        }

    }
}