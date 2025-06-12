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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Filters the connection definitions that are returned by the <c>GetConnections</c>
    /// API operation.
    /// </summary>
    public partial class GetConnectionsFilter
    {
        private int? _connectionSchemaVersion;
        private ConnectionType _connectionType;
        private List<string> _matchCriteria = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConnectionSchemaVersion. 
        /// <para>
        /// Denotes if the connection was created with schema version 1 or 2.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public int? ConnectionSchemaVersion
        {
            get { return this._connectionSchemaVersion; }
            set { this._connectionSchemaVersion = value; }
        }

        // Check to see if ConnectionSchemaVersion property is set
        internal bool IsSetConnectionSchemaVersion()
        {
            return this._connectionSchemaVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of connections to return. Currently, SFTP is not supported.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property MatchCriteria. 
        /// <para>
        /// A criteria string that must match the criteria recorded in the connection definition
        /// for that connection definition to be returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> MatchCriteria
        {
            get { return this._matchCriteria; }
            set { this._matchCriteria = value; }
        }

        // Check to see if MatchCriteria property is set
        internal bool IsSetMatchCriteria()
        {
            return this._matchCriteria != null && (this._matchCriteria.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}