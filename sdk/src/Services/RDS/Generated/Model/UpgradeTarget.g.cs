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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// The version of the database engine that a DB instance can be upgraded to.
    /// </summary>
    public partial class UpgradeTarget
    {
        /// <summary>
        /// Gets and sets the property AutoUpgrade. 
        /// <para>
        /// Indicates whether the target version is applied to any source DB instances that have
        /// <c>AutoMinorVersionUpgrade</c> set to true.
        /// </para>
        ///  
        /// <para>
        /// This parameter is dynamic, and is set by RDS.
        /// </para>
        /// </summary>
        public bool? AutoUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AutoUpgrade property is set.
        /// </summary>
        internal bool IsSetAutoUpgrade() => this.AutoUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The version of the database engine that a DB instance can be upgraded to.
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
        /// The name of the upgrade target database engine.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the upgrade target database engine.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property IsMajorVersionUpgrade. 
        /// <para>
        /// Indicates whether upgrading to the target version requires upgrading the major version
        /// of the database engine.
        /// </para>
        /// </summary>
        public bool? IsMajorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the IsMajorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetIsMajorVersionUpgrade() => this.IsMajorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property SupportedEngineModes. 
        /// <para>
        /// A list of the supported DB engine modes for the target engine version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedEngineModes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedEngineModes property is set.
        /// </summary>
        internal bool IsSetSupportedEngineModes() => this.SupportedEngineModes != null && (this.SupportedEngineModes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportsBabelfish. 
        /// <para>
        /// Indicates whether you can use Babelfish for Aurora PostgreSQL with the target engine
        /// version.
        /// </para>
        /// </summary>
        public bool? SupportsBabelfish { get; set; }

        /// <summary>
        /// Checks to see if the SupportsBabelfish property is set.
        /// </summary>
        internal bool IsSetSupportsBabelfish() => this.SupportsBabelfish.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsGlobalDatabases. 
        /// <para>
        /// Indicates whether you can use Aurora global databases with the target engine version.
        /// </para>
        /// </summary>
        public bool? SupportsGlobalDatabases { get; set; }

        /// <summary>
        /// Checks to see if the SupportsGlobalDatabases property is set.
        /// </summary>
        internal bool IsSetSupportsGlobalDatabases() => this.SupportsGlobalDatabases.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsIntegrations. 
        /// <para>
        /// Indicates whether the DB engine version supports zero-ETL integrations with Amazon
        /// Redshift.
        /// </para>
        /// </summary>
        public bool? SupportsIntegrations { get; set; }

        /// <summary>
        /// Checks to see if the SupportsIntegrations property is set.
        /// </summary>
        internal bool IsSetSupportsIntegrations() => this.SupportsIntegrations.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsLimitlessDatabase. 
        /// <para>
        /// Indicates whether the DB engine version supports Aurora Limitless Database.
        /// </para>
        /// </summary>
        public bool? SupportsLimitlessDatabase { get; set; }

        /// <summary>
        /// Checks to see if the SupportsLimitlessDatabase property is set.
        /// </summary>
        internal bool IsSetSupportsLimitlessDatabase() => this.SupportsLimitlessDatabase.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsLocalWriteForwarding. 
        /// <para>
        /// Indicates whether the target engine version supports forwarding write operations from
        /// reader DB instances to the writer DB instance in the DB cluster. By default, write
        /// operations aren't allowed on reader DB instances.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        /// </summary>
        public bool? SupportsLocalWriteForwarding { get; set; }

        /// <summary>
        /// Checks to see if the SupportsLocalWriteForwarding property is set.
        /// </summary>
        internal bool IsSetSupportsLocalWriteForwarding() => this.SupportsLocalWriteForwarding.HasValue;

        /// <summary>
        /// Gets and sets the property SupportsParallelQuery. 
        /// <para>
        /// Indicates whether you can use Aurora parallel query with the target engine version.
        /// </para>
        /// </summary>
        public bool? SupportsParallelQuery { get; set; }

        /// <summary>
        /// Checks to see if the SupportsParallelQuery property is set.
        /// </summary>
        internal bool IsSetSupportsParallelQuery() => this.SupportsParallelQuery.HasValue;
    }
}
