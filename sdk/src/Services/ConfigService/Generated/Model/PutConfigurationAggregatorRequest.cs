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
    /// Container for the parameters to the PutConfigurationAggregator operation.
    /// Creates and updates the configuration aggregator with the selected source accounts
    /// and regions. The source account can be individual account(s) or an organization.
    /// 
    ///  <note> 
    /// <para>
    /// AWS Config should be enabled in source accounts and regions you want to aggregate.
    /// </para>
    ///  
    /// <para>
    /// If your source type is an organization, you must be signed in to the master account
    /// and all features must be enabled in your organization. AWS Config calls <code>EnableAwsServiceAccess</code>
    /// API to enable integration between AWS Config and AWS Organizations. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutConfigurationAggregatorRequest : AmazonConfigServiceRequest
    {
        private List<AccountAggregationSource> _accountAggregationSources = new List<AccountAggregationSource>();
        private string _configurationAggregatorName;
        private OrganizationAggregationSource _organizationAggregationSource;

        /// <summary>
        /// Gets and sets the property AccountAggregationSources. 
        /// <para>
        /// A list of AccountAggregationSource object. 
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
        /// Gets and sets the property ConfigurationAggregatorName. 
        /// <para>
        /// The name of the configuration aggregator.
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
        /// Gets and sets the property OrganizationAggregationSource. 
        /// <para>
        /// An OrganizationAggregationSource object.
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