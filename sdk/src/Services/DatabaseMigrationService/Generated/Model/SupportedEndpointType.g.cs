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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information about types of supported endpoints in response to a request by
    /// the <c>DescribeEndpointTypes</c> operation. This information includes the type of
    /// endpoint, the database engine name, and whether change data capture (CDC) is supported.
    /// </summary>
    public partial class SupportedEndpointType
    {
        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint. Valid values are <c>source</c> and <c>target</c>.
        /// </para>
        /// </summary>
        public ReplicationEndpointTypeValue EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property EngineDisplayName. 
        /// <para>
        /// The expanded name for the engine name. For example, if the <c>EngineName</c> parameter
        /// is "aurora", this value would be "Amazon Aurora MySQL".
        /// </para>
        /// </summary>
        public string EngineDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the EngineDisplayName property is set.
        /// </summary>
        internal bool IsSetEngineDisplayName() => this.EngineDisplayName != null;

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The database engine name. Valid values, depending on the EndpointType, include <c>"mysql"</c>,
        /// <c>"oracle"</c>, <c>"postgres"</c>, <c>"mariadb"</c>, <c>"aurora"</c>, <c>"aurora-postgresql"</c>,
        /// <c>"redshift"</c>, <c>"s3"</c>, <c>"db2"</c>, <c>"db2-zos"</c>, <c>"azuredb"</c>,
        /// <c>"sybase"</c>, <c>"dynamodb"</c>, <c>"mongodb"</c>, <c>"kinesis"</c>, <c>"kafka"</c>,
        /// <c>"elasticsearch"</c>, <c>"documentdb"</c>, <c>"sqlserver"</c>, <c>"neptune"</c>,
        /// and <c>"babelfish"</c>.
        /// </para>
        /// </summary>
        public string EngineName { get; set; }

        /// <summary>
        /// Checks to see if the EngineName property is set.
        /// </summary>
        internal bool IsSetEngineName() => this.EngineName != null;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceEngineMinimumVersion. 
        /// <para>
        /// The earliest DMS engine version that supports this endpoint engine. Note that endpoint
        /// engines released with DMS versions earlier than 3.1.1 do not return a value for this
        /// parameter.
        /// </para>
        /// </summary>
        public string ReplicationInstanceEngineMinimumVersion { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceEngineMinimumVersion property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceEngineMinimumVersion() => this.ReplicationInstanceEngineMinimumVersion != null;

        /// <summary>
        /// Gets and sets the property SupportsCDC. 
        /// <para>
        /// Indicates if change data capture (CDC) is supported.
        /// </para>
        /// </summary>
        public bool? SupportsCDC { get; set; }

        /// <summary>
        /// Checks to see if the SupportsCDC property is set.
        /// </summary>
        internal bool IsSetSupportsCDC() => this.SupportsCDC.HasValue;
    }
}
