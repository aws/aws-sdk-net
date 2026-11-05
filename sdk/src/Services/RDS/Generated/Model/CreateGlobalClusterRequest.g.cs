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
    /// Container for the parameters to the CreateGlobalCluster operation. Creates an Aurora
    /// global database spread across multiple Amazon Web Services Regions. The global database
    /// contains a single primary cluster with read-write capability, and a read-only secondary
    /// cluster that receives data from the primary cluster through high-speed replication
    /// performed by the Aurora storage subsystem. <para> You can create a global database
    /// that is initially empty, and then create the primary and secondary DB clusters in
    /// the global database. Or you can specify an existing Aurora cluster during the create
    /// operation, and this cluster becomes the primary cluster of the global database. </para>
    /// <note> <para> This operation applies only to Aurora DB clusters. </para> </note>
    /// </summary>
    public partial class CreateGlobalClusterRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name for your database of up to 64 alphanumeric characters. If you don't specify
        /// a name, Amazon Aurora doesn't create a database in the global database cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be specified if <c>SourceDBClusterIdentifier</c> is specified. In this case,
        /// Amazon Aurora uses the database name from the source DB cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether to enable deletion protection for the new global database cluster.
        /// The global database can't be deleted when deletion protection is enabled.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine to use for this global database cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>aurora-mysql | aurora-postgresql</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be specified if <c>SourceDBClusterIdentifier</c> is specified. In this case,
        /// Amazon Aurora uses the engine of the source DB cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineLifecycleSupport. 
        /// <para>
        /// The lifecycle type for this global database cluster.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, this value is set to <c>open-source-rds-extended-support</c>, which enrolls
        /// your global cluster into Amazon RDS Extended Support. At the end of standard support,
        /// you can avoid charges for Extended Support by setting the value to <c>open-source-rds-extended-support-disabled</c>.
        /// In this case, creating the global cluster will fail if the DB major version is past
        /// its end of standard support date.
        /// </para>
        ///  </note> 
        /// <para>
        /// This setting only applies to Aurora PostgreSQL-based global databases.
        /// </para>
        ///  
        /// <para>
        /// You can use this setting to enroll your global cluster into Amazon RDS Extended Support.
        /// With RDS Extended Support, you can run the selected major engine version on your global
        /// cluster past the end of standard support for that engine version. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/extended-support.html">Amazon
        /// RDS Extended Support with Amazon Aurora</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>open-source-rds-extended-support | open-source-rds-extended-support-disabled</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>open-source-rds-extended-support</c> 
        /// </para>
        /// </summary>
        public string EngineLifecycleSupport { get; set; }

        /// <summary>
        /// Checks to see if the EngineLifecycleSupport property is set.
        /// </summary>
        internal bool IsSetEngineLifecycleSupport() => this.EngineLifecycleSupport != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version to use for this global database cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be specified if <c>SourceDBClusterIdentifier</c> is specified. In this case,
        /// Amazon Aurora uses the engine version of the source DB cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// The cluster identifier for this global database cluster. This parameter is stored
        /// as a lowercase string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string GlobalClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GlobalClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetGlobalClusterIdentifier() => this.GlobalClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property SourceDBClusterIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) to use as the primary cluster of the global database.
        /// </para>
        ///  
        /// <para>
        /// If you provide a value for this parameter, don't specify values for the following
        /// settings because Amazon Aurora uses the values from the specified source DB cluster:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DatabaseName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Engine</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EngineVersion</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StorageEncrypted</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceDBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceDBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetSourceDBClusterIdentifier() => this.SourceDBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Specifies whether to enable storage encryption for the new global database cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be specified if <c>SourceDBClusterIdentifier</c> is specified. In this case,
        /// Amazon Aurora uses the setting from the source DB cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? StorageEncrypted { get; set; }

        /// <summary>
        /// Checks to see if the StorageEncrypted property is set.
        /// </summary>
        internal bool IsSetStorageEncrypted() => this.StorageEncrypted.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to assign to the global cluster.
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
    }
}
