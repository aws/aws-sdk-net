/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The details about the configuration aggregator, including information about source
    /// accounts, regions, and metadata of the aggregator.
    /// </summary>
    public partial class ConfigurationAggregator
    {
        private List<AccountAggregationSource> _accountAggregationSources = new List<AccountAggregationSource>();
        private string _configurationAggregatorArn;
        private string _configurationAggregatorName;
        private DateTime? _creationTime;
        private DateTime? _lastUpdatedTime;
        private OrganizationAggregationSource _organizationAggregationSource;

        /// <summary>
        /// Gets and sets the property AccountAggregationSources. 
        /// <para>
        /// Provides a list of source accounts and regions to be aggregated.
        /// </para>
        /// </summary>
        public List<AccountAggregationSource> AccountAggregationSources
        {
            get { return this._accountAggregationSources; }
            set { this._accountAggregationSources = value; }
        }

        // Check to see if AccountAggregationSources property is set
        internal bool IsSetAccountAggregationSources()
        {
            return this._accountAggregationSources != null && this._accountAggregationSources.Count > 0; 
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time stamp when the configuration aggregator was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
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
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
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