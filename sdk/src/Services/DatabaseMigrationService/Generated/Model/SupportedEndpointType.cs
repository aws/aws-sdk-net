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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information about types of supported endpoints in response to a request by
    /// the <code>DescribeEndpointTypes</code> operation. This information includes the type
    /// of endpoint, the database engine name, and whether change data capture (CDC) is supported.
    /// </summary>
    public partial class SupportedEndpointType
    {
        private ReplicationEndpointTypeValue _endpointType;
        private string _engineDisplayName;
        private string _engineName;
        private string _replicationInstanceEngineMinimumVersion;
        private bool? _supportsCDC;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint. Valid values are <code>source</code> and <code>target</code>.
        /// </para>
        /// </summary>
        public ReplicationEndpointTypeValue EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property EngineDisplayName. 
        /// <para>
        /// The expanded name for the engine name. For example, if the <code>EngineName</code>
        /// parameter is "aurora", this value would be "Amazon Aurora MySQL".
        /// </para>
        /// </summary>
        public string EngineDisplayName
        {
            get { return this._engineDisplayName; }
            set { this._engineDisplayName = value; }
        }

        // Check to see if EngineDisplayName property is set
        internal bool IsSetEngineDisplayName()
        {
            return this._engineDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The database engine name. Valid values, depending on the EndpointType, include <code>"mysql"</code>,
        /// <code>"oracle"</code>, <code>"postgres"</code>, <code>"mariadb"</code>, <code>"aurora"</code>,
        /// <code>"aurora-postgresql"</code>, <code>"redshift"</code>, <code>"s3"</code>, <code>"db2"</code>,
        /// <code>"db2-zos"</code>, <code>"azuredb"</code>, <code>"sybase"</code>, <code>"dynamodb"</code>,
        /// <code>"mongodb"</code>, <code>"kinesis"</code>, <code>"kafka"</code>, <code>"elasticsearch"</code>,
        /// <code>"documentdb"</code>, <code>"sqlserver"</code>, <code>"neptune"</code>, and <code>"babelfish"</code>.
        /// </para>
        /// </summary>
        public string EngineName
        {
            get { return this._engineName; }
            set { this._engineName = value; }
        }

        // Check to see if EngineName property is set
        internal bool IsSetEngineName()
        {
            return this._engineName != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceEngineMinimumVersion. 
        /// <para>
        /// The earliest DMS engine version that supports this endpoint engine. Note that endpoint
        /// engines released with DMS versions earlier than 3.1.1 do not return a value for this
        /// parameter.
        /// </para>
        /// </summary>
        public string ReplicationInstanceEngineMinimumVersion
        {
            get { return this._replicationInstanceEngineMinimumVersion; }
            set { this._replicationInstanceEngineMinimumVersion = value; }
        }

        // Check to see if ReplicationInstanceEngineMinimumVersion property is set
        internal bool IsSetReplicationInstanceEngineMinimumVersion()
        {
            return this._replicationInstanceEngineMinimumVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SupportsCDC. 
        /// <para>
        /// Indicates if change data capture (CDC) is supported.
        /// </para>
        /// </summary>
        public bool SupportsCDC
        {
            get { return this._supportsCDC.GetValueOrDefault(); }
            set { this._supportsCDC = value; }
        }

        // Check to see if SupportsCDC property is set
        internal bool IsSetSupportsCDC()
        {
            return this._supportsCDC.HasValue; 
        }

    }
}