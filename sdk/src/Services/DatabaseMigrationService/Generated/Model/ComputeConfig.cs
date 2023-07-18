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
    /// Configuration parameters for provisioning an DMS Serverless replication.
    /// </summary>
    public partial class ComputeConfig
    {
        private string _availabilityZone;
        private string _dnsNameServers;
        private string _kmsKeyId;
        private int? _maxCapacityUnits;
        private int? _minCapacityUnits;
        private bool? _multiAZ;
        private string _preferredMaintenanceWindow;
        private string _replicationSubnetGroupId;
        private List<string> _vpcSecurityGroupIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where the DMS Serverless replication using this configuration
        /// will run. The default value is a random, system-chosen Availability Zone in the configuration's
        /// Amazon Web Services Region, for example, <code>"us-west-2"</code>. You can't set this
        /// parameter if the <code>MultiAZ</code> parameter is set to <code>true</code>.
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
        /// A list of custom DNS name servers supported for the DMS Serverless replication to
        /// access your source or target database. This list overrides the default name servers
        /// supported by the DMS Serverless replication. You can specify a comma-separated list
        /// of internet addresses for up to four DNS name servers. For example: <code>"1.1.1.1,2.2.2.2,3.3.3.3,4.4.4.4"</code>
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// An Key Management Service (KMS) key Amazon Resource Name (ARN) that is used to encrypt
        /// the data during DMS Serverless replication.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <code>KmsKeyId</code> parameter, DMS uses your
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
        /// Gets and sets the property MaxCapacityUnits. 
        /// <para>
        /// Specifies the maximum value of the DMS capacity units (DCUs) for which a given DMS
        /// Serverless replication can be provisioned. A single DCU is 2GB of RAM, with 2 DCUs
        /// as the minimum value allowed. The list of valid DCU values includes 2, 4, 8, 16, 32,
        /// 64, 128, 192, 256, and 384. So, the maximum value that you can specify for DMS Serverless
        /// is 384. The <code>MaxCapacityUnits</code> parameter is the only DCU parameter you
        /// are required to specify.
        /// </para>
        /// </summary>
        public int MaxCapacityUnits
        {
            get { return this._maxCapacityUnits.GetValueOrDefault(); }
            set { this._maxCapacityUnits = value; }
        }

        // Check to see if MaxCapacityUnits property is set
        internal bool IsSetMaxCapacityUnits()
        {
            return this._maxCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinCapacityUnits. 
        /// <para>
        /// Specifies the minimum value of the DMS capacity units (DCUs) for which a given DMS
        /// Serverless replication can be provisioned. A single DCU is 2GB of RAM, with 2 DCUs
        /// as the minimum value allowed. The list of valid DCU values includes 2, 4, 8, 16, 32,
        /// 64, 128, 192, 256, and 384. So, the minimum DCU value that you can specify for DMS
        /// Serverless is 2. You don't have to specify a value for the <code>MinCapacityUnits</code>
        /// parameter. If you don't set this value, DMS scans the current activity of available
        /// source tables to identify an optimum setting for this parameter. If there is no current
        /// source activity or DMS can't otherwise identify a more appropriate value, it sets
        /// this parameter to the minimum DCU value allowed, 2.
        /// </para>
        /// </summary>
        public int MinCapacityUnits
        {
            get { return this._minCapacityUnits.GetValueOrDefault(); }
            set { this._minCapacityUnits = value; }
        }

        // Check to see if MinCapacityUnits property is set
        internal bool IsSetMinCapacityUnits()
        {
            return this._minCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Specifies whether the DMS Serverless replication is a Multi-AZ deployment. You can't
        /// set the <code>AvailabilityZone</code> parameter if the <code>MultiAZ</code> parameter
        /// is set to <code>true</code>.
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
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range during which system maintenance can occur for the DMS Serverless
        /// replication, in Universal Coordinated Time (UTC). The format is <code>ddd:hh24:mi-ddd:hh24:mi</code>.
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// per Amazon Web Services Region. This maintenance occurs on a random day of the week.
        /// Valid values for days of the week include <code>Mon</code>, <code>Tue</code>, <code>Wed</code>,
        /// <code>Thu</code>, <code>Fri</code>, <code>Sat</code>, and <code>Sun</code>.
        /// </para>
        ///  
        /// <para>
        /// Constraints include a minimum 30-minute window.
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
        /// Gets and sets the property ReplicationSubnetGroupId. 
        /// <para>
        /// Specifies a subnet group identifier to associate with the DMS Serverless replication.
        /// </para>
        /// </summary>
        public string ReplicationSubnetGroupId
        {
            get { return this._replicationSubnetGroupId; }
            set { this._replicationSubnetGroupId = value; }
        }

        // Check to see if ReplicationSubnetGroupId property is set
        internal bool IsSetReplicationSubnetGroupId()
        {
            return this._replicationSubnetGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// Specifies the virtual private cloud (VPC) security group to use with the DMS Serverless
        /// replication. The VPC security group must work with the VPC containing the replication.
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