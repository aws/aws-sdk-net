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
    /// The Amazon Redshift properties.
    /// </summary>
    public partial class RedshiftPropertiesOutput
    {
        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The Amazon Redshift credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RedshiftCredentials Credentials { get; set; }

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The Amazon Redshift database name.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property IsProvisionedSecret. 
        /// <para>
        /// Specifies whether Amaon Redshift properties has a provisioned secret.
        /// </para>
        /// </summary>
        public bool? IsProvisionedSecret { get; set; }

        /// <summary>
        /// Checks to see if the IsProvisionedSecret property is set.
        /// </summary>
        internal bool IsSetIsProvisionedSecret() => this.IsProvisionedSecret.HasValue;

        /// <summary>
        /// Gets and sets the property JdbcIamUrl. 
        /// <para>
        /// The jdbcIam URL of the Amazon Redshift properties.
        /// </para>
        /// </summary>
        public string JdbcIamUrl { get; set; }

        /// <summary>
        /// Checks to see if the JdbcIamUrl property is set.
        /// </summary>
        internal bool IsSetJdbcIamUrl() => this.JdbcIamUrl != null;

        /// <summary>
        /// Gets and sets the property JdbcUrl. 
        /// <para>
        /// The jdbcURL of the Amazon Redshift properties. 
        /// </para>
        /// </summary>
        public string JdbcUrl { get; set; }

        /// <summary>
        /// Checks to see if the JdbcUrl property is set.
        /// </summary>
        internal bool IsSetJdbcUrl() => this.JdbcUrl != null;

        /// <summary>
        /// Gets and sets the property LineageSync. 
        /// <para>
        /// The lineage syn of the Amazon Redshift properties.
        /// </para>
        /// </summary>
        public RedshiftLineageSyncConfigurationOutput LineageSync { get; set; }

        /// <summary>
        /// Checks to see if the LineageSync property is set.
        /// </summary>
        internal bool IsSetLineageSync() => this.LineageSync != null;

        /// <summary>
        /// Gets and sets the property RedshiftTempDir. 
        /// <para>
        /// The redshiftTempDir of the Amazon Redshift properties.
        /// </para>
        /// </summary>
        public string RedshiftTempDir { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftTempDir property is set.
        /// </summary>
        internal bool IsSetRedshiftTempDir() => this.RedshiftTempDir != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status in the Amazon Redshift properties.
        /// </para>
        /// </summary>
        public ConnectionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// The storage in the Amazon Redshift properties.
        /// </para>
        /// </summary>
        public RedshiftStorageProperties Storage { get; set; }

        /// <summary>
        /// Checks to see if the Storage property is set.
        /// </summary>
        internal bool IsSetStorage() => this.Storage != null;
    }
}
