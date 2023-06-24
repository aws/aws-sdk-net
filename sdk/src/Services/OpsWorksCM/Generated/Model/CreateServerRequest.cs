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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
    /// parameter, AWS OpsWorks creates a new security group. 
    /// </para>
    ///  
    /// <para>
    ///  <i>Chef Automate:</i> The default security group opens the Chef server to the world
    /// on TCP port 443. If a KeyName is present, AWS OpsWorks enables SSH access. SSH is
    /// also open to the world on TCP port 22. 
    /// </para>
    ///  
    /// <para>
    ///  <i>Puppet Enterprise:</i> The default security group opens TCP ports 22, 443, 4433,
    /// 8140, 8142, 8143, and 8170. If a KeyName is present, AWS OpsWorks enables SSH access.
    /// SSH is also open to the world on TCP port 22. 
    /// </para>
    ///  
    /// <para>
    /// By default, your server is accessible from any IP address. We recommend that you update
    /// your security group rules to allow access from known IP addresses and address ranges
    /// only. To edit security group rules, open Security Groups in the navigation pane of
    /// the EC2 management console. 
    /// </para>
    ///  
    /// <para>
    /// To specify your own domain for a server, and provide your own self-signed or CA-signed
    /// certificate and private key, specify values for <code>CustomDomain</code>, <code>CustomCertificate</code>,
    /// and <code>CustomPrivateKey</code>.
    /// </para>
    /// </summary>
    public partial class CreateServerRequest : AmazonOpsWorksCMRequest
    {
        private bool? _associatePublicIpAddress;
        private string _backupId;
        private int? _backupRetentionCount;
        private string _customCertificate;
        private string _customDomain;
        private string _customPrivateKey;
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
        private List<Tag> _tags = new List<Tag>();

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
        ///  If you specify this field, AWS OpsWorks CM creates the server by using the backup
        /// represented by BackupId. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=79)]
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
        /// AWS OpsWorks CM deletes the oldest backups if this number is exceeded. The default
        /// value is <code>1</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property CustomCertificate. 
        /// <para>
        /// A PEM-formatted HTTPS certificate. The value can be be a single, self-signed certificate,
        /// or a certificate chain. If you specify a custom certificate, you must also specify
        /// values for <code>CustomDomain</code> and <code>CustomPrivateKey</code>. The following
        /// are requirements for the <code>CustomCertificate</code> value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can provide either a self-signed, custom certificate, or the full certificate
        /// chain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The certificate must be a valid X509 certificate, or a certificate chain in PEM format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The certificate must be valid at the time of upload. A certificate can't be used before
        /// its validity period begins (the certificate's <code>NotBefore</code> date), or after
        /// it expires (the certificate's <code>NotAfter</code> date).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The certificate’s common name or subject alternative names (SANs), if present, must
        /// match the value of <code>CustomDomain</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The certificate must match the value of <code>CustomPrivateKey</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2097152)]
        public string CustomCertificate
        {
            get { return this._customCertificate; }
            set { this._customCertificate = value; }
        }

        // Check to see if CustomCertificate property is set
        internal bool IsSetCustomCertificate()
        {
            return this._customCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDomain. 
        /// <para>
        /// An optional public endpoint of a server, such as <code>https://aws.my-company.com</code>.
        /// To access the server, create a CNAME DNS record in your preferred DNS service that
        /// points the custom domain to the endpoint that is generated when the server is created
        /// (the value of the CreateServer Endpoint attribute). You cannot access the server by
        /// using the generated <code>Endpoint</code> value if the server is using a custom domain.
        /// If you specify a custom domain, you must also specify values for <code>CustomCertificate</code>
        /// and <code>CustomPrivateKey</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=253)]
        public string CustomDomain
        {
            get { return this._customDomain; }
            set { this._customDomain = value; }
        }

        // Check to see if CustomDomain property is set
        internal bool IsSetCustomDomain()
        {
            return this._customDomain != null;
        }

        /// <summary>
        /// Gets and sets the property CustomPrivateKey. 
        /// <para>
        /// A private key in PEM format for connecting to the server by using HTTPS. The private
        /// key must not be encrypted; it cannot be protected by a password or passphrase. If
        /// you specify a custom private key, you must also specify values for <code>CustomDomain</code>
        /// and <code>CustomCertificate</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=4096)]
        public string CustomPrivateKey
        {
            get { return this._customPrivateKey; }
            set { this._customPrivateKey = value; }
        }

        // Check to see if CustomPrivateKey property is set
        internal bool IsSetCustomPrivateKey()
        {
            return this._customPrivateKey != null;
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
        ///  The configuration management engine to use. Valid values include <code>ChefAutomate</code>
        /// and <code>Puppet</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10000)]
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
        ///  <p class="title"> <b>Attributes accepted in a Chef createServer request:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CHEF_AUTOMATE_PIVOTAL_KEY</code>: A base64-encoded RSA public key. The corresponding
        /// private key is required to access the Chef API. When no CHEF_AUTOMATE_PIVOTAL_KEY
        /// is set, a private key is generated and returned in the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CHEF_AUTOMATE_ADMIN_PASSWORD</code>: The password for the administrative user
        /// in the Chef Automate web-based dashboard. The password length is a minimum of eight
        /// characters, and a maximum of 32. The password can contain letters, numbers, and special
        /// characters (!/@#$%^&amp;+=_). The password must contain at least one lower case letter,
        /// one upper case letter, one number, and one special character. When no CHEF_AUTOMATE_ADMIN_PASSWORD
        /// is set, one is generated and returned in the response.
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Attributes accepted in a Puppet createServer request:</b>
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PUPPET_ADMIN_PASSWORD</code>: To work with the Puppet Enterprise console, a
        /// password must use ASCII characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PUPPET_R10K_REMOTE</code>: The r10k remote is the URL of your control repository
        /// (for example, ssh://git@your.git-repo.com:user/control-repo.git). Specifying an r10k
        /// remote opens TCP port 8170.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PUPPET_R10K_PRIVATE_KEY</code>: If you are using a private Git repository,
        /// add PUPPET_R10K_PRIVATE_KEY to specify a PEM-encoded private SSH key.
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
        ///  The engine model of the server. Valid values in this release include <code>Monolithic</code>
        /// for Puppet and <code>Single</code> for Chef. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
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
        ///  The major release version of the engine that you want to use. For a Chef server,
        /// the valid value for EngineVersion is currently <code>2</code>. For a Puppet server,
        /// valid values are <code>2019</code> or <code>2017</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
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
        /// located at https://s3.amazonaws.com/opsworks-cm-us-east-1-prod-default-assets/misc/opsworks-cm-roles.yaml.
        /// This template creates a CloudFormation stack that includes the instance profile you
        /// need. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10000)]
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
        ///  The Amazon EC2 instance type to use. For example, <code>m5.large</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10000)]
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
        [AWSProperty(Max=10000)]
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
        ///  The start time for a one-hour period during which AWS OpsWorks CM backs up application-level
        /// data on your server if automated backups are enabled. Valid values must be specified
        /// in one of the following formats: 
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
        ///  <code>MM</code> must be specified as <code>00</code>. The specified time is in coordinated
        /// universal time (UTC). The default value is a random, daily start time.
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
        [AWSProperty(Max=10000)]
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
        ///  The start time for a one-hour period each week during which AWS OpsWorks CM performs
        /// maintenance on the instance. Valid values must be specified in the following format:
        /// <code>DDD:HH:MM</code>. <code>MM</code> must be specified as <code>00</code>. The
        /// specified time is in coordinated universal time (UTC). The default value is a random
        /// one-hour period on Tuesday, Wednesday, or Friday. See <code>TimeWindowDefinition</code>
        /// for more information. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Example:</b> <code>Mon:08:00</code>, which represents a start time of every Monday
        /// at 08:00 UTC. (8:00 a.m.) 
        /// </para>
        /// </summary>
        [AWSProperty(Max=10000)]
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
        ///  If you do not specify this parameter, AWS OpsWorks CM creates one new security group
        /// that uses TCP ports 22 and 443, open to 0.0.0.0/0 (everyone). 
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
        [AWSProperty(Required=true, Min=1, Max=40)]
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
        ///  The service role that the AWS OpsWorks CM service backend uses to work with your
        /// account. Although the AWS OpsWorks management console typically creates the service
        /// role for you, if you are using the AWS CLI or API commands, run the service-role-creation.yaml
        /// AWS CloudFormation template, located at https://s3.amazonaws.com/opsworks-cm-us-east-1-prod-default-assets/misc/opsworks-cm-roles.yaml.
        /// This template creates a CloudFormation stack that includes the service role and instance
        /// profile that you need. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10000)]
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
        /// For more information about supported Amazon EC2 platforms, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-supported-platforms.html">Supported
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map that contains tag keys and tag values to attach to an AWS OpsWorks for Chef
        /// Automate or AWS OpsWorks for Puppet Enterprise server.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key cannot be empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The key can be a maximum of 127 characters, and can contain only Unicode letters,
        /// numbers, or separators, or the following special characters: <code>+ - = . _ : / @</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value can be a maximum 255 characters, and contain only Unicode letters, numbers,
        /// or separators, or the following special characters: <code>+ - = . _ : / @</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Leading and trailing white spaces are trimmed from both the key and value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A maximum of 50 user-applied tags is allowed for any AWS OpsWorks-CM server.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}