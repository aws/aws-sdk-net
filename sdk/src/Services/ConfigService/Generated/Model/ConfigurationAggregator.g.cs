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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The details about the configuration aggregator, including information about source
    /// accounts, regions, and metadata of the aggregator.
    /// </summary>
    public partial class ConfigurationAggregator
    {
        /// <summary>
        /// Gets and sets the property AccountAggregationSources. 
        /// <para>
        /// Provides a list of source accounts and regions to be aggregated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<AccountAggregationSource> AccountAggregationSources { get; set; } = AWSConfigs.InitializeCollections ? new List<AccountAggregationSource>() : null;

        /// <summary>
        /// Checks to see if the AccountAggregationSources property is set.
        /// </summary>
        internal bool IsSetAccountAggregationSources() => this.AccountAggregationSources != null && (this.AccountAggregationSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AggregatorFilters. 
        /// <para>
        /// An object to filter the data you specify for an aggregator.
        /// </para>
        /// </summary>
        public AggregatorFilters AggregatorFilters { get; set; }

        /// <summary>
        /// Checks to see if the AggregatorFilters property is set.
        /// </summary>
        internal bool IsSetAggregatorFilters() => this.AggregatorFilters != null;

        /// <summary>
        /// Gets and sets the property ConfigurationAggregatorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the aggregator.
        /// </para>
        /// </summary>
        public string ConfigurationAggregatorArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationAggregatorArn property is set.
        /// </summary>
        internal bool IsSetConfigurationAggregatorArn() => this.ConfigurationAggregatorArn != null;

        /// <summary>
        /// Gets and sets the property ConfigurationAggregatorName. 
        /// <para>
        /// The name of the aggregator.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ConfigurationAggregatorName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationAggregatorName property is set.
        /// </summary>
        internal bool IsSetConfigurationAggregatorName() => this.ConfigurationAggregatorName != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Amazon Web Services service that created the configuration aggregator.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time stamp when the configuration aggregator was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time of the last update.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property OrganizationAggregationSource. 
        /// <para>
        /// Provides an organization and list of regions to be aggregated.
        /// </para>
        /// </summary>
        public OrganizationAggregationSource OrganizationAggregationSource { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationAggregationSource property is set.
        /// </summary>
        internal bool IsSetOrganizationAggregationSource() => this.OrganizationAggregationSource != null;
    }
}
