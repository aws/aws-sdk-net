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
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached       policy that explicitly grants permissions.
    /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class UpdateInstanceRequest : AmazonOpsWorksRequest
    {
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
        /// Gets and sets the property AmiId. 
        /// <para>
        /// A custom AMI ID to be used to create the instance. The AMI should be based on one
        /// of the standard AWS OpsWorks APIs:         Amazon Linux or Ubuntu 12.04 LTS. For more
        /// information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances.html">Instances</a>
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
        ///         For a list of the architectures that are supported by the different instance
        /// types, see  <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
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
        /// The instance's auto scaling type, which has three possible values:
        /// </para>
        ///   <ul>  <li><b>AlwaysRunning</b>: A 24/7 instance, which is not affected by auto scaling.</li>
        ///  <li><b>TimeBasedAutoScaling</b>: A time-based auto scaling instance, which is started
        /// and stopped based on a specified schedule.</li>  <li><b>LoadBasedAutoScaling</b>:
        /// A load-based auto scaling instance, which is started and stopped based on load metrics.</li>
        ///  </ul>
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
        /// Whether this is an Amazon EBS-optimized instance.
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
        /// default value is <code>true</code>.         To control when updates are installed,
        /// set this value to <code>false</code>. You must then update your instances manually
        /// by         using <a>CreateDeployment</a> to run the <code>update_dependencies</code>
        /// stack command or         manually running <code>yum</code> (Amazon Linux) or <code>apt-get</code>
        /// (Ubuntu) on the instances.  
        /// </para>
        ///   <note>      
        /// <para>
        /// We strongly recommend using the default value of <code>true</code>, to ensure that
        /// your        instances have the latest security updates.
        /// </para>
        ///     </note>
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
        /// The instance type. AWS OpsWorks supports all instance types except Cluster Compute,
        /// Cluster GPU, and High Memory Cluster.         For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Families and Types</a>.         The parameter values that you use to specify the various
        /// types are in the API Name column of the Available Instance Types table.
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
        /// The instance operating system, which must be set to one of the following.
        /// </para>
        ///   <ul>  <li>Standard operating systems: <code>Amazon Linux</code> or <code>Ubuntu
        /// 12.04 LTS</code></li>  <li>Custom AMIs: <code>Custom</code></li>  </ul>  
        /// <para>
        /// The default option is <code>Amazon Linux</code>. If you set this parameter to <code>Custom</code>,
        /// you must use the  <a>CreateInstance</a> action's AmiId parameter to specify      
        ///   the custom AMI that you want to use. For more information on the standard operating
        /// systems, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-os.html">Operating
        /// Systems</a>For more information         on how to use custom AMIs with OpsWorks, see
        ///  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-custom-ami.html">Using
        /// Custom AMIs</a>.
        /// </para>
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
        /// The instance SSH key name.
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