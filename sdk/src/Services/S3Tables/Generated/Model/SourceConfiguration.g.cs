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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// The source to migrate from. Set exactly one member, and set <c>sourceType</c> to match
    /// it.
    /// </summary>
    public partial class SourceConfiguration
    {
        /// <summary>
        /// Gets and sets the property GlueTable. 
        /// <para>
        /// An Amazon Web Services Glue Data Catalog table to migrate. The table must be an external
        /// Apache Hive table whose data is stored as Parquet in a general purpose bucket in the
        /// same account and Region as the table bucket. Views, transactional (ACID) tables, tables
        /// in an open table format such as Apache Iceberg, and tables registered with Amazon
        /// Web Services Lake Formation can't be migrated. If the table can't be migrated, the
        /// migration fails, and the table compatibility report lists the reason.
        /// </para>
        /// </summary>
        public GlueTableSource GlueTable { get; set; }

        /// <summary>
        /// Checks to see if the GlueTable property is set.
        /// </summary>
        internal bool IsSetGlueTable() => this.GlueTable != null;
    }
}
