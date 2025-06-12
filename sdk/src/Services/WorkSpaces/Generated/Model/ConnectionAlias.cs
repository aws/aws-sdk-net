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
    /// Describes a connection alias. Connection aliases are used for cross-Region redirection.
    /// For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/cross-region-redirection.html">
    /// Cross-Region Redirection for Amazon WorkSpaces</a>.
    /// </summary>
    public partial class ConnectionAlias
    {
        private string _aliasId;
        private List<ConnectionAliasAssociation> _associations = AWSConfigs.InitializeCollections ? new List<ConnectionAliasAssociation>() : null;
        private string _connectionString;
        private string _ownerAccountId;
        private ConnectionAliasState _state;

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
        /// Gets and sets the property Associations. 
        /// <para>
        /// The association status of the connection alias.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<ConnectionAliasAssociation> Associations
        {
            get { return this._associations; }
            set { this._associations = value; }
        }

        // Check to see if Associations property is set
        internal bool IsSetAssociations()
        {
            return this._associations != null && (this._associations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionString. 
        /// <para>
        /// The connection string specified for the connection alias. The connection string must
        /// be in the form of a fully qualified domain name (FQDN), such as <c>www.example.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ConnectionString
        {
            get { return this._connectionString; }
            set { this._connectionString = value; }
        }

        // Check to see if ConnectionString property is set
        internal bool IsSetConnectionString()
        {
            return this._connectionString != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account that owns the connection alias.
        /// </para>
        /// </summary>
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the connection alias.
        /// </para>
        /// </summary>
        public ConnectionAliasState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}