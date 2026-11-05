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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataProvider operation. Creates a data provider
    /// using the provided settings. A data provider stores a data store type and location
    /// information about your database. <para> <b>Required permissions:</b> <c>dms:CreateDataProvider</c>.
    /// For more information, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsdatabasemigrationservice.html">Actions,
    /// resources, and condition keys for Database Migration Service</a>. </para>
    /// </summary>
    public partial class CreateDataProviderRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DataProviderName. 
        /// <para>
        /// A user-friendly name for the data provider.
        /// </para>
        /// </summary>
        public string DataProviderName { get; set; }

        /// <summary>
        /// Checks to see if the DataProviderName property is set.
        /// </summary>
        internal bool IsSetDataProviderName() => this.DataProviderName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-friendly description of the data provider.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The type of database engine for the data provider.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>aurora</c>, <c>aurora-postgresql</c>, <c>db2</c>, <c>db2-zos</c>,
        /// <c>docdb</c>, <c>mariadb</c>, <c>mongodb</c>, <c>mysql</c>, <c>oracle</c>, <c>postgres</c>,
        /// <c>redshift</c>, <c>sqlserver</c>, and <c>sybase</c>. A value of <c>aurora</c> represents
        /// Amazon Aurora MySQL-Compatible Edition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The settings in JSON format for a data provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataProviderSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to be assigned to the data provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Virtual. 
        /// <para>
        /// Indicates whether the data provider is virtual.
        /// </para>
        /// </summary>
        public bool? Virtual { get; set; }

        /// <summary>
        /// Checks to see if the Virtual property is set.
        /// </summary>
        internal bool IsSetVirtual() => this.Virtual.HasValue;
    }
}
