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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyReplicationInstance operation.
    /// Modifies the replication instance to apply new settings. You can change one or more
    /// parameters by specifying these parameters and the new values in the request.
    /// 
    ///  
    /// <para>
    /// Some settings are applied during the maintenance window.
    /// </para>
    /// </summary>
    public partial class ModifyReplicationInstanceRequest : AmazonDatabaseMigrationServiceRequest
    {
        private int? _allocatedStorage;
        private bool? _allowMajorVersionUpgrade;
        private bool? _applyImmediately;
        private bool? _autoMinorVersionUpgrade;
        private string _engineVersion;
        private bool? _multiAZ;
        private string _networkType;
        private string _preferredMaintenanceWindow;
        private string _replicationInstanceArn;
        private string _replicationInstanceClass;
        private string _replicationInstanceIdentifier;
        private List<string> _vpcSecurityGroupIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage (in gigabytes) to be allocated for the replication instance.
        /// </para>
        /// </summary>
        public int AllocatedStorage
        {
            get { return this._allocatedStorage.GetValueOrDefault(); }
            set { this._allocatedStorage = value; }
        }

        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this._allocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowMajorVersionUpgrade. 
        /// <para>
        /// Indicates that major version upgrades are allowed. Changing this parameter does not
        /// result in an outage, and the change is asynchronously applied as soon as possible.
        /// </para>
        ///  
        /// <para>
        /// This parameter must be set to <code>true</code> when specifying a value for the <code>EngineVersion</code>
        /// parameter that is a different major version than the replication instance's current
        /// version.
        /// </para>
        /// </summary>
        public bool AllowMajorVersionUpgrade
        {
            get { return this._allowMajorVersionUpgrade.GetValueOrDefault(); }
            set { this._allowMajorVersionUpgrade = value; }
        }

        // Check to see if AllowMajorVersionUpgrade property is set
        internal bool IsSetAllowMajorVersionUpgrade()
        {
            return this._allowMajorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Indicates whether the changes should be applied immediately or during the next maintenance
        /// window.
        /// </para>
        /// </summary>
        public bool ApplyImmediately
        {
            get { return this._applyImmediately.GetValueOrDefault(); }
            set { this._applyImmediately = value; }
        }

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this._applyImmediately.HasValue; 
        }

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
        /// This parameter is set to <code>true</code> during the maintenance window.
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
        /// <para>
        /// When <code>AutoMinorVersionUpgrade</code> is enabled, DMS uses the current default
        /// engine version when you modify a replication instance. For example, if you set <code>EngineVersion</code>
        /// to a lower version number than the current default version, DMS uses the default version.
        /// </para>
        ///  
        /// <para>
        /// If <code>AutoMinorVersionUpgrade</code> <i>isn’t</i> enabled when you modify a replication
        /// instance, DMS uses the engine version specified by the <code>EngineVersion</code>
        /// parameter.
        /// </para>
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade.GetValueOrDefault(); }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version number of the replication instance.
        /// </para>
        ///  
        /// <para>
        /// When modifying a major engine version of an instance, also set <code>AllowMajorVersionUpgrade</code>
        /// to <code>true</code>.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        ///  Specifies whether the replication instance is a Multi-AZ deployment. You can't set
        /// the <code>AvailabilityZone</code> parameter if the Multi-AZ parameter is set to <code>true</code>.
        /// 
        /// </para>
        /// </summary>
        public bool MultiAZ
        {
            get { return this._multiAZ.GetValueOrDefault(); }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The type of IP address protocol used by a replication instance, such as IPv4 only
        /// or Dual-stack that supports both IPv4 and IPv6 addressing. IPv6 only is not yet supported.
        /// </para>
        /// </summary>
        public string NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

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
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationInstanceArn
        {
            get { return this._replicationInstanceArn; }
            set { this._replicationInstanceArn = value; }
        }

        // Check to see if ReplicationInstanceArn property is set
        internal bool IsSetReplicationInstanceArn()
        {
            return this._replicationInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceClass. 
        /// <para>
        /// The compute and memory capacity of the replication instance as defined for the specified
        /// replication instance class. For example to specify the instance class dms.c4.large,
        /// set this parameter to <code>"dms.c4.large"</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information on the settings and capacities for the available replication
        /// instance classes, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_ReplicationInstance.html#CHAP_ReplicationInstance.InDepth">
        /// Selecting the right DMS replication instance for your migration</a>. 
        /// </para>
        /// </summary>
        public string ReplicationInstanceClass
        {
            get { return this._replicationInstanceClass; }
            set { this._replicationInstanceClass = value; }
        }

        // Check to see if ReplicationInstanceClass property is set
        internal bool IsSetReplicationInstanceClass()
        {
            return this._replicationInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceIdentifier. 
        /// <para>
        /// The replication instance identifier. This parameter is stored as a lowercase string.
        /// </para>
        /// </summary>
        public string ReplicationInstanceIdentifier
        {
            get { return this._replicationInstanceIdentifier; }
            set { this._replicationInstanceIdentifier = value; }
        }

        // Check to see if ReplicationInstanceIdentifier property is set
        internal bool IsSetReplicationInstanceIdentifier()
        {
            return this._replicationInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        ///  Specifies the VPC security group to be used with the replication instance. The VPC
        /// security group must work with the VPC containing the replication instance. 
        /// </para>
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && this._vpcSecurityGroupIds.Count > 0; 
        }

    }
}