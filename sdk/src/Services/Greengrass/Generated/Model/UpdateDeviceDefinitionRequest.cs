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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDeviceDefinition operation.
    /// Updates a device definition.
    /// </summary>
    public partial class UpdateDeviceDefinitionRequest : AmazonGreengrassRequest
    {
        private string _deviceDefinitionId;
        private string _name;

        /// <summary>
        /// Gets and sets the property DeviceDefinitionId. The ID of the device definition.
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeviceDefinitionId
        {
            get { return this._deviceDefinitionId; }
            set { this._deviceDefinitionId = value; }
        }

        // Check to see if DeviceDefinitionId property is set
        internal bool IsSetDeviceDefinitionId()
        {
            return this._deviceDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the definition.
        /// </summary>
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