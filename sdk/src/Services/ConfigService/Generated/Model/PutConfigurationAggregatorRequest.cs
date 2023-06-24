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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutConfigurationAggregator operation.
    /// Creates and updates the configuration aggregator with the selected source accounts
    /// and regions. The source account can be individual account(s) or an organization.
    /// 
    ///  
    /// <para>
    ///  <code>accountIds</code> that are passed will be replaced with existing accounts.
    /// If you want to add additional accounts into the aggregator, call <code>DescribeConfigurationAggregators</code>
    /// to get the previous accounts and then append new ones.
    /// </para>
    ///  <note> 
    /// <para>
    /// Config should be enabled in source accounts and regions you want to aggregate.
    /// </para>
    ///  
    /// <para>
    /// If your source type is an organization, you must be signed in to the management account
    /// or a registered delegated administrator and all the features must be enabled in your
    /// organization. If the caller is a management account, Config calls <code>EnableAwsServiceAccess</code>
    /// API to enable integration between Config and Organizations. If the caller is a registered
    /// delegated administrator, Config calls <code>ListDelegatedAdministrators</code> API
    /// to verify whether the caller is a valid delegated administrator.
    /// </para>
    ///  
    /// <para>
    /// To register a delegated administrator, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/set-up-aggregator-cli.html#register-a-delegated-administrator-cli">Register
    /// a Delegated Administrator</a> in the <i>Config developer guide</i>. 
    /// </para>
    ///  </note> <note> 
    /// <para>
    ///  <code>PutConfigurationAggregator</code> is an idempotent API. Subsequent requests
    /// won’t create a duplicate resource if one was already created. If a following request
    /// has different <code>tags</code> values, Config will ignore these differences and treat
    /// it as an idempotent request of the previous. In this case, <code>tags</code> will
    /// not be updated, even if they are different.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutConfigurationAggregatorRequest : AmazonConfigServiceRequest
    {
        private List<AccountAggregationSource> _accountAggregationSources = new List<AccountAggregationSource>();
        private string _configurationAggregatorName;
        private OrganizationAggregationSource _organizationAggregationSource;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AccountAggregationSources. 
        /// <para>
        /// A list of AccountAggregationSource object. 
        /// </para>
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
            return this._accountAggregationSources != null && this._accountAggregationSources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationAggregatorName. 
        /// <para>
        /// The name of the configuration aggregator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tag object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}