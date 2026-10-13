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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetMaterializedViewRefreshTaskRun operation. Get
    /// the associated metadata/information for a task run, given a task run ID.
    /// </summary>
    public partial class GetMaterializedViewRefreshTaskRunRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the table resides. If none is supplied, the account
        /// ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property MaterializedViewRefreshTaskRunId. 
        /// <para>
        /// The identifier for the particular materialized view refresh task run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MaterializedViewRefreshTaskRunId { get; set; }

        /// <summary>
        /// Checks to see if the MaterializedViewRefreshTaskRunId property is set.
        /// </summary>
        internal bool IsSetMaterializedViewRefreshTaskRunId() => this.MaterializedViewRefreshTaskRunId != null;
    }
}
