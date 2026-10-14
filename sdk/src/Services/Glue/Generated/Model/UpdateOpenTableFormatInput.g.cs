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
    /// Input parameters for updating open table format tables in GlueData Catalog, serving
    /// as a wrapper for format-specific update operations such as Apache Iceberg.
    /// </summary>
    public partial class UpdateOpenTableFormatInput
    {
        /// <summary>
        /// Gets and sets the property UpdateIcebergInput. 
        /// <para>
        /// Apache Iceberg-specific update parameters that define the table modifications to be
        /// applied, including schema changes, partition specifications, and table properties.
        /// </para>
        /// </summary>
        public UpdateIcebergInput UpdateIcebergInput { get; set; }

        /// <summary>
        /// Checks to see if the UpdateIcebergInput property is set.
        /// </summary>
        internal bool IsSetUpdateIcebergInput() => this.UpdateIcebergInput != null;
    }
}
