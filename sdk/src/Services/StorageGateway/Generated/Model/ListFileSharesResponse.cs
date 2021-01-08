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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// ListFileShareOutput
    /// </summary>
    public partial class ListFileSharesResponse : AmazonWebServiceResponse
    {
        private List<FileShareInfo> _fileShareInfoList = new List<FileShareInfo>();
        private string _marker;
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property FileShareInfoList. 
        /// <para>
        /// An array of information about the file gateway's file shares.
        /// </para>
        /// </summary>
        public List<FileShareInfo> FileShareInfoList
        {
            get { return this._fileShareInfoList; }
            set { this._fileShareInfoList = value; }
        }

        // Check to see if FileShareInfoList property is set
        internal bool IsSetFileShareInfoList()
        {
            return this._fileShareInfoList != null && this._fileShareInfoList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// If the request includes <code>Marker</code>, the response returns that value in this
        /// field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If a value is present, there are more file shares to return. In a subsequent request,
        /// use <code>NextMarker</code> as the value for <code>Marker</code> to retrieve the next
        /// set of file shares.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

    }
}