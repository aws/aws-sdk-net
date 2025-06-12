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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
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
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// This is the response object from the ListNamespaces operation.
    /// </summary>
    public partial class ListNamespacesResponse : AmazonWebServiceResponse
    {
        private List<NamespaceSummary> _namespaces = AWSConfigs.InitializeCollections ? new List<NamespaceSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Namespaces. 
        /// <para>
        /// An array that contains one <c>NamespaceSummary</c> object for each namespace that
        /// matches the specified filter criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NamespaceSummary> Namespaces
        {
            get { return this._namespaces; }
            set { this._namespaces = value; }
        }

        // Check to see if Namespaces property is set
        internal bool IsSetNamespaces()
        {
            return this._namespaces != null && (this._namespaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response contains <c>NextToken</c>, submit another <c>ListNamespaces</c> request
        /// to get the next group of results. Specify the value of <c>NextToken</c> from the previous
        /// response in the next request.
        /// </para>
        ///  <note> 
        /// <para>
        /// Cloud Map gets <c>MaxResults</c> namespaces and then filters them based on the specified
        /// criteria. It's possible that no namespaces in the first <c>MaxResults</c> namespaces
        /// matched the specified criteria but that subsequent groups of <c>MaxResults</c> namespaces
        /// do contain namespaces that match the criteria.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=4096)]
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