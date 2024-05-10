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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
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
namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// This is the response object from the ListHypervisors operation.
    /// </summary>
    public partial class ListHypervisorsResponse : AmazonWebServiceResponse
    {
        private List<Hypervisor> _hypervisors = AWSConfigs.InitializeCollections ? new List<Hypervisor>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Hypervisors. 
        /// <para>
        /// A list of your <c>Hypervisor</c> objects, ordered by their Amazon Resource Names (ARNs).
        /// </para>
        /// </summary>
        public List<Hypervisor> Hypervisors
        {
            get { return this._hypervisors; }
            set { this._hypervisors = value; }
        }

        // Check to see if Hypervisors property is set
        internal bool IsSetHypervisors()
        {
            return this._hypervisors != null && (this._hypervisors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next item following a partial list of returned resources. For example, if a request
        /// is made to return <c>maxResults</c> number of resources, <c>NextToken</c> allows you
        /// to return more items in your list starting at the location pointed to by the next
        /// token.
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