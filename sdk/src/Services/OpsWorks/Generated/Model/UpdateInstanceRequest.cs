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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateInstance operation.
    /// Updates a specified instance.
    /// 
    ///  
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached policy that explicitly grants permissions. For
    /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class UpdateInstanceRequest : AmazonOpsWorksRequest
    {
        private string _agentVersion;
        private string _amiId;
        private Architecture _architecture;
        private AutoScalingType _autoScalingType;
        private bool? _ebsOptimized;
        private string _hostname;
        private bool? _installUpdatesOnBoot;
        private string _instanceId;
        private string _instanceType;
        private List<string> _layerIds = new List<string>();
        private string _os;
        private string _sshKeyName;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The default AWS OpsWorks Stacks agent version. You have the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>INHERIT</code> - Use the stack's default agent version setting.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>version_number</i> - Use the specified agent version. This value overrides the
        /// stack's default setting. To update the agent version, you must edit the instance configuration
        /// and specify a new version. AWS OpsWorks Stacks then automatically installs that version
        /// on the instance.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default setting is <code>INHERIT</code>. To specify an agent version, you must
        /// use the complete version number, not the abbreviated number shown on the console.
        /// For a list of available agent version numbers, call <a>DescribeAgentVersions</a>.
        /// </para>
        ///  
        /// <para>
        /// AgentVersion cannot be set to Chef 12.2.
        /// </para>
        /// </summary>
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }

        // Check to see if AgentVersion property is set
        internal bool IsSetAgentVersion()
        {
            return this._agentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// The ID of the AMI that was used to create the instance. The value of this parameter
        /// must be the same AMI ID that the instance is already using. You cannot apply a new
        /// AMI to an instance by running UpdateInstance. UpdateInstance does not work on instances
        /// that are using custom AMIs. 
        /// </para>
        /// </summary>
        public string AmiId
        {
            get { return this._amiId; }
            set { this._amiId = value; }
        }

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this._amiId != null;
        }

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The instance architecture. Instance types do not necessarily support both architectures.
        /// For a list of the architectures that are supported by the different instance types,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Families and Types</a>.
        /// </para>
        /// </summary>
        public Architecture Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingType. 
        /// <para>
        /// For load-based or time-based instances, the type. Windows stacks can use only time-based
        /// instances.
        /// </para>
        /// </summary>
        public AutoScalingType AutoScalingType
        {
            get { return this._autoScalingType; }
            set { this._autoScalingType = value; }
        }

        // Check to see if AutoScalingType property is set
        internal bool IsSetAutoScalingType()
        {
            return this._autoScalingType != null;
        }

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// This property cannot be updated.
        /// </para>
        /// </summary>
        public bool EbsOptimized
        {
            get { return this._ebsOptimized.GetValueOrDefault(); }
            set { this._ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this._ebsOptimized.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The instance host name.
        /// </para>
        /// </summary>
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }

        /// <summary>
        /// Gets and sets the property InstallUpdatesOnBoot. 
        /// <para>
        /// Whether to install operating system and package updates when the instance boots. The
        /// default value is <code>true</code>. To control when updates are installed, set this
        /// value to <code>false</code>. You must then update your instances manually by using
        /// <a>CreateDeployment</a> to run the <code>update_dependencies</code> stack command
        /// or by manually running <code>yum</code> (Amazon Linux) or <code>apt-get</code> (Ubuntu)
        /// on the instances. 
        /// </para>
        ///  <note> 
        /// <para>
        /// We strongly recommend using the default value of <code>true</code>, to ensure that
        /// your instances have the latest security updates.
        /// </para>
        ///  </note>
        /// </summary>
        public bool InstallUpdatesOnBoot
        {
            get { return this._installUpdatesOnBoot.GetValueOrDefault(); }
            set { this._installUpdatesOnBoot = value; }
        }

        // Check to see if InstallUpdatesOnBoot property is set
        internal bool IsSetInstallUpdatesOnBoot()
        {
            return this._installUpdatesOnBoot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type, such as <code>t2.micro</code>. For a list of supported instance
        /// types, open the stack in the console, choose <b>Instances</b>, and choose <b>+ Instance</b>.
        /// The <b>Size</b> list contains the currently supported types. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Families and Types</a>. The parameter values that you use to specify the various types
        /// are in the <b>API Name</b> column of the <b>Available Instance Types</b> table.
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
        /// Gets and sets the property LayerIds. 
        /// <para>
        /// The instance's layer IDs.
        /// </para>
        /// </summary>
        public List<string> LayerIds
        {
            get { return this._layerIds; }
            set { this._layerIds = value; }
        }

        // Check to see if LayerIds property is set
        internal bool IsSetLayerIds()
        {
            return this._layerIds != null && this._layerIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Os. 
        /// <para>
        /// The instance's operating system, which must be set to one of the following. You cannot
        /// update an instance that is using a custom AMI.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A supported Linux operating system: An Amazon Linux version, such as <code>Amazon
        /// Linux 2017.09</code>, <code>Amazon Linux 2017.03</code>, <code>Amazon Linux 2016.09</code>,
        /// <code>Amazon Linux 2016.03</code>, <code>Amazon Linux 2015.09</code>, or <code>Amazon
        /// Linux 2015.03</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A supported Ubuntu operating system, such as <code>Ubuntu 16.04 LTS</code>, <code>Ubuntu
        /// 14.04 LTS</code>, or <code>Ubuntu 12.04 LTS</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CentOS Linux 7</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Red Hat Enterprise Linux 7</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A supported Windows operating system, such as <code>Microsoft Windows Server 2012
        /// R2 Base</code>, <code>Microsoft Windows Server 2012 R2 with SQL Server Express</code>,
        /// <code>Microsoft Windows Server 2012 R2 with SQL Server Standard</code>, or <code>Microsoft
        /// Windows Server 2012 R2 with SQL Server Web</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on the supported operating systems, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-os.html">AWS
        /// OpsWorks Stacks Operating Systems</a>.
        /// </para>
        ///  
        /// <para>
        /// The default option is the current Amazon Linux version. If you set this parameter
        /// to <code>Custom</code>, you must use the AmiId parameter to specify the custom AMI
        /// that you want to use. For more information on the supported operating systems, see
        /// <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-os.html">Operating
        /// Systems</a>. For more information on how to use custom AMIs with OpsWorks, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-custom-ami.html">Using
        /// Custom AMIs</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify a different Linux operating system for the updated stack, but you
        /// cannot change from Linux to Windows or Windows to Linux.
        /// </para>
        ///  </note>
        /// </summary>
        public string Os
        {
            get { return this._os; }
            set { this._os = value; }
        }

        // Check to see if Os property is set
        internal bool IsSetOs()
        {
            return this._os != null;
        }

        /// <summary>
        /// Gets and sets the property SshKeyName. 
        /// <para>
        /// The instance's Amazon EC2 key name.
        /// </para>
        /// </summary>
        public string SshKeyName
        {
            get { return this._sshKeyName; }
            set { this._sshKeyName = value; }
        }

        // Check to see if SshKeyName property is set
        internal bool IsSetSshKeyName()
        {
            return this._sshKeyName != null;
        }

    }
}