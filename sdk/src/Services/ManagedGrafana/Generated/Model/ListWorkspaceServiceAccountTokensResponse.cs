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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
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
namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// This is the response object from the ListWorkspaceServiceAccountTokens operation.
    /// </summary>
    public partial class ListWorkspaceServiceAccountTokensResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private string _serviceAccountId;
        private List<ServiceAccountTokenSummary> _serviceAccountTokens = AWSConfigs.InitializeCollections ? new List<ServiceAccountTokenSummary>() : null;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use when requesting the next set of service accounts.
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
        /// Gets and sets the property ServiceAccountId. 
        /// <para>
        /// The ID of the service account where the tokens reside.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceAccountId
        {
            get { return this._serviceAccountId; }
            set { this._serviceAccountId = value; }
        }

        // Check to see if ServiceAccountId property is set
        internal bool IsSetServiceAccountId()
        {
            return this._serviceAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccountTokens. 
        /// <para>
        /// An array of structures containing information about the tokens.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ServiceAccountTokenSummary> ServiceAccountTokens
        {
            get { return this._serviceAccountTokens; }
            set { this._serviceAccountTokens = value; }
        }

        // Check to see if ServiceAccountTokens property is set
        internal bool IsSetServiceAccountTokens()
        {
            return this._serviceAccountTokens != null && (this._serviceAccountTokens.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace where the tokens reside.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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