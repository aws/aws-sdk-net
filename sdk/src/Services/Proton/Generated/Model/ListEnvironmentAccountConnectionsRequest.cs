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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
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
namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the ListEnvironmentAccountConnections operation.
    /// View a list of environment account connections.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-env-account-connections.html">Environment
    /// account connections</a> in the <i>Proton User guide</i>.
    /// </para>
    /// </summary>
    public partial class ListEnvironmentAccountConnectionsRequest : AmazonProtonRequest
    {
        private string _environmentName;
        private int? _maxResults;
        private string _nextToken;
        private EnvironmentAccountConnectionRequesterAccountType _requestedBy;
        private List<string> _statuses = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The environment name that's associated with each listed environment account connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of environment account connections to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// A token that indicates the location of the next environment account connection in
        /// the array of environment account connections, after the list of environment account
        /// connections that was previously requested.
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
        /// Gets and sets the property RequestedBy. 
        /// <para>
        /// The type of account making the <c>ListEnvironmentAccountConnections</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnvironmentAccountConnectionRequesterAccountType RequestedBy
        {
            get { return this._requestedBy; }
            set { this._requestedBy = value; }
        }

        // Check to see if RequestedBy property is set
        internal bool IsSetRequestedBy()
        {
            return this._requestedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        /// The status details for each listed environment account connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Statuses
        {
            get { return this._statuses; }
            set { this._statuses = value; }
        }

        // Check to see if Statuses property is set
        internal bool IsSetStatuses()
        {
            return this._statuses != null && (this._statuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}