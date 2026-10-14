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
    /// Property attributes that include configuration properties for the catalog resource.
    /// </summary>
    public partial class CatalogPropertiesOutput
    {
        /// <summary>
        /// Gets and sets the property CustomProperties. 
        /// <para>
        /// Additional key-value properties for the catalog, such as column statistics optimizations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> CustomProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the CustomProperties property is set.
        /// </summary>
        internal bool IsSetCustomProperties() => this.CustomProperties != null && (this.CustomProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataLakeAccessProperties. 
        /// <para>
        /// A <c>DataLakeAccessProperties</c> object with input properties to configure data lake
        /// access for your catalog resource in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public DataLakeAccessPropertiesOutput DataLakeAccessProperties { get; set; }

        /// <summary>
        /// Checks to see if the DataLakeAccessProperties property is set.
        /// </summary>
        internal bool IsSetDataLakeAccessProperties() => this.DataLakeAccessProperties != null;

        /// <summary>
        /// Gets and sets the property IcebergOptimizationProperties. 
        /// <para>
        /// An <c>IcebergOptimizationPropertiesOutput</c> object that specifies Iceberg table
        /// optimization settings for the catalog, including configurations for compaction, retention,
        /// and orphan file deletion operations.
        /// </para>
        /// </summary>
        public IcebergOptimizationPropertiesOutput IcebergOptimizationProperties { get; set; }

        /// <summary>
        /// Checks to see if the IcebergOptimizationProperties property is set.
        /// </summary>
        internal bool IsSetIcebergOptimizationProperties() => this.IcebergOptimizationProperties != null;
    }
}
