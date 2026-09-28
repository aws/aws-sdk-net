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
    /// The configuration details of the Amazon Redshift data source.
    /// </summary>
    public partial class RedshiftRunConfigurationInput
    {
        /// <summary>
        /// Gets and sets the property DataAccessRole. 
        /// <para>
        /// The data access role included in the configuration details of the Amazon Redshift
        /// data source.
        /// </para>
        /// </summary>
        public string DataAccessRole { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRole property is set.
        /// </summary>
        internal bool IsSetDataAccessRole() => this.DataAccessRole != null;

        /// <summary>
        /// Gets and sets the property RedshiftCredentialConfiguration.
        /// </summary>
        public RedshiftCredentialConfiguration RedshiftCredentialConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftCredentialConfiguration property is set.
        /// </summary>
        internal bool IsSetRedshiftCredentialConfiguration() => this.RedshiftCredentialConfiguration != null;

        /// <summary>
        /// Gets and sets the property RedshiftStorage.
        /// </summary>
        public RedshiftStorage RedshiftStorage { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftStorage property is set.
        /// </summary>
        internal bool IsSetRedshiftStorage() => this.RedshiftStorage != null;

        /// <summary>
        /// Gets and sets the property RelationalFilterConfigurations. 
        /// <para>
        /// The relational filger configurations included in the configuration details of the
        /// Amazon Redshift data source.
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
