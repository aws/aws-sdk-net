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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReplicationInstance operation.
    /// Creates the replication instance using the specified parameters.
    /// 
    ///  
    /// <para>
    /// DMS requires that your account have certain roles with appropriate permissions before
    /// you can create a replication instance. For information on the required roles, see
    /// <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#CHAP_Security.APIRole">Creating
    /// the IAM Roles to Use With the CLI and DMS API</a>. For information on the required
    /// permissions, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#CHAP_Security.IAMPermissions">IAM
    /// Permissions Needed to Use DMS</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you don't specify a version when creating a replication instance, DMS will create
    /// the instance using the default engine version. For information about the default engine
    /// version, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_ReleaseNotes.html">Release
    /// Notes</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateReplicationInstanceRequest : AmazonDatabaseMigrationServiceRequest
    {
        private int? _allocatedStorage;
        private bool? _autoMinorVersionUpgrade;
        private string _availabilityZone;
        private string _dnsNameServers;
        private string _engineVersion;
        private KerberosAuthenticationSettings _kerberosAuthenticationSettings;
        private string _kmsKeyId;
        private bool? _multiAZ;
        private string _networkType;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private string _replicationInstanceClass;
        private string _replicationInstanceIdentifier;
        private string _replicationSubnetGroupIdentifier;
        private string _resourceIdentifier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage (in gigabytes) to be initially allocated for the replication
        /// instance.
        /// </para>
        /// </summary>
        public int? AllocatedStorage
        {
            get { return this._allocatedStorage; }
            set { this._allocatedStorage = value; }
        }

        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this._allocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// A value that indicates whether minor engine upgrades are applied automatically to
        /// the replication instance during the maintenance window. This parameter defaults to
        /// <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>true</c> 
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade; }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where the replication instance will be created. The default
        /// value is a random, system-chosen Availability Zone in the endpoint's Amazon Web Services
        /// Region, for example: <c>us-east-1d</c>.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property DnsNameServers. 
        /// <para>
        /// A list of custom DNS name servers supported for the replication instance to access
        /// your on-premise source or target database. This list overrides the default name servers
        /// supported by the replication instance. You can specify a comma-separated list of internet
        /// addresses for up to four on-premise DNS name servers. For example: <c>"1.1.1.1,2.2.2.2,3.3.3.3,4.4.4.4"</c>
        /// 
        /// </para>
        /// </summary>
        public string DnsNameServers
        {
            get { return this._dnsNameServers; }
            set { this._dnsNameServers = value; }
        }

        // Check to see if DnsNameServers property is set
        internal bool IsSetDnsNameServers()
        {
            return this._dnsNameServers != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version number of the replication instance.
        /// </para>
        ///  
        /// <para>
        /// If an engine version number is not specified when a replication instance is created,
        /// the default is the latest engine version available.
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
        /// Gets and sets the property KerberosAuthenticationSettings. 
        /// <para>
        /// Specifies the settings required for kerberos authentication when creating the replication
        /// instance.
        /// </para>
        /// </summary>
        public KerberosAuthenticationSettings KerberosAuthenticationSettings
        {
            get { return this._kerberosAuthenticationSettings; }
            set { this._kerberosAuthenticationSettings = value; }
        }

        // Check to see if KerberosAuthenticationSettings property is set
        internal bool IsSetKerberosAuthenticationSettings()
        {
            return this._kerberosAuthenticationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// An KMS key identifier that is used to encrypt the data on the replication instance.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <c>KmsKeyId</c> parameter, then DMS uses your
        /// default encryption key.
        /// </para>
        ///  
        /// <para>
        /// KMS creates the default encryption key for your Amazon Web Services account. Your
        /// Amazon Web Services account has a different default encryption key for each Amazon
        /// Web Services Region.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        ///  Specifies whether the replication instance is a Multi-AZ deployment. You can't set
        /// the <c>AvailabilityZone</c> parameter if the Multi-AZ parameter is set to <c>true</c>.
        /// 
        /// </para>
        /// </summary>
        public bool? MultiAZ
        {
            get { return this._multiAZ; }
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
        /// The weekly time range during which system maintenance can occur, in Universal Coordinated
        /// Time (UTC).
        /// </para>
        ///  
        /// <para>
        ///  Format: <c>ddd:hh24:mi-ddd:hh24:mi</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: A 30-minute window selected at random from an 8-hour block of time per Amazon
        /// Web Services Region, occurring on a random day of the week.
        /// </para>
        ///  
        /// <para>
        /// Valid Days: Mon, Tue, Wed, Thu, Fri, Sat, Sun
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum 30-minute window.
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
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        ///  Specifies the accessibility options for the replication instance. A value of <c>true</c>
        /// represents an instance with a public IP address. A value of <c>false</c> represents
        /// an instance with a private IP address. The default value is <c>true</c>. 
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible
        {
            get { return this._publiclyAccessible; }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

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
        /// instance classes, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_ReplicationInstance.Types.html
        /// "> Choosing the right DMS replication instance</a>; and, <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_BestPractices.SizingReplicationInstance.html">Selecting
        /// the best size for a replication instance</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=30)]
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
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain 1-63 alphanumeric characters or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>myrepinstance</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ReplicationSubnetGroupIdentifier. 
        /// <para>
        /// A subnet group to associate with the replication instance.
        /// </para>
        /// </summary>
        public string ReplicationSubnetGroupIdentifier
        {
            get { return this._replicationSubnetGroupIdentifier; }
            set { this._replicationSubnetGroupIdentifier = value; }
        }

        // Check to see if ReplicationSubnetGroupIdentifier property is set
        internal bool IsSetReplicationSubnetGroupIdentifier()
        {
            return this._replicationSubnetGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// A friendly name for the resource identifier at the end of the <c>EndpointArn</c> response
        /// parameter that is returned in the created <c>Endpoint</c> object. The value for this
        /// parameter can have up to 31 characters. It can contain only ASCII letters, digits,
        /// and hyphen ('-'). Also, it can't end with a hyphen or contain two consecutive hyphens,
        /// and can only begin with a letter, such as <c>Example-App-ARN1</c>. For example, this
        /// value might result in the <c>EndpointArn</c> value <c>arn:aws:dms:eu-west-1:012345678901:rep:Example-App-ARN1</c>.
        /// If you don't specify a <c>ResourceIdentifier</c> value, DMS generates a default identifier
        /// value for the end of <c>EndpointArn</c>.
        /// </para>
        /// </summary>
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to be assigned to the replication instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        ///  Specifies the VPC security group to be used with the replication instance. The VPC
        /// security group must work with the VPC containing the replication instance. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && (this._vpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}