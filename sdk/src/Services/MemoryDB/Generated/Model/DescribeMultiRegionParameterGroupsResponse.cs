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
    /// This is the response object from the DescribeMultiRegionParameterGroups operation.
    /// </summary>
    public partial class DescribeMultiRegionParameterGroupsResponse : AmazonWebServiceResponse
    {
        private List<MultiRegionParameterGroup> _multiRegionParameterGroups = AWSConfigs.InitializeCollections ? new List<MultiRegionParameterGroup>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MultiRegionParameterGroups. 
        /// <para>
        /// A list of multi-region parameter groups. Each element in the list contains detailed
        /// information about one parameter group.
        /// </para>
        /// </summary>
        public List<MultiRegionParameterGroup> MultiRegionParameterGroups
        {
            get { return this._multiRegionParameterGroups; }
            set { this._multiRegionParameterGroups = value; }
        }

        // Check to see if MultiRegionParameterGroups property is set
        internal bool IsSetMultiRegionParameterGroups()
        {
            return this._multiRegionParameterGroups != null && (this._multiRegionParameterGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional token to include in the response. If this token is provided, the response
        /// includes only results beyond the token, up to the value specified by MaxResults.
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