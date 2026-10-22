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
    /// Container for the parameters to the StartDataMigration operation. Starts the specified
    /// data migration.
    /// </summary>
    public partial class StartDataMigrationRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DataMigrationIdentifier. 
        /// <para>
        /// The identifier (name or ARN) of the data migration to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataMigrationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DataMigrationIdentifier property is set.
        /// </summary>
        internal bool IsSetDataMigrationIdentifier() => this.DataMigrationIdentifier != null;

        /// <summary>
        /// Gets and sets the property StartType. 
        /// <para>
        /// Specifies the start type for the data migration. Valid values include <c>start-replication</c>,
        /// <c>reload-target</c>, and <c>resume-processing</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StartReplicationMigrationTypeValue StartType { get; set; }

        /// <summary>
        /// Checks to see if the StartType property is set.
        /// </summary>
        internal bool IsSetStartType() => this.StartType != null;
    }
}
