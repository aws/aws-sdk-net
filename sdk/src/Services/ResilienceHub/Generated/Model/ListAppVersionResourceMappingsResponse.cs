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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the ListAppVersionResourceMappings operation.
    /// </summary>
    public partial class ListAppVersionResourceMappingsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResourceMapping> _resourceMappings = new List<ResourceMapping>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no more results.
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
        /// Gets and sets the property ResourceMappings. 
        /// <para>
        /// Mappings used to map logical resources from the template to physical resources. You
        /// can use the mapping type <code>CFN_STACK</code> if the application template uses a
        /// logical stack name. Or you can map individual resources by using the mapping type
        /// <code>RESOURCE</code>. We recommend using the mapping type <code>CFN_STACK</code>
        /// if the application is backed by a CloudFormation stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResourceMapping> ResourceMappings
        {
            get { return this._resourceMappings; }
            set { this._resourceMappings = value; }
        }

        // Check to see if ResourceMappings property is set
        internal bool IsSetResourceMappings()
        {
            return this._resourceMappings != null && this._resourceMappings.Count > 0; 
        }

    }
}