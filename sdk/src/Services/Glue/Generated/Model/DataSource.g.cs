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
    /// A data source (an Glue table) for which you want data quality results.
    /// </summary>
    public partial class DataSource
    {
        /// <summary>
        /// Gets and sets the property DataQualityGlueTable. 
        /// <para>
        /// An Glue table for Data Quality Operations.
        /// </para>
        /// </summary>
        public DataQualityGlueTable DataQualityGlueTable { get; set; }

        /// <summary>
        /// Checks to see if the DataQualityGlueTable property is set.
        /// </summary>
        internal bool IsSetDataQualityGlueTable() => this.DataQualityGlueTable != null;

        /// <summary>
        /// Gets and sets the property GlueTable. 
        /// <para>
        /// An Glue table.
        /// </para>
        /// </summary>
        public GlueTable GlueTable { get; set; }

        /// <summary>
        /// Checks to see if the GlueTable property is set.
        /// </summary>
        internal bool IsSetGlueTable() => this.GlueTable != null;
    }
}
