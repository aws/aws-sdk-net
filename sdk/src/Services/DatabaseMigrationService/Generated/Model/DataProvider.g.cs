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
    /// Provides information that defines a data provider.
    /// </summary>
    public partial class DataProvider
    {
        /// <summary>
        /// Gets and sets the property DataProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) string that uniquely identifies the data provider.
        /// </para>
        /// </summary>
        public string DataProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the DataProviderArn property is set.
        /// </summary>
        internal bool IsSetDataProviderArn() => this.DataProviderArn != null;

        /// <summary>
        /// Gets and sets the property DataProviderCreationTime. 
        /// <para>
        /// The time the data provider was created.
        /// </para>
        /// </summary>
        public DateTime? DataProviderCreationTime { get; set; }

        /// <summary>
        /// Checks to see if the DataProviderCreationTime property is set.
        /// </summary>
        internal bool IsSetDataProviderCreationTime() => this.DataProviderCreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataProviderName. 
        /// <para>
        /// The name of the data provider.
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
        /// A description of the data provider. Descriptions can have up to 31 characters. A description
        /// can contain only ASCII letters, digits, and hyphens ('-'). Also, it can't end with
        /// a hyphen or contain two consecutive hyphens, and can only begin with a letter.
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
        public DataProviderSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;

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
