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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// Configuration settings that identify the operating system for an application resource.
    /// This can also include a compatibility layer and other drivers.
    /// 
    ///  
    /// <para>
    /// A runtime environment can be one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  For Linux applications 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  Ubuntu 22.04 LTS (<c>Type=UBUNTU, Version=22_04_LTS</c>) 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  For Windows applications 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Microsoft Windows Server 2022 Base (<c>Type=WINDOWS, Version=2022</c>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Proton 9.0-2 (<c>Type=PROTON, Version=20250516</c>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Proton 8.0-5 (<c>Type=PROTON, Version=20241007</c>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Proton 8.0-2c (<c>Type=PROTON, Version=20230704</c>)
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class RuntimeEnvironment
    {
        private RuntimeEnvironmentType _type;
        private string _version;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The operating system and other drivers. For Proton, this also includes the Proton
        /// compatibility layer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuntimeEnvironmentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Versioned container environment for the application operating system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}