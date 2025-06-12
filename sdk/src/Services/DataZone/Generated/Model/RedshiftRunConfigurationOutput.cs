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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
    /// The configuration details of the Amazon Redshift data source.
    /// </summary>
    public partial class RedshiftRunConfigurationOutput
    {
        private string _accountId;
        private string _dataAccessRole;
        private RedshiftCredentialConfiguration _redshiftCredentialConfiguration;
        private RedshiftStorage _redshiftStorage;
        private string _region;
        private List<RelationalFilterConfiguration> _relationalFilterConfigurations = AWSConfigs.InitializeCollections ? new List<RelationalFilterConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account included in the configuration details of
        /// the Amazon Redshift data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property DataAccessRole. 
        /// <para>
        /// The data access role included in the configuration details of the Amazon Redshift
        /// data source.
        /// </para>
        /// </summary>
        public string DataAccessRole
        {
            get { return this._dataAccessRole; }
            set { this._dataAccessRole = value; }
        }

        // Check to see if DataAccessRole property is set
        internal bool IsSetDataAccessRole()
        {
            return this._dataAccessRole != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftCredentialConfiguration.
        /// </summary>
        public RedshiftCredentialConfiguration RedshiftCredentialConfiguration
        {
            get { return this._redshiftCredentialConfiguration; }
            set { this._redshiftCredentialConfiguration = value; }
        }

        // Check to see if RedshiftCredentialConfiguration property is set
        internal bool IsSetRedshiftCredentialConfiguration()
        {
            return this._redshiftCredentialConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftStorage.
        /// </summary>
        [AWSProperty(Required=true)]
        public RedshiftStorage RedshiftStorage
        {
            get { return this._redshiftStorage; }
            set { this._redshiftStorage = value; }
        }

        // Check to see if RedshiftStorage property is set
        internal bool IsSetRedshiftStorage()
        {
            return this._redshiftStorage != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services region included in the configuration details of the Amazon
        /// Redshift data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=16)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalFilterConfigurations. 
        /// <para>
        /// The relational filger configurations included in the configuration details of the
        /// Amazon Redshift data source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RelationalFilterConfiguration> RelationalFilterConfigurations
        {
            get { return this._relationalFilterConfigurations; }
            set { this._relationalFilterConfigurations = value; }
        }

        // Check to see if RelationalFilterConfigurations property is set
        internal bool IsSetRelationalFilterConfigurations()
        {
            return this._relationalFilterConfigurations != null && (this._relationalFilterConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}