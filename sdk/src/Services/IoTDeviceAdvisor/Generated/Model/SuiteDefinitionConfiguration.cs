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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// Gets Suite Definition Configuration.
    /// </summary>
    public partial class SuiteDefinitionConfiguration
    {
        private string _devicePermissionRoleArn;
        private List<DeviceUnderTest> _devices = new List<DeviceUnderTest>();
        private bool? _intendedForQualification;
        private string _rootGroup;
        private string _suiteDefinitionName;

        /// <summary>
        /// Gets and sets the property DevicePermissionRoleArn. 
        /// <para>
        /// Gets device permission arn.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DevicePermissionRoleArn
        {
            get { return this._devicePermissionRoleArn; }
            set { this._devicePermissionRoleArn = value; }
        }

        // Check to see if DevicePermissionRoleArn property is set
        internal bool IsSetDevicePermissionRoleArn()
        {
            return this._devicePermissionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Devices. 
        /// <para>
        /// Gets the devices configured.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<DeviceUnderTest> Devices
        {
            get { return this._devices; }
            set { this._devices = value; }
        }

        // Check to see if Devices property is set
        internal bool IsSetDevices()
        {
            return this._devices != null && this._devices.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IntendedForQualification. 
        /// <para>
        /// Gets the tests intended for qualification in a suite.
        /// </para>
        /// </summary>
        public bool IntendedForQualification
        {
            get { return this._intendedForQualification.GetValueOrDefault(); }
            set { this._intendedForQualification = value; }
        }

        // Check to see if IntendedForQualification property is set
        internal bool IsSetIntendedForQualification()
        {
            return this._intendedForQualification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RootGroup. 
        /// <para>
        /// Gets test suite root group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RootGroup
        {
            get { return this._rootGroup; }
            set { this._rootGroup = value; }
        }

        // Check to see if RootGroup property is set
        internal bool IsSetRootGroup()
        {
            return this._rootGroup != null;
        }

        /// <summary>
        /// Gets and sets the property SuiteDefinitionName. 
        /// <para>
        /// Gets Suite Definition Configuration name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SuiteDefinitionName
        {
            get { return this._suiteDefinitionName; }
            set { this._suiteDefinitionName = value; }
        }

        // Check to see if SuiteDefinitionName property is set
        internal bool IsSetSuiteDefinitionName()
        {
            return this._suiteDefinitionName != null;
        }

    }
}