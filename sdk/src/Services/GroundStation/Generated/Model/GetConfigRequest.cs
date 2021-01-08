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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the GetConfig operation.
    /// Returns <code>Config</code> information.
    /// 
    ///  
    /// <para>
    /// Only one <code>Config</code> response can be returned.
    /// </para>
    /// </summary>
    public partial class GetConfigRequest : AmazonGroundStationRequest
    {
        private string _configId;
        private ConfigCapabilityType _configType;

        /// <summary>
        /// Gets and sets the property ConfigId. 
        /// <para>
        /// UUID of a <code>Config</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigId
        {
            get { return this._configId; }
            set { this._configId = value; }
        }

        // Check to see if ConfigId property is set
        internal bool IsSetConfigId()
        {
            return this._configId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigType. 
        /// <para>
        /// Type of a <code>Config</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigCapabilityType ConfigType
        {
            get { return this._configType; }
            set { this._configType = value; }
        }

        // Check to see if ConfigType property is set
        internal bool IsSetConfigType()
        {
            return this._configType != null;
        }

    }
}