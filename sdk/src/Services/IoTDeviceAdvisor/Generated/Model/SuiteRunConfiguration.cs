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
    /// Gets suite run configuration.
    /// </summary>
    public partial class SuiteRunConfiguration
    {
        private DeviceUnderTest _primaryDevice;
        private DeviceUnderTest _secondaryDevice;
        private List<string> _selectedTestList = new List<string>();

        /// <summary>
        /// Gets and sets the property PrimaryDevice. 
        /// <para>
        /// Gets the primary device for suite run.
        /// </para>
        /// </summary>
        public DeviceUnderTest PrimaryDevice
        {
            get { return this._primaryDevice; }
            set { this._primaryDevice = value; }
        }

        // Check to see if PrimaryDevice property is set
        internal bool IsSetPrimaryDevice()
        {
            return this._primaryDevice != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryDevice. 
        /// <para>
        /// Gets the secondary device for suite run.
        /// </para>
        /// </summary>
        public DeviceUnderTest SecondaryDevice
        {
            get { return this._secondaryDevice; }
            set { this._secondaryDevice = value; }
        }

        // Check to see if SecondaryDevice property is set
        internal bool IsSetSecondaryDevice()
        {
            return this._secondaryDevice != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedTestList. 
        /// <para>
        /// Gets test case list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> SelectedTestList
        {
            get { return this._selectedTestList; }
            set { this._selectedTestList = value; }
        }

        // Check to see if SelectedTestList property is set
        internal bool IsSetSelectedTestList()
        {
            return this._selectedTestList != null && this._selectedTestList.Count > 0; 
        }

    }
}