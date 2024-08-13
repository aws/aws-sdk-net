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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDeviceFleet operation.
    /// Updates a fleet of devices.
    /// </summary>
    public partial class UpdateDeviceFleetRequest : AmazonSageMakerRequest
    {
        private string _description;
        private string _deviceFleetName;
        private bool? _enableIotRoleAlias;
        private EdgeOutputConfig _outputConfig;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=800)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The name of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DeviceFleetName
        {
            get { return this._deviceFleetName; }
            set { this._deviceFleetName = value; }
        }

        // Check to see if DeviceFleetName property is set
        internal bool IsSetDeviceFleetName()
        {
            return this._deviceFleetName != null;
        }

        /// <summary>
        /// Gets and sets the property EnableIotRoleAlias. 
        /// <para>
        /// Whether to create an Amazon Web Services IoT Role Alias during device fleet creation.
        /// The name of the role alias generated will match this pattern: "SageMakerEdge-{DeviceFleetName}".
        /// </para>
        ///  
        /// <para>
        /// For example, if your device fleet is called "demo-fleet", the name of the role alias
        /// will be "SageMakerEdge-demo-fleet".
        /// </para>
        /// </summary>
        public bool? EnableIotRoleAlias
        {
            get { return this._enableIotRoleAlias; }
            set { this._enableIotRoleAlias = value; }
        }

        // Check to see if EnableIotRoleAlias property is set
        internal bool IsSetEnableIotRoleAlias()
        {
            return this._enableIotRoleAlias.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Output configuration for storing sample data collected by the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EdgeOutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}