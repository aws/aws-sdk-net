/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// This is the response object from the ListDeviceInstances operation.
    /// </summary>
    public partial class ListDeviceInstancesResponse : AmazonWebServiceResponse
    {
        private List<DeviceInstance> _deviceInstances = new List<DeviceInstance>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DeviceInstances. 
        /// <para>
        /// An object containing information about your device instances.
        /// </para>
        /// </summary>
        public List<DeviceInstance> DeviceInstances
        {
            get { return this._deviceInstances; }
            set { this._deviceInstances = value; }
        }

        // Check to see if DeviceInstances property is set
        internal bool IsSetDeviceInstances()
        {
            return this._deviceInstances != null && this._deviceInstances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that can be used in the next call to this operation to return the next
        /// set of items in the list.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}