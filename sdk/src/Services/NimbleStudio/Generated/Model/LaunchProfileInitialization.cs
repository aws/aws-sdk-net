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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// A launch profile initialization contains information required for a workstation or
    /// server to connect to a launch profile.
    /// 
    ///  
    /// <para>
    /// This includes scripts, endpoints, security groups, subnets, and other configuration.
    /// </para>
    /// </summary>
    public partial class LaunchProfileInitialization
    {
        private LaunchProfileInitializationActiveDirectory _activeDirectory;
        private List<string> _ec2SecurityGroupIds = new List<string>();
        private string _launchProfileId;
        private string _launchProfileProtocolVersion;
        private string _launchPurpose;
        private string _name;
        private LaunchProfilePlatform _platform;
        private List<LaunchProfileInitializationScript> _systemInitializationScripts = new List<LaunchProfileInitializationScript>();
        private List<LaunchProfileInitializationScript> _userInitializationScripts = new List<LaunchProfileInitializationScript>();

        /// <summary>
        /// Gets and sets the property ActiveDirectory. 
        /// <para>
        /// A <code>LaunchProfileInitializationActiveDirectory</code> resource.
        /// </para>
        /// </summary>
        public LaunchProfileInitializationActiveDirectory ActiveDirectory
        {
            get { return this._activeDirectory; }
            set { this._activeDirectory = value; }
        }

        // Check to see if ActiveDirectory property is set
        internal bool IsSetActiveDirectory()
        {
            return this._activeDirectory != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2SecurityGroupIds. 
        /// <para>
        /// The EC2 security groups that control access to the studio component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Ec2SecurityGroupIds
        {
            get { return this._ec2SecurityGroupIds; }
            set { this._ec2SecurityGroupIds = value; }
        }

        // Check to see if Ec2SecurityGroupIds property is set
        internal bool IsSetEc2SecurityGroupIds()
        {
            return this._ec2SecurityGroupIds != null && this._ec2SecurityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchProfileId. 
        /// <para>
        /// The ID of the launch profile used to control access from the streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=22)]
        public string LaunchProfileId
        {
            get { return this._launchProfileId; }
            set { this._launchProfileId = value; }
        }

        // Check to see if LaunchProfileId property is set
        internal bool IsSetLaunchProfileId()
        {
            return this._launchProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchProfileProtocolVersion. 
        /// <para>
        /// The version number of the protocol that is used by the launch profile. The only valid
        /// version is "2021-03-31".
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public string LaunchProfileProtocolVersion
        {
            get { return this._launchProfileProtocolVersion; }
            set { this._launchProfileProtocolVersion = value; }
        }

        // Check to see if LaunchProfileProtocolVersion property is set
        internal bool IsSetLaunchProfileProtocolVersion()
        {
            return this._launchProfileProtocolVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchPurpose. 
        /// <para>
        /// The launch purpose.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string LaunchPurpose
        {
            get { return this._launchPurpose; }
            set { this._launchPurpose = value; }
        }

        // Check to see if LaunchPurpose property is set
        internal bool IsSetLaunchPurpose()
        {
            return this._launchPurpose != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the launch profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the launch platform, either Windows or Linux.
        /// </para>
        /// </summary>
        public LaunchProfilePlatform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property SystemInitializationScripts. 
        /// <para>
        /// The system initializtion scripts.
        /// </para>
        /// </summary>
        public List<LaunchProfileInitializationScript> SystemInitializationScripts
        {
            get { return this._systemInitializationScripts; }
            set { this._systemInitializationScripts = value; }
        }

        // Check to see if SystemInitializationScripts property is set
        internal bool IsSetSystemInitializationScripts()
        {
            return this._systemInitializationScripts != null && this._systemInitializationScripts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserInitializationScripts. 
        /// <para>
        /// The user initializtion scripts.
        /// </para>
        /// </summary>
        public List<LaunchProfileInitializationScript> UserInitializationScripts
        {
            get { return this._userInitializationScripts; }
            set { this._userInitializationScripts = value; }
        }

        // Check to see if UserInitializationScripts property is set
        internal bool IsSetUserInitializationScripts()
        {
            return this._userInitializationScripts != null && this._userInitializationScripts.Count > 0; 
        }

    }
}