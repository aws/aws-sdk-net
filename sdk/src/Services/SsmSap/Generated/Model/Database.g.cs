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

namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// The SAP HANA database of the application registered with AWS Systems Manager for SAP.
    /// </summary>
    public partial class Database
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the database.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ComponentId. 
        /// <para>
        /// The ID of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ComponentId { get; set; }

        /// <summary>
        /// Checks to see if the ComponentId property is set.
        /// </summary>
        internal bool IsSetComponentId() => this.ComponentId != null;

        /// <summary>
        /// Gets and sets the property ConnectedComponentArns. 
        /// <para>
        /// The Amazon Resource Names of the connected AWS Systems Manager for SAP components.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConnectedComponentArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConnectedComponentArns property is set.
        /// </summary>
        internal bool IsSetConnectedComponentArns() => this.ConnectedComponentArns != null && (this.ConnectedComponentArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials of the database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<ApplicationCredential> Credentials { get; set; } = AWSConfigs.InitializeCollections ? new List<ApplicationCredential>() : null;

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null && (this.Credentials.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DatabaseId. 
        /// <para>
        /// The ID of the SAP HANA database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string DatabaseId { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseId property is set.
        /// </summary>
        internal bool IsSetDatabaseId() => this.DatabaseId != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property DatabaseType. 
        /// <para>
        /// The type of the database.
        /// </para>
        /// </summary>
        public DatabaseType DatabaseType { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseType property is set.
        /// </summary>
        internal bool IsSetDatabaseType() => this.DatabaseType != null;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time at which the database was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property PrimaryHost. 
        /// <para>
        /// The primary host of the database.
        /// </para>
        /// </summary>
        public string PrimaryHost { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryHost property is set.
        /// </summary>
        internal bool IsSetPrimaryHost() => this.PrimaryHost != null;

        /// <summary>
        /// Gets and sets the property SQLPort. 
        /// <para>
        /// The SQL port of the database.
        /// </para>
        /// </summary>
        public int? SQLPort { get; set; }

        /// <summary>
        /// Checks to see if the SQLPort property is set.
        /// </summary>
        internal bool IsSetSQLPort() => this.SQLPort.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the database.
        /// </para>
        /// </summary>
        public DatabaseStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
