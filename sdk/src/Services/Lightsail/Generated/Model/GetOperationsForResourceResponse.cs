/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetOperationsForResource operation.
    /// </summary>
    public partial class GetOperationsForResourceResponse : AmazonWebServiceResponse
    {
        private string _nextPageCount;
        private string _nextPageToken;
        private List<Operation> _operations = new List<Operation>();

        /// <summary>
        /// Gets and sets the property NextPageCount. 
        /// <para>
        /// (Deprecated) Returns the number of pages of results that remain.
        /// </para>
        ///  <note> 
        /// <para>
        /// In releases prior to June 12, 2017, this parameter returned <code>null</code> by the
        /// API. It is now deprecated, and the API returns the <code>nextPageToken</code> parameter
        /// instead.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextPageCount
        {
            get { return this._nextPageCount; }
            set { this._nextPageCount = value; }
        }

        // Check to see if NextPageCount property is set
        internal bool IsSetNextPageCount()
        {
            return this._nextPageCount != null;
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Operations. 
        /// <para>
        /// An array of key-value pairs containing information about the results of your get operations
        /// for resource request.
        /// </para>
        /// </summary>
        public List<Operation> Operations
        {
            get { return this._operations; }
            set { this._operations = value; }
        }

        // Check to see if Operations property is set
        internal bool IsSetOperations()
        {
            return this._operations != null && this._operations.Count > 0; 
        }

    }
}