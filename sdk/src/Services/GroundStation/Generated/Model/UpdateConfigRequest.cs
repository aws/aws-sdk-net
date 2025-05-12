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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConfig operation.
    /// Updates the <c>Config</c> used when scheduling contacts.
    /// 
    ///  
    /// <para>
    /// Updating a <c>Config</c> will not update the execution parameters for existing future
    /// contacts scheduled with this <c>Config</c>.
    /// </para>
    /// </summary>
    public partial class UpdateConfigRequest : AmazonGroundStationRequest
    {
        private ConfigTypeData _configData;
        private string _configId;
        private ConfigCapabilityType _configType;
        private string _name;

        /// <summary>
        /// Gets and sets the property ConfigData. 
        /// <para>
        /// Parameters of a <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigTypeData ConfigData
        {
            get { return this._configData; }
            set { this._configData = value; }
        }

        // Check to see if ConfigData property is set
        internal bool IsSetConfigData()
        {
            return this._configData != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigId. 
        /// <para>
        /// UUID of a <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Type of a <c>Config</c>.
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of a <c>Config</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

    }
}