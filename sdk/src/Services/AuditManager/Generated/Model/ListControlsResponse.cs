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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// This is the response object from the ListControls operation.
    /// </summary>
    public partial class ListControlsResponse : AmazonWebServiceResponse
    {
        private List<ControlMetadata> _controlMetadataList = new List<ControlMetadata>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ControlMetadataList. 
        /// <para>
        ///  The list of control metadata objects returned by the <code>ListControls</code> API.
        /// 
        /// </para>
        /// </summary>
        public List<ControlMetadata> ControlMetadataList
        {
            get { return this._controlMetadataList; }
            set { this._controlMetadataList = value; }
        }

        // Check to see if ControlMetadataList property is set
        internal bool IsSetControlMetadataList()
        {
            return this._controlMetadataList != null && this._controlMetadataList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token used to fetch the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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

    }
}