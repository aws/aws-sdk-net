/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServer operation.
    /// Creates and immedately starts a new server. The server is ready to use when it is
    /// in the <code>HEALTHY</code> state. By default, you can create a maximum of 10 servers.
    /// 
    /// 
    ///  
    /// <para>
    ///  This operation is asynchronous. 
    /// </para>
    ///  
    /// <para>
    ///  A <code>LimitExceededException</code> is thrown when you have created the maximum
    /// number of servers (10). A <code>ResourceAlreadyExistsException</code> is thrown when
    /// a server with the same name already exists in the account. A <code>ResourceNotFoundException</code>
    /// is thrown when you specify a backup ID that is not valid or is for a backup that does
    /// not exist. A <code>ValidationException</code> is thrown when parameters of the request
    /// are not valid. 
    /// </para>
    ///  
    /// <para>
    ///  If you do not specify a security group by adding the <code>SecurityGroupIds</code>
    /// parameter, AWS OpsWorks creates a new security group. The default security group opens
    /// the Chef server to the world on TCP port 443. If a KeyName is present, AWS OpsWorks
    /// enables SSH access. SSH is also open to the world on TCP port 22. 
    /// </para>
    ///  
    /// <para>
    /// By default, the Chef Server is accessible from any IP address. We recommend that you
    /// update your security group rules to allow access from known IP addresses and address
    /// ranges only. To edit security group rules, open Security Groups in the navigation
    /// pane of the EC2 management console. 
    /// </para>
    /// </summary>
    public partial class CreateServerRequest : AmazonOpsWorksCMRequest
    {
        private bool? _associatePublicIpAddress;
        private string _backupId;
        private int? _backupRetentionCount;
        private bool? _disableAutomatedBackup;
        private string _engine;
        private List<EngineAttribute> _engineAttributes = new List<EngineAttribute>();
        private string _engineModel;
        private string _engineVersion;
        private string _instanceProfileArn;
        private string _instanceType;
        private string _keyPair;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private List<string> _securityGroupIds = new List<string>();
        private string _serverName;
        private string _serviceRoleArn;
        private List<string> _subnetIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        ///  Associate a public IP address with a server that you are launching. Valid values
        /// are <code>true</code> or <code>false</code>. The default value is <code>true</code>.
        /// 
        /// </para>
        /// </summary>
        public bool AssociatePublicIpAddress
        {
            get { return this._associatePublicIpAddress.GetValueOrDefault(); }
            set { this._associatePublicIpAddress = value; }
        }

        // Check to see if AssociatePublicIpAddress property is set
        internal bool IsSetAssociatePublicIpAddress()
        {
            return this._associatePublicIpAddress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        ///  If you specify this field, AWS OpsWorks for Chef Automate creates the server by using
        /// the backup represented by BackupId. 
        /// </para>
        /// </summary>
        public string BackupId
        {
            get { return this._backupId; }
            set { this._backupId = value; }
        }

        // Check to see if BackupId property is set
        internal bool IsSetBackupId()
        {
            return this._backupId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionCount. 
        /// <para>
        ///  The number of automated backups that you want to keep. Whenever a new backup is created,
        /// AWS OpsWorks for Chef Automate deletes the oldest backups if this number is exceeded.
        /// The default value is <code>1</code>. 
        /// </para>
        /// </summary>
        public int BackupRetentionCount
        {
            get { return this._backupRetentionCount.GetValueOrDefault(); }
            set { this._backupRetentionCount = value; }
        }

        // Check to see if BackupRetentionCount property is set
        internal bool IsSetBackupRetentionCount()
        {
            return this._backupRetentionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisableAutomatedBackup. 
        /// <para>
        ///  Enable or disable scheduled backups. Valid values are <code>true</code> or <code>false</code>.
        /// The default value is <code>true</code>. 
        /// </para>
        /// </summary>
        public bool DisableAutomatedBackup
        {
            get { return this._disableAutomatedBackup.GetValueOrDefault(); }
            set { this._disableAutomatedBackup = value; }
        }

        // Check to see if DisableAutomatedBackup property is set
        internal bool IsSetDisableAutomatedBackup()
        {
            return this._disableAutomatedBackup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        ///  The configuration management engine to use. Valid values include <code>Chef</code>.
        /// 
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineAttributes. 
        /// <para>
        /// Optional engine attributes on a specified server. 
        /// </para>
        ///  <p class="title"> <b>Attributes accepted in a createServer request:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CHEF_PIVOTAL_KEY</code>: A base64-encoded RSA private key that is not stored
        /// by AWS OpsWorks for Chef. This private key is required to access the Chef API. When
        /// no CHEF_PIVOTAL_KEY is set, one is generated and returned in the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CHEF_DELIVERY_ADMIN_PASSWORD</code>: The password for the administrative user
        /// in the Chef Automate GUI. The password length is a minimum of eight characters, and
        /// a maximum of 32. The password can contain letters, numbers, and special characters
        /// (!/@#$%^&amp;+=_). The password must contain at least one lower case letter, one upper
        /// case letter, one number, and one special character. When no CHEF_DELIVERY_ADMIN_PASSWORD
        /// is set, one is generated and returned in the response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<EngineAttribute> EngineAttributes
        {
            get { return this._engineAttributes; }
            set { this._engineAttributes = value; }
        }

        // Check to see if EngineAttributes property is set
        internal bool IsSetEngineAttributes()
        {
            return this._engineAttributes != null && this._engineAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EngineModel. 
        /// <para>
        ///  The engine model, or option. Valid values include <code>Single</code>. 
        /// </para>
        /// </summary>
        public string EngineModel
        {
            get { return this._engineModel; }
            set { this._engineModel = value; }
        }

        // Check to see if EngineModel property is set
        internal bool IsSetEngineModel()
        {
            return this._engineModel != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        ///  The major release version of the engine that you want to use. Values depend on the
        /// engine that you choose. 
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
        /// Gets and sets the property InstanceProfileArn. 
        /// <para>
        ///  The ARN of the instance profile that your Amazon EC2 instances use. Although the
        /// AWS OpsWorks console typically creates the instance profile for you, if you are using
        /// API commands instead, run the service-role-creation.yaml AWS CloudFormation template,
        /// located at https://s3.amazonaws.com/opsworks-stuff/latest/service-role-creation.yaml.
        /// This template creates a CloudFormation stack that includes the instance profile you
        /// need. 
        /// </para>
        /// </summary>
        public string InstanceProfileArn
        {
            get { return this._instanceProfileArn; }
            set { this._instanceProfileArn = value; }
        }

        // Check to see if InstanceProfileArn property is set
        internal bool IsSetInstanceProfileArn()
        {
            return this._instanceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        ///  The Amazon EC2 instance type to use. Valid values must be specified in the following
        /// format: <code>^([cm][34]|t2).*</code> For example, <code>m4.large</code>. Valid values
        /// are <code>t2.medium</code>, <code>m4.large</code>, or <code>m4.2xlarge</code>. 
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPair. 
        /// <para>
        ///  The Amazon EC2 key pair to set for the instance. This parameter is optional; if desired,
        /// you may specify this parameter to connect to your instances by using SSH. 
        /// </para>
        /// </summary>
        public string KeyPair
        {
            get { return this._keyPair; }
            set { this._keyPair = value; }
        }

        // Check to see if KeyPair property is set
        internal bool IsSetKeyPair()
        {
            return this._keyPair != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        ///  The start time for a one-hour period during which AWS OpsWorks for Chef Automate
        /// backs up application-level data on your server if automated backups are enabled. Valid
        /// values must be specified in one of the following formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>HH:MM</code> for daily backups
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DDD:HH:MM</code> for weekly backups
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The specified time is in coordinated universal time (UTC). The default value is a
        /// random, daily start time.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example:</b> <code>08:00</code>, which represents a daily start time of 08:00
        /// UTC.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example:</b> <code>Mon:08:00</code>, which represents a start time of every Monday
        /// at 08:00 UTC. (8:00 a.m.)
        /// </para>
        /// </summary>
        public string PreferredBackupWindow
        {
            get { return this._preferredBackupWindow; }
            set { this._preferredBackupWindow = value; }
        }

        // Check to see if PreferredBackupWindow property is set
        internal bool IsSetPreferredBackupWindow()
        {
            return this._preferredBackupWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        ///  The start time for a one-hour period each week during which AWS OpsWorks for Chef
        /// Automate performs maintenance on the instance. Valid values must be specified in the
        /// following format: <code>DDD:HH:MM</code>. The specified time is in coordinated universal
        /// time (UTC). The default value is a random one-hour period on Tuesday, Wednesday, or
        /// Friday. See <code>TimeWindowDefinition</code> for more information. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Example:</b> <code>Mon:08:00</code>, which represents a start time of every Monday
        /// at 08:00 UTC. (8:00 a.m.) 
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        ///  A list of security group IDs to attach to the Amazon EC2 instance. If you add this
        /// parameter, the specified security groups must be within the VPC that is specified
        /// by <code>SubnetIds</code>. 
        /// </para>
        ///  
        /// <para>
        ///  If you do not specify this parameter, AWS OpsWorks for Chef Automate creates one
        /// new security group that uses TCP ports 22 and 443, open to 0.0.0.0/0 (everyone). 
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        ///  The name of the server. The server name must be unique within your AWS account, within
        /// each region. Server names must start with a letter; then letters, numbers, or hyphens
        /// (-) are allowed, up to a maximum of 40 characters. 
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        ///  The service role that the AWS OpsWorks for Chef Automate service backend uses to
        /// work with your account. Although the AWS OpsWorks management console typically creates
        /// the service role for you, if you are using the AWS CLI or API commands, run the service-role-creation.yaml
        /// AWS CloudFormation template, located at https://s3.amazonaws.com/opsworks-stuff/latest/service-role-creation.yaml.
        /// This template creates a CloudFormation stack that includes the service role that you
        /// need. 
        /// </para>
        /// </summary>
        public string ServiceRoleArn
        {
            get { return this._serviceRoleArn; }
            set { this._serviceRoleArn = value; }
        }

        // Check to see if ServiceRoleArn property is set
        internal bool IsSetServiceRoleArn()
        {
            return this._serviceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        ///  The IDs of subnets in which to launch the server EC2 instance. 
        /// </para>
        ///  
        /// <para>
        ///  Amazon EC2-Classic customers: This field is required. All servers must run within
        /// a VPC. The VPC must have "Auto Assign Public IP" enabled. 
        /// </para>
        ///  
        /// <para>
        ///  EC2-VPC customers: This field is optional. If you do not specify subnet IDs, your
        /// EC2 instances are created in a default subnet that is selected by Amazon EC2. If you
        /// specify subnet IDs, the VPC must have "Auto Assign Public IP" enabled. 
        /// </para>
        ///  
        /// <para>
        /// For more information about supported Amazon EC2 platforms, see <a href="http://docs.aws.amazon.com/https:/docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-supported-platforms.html">Supported
        /// Platforms</a>.
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

    }
}