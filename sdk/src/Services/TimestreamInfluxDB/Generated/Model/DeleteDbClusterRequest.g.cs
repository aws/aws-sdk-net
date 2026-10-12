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

namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDbCluster operation. Deletes a Timestream
    /// for InfluxDB cluster.
    /// </summary>
    public partial class DeleteDbClusterRequest : AmazonTimestreamInfluxDBRequest
    {
        /// <summary>
        /// Gets and sets the property DbClusterId. 
        /// <para>
        /// Service-generated unique identifier of the DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string DbClusterId { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterId property is set.
        /// </summary>
        internal bool IsSetDbClusterId() => this.DbClusterId != null;

        /// <summary>
        /// Gets and sets the property RetainAutomatedBackups. 
        /// <para>
        /// Specifies whether to retain automated backups after the DB cluster is deleted. If
        /// set to true, automated backups are not deleted and can be restored later.
        /// </para>
        /// </summary>
        public bool? RetainAutomatedBackups { get; set; }

        /// <summary>
        /// Checks to see if the RetainAutomatedBackups property is set.
        /// </summary>
        internal bool IsSetRetainAutomatedBackups() => this.RetainAutomatedBackups.HasValue;
    }
}
