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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// In addition to your infrastructure configuration, these settings provide an extra
    /// layer of control over your build instances. You can also specify commands to run on
    /// launch for all of your build instances.
    /// 
    ///  
    /// <para>
    /// Image Builder does not automatically install the Systems Manager agent on Windows
    /// instances. If your base image includes the Systems Manager agent, then the AMI that
    /// you create will also include the agent. For Linux instances, if the base image does
    /// not already include the Systems Manager agent, Image Builder installs it. For Linux
    /// instances where Image Builder installs the Systems Manager agent, you can choose whether
    /// to keep it for the AMI that you create.
    /// </para>
    /// </summary>
    public partial class AdditionalInstanceConfiguration
    {
        private SystemsManagerAgent _systemsManagerAgent;
        private string _userDataOverride;

        /// <summary>
        /// Gets and sets the property SystemsManagerAgent. 
        /// <para>
        /// Contains settings for the Systems Manager agent on your build instance.
        /// </para>
        /// </summary>
        public SystemsManagerAgent SystemsManagerAgent
        {
            get { return this._systemsManagerAgent; }
            set { this._systemsManagerAgent = value; }
        }

        // Check to see if SystemsManagerAgent property is set
        internal bool IsSetSystemsManagerAgent()
        {
            return this._systemsManagerAgent != null;
        }

        /// <summary>
        /// Gets and sets the property UserDataOverride. 
        /// <para>
        /// Use this property to provide commands or a command script to run when you launch your
        /// build instance.
        /// </para>
        ///  
        /// <para>
        /// The userDataOverride property replaces any commands that Image Builder might have
        /// added to ensure that Systems Manager is installed on your Linux build instance. If
        /// you override the user data, make sure that you add commands to install Systems Manager,
        /// if it is not pre-installed on your base image.
        /// </para>
        ///  <note> 
        /// <para>
        /// The user data is always base 64 encoded. For example, the following commands are encoded
        /// as <code>IyEvYmluL2Jhc2gKbWtkaXIgLXAgL3Zhci9iYi8KdG91Y2ggL3Zhci$</code>:
        /// </para>
        ///  
        /// <para>
        ///  <i>#!/bin/bash</i> 
        /// </para>
        ///  
        /// <para>
        /// mkdir -p /var/bb/
        /// </para>
        ///  
        /// <para>
        /// touch /var
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=21847)]
        public string UserDataOverride
        {
            get { return this._userDataOverride; }
            set { this._userDataOverride = value; }
        }

        // Check to see if UserDataOverride property is set
        internal bool IsSetUserDataOverride()
        {
            return this._userDataOverride != null;
        }

    }
}