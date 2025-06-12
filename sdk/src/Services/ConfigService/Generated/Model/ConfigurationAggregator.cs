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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
        private List<AccountAggregationSource> _accountAggregationSources = AWSConfigs.InitializeCollections ? new List<AccountAggregationSource>() : null;
        private AggregatorFilters _aggregatorFilters;
        private string _configurationAggregatorArn;
        private string _configurationAggregatorName;
        private string _createdBy;
        private DateTime? _creationTime;
        private DateTime? _lastUpdatedTime;
        private OrganizationAggregationSource _organizationAggregationSource;

        /// <summary>
        /// Gets and sets the property AccountAggregationSources. 
        /// <para>
        /// Provides a list of source accounts and regions to be aggregated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<AccountAggregationSource> AccountAggregationSources
        {
            get { return this._accountAggregationSources; }
            set { this._accountAggregationSources = value; }
        }

        // Check to see if AccountAggregationSources property is set
        internal bool IsSetAccountAggregationSources()
        {
            return this._accountAggregationSources != null && (this._accountAggregationSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AggregatorFilters. 
        /// <para>
        /// An object to filter the data you specify for an aggregator.
        /// </para>
        /// </summary>
        public AggregatorFilters AggregatorFilters
        {
            get { return this._aggregatorFilters; }
            set { this._aggregatorFilters = value; }
        }

        // Check to see if AggregatorFilters property is set
        internal bool IsSetAggregatorFilters()
        {
            return this._aggregatorFilters != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationAggregatorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the aggregator.
        /// </para>
        /// </summary>
        public string ConfigurationAggregatorArn
        {
            get { return this._configurationAggregatorArn; }
            set { this._configurationAggregatorArn = value; }
        }

        // Check to see if ConfigurationAggregatorArn property is set
        internal bool IsSetConfigurationAggregatorArn()
        {
            return this._configurationAggregatorArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationAggregatorName. 
        /// <para>
        /// The name of the aggregator.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ConfigurationAggregatorName
        {
            get { return this._configurationAggregatorName; }
            set { this._configurationAggregatorName = value; }
        }

        // Check to see if ConfigurationAggregatorName property is set
        internal bool IsSetConfigurationAggregatorName()
        {
            return this._configurationAggregatorName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Amazon Web Services service that created the configuration aggregator.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time stamp when the configuration aggregator was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time of the last update.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationAggregationSource. 
        /// <para>
        /// Provides an organization and list of regions to be aggregated.
        /// </para>
        /// </summary>
        public OrganizationAggregationSource OrganizationAggregationSource
        {
            get { return this._organizationAggregationSource; }
            set { this._organizationAggregationSource = value; }
        }

        // Check to see if OrganizationAggregationSource property is set
        internal bool IsSetOrganizationAggregationSource()
        {
            return this._organizationAggregationSource != null;
        }

    }
}