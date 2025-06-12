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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// This is the response object from the ListServicesByNamespace operation.
    /// </summary>
    public partial class ListServicesByNamespaceResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _serviceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value to include in a future <c>ListServicesByNamespace</c> request.
        /// When the results of a <c>ListServicesByNamespace</c> request exceed <c>maxResults</c>,
        /// this value can be used to retrieve the next page of results. When there are no more
        /// results to return, this value is <c>null</c>.
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
        /// Gets and sets the property ServiceArns. 
        /// <para>
        /// The list of full ARN entries for each service that's associated with the specified
        /// namespace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ServiceArns
        {
            get { return this._serviceArns; }
            set { this._serviceArns = value; }
        }

        // Check to see if ServiceArns property is set
        internal bool IsSetServiceArns()
        {
            return this._serviceArns != null && (this._serviceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}