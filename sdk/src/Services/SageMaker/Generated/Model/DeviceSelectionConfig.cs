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
    /// Contains information about the configurations of selected devices.
    /// </summary>
    public partial class DeviceSelectionConfig
    {
        private string _deviceNameContains;
        private List<string> _deviceNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DeviceSubsetType _deviceSubsetType;
        private int? _percentage;

        /// <summary>
        /// Gets and sets the property DeviceNameContains. 
        /// <para>
        /// A filter to select devices with names containing this name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DeviceNameContains
        {
            get { return this._deviceNameContains; }
            set { this._deviceNameContains = value; }
        }

        // Check to see if DeviceNameContains property is set
        internal bool IsSetDeviceNameContains()
        {
            return this._deviceNameContains != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceNames. 
        /// <para>
        /// List of devices chosen to deploy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeviceNames
        {
            get { return this._deviceNames; }
            set { this._deviceNames = value; }
        }

        // Check to see if DeviceNames property is set
        internal bool IsSetDeviceNames()
        {
            return this._deviceNames != null && (this._deviceNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeviceSubsetType. 
        /// <para>
        /// Type of device subsets to deploy to the current stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeviceSubsetType DeviceSubsetType
        {
            get { return this._deviceSubsetType; }
            set { this._deviceSubsetType = value; }
        }

        // Check to see if DeviceSubsetType property is set
        internal bool IsSetDeviceSubsetType()
        {
            return this._deviceSubsetType != null;
        }

        /// <summary>
        /// Gets and sets the property Percentage. 
        /// <para>
        /// Percentage of devices in the fleet to deploy to the current stage.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public int? Percentage
        {
            get { return this._percentage; }
            set { this._percentage = value; }
        }

        // Check to see if Percentage property is set
        internal bool IsSetPercentage()
        {
            return this._percentage.HasValue; 
        }

    }
}