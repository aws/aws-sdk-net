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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// This is the response object from the DescribeConnectionAliasPermissions operation.
    /// </summary>
    public partial class DescribeConnectionAliasPermissionsResponse : AmazonWebServiceResponse
    {
        private string _aliasId;
        private List<ConnectionAliasPermission> _connectionAliasPermissions = AWSConfigs.InitializeCollections ? new List<ConnectionAliasPermission>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AliasId. 
        /// <para>
        /// The identifier of the connection alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=13, Max=68)]
        public string AliasId
        {
            get { return this._aliasId; }
            set { this._aliasId = value; }
        }

        // Check to see if AliasId property is set
        internal bool IsSetAliasId()
        {
            return this._aliasId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionAliasPermissions. 
        /// <para>
        /// The permissions associated with a connection alias.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<ConnectionAliasPermission> ConnectionAliasPermissions
        {
            get { return this._connectionAliasPermissions; }
            set { this._connectionAliasPermissions = value; }
        }

        // Check to see if ConnectionAliasPermissions property is set
        internal bool IsSetConnectionAliasPermissions()
        {
            return this._connectionAliasPermissions != null && (this._connectionAliasPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is null when there
        /// are no more results to return. 
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

    }
}