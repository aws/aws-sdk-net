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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The configuration details of the Amazon Web Services Glue data source.
    /// </summary>
    public partial class GlueRunConfigurationOutput
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID included in the configuration details of the Amazon
        /// Web Services Glue data source. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AutoImportDataQualityResult. 
        /// <para>
        /// Specifies whether to automatically import data quality metrics as part of the data
        /// source run.
        /// </para>
        /// </summary>
        public bool? AutoImportDataQualityResult { get; set; }

        /// <summary>
        /// Checks to see if the AutoImportDataQualityResult property is set.
        /// </summary>
        internal bool IsSetAutoImportDataQualityResult() => this.AutoImportDataQualityResult.HasValue;

        /// <summary>
        /// Gets and sets the property CatalogName. 
        /// <para>
        /// The catalog name in the Amazon Web Services Glue run configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string CatalogName { get; set; }

        /// <summary>
        /// Checks to see if the CatalogName property is set.
        /// </summary>
        internal bool IsSetCatalogName() => this.CatalogName != null;

        /// <summary>
        /// Gets and sets the property DataAccessRole. 
        /// <para>
        /// The data access role included in the configuration details of the Amazon Web Services
        /// Glue data source. 
        /// </para>
        /// </summary>
        public string DataAccessRole { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRole property is set.
        /// </summary>
        internal bool IsSetDataAccessRole() => this.DataAccessRole != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services region included in the configuration details of the Amazon
        /// Web Services Glue data source. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 16)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property RelationalFilterConfigurations. 
        /// <para>
        /// The relational filter configurations included in the configuration details of the
        /// Amazon Web Services Glue data source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RelationalFilterConfiguration> RelationalFilterConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<RelationalFilterConfiguration>() : null;

        /// <summary>
        /// Checks to see if the RelationalFilterConfigurations property is set.
        /// </summary>
        internal bool IsSetRelationalFilterConfigurations() => this.RelationalFilterConfigurations != null && (this.RelationalFilterConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
