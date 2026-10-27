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
    /// Container for the parameters to the ModifyReplicationInstance operation. Modifies
    /// the replication instance to apply new settings. You can change one or more parameters
    /// by specifying these parameters and the new values in the request. <para> Some settings
    /// are applied during the maintenance window. </para> <para> </para>
    /// </summary>
    public partial class ModifyReplicationInstanceRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage (in gigabytes) to be allocated for the replication instance.
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property AllowMajorVersionUpgrade. 
        /// <para>
        /// Indicates that major version upgrades are allowed. Changing this parameter does not
        /// result in an outage, and the change is asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// This parameter must be set to <c>true</c> when specifying a value for the <c>EngineVersion</c>
        /// parameter that is a different major version than the replication instance's current
        /// version.
        /// </para>
        /// </summary>
        public bool? AllowMajorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AllowMajorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAllowMajorVersionUpgrade() => this.AllowMajorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Indicates whether the changes should be applied immediately or during the next maintenance
        /// window.
        /// </para>
        /// </summary>
        public bool? ApplyImmediately { get; set; }

        /// <summary>
        /// Checks to see if the ApplyImmediately property is set.
        /// </summary>
        internal bool IsSetApplyImmediately() => this.ApplyImmediately.HasValue;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// A value that indicates that minor version upgrades are applied automatically to the
        /// replication instance during the maintenance window. Changing this parameter doesn't
        /// result in an outage, except in the case described following. The change is asynchronously
        /// applied as soon as possible. 
        /// </para>
        ///  
        /// <para>
        /// An outage does result if these factors apply: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This parameter is set to <c>true</c> during the maintenance window.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A newer minor version is available. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DMS has enabled automatic patching for the given engine version. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? AutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AutoMinorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetAutoMinorVersionUpgrade() => this.AutoMinorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version number of the replication instance.
        /// </para>
        ///  
        /// <para>
        /// When modifying a major engine version of an instance, also set <c>AllowMajorVersionUpgrade</c>
        /// to <c>true</c>.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property KerberosAuthenticationSettings. 
        /// <para>
        /// Specifies the settings required for kerberos authentication when modifying a replication
        /// instance.
        /// </para>
        /// </summary>
        public KerberosAuthenticationSettings KerberosAuthenticationSettings { get; set; }

        /// <summary>
        /// Checks to see if the KerberosAuthenticationSettings property is set.
        /// </summary>
        internal bool IsSetKerberosAuthenticationSettings() => this.KerberosAuthenticationSettings != null;

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        ///  Specifies whether the replication instance is a Multi-AZ deployment. You can't set
        /// the <c>AvailabilityZone</c> parameter if the Multi-AZ parameter is set to <c>true</c>.
        /// 
        /// </para>
        /// </summary>
        public bool? MultiAZ { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZ property is set.
        /// </summary>
        internal bool IsSetMultiAZ() => this.MultiAZ.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The type of IP address protocol used by a replication instance, such as IPv4 only
        /// or Dual-stack that supports both IPv4 and IPv6 addressing. IPv6 only is not yet supported.
        /// </para>
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range (in UTC) during which system maintenance can occur, which might
        /// result in an outage. Changing this parameter does not result in an outage, except
        /// in the following situation, and the change is asynchronously applied as soon as possible.
        /// If moving this window to the current time, there must be at least 30 minutes between
        /// the current time and end of the window to ensure pending changes are applied.
        /// </para>
        ///  
        /// <para>
        /// Default: Uses existing setting
        /// </para>
        ///  
        /// <para>
        /// Format: ddd:hh24:mi-ddd:hh24:mi
        /// </para>
        ///  
        /// <para>
        /// Valid Days: Mon | Tue | Wed | Thu | Fri | Sat | Sun
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be at least 30 minutes
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceArn property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceArn() => this.ReplicationInstanceArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceClass. 
        /// <para>
        /// The compute and memory capacity of the replication instance as defined for the specified
        /// replication instance class. For example to specify the instance class dms.c4.large,
        /// set this parameter to <c>"dms.c4.large"</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information on the settings and capacities for the available replication
        /// instance classes, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_ReplicationInstance.html#CHAP_ReplicationInstance.InDepth">
        /// Selecting the right DMS replication instance for your migration</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public string ReplicationInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceClass property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceClass() => this.ReplicationInstanceClass != null;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceIdentifier. 
        /// <para>
        /// The replication instance identifier. This parameter is stored as a lowercase string.
        /// </para>
        /// </summary>
        public string ReplicationInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceIdentifier() => this.ReplicationInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        ///  Specifies the VPC security group to be used with the replication instance. The VPC
        /// security group must work with the VPC containing the replication instance. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroupIds() => this.VpcSecurityGroupIds != null && (this.VpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
