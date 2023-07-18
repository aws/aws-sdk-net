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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// This is the response object from the ListEdgeAgentConfigurations operation.
    /// </summary>
    public partial class ListEdgeAgentConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<ListEdgeAgentConfigurationsEdgeConfig> _edgeConfigs = new List<ListEdgeAgentConfigurationsEdgeConfig>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EdgeConfigs. 
        /// <para>
        /// A description of a single stream's edge configuration.
        /// </para>
        /// </summary>
        public List<ListEdgeAgentConfigurationsEdgeConfig> EdgeConfigs
        {
            get { return this._edgeConfigs; }
            set { this._edgeConfigs = value; }
        }

        // Check to see if EdgeConfigs property is set
        internal bool IsSetEdgeConfigs()
        {
            return this._edgeConfigs != null && this._edgeConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, the call returns this element with a given token. To
        /// get the next batch of edge configurations, use this token in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
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