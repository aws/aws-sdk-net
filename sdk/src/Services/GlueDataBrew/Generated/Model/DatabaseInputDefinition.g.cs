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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Connection information for dataset input files stored in a database.
    /// </summary>
    public partial class DatabaseInputDefinition
    {
        /// <summary>
        /// Gets and sets the property DatabaseTableName. 
        /// <para>
        /// The table within the target database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DatabaseTableName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseTableName property is set.
        /// </summary>
        internal bool IsSetDatabaseTableName() => this.DatabaseTableName != null;

        /// <summary>
        /// Gets and sets the property GlueConnectionName. 
        /// <para>
        /// The Glue Connection that stores the connection information for the target database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string GlueConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the GlueConnectionName property is set.
        /// </summary>
        internal bool IsSetGlueConnectionName() => this.GlueConnectionName != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// Custom SQL to run against the provided Glue connection. This SQL will be used as the
        /// input for DataBrew projects and jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property TempDirectory.
        /// </summary>
        public S3Location TempDirectory { get; set; }

        /// <summary>
        /// Checks to see if the TempDirectory property is set.
        /// </summary>
        internal bool IsSetTempDirectory() => this.TempDirectory != null;
    }
}
