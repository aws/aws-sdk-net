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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Updates to the configuration parameters for the default Amazon Glue database. You
    /// use this database for SQL queries that you write in a Managed Service for Apache Flink
    /// Studio notebook.
    /// </summary>
    public partial class CatalogConfigurationUpdate
    {
        /// <summary>
        /// Gets and sets the property GlueDataCatalogConfigurationUpdate. 
        /// <para>
        /// Updates to the configuration parameters for the default Amazon Glue database. You
        /// use this database for SQL queries that you write in a Managed Service for Apache Flink
        /// Studio notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GlueDataCatalogConfigurationUpdate GlueDataCatalogConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the GlueDataCatalogConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetGlueDataCatalogConfigurationUpdate() => this.GlueDataCatalogConfigurationUpdate != null;
    }
}
