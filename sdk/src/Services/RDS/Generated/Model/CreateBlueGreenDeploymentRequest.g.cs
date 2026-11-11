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
    /// Container for the parameters to the CreateBlueGreenDeployment operation. Creates a
    /// blue/green deployment. <para> A blue/green deployment creates a staging environment
    /// that copies the production environment. In a blue/green deployment, the blue environment
    /// is the current production environment. The green environment is the staging environment,
    /// and it stays in sync with the current production environment. </para> <para> You can
    /// make changes to the databases in the green environment without affecting production
    /// workloads. For example, you can upgrade the major or minor DB engine version, change
    /// database parameters, or make schema changes in the staging environment. You can thoroughly
    /// test changes in the green environment. When ready, you can switch over the environments
    /// to promote the green environment to be the new production environment. The switchover
    /// typically takes under a minute. </para> <para> For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/blue-green-deployments.html">Using
    /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon RDS User
    /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">
    /// Using Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon
    /// Aurora User Guide</i>. </para>
    /// </summary>
    public partial class CreateBlueGreenDeploymentRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property BlueGreenDeploymentName. 
        /// <para>
        /// The name of the blue/green deployment.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be the same as an existing blue/green deployment name in the same account and
        /// Amazon Web Services Region.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 60)]
        public string BlueGreenDeploymentName { get; set; }

        /// <summary>
        /// Checks to see if the BlueGreenDeploymentName property is set.
        /// </summary>
        internal bool IsSetBlueGreenDeploymentName() => this.BlueGreenDeploymentName != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source production database.
        /// </para>
        ///  
        /// <para>
        /// Specify the database that you want to clone. The blue/green deployment creates this
        /// database in the green environment. You can make updates to the database in the green
        /// environment, such as an engine version upgrade. When you are ready, you can switch
        /// the database in the green environment to be the production database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to assign to the blue/green deployment.
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
        /// Gets and sets the property TargetAllocatedStorage. 
        /// <para>
        /// The amount of storage in gibibytes (GiB) to allocate for the green DB instance. You
        /// can choose to increase or decrease the allocated storage on the green DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora blue/green deployments.
        /// </para>
        /// </summary>
        public int? TargetAllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the TargetAllocatedStorage property is set.
        /// </summary>
        internal bool IsSetTargetAllocatedStorage() => this.TargetAllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property TargetDBClusterParameterGroupName. 
        /// <para>
        /// The DB cluster parameter group associated with the Aurora DB cluster in the green
        /// environment.
        /// </para>
        ///  
        /// <para>
        /// To test parameter changes, specify a DB cluster parameter group that is different
        /// from the one associated with the source DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TargetDBClusterParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the TargetDBClusterParameterGroupName property is set.
        /// </summary>
        internal bool IsSetTargetDBClusterParameterGroupName() => this.TargetDBClusterParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property TargetDBInstanceClass. 
        /// <para>
        /// Specify the DB instance class for the databases in the green environment.
        /// </para>
        ///  
        /// <para>
        /// This parameter only applies to RDS DB instances, because DB instances within an Aurora
        /// DB cluster can have multiple different instance classes. If you're creating a blue/green
        /// deployment from an Aurora DB cluster, don't specify this parameter. After the green
        /// environment is created, you can individually modify the instance classes of the DB
        /// instances within the green DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 20)]
        public string TargetDBInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the TargetDBInstanceClass property is set.
        /// </summary>
        internal bool IsSetTargetDBInstanceClass() => this.TargetDBInstanceClass != null;

        /// <summary>
        /// Gets and sets the property TargetDBParameterGroupName. 
        /// <para>
        /// The DB parameter group associated with the DB instance in the green environment.
        /// </para>
        ///  
        /// <para>
        /// To test parameter changes, specify a DB parameter group that is different from the
        /// one associated with the source DB instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TargetDBParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the TargetDBParameterGroupName property is set.
        /// </summary>
        internal bool IsSetTargetDBParameterGroupName() => this.TargetDBParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property TargetEngineVersion. 
        /// <para>
        /// The engine version of the database in the green environment.
        /// </para>
        ///  
        /// <para>
        /// Specify the engine version to upgrade to in the green environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string TargetEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the TargetEngineVersion property is set.
        /// </summary>
        internal bool IsSetTargetEngineVersion() => this.TargetEngineVersion != null;

        /// <summary>
        /// Gets and sets the property TargetIops. 
        /// <para>
        /// The amount of Provisioned IOPS (input/output operations per second) to allocate for
        /// the green DB instance. For information about valid IOPS values, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html">Amazon
        /// RDS DB instance storage</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora blue/green deployments.
        /// </para>
        /// </summary>
        public int? TargetIops { get; set; }

        /// <summary>
        /// Checks to see if the TargetIops property is set.
        /// </summary>
        internal bool IsSetTargetIops() => this.TargetIops.HasValue;

        /// <summary>
        /// Gets and sets the property TargetResourceConfigurations. 
        /// <para>
        /// Specifies resource-level configuration overrides for the green environment.
        /// </para>
        ///  
        /// <para>
        /// Each entry identifies a resource in the blue environment by its Amazon Resource Name
        /// (ARN). It defines the desired configuration for the corresponding resource in the
        /// green environment. Any resource that you don't include in this parameter retains the
        /// same configuration as its counterpart in the blue environment.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter when one or more resources in the green environment require a different
        /// configuration than what they have in the blue environment.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can't specify the same <c>SourceArn</c> in more than one entry.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<TargetResourceConfiguration> TargetResourceConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<TargetResourceConfiguration>() : null;

        /// <summary>
        /// Checks to see if the TargetResourceConfigurations property is set.
        /// </summary>
        internal bool IsSetTargetResourceConfigurations() => this.TargetResourceConfigurations != null && (this.TargetResourceConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetStorageThroughput. 
        /// <para>
        /// The storage throughput value for the green DB instance.
        /// </para>
        ///  
        /// <para>
        /// This setting applies only to the <c>gp3</c> storage type.
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora blue/green deployments.
        /// </para>
        /// </summary>
        public int? TargetStorageThroughput { get; set; }

        /// <summary>
        /// Checks to see if the TargetStorageThroughput property is set.
        /// </summary>
        internal bool IsSetTargetStorageThroughput() => this.TargetStorageThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property TargetStorageType. 
        /// <para>
        /// The storage type to associate with the green DB instance.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>gp2 | gp3 | io1 | io2</c> 
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't apply to Amazon Aurora blue/green deployments.
        /// </para>
        /// </summary>
        public string TargetStorageType { get; set; }

        /// <summary>
        /// Checks to see if the TargetStorageType property is set.
        /// </summary>
        internal bool IsSetTargetStorageType() => this.TargetStorageType != null;

        /// <summary>
        /// Gets and sets the property UpgradeTargetStorageConfig. 
        /// <para>
        /// Whether to upgrade the storage file system configuration on the green database. This
        /// option migrates the green DB instance from the older 32-bit file system to the preferred
        /// configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIOPS.StorageTypes.html#USER_PIOPS.UpgradeFileSystem">Upgrading
        /// the storage file system for a DB instance</a>.
        /// </para>
        /// </summary>
        public bool? UpgradeTargetStorageConfig { get; set; }

        /// <summary>
        /// Checks to see if the UpgradeTargetStorageConfig property is set.
        /// </summary>
        internal bool IsSetUpgradeTargetStorageConfig() => this.UpgradeTargetStorageConfig.HasValue;
    }
}
