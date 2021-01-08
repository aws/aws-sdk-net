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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// This is the response object from the ListAttributeGroups operation.
    /// </summary>
    public partial class ListAttributeGroupsResponse : AmazonWebServiceResponse
    {
        private List<AttributeGroupSummary> _attributeGroups = new List<AttributeGroupSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AttributeGroups. 
        /// <para>
        /// This list of attribute groups.
        /// </para>
        /// </summary>
        public List<AttributeGroupSummary> AttributeGroups
        {
            get { return this._attributeGroups; }
            set { this._attributeGroups = value; }
        }

        // Check to see if AttributeGroups property is set
        internal bool IsSetAttributeGroups()
        {
            return this._attributeGroups != null && this._attributeGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to get the next page of results after a previous API call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2024)]
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