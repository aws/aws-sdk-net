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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// This is the response object from the ListApplicationInstanceNodeInstances operation.
    /// </summary>
    public partial class ListApplicationInstanceNodeInstancesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<NodeInstance> _nodeInstances = AWSConfigs.InitializeCollections ? new List<NodeInstance>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that's included if more results are available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property NodeInstances. 
        /// <para>
        /// A list of node instances.
        /// </para>
        /// </summary>
        public List<NodeInstance> NodeInstances
        {
            get { return this._nodeInstances; }
            set { this._nodeInstances = value; }
        }

        // Check to see if NodeInstances property is set
        internal bool IsSetNodeInstances()
        {
            return this._nodeInstances != null && (this._nodeInstances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}