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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// This is the response object from the DescribeEngineVersions operation.
    /// </summary>
    public partial class DescribeEngineVersionsResponse : AmazonWebServiceResponse
    {
        private List<EngineVersionInfo> _engineVersions = AWSConfigs.InitializeCollections ? new List<EngineVersionInfo>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EngineVersions. 
        /// <para>
        /// A list of engine version details. Each element in the list contains detailed information
        /// about one engine version.
        /// </para>
        /// </summary>
        public List<EngineVersionInfo> EngineVersions
        {
            get { return this._engineVersions; }
            set { this._engineVersions = value; }
        }

        // Check to see if EngineVersions property is set
        internal bool IsSetEngineVersions()
        {
            return this._engineVersions != null && (this._engineVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional argument to pass in case the total number of records exceeds the value
        /// of MaxResults. If nextToken is returned, there are more results available. The value
        /// of nextToken is a unique pagination token for each page. Make the call again using
        /// the returned token to retrieve the next page. Keep all other arguments unchanged.
        /// 
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

    }
}