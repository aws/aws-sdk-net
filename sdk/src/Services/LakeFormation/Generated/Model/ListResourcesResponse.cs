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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// This is the response object from the ListResources operation.
    /// </summary>
    public partial class ListResourcesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResourceInfo> _resourceInfoList = new List<ResourceInfo>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if this is not the first call to retrieve these resources.
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
        /// Gets and sets the property ResourceInfoList. 
        /// <para>
        /// A summary of the data lake resources.
        /// </para>
        /// </summary>
        public List<ResourceInfo> ResourceInfoList
        {
            get { return this._resourceInfoList; }
            set { this._resourceInfoList = value; }
        }

        // Check to see if ResourceInfoList property is set
        internal bool IsSetResourceInfoList()
        {
            return this._resourceInfoList != null && this._resourceInfoList.Count > 0; 
        }

    }
}