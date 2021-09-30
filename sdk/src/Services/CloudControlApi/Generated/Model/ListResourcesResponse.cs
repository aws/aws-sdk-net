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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudControlApi.Model
{
    /// <summary>
    /// This is the response object from the ListResources operation.
    /// </summary>
    public partial class ListResourcesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResourceDescription> _resourceDescriptions = new List<ResourceDescription>();
        private string _typeName;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the request doesn't return all of the remaining results, <code>NextToken</code>
        /// is set to a token. To retrieve the next set of results, call <code>ListResources</code>
        /// again and assign that token to the request object's <code>NextToken</code> parameter.
        /// If the request returns all results, <code>NextToken</code> is set to null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property ResourceDescriptions. 
        /// <para>
        /// Information about the specified resources, including primary identifier and resource
        /// model.
        /// </para>
        /// </summary>
        public List<ResourceDescription> ResourceDescriptions
        {
            get { return this._resourceDescriptions; }
            set { this._resourceDescriptions = value; }
        }

        // Check to see if ResourceDescriptions property is set
        internal bool IsSetResourceDescriptions()
        {
            return this._resourceDescriptions != null && this._resourceDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=196)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

    }
}