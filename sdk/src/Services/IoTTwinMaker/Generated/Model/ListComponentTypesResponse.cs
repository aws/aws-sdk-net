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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// This is the response object from the ListComponentTypes operation.
    /// </summary>
    public partial class ListComponentTypesResponse : AmazonWebServiceResponse
    {
        private List<ComponentTypeSummary> _componentTypeSummaries = AWSConfigs.InitializeCollections ? new List<ComponentTypeSummary>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property ComponentTypeSummaries. 
        /// <para>
        /// A list of objects that contain information about the component types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ComponentTypeSummary> ComponentTypeSummaries
        {
            get { return this._componentTypeSummaries; }
            set { this._componentTypeSummaries = value; }
        }

        // Check to see if ComponentTypeSummaries property is set
        internal bool IsSetComponentTypeSummaries()
        {
            return this._componentTypeSummaries != null && (this._componentTypeSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of results to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string that specifies the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=17880)]
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
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}